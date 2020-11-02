using AdvertisingAgency.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvertisingAgency.Forms.TablesForms
{
    public partial class ClientsForm : Form
    {
        private readonly List<TextBox> TextBoxes;
        private DataBaseManager Manager;
        public ClientsForm(string connectionString)
        {
            InitializeComponent();

            Manager = new DataBaseManager(connectionString);
            UpdateClientsTable();

            TextBoxes = GetInputTextBoxes();
        }

        private List<TextBox> GetInputTextBoxes()
        {
            return new List<TextBox>()
            {
                ClientCodeTextBox,
                DepartmentTextBox,
                SurnameTextBox,
                NameTextBox,
                PatronymicTextBox,
                CityTextBox,
                AdressTextBox,
                PhoneNumberTextBox
            };
        }

        private void UpdateClientsTable()
        {
            try
            {
                ClientsTable.DataSource = Manager.GetTable("Клиенты");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientsTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            DocumentPrinter.DefaultPageSettings.Landscape = true;
            DocumentPrinter.DocumentName = "Таблица \"Клиенты\"";
            dialog.Document = DocumentPrinter;
            dialog.ShowDialog();
        }

        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            SearchNameTextBox.Enabled = !SearchNameTextBox.Enabled;
            SearchButton.Enabled = !SearchButton.Enabled;
        }

        private void ClientsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ClientsTable.Rows.Count - 1)
            {
                DataGridViewRow row = ClientsTable.Rows[e.RowIndex];
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

                Manager.UpdateClientsTable(list);
                UpdateClientsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateClientsTable();
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

                Manager.AddClient(list);
                UpdateClientsTable();
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
                    Manager.DeleteClient(Convert.ToInt32(TextBoxes[0].Text));
                    UpdateClientsTable();
                }
                else MessageBox.Show("Выберете строку!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap obj = new Bitmap(ClientsTable.Width, ClientsTable.Height);
            ClientsTable.DrawToBitmap(obj, new Rectangle(0, 0, ClientsTable.Width, ClientsTable.Height));
            e.Graphics.DrawImage(obj, 100, 100);
        }

        private void ClientCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchNameTextBox.Text != string.Empty)
            {
                ClientsTable.DataSource = Manager.Search
                    (
                        tableName: "Клиенты",
                        columnName: "Имя",
                        value: SearchNameTextBox.Text
                    );
            }
            else MessageBox.Show("Поисковая строка пуста!");
        }

        private void SortByNameButton_Click(object sender, EventArgs e)
        {
            ClientsTable.Sort(ClientsTable.Columns["Имя"], ListSortDirection.Ascending);
        }

        private void CodeMoreThan2Button_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Клиенты WHERE КодКлиента > " + 2;
            ClientsTable.DataSource = Manager.MakeSQLRequest(query);
        }

        private void SortBySurnameButton_Click(object sender, EventArgs e)
        {
            ClientsTable.Sort(ClientsTable.Columns["Фамилия"], ListSortDirection.Ascending);
        }

        private void SortByCityButton_Click(object sender, EventArgs e)
        {
            ClientsTable.Sort(ClientsTable.Columns["Город"], ListSortDirection.Ascending);
        }
    }
}
