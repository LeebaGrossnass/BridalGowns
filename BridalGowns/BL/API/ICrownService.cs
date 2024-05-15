using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface ICrownService
    {
        List<CrownDTO> GetAll();

        CrownDTO Get(string name);

        CrownDTO Add(CrownDTO crown);

        CrownDTO Update(CrownDTO crown);

        CrownDTO Delete(string name);
    }
}
