using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeningHourController : ControllerBase
    {
        private readonly IOpeningHourBll openingHourBll;
        public OpeningHourController(IOpeningHourBll openingHourBll)
        {
            this.openingHourBll = openingHourBll;
        }
        //???שגיאה על מיפו
        //[HttpPost("/api/[controller]/Get/attraction")]
        //public OpeningHourDto Get([FromBody] AttractionDto attraction)
        //{
        //    return openingHourBll.Get(attraction);
        //}
        [HttpPost("/api/[controller]/Get/{id}")]
        public List<OpeningHourDto> Get( int id)
        {
            return openingHourBll.Get(id);
        }

        [HttpPost("/api/[controller]/Update")]
        public void Update(OpeningHourDto o)
        {
            openingHourBll.Update(o);
        }

        //[HttpPost("/api/[controller]/Add")]
        //public OpeningHourDto Add(OpeningHourDto o)
        //{

        //}


    }
}
