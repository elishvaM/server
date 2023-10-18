using System;
using System.Collections.Generic;

namespace Dto;

public partial class CountryDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ContinentId { get; set; }

}
