using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IMeetingScheduleRepo
    {
        OrderSchedule Get(DateTime time);

        OrderSchedule Add(OrderSchedule meetingsSchedule);
        List<OrderSchedule> GetAll();


        OrderSchedule Delete(DateTime time);
    }
}
