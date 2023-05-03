using System.Collections.Generic;

namespace NF.Application.DTOs
{
    public class CreateOrderDTO
    {

        public IEnumerable<int> OrderItems { get; set; }

    }
}
