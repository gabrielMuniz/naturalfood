using NF.Domain.Entities;
using System.Collections.Generic;

namespace NF.Domain.Interfaces.Services
{
    public interface IPlaceService
    {

        IEnumerable<Place> GetAll();
        Place GetById(int id);
    }
}
