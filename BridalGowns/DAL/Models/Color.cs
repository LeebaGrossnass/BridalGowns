using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Color
{
    public int ColorId { get; set; }

    public string Color1 { get; set; }

    public virtual ICollection<Crown> Crowns { get; set; } = new List<Crown>();

    public virtual ICollection<Gown> Gowns { get; set; } = new List<Gown>();
}
