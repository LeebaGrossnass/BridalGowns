using DAL.API;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        IMeetingRepo meetingRepo;
        public MeetingsController(IMeetingRepo meetingRepo)
        {
            this.meetingRepo = meetingRepo;
        }

        [HttpGet]
        public ActionResult<List<Meeting>> GetAll()
        {
            return meetingRepo.GetAll();
        }

        [HttpGet("{time}")]
        public ActionResult<Meeting> Get(DateTime time)
        {
            return meetingRepo.Get(time);
        }

        [HttpPut]
        public ActionResult<Meeting> Update(Meeting meeting)
        {
            return meetingRepo.Update(meeting);
        }

        [HttpPost]
        public ActionResult<Meeting> Add(Meeting meeting)
        {
            return meetingRepo.Add(meeting);
        }

        [HttpDelete("{time}")]
        public ActionResult<Meeting> Delete(DateTime time)
        {
            return meetingRepo.Delete(time);
        }

    }
}
