using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class GownDTO
{
    public GownDTO()
    {
    }

    public GownDTO(string GownCode, string Name, string Description, /*int[] Size,*/ int ColorId, int Price, string Image)
    {
        this.GownCode = GownCode;
        this.Name = Name;
        this.Description = Description;
        //this.Size = Size;
        this.ColorId = ColorId;
        this.Price = Price;
        this.Image = Image;
    }
    public string GownCode { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    //public int[] Size { get; set; }

    public int ColorId { get; set; }

    public int Price { get; set; }

    public string Image { get; set; }

    public virtual ColorDTO Color { get; set; }

    public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();

    public virtual ICollection<OrdersScheduleDTO> Schedules { get; set; } = new List<OrdersScheduleDTO>();
}
