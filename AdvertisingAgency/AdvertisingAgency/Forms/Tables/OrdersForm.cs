using AdvertisingAgency.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvertisingAgency.Forms.Tables
{
    public partial class OrdersForm : Form
    {
        private readonly List<TextBox> TextBoxes;
        private DataBaseManager Manager;

        public OrdersForm(string connectionString)
        {
            InitializeComponent();

            Manager = new DataBaseManager(connectionString);
            UpdateOrdersTable();

            TextBoxes = GetInputTextBoxes();
        }

        private List<TextBox> GetInputTextBoxes()
        {
            return new List<TextBox>()
            {
                OrderCodeTextBox,
                ServiceNameTextBox,
                ClientCodeTextBox,
                CooperatorCodeTextBox
            };
        }

        private void UpdateOrdersTable()
        {
            try
            {
                OrdersTable.DataSource = Manager.GetTable("Заказы");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void ClientCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CooperatorCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            DocumentPrinter.DocumentName = "Таблица \"Заказы\"";
            dialog.Document = DocumentPrinter;
            dialog.ShowDialog();
        }

        private void SearchByOrderCodeButton_Click(object sender, EventArgs e)
        {
            SearchNameTextBox.Enabled = !SearchNameTextBox.Enabled;
            SearchButton.Enabled = !SearchButton.Enabled;
        }

        private void OrdersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < OrdersTable.Rows.Count - 1)
            {
                DataGridViewRow row = OrdersTable.Rows[e.RowIndex];
                TextBoxes[0].Text = row.Cells[0].Value.ToString();
                DateTimePicker.Text = row.Cells[1].Value.ToString();
                TextBoxes[1].Text = row.Cells[2].Value.ToString();
                TextBoxes[2].Text = row.Cells[3].Value.ToString();
                TextBoxes[3].Text = row.Cells[4].Value.ToString();
                DoneCheckBox.Checked = bool.Parse(row.Cells[row.Cells.Count - 1].Value.ToString());
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

                Manager.UpdateOrdersTable(list, DateTimePicker, DoneCheckBox.Checked);
                UpdateOrdersTable();
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
            UpdateOrdersTable();
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

                Manager.AddOrder(list, DateTimePicker, DoneCheckBox.Checked);
                UpdateOrdersTable();
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
                    Manager.DeleteOrder(orderCode: Convert.ToInt32(TextBoxes[0].Text));
                    UpdateOrdersTable();
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
            Bitmap obj = new Bitmap(OrdersTable.Width, OrdersTable.Height);
            OrdersTable.DrawToBitmap(obj, new Rectangle(0, 0, OrdersTable.Width, OrdersTable.Height));
            e.Graphics.DrawImage(obj, 100, 100);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchNameTextBox.Text != string.Empty)
            {
                OrdersTable.DataSource = Manager.Search
                    (
                        tableName: "Заказы",
                        columnName: "НомерЗаказа",
                        value: SearchNameTextBox.Text
                    );
            }
            else MessageBox.Show("Поисковая строка пуста!");
        }

        private void SortByDateButton_Click(object sender, EventArgs e)
        {
            OrdersTable.Sort(OrdersTable.Columns["Дата"], ListSortDirection.Ascending);
        }

        private void SortByServiceNameButton_Click(object sender, EventArgs e)
        {
            OrdersTable.Sort(OrdersTable.Columns["НазваниеУслуги"], ListSortDirection.Ascending);
        }

        private void ShowDoneOrderssButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Заказы WHERE Выполнено LIKE true";
            OrdersTable.DataSource = Manager.MakeSQLRequest(query);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
