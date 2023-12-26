using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CommentDal : ICommentDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public CommentDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public void Add(Comment comment)
        {
            ElishevaMHadasBListsTripContext.Comments.Add(comment);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public void Delete(int commentId)
        {
            Comment foundComment = ElishevaMHadasBListsTripContext.Comments.FirstOrDefault(x => x.Id == commentId);
           ElishevaMHadasBListsTripContext.Comments.Remove(foundComment);
            ElishevaMHadasBListsTripContext.SaveChanges();

        }

        //public List<Comment> GetByAttractionId(int attractionId)
        //{
        //    return "jj";
        //    //return ElishevaMHadasBListsTripContext.Comments.FirstOrDefault(x=>x.)
        //}

        public List<Comment> GetComplained()
        {
            throw new NotImplementedException();
        }
    }
}
