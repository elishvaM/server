using System;
using System.Collections.Generic;

namespace Dto;

public partial class OpeningHourDto
{
    public int AttractionId { get; set; }

    public int Day { get; set; }

    public TimeSpan? OpeningHour1 { get; set; }

    public TimeSpan? ClosingHour { get; set; }

    public bool IsOpening { get; set; }

}
