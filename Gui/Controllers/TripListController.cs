using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
using Entity;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripListController : ControllerBase
    {
        private readonly ITripListBll tripListBll;
        public TripListController(ITripListBll tripListBll)
        {
            this.tripListBll = tripListBll;
        }
        // GET: api/<TripListController>
        [HttpGet("/api/[controller]/GetAll/{userId}")]
        public List<TripListDto> GetAll(int userId) { 
            return tripListBll.GetAll(userId);
        }

        // POST api/<TripListController>
        [HttpPost("/api/[controller]/Add")]
        public ActionResult Add([FromBody] TripListDto tripList)
        {
            TripListDto t = tripListBll.Add(tripList);
            return Ok(t);
        }

        [HttpPost("/api/[controller]/Update")]
        public void Put([FromBody] TripListDto tripList)
        {
            tripListBll.Update(tripList);
        }
        ///??? check
        [HttpPost("/api/[controller]/Delete")]
        public void Delete([FromBody] TripListDto tripList)
        {
            tripListBll.Delete(tripList);
        }

        [HttpPost("/api/[controller]/SendEmail/{to}/{subject}")]
        public ActionResult SendEmail(string to, string subject)
        {
            tripListBll.SendEmailOnly(to, subject);
            return Ok("המייל נשלח");
        }
    }
}
