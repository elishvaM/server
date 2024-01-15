using System;
using System.Collections.Generic;

namespace Entity;

public partial class OpeningHour
{
    public int Id { get; set; }

    public int AttractionId { get; set; }

    public int Day { get; set; }

    public TimeSpan? OpeningHour1 { get; set; }

    public TimeSpan? ClosingHour { get; set; }

    public bool IsOpening { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;
}
