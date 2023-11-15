using AutoMapper;
using Dto;
using Entity;
using AutoMapper;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ProductBll:IProductBll
    {
        private readonly IProductDal productDal;
        private readonly IMapper mapper;
        public ProductBll(IProductDal productDal, IMapper mapper)
        {
            this.productDal = productDal;
            this.mapper = mapper;
        }
        public List<ProductDto> GetAllProducts()
        {
            return mapper.Map<List<ProductDto>>(this.productDal.GetAllProducts());
        }
        public int AddProduct(ProductDto p)
        {
            return this.productDal.AddProduct(mapper.Map<Product>(p));
        }
    }
}
