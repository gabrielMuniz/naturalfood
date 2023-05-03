using NF.Domain.Entities;
using System.Collections.Generic;

namespace NF.Application.ApplicationServices.Interfaces
{
    public interface IPlaceAppService
    {
        IEnumerable<Place> GetAll();
        Place GetById(int id);
        int Delete(int id);
        Place Update(Place place);

    }
}
