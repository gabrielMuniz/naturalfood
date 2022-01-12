using NF.Domain.Entities.Base;

namespace NF.Domain.Entities
{
    public class FoodType : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}