using AutoMapper;
using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ProductTypeBll : IProductTypeBll
    {
        private readonly IProductTypeDal productTypeDal;
        private readonly IMapper mapper;
        public ProductTypeBll(IProductTypeDal productTypeDal, IMapper mapper)
        {
            this.productTypeDal = productTypeDal;
            this.mapper = mapper;
        }

        public List<ProductTypeDto> GetAll()
        {
            return mapper.Map<List<ProductTypeDto>>(productTypeDal.GetAll());
        }
    }
}
