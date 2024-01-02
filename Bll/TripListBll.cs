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
    public class TripListBll : ITripListBll
    {
        private readonly ITripListDal tripListDal;
        private readonly IMapper mapper;
        public TripListBll(ITripListDal tripListDal, IMapper mapper)
        {
            this.tripListDal = tripListDal;
            this.mapper = mapper;
        }
        public TripListDto Add(TripListDto tripList)
        {
            return mapper.Map<TripListDto>(this.tripListDal.Add(mapper.Map<TripList>(tripList)));
        }

        public void Delete(TripListDto tripList)
        {
            this.tripListDal.Delete(mapper.Map<TripList>(tripList));
        }

        public List<TripListDto> GetAll(int userId)
        {

            return mapper.Map<List<TripListDto>>(this.tripListDal.GetAll(userId));
        }

        public void Update(TripListDto tripList)
        {
            this.tripListDal.Update(mapper.Map<TripList>(tripList));
        }
    }
}
