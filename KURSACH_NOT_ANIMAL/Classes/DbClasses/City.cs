using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }

        public City(int id, int countryId, string name)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }
    }
}
