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
    public class OperationFromDb
    {
        public static List<OperationView> GetOperations()
        {
            var operations = new List<OperationView>();

            using (var connection = new NpgsqlConnection(ConnectionStr.connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT o.id, p.name AS product, o.product_id, o.count, o.summa,
                           o.date_operation, o.time_operation,
                           c.name AS client_name, u.name AS user_name,
                           s.name AS status, o.client_id, o.user_id, o.status_id
                    FROM operation o
                    JOIN product p ON o.product_id = p.id
                    JOIN client c ON o.client_id = c.id
                    JOIN users u ON o.user_id = u.id
                    JOIN status_operation s ON o.status_id = s.id
                    ORDER BY o.date_operation DESC, o.time_operation DESC";

                using (var cmd = new NpgsqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        operations.Add(new OperationView
                        {
                            Id = reader.GetInt32(0),
                            Product = reader.GetString(1),
                            ProductId = reader.GetInt32(2),
                            Count = reader.GetInt32(3),
                            Summa = reader.GetDouble(4),
                            Date = DateOnly.FromDateTime(reader.GetDateTime(5)),
                            Time = TimeOnly.FromTimeSpan(reader.GetTimeSpan(6)),
                            ClientName = reader.GetString(7),
                            UserName = reader.GetString(8),
                            Status = reader.GetString(9),
                            ClientId = reader.GetInt32(10),
                            UserId = reader.GetInt32(11),
                            StatusId = reader.GetInt32(12)
                        });
                    }
                }
            }

            return operations;
        }

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

        public static void UpdateOperation(OperationView operation)
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE operation SET status_id = @StatusId WHERE id = @Id";
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("StatusId", operation.StatusId);
                        cmd.Parameters.AddWithValue("Id", operation.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Ошибка при обновлении статуса операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
