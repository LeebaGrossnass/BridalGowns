using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class MeetingScheduleDTO
{
    public MeetingScheduleDTO()
    {
    }

    public MeetingScheduleDTO(DateTime Date, int MeetingCode) 
    { 
        this.Date = Date;
        this.MeetingCode = MeetingCode;
    }
    //public int Code { get; set; }

    public DateTime Date { get; set; }

    public int MeetingCode { get; set; }

    public virtual GownDTO GownCodeNavigation { get; set; }
}
