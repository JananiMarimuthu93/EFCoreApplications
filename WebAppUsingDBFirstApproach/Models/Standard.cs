using System;
using System.Collections.Generic;

namespace WebAppUsingDBFirstApproach.Models;

public partial class Standard
{
    public int StandardId { get; set; }

    public string StandardName { get; set; } = null!;

    public string Description { get; set; } = null!;
}
