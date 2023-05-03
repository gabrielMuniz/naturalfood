using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NF.Api.Controllers.Base;
using NF.Api.DTOs;
using NF.Application.ApplicationServices.Interfaces;
using NF.Application.DTOs;

namespace NF.Api.Controllers
{
    public class OrderController : BaseController
    {

        private readonly IOrderAppService orderAppService;
        private readonly IMapper mapper;

        public OrderController(IOrderAppService orderAppService, IMapper mapper)
        {
            this.orderAppService = orderAppService;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult Save([FromBody] CreateOrderDTO createOrderDTO)
        {
            this.orderAppService.Add(createOrderDTO);

            return Ok();
        }
    }
}
