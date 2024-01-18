using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IProductBll
    {
        List<ProductDto> GetAllProducts();
        int AddProduct(ProductDto p);
        void Delete(int id);
        void Update(ProductDto p);
    }
}
