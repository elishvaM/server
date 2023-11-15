using Bll;
using Dal;
using Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBll productBll;
        public ProductController(IProductBll productBll)
        {
            this.productBll = productBll;
        }

        [HttpGet("/api/[controller]/GetAllProducts")]
        public List<ProductDto> GetAllProducts()
        {
            return productBll.GetAllProducts();
        }

        // GET: api/<ProductController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost("/api/[controller]/AddProduct")]
        public int AddProduct([FromBody] ProductDto product)
        {
            return productBll.AddProduct(product);
            // חייב לעשות משהו שיגיד לי אם בכלל האובייקט התווסף כי הרי אני כבר יודעת אם כן עושים תקינות בריאקט ???
            //return new { user = user, message = "success" };
        }
        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
