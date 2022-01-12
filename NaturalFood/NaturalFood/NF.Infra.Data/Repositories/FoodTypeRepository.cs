using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Infra.Data.Repositories.Base;

namespace NF.Infra.Data.Repositories
{
    public class FoodTypeRepository : BaseRepository<FoodType>, IRepositoryBase<FoodType>
    {
    }
}
