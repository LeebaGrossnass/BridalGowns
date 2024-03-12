using DAL.API;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        IOrderRepo orderRepo;
        public OrdersController(IOrderRepo orderRepo)
        {
            this.orderRepo = orderRepo;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetAll()
        {
            return orderRepo.GetAll();
        }

        [HttpGet("{OrderNumber}")]
        public ActionResult<Order> Get(string orderNumber)
        {
            return orderRepo.Get(orderNumber);
        }

        [HttpPut]
        public ActionResult<Order> Update(Order order)
        {
            return orderRepo.Update(order);
        }

        [HttpPost]
        public ActionResult<Order> Add(Order order)
        {
            return orderRepo.Add(order);
        }

    }
}
