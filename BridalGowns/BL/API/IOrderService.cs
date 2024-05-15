using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IOrderService
    {
        List<OrderDTO> GetAll();

        OrderDTO Get(String orderNumber);

        OrderDTO Add(OrderDTO order);

        OrderDTO Update(OrderDTO order);

        OrderDTO Delete(String orderNumber);

    }
}
