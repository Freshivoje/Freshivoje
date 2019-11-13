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
                    string text = string.Empty;
                    foreach(string column in columns)
                    {
                        if(column == columns[0])
                        {
                            continue;
                        }
                        text += $"{ reader.GetString(column)} / ";
                    }
                    text = text.Trim(' ', '/');
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Value = reader.GetInt32(columns[0]),
                        Text = text
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

        public static void executeTransportQuery(List<TransportItem> transportItems, int clientId)
        {
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = _databaseConnection;
            _databaseConnection.Open();

            MySqlTransaction transaction = _databaseConnection.BeginTransaction();
            mySqlCommand.Transaction = transaction;

            try
            {
                mySqlCommand.CommandText = "SELECT `transport_number` FROM `transport` ORDER BY `transport_number` DESC LIMIT 1";

                int? transportNumber = (int) mySqlCommand.ExecuteScalar();
                if (transportNumber == null)
                {
                    transportNumber = 0;
                }

                transportNumber += 1;

                mySqlCommand.CommandText = "INSERT INTO `transport` (`fk_client_id`, `transport_number`) VALUES (@clientId, @transportNumber); SELECT LAST_INSERT_ID()";
                mySqlCommand.Parameters.AddWithValue("@clientId", clientId);
                mySqlCommand.Parameters.AddWithValue("@transportNumber", transportNumber);
             
                dynamic transportId = mySqlCommand.ExecuteScalar();

                mySqlCommand.Parameters.Clear();

                mySqlCommand.CommandText = "INSERT INTO `transport_items` (`fk_transport_id`, `price`, `quantity`, `traveled`) VALUES ( @fkTransportId, @price, @quantity, @traveled)";
                foreach (TransportItem item in transportItems)
                {
                    mySqlCommand.Parameters.AddWithValue("@fkTransportId", transportId);
                    mySqlCommand.Parameters.AddWithValue("@price", item._price);
                    mySqlCommand.Parameters.AddWithValue("@quantity", item._quantity);
                    mySqlCommand.Parameters.AddWithValue("@traveled", item._traveled);

                    mySqlCommand.ExecuteNonQuery();

                    mySqlCommand.Parameters.Clear();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _databaseConnection.Close();
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
    }
}
