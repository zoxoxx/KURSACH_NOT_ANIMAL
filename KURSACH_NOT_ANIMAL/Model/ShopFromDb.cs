using KURSACH_NOT_ANIMAL.Classes.DbClasses;
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
    public static class ShopFromDb
    {
        public static List<ShopView>? GetOurShops()
        {
            List<ShopView>? shops = new List<ShopView>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select s.ID, s.NAME, s.ADRESS, s.CITY_ID, c.NAME " +
                        "from SHOP s " +
                        "join CITY c on c.ID = s.CITY_ID";

                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    NpgsqlDataReader reader = cmd.ExecuteReader();


                    if (!reader.HasRows)
                        return null;


                    while (reader.Read())
                        shops.Add(new ShopView((int)reader[0], reader[1].ToString()!, reader[2].ToString()!, (int)reader[3], reader[4].ToString()!));
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при загрузке наших магазинов,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return shops;
        }

        public static List<ShopView>? GetPartnerShops()
        {
            List<ShopView>? shops = new List<ShopView>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select s.ID, s.NAME, s.ADRESS, s.CITY_ID, c.NAME " +
                        "from PARTNER s " +
                        "join CITY c on c.ID = s.CITY_ID";

                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    NpgsqlDataReader reader = cmd.ExecuteReader();


                    if (!reader.HasRows)
                        return null;


                    while (reader.Read())
                        shops.Add(new ShopView((int)reader[0], reader[1].ToString()!, reader[2].ToString()!, (int)reader[3], reader[4].ToString()!));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при загрузке наших магазинов,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return shops;
        }

        public static List<City>? GetCities()
        {
            List<City>? cities = new List<City>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from CITY";

                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    NpgsqlDataReader reader = cmd.ExecuteReader();


                    if (!reader.HasRows)
                        return null;


                    while (reader.Read())
                        cities.Add(new City((int)reader[0], (int)reader[1], reader[2].ToString()!));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при загрузке списка городов,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return cities;
        }

        //CRUD

        public static bool DeletePartnerShop(int shopId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete from PARTNER " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", shopId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении магазина партнера,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool DeleteShop(int shopId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete from SHOP " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", shopId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении магазина,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool AddShop(string name, string adress, int cityId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into SHOP(NAME, ADRESS, CITY_ID) " +
                        "values(@Name, @Adress, @CityId)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Adress", adress);
                    cmd.Parameters.AddWithValue("CityId", cityId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении магазина,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool AddPartnerShop(string name, string adress, int cityId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into PARTNER(NAME, ADRESS, CITY_ID) " +
                        "values(@Name, @Adress, @CityId)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Adress", adress);
                    cmd.Parameters.AddWithValue("CityId", cityId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении магазина,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool UpdatePartnerShop(int shopId, string name, string adress, int cityId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "update PARTNER set " +
                        "   NAME = @Name, " +
                        "   ADRESS = @Adress, " +
                        "   CITY_ID = @CityId " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Adress", adress);
                    cmd.Parameters.AddWithValue("CityId", cityId);
                    cmd.Parameters.AddWithValue("Id", shopId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении магазина,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool UpdateShop(int shopId, string name, string adress, int cityId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "update PARTNER set " +
                        "   NAME = @Name, " +
                        "   ADRESS = @Adress, " +
                        "   CITY_ID = @CityId " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Adress", adress);
                    cmd.Parameters.AddWithValue("CityId", cityId);
                    cmd.Parameters.AddWithValue("Id", shopId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении магазина,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
