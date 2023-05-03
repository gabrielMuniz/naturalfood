using AutoMapper;
using NF.Application.DTOs;
using NF.Domain.Entities;

namespace NF.Application.Configurations.Profiles
{
    public class FoodTypeProfile : Profile
    {
        public FoodTypeProfile()
        {
            CreateMap<FoodType, FoodTypeDTO>().ReverseMap();
        }
    }
}
