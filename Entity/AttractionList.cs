using System;
using System.Collections.Generic;

namespace Entity;

public partial class AttractionList
{
    public int Id { get; set; }

    public int TripListId { get; set; }

    public int AttractionId { get; set; }

    public DateTime ExitDate { get; set; }

    public bool IsBasic { get; set; }

    public DateTime RemainderDate { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;

    public virtual ICollection<AttractionListProduct> AttractionListProducts { get; set; } = new List<AttractionListProduct>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual TripList TripList { get; set; } = null!;
}
