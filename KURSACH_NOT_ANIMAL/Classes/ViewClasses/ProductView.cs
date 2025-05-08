using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.ViewClasses
{
    public class ProductView
    {
        public int Id { get; set; }
        public double? Weight { get; set; }
        public string Name { get; set; }
        public string? Commentary { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }

        public ProductView(int id, double weight, string name, string? commentary, string? description, int categoryId, double price, string categoryName) 
        {
            Id = id;
            Weight = weight;
            Name = name;
            Commentary = commentary;
            Description = description;
            CategoryId = categoryId;
            CategoryName = categoryName;
            Price = price;
        }
    }
}
