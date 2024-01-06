using System;
using System.Collections.Generic;

namespace Dto;

public partial class CommentDto : PostComment
{
    public bool Status { get; set; }

    public int ComplainCount { get; set; }

}
public partial class ComplainedComment
{
    public int Id { get; set; }

    public int UserId { get; set; }

}
public partial class PostComment 
{
    public int Id { get; set; }

    public string Desc { get; set; } = null!;

    public DateTime Date { get; set; }

    public int UserId { get; set; } 

    public int AttractionId { get; set; }
}