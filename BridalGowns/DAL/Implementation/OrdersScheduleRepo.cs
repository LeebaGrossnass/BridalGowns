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
    public class OrdersScheduleRepo : IOrdersScheduleRepo
    {
        BridalContext context;
        public OrdersScheduleRepo(BridalContext context)
        {
            this.context = context;
        }

        public OrdersSchedule Add(OrdersSchedule ordersSchedule)
        {
            context.OrdersSchedules.Add(ordersSchedule);
            context.SaveChanges();
            return ordersSchedule;
        }

        public OrdersSchedule Delete(DateTime time)
        {
            try
            {
                var scheduleToDelete = context.OrdersSchedules.Where(s => s.Date == time).FirstOrDefault();
                context.OrdersSchedules.Remove(scheduleToDelete);
                context.SaveChanges();
                return scheduleToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting from schedule date: {time}");
            }
        }

        public OrdersSchedule Get(DateTime time)
        {
            try
            {
                return context.OrdersSchedules.Where(s => s.Date == time).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single date {time} data");
            }
        }
        public List<OrdersSchedule> GetAll()
        {
            return context.OrdersSchedules.ToList();
        }
    }
}
