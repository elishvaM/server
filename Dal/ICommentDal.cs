using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public interface ICommentDal
    {
        List<Comment> GetAll(int attractionId);
        List<Comment> GetComplained();
        void Delete(int commentId);
        void Add(Comment comment);  
        void UpDateCount(int id);  
    }
}
