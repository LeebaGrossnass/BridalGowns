using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IClientService
    {
        List<ClientDTO> GetAll();
        ClientDTO Get(string id);
        ClientDTO Add(ClientDTO client);
        ClientDTO Update(ClientDTO client);

    }
}
