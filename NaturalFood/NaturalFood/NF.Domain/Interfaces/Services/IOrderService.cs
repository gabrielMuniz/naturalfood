using NF.Domain.Commands;

namespace NF.Domain.Interfaces.Services
{
    public interface IOrderService
    {

        public void Add(CreateOrderCommand createOrderCommand);

    }
}
