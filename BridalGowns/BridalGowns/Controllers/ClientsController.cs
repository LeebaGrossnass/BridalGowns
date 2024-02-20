using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {


        [HttpGet]
        public ActionResult<List<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{ID}")]
        public ActionResult<Client> Get(string ID)
        {
            throw null;
        }

        [HttpPut("{ID}")]
        public ActionResult<Client> Update(string ID, Client client)
        {
            return null;
        }

        [HttpPost]
        public ActionResult<Crown> Add(Client client)
        {
            return null;
        }

    }
}
