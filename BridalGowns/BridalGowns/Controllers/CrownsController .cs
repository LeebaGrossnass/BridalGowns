using DAL.Implementation;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrownsController : ControllerBase
    {
        ICrownRepo crownRepo;
        public CrownsController(ICrownRepo crownRepo)
        {
            this.crownRepo = crownRepo;
        }

        [HttpGet]
        public ActionResult<List<Crown>> GetAll()
        {
            return GetAll();
        }

        [HttpGet("{CrownName}")]
        public ActionResult<Crown> Get(string crownName)
        {
            return Get(crownName);
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
