using System;
using System.Collections.Generic;

namespace Dto;

public partial class AttractionListDto
{
    public int Id { get; set; }

    public int TripListId { get; set; }

    public int AttractionId { get; set; }

    public DateTime ExitDate { get; set; }

    public bool IsBasic { get; set; }

    public DateTime RemainderDate { get; set; }

    public List<AttractionListProductDto>? AttractionListProduct { get; set; }

}
