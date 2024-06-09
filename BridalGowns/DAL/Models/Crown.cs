using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Crown
{
    public string CrownCode { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Price { get; set; }

    public int ColorId { get; set; }

    public string Image { get; set; }

    public virtual Color Color { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<OrdersSchedule> OrdersSchedules { get; set; } = new List<OrdersSchedule>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
