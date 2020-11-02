using AdvertisingAgency.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvertisingAgency.Forms.Tables
{
    public partial class CooperatorsForm : Form
    {
        private readonly List<TextBox> TextBoxes;
        private DataBaseManager Manager;
        public CooperatorsForm(string connectionString)
        {
            InitializeComponent();

            Manager = new DataBaseManager(connectionString);
            UpdateCooperatorsTable();

            TextBoxes = GetInputTextBoxes();
        }

        private List<TextBox> GetInputTextBoxes()
        {
            return new List<TextBox>()
            {
                CooperatorCodeTextBox,
                SurnameTextBox,
                NameTextBox,
                PatronymicTextBox,
                PositionTextBox,
                PhoneNumberTextBox
            };
        }

        private void UpdateCooperatorsTable()
        {
            try
            {
                CooperatorsTable.DataSource = Manager.GetTable("Сотрудники");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            DocumentPrinter.DefaultPageSettings.Landscape = true;
            DocumentPrinter.DocumentName = "Таблица \"Сотрудники\"";
            dialog.Document = DocumentPrinter;
            dialog.ShowDialog();
        }

        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            SearchNameTextBox.Enabled = !SearchNameTextBox.Enabled;
            SearchButton.Enabled = !SearchButton.Enabled;
        }

        private void CooperatorsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CooperatorsTable.Rows.Count - 1)
            {
                DataGridViewRow row = CooperatorsTable.Rows[e.RowIndex];
                for (int i = 0; i < TextBoxes.Count; i++)
                {
                    TextBoxes[i].Text = row.Cells[i].Value.ToString();
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на наличие пустых строк при заполнении
                if (!InputIsValid())
                {
                    return;
                }

                var list = new List<string>();
                for (int i = 0; i < TextBoxes.Count; i++)
                    list.Add(TextBoxes[i].Text);

                Manager.UpdateCooperatorsTable(list);
                UpdateCooperatorsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool InputIsValid()
        {
            // Проверка на наличие пустых строк при заполнении
            foreach (var item in TextBoxes)
                if (item.Text == string.Empty)
                {
                    MessageBox.Show("Проверьте данные!");
                    return false;
                }
            return true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateCooperatorsTable();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на наличие пустых строк при заполнении
                if (!InputIsValid())
                {
                    return;
                }

                var list = new List<string>();
                for (int i = 0; i < TextBoxes.Count; i++)
                    list.Add(TextBoxes[i].Text);

                Manager.AddCooperator(list);
                UpdateCooperatorsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxes[0].Text != string.Empty)
                {
                    Manager.DeleteCooperator(CooperatorCode: Convert.ToInt32(TextBoxes[0].Text));
                    UpdateCooperatorsTable();
                }
                else MessageBox.Show("Выберете строку!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DocumentPrinter_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap obj = new Bitmap(CooperatorsTable.Width, CooperatorsTable.Height);
            CooperatorsTable.DrawToBitmap(obj, new Rectangle(0, 0, CooperatorsTable.Width, CooperatorsTable.Height));
            e.Graphics.DrawImage(obj, 100, 100);
        }

        private void CooperatorCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchNameTextBox.Text != string.Empty)
            {
                CooperatorsTable.DataSource = Manager.Search
                    (
                        tableName: "Сотрудники",
                        columnName: "Имя",
                        value: SearchNameTextBox.Text
                    );
            }
            else MessageBox.Show("Поисковая строка пуста!");
        }

        private void SortByNameButton_Click(object sender, EventArgs e)
        {
            CooperatorsTable.Sort(CooperatorsTable.Columns["Имя"], ListSortDirection.Ascending);
        }

        private void SortBySurnameButton_Click(object sender, EventArgs e)
        {
            CooperatorsTable.Sort(CooperatorsTable.Columns["Фамилия"], ListSortDirection.Ascending);
        }

        private void SortByPositionButton_Click(object sender, EventArgs e)
        {
            CooperatorsTable.Sort(CooperatorsTable.Columns["Должность"], ListSortDirection.Ascending);
        }

        private void ShowManagersButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Сотрудники WHERE Должность LIKE 'менеджер'";
            CooperatorsTable.DataSource = Manager.MakeSQLRequest(query);
        }
    }
}
