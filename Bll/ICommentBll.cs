﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using Dto;
namespace Bll
{
    public interface ICommentBll
    {
        List<CommentDto> GetAll(int attractionId);
        List<CommentDto> GetComplained();
        void Add(CommentDto comment);
        void Delete(int commentId);
        void UpDateCount(CommentDto comment);
    }
}
