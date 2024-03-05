using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public interface IGownRepo
    {
        List<Gown> GetAll();

        Gown Get(string name);

        Gown Add(Gown gown);

        Gown Update(string id, Gown gown);

        Gown Delete(string name);
    }
}
