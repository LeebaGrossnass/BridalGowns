using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public interface IMeetingRepo
    {
        List<Meeting> GetAll();

        Meeting Get(DateTime time);

        Meeting Add(Meeting meeting);

        Meeting Update(Meeting meeting);

        Meeting Delete(DateTime time);
    }
}
