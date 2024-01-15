using System;
using System.Collections.Generic;

namespace Entity;

public partial class Address
{
    public int Id { get; set; }

    public string Land { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? Street { get; set; }

    public int? Number { get; set; }

    public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
}
