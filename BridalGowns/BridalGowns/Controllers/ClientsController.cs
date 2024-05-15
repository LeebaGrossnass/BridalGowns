using BL;
using BL.DTO;
using BL.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridalGowns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        ClientService clientService;
        public ClientsController(BLManager manager)
        {
            this.clientService = manager.clientService;
        }

        [HttpGet]
        public ActionResult<List<ClientDTO>> GetAll()
        {
            return clientService.GetAll();
        }

        [HttpGet("{ID}")]
        public ActionResult<ClientDTO> Get(string ID)
        {
            return clientService.Get(ID);
        }

        [HttpPut("{ID}")]
        public ActionResult<ClientDTO> Update(ClientDTO client)
        {
            return clientService.Update(client);
        }

        [HttpPost]
        public ActionResult<ClientDTO> Add(ClientDTO client)
        {
            return clientService.Add(client);
        }

    }
}
