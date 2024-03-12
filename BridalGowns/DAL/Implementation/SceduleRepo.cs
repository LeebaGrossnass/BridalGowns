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
    public class SceduleRepo : ISceduleRepo
    {
        BridalContext context;
        public SceduleRepo(BridalContext context)
        {
            this.context = context;
        }

        public Schedule Add(Schedule schedule)
        {
            context.Schedules.Add(schedule);
            context.SaveChanges();
            return schedule;
        }

        public Schedule Delete(DateTime time)
        {
            try
            {
                var scheduleToDelete = context.Schedules.Where(s => s.Date == time).FirstOrDefault();
                context.Schedules.Remove(scheduleToDelete);
                context.SaveChanges();
                return scheduleToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting from schedule date: {time}");
            }
        }

        public Schedule Get(DateTime time)
        {
            try
            {
                return context.Schedules.Where(s => s.Date == time).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single date {time} data");
            }
        }
        public List<Schedule> GetAll()
        {
            return context.Schedules.ToList();
        }
    }
}
