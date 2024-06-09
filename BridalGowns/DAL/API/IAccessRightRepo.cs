using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IAccessRightRepo
    {
        List<AccessRight> GetAll();

        AccessRight Get(string password);

        AccessRight Add(AccessRight accessRight);

        AccessRight Update(AccessRight accessRight);

        AccessRight Delete(string password);
    }
}
