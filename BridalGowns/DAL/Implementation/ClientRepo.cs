using DAL.API;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class ClientRepo : IClientRepo
    {
        BridalContext context;
        public ClientRepo(BridalContext context)
        {
            this.context = context;
        }

        public Client Add(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
            return client;
        }

        public Client Get(string id)
        {
            try
            {
                return context.Clients.Where(client => client.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Gown {id} data");
            }
        }

        public List<Client> GetAll()
        {
            return context.Clients.ToList();
        }

        public BridalContext GetContext()
        {
            return context;
        }

        public Client Update(Client client)
        {
            foreach (Client c in context.Clients.ToList())
            {
                if (c.Id == client.Id)
                {
                    c.Email = client.Email;
                    c.PhoneNumber = client.PhoneNumber;
                    break;
                }
            }
            context.SaveChanges();
            return client;
        }
    }
}
