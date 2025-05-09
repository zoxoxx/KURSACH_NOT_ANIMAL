using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class RecomendationProduct
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public int ProductId { get; set; }

        public RecomendationProduct(int id, string animalName, int productId)
        {
            Id = id;
            AnimalName = animalName;
            ProductId = productId;
        }
    }
}
