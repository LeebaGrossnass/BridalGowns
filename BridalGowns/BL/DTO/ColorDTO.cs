
using System;
using System.Collections.Generic;

namespace BL.DTO;

public partial class ColorDTO
{
    public ColorDTO()
    {
    }

    public ColorDTO(int ColorId, string Color1) 
    {
        this.ColorId = ColorId;
        this.Color1 = Color1;
    }
    public int ColorId { get; set; }

    public string Color1 { get; set; }

    public virtual ICollection<CrownDTO> Crowns { get; set; } = new List<CrownDTO>();

    public virtual ICollection<GownDTO> Gowns { get; set; } = new List<GownDTO>();
}
