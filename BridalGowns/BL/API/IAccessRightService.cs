using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IAccessRightService
    {
        List<AccessRightDTO> GetAll();

        AccessRightDTO Get(string password);

        AccessRightDTO Add(AccessRightDTO accessRight);

        AccessRightDTO Update(AccessRightDTO accessRight);

        AccessRightDTO Delete(string password);
    }
}
