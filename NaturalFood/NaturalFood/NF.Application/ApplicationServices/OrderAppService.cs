using AutoMapper;
using NF.Application.ApplicationServices.Interfaces;
using NF.Application.DTOs;
using NF.Domain.Commands;
using NF.Domain.Interfaces.Services;

namespace NF.Application.ApplicationServices
{
    public class OrderAppService : IOrderAppService
    {

        private readonly IOrderService orderService;
        private readonly IMapper mapper;

        public OrderAppService(IOrderService orderService, IMapper mapper)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }

        public void Add(CreateOrderDTO createOrderDTO)
        {
            var createOrderCommand = mapper.Map<CreateOrderCommand>(createOrderDTO);
            this.orderService.Add(createOrderCommand);
        }
    }
}
