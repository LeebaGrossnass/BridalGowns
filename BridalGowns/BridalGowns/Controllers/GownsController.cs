using DAL.API;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GownsController : ControllerBase
    {
        IGownRepo gownRepo;
        public GownsController(IGownRepo gownRepo) 
        { 
            this.gownRepo = gownRepo;
        }

        [HttpGet]
        public ActionResult<List<Gown>> GetAll()
        {
            return gownRepo.GetAll();                                           
        }

        [HttpGet( "{id}")]
        public ActionResult<Gown> Get(string id)
        {
            return gownRepo.Get(id);
        }

        [HttpDelete("{id}")]
        public ActionResult<Gown> Delete(string id)
        {  
           return gownRepo.Delete(id);
        }

        [HttpPost]
        public ActionResult<Gown> Add(Gown gown)
        {
           return gownRepo.Add(gown);
        }

        [HttpPut]
        public ActionResult<Gown> Update(Gown gown) 
        {
            return gownRepo.Update(gown);
        }


        
    }
}
