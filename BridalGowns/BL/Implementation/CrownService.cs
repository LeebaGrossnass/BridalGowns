using BL.DTO;
using DAL.Implementation;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.API;
using System.Net;

namespace BL.Implementation
{
    public class CrownService: ICrownService
    {
        CrownRepo crowns;
        public CrownService(DALManager manager)
        {
            this.crowns = manager.crownRepo;
        }
        public CrownDTO Add(CrownDTO crown)
        {
            Crown c = new Crown();
            c.CrownCode = crown.CrownCode;
            c.Name = crown.Name;
            c.Description = crown.Description;
            c.Price = crown.Price;
            c.ColorId = crown.ColorId;
            c.Image = crown.Image;
            crowns.Add(c);
            return crown;
        }

        public CrownDTO Delete(string name)
        {
            Crown c = crowns.Delete(name);
            return new CrownDTO() {CrownCode = c.CrownCode, Name = name, Description = c.Description, 
                Price = c.Price, ColorId = c.ColorId, Image = c.Image};
        }

        public CrownDTO Get(string name)
        {
            Crown c = crowns.Get(name);
            if (c == null)
            {
                return null;
            }
            CrownDTO crown = new CrownDTO(c.CrownCode, c.Name, c.Description, c.Price, c.ColorId, c.Image);
            return crown;
        }

        public List<CrownDTO> GetAll()
        {
            List<Crown> list = crowns.GetAll();
            List<CrownDTO> result = new List<CrownDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new CrownDTO(list[i].CrownCode, list[i].Name, list[i].Description, list[i].Price, list[i].ColorId,  list[i].Image));
            }
            return result;
        }

        public CrownDTO Update(CrownDTO crown)
        {
            Crown c = new Crown();
            c.CrownCode = crown.CrownCode;
            c.Name = crown.Name;
            c.Description = crown.Description;
            c.Price = crown.Price;
            crowns.Update(c);
            return crown;
        }
    }
}
