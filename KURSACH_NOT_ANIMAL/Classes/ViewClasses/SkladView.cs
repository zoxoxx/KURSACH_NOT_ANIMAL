using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.ViewClasses
{
    public class SkladView
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Count { get; set; }
        public string? PartnerName { get; set; }
        public double PurchasePrice { get; set; }
        public DateOnly DatePrihod { get; set; }

        public SkladView(int id, string? productName, int count, string? partnerName, double purchasePrice, DateOnly datePrihod)
        {
            Id = id;
            ProductName = productName;
            Count = count;
            PartnerName = partnerName;
            PurchasePrice = purchasePrice;
            DatePrihod = datePrihod;
        }
    }
}
