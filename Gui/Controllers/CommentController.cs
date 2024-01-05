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
        }

        [HttpPost("/api/[controller]/Delete/{id}")]
        public void Delete(int id)
        {
            commentaBll.Delete(id);
        }

        [HttpPost("/api/[controller]/UpDateCount")]
        public void UpDateCount([FromBody] CommentDto comment)
        {
            commentaBll.UpDateCount(comment);
        }
    }
}
