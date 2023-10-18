using System;
using System.Collections.Generic;

namespace Entity;

public partial class Request
{
    public int Id { get; set; }

    public string AttractionName { get; set; } = null!;

    public int AddressId { get; set; }

    public int UserId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
