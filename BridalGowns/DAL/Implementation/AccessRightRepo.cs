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
    public class AccessRightRepo : IAccessRightRepo
    {
        BridalContext context;
        public AccessRightRepo(BridalContext context)
        {
            this.context = context;
        }

        public AccessRight Add(AccessRight accessRight)
        {
            context.AccessRights.Add(accessRight);
            context.SaveChanges();
            return accessRight;
        }

        public AccessRight Delete(string password)
        {
            try
            {
                var accessRightToDelete = context.AccessRights.Where(accessRight => accessRight.Password == password).FirstOrDefault();
                context.AccessRights.Remove(accessRightToDelete);
                context.SaveChanges();
                return accessRightToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting AccessRights {password} data");
            }
        }

        public AccessRight Get(string password)
        {
            try
            {
                return context.AccessRights.Where(accessRight => accessRight.Password == password).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single accessRight {password} data");
            }
        }

        public List<AccessRight> GetAll()
        {
            return context.AccessRights.ToList();
        }

        public AccessRight Update(AccessRight accessRight)
        {
            foreach (AccessRight ar in context.AccessRights.ToList())
            {
                if (ar.Id == accessRight.Id)
                {
                    ar.Password = accessRight.Password;
                    break;
                }
            }
            context.SaveChanges();
            return accessRight;
        }
    }
}
