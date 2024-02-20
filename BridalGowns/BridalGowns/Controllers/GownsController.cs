using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GownsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Gown>> GetAll()
        {
            throw new NotImplementedException();                                           
        }

        [HttpGet]
        public ActionResult<Gown> Get(string id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult<Gown> Delete(string id)
        {  
           throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult<Gown> Add(Gown Gown)
        {
           throw null;
        }

        [HttpPut]
        public ActionResult<Gown> Update(Gown Gown) 
        {
            throw null;
        }


        
    }
}
