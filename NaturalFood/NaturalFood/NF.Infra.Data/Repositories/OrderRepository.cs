using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Infra.Data.Contexts;
using NF.Infra.Data.Repositories.Base;

namespace NF.Infra.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DefaultContext context):base(context)
        { }

        public void AddOrderItem(OrderItem orderItem)
        {
            var entity = context.OrderItems.Add(orderItem).Entity;
            context.SaveChanges();
        }
    }
}
