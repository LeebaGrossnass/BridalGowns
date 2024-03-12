using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public interface ISceduleRepo
    {
        Schedule Get(DateTime time);

        Schedule Add(Schedule schedule);

        Schedule Delete(DateTime time);
    }
}
