using AutoMapper;
using Dal;
using Dto;
using Entity;
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

        public PostAttractionList Add(PostAttractionList attractionList)
        {
            return mapper.Map<PostAttractionList>(attractionListDal.Add(mapper.Map<AttractionList>(attractionList)));
        }

        public List<AttractionListDto> GetAttractionListByAttractionId(int attractionId, int myattractionList)
        {
            return mapper.Map<List<AttractionListDto>>(attractionListDal.GetAttractionListByAttractionId(attractionId, myattractionList));
        }

        public List<AttractionListDto> GetAttractionListByUserId(int userId)
        {
            return mapper.Map<List<AttractionListDto>>(attractionListDal.GetAttractionListByUserId(userId));
        }

    }
}
