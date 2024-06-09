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
    public class GownService : IGownService
    {
        GownRepo gowns;
        public GownService(DALManager manager)
        {
            this.gowns = manager.gownRepo;
        }


        public GownDTO Add(GownDTO gown)
        {
            Gown g = new Gown();
            g.GownCode = gown.GownCode;
            g.Name = gown.Name;
            g.Description = gown.Description;
            g.Price = gown.Price;
            g.ColorId = gown.ColorId;
            g.Image = gown.Image;
            g.Image1 = gown.Image1;
            g.Image2 = gown.Image2;
            g.Image3 = gown.Image3;
            g.Image4 = gown.Image4;
            gowns.Add(g);
            return gown;
        }

        public GownDTO Delete(string name)
        {
            Gown g = gowns.Delete(name);
            return new GownDTO()
            {
                GownCode = g.GownCode,
                Name = name,
                Description = g.Description,
                Price = g.Price,
                ColorId = g.ColorId,
                Image = g.Image,
                Image1 = g.Image1,
                Image2 = g.Image2,
                Image3 = g.Image3,
                Image4 = g.Image4
            };
        }

        public GownDTO Get(string name)
        {
            Gown g = gowns.Get(name);
            if (g == null)
            {
                return null;
            }
            GownDTO gown = new GownDTO(g.GownCode, g.Name, g.Description, g.ColorId, g.Price, g.Image, g.Image1, g.Image2, g.Image3, g.Image4);
            return gown;
        }

        public List<GownDTO> GetAll()
        {
            List<Gown> list = gowns.GetAll();
            List<GownDTO> result = new List<GownDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new GownDTO(list[i].GownCode, list[i].Name, list[i].Description, list[i].Price, list[i].ColorId, list[i].Image, list[i].Image1, list[i].Image2, list[i].Image3, list[i].Image4));
            }
            return result;
        }

        public GownDTO Update(GownDTO gown)
        {
            Gown g = new Gown();
            g.GownCode = gown.GownCode;
            g.Name = gown.Name;
            g.Description = gown.Description;
            g.Price = gown.Price;
            g.Image = gown.Image;
            g.Image1 = gown.Image1;
            g.Image2 = gown.Image2;
            g.Image3 = gown.Image3;
            g.Image4 = gown.Image4;
            g.ColorId = gown.ColorId;
            gowns.Update(g);
            return gown;
        }
    }
}
