using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IColorRepo
    {
        List<Color> GetAll();

        Color Get(string name);

        Color Add(Color color);

        Color Delete(string name);
    }
}
