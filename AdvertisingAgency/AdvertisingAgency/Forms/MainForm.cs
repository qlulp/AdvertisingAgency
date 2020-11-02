using AdvertisingAgency.Classes;
using AdvertisingAgency.Forms.Tables;
using AdvertisingAgency.Forms.TablesForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvertisingAgency
{
    public partial class MainForm : Form
    {
        // Название Базы Данных: "AdvertisingAgency";
        // Строка подключения
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\AdvertisingAgencyDB.mdb
        private readonly string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AdvertisingAgencyDB.mdb";

        // Формы - таблицы
        ClientsForm Clients;
        ServicesForm Services;
        CooperatorsForm Cooperators;
        OrdersForm Orders;

        public MainForm()
        {
            InitializeComponent();

            if (DataBaseManager.CheckConnection(ConnectionString))
            {
                OrdersButton.Enabled = true;
                CooperatorsButton.Enabled = true;
                ServicesButton.Enabled = true;
                ClientsButton.Enabled = true;
            }
            else
            {
                OrdersButton.Enabled = false;
                CooperatorsButton.Enabled = false;
                ServicesButton.Enabled = false;
                ClientsButton.Enabled = false;
                MessageBox.Show("База данных отсутствует или указаны неверные данные!");
            }
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            if (DataBaseManager.CheckTableExists(ConnectionString, "Клиенты"))
            {
                Clients = new ClientsForm(ConnectionString);
                Clients.Show();
            }
            else
                MessageBox.Show("Данной таблицы не существует!");
        }

        private void CooperatorsButton_Click(object sender, EventArgs e)
        {
            if (DataBaseManager.CheckTableExists(ConnectionString, "Сотрудники"))
            {
                Cooperators = new CooperatorsForm(ConnectionString);
                Cooperators.Show();
            }
            else
                MessageBox.Show("Данной таблицы не существует!");
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            if (DataBaseManager.CheckTableExists(ConnectionString, "Заказы"))
            {
                Orders = new OrdersForm(ConnectionString);
                Orders.Show();
            }
            else
                MessageBox.Show("Данной таблицы не существует!");
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            if (DataBaseManager.CheckTableExists(ConnectionString, "Услуги"))
            {
                Services = new ServicesForm(ConnectionString);
                Services.Show();
            }
            else
                MessageBox.Show("Данной таблицы не существует!");
        }
    }
}
