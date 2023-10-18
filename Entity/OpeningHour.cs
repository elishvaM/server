using System;
using System.Collections.Generic;

namespace Entity;

public partial class OpeningHour
{
    public int AttractionId { get; set; }

    public int Day { get; set; }

    public DateTime? OpeningHour1 { get; set; }

    public DateTime? ClosingHour { get; set; }

    public bool IsOpening { get; set; }

    public virtual Attraction? Attraction { get; set; }
}
