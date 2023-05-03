using AutoMapper;
using NF.Application.DTOs;
using NF.Domain.Entities;

namespace NF.Application.Configurations.Profiles
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
