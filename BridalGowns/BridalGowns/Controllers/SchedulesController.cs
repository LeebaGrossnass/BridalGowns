using DAL.API;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        ISceduleRepo sceduleRepo;
        public SchedulesController(ISceduleRepo sceduleRepo)
        {
            this.sceduleRepo = sceduleRepo;
        }

        [HttpGet("{time}")]
        public ActionResult<Schedule> Get(DateTime time)
        {
            return sceduleRepo.Get(time);
        }

        [HttpDelete("{time}")]
        public ActionResult<Schedule> Delete(DateTime time)
        {
            return sceduleRepo.Delete(time);
        }

        [HttpPost]
        public ActionResult<Schedule> Add(Schedule schedule)
        {
            return sceduleRepo.Add(schedule);
        }
        public ActionResult<List<Schedule>> GetAll()
        {
            return sceduleRepo.GetAll();
        }
    }
}
