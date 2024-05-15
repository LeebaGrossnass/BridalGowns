using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IOrderRepo
    {
        List<Order> GetAll();

        Order Get(string orderNumber);

        Order Add(Order order);

        Order Update(Order order);

        Order Delete(string orderNumber);

    }
}
