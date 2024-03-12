using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface ISceduleRepo
    {
        Schedule Get(DateTime time);

        Schedule Add(Schedule schedule);
        List<Schedule> GetAll();


        Schedule Delete(DateTime time);
    }
}
