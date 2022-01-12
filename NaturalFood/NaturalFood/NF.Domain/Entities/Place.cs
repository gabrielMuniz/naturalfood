using NF.Domain.Entities.Base;

namespace NF.Domain.Entities
{
    public class Place : EntityBase
    {

        public string SocialName { get; set; }
        public string FantasyName { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public virtual FoodType FoodType { get; set; }
        public int FoodTypeId { get; set; }

    }
}
