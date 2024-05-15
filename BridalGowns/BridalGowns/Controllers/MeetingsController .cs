using BL.DTO;
using BL.Implementation;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        MeetingService meetingService;
        public MeetingsController(BLManager manager)
        {
            this.meetingService = manager.meetingService;
        }

        [HttpGet]
        public ActionResult<List<MeetingDTO>> GetAll()
        {
            return meetingService.GetAll();
        }

        [HttpGet("{time}")]
        public ActionResult<MeetingDTO> Get(DateTime time)
        {
            return meetingService.Get(time);
        }

        [HttpPut]
        public ActionResult<MeetingDTO> Update(MeetingDTO meeting)
        {
            return meetingService.Update(meeting);
        }

        [HttpPost]
        public ActionResult<MeetingDTO> Add(MeetingDTO meeting)
        {
            return meetingService.Add(meeting);
        }

        [HttpDelete("{time}")]
        public ActionResult<MeetingDTO> Delete(DateTime time)
        {
            return meetingService.Delete(time);
        }

    }
}
