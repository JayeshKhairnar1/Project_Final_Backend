using System;
using System.Collections.Generic;

namespace DotNetProject.Models;

public partial class Component
{
    public long Id { get; set; }

    public string? CompName { get; set; }

    public virtual ICollection<AlternateComponent> AlternateComponents { get; } = new List<AlternateComponent>();

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();
}
