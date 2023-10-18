using System;
using System.Collections.Generic;

namespace Dto;

public partial class OpeningHourDto
{
    public int AttractionId { get; set; }

    public int Day { get; set; }

    public DateTime? OpeningHour1 { get; set; }

    public DateTime? ClosingHour { get; set; }

    public bool IsOpening { get; set; }

}
