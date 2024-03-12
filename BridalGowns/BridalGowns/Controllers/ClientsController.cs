using DAL.API;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        IClientRepo clientRepo;
        public ClientsController(IClientRepo clientRepo)
        {
            this.clientRepo = clientRepo;
        }

        [HttpGet]
        public ActionResult<List<Client>> GetAll()
        {
            return clientRepo.GetAll();
        }

        [HttpGet("{ID}")]
        public ActionResult<Client> Get(string ID)
        {
            return clientRepo.Get(ID);
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
