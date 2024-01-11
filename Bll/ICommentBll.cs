using System;
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
        void Add(PostComment comment);
        void Delete(int commentId);
        bool UpDateCount(int id, int userId);
        bool ValidComment(int commentId);

    }
}
