using DAL.API;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class MeetingScheduleRepo : IMeetingScheduleRepo
    {
        BridalContext context;
        public MeetingScheduleRepo(BridalContext context)
        {
            this.context = context;
        }

        public OrderSchedule Add(OrderSchedule meetingsSchedule)
        {
            context.MeetingsSchedules.Add(meetingsSchedule);
            context.SaveChanges();
            return meetingsSchedule;
        }

        public OrderSchedule Delete(DateTime time)
        {
            try
            {
                var scheduleToDelete = context.MeetingsSchedules.Where(s => s.Date == time).FirstOrDefault();
                context.MeetingsSchedules.Remove(scheduleToDelete);
                context.SaveChanges();
                return scheduleToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting from schedule date: {time}");
            }
        }

        public OrderSchedule Get(DateTime time)
        {
            try
            {
                return context.MeetingsSchedules.Where(s => s.Date == time).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single date {time} data");
            }
        }
        public List<OrderSchedule> GetAll()
        {
            return context.MeetingsSchedules.ToList();
        }
    }
}
