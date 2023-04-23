using AutoMapper;
using BspAcademy.Core.DTOs;
using BspAcademy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BspAcademy.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AidNotice, AidNoticeAddDto>().ReverseMap();
            CreateMap<AidNotice, AidNoticeWithCityCategoryDto>().ReverseMap();
            CreateMap<AidNotice, AidNoticeWithCityCategoryDto>().ReverseMap();

            CreateMap<City,CityDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
           


        }
    }
}
