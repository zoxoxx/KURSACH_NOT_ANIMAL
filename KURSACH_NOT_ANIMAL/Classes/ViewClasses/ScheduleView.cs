using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_NOT_ANIMAL.Classes.ViewClasses
{
    public class ScheduleView
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateOnly DateJob { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public TimeOnly TimeStart { get; set; } = new TimeOnly(9, 0);
        public TimeOnly TimeEnd { get; set; } = new TimeOnly(18, 0);
        public string PHYO { get; set; }

        public ScheduleView(int id, int userId, DateOnly dateJob, TimeOnly timeStart, TimeOnly timeEnd, string pHYO)
        {
            Id = id;
            UserId = userId;
            DateJob = dateJob;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            PHYO = pHYO;
        }

        public ScheduleView()
        {
        }
    }
}
