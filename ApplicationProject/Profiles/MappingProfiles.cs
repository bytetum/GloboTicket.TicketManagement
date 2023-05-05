using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationProject.Features;
using AutoMapper;
using Domain.Entities;

namespace ApplicationProject.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
        }
    }
}
