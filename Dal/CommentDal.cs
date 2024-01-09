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
            foundComment.ComplainCount = 0;
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

        public bool UpDateCount(int id, int userId)
        {
            Comment foundComment = ElishevaMHadasBListsTripContext.Comments.FirstOrDefault(x => x.Id == id);
            //נבדוק שמשתמש כבר לא דיווח עליה
            List<ComplainedComment> found = ElishevaMHadasBListsTripContext.ComplainedComments.Where(x =>
                                        x.CommentId == id && x.UserId == userId).ToList();
            if (!found.Any())
            {
                foundComment.ComplainCount = foundComment.ComplainCount + 1;
                ComplainedComment complainedComment = new ComplainedComment();
                complainedComment.CommentId = id;
                complainedComment.UserId = userId;
                ElishevaMHadasBListsTripContext.ComplainedComments.Add(complainedComment);
                ElishevaMHadasBListsTripContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
