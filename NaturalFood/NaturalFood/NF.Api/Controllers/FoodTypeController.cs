using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NF.Api.Controllers.Base;
using NF.Api.DTOs;
using NF.Application.ApplicationServices.Interfaces;

namespace NF.Api.Controllers
{
    [Route("/foodtype")]
    public class FoodTypeController : BaseController
    {

        private readonly IFoodTypeAppService foodTypeAppService;
        private readonly IMapper mapper;

        public FoodTypeController(IMapper mapper, IFoodTypeAppService foodTypeAppService)
        {
            this.mapper = mapper;
            this.foodTypeAppService = foodTypeAppService;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<FoodTypeDTO> Get([FromRoute] int id)
        {
            var foodType = mapper.Map<FoodTypeDTO>(foodTypeAppService.GetById(id));
            return Ok(foodType);
        }

    }
}
