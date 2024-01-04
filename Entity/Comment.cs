using System;
using System.Collections.Generic;

namespace Entity;

public partial class Comment
{
    public int Id { get; set; }

    public string Desc { get; set; } = null!;

    public DateTime Date { get; set; }

    public int ComplainCount { get; set; }

    public int AttractionId { get; set; }

    public int UserId { get; set; }

    public bool Status { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual User User { get; set; } = null!;
}
