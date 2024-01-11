using System;
using System.Collections.Generic;

namespace Dto;

public partial class ComplainedCommentDto
{
    public int Id { get; set; }

    public int CommentId { get; set; }

    public int UserId { get; set; }
}
