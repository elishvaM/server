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

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("/api/[controller]/AddProduct")]
        public int AddProduct([FromBody] ProductDto product)
        {
            return productBll.AddProduct(product);
            //return new { user = user, message = "success" };
        }
        [HttpPost("/api/[controller]/Delete/{id}")]
        public void Delete(int id)
        {
            productBll.Delete(id);           
        }
        [HttpPost("/api/[controller]/Update")]
        public void Update([FromBody] ProductDto p)
        {
            productBll.Update(p);

        }
        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
