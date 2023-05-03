using NF.Domain.Entities.Base;

namespace NF.Domain.Entities
{
    public class OrderItem : EntityBase
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
