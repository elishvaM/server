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
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<User, UserDto>()
              .ForMember(u => u.Type, y => y.MapFrom(t => t.UserType.Type));
            CreateMap<FullUser, User>();
            CreateMap<User, FullUser>();
            CreateMap<UserDto, User>();
            CreateMap<Attraction, AttractionDto>()
              .ForMember(u => u.Type, y => y.MapFrom(t => t.Type.Type))
                .ForMember(u => u.State, y => y.MapFrom(t => t.PersonState.State));
            CreateMap<AttractionDto, Attraction>()
            //.ForMember(a => a.Address, y => y.MapFrom(t => t.Address))
            .ForMember(a => a.Type, y => y.MapFrom(t => t.Type))
            .ForMember(a => a.PersonState, y => y.MapFrom(t => t.State));

            CreateMap<Product, ProductDto>()
            .ForMember(a => a.StorageType, y => y.MapFrom(t => t.StorageType.Type))
            .ForMember(a => a.ProductType, y => y.MapFrom(t => t.ProductType.Type));
            CreateMap<ProductDto, Product>()
                .ForPath(a => a.StorageType.Type, y => y.MapFrom(t => t.StorageType))//totch now
                .ForPath(a => a.ProductType.Type, y => y.MapFrom(t => t.ProductType));//totch now
            CreateMap<SavedAttraction, SavedAttractionDto>();
            CreateMap<SavedAttractionDto, SavedAttraction>();
            CreateMap<AttractionList, AttractionListDto>()
                .ForMember(u => u.AttractionListProduct, y => y.MapFrom(x => x.AttractionListProducts));
            CreateMap<AttractionListDto, AttractionList>();
            CreateMap<PostAttractionList, AttractionList>();
            CreateMap<AttractionList, PostAttractionList>();

            CreateMap<TripList, TripListDto>()
                 .ForMember(u => u.CounAtraction, y => y.MapFrom(t => t.AttractionLists.Count()))
               //כשמדובר בטבלה שהיא רשימה ולא אובייקט בודד חובה לפרט ידני 
               .ForMember(u => u.AttractionList, y => y.MapFrom(t => t.AttractionLists));
            CreateMap<TripListDto, TripList>();
            CreateMap<Address, AddressDto>();
            CreateMap<AddressDto, Address>();
            CreateMap<AttractionType, AttractionTypeDto>();
            CreateMap<AttractionTypeDto, AttractionType>();
            CreateMap<PersonState, PersonStateDto>();
            CreateMap<PersonStateDto, PersonState>();
            CreateMap<Comment, CommentDto>();
            CreateMap<CommentDto, Comment>();
            CreateMap<PostComment, Comment>();
            CreateMap<ProductType, ProductTypeDto>();
            CreateMap<ProductTypeDto, ProductType>();
            CreateMap<AttractionListProduct, AttractionListProductDto>()
                 .ForMember(u => u.StatusName, y => y.MapFrom(t => t.Status.Type));
            CreateMap<AttractionListProductDto, AttractionListProduct>();
            CreateMap<StorageType, StorageTypeDto>();
            CreateMap<StorageTypeDto, StorageType>();
            CreateMap<AttractionType, AttractionTypeDto>();
            CreateMap<AttractionTypeDto, AttractionType>();
            CreateMap<PersonState, PersonStateDto>();
            CreateMap<PersonStateDto, PersonState>();
            CreateMap<OpeningHour, OpeningHourDto>();
            CreateMap<OpeningHourDto, OpeningHour>();
            //כאן יתווספו כל הטבלאות
            
           
        }
  
    }
}
