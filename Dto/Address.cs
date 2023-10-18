using System;
using System.Collections.Generic;

namespace Dto;

public partial class AddressDto
{
    public int Id { get; set; }

    public string Land { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int Number { get; set; }

}
