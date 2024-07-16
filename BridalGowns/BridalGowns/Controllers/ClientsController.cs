using BL;
using BL.API;
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

        [HttpPut("{id}")]
        public ActionResult<ClientDTO> Update(string id, ClientDTO clientDTO)
        {
            if (id != clientDTO.Id)
            {
                return BadRequest("The ID in the URL does not match the ID in the client data.");
            }

            var updatedClient = clientService.Update(clientDTO);
            if (updatedClient == null)
            {
                return NotFound($"Client with ID {id} not found.");
            }

            return Ok(updatedClient);
        }
        //[HttpPut("{name}")]
        //public ActionResult<ClientDTO> Update(string name, ClientDTO clientDTO)
        //{
        //    if (name != clientDTO.FirstName)
        //    {
        //        return BadRequest();
        //    }

        //    var updatedClient = clientService.Update(clientDTO);
        //    if (updatedClient == null)
        //    {
        //        return NotFound();
        //    }

        //    return updatedClient;
        //}

        [HttpPost]
        public ActionResult<ClientDTO> Add(ClientDTO client)
        {
            return clientService.Add(client);
        }

    }
}
