using Bll;
using Dal;
using Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionListProductController : ControllerBase
    {
        private readonly IAttractionListProductBll attractionListProductBll;
        public AttractionListProductController(IAttractionListProductBll attractionListProductBll)
        {
            this.attractionListProductBll = attractionListProductBll;
        }
        [HttpGet("/api/[controller]/GetByAttractionListId/{attractionListId}")]
        public List<AttractionListProductDto> GetByAttractionListId(int attractionListId)
        {
            return attractionListProductBll.GetByAttractionListId(attractionListId);
        }

        [HttpPost("/api/[controller]/Add")]
        public void Add([FromBody] AttractionListProductDto attractionListProduct)
        {
            attractionListProductBll.Add(attractionListProduct);
        }

        // PUT api/<AttractionListProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpPost("/api/[controller]/Delete")]
        public void Delete([FromBody] AttractionListProductDto attractionListProduct)
        {
            attractionListProductBll.Delete(attractionListProduct);
        }
    }
}
