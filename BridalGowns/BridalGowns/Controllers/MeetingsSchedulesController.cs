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
    public class MeetingsSchedulesController : ControllerBase
    {
        MeetingScheduleService meetingScheduleService;
        public MeetingsSchedulesController(BLManager manager)
        {
            this.meetingScheduleService = manager.meetingScheduleService;
        }

        [HttpGet]
        public ActionResult<List<MeetingScheduleDTO>> GetAll()
        {
            return meetingScheduleService.GetAll();
        }

        [HttpGet("{time}")]
        public ActionResult<MeetingScheduleDTO> Get(DateTime time)
        {
            return meetingScheduleService.Get(time);
        }

        [HttpDelete("{time}")]
        public ActionResult<MeetingScheduleDTO> Delete(DateTime time)
        {
            return meetingScheduleService.Delete(time);
        }

        [HttpPost]
        public ActionResult<MeetingScheduleDTO> Add(MeetingScheduleDTO schedule)
        {
            return meetingScheduleService.Add(schedule);
        }
       
    }
}
