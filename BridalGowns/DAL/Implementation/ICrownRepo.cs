using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public interface ICrownRepo
    {
        List<Crown> GetAll();

        Crown Get(string name);

        Crown Add(Crown crown);

        Crown Update(string id, Crown crown);

        Crown Delete(string name);
    }
}
