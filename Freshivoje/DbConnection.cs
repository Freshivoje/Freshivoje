using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using MySql.Data.MySqlClient;

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
        private static readonly MySqlConnection _databaseConnection = new MySqlConnection(_connectionString);

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
                //reader.Read();
                return reader;
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
