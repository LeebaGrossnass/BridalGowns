using BL.Implementation;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.DTO;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrownsController : ControllerBase
    {
        CrownService crownService;
        public CrownsController(BLManager manager)
        {
            this.crownService = manager.crownService;
        }

        [HttpGet]
        public ActionResult<List<CrownDTO>> GetAll()
        {
            return crownService.GetAll();
        }

        [HttpGet("{CrownName}")]
        public ActionResult<CrownDTO> Get(string crownName)
        {
            return crownService.Get(crownName);
        }

        [HttpPut]
        public ActionResult<CrownDTO> Update(CrownDTO crown)
        {
            return crownService.Update(crown);
        }

        [HttpPost]
        public ActionResult<CrownDTO> Add(CrownDTO crown)
        {
            return crownService.Add(crown);
        }

        [HttpDelete("{CrownName}")]
        public ActionResult<CrownDTO> Delete(String crownName)
        {
            return crownService.Delete(crownName);
        }




    }

    

    
}
