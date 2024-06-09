using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Client
{
    public string Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public virtual ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
