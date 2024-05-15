using BL.API;
using BL.DTO;
using DAL;
using DAL.API;
using DAL.Implementation;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    public class OrdersScheduleService : IOrdersScheduleService
    {
        OrdersScheduleRepo ordersSchedules;
        public OrdersScheduleService(DALManager manager)
        {
            this.ordersSchedules = manager.ordersScheduleRepo;
        }

        public OrdersScheduleDTO Add(OrdersScheduleDTO schedule)
        {
            OrdersSchedule s = new OrdersSchedule();
            s.Date = schedule.Date;
            s.GownCode = schedule.GownCode;
            //s.CrownCode = schedule.CrownCode;
            ordersSchedules.Add(s);
            return schedule;
        }

        public OrdersScheduleDTO Delete(DateTime time)
        {
            OrdersSchedule s = ordersSchedules.Delete(time);
            return new OrdersScheduleDTO() { Date = time,GownCode = s.GownCode, /*CrownCode = s.CrownCode*/};
           
        }
        public OrdersScheduleDTO Get(DateTime time)
        {
            OrdersSchedule s = ordersSchedules.Get(time);
            if (s == null)
            {
                return null;
            }
            OrdersScheduleDTO schedule = new OrdersScheduleDTO(s.Date, s.GownCode /*, s.CrownCode*/);
            return schedule;
        }
        public List<OrdersScheduleDTO> GetAll()
        {
            List<OrdersSchedule> list = ordersSchedules.GetAll();
            List<OrdersScheduleDTO> result = new List<OrdersScheduleDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new OrdersScheduleDTO(list[i].Date, list[i].GownCode));
            }
            return result;
        }

    }
}
