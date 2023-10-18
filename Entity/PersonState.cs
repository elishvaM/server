using System;
using System.Collections.Generic;

namespace Entity;

public partial class PersonState
{
    public int Id { get; set; }

    public string State { get; set; } = null!;

    public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
}
