using System;
using System.Collections.Generic;

namespace DotNetProject.Models;

public partial class AlternateComponent
{
    public long Id { get; set; }

    public double DeltaPrice { get; set; }

    public long CompId { get; set; }

    public long ModId { get; set; }

    public long? AltCompId { get; set; }

    public virtual Component Comp { get; set; } = null!;

    public virtual Model Mod { get; set; } = null!;
}
