using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavedAttractionController : ControllerBase
    {
        private readonly ISavedAttractionBll savedAttractionBll;
        public SavedAttractionController(ISavedAttractionBll savedAttractionBll)
        {
            this.savedAttractionBll = savedAttractionBll;
        }

        [HttpGet("/api/[controller]/GetSavedAttractionByUserId")]
        public List<SavedAttractionDto> GetSavedAttractionByUserId(int userId)
        {
            return savedAttractionBll.GetSavedAttractionByUserId(userId);
        }

        // GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
