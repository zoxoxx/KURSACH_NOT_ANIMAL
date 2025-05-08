using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.ViewClasses
{
    public class OperationView
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public double Summa { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string ClientName { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }

        public OperationView(int id, string product, int count, double summa, DateOnly date, TimeOnly time, string clientName, string userName, string status)
        {
            Id = id;
            Product = product;
            Count = count;
            Summa = summa;
            Date = date;
            Time = time;
            ClientName = clientName;
            UserName = userName;
            Status = status;
        }

        public OperationView()
        {
        }
    }
}
