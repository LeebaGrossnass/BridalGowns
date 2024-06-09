using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.API
{
    public interface IMeetingScheduleRepo
    {
        MeetingsSchedule Get(DateTime time);

        MeetingsSchedule Add(MeetingsSchedule meetingsSchedule);
        List<MeetingsSchedule> GetAll();


        MeetingsSchedule Delete(DateTime time);
    }
}
