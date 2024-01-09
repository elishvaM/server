using AutoMapper;
using Dal;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(AttractionListProductDto attractionListProduct)
        {
            this.attractionListProductDal.Add(mapper.Map<AttractionListProduct>(attractionListProduct));
        }

        public void Delete(AttractionListProductDto attractionListProduct)
        {
            attractionListProductDal.Delete(mapper.Map<AttractionListProduct>(attractionListProduct));
        }

        public List<AttractionListProductDto> GetByAttractionListId(int attractionListId)
        {
            return mapper.Map<List<AttractionListProductDto>>(this.attractionListProductDal.GetByAttractionListId(attractionListId));
        }
    }
}
