using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IMeetingScheduleService
    {
        List<MeetingScheduleDTO> GetAll();

        MeetingScheduleDTO Get(DateTime time);

        MeetingScheduleDTO Add(MeetingScheduleDTO schedule);

        MeetingScheduleDTO Delete(DateTime time);
    }
}
