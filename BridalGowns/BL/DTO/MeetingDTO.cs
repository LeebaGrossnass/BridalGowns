using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class MeetingDTO
{
    public MeetingDTO()
    {
    }

    public MeetingDTO(string ClientId, DateTime MeetingTime) 
    {
        this.ClientId = ClientId;
        this.MeetingTime = MeetingTime;
    }

    //public int Code { get; set; }

    public string ClientId { get; set; }

    public DateTime MeetingTime { get; set; }

    public virtual ClientDTO Client { get; set; }
}
