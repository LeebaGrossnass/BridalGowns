
using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class CrownDTO
{
    public CrownDTO() {}

    public CrownDTO(string CrownCode, string Name, string Description, int Price, int ColorId, string Image)
    {
        this.CrownCode = CrownCode;
        this.Name = Name;
        this.Description = Description;
        this.Price = Price;
        this.ColorId = ColorId;
        this.Image = Image;
    }

    public string CrownCode { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Price { get; set; }

    public int ColorId { get; set; }

    public string Image { get; set; }

    public virtual ColorDTO Color { get; set; }

    public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();
}
