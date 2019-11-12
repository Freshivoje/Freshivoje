using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using MySql.Data.MySqlClient;
using Freshivoje.Models;
using System.Collections.Generic;

namespace Freshivoje
{
    public static class DbConnection
    {
        private static readonly string _dataSource = "localhost";
        private static readonly string _port = "3306";
        private static readonly string _database = "freshivoje";
        private static readonly string _username = "root";
        //private static string password = "";
        private static readonly string _connectionString = $"datasource={_dataSource};port={_port};database={_database};username={_username}";
        public static readonly MySqlConnection _databaseConnection = new MySqlConnection(_connectionString);

        public static void fillCmbBox(ComboBox cmbBox, string table, params string[] columns)
        {
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = $"SELECT * FROM `{table}`";
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Value = reader.GetInt32(columns[0]),
                        Text = reader.GetString(columns[1])
                    };
                    cmbBox.Items.Add(item);
                }
            }
            catch
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }
        }

        public static void executeQuery(MySqlCommand mySqlCommand)
        {
            try
            {
                mySqlCommand.Connection = _databaseConnection;
                _databaseConnection.Open();
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }
        }

        public static void executeTransportQuery(List<TransportItems> transportItems)
        {
            _databaseConnection.Open();
            MySqlTransaction transaction = _databaseConnection.BeginTransaction();
            try
            {

                MySqlCommand mySqlCommand2 = new MySqlCommand();
                mySqlCommand2.CommandText = "SELECT transport_number FROM transport ORDER BY id_transport DESC LIMIT 1";
                mySqlCommand2.Connection = _databaseConnection;
                mySqlCommand2.Transaction = transaction;

                dynamic transportNumber = mySqlCommand2.ExecuteScalar();
                if (transportNumber == null) transportNumber = 0;
                transportNumber += 1;

                MySqlCommand mySqlCommand1 = new MySqlCommand();

                DateTime today = DateTime.Today;
                string date = today.ToString("yyyy-MM-dd");
                mySqlCommand1.CommandText = @"INSERT INTO `transport` (`fk_client_id`, `transport_number`, `transport_date`, `transport_year`, `transport_status`) VALUES (@clientId, @transportNumber, @transportDate, @transportYear, @transportStatus); SELECT LAST_INSERT_ID()";
                mySqlCommand1.Connection = _databaseConnection;
                mySqlCommand1.Transaction = transaction;
                mySqlCommand1.Parameters.AddWithValue("@clientId", transportItems[0]._clientId);
                mySqlCommand1.Parameters.AddWithValue("@transportNumber", transportNumber);
                mySqlCommand1.Parameters.AddWithValue("@transportDate",date);
                mySqlCommand1.Parameters.AddWithValue("@transportYear", today.ToString("yyyy"));
                mySqlCommand1.Parameters.AddWithValue("@transportStatus", 1);


                dynamic transportId = mySqlCommand1.ExecuteScalar();


                for (int i = 0; i < transportItems.Count; i++)
                {

                    string query = "INSERT INTO `transport_items` (`fk_transport_id`, `price`, `quantity`, `traveled`) VALUES ( @fkTransportId, @price, @quantity, @travel)";
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    mySqlCommand.Connection = _databaseConnection;
                    mySqlCommand.CommandText = query;
                    mySqlCommand.Transaction = transaction;
                    mySqlCommand.Parameters.AddWithValue("@fkTransportId", transportId);
                    mySqlCommand.Parameters.AddWithValue("@price", transportItems[i]._price);
                    mySqlCommand.Parameters.AddWithValue("@quantity", transportItems[i]._quantity);
                    mySqlCommand.Parameters.AddWithValue("@travel", transportItems[i]._traveled);
              

                    int result = mySqlCommand.ExecuteNonQuery();
                    if (result <= 0)
                    {
                        throw new InvalidProgramException();
                    }
                }
                transaction.Commit();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                DbConnection._databaseConnection.Close();
            }
        }


        public static void fillDGV(DataGridView dataGridView, string query)
        {
            DataTable table = new DataTable();
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                table.Load(reader);
                dataGridView.DataSource = table;
            }
            catch
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }
        } 
        public static void deleteFromDB(string table, string columnName, int? id)
        {
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = $"DELETE FROM {table} WHERE {columnName} = @id";
                mySqlCommand.Parameters.AddWithValue("@id", id);
                mySqlCommand.ExecuteScalar();
            }
            catch
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }

        }

        public static dynamic getValue(MySqlCommand mySqlCommand)
        {
            dynamic value = 0;
            try
            {
                mySqlCommand.Connection = _databaseConnection;
                _databaseConnection.Open();
                value = mySqlCommand.ExecuteScalar();
            }
            catch
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return -1;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }
            return value;
        }

        public static dynamic getQuery(MySqlCommand mySqlCommand)
        {
            dynamic value = null;
            try
            {
                mySqlCommand.Connection = _databaseConnection;
                _databaseConnection.Open();
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                reader.Read();
                value = reader.GetString(0);
            }
            catch
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return -1;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }
            return value;
        }
        public static dynamic getQueryValues(MySqlCommand mySqlCommand)
        {
            dynamic value = null;
            try
            {
                mySqlCommand.Connection = _databaseConnection;
                _databaseConnection.Open();
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                reader.Read();
                value = reader.GetString(0) + "," + reader.GetString(1) + "," + reader.GetString(2);
            }
            catch
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return -1;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }
            return value;
        }

        public static void fillCustomCmbBox(ComboBox cmbBox, string table, params string[] columns)
        {
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = $"SELECT * FROM `{table}`";
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Value = reader.GetInt32(columns[0]),
                        Text = reader.GetString(columns[1]) + " / " + reader.GetString(columns[2]) + " / " + reader.GetString(columns[3])
                    };
                    cmbBox.Items.Add(item);
                }
            }
            catch
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
            }
            finally
            {
                _databaseConnection.Close();
            }
        }
    }
}
