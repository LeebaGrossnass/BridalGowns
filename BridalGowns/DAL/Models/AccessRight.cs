using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AccessRight
{
    public int Id { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
}
