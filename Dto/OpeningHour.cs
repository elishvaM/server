using System;
using System.Collections.Generic;

namespace Dto;

public partial class OpeningHourDto
{
    public int Id { get; set; }
    public int AttractionId { get; set; }

    public int Day { get; set; }

    public string? OpeningHour1 { get; set; }

    public string? ClosingHour { get; set; }

    public bool IsOpening { get; set; }

}
