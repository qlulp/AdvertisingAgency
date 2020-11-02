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
    public partial class ServicesForm : Form
    {
        private readonly List<TextBox> TextBoxes;
        private DataBaseManager Manager;

        public ServicesForm(string connectionString)
        {
            InitializeComponent();

            Manager = new DataBaseManager(connectionString);
            UpdateServicesTable();

            TextBoxes = GetInputTextBoxes();
        }

        private List<TextBox> GetInputTextBoxes()
        {
            return new List<TextBox>()
            {
                ServiceNameTextBox,
                ServicePriceTextBox,
            };
        }

        private void UpdateServicesTable()
        {
            try
            {
                ServicesTable.DataSource = Manager.GetTable("Услуги");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortByServiceNameButton_Click(object sender, EventArgs e)
        {
            ServicesTable.Sort(ServicesTable.Columns["НазваниеУслуги"], ListSortDirection.Ascending);
        }

        private void ServicePriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            DocumentPrinter.DefaultPageSettings.Landscape = true;
            DocumentPrinter.DocumentName = "Таблица \"Услуги\"";
            dialog.Document = DocumentPrinter;
            dialog.ShowDialog();
        }

        private void SearchByServiceNameButton_Click(object sender, EventArgs e)
        {
            SearchNameTextBox.Enabled = !SearchNameTextBox.Enabled;
            SearchButton.Enabled = !SearchButton.Enabled;
        }

        private void ServicesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ServicesTable.Rows.Count - 1)
            {
                DataGridViewRow row = ServicesTable.Rows[e.RowIndex];
                TextBoxes[0].Text = row.Cells[0].Value.ToString();
                TextBoxes[1].Text = row.Cells[1].Value.ToString();
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

                Manager.UpdateServiceTable(list);
                UpdateServicesTable();
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

                Manager.AddService(list);
                UpdateServicesTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateServicesTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxes[0].Text != string.Empty)
                {
                    Manager.DeleteService(TextBoxes[0].Text);
                    UpdateServicesTable();
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
            Bitmap obj = new Bitmap(ServicesTable.Width, ServicesTable.Height);
            ServicesTable.DrawToBitmap(obj, new Rectangle(0, 0, ServicesTable.Width, ServicesTable.Height));
            e.Graphics.DrawImage(obj, 100, 100);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchNameTextBox.Text != string.Empty)
            {
                ServicesTable.DataSource = Manager.Search
                    (
                        tableName: "Услуги",
                        columnName: "НазваниеУслуги",
                        value: SearchNameTextBox.Text
                    );
            }
            else MessageBox.Show("Поисковая строка пуста!");
        }

        private void SortByPriceButton_Click(object sender, EventArgs e)
        {
            ServicesTable.Sort(ServicesTable.Columns["Стоимость"], ListSortDirection.Ascending);
        }

        private void PriceMoreThan5000Button_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Услуги WHERE Стоимость >= 5000";
            ServicesTable.DataSource = Manager.MakeSQLRequest(query);
        }

        private void PriceLessThan5000Button_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Услуги WHERE Стоимость <= 5000";
            ServicesTable.DataSource = Manager.MakeSQLRequest(query);
        }
    }
}
