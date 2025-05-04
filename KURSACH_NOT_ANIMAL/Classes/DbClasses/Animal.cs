using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public string Description { get; set; }

        public Animal(int id, string name, int categoryId, string description)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Description = description;
        }
    }
}
