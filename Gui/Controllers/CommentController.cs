using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentBll commentaBll;
        public CommentController(ICommentBll commentaBll)
        {
            this.commentaBll = commentaBll;
        }

        [HttpPost("/api/[controller]/GetAll/{attractionId}")]
        public ActionResult GetAll(int attractionId)
        {
            List<CommentDto> commentList = commentaBll.GetAll(attractionId);
            if (commentList == null)
                return BadRequest("לא נמצאו תגובות לאטרקציות זו או שארעה שגיאה");
            return Ok(commentList);
        }

        [HttpPost("/api/[controller]/GetComplained")]
        public List<CommentDto> GetComplained()
        {
            return commentaBll.GetComplained();
        }

        [HttpPost("/api/[controller]/Add")]
        public PostComment Add([FromBody] PostComment comment)
        {
            commentaBll.Add(comment);
            return comment;
            //return Ok("התווסף בהצלחה"+comment);
            //return BadRequest("שגיאה"+comment);
        }

        [HttpPost("/api/[controller]/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            commentaBll.Delete(id);
            return Ok("מחיקה בוצעה בהצלחה");
        }

        [HttpPost("/api/[controller]/UpDateCount")]
        public ActionResult UpDateCount([FromBody] CommentDto comment)
        {
            //if (commentaBll.GetComplained().Where(c => c.UserId == comment.UserId  && c.Id == comment.Id).Count() > 0)
            //    return BadRequest("כבר דיווחת על תגובה זו");
            //commentaBll.UpDateCount(comment.Id);
            //return Ok("דווח בהצלחה");
            commentaBll.UpDateCount(comment.Id);
            return Ok("דווח בהצלחה");
        }
    }
}
