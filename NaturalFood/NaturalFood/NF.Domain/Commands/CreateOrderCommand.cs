using System.Collections.Generic;

namespace NF.Domain.Commands
{
    public class CreateOrderCommand
    {

        public IEnumerable<int> OrderItems { get; set; }
        public double TotalValue { get; set; }
        public double Freight { get; set; }

    }
}
