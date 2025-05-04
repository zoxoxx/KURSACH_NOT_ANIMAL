using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.ViewClasses
{
    class AnimalView
    {
        public int AnimalId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        

        public AnimalView(int id, string name, string desciption, string categoryName, string categoryDescription, int categoryId)
        {
            AnimalId = id;
            Name = name;
            Description = desciption;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
            CategoryId = categoryId;
        }

        public AnimalView(int id) 
        {
            AnimalId = id;
        }
    }
}
