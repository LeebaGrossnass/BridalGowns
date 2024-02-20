using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrownsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Crown>> GetAll()
        {
           throw new NotImplementedException();
        }

        [HttpGet("{CrownCode}")]
        public ActionResult<Crown> Get(int crownCode)
        {
            throw null;
        }

        [HttpPut("{CrownCode}")]
        public ActionResult<Crown> Update(int crownCode, Crown crown)
        {
            return null;
        }

        [HttpPost]
        public ActionResult<Crown> Add(Crown crown)
        {
            return null;
        }
        [HttpDelete("{CrownCode}")]
        public ActionResult<Crown> Delete(int crownCode)
        {
            return null;
        }




    }

    

    
}
