using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Infra.Data.Contexts;
using NF.Infra.Data.Repositories.Base;

namespace NF.Infra.Data.Repositories
{
    public class PlaceRepository : BaseRepository<Place>, IPlaceRepository
    {
        public PlaceRepository(DefaultContext context) : base(context)
        {}
    }
}
