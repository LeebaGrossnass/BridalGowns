using BL.API;
using BL.DTO;
using DAL.Implementation;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    public class ColorService : IColorService
    {
        ColorRepo colors;
        public ColorService(DALManager manager)
        {
            this.colors = manager.colorRepo;
        }
        public ColorDTO Add(ColorDTO color)
        {
            Color c = new Color();
            c.ColorId = color.ColorId;
            c.Color1 = color.Color1;
            colors.Add(c);
            return color;
        }

        public ColorDTO Delete(string name)
        {
            Color c = colors.Delete(name);
            return new ColorDTO() {ColorId = c.ColorId, Color1 = name };
        }

        public ColorDTO Get(string name)
        {
            Color c = colors.Get(name);
            if (c == null)
            {
                return null;
            }
            ColorDTO color = new ColorDTO(c.ColorId, c.Color1);
            return color;
        }

        public List<ColorDTO> GetAll()
        {
            List<Color> list = colors.GetAll();
            List<ColorDTO> result = new List<ColorDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new ColorDTO(list[i].ColorId, list[i].Color1));
            }
            return result;
        }
    }
}
