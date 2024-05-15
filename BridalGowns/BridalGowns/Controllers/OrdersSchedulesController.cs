using BL.Implementation;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.DTO;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersSchedulesController : ControllerBase
    {
        OrdersScheduleService ordersScheduleService;
        public OrdersSchedulesController(BLManager manager)
        {
            this.ordersScheduleService = manager.ordersScheduleService;
        }

        [HttpGet("{time}")]
        public ActionResult<OrdersScheduleDTO> Get(DateTime time)
        {
            return ordersScheduleService.Get(time);
        }

        [HttpDelete("{time}")]
        public ActionResult<OrdersScheduleDTO> Delete(DateTime time)
        {
            return ordersScheduleService.Delete(time);
        }

        [HttpPost]
        public ActionResult<OrdersScheduleDTO> Add(OrdersScheduleDTO schedule)
        {
            return ordersScheduleService.Add(schedule);
        }
        public ActionResult<List<OrdersScheduleDTO>> GetAll()
        {
            return ordersScheduleService.GetAll();
        }
    }
}
