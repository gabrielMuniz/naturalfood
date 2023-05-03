using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NF.Api.Controllers.Base;
using NF.Application.ApplicationServices.Interfaces;
using NF.Application.DTOs;
using RabbitMQ.Client;
using System.Collections.Generic;
using System.Text;

namespace NF.Api.Controllers
{
    [Route("/places")]
    public class PlaceController : BaseController
    {

        private readonly IPlaceAppService placeAppService;
        private readonly IMapper mapper;
        private readonly ConnectionFactory _connectionFactory;

        public PlaceController(IMapper mapper, IPlaceAppService placeAppService)
        {
            this.mapper = mapper;
            this.placeAppService = placeAppService;
            _connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };
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

        [HttpPost]
        [Route("/")]
        public ActionResult<PlaceDTO> Post([FromBody] PlaceDTO place)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var stringfiedMessage = JsonConvert.SerializeObject(place);
                    var bytesMessage = Encoding.UTF8.GetBytes(stringfiedMessage);

                    channel.BasicPublish(
                        exchange: "",
                        routingKey: "places",
                        basicProperties: null,
                        body: bytesMessage
                        );
                }
            }
            return Accepted();
        }
    }
}
