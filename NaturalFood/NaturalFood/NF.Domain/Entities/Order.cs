using System.Collections.Generic;

namespace NF.Domain.Entities
{
    public class Order
    {

        public IEnumerable<OrderItem> OrderItems { get; set; }
        public double TotalValue { get; set; }
        public double Freight { get; set; }

    }
}