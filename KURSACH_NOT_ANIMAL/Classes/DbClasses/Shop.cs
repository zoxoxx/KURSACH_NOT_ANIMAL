using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int CityId { get; set; }
        
        public Shop(int Id, string Name, string Adress, int CityId)
        {
            this.Id = Id;
            this.Name = Name;
            this.Adress = Adress;
            this.CityId = CityId;
        }
    }
}
