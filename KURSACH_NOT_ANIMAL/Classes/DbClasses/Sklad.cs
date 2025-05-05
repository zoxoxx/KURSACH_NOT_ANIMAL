using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class Sklad
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public int ShopId { get; set; }
        public int PartnerId { get; set; }
        public double PurchasePrice { get; set; }
        public DateOnly DatePrihod { get; set; }
        public Sklad(int id, int productId, int count, int shopId, int partnerId, double purchasePrice, DateOnly datePrihod)
        {
            Id = id;
            ProductId = productId;
            Count = count;
            ShopId = shopId;
            PartnerId = partnerId;
            PurchasePrice = purchasePrice;
            DatePrihod = datePrihod;
        }
    }
}
