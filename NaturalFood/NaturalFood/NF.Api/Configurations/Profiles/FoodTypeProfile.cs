using AutoMapper;
using NF.Api.DTOs;
using NF.Domain.Entities;

namespace NF.Api.Configurations.Profiles
{
    public class FoodTypeProfile : Profile
    {
        public FoodTypeProfile()
        {
            CreateMap<FoodType, FoodTypeDTO>().ReverseMap();
        }
    }
}
