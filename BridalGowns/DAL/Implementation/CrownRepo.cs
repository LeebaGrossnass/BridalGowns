using DAL.API;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class CrownRepo : ICrownRepo
    {
        BridalContext context;
        public CrownRepo(BridalContext context)
        {
            this.context = context;
        }

        public Crown Add(Crown crown)
        {
            context.Crowns.Add(crown);
            context.SaveChanges();
            return crown;
        }

        public Crown Delete(string name)
        {
            try
            {
                var crownToDelete = context.Crowns.Where(crown => crown.Name == name).FirstOrDefault();
                context.Crowns.Remove(crownToDelete);
                context.SaveChanges();
                return crownToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting Crown {name} data");
            }
        }

        public Crown Get(string name)
        {
            try
            {
                return  context.Crowns.Where(crown => crown.Name == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Crown {name} data");
            }
        }

        public List<Crown> GetAll()
        {
            return context.Crowns.ToList();
        }

        public Crown Update(Crown crown)
        {
            foreach (Crown c in context.Crowns.ToList())
            {
                if (c.CrownCode == crown.CrownCode)
                {
                    c.Price = crown.Price;
                    break;
                }
            }
            context.SaveChanges();
            return crown;
        }
    }
}
