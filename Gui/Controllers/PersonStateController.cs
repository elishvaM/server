using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;
namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonStateController : ControllerBase
    {
        private readonly IPersonStateBll personStateBll;
        public PersonStateController(IPersonStateBll personStateBll)
        {
            this.personStateBll = personStateBll;
        }

        // GET: api/<PersonStateController>
        [HttpGet("/api/[controller]/GetAll")]
        public List<PersonStateDto> GetAll()
        {
            return personStateBll.GetAll();
        }

        // POST api/<PersonStateController>
        [HttpPost]
        public void Post([FromBody] PersonStateDto personState)
        {
        }
    }
}
