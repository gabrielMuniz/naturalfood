using AutoMapper;
using NF.Application.Commands;
using NF.Application.DTOs;

namespace NF.Application.Configurations.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<CreateOrderDTO, CreateOrderCommand>();
        }
    }
}
