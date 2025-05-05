using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserRole(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
