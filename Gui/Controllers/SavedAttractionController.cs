using Bll;
using Dal;
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

        [HttpPost("/api/[controller]/AddLovedAttraction")]
        public void AddLovedAttraction(SavedAttractionDto lovedAttrraction)
        {
            savedAttractionBll.AddLovedAttraction(lovedAttrraction);
        }
        // PUT api/<ValuesController>/5
        [HttpPut("/api/[controller]/RemoveLovedAttraction")]
        public void RemoveLovedAttraction(SavedAttractionDto lovedAttrraction)
        {
            Console.WriteLine("cameee");
            savedAttractionBll.RemoveLovedAttraction(lovedAttrraction);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
