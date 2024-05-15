using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class OrderDTO
{
    public OrderDTO()
    {
    }

    public OrderDTO(string OrderNumber, DateTime WeddingDate, string GownCode, string? CrownCode, string ClientId, int ToatlPayment, bool? PickedUp, bool? Returned)
    {
        this.OrderNumber = OrderNumber;
        this.WeddingDate = WeddingDate;
        this.GownCode = GownCode;
        this.CrownCode = CrownCode;
        this.ClientId = ClientId;
        this.ToatlPayment = ToatlPayment;
        this.PickedUp = PickedUp;
        this.Returned = Returned;
    }

    public string OrderNumber { get; set; }

    public DateTime WeddingDate { get; set; }

    public string GownCode { get; set; }

    public string? CrownCode { get; set; }

    public string ClientId { get; set; }

    public int ToatlPayment { get; set; }

    public bool? PickedUp { get; set; }

    public bool? Returned { get; set; }

    public virtual ClientDTO Client { get; set; }

    public virtual CrownDTO CrownCodeNavigation { get; set; }

    public virtual GownDTO GownCodeNavigation { get; set; }
}
