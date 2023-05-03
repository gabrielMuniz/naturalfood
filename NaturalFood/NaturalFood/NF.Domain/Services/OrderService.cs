using NF.Domain.Commands;
using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Domain.Interfaces.Services;
using System.Linq;

namespace NF.Domain.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;

        public OrderService(IOrderRepository orderRepository,
            IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }

        public void Add(CreateOrderCommand createOrderCommand)
        {
            var totalValue = productRepository
                .GetProductsByIds(createOrderCommand.OrderItems)
                .ToList()
                .Sum(product => product.Price);


            this.orderRepository.Add(new Order
            {
                Freight = createOrderCommand.Freight,
                TotalValue = totalValue,
                OrderItems = 
            });
        }
    }
}
