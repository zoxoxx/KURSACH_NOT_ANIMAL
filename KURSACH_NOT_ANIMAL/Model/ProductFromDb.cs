using KURSACH_NOT_ANIMAL.Classes.DbClasses;
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
    public class ProductFromDb
    {
        public static List<Product>? GetProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select ID, NAME " +
                        "from PRODUCT";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        products.Add(new Product((int)reader[0], reader[1].ToString()!));
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия пользователя в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return products;
        }
    }
}
