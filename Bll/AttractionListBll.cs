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
    public class AttractionListBll:IAttractionListBll
    {
        private readonly IAttractionListDal attractionListDal;
        private readonly IMapper mapper;
        public AttractionListBll(IAttractionListDal attractionListDal, IMapper mapper)
        {
            this.attractionListDal = attractionListDal;
            this.mapper = mapper;
        }
        public List<AttractionListDto> GetAttractionListByUserId(int userId)
        {
            return mapper.Map<List<AttractionListDto>>(attractionListDal.GetAttractionListByUserId(userId));
        }

    }
}
