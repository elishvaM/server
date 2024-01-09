using System;
using System.Collections.Generic;

namespace Entity;

public partial class ComplainedComment
{
    public int Id { get; set; }

    public int CommentId { get; set; }

    public int UserId { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
