using System;
using System.Collections.Generic;

namespace DotNetProject.Models;

public partial class User
{
    public string Userid { get; set; } = null!;

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? CompanyName { get; set; }

    public string? Email { get; set; }

    public string? GstNumber { get; set; }

    public string? Password { get; set; }

    public string? PinCode { get; set; }

    public string? State { get; set; }

    public string? Telephone { get; set; }

    public string? Username { get; set; }
}
