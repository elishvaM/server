using System;
using System.Collections.Generic;

namespace Entity;

public partial class Like
{
    public int Id { get; set; }

    public int AttractionListId { get; set; }

    public int Rank { get; set; }

    public int CommentId { get; set; }

    public virtual AttractionList AttractionList { get; set; } = null!;

    public virtual Comment Comment { get; set; } = null!;
}
