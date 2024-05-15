using DAL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IOrdersScheduleRepo
    {
        OrdersSchedule Get(DateTime time);

        OrdersSchedule Add(OrdersSchedule ordersSchedule);
        List<OrdersSchedule> GetAll();


        OrdersSchedule Delete(DateTime time);
    }
}
