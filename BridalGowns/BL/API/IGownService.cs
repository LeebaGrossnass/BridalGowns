using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IGownService
    {
        List<GownDTO> GetAll();

        GownDTO Get(string name);

        GownDTO Add(GownDTO gown);

        GownDTO Update(GownDTO gown);

        GownDTO Delete(string name);
    }
}
