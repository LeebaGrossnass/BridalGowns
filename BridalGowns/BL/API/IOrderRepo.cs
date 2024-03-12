using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public interface IOrderRepo
    {
        List<Order> GetAll();

        Order Get(String orderNumber);

        Order Add(Order order);

        Order Update(Order order);

    }
}
