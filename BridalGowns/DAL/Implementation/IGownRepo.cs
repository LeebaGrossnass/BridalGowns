using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    internal interface IGownRepo
    {
        List<Gown> GetAll();

        Gown Get(string id);

        Gown Add(Gown gown);

        Gown Update(string id, Gown gown);

        Gown Delete(string id);
    }
}
