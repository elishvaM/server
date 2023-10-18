using System;
using System.Collections.Generic;

namespace Dto;

public partial class RequestDto
{
    public int Id { get; set; }

    public string AttractionName { get; set; } = null!;

    public int AddressId { get; set; }

    public int UserId { get; set; }

}
