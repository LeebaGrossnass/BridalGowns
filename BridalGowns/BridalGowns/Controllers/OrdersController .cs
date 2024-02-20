using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{OrderNumber}")]
        public ActionResult<Order> Get(string orderNumber)
        {
            throw null;
        }

        [HttpPut("{OrderNumber}")]
        public ActionResult<Order> Update(string orderNumber, Order order)
        {
            return null;
        }

        [HttpPost]
        public ActionResult<Order> Add(Order order)
        {
            return null;
        }

    }
}
