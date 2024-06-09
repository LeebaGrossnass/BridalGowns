using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class GownDTO
{
    public GownDTO()
    {
    }

    public GownDTO(string GownCode, string Name, string Description, int ColorId, int Price, string Image, string image1, string image2, string image3, string image4)
    {
        this.GownCode = GownCode;
        this.Name = Name;
        this.Description = Description;
        this.ColorId = ColorId;
        this.Price = Price;
        this.Image = Image;
    }
    public string GownCode { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }


    public int ColorId { get; set; }

    public int Price { get; set; }

    public string Image { get; set; }
    public string Image1 { get; set; }
    public string Image2 { get; set; }
    public string Image3 { get; set; }
    public string Image4 { get; set; }

    public virtual ColorDTO Color { get; set; }

    public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();

    public virtual ICollection<OrdersScheduleDTO> Schedules { get; set; } = new List<OrdersScheduleDTO>();
}
