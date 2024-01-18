using AutoMapper;
using Dal;
using Dto;
using Entity;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class AttractionListProductBll : IAttractionListProductBll
    {
        private readonly IAttractionListProductDal attractionListProductDal;
        private readonly IMapper mapper;
        public AttractionListProductBll(IAttractionListProductDal attractionListProductDal, IMapper mapper)
        {
            this.attractionListProductDal = attractionListProductDal;
            this.mapper = mapper;
        }

        public AttractionListProductDto Add(AttractionListProductDto attractionListProduct)
        {
            return mapper.Map<AttractionListProductDto>(this.attractionListProductDal.Add(mapper.Map<AttractionListProduct>(attractionListProduct)));
        }

        public List<AttractionListProductDto> AddList(List<AttractionListProductDto> attractionListProduct)
        {
            return mapper.Map<List<AttractionListProductDto>>(this.attractionListProductDal.AddList(mapper.Map<List<AttractionListProduct>>(attractionListProduct)));
        }

        public void Delete(int productId, int attractionListId)
        {
            attractionListProductDal.Delete(productId, attractionListId);
        }

        public List<object> GetAllAttractionListProductByTripListIdId(int tripListId)
        {
            List<keyCount> a = attractionListProductDal.GetAllAttractionListProductByTripListIdId(tripListId);
            List<object> c = new List<object>();
            foreach(keyCount b in a)
            {
                ProductDto productDto = mapper.Map<ProductDto>(b.Product);
                c.Add(new { Key = b.Key, Sum=b.Sum, Product= productDto, StatusId=b.StatusId });
                //,StatusName = b.StatusName
            }
            return c;
        }

        public List<AttractionListProductDto> GetByAttractionListId(int attractionListId)
        {
            return mapper.Map<List<AttractionListProductDto>>(this.attractionListProductDal.GetByAttractionListId(attractionListId));
        }
    }
}
