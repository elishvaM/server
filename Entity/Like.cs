using System;
using System.Collections.Generic;

namespace Entity;

public partial class Like
{
    public int Id { get; set; }

    public int AttractionId { get; set; }

    public int AttractionListId { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;

    public virtual AttractionList AttractionList { get; set; } = null!;
}
