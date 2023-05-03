using NF.Domain.Entities;

namespace NF.Domain.Interfaces.Repositories
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {

        public void AddOrderItem(OrderItem orderItem);

    }
}
