using BL.Implementation;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.DTO;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GownsController : ControllerBase
    {
        GownService gownService;
        public GownsController(BLManager manager)
        {
            this.gownService = manager.gownService;
        }

        [HttpGet]
        public ActionResult<List<GownDTO>> GetAll()
        {
            return gownService.GetAll();                                           
        }

        [HttpGet( "{id}")]
        public ActionResult<GownDTO> Get(string id)
        {
            return gownService.Get(id);
        }

        [HttpDelete("{id}")]
        public ActionResult<GownDTO> Delete(string id)
        {  
           return gownService.Delete(id);
        }

        [HttpPost]
        public ActionResult<GownDTO> Add(GownDTO gown)
        {
           return gownService.Add(gown);
        }

        [HttpPut]
        public ActionResult<GownDTO> Update(GownDTO gown) 
        {
            return gownService.Update(gown);
        }


        
    }
}
