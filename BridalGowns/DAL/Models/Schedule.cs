using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Schedule
{
    public int Code { get; set; }

    public DateTime Date { get; set; }

    public string GownCode { get; set; }

    public string CrownCode { get; set; }

    public virtual Crown CrownCodeNavigation { get; set; }

    public virtual Gown GownCodeNavigation { get; set; }
}
