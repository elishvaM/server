using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface IProductDal
    {
        List<Product> GetAllProducts();
        int AddProduct(Product p);

    }
}
