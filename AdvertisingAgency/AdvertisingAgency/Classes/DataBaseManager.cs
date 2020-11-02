using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AdvertisingAgency.Classes
{
    class DataBaseManager
    {
        private readonly string ConnectionString;
        private OleDbConnection Connection;

        /// <summary>
        /// Конструктор класса DataBaseManager
        /// </summary>
        /// <param name="connectionString">Строка подключения БД</param>
        public DataBaseManager(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new OleDbConnection(connectionString);
        }

        #region Методы для таблицы "Клиенты"

        /// <summary>
        /// Обновить данные клиента
        /// </summary>
        /// <param name="args">Поля клиента</param>
        public void UpdateClientsTable(List<string> args)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"UPDATE Клиенты SET ОрганизацияИлиОтдел = '{args[1]}', Фамилия = '{args[2]}', Имя = '{args[3]}', " +
                    $"Отчество = '{args[4]}', Город = '{args[5]}', Адрес = '{args[6]}', Телефон = '{args[7]}' " +
                    $"WHERE КодКлиента = " + Convert.ToInt32(args[0]) + ";";

                OleDbCommand cmd = new OleDbCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
                Connection.Close();
            }
        }

        /// <summary>
        /// Добавить клиента
        /// </summary>
        /// <param name="args">Поля нового клиента</param>
        public void AddClient(List<string> args)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"INSERT INTO Клиенты (КодКлиента, ОрганизацияИлиОтдел, Фамилия, Имя, Отчество, Город, Адрес, Телефон)" +
                      $" VALUES(" + Convert.ToInt32(args[0]) + ",'" + args[1] + "', '" + args[2] + "', '" + args[3] + "', '" + args[4] + "', '" + args[5] + "', '" + args[6] + "', '" + args[7] + "');";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено");

                Connection.Close();
            }
        }

        /// <summary>
        /// Удалить клиента по ID
        /// </summary>
        /// <param name="clientCode">id клиента</param>
        public void DeleteClient(int clientCode)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = "DELETE FROM Клиенты WHERE КодКлиента = " + clientCode;
                OleDbCommand DBcommand = new OleDbCommand(query, Connection);
                DBcommand.ExecuteNonQuery();
                MessageBox.Show("Клиент удалён");
                Connection.Close();
            }
        }

        #endregion Методы для таблицы "Клиенты"

        #region Методы для таблицы "Сотрудники"

        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        /// <param name="args">Поля</param>
        public void AddCooperator(List<string> args)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"INSERT INTO Сотрудники (КодСотрудника, Фамилия, Имя, Отчество, Должность, Телефон)" +
                       $" VALUES(" + Convert.ToInt32(args[0]) + ",'" + args[1] + "', '" + args[2] + "', '" + args[3] + "', '" + args[4] + "', '" + args[5] + "');";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено");

                Connection.Close();
            }
        }

        /// <summary>
        /// Обновить данные сотрудника
        /// </summary>
        /// <param name="args">Поля</param>
        public void UpdateCooperatorsTable(List<string> args)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"UPDATE Сотрудники SET Фамилия = '{args[1]}', Имя = '{args[2]}', Отчество = '{args[3]}', " +
                    $"Должность = '{args[4]}', Телефон = '{args[5]}' WHERE КодСотрудника = " + args[0];

                OleDbCommand cmd = new OleDbCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
                Connection.Close();
            }
        }

        /// <summary>
        /// Удалить сотрудника по ID
        /// </summary>
        /// <param name="CooperatorCode">- ID/КодСотрудника</param>
        public void DeleteCooperator(int CooperatorCode)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = "DELETE FROM Сотрудники WHERE КодСотрудника = " + CooperatorCode;
                OleDbCommand DBcommand = new OleDbCommand(query, Connection);
                DBcommand.ExecuteNonQuery();
                MessageBox.Show("Сотрудник удалён");
                Connection.Close();
            }
        }

        #endregion Методы для таблицы "Сотрудники"

        #region Методы для таблицы "Заказы"

        /// <summary>
        /// Изменить заказ
        /// </summary>
        /// <param name="args">Поля заказа</param>
        public void UpdateOrdersTable(List<string> args, DateTimePicker date, bool isDone)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"UPDATE Заказы SET Дата = '{date.Value}', НазваниеУслуги = '{args[1]}', КодКлиента = {Convert.ToInt32(args[2])}," +
                    $" КодСотрудника = {Convert.ToInt32(args[3])}, Выполнено = {isDone}" +
                    $" WHERE НомерЗаказа = " + Convert.ToInt32(args[0]) + ";";

                OleDbCommand cmd = new OleDbCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
                Connection.Close();
            }
        }

        /// <summary>
        /// Добавить заказ
        /// </summary>
        /// <param name="args">Поля нового заказа</param>
        public void AddOrder(List<string> args, DateTimePicker date, bool isDone)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"INSERT INTO Заказы (НомерЗаказа, Дата, НазваниеУслуги, КодКлиента, КодСотрудника, Выполнено)" +
                      $" VALUES(" + Convert.ToInt32(args[0]) + ",'" + date.Value + "', '" + args[1] + "', " + Convert.ToInt32(args[2]) + ", " + Convert.ToInt32(args[3]) +
                      ", " + isDone + ");";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено");

                Connection.Close();
            }
        }

        /// <summary>
        /// Удалить заказ по ID
        /// </summary>
        /// <param name="clientCode">id заказа</param>
        public void DeleteOrder(int orderCode)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = "DELETE FROM Заказы WHERE НомерЗаказа = " + orderCode;
                OleDbCommand DBcommand = new OleDbCommand(query, Connection);
                DBcommand.ExecuteNonQuery();
                MessageBox.Show("Заказ удалён");
                Connection.Close();
            }
        }

        #endregion Методы для таблицы "Заказы"

        #region Методы для таблицы "Услуги"
        
        public void AddService(List<string> args)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"INSERT INTO Услуги (НазваниеУслуги, Стоимость)" +
                      $" VALUES('" + args[0] + "'," + Convert.ToDecimal(args[1]) + ");";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено");

                Connection.Close();
            }
        }

        public void UpdateServiceTable(List<string> args)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = $"UPDATE Услуги SET Стоимость = {Convert.ToDecimal(args[1])}" +
                    $" WHERE НазваниеУслуги = '" + args[0] + "';";

                OleDbCommand cmd = new OleDbCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные изменены");
                Connection.Close();
            }
        }

        public void DeleteService(string serviceName)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = "DELETE FROM Услуги WHERE НазваниеУслуги = '" + serviceName + "'";
                OleDbCommand DBcommand = new OleDbCommand(query, Connection);
                DBcommand.ExecuteNonQuery();
                MessageBox.Show("Услуга удалена");
                Connection.Close();
            }
        }
            
        #endregion Методы для таблицы "Услуги"

        #region Общие методы

        /// <summary>
        /// Проверка подключения
        /// </summary>
        /// <param name="connectionString">Стока подключения</param>
        /// <returns>true - да, false - нет</returns>
        public static bool CheckConnection(string connectionString)
        {
            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Существует ли указанная таблица
        /// </summary>
        /// <param name="tableName">Название таблицы в БД</param>
        /// <returns>true - да, false - нет</returns>
        public static bool CheckTableExists(string connectionString, string tableName)
        {
            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM " + tableName;
                    OleDbCommand DBcommand = new OleDbCommand(query, connection);
                    DBcommand.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Выполнение SQL запроса
        /// </summary>
        /// <param name="query">SQL запрос</param>
        /// <returns>Таблица - результат запрос</returns>
        public DataTable MakeSQLRequest(string query)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();

                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                DataTable result = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(result);

                Connection.Close();
                return result;
            }
        }

        /// <summary>
        /// Получить таблицу
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <returns>таблица типа System.Data.DataTable</returns>
        public DataTable GetTable(string tableName)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();
                string query = "SELECT * FROM " + tableName;
                OleDbCommand DBcommand = new OleDbCommand(query, Connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(DBcommand);
                DataTable result = new DataTable(tableName);
                adapter.Fill(result);
                Connection.Close();
                return result;
            }
        }

        /// <summary>
        /// Поиск с учётом таблицы и столбца
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <param name="columnName">Название столбца</param>
        /// <param name="value">Значение, по которому происходит отбор</param>
        /// <returns></returns>
        public DataTable Search(string tableName, string columnName, string value)
        {
            using (Connection = new OleDbConnection(ConnectionString))
            {
                Connection.Open();

                string query = "SELECT* FROM " + tableName + " WHERE " + columnName + " LIKE '" + value + "'";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                DataTable result = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(result);

                Connection.Close();
                return result;
            }
        }

        #endregion Общие методы
    }
}
