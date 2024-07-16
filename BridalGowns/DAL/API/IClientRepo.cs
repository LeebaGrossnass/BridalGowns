using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IClientRepo
    {
        List<Client> GetAll();

        Client Get(string name);

        Client Add(Client client);

        Client Update(Client client);

    }
}
