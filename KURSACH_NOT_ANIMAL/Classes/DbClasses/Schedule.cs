using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.DbClasses
{
    public class Schedule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateOnly DateJob { get; set; }
        public TimeOnly TimeStart {  get; set; }
        public TimeOnly TimeEnd { get; set; }

        public Schedule(int id, int userId, DateOnly dateJob, TimeOnly timeStart, TimeOnly timeEnd)
        {
            Id = id;
            UserId = userId;
            DateJob = dateJob;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
        }
    }
}
