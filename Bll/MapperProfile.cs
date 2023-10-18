using AutoMapper;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public  class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Attraction, AttractionDto>().ForMember(x=>x.CityName,y=>y.MapFrom(t=>t.Address.City));
            CreateMap<AttractionDto, Attraction>();
            //כאן יתווספו כל הטבלאות
        }
    }
}
