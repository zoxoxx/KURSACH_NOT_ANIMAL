using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.ViewClasses
{
    public class ShopView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }

        public ShopView(int id, string name, string adress, int cityId, string cityName)
        {
            Id = id;
            Name = name;
            Adress = adress;
            CityId = cityId;
            CityName = cityName;
        }
    }
}
