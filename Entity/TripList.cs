using System;
using System.Collections.Generic;

namespace Entity;

public partial class TripList
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Name { get; set; }

    public bool Status { get; set; }

    public DateTime AddingDate { get; set; }

    public DateTime BackingDate { get; set; }

    public DateTime TravelingDate { get; set; }

    public virtual ICollection<AttractionList> AttractionLists { get; set; } = new List<AttractionList>();
}
