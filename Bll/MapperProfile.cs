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
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Attraction, AttractionDto>().ForMember(x=>x.CityName,y=>y.MapFrom(t=>t.Address.City));
            CreateMap<AttractionDto, Attraction>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<SavedAttraction, SavedAttractionDto>();
            CreateMap<SavedAttractionDto, SavedAttraction>();
            CreateMap<AttractionList, AttractionListDto>();
            CreateMap<AttractionListDto, AttractionList>();
            CreateMap<TripList, TripListDto>();
            CreateMap<TripListDto, TripList>();
            //כאן יתווספו כל הטבלאות
        }
    }
}
