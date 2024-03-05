using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class GownRepo : IGownRepo
    {
        BridalContext context;
        public GownRepo(BridalContext context)
        {
            this.context = context;
        }

        public Gown Add(Gown gown)
        {
            context.Gowns.Add(gown);
            context.SaveChanges();
            return gown;
        }

        public Gown Delete(string name)
        {
            try
            {
                var gownToDelete = context.Gowns.Where(gown => gown.Name == name).FirstOrDefault();
                context.Gowns.Remove(gownToDelete);
                context.SaveChanges();
                return gownToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting  Gown {name} data");
            }
        }

        public Gown Get(string name)
        {
            try
            {
                return context.Gowns.Where(gown => gown.Name == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Gown {name} data");
            }
        }

        public List<Gown> GetAll()
        {
            return context.Gowns.ToList();
        }

        public Gown Update(string id, Gown gown)
        {
            throw new NotImplementedException();
        }
    }
}
