using System;
using System.Collections.Generic;

namespace Entity;

public partial class SavedAttraction
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int AttractionId { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
