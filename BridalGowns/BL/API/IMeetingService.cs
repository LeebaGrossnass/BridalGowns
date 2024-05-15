using BL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.API
{
    public interface IMeetingService
    {
        List<MeetingDTO> GetAll();

        MeetingDTO Get(DateTime time);

        MeetingDTO Add(MeetingDTO meeting);

        MeetingDTO Update(MeetingDTO meeting);

        MeetingDTO Delete(DateTime time);
    }
}
