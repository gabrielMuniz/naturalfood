using NF.Domain.Entities;
using System.Collections.Generic;

namespace NF.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {

        public IEnumerable<Product> GetProductsByIds(IEnumerable<int> productIds);

    }
}
