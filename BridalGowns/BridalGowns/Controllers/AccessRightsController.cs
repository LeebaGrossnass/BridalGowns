using BL.Implementation;
using BL;
using Microsoft.AspNetCore.Mvc;
using BL.API;
using BL.DTO;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessRightsController: ControllerBase
    {
        AccessRightService accessRightService;
        public AccessRightsController(BLManager manager)
        {
            this.accessRightService = manager.accessRightService;
        }

        [HttpGet]
        public ActionResult<List<AccessRightDTO>> GetAll()
        {
            return accessRightService.GetAll();
        }

        [HttpGet("{ID}")]
        public ActionResult<AccessRightDTO> Get(string pass)
        {
            return accessRightService.Get(pass);
        }

        [HttpPut("{ID}")]
        public ActionResult<AccessRightDTO> Update(AccessRightDTO accessRight)
        {
            return accessRightService.Update(accessRight);
        }

        [HttpPost]
        public ActionResult<AccessRightDTO> Add(AccessRightDTO accessRight)
        {
            return accessRightService.Add(accessRight);
        }

        [HttpDelete("{id}")]
        public ActionResult<AccessRightDTO> Delete(string pass)
        {
            return accessRightService.Delete(pass);
        }

    }
}
