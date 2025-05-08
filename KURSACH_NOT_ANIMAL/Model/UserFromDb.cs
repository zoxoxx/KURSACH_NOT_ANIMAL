using KURSACH_NOT_ANIMAL.Classes.DbClasses;
using KURSACH_NOT_ANIMAL.Classes.ViewClasses;
using KURSACH_NOT_ANIMAL.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    static class UserFromDb
    {
        public static UserSystem? GetUser(string login, string password)
        {
            UserSystem? currentUser = null;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from USER_SYSTEM " +
                        "where LOGIN = @Login and PASSWORD = @Password";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Login", login);
                    cmd.Parameters.AddWithValue("Password", password);
                    NpgsqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        reader.Read();

                        currentUser = new UserSystem((int)reader[0], (int)reader[1],
                            reader[2].ToString() ?? "", DateOnly.FromDateTime((DateTime)reader[3]),
                            reader[4].ToString(), (double)reader[5], reader[6].ToString()!, reader[7].ToString()!);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия пользователя в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            if (currentUser is null)
            {
                MessageBox.Show("Пользователь не зарегистрирован в системе.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return currentUser;
        }

        public static int AddUserWithRole(string login, string password, DateOnly birthday, string phone, string phyo, int roleId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into USER_SYSTEM(ROLE_ID, PHYO, BIRTHDAY, PHONE, BALANCE, LOGIN, PASSWORD) " +
                        "select ID, @Phyo, @Birthday, @Phone, 0, @Login, @Password " +
                        "from ROLE " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Phyo", phyo);
                    cmd.Parameters.AddWithValue("Birthday", birthday);
                    cmd.Parameters.AddWithValue("Phone", phone);
                    cmd.Parameters.AddWithValue("Id", roleId);
                    cmd.Parameters.AddWithValue("Login", login);
                    cmd.Parameters.AddWithValue("Password", password);
                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении нового пользователя в систему,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 666;
            }

            return 1;
        }

        public static int AddUser(string login, string password, DateOnly birthday, string phone, string phyo, string roleName = "Клиент")
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "insert into USER_SYSTEM(ROLE_ID, PHYO, BIRTHDAY, PHONE, BALANCE, LOGIN, PASSWORD) " +
                        "select ID, @Phyo, @Birthday, @Phone, 0, @Login, @Password " +
                        "from ROLE " +
                        "where trim(NAME) = @RoleName";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Phyo", phyo);
                    cmd.Parameters.AddWithValue("Birthday", birthday);
                    cmd.Parameters.AddWithValue("Phone", phone);
                    cmd.Parameters.AddWithValue("RoleName", roleName);
                    cmd.Parameters.AddWithValue("Login", login);
                    cmd.Parameters.AddWithValue("Password", password);
                    int resultQuery = cmd.ExecuteNonQuery();

                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при добавлении нового пользователя в систему,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 666;
            }

            return 1;
        }

        public static bool CheckRoleAcess(int userId, string roleName)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select 1 " +
                        "from USER_SYSTEM us " +
                        "join ROLE r on r.ID = us.ROLE_ID " +
                        "where us.ID = @Id and r.NAME = @RoleName";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("Id", userId);
                    cmd.Parameters.AddWithValue("RoleName", roleName);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return false;
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия прав доступа,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return true;
        }

        public static bool UpdateUser(UserSystem changedUser)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "update USER_SYSTEM " +
                        "set " +
                        "   ROLE_ID = @RoleId, " +
                        "   PHYO = @Phyo, " +
                        "   BIRTHDAY = @Birthday, " +
                        "   PHONE = @Phone, " +
                        "   BALANCE = @Balance, " +
                        "   LOGIN = @Login, " +
                        "   PASSWORD = @Password " +
                        "where ID = @Id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("RoleId", changedUser.RoleId);
                    cmd.Parameters.AddWithValue("Phyo", changedUser.PHYO);
                    cmd.Parameters.AddWithValue("Birthday", changedUser.Birthday);
                    cmd.Parameters.AddWithValue("Phone", changedUser.Phone!);
                    cmd.Parameters.AddWithValue("Login", changedUser.Login);
                    cmd.Parameters.AddWithValue("Password", changedUser.Password);
                    cmd.Parameters.AddWithValue("Id", changedUser.Id);
                    int resultQuery = cmd.ExecuteNonQuery();

                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при обновлении пользователя,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static List<UserView>? GetUsersWithRole()
        {
            List<UserView>? users = new List<UserView>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select u.ID, u.PHYO, u.ROLE_ID, r.NAME, u.BIRTHDAY, u.PHONE, u.BALANCE, u.LOGIN, u.PASSWORD " +
                        "from USER_SYSTEM u " +
                        "left join ROLE r on r.ID = u.ROLE_ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        users.Add(new UserView((int)reader[0], reader[1].ToString()!, (int)reader[2],
                            reader[3].ToString()!, DateOnly.FromDateTime(((DateTime)reader[4])), reader[5].ToString()!, (double)reader[6], reader[7].ToString()!, reader[8].ToString()!));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия пользователя в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return users;
        }

        public static List<UserView>? GetWorkers()
        {
            List<UserView>? users = new List<UserView>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select u.ID, u.PHYO, u.ROLE_ID, r.NAME, u.BIRTHDAY, u.PHONE, u.BALANCE, u.LOGIN, u.PASSWORD " +
                        "from USER_SYSTEM u " +
                        "join ROLE r on r.ID = u.ROLE_ID " +
                        "where r.NAME = 'Продавец'";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        users.Add(new UserView((int)reader[0], reader[1].ToString()!, (int)reader[2],
                            reader[3].ToString()!, DateOnly.FromDateTime(((DateTime)reader[4])), reader[5].ToString()!, (double)reader[6], reader[7].ToString()!, reader[8].ToString()!));
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при проверке наличия пользователя в системе,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return users;
        }

        public static bool DeleteUser(int userId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "delete from USER_SYSTEM " +
                        "where ID = @UserId";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("UserId", userId);

                    int resultQuery = cmd.ExecuteNonQuery();
                }
            }

            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при удалении пользователя пользователя,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static List<UserRole>? GetRoles()
        {
            List<UserRole>? roles = new List<UserRole>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionStr.connectionString))
                {
                    connection.Open();

                    string sqlExp = "select * " +
                        "from ROLE";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connection);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                        return null;

                    while (reader.Read())
                        roles.Add(new UserRole((int)reader[0], reader[1].ToString()?? "Отсутствует"));
                }
            }

            catch(NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Было вызвано исключение при получении ролей пользователей,\n" +
                    "уведомьте разработчиков.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return roles;
        }
    }
}
