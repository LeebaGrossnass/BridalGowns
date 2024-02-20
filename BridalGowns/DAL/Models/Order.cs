using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Order
{
    public string OrderNumber { get; set; }

    public DateTime WeddingDate { get; set; }

    public string GownCode { get; set; }

    public int? CrownCode { get; set; }

    public string ClientId { get; set; }

    public int ToatlPayment { get; set; }

    public bool? PickedUp { get; set; }

    public bool Returned { get; set; }

    public virtual Client Client { get; set; }

    public virtual Crown CrownCodeNavigation { get; set; }

    public virtual Gown GownCodeNavigation { get; set; }
}
