using System;
using System.Collections.Generic;

namespace Entity;

public partial class AttractionType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
}
