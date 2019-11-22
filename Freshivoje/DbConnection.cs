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
        private static readonly string _connectionString = $"datasource={_dataSource};port={_port};database={_database};username={_username};charset=utf8;";
        public static readonly MySqlConnection _databaseConnection = new MySqlConnection(_connectionString);

       
        public static void fillBtnText(Button button, string table, string position, params string[] columns)
        {
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = $"SELECT * FROM `{table}` WHERE storage_position='{position}'";
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if(reader.Read())
                {
                    string text = string.Empty;
                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "id_storage":
                                int _storageId = reader.GetInt32(column);
                                button.Tag = _storageId;
                                break;
                            case "storage_position":
                                text += $"{ reader.GetString(column)} \n ";
                                button.Text = text;
                                break;
                            case "article_quantity":
                                text += $"{ reader.GetString(column)} KG \n ";
                                button.Text = text;
                                break;
                            case "package_quantity":
                                text += $"{ reader.GetString(column)} BR \n ";
                                button.Text = text;
                                break;
                            case "status":
                                string test = reader.GetString(column);
                                if (test == "neaktivna")
                                {
                                    button.Enabled = false;
                                    button.Text = "Komora je izdata za lagerovanje";
                                }
                                break;
                            default:
                                
                                break;
                        }
                    }
                text = text.Trim(' ', '/');
                
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
        public static void fillCmbBox(ComboBox cmbBox, string table, char separator, params string[] columns)
        {
            string tables = string.Empty;
            foreach (string column in columns)
            {
                if (column == columns[0])
                {
                    continue;
                }
                tables += $"{ column}, ";
            }

            tables = tables.Trim(',', ' ');

            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = $"SELECT {columns[0]}, CONCAT_WS(' {separator} ', {tables}) as `details` FROM `{table}`";
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string text = reader.GetString("details");
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Value = reader.GetInt32(columns[0]),
                        Text = text
                    };
                    cmbBox.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
                throw e;
            }
            finally
            {
                _databaseConnection.Close();
            }
        }
        public static void tunnel(Label label, string query, params string[] columns)
        {

            try
            {
                
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string text = string.Empty;
                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "article_name":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "sort":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "organic":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "category":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "quantityArts":
                                text += $"{reader.GetString(column)}\n";
                                break;
                            case "capacity":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "weight":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "producer":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "state":
                                text += $"{reader.GetString(column)}/";
                                break;
                            case "quantityPackg":
                                text += $"{reader.GetString(column)}\n";
                                break;
                            default:

                                break;
                        }
                      
                    }
                    label.Text += text;

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
        public static void fillWhereCmbBox(ComboBox cmbBox, string table, params string[] columns)
        {
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = $"SELECT * FROM `{table}` WHERE status=1";
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    string text = string.Empty;
                    foreach (string column in columns)
                    {
                        if (column == columns[0])
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
            catch(Exception e)
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
                throw e;
            }
            finally
            {
                _databaseConnection.Close();
            }
        }

        public static void executeTransportQuery(List<TransportItem> transportItems, decimal totalPrice)
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                Connection = _databaseConnection
            };
            _databaseConnection.Open();

            MySqlTransaction transaction = _databaseConnection.BeginTransaction();
            mySqlCommand.Transaction = transaction;

            try
            {
                mySqlCommand.CommandText = "SELECT `transport_number` FROM `transport` ORDER BY `id_transport` DESC LIMIT 1";

                int? transportNumber = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                if (transportNumber == null)
                {
                    transportNumber = 0;
                }

                transportNumber += 1;

                int clientId = transportItems[0]._clientId;

                mySqlCommand.CommandText = "INSERT INTO `transport` (`fk_client_id`, `transport_number`, `total_price`) VALUES (@clientId, @transportNumber, @totalPrice); SELECT LAST_INSERT_ID()";
                mySqlCommand.Parameters.AddWithValue("@clientId", clientId);
                mySqlCommand.Parameters.AddWithValue("@transportNumber", transportNumber);
                mySqlCommand.Parameters.AddWithValue("@totalPrice", totalPrice);

                int? transportId = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                mySqlCommand.Parameters.Clear();

                mySqlCommand.CommandText = "INSERT INTO `transport_items` (`fk_transport_id`, `price_single`, `quantity`, `traveled`, `price`) VALUES (@fkTransportId, @priceSingle, @quantity, @traveled, @price)";
                foreach (TransportItem item in transportItems)
                {
                    mySqlCommand.Parameters.AddWithValue("@fkTransportId", transportId);
                    mySqlCommand.Parameters.AddWithValue("@priceSingle", item._priceSingle);
                    mySqlCommand.Parameters.AddWithValue("@quantity", item._quantity);
                    mySqlCommand.Parameters.AddWithValue("@traveled", item._traveled);
                    mySqlCommand.Parameters.AddWithValue("@price", item._price);

                    mySqlCommand.ExecuteNonQuery();

                    mySqlCommand.Parameters.Clear();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return;
                }
                throw new Exception(ex.Message);
            }
            finally
            {
                _databaseConnection.Close();
            }
        }

        public static dynamic getStorageData(MySqlCommand mySqlCommand,int id)
        {
            dynamic result = null;
            try
            {
                mySqlCommand.Connection = _databaseConnection;
                _databaseConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                
                if (mySqlDataReader.Read())
                {
                    
                    decimal article_quantity = mySqlDataReader.GetDecimal("article_quantity");
                    string storage_position = mySqlDataReader.GetString("storage_position");
                    decimal package_quantity = mySqlDataReader.GetDecimal("package_quantity");

                    StorageData storageData = new StorageData(id, storage_position, article_quantity,package_quantity);

                    result = storageData;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _databaseConnection.Close();
            }
            return result;

        }

        public static string getTransportDetails(MySqlCommand mySqlCommand)
        {
            string result = string.Empty;
            try
            {
                mySqlCommand.Connection = _databaseConnection;
                _databaseConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                int articleNum = 1;
                while (mySqlDataReader.Read())
                {
                    //string priceSingle = mySqlDataReader.GetDecimal("price_single").ToString("0.00");
                    //string quantity = mySqlDataReader.GetDecimal("quantity").ToString("0.00");
                    //string traveled = mySqlDataReader.GetDecimal("traveled").ToString("0.00");
                    //string price = mySqlDataReader.GetDecimal("price").ToString("0.00");

                    result += $"Artikal {articleNum}\n{mySqlDataReader.GetString("details")}\n";

                    // result += $"Artikal {articleNum}\n{priceSingle} / {quantity} / {traveled} / {price}\n";

                    articleNum += 1;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _databaseConnection.Close();
            }
            return result;

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
            catch(Exception e)
            {
                if (_databaseConnection.State != ConnectionState.Open)
                {
                    return -1;
                }
                 throw e;
            }
            finally
            {
                _databaseConnection.Close();
            }
            return value;
        }
    }
}
