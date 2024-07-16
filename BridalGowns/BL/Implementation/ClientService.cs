using BL.API;
using BL.DTO;
using DAL;
using DAL.API;
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

        public ClientDTO Get(string name)
        {
            Client c =  clients.Get(name);
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


        //public ClientDTO Update(ClientDTO client)
        //{
        //    var updatedClient = new Client
        //    {
        //        Id = client.Id,
        //        FirstName = client.FirstName,
        //        LastName = client.LastName,
        //        Email = client.Email,
        //        PhoneNumber = client.PhoneNumber,
        //        Password = client.Password
        //    };

        //    clients.Update(updatedClient);
        //    return client;
        //}

        public ClientDTO Update(ClientDTO clientDTO)
        {
            Client client = new Client
            {
                Id = clientDTO.Id,
                FirstName = clientDTO.FirstName,
                LastName = clientDTO.LastName,
                Email = clientDTO.Email,
                PhoneNumber = clientDTO.PhoneNumber,
                Password = clientDTO.Password
            };

            Client updatedClient = clients.Update(client);

            if (updatedClient == null)
            {
                return null;
            }

            return new ClientDTO(updatedClient.Id, updatedClient.FirstName, updatedClient.LastName, updatedClient.PhoneNumber, updatedClient.Email, updatedClient.Password);
        }


    }
}
