using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageTypeController : ControllerBase
    {
        private readonly IStorageTypeBll storageTypeBll;
        public StorageTypeController(IStorageTypeBll storageTypeBll)
        {
            this.storageTypeBll = storageTypeBll;
        }

        [HttpGet("/api/[controller]/GetAll")]
        public List<StorageTypeDto> GetAll()
        {
            return storageTypeBll.GetAll();
        }

        // GET api/<StorageTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StorageTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StorageTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StorageTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
