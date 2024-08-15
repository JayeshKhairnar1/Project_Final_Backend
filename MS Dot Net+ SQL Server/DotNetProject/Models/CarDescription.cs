using System;
using System.Collections.Generic;

namespace DotNetProject.Models;

public partial class CarDescription
{
    public long Id { get; set; }

    public string? CarName { get; set; }

    public string? Description { get; set; }

    public string? Path { get; set; }
}
