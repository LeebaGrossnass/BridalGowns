using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class OrdersScheduleDTO
{
    public OrdersScheduleDTO()
    {
    }

    public OrdersScheduleDTO(DateTime Date, string GownCode) 
    { 
        this.Date = Date;
        this.GownCode = GownCode;
    }
    //public int Code { get; set; }

    public DateTime Date { get; set; }

    public string GownCode { get; set; }

    public virtual GownDTO GownCodeNavigation { get; set; }
}
