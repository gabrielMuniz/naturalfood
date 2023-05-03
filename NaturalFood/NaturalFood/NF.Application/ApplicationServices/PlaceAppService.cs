using NF.Application.ApplicationServices.Interfaces;
using NF.Domain.Entities;
using NF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace NF.Application.ApplicationServices
{
    public class PlaceAppService : IPlaceAppService
    {
        private readonly IPlaceService placeService;

        public PlaceAppService(IPlaceService placeService)
        {
            this.placeService = placeService;
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Place> GetAll() => placeService.GetAll();

        public Place GetById(int id) => placeService.GetById(id);

        public Place Update(Place place)
        {
            throw new System.NotImplementedException();
        }
    }
}
