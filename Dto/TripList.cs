using System;
using System.Collections.Generic;

namespace Dto;

public partial class TripListDto
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Name { get; set; }

    public DateTime AddingDate { get; set; }

    public DateTime BackingDate { get; set; }

    public DateTime TravelingDate { get; set; }

}
