using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace NF.Domain.Services
{
    public class PlaceService : IPlaceService
    {

        private readonly IPlaceRepository placeRepository;

        public PlaceService(IPlaceRepository placeRepository)
        {
            this.placeRepository = placeRepository;
        }

        public IEnumerable<Place> GetAll() => placeRepository.GetAll();

        public Place GetById(int id) => placeRepository.GetById(id);
    }
}
