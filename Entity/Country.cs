using System;
using System.Collections.Generic;

namespace Entity;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ContinentId { get; set; }

    public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();

    public virtual Continent Continent { get; set; } = null!;
}
