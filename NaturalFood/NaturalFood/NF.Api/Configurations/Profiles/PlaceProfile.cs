using AutoMapper;
using NF.Api.DTOs;
using NF.Domain.Entities;

namespace NF.Api.Configurations.Profiles
{
    public class PlaceProfile : Profile
    {
        public PlaceProfile()
        {
            CreateMap<Place, PlaceDTO>().ForMember(
                place => place.FoodType,
                placeDTO => placeDTO.MapFrom(placeDTO => placeDTO.FoodType))
                .ReverseMap();
        }
    }
}
