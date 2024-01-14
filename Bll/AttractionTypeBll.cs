using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;
namespace Bll
{
    public class AttractionTypeBll : IAttractionTypeBll
    {
        private readonly IAttractionTypeDal attractionTypeDal;
        private readonly IMapper mapper;
        public AttractionTypeBll(IAttractionTypeDal attractionTypeDal, IMapper mapper)
        {
            this.attractionTypeDal = attractionTypeDal;
            this.mapper = mapper;
        }
        public List<AttractionTypeDto> GetAll()
        {
            return mapper.Map<List<AttractionTypeDto>>(attractionTypeDal.GetAll());
        }
    }
}
