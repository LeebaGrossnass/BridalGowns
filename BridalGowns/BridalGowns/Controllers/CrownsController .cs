using DAL.API;
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
            return crownRepo.GetAll();
        }

        [HttpGet("{CrownName}")]
        public ActionResult<Crown> Get(string crownName)
        {
            return crownRepo.Get(crownName);
        }

        [HttpPut]
        public ActionResult<Crown> Update(Crown crown)
        {
            return crownRepo.Update(crown);
        }

        [HttpPost]
        public ActionResult<Crown> Add(Crown crown)
        {
            return crownRepo.Add(crown);
        }

        [HttpDelete("{CrownName}")]
        public ActionResult<Crown> Delete(String crownName)
        {
            return crownRepo.Delete(crownName);
        }




    }

    

    
}
