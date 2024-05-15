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
    public class ColorRepo : IColorRepo
    {
        BridalContext context;
        public ColorRepo(BridalContext context)
        {
            this.context = context;
        }
        public Color Add(Color color)
        {
            context.Colors.Add(color);
            context.SaveChanges();
            return color;
        }

        public Color Delete(string name)
        {
            try
            {
                var colorToDelete = context.Colors.Where(c => c.Color1 == name).FirstOrDefault();
                context.Colors.Remove(colorToDelete);
                context.SaveChanges();
                return colorToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting color {name} data");
            }
        }

        public Color Get(string name)
        {
            try
            {
                return context.Colors.Where(c => c.Color1 == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting color  {name} data");
            }
        }

        public List<Color> GetAll()
        {
            return context.Colors.ToList();
        }
    }
}
