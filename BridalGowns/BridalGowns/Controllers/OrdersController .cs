using BL.DTO;
using BL.Implementation;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.API;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        OrderService orderService;
        public OrdersController(BLManager manager)
        {
            this.orderService = manager.orderService;
        }

        [HttpGet]
        public ActionResult<List<OrderDTO>> GetAll()
        {
            return orderService.GetAll();
        }

        [HttpGet("{OrderNumber}")]
        public ActionResult<OrderDTO> Get(string orderNumber)
        {
            return orderService.Get(orderNumber);
        }

        [HttpPut]
        public ActionResult<OrderDTO> Update(OrderDTO order)
        {
            return orderService.Update(order);
        }

        [HttpPost]
        public ActionResult<OrderDTO> Add(OrderDTO order)
        {
            return orderService.Add(order);
        }

    }
}
