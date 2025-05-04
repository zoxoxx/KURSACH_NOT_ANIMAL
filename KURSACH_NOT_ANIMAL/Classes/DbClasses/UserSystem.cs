using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class UserSystem
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string PHYO { get; set; }
        public DateOnly Birthday { get; set; }
        public string? Phone { get; set; }
        public double Balance { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserSystem(int id, int roleId, string pHYO, DateOnly birthday, string? phone, double balance, string login, string password)
        {
            Id = id;
            RoleId = roleId;
            PHYO = pHYO;
            Birthday = birthday;
            Phone = phone;
            Balance = balance;
            Login = login;
            Password = password;
        }

        public UserSystem(string pHYO, DateOnly birthday, string? phone, double balance, string login, string password)
        {
            PHYO = pHYO;
            Birthday = birthday;
            Phone = phone;
            Balance = balance;
            Login = login;
            Password = password;
        }
    }
}
