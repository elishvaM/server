using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionController : ControllerBase
    {
        private readonly IAttractionBll attractionBll;
        public AttractionController(IAttractionBll attractionBll)
        {
            this.attractionBll = attractionBll;
        }

        [HttpGet("/api/[controller]/GetAll")]
        public object GetAll()
        {
            return attractionBll.GetAll();
        }

        [HttpGet("/api/[controller]/GetById/{id}")]
        public AttractionDto GetById(int id)
        {
            return attractionBll.GetById(id);
        }

        [HttpGet("/api/[controller]/Add")]
        public AttractionDto Add([FromBody] AttractionDto a)
        {
            int id = attractionBll.Add(a);
            AttractionDto add = attractionBll.GetById(id);
            return add;
        }

        [HttpPost("/api/[controller]/Update/attraction")]
        public void Update([FromBody] AttractionDto a)
        {
            attractionBll.Update(a);
        }

        //[HttpPut("/api/[controller]/updateStatusById/{id}")]
        //public void UpdateStatusById(int id)
        //{
        //    attractionBll.UpdateStatusById(id);
        //}
        
        [HttpGet("/api/[controller]/GetFavorites")]
        public List<AttractionDto> GetFavorites()
        {
            return attractionBll.GetFavorites();
        }
    }
}
