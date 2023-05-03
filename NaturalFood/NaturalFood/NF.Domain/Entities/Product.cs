using NF.Domain.Entities.Base;

namespace NF.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Ingredients { get; set; }
        public bool LowCarb { get; set; }
    }
}
