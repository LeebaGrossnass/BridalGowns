using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IOrdersScheduleService
    {
        List<OrdersScheduleDTO> GetAll();
        OrdersScheduleDTO Get(DateTime time);

        OrdersScheduleDTO Add(OrdersScheduleDTO schedule);

        OrdersScheduleDTO Delete(DateTime time);
    }
}
