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

        public Client Update(string id, Client client)
        {

            foreach (var c in context.Clients.ToList())
            {
                if (c.Id == id)
                {
                    c.Id= client.Id;
                    c.FirstName= client.FirstName;
                    c.LastName= client.LastName;
                    c.Email= client.Email;
                    c.PhoneNumber= client.PhoneNumber;
                    break;
                }
            }
            return client;
        }
    }
}
