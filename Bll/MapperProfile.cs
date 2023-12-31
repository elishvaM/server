﻿using AutoMapper;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDto>()
              .ForMember(u => u.Type, y => y.MapFrom(t => t.UserType.Type));
            CreateMap<FullUser, User>();
            CreateMap<UserDto, User>();
            CreateMap<Attraction, AttractionDto>();
            CreateMap<AttractionDto, Attraction>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<SavedAttraction, SavedAttractionDto>();
            CreateMap<SavedAttractionDto, SavedAttraction>();
            CreateMap<AttractionList, AttractionListDto>();
            CreateMap<AttractionListDto, AttractionList>();
            CreateMap<TripList, TripListDto>()
                 .ForMember(u => u.CounAtraction, y => y.MapFrom(t => t.AttractionLists.Count()))
               //כשמדובר בטבלה שהיא רשימה ולא אובייקט בודד חובה לפרט ידני 
               .ForMember(u => u.AttractionList, y => y.MapFrom(t => t.AttractionLists));
            CreateMap<TripListDto, TripList>();
            CreateMap<Address, AddressDto>();
            CreateMap<AddressDto, Address>();
            CreateMap<Comment, CommentDto>();
            CreateMap<CommentDto, Comment>();
            CreateMap<PostComment, Comment>();
            //כאן יתווספו כל הטבלאות
        }
    }
}
