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
    public class OperationFromDb
    {
        public static bool AddOperation(int summa, int clientId, int productId, int count)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into OPERATION(SUMMA, DATE_OPERATION, TIME_OPERATION, STATUS_ID, CLIENT_ID, PRODUCT_ID, COUNT) " +
                        "select @Summa, current_date, now()::timestamp, s.ID, @ClientId, @ProductId, @Count " +
                        "from STATUS_OPERATION s " +
                        "where s.NAME = 'В обработке'";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Summa", summa);
                    cmd.Parameters.AddWithValue("ClientId", clientId);
                    cmd.Parameters.AddWithValue("ProductId", productId);
                    cmd.Parameters.AddWithValue("Count", count);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при создании заявки на продукцию,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
