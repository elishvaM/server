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
        [HttpPost("/api/[controller]/Get/{id}")]
        public List<OpeningHourDto> Get(int id)
        {
            return openingHourBll.Get(id);
        }

        [HttpPost("/api/[controller]/Update")]
        public ActionResult Update(OpeningHourDto o)
        {
            o = openingHourBll.Update(o);
            if (o == null)
                return BadRequest("קיימת שעת פתיחה כזו באותו היום או שעות לא תקינות");
            return Ok(o);
        }

        [HttpPost("/api/[controller]/Delete")]
        public List<OpeningHourDto> Delete(OpeningHourDto openingHour)
        {
            openingHourBll.Delete(openingHour);
            return openingHourBll.Get(openingHour.AttractionId);
        }

    }
}
