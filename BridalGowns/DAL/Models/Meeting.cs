using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Meeting
{
    public int Code { get; set; }

    public string ClientId { get; set; }

    public DateTime MeetingTime { get; set; }

    public virtual Client Client { get; set; }

    public virtual ICollection<OrderSchedule> MeetingsSchedules { get; set; } = new List<OrderSchedule>();
}
