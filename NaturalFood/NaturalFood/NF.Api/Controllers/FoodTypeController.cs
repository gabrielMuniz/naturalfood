using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NF.Api.Controllers.Base;
using NF.Api.DTOs;
using NF.Application.ApplicationServices.Interfaces;
using System.Collections.Generic;

namespace NF.Api.Controllers
{
    [Route("/foodtypes")]
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
        public ActionResult<FoodTypeDTO> GetAll()
        {
            var foodTypes = mapper.Map<IEnumerable<FoodTypeDTO>>(foodTypeAppService.GetAll());
            return Ok(foodTypes);
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
