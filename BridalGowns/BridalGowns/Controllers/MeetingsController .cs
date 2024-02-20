using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Meeting>> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{code}")]
        public ActionResult<Meeting> Get(int code)
        {
            throw null;
        }

        [HttpPut("{code}")]
        public ActionResult<Meeting> Update(int code, Meeting meeting)
        {
            return null;
        }

        [HttpPost]
        public ActionResult<Meeting> Add(Meeting meeting)
        {
            return null;
        }
        [HttpDelete("{code}")]
        public ActionResult<Crown> Delete(int code)
        {
            return null;
        }

    }
}
