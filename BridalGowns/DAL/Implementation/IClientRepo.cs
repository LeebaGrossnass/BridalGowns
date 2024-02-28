using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public interface IClientRepo
    {
        List<Client> GetAll();

        Client Get(string id);

        Client Add(Client client);

        Client Update(string id, Client client);

    }
}
