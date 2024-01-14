using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionTypeController : ControllerBase
    {
        private readonly IAttractionTypeBll attractionTypeBll;
        public AttractionTypeController(IAttractionTypeBll attractionTypeBll)
        {
            this.attractionTypeBll = attractionTypeBll;
        }

        // GET: api/<AttractionTypeController>
        [HttpGet("/api/[controller]/GetAll")]
        public List<AttractionTypeDto> GetAll()
        {
            return attractionTypeBll.GetAll();
        }

        // POST api/<AttractionTypeController>
        [HttpPost]
        public void Post([FromBody]AttractionTypeDto attractionType)
        {
        }
    }
}
