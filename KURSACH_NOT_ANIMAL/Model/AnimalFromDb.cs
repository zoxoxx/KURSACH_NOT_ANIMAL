using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Models;
using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KURSACH_NOT_ANIMAL.Model
{
    class AnimalFromDb
    {
        public static Animal? GetAnimal(int animalId)
        {
            Animal? selectedAnimal = null;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from ANIMAL " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", animalId);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    selectedAnimal = new Animal((int)reader[0], reader[1].ToString()!, (int)reader[2], reader[3].ToString()!);
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при поиске животного,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return selectedAnimal;
        }

        public static bool AddAnimal(string name, int categoryId, string desciption = "")
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into ANIMAL(NAME, CATEGORY_ID, DESCRIPTION) " +
                        "values (@Name, @CategoryId, @Description)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("Description", desciption);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении нового животного,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static List<Animal>? GetAllAnimals()
        {
            List<Animal>? animals = new List<Animal>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from ANIMAL";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        animals.Add(new Animal((int)reader[0], reader[1].ToString()!, (int)reader[2], reader[3].ToString()!));
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении реестра животных,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return animals;
        }

        public static bool UpdateAnimal(Animal changedAnimal)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "update ANIMAL " +
                        "set " +
                        "   NAME = @Name, " +
                        "   CATEGORY_ID = @CategoryId," +
                        "   DESCRIPTION = @Description " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", changedAnimal.Id);
                    cmd.Parameters.AddWithValue("Name", changedAnimal.Name);
                    cmd.Parameters.AddWithValue("CategoryId", changedAnimal.CategoryId);
                    cmd.Parameters.AddWithValue("Description", changedAnimal.Description);

                    int resultQery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при обновлении животного ,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static CategoryAnimal? GetCategory(string categoryName)
        {
            CategoryAnimal? selectedCategory = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from CATEGORY_ANIMAL " +
                        "where NAME = @Name";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", categoryName);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    reader.Read();
                    selectedCategory = new CategoryAnimal((int)reader[0], reader[1].ToString()!, reader[2].ToString()?? "");
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении категории,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return selectedCategory;
        }

        public static List<CategoryAnimal>? GetAllCategorys()
        {
            List<CategoryAnimal>? categorys = new List<CategoryAnimal>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from CATEGORY_ANIMAL";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while(reader.Read())
                        categorys.Add(new CategoryAnimal((int)reader[0], reader[1].ToString()!, reader[2].ToString() ?? ""));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении категорий животных,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return categorys;
        }

        public static bool AddCategory(string name, string description = "")
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into CATEGORY_ANIMAL(NAME, DESCRIPTION) " +
                        "values(@Name, @Description)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Description", description);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении категории животных,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static int GetMaxAnimalId()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select max(ID) " +
                        "from ANIMAL";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return 0;

                    reader.Read();
                    return (int)reader[0];
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении максимального значения первичного ключа животного,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
        }

        public static bool UpdateCategory(CategoryAnimal changedCategory)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "update CATEGORY_ANIMAL " +
                        "set " +
                        "   NAME = @Name, " +
                        "   DESCRIPTION = @Description " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Name", changedCategory.Name!);
                    cmd.Parameters.AddWithValue("Description", changedCategory.Description?? "");
                    cmd.Parameters.AddWithValue("Id", changedCategory.Id);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при обновлении категории животных,\n" +
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

                    string sqlExp = "delete from CATEGORY_ANIMAL " +
                        "where ID = @CategoryId";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("CategoryId", categoryId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                if (ex.ErrorCode == -2147467259)
                    MessageBox.Show("Данную категорию нельзя удалить, так как имеются животные с этой категорией", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Было вызвано исключение при удалении категории животных,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            return true;
        }

        public static List<AnimalView>? GetAnimalWithCategory()
        {
            List<AnimalView>? animals = new List<AnimalView>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select a.ID, a.NAME, a.DESCRIPTION, c.NAME, c.DESCRIPTION, c.ID " +
                        "from ANIMAL a " +
                        "left join CATEGORY_ANIMAL c on a.CATEGORY_ID = c.ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        animals.Add(new AnimalView((int)reader[0], reader[1].ToString()!,
                            reader[2].ToString()!, reader[3].ToString()?? "Пусто", reader[4].ToString()?? "", (int)reader[5]));
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении животных с категорией,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return animals;
        }

        public static bool DeleteAnimal(int animalId = 0)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete from Animal " +
                        "where ID = @AnimalId";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("AnimalId", animalId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении животного,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
