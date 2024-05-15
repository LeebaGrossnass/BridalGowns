using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IColorService
    {
        List<ColorDTO> GetAll();

        ColorDTO Get(string name);

        ColorDTO Add(ColorDTO color);

        ColorDTO Delete(string name);
    }
}
