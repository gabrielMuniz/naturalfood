using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NF.Api.Controllers.Base;
using NF.Api.DTOs;
using NF.Application.ApplicationServices.Interfaces;
using System.Collections.Generic;

namespace NF.Api.Controllers
{
    [Route("/places")]
    public class PlaceController : BaseController
    {

        private readonly IPlaceAppService placeAppService;
        private readonly IMapper mapper;

        public PlaceController(IMapper mapper, IPlaceAppService placeAppService)
        {
            this.mapper = mapper;
            this.placeAppService = placeAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlaceDTO>> GetAll()
        {
            var places = mapper.Map<IEnumerable<PlaceDTO>>(placeAppService.GetAll());
            return Ok(places);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<PlaceDTO> Get([FromRoute] int id)
        {
            var place = mapper.Map<PlaceDTO>(placeAppService.GetById(id));
            return Ok(place);
        }
    }
}
