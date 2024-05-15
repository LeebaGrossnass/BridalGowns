using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class OrderSchedule
{
    public int Code { get; set; }

    public DateTime Date { get; set; }

    public int MeetingCode { get; set; }

    public virtual Meeting MeetingCodeNavigation { get; set; }
}
