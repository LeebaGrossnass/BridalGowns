using BL.API;
using BL.DTO;
using BL.API;
using BL.DTO;
using DAL.Implementation;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    public class AccessRightService : IAccessRightService
    {
        AccessRightRepo accessRights;
        public AccessRightService(DALManager manager)
        {
            this.accessRights = manager.accessRightRepo;
        }
        public AccessRightDTO Add(AccessRightDTO accessRight)
        {
            AccessRight ar = new AccessRight();
            ar.Email = accessRight.Email;
            ar.Password = accessRight.Password;
            accessRights.Add(ar);
            return accessRight;
        }

        public AccessRightDTO Delete(string password)
        {
            AccessRight ar = accessRights.Delete(password);
            return new AccessRightDTO()
            {
               Password = password,
               Email  = ar.Email
            };
        }

        public AccessRightDTO Get(string password)
        {
            AccessRight ar = accessRights.Get(password);
            if (ar == null)
            {
                return null;
            }
            AccessRightDTO accessRight = new AccessRightDTO(ar.Id, ar.Email, ar.Password);
            return accessRight;
        }

        public List<AccessRightDTO> GetAll()
        {
            List<AccessRight> list = accessRights.GetAll();
            List<AccessRightDTO> result = new List<AccessRightDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new AccessRightDTO(list[i].Id, list[i].Email, list[i].Password));
            }
            return result;
        }

        public AccessRightDTO Update(AccessRightDTO accessRight)
        {
            AccessRight ar = new AccessRight();
            ar.Id = accessRight.Id;
            ar.Email = accessRight.Email;
            ar.Password = accessRight.Password;
            accessRights.Update(ar);
            return accessRight;
        }
    }
}
