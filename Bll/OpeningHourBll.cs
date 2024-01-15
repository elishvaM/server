using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;
using Entity;
namespace Bll
{
    public class OpeningHourBll : IOpeningHourBll
    {

        private readonly IOpeningHourDal openingHoureDal;
        private readonly IMapper mapper;
        public OpeningHourBll(IOpeningHourDal openingHoureDal, IMapper mapper)
        {
            this.openingHoureDal = openingHoureDal;
            this.mapper = mapper;
        }
        public OpeningHourDto Get(AttractionDto attraction)
        {
            return mapper.Map<OpeningHourDto>(openingHoureDal.Get(mapper.Map<Attraction>(attraction)));
        }
        public List<OpeningHourDto> Get(int id)
        {
            //mapper.Map < List < CommentDto >>
            return mapper.Map<List<OpeningHourDto>>(this.openingHoureDal.Get(id));
        }

        public void Update(OpeningHourDto openingHour)
        {
            openingHoureDal.Update(mapper.Map<OpeningHour>(openingHour));
        }
    }
}
