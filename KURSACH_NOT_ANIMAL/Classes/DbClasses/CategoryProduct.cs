using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class CategoryProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public CategoryProduct(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public CategoryProduct(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public CategoryProduct() { }
    }
}
