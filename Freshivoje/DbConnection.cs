using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using MySql.Data.MySqlClient;
using Freshivoje.Models;
using System.Collections.Generic;
using System.Drawing;

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
        public static void Storage(Label label, string query, params string[] columns)
        {
            try
            {
                string text = string.Empty;
                decimal ArticleQuantity = 0, StorageArticleQuantity = 0, SumA;
                int PackagingQuantity = 0, StoragePackagingQuantity = 0, SumP;
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "StorageArticleQuantity":

                                StorageArticleQuantity = reader.GetDecimal(column);
                                break;
                            case "article_quantity":

                                ArticleQuantity = reader.GetDecimal(column);
                                SumA = ArticleQuantity - StorageArticleQuantity;
                                text = $"{SumA}";
                                break;
                            case "StoragePackagingQuantity":

                                StoragePackagingQuantity = reader.GetInt32(column);
                                break;
                            case "package_quantity":

                                PackagingQuantity = reader.GetInt32(column);
                                SumP = PackagingQuantity - StoragePackagingQuantity;
                                text = $"{SumP}";
                                break;


                            default:

                                break;
                        }
                    }
                }
                label.Text = text;

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
        public static void fillLbl(Label label, string query, string query1, params string[] columns)
        {
            try
            {
                string text = string.Empty;
                var MapOfArticleQuantiy = new Dictionary<Int32, Decimal>();
                var MapOfArticleStorageQuantiy = new Dictionary<Int32, Decimal>();
                var MapOfPackagingQuantity = new Dictionary<Int32, Decimal>();
                var MapOfPackagingStorageQuantity = new Dictionary<Int32, Decimal>();
                int QuantityStorageArticleId = 0, QuantityArticleId = 0, QuantityPackagingId = 0, QuantityStoragePackagingId = 0;
                decimal QuantityStorageArticle = 0, QuantityArticle = 0, QuantityStoragePackaging = 0, QuantityPackaging = 0, SUM;
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "QuantityArticleId":
                                QuantityArticleId = reader.GetInt32(column);
                                break;
                            case "QuantityArts":
                                QuantityArticle = reader.GetDecimal(column);
                                MapOfArticleQuantiy.Add(QuantityArticleId, QuantityArticle);
                                break;
                            case "QuantityPackagingId":
                                QuantityPackagingId = reader.GetInt32(column);
                                break;
                            case "QuantityPackg":
                                QuantityPackaging = reader.GetDecimal(column);
                                MapOfPackagingQuantity.Add(QuantityPackagingId, QuantityPackaging);
                                break;
                            default:

                                break;
                        }
                    }
                }
                _databaseConnection.Close();
                if (query1 == "")
                {
                    foreach (KeyValuePair<Int32, Decimal> item in MapOfArticleQuantiy)
                    {
                        bool state = true;
                        foreach (KeyValuePair<Int32, Decimal> item1 in MapOfArticleStorageQuantiy)
                        {
                            if (item1.Key == item.Key)
                            {
                                state = false;
                                SUM = item.Value - item1.Value;
                                text += $"{SUM.ToString()}";
                            }
                        }

                        if (state != false)
                        {
                            text += $"{item.Value.ToString()}";
                        }

                    }
                    foreach (KeyValuePair<Int32, Decimal> item in MapOfPackagingQuantity)
                    {
                        bool state = true;
                        foreach (KeyValuePair<Int32, Decimal> item1 in MapOfPackagingStorageQuantity)
                        {
                            if (item1.Key == item.Key)
                            {
                                state = false;
                                SUM = item.Value - item1.Value;
                                text += $"{SUM.ToString()}";
                            }
                        }

                        if (state != false)
                        {
                            text += $"{item.Value.ToString()}";
                        }

                    }

                    label.Text = text;
                    return;
                }
                _databaseConnection.Open();
                int j = 1;
                MySqlCommand mySqlCommand1 = _databaseConnection.CreateCommand();
                mySqlCommand1.CommandText = query1;
                using MySqlDataReader reader1 = mySqlCommand1.ExecuteReader();
                while (reader1.Read())
                {
                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "QuantityStorageArticleId":
                                QuantityStorageArticleId = reader1.GetInt32(column);
                                break;
                            case "QuantityStorageArticle":
                                QuantityStorageArticle = reader1.GetDecimal(column);
                                MapOfArticleStorageQuantiy.Add(QuantityStorageArticleId, QuantityStorageArticle);
                                break;
                            case "QuantityStoragePackagingId":
                                QuantityStoragePackagingId = reader1.GetInt32(column);
                                break;
                            case "QuantityStoragePackaging":
                                QuantityStoragePackaging = reader1.GetDecimal(column);
                                MapOfPackagingStorageQuantity.Add(QuantityStoragePackagingId, QuantityStoragePackaging);
                                break;
                            default:
                                break;
                        }
                    }


                }
                foreach (KeyValuePair<Int32, Decimal> item in MapOfArticleQuantiy)
                {
                    bool state = true;
                    foreach (KeyValuePair<Int32, Decimal> item1 in MapOfArticleStorageQuantiy)
                    {
                        if (item1.Key == item.Key)
                        {
                            state = false;
                            SUM = item.Value - item1.Value;
                            text += $"{SUM.ToString()}";
                        }
                    }

                    if (state != false)
                    {
                        text += $"{item.Value.ToString()}";
                    }

                }
                foreach (KeyValuePair<Int32, Decimal> item in MapOfPackagingQuantity)
                {
                    bool state = true;
                    foreach (KeyValuePair<Int32, Decimal> item1 in MapOfPackagingStorageQuantity)
                    {
                        if (item1.Key == item.Key)
                        {
                            state = false;
                            SUM = item.Value - item1.Value;
                            text += $"{SUM.ToString()}";
                        }
                    }

                    if (state != false)
                    {
                        text += $"{item.Value.ToString()}";
                    }

                }

                label.Text = text;
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
        public static void fillBtnText(Button button, string query, params string[] columns)
        {
            try
            {
                string text = string.Empty;
                decimal ArticleQuantity = 0, StorageArticleQuantity = 0, SumA;
                int PackagingQuantity = 0, StoragePackagingQuantity = 0, SumP;
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "id_storage":
                                button.Tag = reader.GetInt32(column);
                                break;
                            case "storage_position":
                                text += $"{reader.GetString(column)}\n";
                                break;
                            case "StorageArticleQuantity":
                                text += $"Artikli(kg) {reader.GetDecimal(column)}/";
                                StorageArticleQuantity = reader.GetDecimal(column);
                                break;
                            case "article_quantity":
                                text += $"{reader.GetDecimal(column)}\n";
                                ArticleQuantity = reader.GetDecimal(column);
                                SumA = ArticleQuantity - StorageArticleQuantity;
                                if (SumA <= 1000)
                                {
                                    button.BackColor = Color.Red;
                                }
                                break;
                            case "StoragePackagingQuantity":
                                text += $"Ambalaže {reader.GetInt32(column)}/";
                                StoragePackagingQuantity = reader.GetInt32(column);
                                break;
                            case "package_quantity":
                                text += $"{reader.GetInt32(column)}\n";
                                PackagingQuantity = reader.GetInt32(column);
                                SumP = PackagingQuantity - StoragePackagingQuantity;
                                if (SumP <= 1000)
                                {
                                    button.BackColor = Color.Red;
                                }
                                break;


                            default:

                                break;
                        }
                    }
                }
                button.Text = text;

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
        public static void FillCmbBoxQuery(ComboBox cmbBox, string query, params string[] columns)
        {
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int value = 0;
                    string text = string.Empty;

                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "id_article":
                                value = reader.GetInt32(column);
                                break;
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
                            case "id_packaging":
                                value = reader.GetInt32(column);
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
                                text += $"{reader.GetString(column)}";
                                break;
                            case "id_pallete":
                                value = reader.GetInt32(column);
                                break;
                            case "pallet_number":
                                text += $"{reader.GetInt32(column).ToString()}";
                                break;
                            default:

                                break;
                        }

                      
                    }
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Value = value,
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
        public static void tunnel(Label label, string query, string query1, Label label1, params string[] columns)
        {

            try
            {
                string text = string.Empty;
                string text1 = string.Empty;

                var MapOfArticleQuantiy = new Dictionary<Int32, Decimal>();
                var MapOfArticleStorageQuantiy = new Dictionary<Int32, Decimal>();
                var MapOfPackagingQuantity = new Dictionary<Int32, Decimal>();
                var MapOfPackagingStorageQuantity = new Dictionary<Int32, Decimal>();
                int QuantityStorageArticleId = 0, QuantityArticleId = 0, QuantityPackagingId = 0, QuantityStoragePackagingId = 0;
                decimal QuantityStorageArticle = 0, QuantityArticle = 0, QuantityStoragePackaging = 0, QuantityPackaging = 0, SUM;
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "quantityArticleId":
                                QuantityArticleId = reader.GetInt32(column);
                                break;
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
                                text += $"{reader.GetString(column)}\n";
                                break;
                            case "quantityArts":
                                QuantityArticle = reader.GetDecimal(column);
                                MapOfArticleQuantiy.Add(QuantityArticleId, QuantityArticle);
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
                            case "QuantityPackagingId":
                                QuantityPackagingId = reader.GetInt32(column);
                                break;
                            case "quantityPackg":
                                QuantityPackaging = reader.GetDecimal(column);
                                MapOfPackagingQuantity.Add(QuantityPackagingId, QuantityPackaging);
                                break;

                            default:

                                break;
                        }


                    }



                }
                label.Text = text;
                _databaseConnection.Close();
                _databaseConnection.Open();
                int j = 1;

                MySqlCommand mySqlCommand1 = _databaseConnection.CreateCommand();
                mySqlCommand1.CommandText = query1;
                using MySqlDataReader reader1 = mySqlCommand1.ExecuteReader();
                while (reader1.Read())
                {
                    foreach (string column in columns)
                    {
                        switch (column)
                        {
                            case "QuantityStorageArticleId":
                                QuantityStorageArticleId = reader1.GetInt32(column);
                                break;
                            case "quantityStorageArticle":
                                QuantityStorageArticle = reader1.GetDecimal(column);
                                MapOfArticleStorageQuantiy.Add(QuantityStorageArticleId, QuantityStorageArticle);
                                break;
                            case "QuantityStoragePackagingId":
                                QuantityStoragePackagingId = reader1.GetInt32(column);
                                break;
                            case "quantityStoragePackaging":
                                QuantityStoragePackaging = reader1.GetDecimal(column);
                                MapOfPackagingStorageQuantity.Add(QuantityStoragePackagingId, QuantityStoragePackaging);
                                break;
                            default:
                                break;
                        }
                    }


                }
                foreach (KeyValuePair<Int32, Decimal> item in MapOfArticleQuantiy)
                {
                    bool state = true;
                    foreach (KeyValuePair<Int32, Decimal> item1 in MapOfArticleStorageQuantiy)
                    {
                        if (item1.Key == item.Key)
                        {
                            state = false;
                            SUM = item.Value - item1.Value;
                            text1 += $"/{SUM.ToString()}\n";
                        }
                    }

                    if (state != false)
                    {
                        text1 += $"/{item.Value.ToString()}\n";
                    }

                }
                foreach (KeyValuePair<Int32, Decimal> item in MapOfPackagingQuantity)
                {
                    bool state = true;
                    foreach (KeyValuePair<Int32, Decimal> item1 in MapOfPackagingStorageQuantity)
                    {
                        if (item1.Key == item.Key)
                        {
                            state = false;
                            SUM = item.Value - item1.Value;
                            text1 += $"/{SUM.ToString()}\n";
                        }
                    }

                    if (state != false)
                    {
                        text1 += $"/{item.Value.ToString()}\n";
                    }

                }


                label1.Text += text1;

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

        public static void fillWhereCmbBox(ComboBox cmbBox, string table, params string[] columns)
        {
            try
            {
                _databaseConnection.Open();
                MySqlCommand mySqlCommand = _databaseConnection.CreateCommand();
                mySqlCommand.CommandText = $"SELECT * FROM `{table}` WHERE status=1";
                using MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
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

        public static void executePalletingQuery(List<PalletingItem> palletingItems )
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
                mySqlCommand.CommandText = "SELECT `pallet_number` FROM `pallete` ORDER BY `id_pallete` DESC LIMIT 1";

                int? palletNumber = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                if (palletNumber == null)
                {
                    palletNumber = 0;
                }

                palletNumber += 1;
                
                mySqlCommand.CommandText = "INSERT INTO `pallete` (`pallet_number`) VALUES (@pallet_number); SELECT LAST_INSERT_ID()";
                mySqlCommand.Parameters.AddWithValue("@pallet_number", palletNumber);
               
                int? palletId = Convert.ToInt32(mySqlCommand.ExecuteScalar());

                mySqlCommand.Parameters.Clear();

                mySqlCommand.CommandText = "INSERT INTO `item_pallete` ( `fk_id_item_recepit`, `fk_id_pallete`) VALUES ( @palletItemId, @palletId)";
                foreach (PalletingItem item in palletingItems)
                {
                    mySqlCommand.Parameters.AddWithValue("@palletId", palletId);
                    mySqlCommand.Parameters.AddWithValue("@palletItemId", item._fk_item_receipt_id);

                    mySqlCommand.ExecuteNonQuery();

                    mySqlCommand.Parameters.Clear();
                }

                mySqlCommand.CommandText = "UPDATE `items_receipt` SET `status` = 'neaktivna' WHERE `items_receipt`.`id_items_receipt` = @palletItemId; ";
                foreach (PalletingItem item in palletingItems)
                {
                    mySqlCommand.Parameters.AddWithValue("@palletItemId", item._fk_item_receipt_id);

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

        public static dynamic getStorageData(MySqlCommand mySqlCommand, int id)
        {
            dynamic result = null;
            try
            {
                mySqlCommand.Connection = _databaseConnection;
                _databaseConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


                if (mySqlDataReader.Read())
                {

                    string storage_position = mySqlDataReader.GetString("storage_position");

                    if (storage_position == "IZLAZ")
                    {
                        StorageData storageData1 = new StorageData(id, storage_position);
                        result = storageData1;
                        return result;
                    }
                    StorageData storageData = new StorageData(id, storage_position);

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
                    string priceSingle = mySqlDataReader.GetDecimal("price_single").ToString("0.00");
                    string quantity = mySqlDataReader.GetDecimal("quantity").ToString("0.00");
                    string traveled = mySqlDataReader.GetDecimal("traveled").ToString("0.00");
                    string price = mySqlDataReader.GetDecimal("price").ToString("0.00");


                    result += $"Artikal {articleNum}\n{priceSingle} / {quantity} / {traveled} / {price}\n";

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

        public static string getReceiptDetails(MySqlCommand mySqlCommand)
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

                    result += $"Artikal {articleNum}\n{mySqlDataReader.GetString("article")}\n{mySqlDataReader.GetString("quantity")} kg\n{mySqlDataReader.GetString("price")} RSD\n\n";

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
            catch (Exception e)
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