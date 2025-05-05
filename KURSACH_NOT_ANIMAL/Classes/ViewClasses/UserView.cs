using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.ViewClasses
{
    public class UserView
    {
        public int Id { get; set; }
        public string Phyo { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateOnly Birthday { get; set; }
        public string Phone { get; set; }
        public double Balance { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserView(int id, string phyo, int roleId, string roleName, DateOnly birthday, string phone, double balance, string login, string password)
        {
            Id = id;
            Phyo = phyo;
            RoleId = roleId;
            RoleName = roleName;
            Birthday = birthday;
            Phone = phone;
            Balance = balance;
            Login = login;
            Password = password;
        }
    }
}
