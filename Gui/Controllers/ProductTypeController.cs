﻿using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {

        private readonly IProductTypeBll productTypeBll;
        public ProductTypeController(IProductTypeBll productTypeBll)
        {
            this.productTypeBll = productTypeBll;
        }

        [HttpGet("/api/[controller]/GetAll")]
        public List<ProductTypeDto> GetAll()
        {
            return productTypeBll.GetAll();
        }

        // GET api/<ProductTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
