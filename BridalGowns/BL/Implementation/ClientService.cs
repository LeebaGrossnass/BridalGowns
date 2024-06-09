using BL.API;
using BL.DTO;
using DAL;
using DAL.Implementation;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    public class ClientService : IClientService
    {
        ClientRepo clients;
        public ClientService(DALManager manager)
        {
            this.clients = manager.clientRepo;
        }
        public ClientDTO Add(ClientDTO client)
        {
            Client c = new Client();
            c.Id = client.Id;
            c.LastName = client.LastName;
            c.FirstName = client.FirstName;
            c.Email = client.Email;
            c.PhoneNumber = client.PhoneNumber;
            c.Password = client.Password;
            clients.Add(c);
            return client;
        }

        public ClientDTO Get(string id)
        {
            Client c =  clients.Get(id);
            if (c == null)
            {
                return null;
            }
            ClientDTO client = new ClientDTO(c.Id,c.FirstName,c.LastName,c.PhoneNumber,c.Email, c.Password);
            return client;
        }

        public List<ClientDTO> GetAll()
        {
            List<Client> list = clients.GetAll();
            List<ClientDTO> result = new List<ClientDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new ClientDTO(list[i].Id, list[i].FirstName, list[i].LastName, list[i].PhoneNumber, list[i].Email, list[i].Password));
            }
            return result;
        }

        public ClientDTO Update(ClientDTO client)
        {
            Client c = new Client();
            c.Id = client.Id;
            c.FirstName = client.FirstName;
            c.LastName = client.LastName;
            c.PhoneNumber = client.PhoneNumber;
            c.Email = client.Email;
            c.Password = client.Password;
            clients.Update(c);
            return client;
        }


    }
}
