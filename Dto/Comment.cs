using System;
using System.Collections.Generic;

namespace Dto;

public partial class CommentDto
{
    public int Id { get; set; }

    public string Desc { get; set; } = null!;

    public DateTime Date { get; set; }

    public int ComplainCount { get; set; }

    public int UserId { get; set; }

    public int Count { get; set; }

   

}
