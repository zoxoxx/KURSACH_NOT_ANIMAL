using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class Operation
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double Summa { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public Operation(int id, int productId, int count, double summa, DateOnly date, TimeOnly time, int clientId, int userId, int statusId)
        {
            Id = id;
            ProductId = productId;
            Count = count;
            Summa = summa;
            Date = date;
            Time = time;
            ClientId = clientId;
            UserId = userId;
            StatusId = statusId;
        }

        public Operation() { }
    }
}
