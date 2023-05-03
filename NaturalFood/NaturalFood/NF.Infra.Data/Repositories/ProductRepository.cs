using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Infra.Data.Contexts;
using NF.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace NF.Infra.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DefaultContext context) : base(context)
        { }

        public IEnumerable<Product> GetProductsByIds(IEnumerable<int> productIds)
        {
            return context.Products.Where(product => productIds.ToList()
                .Contains(product.Id));
        }
    }
}
