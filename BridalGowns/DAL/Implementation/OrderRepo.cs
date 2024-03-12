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
    public class OrderRepo : IOrderRepo
    {
        BridalContext context;
        public OrderRepo(BridalContext context)
        {
            this.context = context;
        }

        public Order Add(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            return order;
        }

        public Order Get(string orderNumber)
        {
            try
            {
                return context.Orders.Where(o => o.OrderNumber == orderNumber).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single order {orderNumber} data");
            }
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public Order Update(Order order)
        {
            foreach (Order o in context.Orders.ToList())
            {
                if (o.OrderNumber == order.OrderNumber)
                {
                    o.PickedUp = order.PickedUp;
                    o.Returned = order.Returned;
                    o.ToatlPayment = order.ToatlPayment;
                    break;
                }
            }
            context.SaveChanges();
            return order;
        }
    }
}
