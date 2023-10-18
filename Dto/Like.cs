using System;
using System.Collections.Generic;

namespace Dto;

public partial class LikeDto
{
    public int Id { get; set; }

    public int AttractionListId { get; set; }

    public int Rank { get; set; }

    public int CommentId { get; set; }

}
