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
using System.Xml.Linq;

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
                MessageBox.Show("Было вызвано исключение при проверке наличия продуктов в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return products;
        }

        public static List<ProductView>? GetProductsWithCategory()
        {
            List<ProductView> products = new List<ProductView>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select p.*, c.NAME " +
                        "from PRODUCT p " +
                        "join CATEGORY_PRODUCT c on c.ID = p.CATEGORY_ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        products.Add(new ProductView((int)reader[0], (double)reader[1], reader[2].ToString()!, reader[3].ToString(), reader[4].ToString(), (int)reader[5], (double)reader[6], reader[7].ToString()!));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия продуктов в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return products;
        }

        public static ProductView? GetProductsWithCategory(int ProductId)
        {
            ProductView? product = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select p.*, c.NAME" +
                        "from PRODUCT p " +
                        "join CATEGORY_ANIMAL c on c.ID = p.CATEGORY_ID" +
                        "where p.ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", ProductId);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    product = new ProductView((int)reader[0], (double)reader[1], reader[2].ToString()!, reader[3].ToString(), reader[4].ToString(), (int)reader[5], (double)reader[6], reader[7].ToString()!);
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия продукта в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return product;
        }

        public static Product? GetProduct(int ProductId)
        {
            Product? product = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select *" +
                        "from PRODUCT" +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", ProductId);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    product = new Product((int)reader[0], (double)reader[1], reader[2].ToString()!, reader[3].ToString()?? "", reader[4].ToString()?? "", (int)reader[5], (double)reader[6]);
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия продукта в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return product;
        }

        public static int? GetMaxProductId()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select max(ID) " +
                        "from PRODUCT";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    return (int)reader[0];
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении максимального значения первичного ключа продукции,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static bool AddProduct(double weight, string name, int price, int categoryId, string desciption = "", string commentary = "")
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into PRODUCT(WEIGHT, NAME, COMMENTARY, DESCRIPTION, CATEGORY_ID, PRICE) " +
                        "values (@Weight, @Name, @Commentary, @Description, @CategoryId, @Price)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Weight", weight);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Commentary", commentary);
                    cmd.Parameters.AddWithValue("Price", price);
                    cmd.Parameters.AddWithValue("CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("Description", desciption);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении нового продукта,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool AddRecomendationsFromProduct(List<int> animalId, int userId, int productId)
        {
            try
            {
                for (int i=0; i < animalId.Count; i++)
                    using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                    {
                        connection.Open();

                        string sqlExp = "insert into PRODUCT_FOR_ANIMAL(ANIMAL_ID, USER_ID, PRODUCT_ID) " +
                            "values (@AnimalId, @UserId, @ProductId)";
                        NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                        cmd.Parameters.AddWithValue("AnimalId", animalId[i]);
                        cmd.Parameters.AddWithValue("UserId", userId);
                        cmd.Parameters.AddWithValue("ProductId", productId);

                        int resultQuery = cmd.ExecuteNonQuery();
                    }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении рекомендаций для продукта,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool UpdateProduct(Product changedProduct)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();
                    string sqlExp = "update PRODUCT " +
                        "set " +
                        "   WEIGHT = @Weight, " +
                        "   NAME = @Name, " +
                        "   COMMENTARY = @Commentary, " +
                        "   DESCRIPTION = @Description, " +
                        "   CATEGORY_ID = @CategoryId, " +
                        "   PRICE = @Price " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", changedProduct.Id);
                    cmd.Parameters.AddWithValue("Weight", changedProduct.Weight!);
                    cmd.Parameters.AddWithValue("Name", changedProduct.Name);
                    cmd.Parameters.AddWithValue("Commentary", changedProduct.Commentary?? "");
                    cmd.Parameters.AddWithValue("Description", changedProduct.Description ?? "");
                    cmd.Parameters.AddWithValue("CategoryId", changedProduct.CategoryId);
                    cmd.Parameters.AddWithValue("Price", changedProduct.Price);

                    int resultQery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при обновлении продукта ,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool DeleteProduct(int id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete from PRODUCT " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", id);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении продукта,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static CategoryProduct? GetCategory(string categoryName)
        {
            CategoryProduct? selectedCategory = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from CATEGORY_PRODUCT " +
                        "where NAME = @Name";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", categoryName);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    selectedCategory = new CategoryProduct((int)reader[0], reader[1].ToString()!, reader[2].ToString() ?? "");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении категории,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return selectedCategory;
        }

        public static List<CategoryProduct>? GetAllCategories()
        {
            List<CategoryProduct>? categories = new List<CategoryProduct>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from CATEGORY_PRODUCT";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        categories.Add(new CategoryProduct((int)reader[0], reader[1].ToString()!, reader[2].ToString() ?? ""));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении категорий продуктов,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return categories;
        }

        public static bool DeleteRecomendationsForProduct(int productId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete  " +
                        "from PRODUCT_FOR_ANIMAL " +
                        "where PRODUCT_ID = @ProductId";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("ProductId", productId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении рекомендаций продукта для животных,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool AddCategory(string name, string description = "")
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into CATEGORY_PRODUCT(NAME, DESCRIPTION) " +
                        "values(@Name, @Description)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Description", description);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении категории продуктов,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool UpdateCategory(CategoryProduct changedCategory)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "update CATEGORY_PRODUCT " +
                        "set " +
                        "   NAME = @Name, " +
                        "   DESCRIPTION = @Description " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", changedCategory.Name!);
                    cmd.Parameters.AddWithValue("Description", changedCategory.Description ?? "");
                    cmd.Parameters.AddWithValue("Id", changedCategory.Id);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при обновлении категории продуктов,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool DeleteCategory(int categoryId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete from CATEGORY_PRODUCT " +
                        "where ID = @CategoryId";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("CategoryId", categoryId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.ErrorCode == -2147467259)
                    MessageBox.Show("Данную категорию нельзя удалить, так как имеются продукты с этой категорией", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Было вызвано исключение при удалении категории продуктов,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            return true;
        }

        public static List<int>? GetRecomendationFromProduct(int productId)
        {
            List<int> recomendationsId = new List<int>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select a.ID " +
                        "from PRODUCT_FOR_ANIMAL r " +
                        "join ANIMAL a on a.ID = r.ANIMAL_ID " +
                        "where PRODUCT_ID = @ProductId " +
                        "order by r.ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("ProductId", productId);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        recomendationsId.Add((int)reader[0]);
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении списка рекомендаций животным по продукту,\n" +
                "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return recomendationsId;
        }
    }
}
