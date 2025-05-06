using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.SystemClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Models;
using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Model
{
    public class SkladFromDb
    {
        public static List<SkladView>? GetAllPurchases()
        {
            List<SkladView> purchases = new List<SkladView>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select s.ID, p.NAME, s.COUNT, sh.NAME, pr.NAME, s.PURCHASE_PRICE, s.DATE_PRIHOD " +
                        "from SKLAD s " +
                        "join PRODUCT p on p.ID = s.PRODUCT_ID " +
                        "join SHOP sh on sh.ID = s.SHOP_ID " +
                        "join PARTNER pr on pr.ID = s.PARTNER_ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;
                    
                    while(reader.Read())
                        purchases.Add(new SkladView((int)reader[0], reader[1].ToString(), 
                            (int)reader[2], reader[3].ToString(), 
                            reader[4].ToString(), (double)reader[5], DateOnly.FromDateTime((DateTime)reader[6])));
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия пользователя в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return purchases;
        }

        public static bool DeletePurchase(int purchaseId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete from SKLAD where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", purchaseId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении закупки,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool AddPurchase(int productId, int count, int shopId, int partnerId, double purchasePrice, DateOnly datePrihod)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into SKLAD(PRODUCT_ID, COUNT, SHOP_ID, PARTNER_ID, PURCHASE_PRICE, DATE_PRIHOD) " +
                        "values (@ProductId, @Count, @ShopId, @PartnerId, @PurchasePrice, @DatePrihod)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("ProductId", productId);
                    cmd.Parameters.AddWithValue("Count", count);
                    cmd.Parameters.AddWithValue("ShopId", shopId);
                    cmd.Parameters.AddWithValue("PartnerId", partnerId);
                    cmd.Parameters.AddWithValue("PurchasePrice", purchasePrice);
                    cmd.Parameters.AddWithValue("DatePrihod", datePrihod);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении закупки,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool UpdatePurchase(int productId, int count, int shopId, int partnerId, double purchasePrice, DateOnly datePrihod, int purchaseId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "update SKLAD set " +
                        "   PRODUCT_ID = @ProductId, " +
                        "   COUNT = @Count, " +
                        "   SHOP_ID = @ShopId, " +
                        "   PARTNER_ID = @PartnerId, " +
                        "   PURCHASE_PRICE = @PurchasePrice, " +
                        "   DATE_PRIHOD = @DatePrihod " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("ProductId", productId);
                    cmd.Parameters.AddWithValue("Count", count);
                    cmd.Parameters.AddWithValue("ShopId", shopId);
                    cmd.Parameters.AddWithValue("PartnerId", partnerId);
                    cmd.Parameters.AddWithValue("PurchasePrice", purchasePrice);
                    cmd.Parameters.AddWithValue("DatePrihod", datePrihod);
                    cmd.Parameters.AddWithValue("Id", purchaseId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при обновлении закупки,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static Sklad? GetDbPurchase(int purchaseId)
        {
            Sklad? dbPurchase = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from SKLAD " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", purchaseId);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    dbPurchase = new Sklad((int)reader[0], (int)reader[1], (int)reader[2], (int)reader[3], 
                        (int)reader[4], (double)reader[5], DateOnly.FromDateTime((DateTime)reader[6]));
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении dto закупки,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return null;
            }

            return dbPurchase;
        }
    }
}
