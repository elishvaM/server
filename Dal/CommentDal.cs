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
            comment.Status = true;
            comment.Date = DateTime.Now;
            ElishevaMHadasBListsTripContext.Comments.Add(comment);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public void Delete(int commentId)
        {
            Comment foundComment = ElishevaMHadasBListsTripContext.Comments.FirstOrDefault(x => x.Id == commentId);
            //לא נרצה למחוק כי כך ייעלמו נתונים
            foundComment.Status = false;
            ElishevaMHadasBListsTripContext.SaveChanges();

        }

        public List<Comment> GetAll(int attractionId)
        {
            return ElishevaMHadasBListsTripContext.Comments.Where(x => x.AttractionId == attractionId).ToList();
        }

        public List<Comment> GetComplained()
        {
            return ElishevaMHadasBListsTripContext.Comments.Where(x => x.ComplainCount >= 1).ToList();
        }

        public void UpDateCount(Comment comment)
        {
            Comment foundComment = ElishevaMHadasBListsTripContext.Comments.FirstOrDefault(x => x.Id == commentId);
            foundComment.ComplainCount = comment.ComplainCount + 1;
            ElishevaMHadasBListsTripContext.SaveChanges();
        }
    }
}
