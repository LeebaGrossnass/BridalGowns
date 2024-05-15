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
    public class OrderService : IOrderService
    {
        OrderRepo orders;
        public OrderService(DALManager manager)
        {
            this.orders = manager.orderRepo;
        }

        public OrderDTO Add(OrderDTO order)
        {
            Order o = new Order();
            o.OrderNumber = order.OrderNumber;
            o.WeddingDate = order.WeddingDate;
            o.ClientId = order.ClientId;
            o.GownCode = order.GownCode;
            o.CrownCode = order.CrownCode;
            o.ToatlPayment = order.ToatlPayment;
            o.PickedUp = order.PickedUp;
            o.Returned = order.Returned;
            orders.Add(o);
            return order;
        }

        public OrderDTO Delete(string orderNumber)
        {
            Order o = orders.Delete(orderNumber);
            return new OrderDTO() { OrderNumber = orderNumber, WeddingDate = o.WeddingDate, ClientId = o.ClientId,GownCode = o.GownCode,
                 CrownCode = o.CrownCode, ToatlPayment = o.ToatlPayment, PickedUp = o.PickedUp, Returned = o.Returned };
        }

        public OrderDTO Get(String orderNumber)
        {
            Order o = orders.Get(orderNumber);
            if (o == null)
            {
                return null;
            }
            OrderDTO order = new OrderDTO(o.OrderNumber, o.WeddingDate,  o.GownCode, o.CrownCode,o.ClientId, o.ToatlPayment,
                o.PickedUp, o.Returned);
            return order;
        }

        public List<OrderDTO> GetAll()
        {
            List<Order> list = orders.GetAll();
            List<OrderDTO> result = new List<OrderDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new OrderDTO(list[i].OrderNumber, list[i].WeddingDate, list[i].GownCode,
                    list[i].CrownCode, list[i].ClientId, list[i].ToatlPayment, list[i].PickedUp, list[i].Returned));
            }
            return result;
        }

        public OrderDTO Update(OrderDTO order)
        {
            Order o = new Order();
            o.OrderNumber = order.OrderNumber;
            o.WeddingDate = order.WeddingDate;
            o.GownCode = order.GownCode;
            o.CrownCode = order.CrownCode;
            o.ClientId = order.ClientId;
            o.ToatlPayment = order.ToatlPayment;
            o.PickedUp = order.PickedUp;
            o.Returned = order.Returned;
            orders.Update(o);
            return order;
        }
    }
}
