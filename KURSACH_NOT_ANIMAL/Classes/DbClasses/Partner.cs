using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int CityId { get; set; }

        public Partner(int id, string name, string adress, int cityId)
        {
            Id = id;
            Name = name;
            Adress = adress;
            CityId = cityId;
        }
    }
}
