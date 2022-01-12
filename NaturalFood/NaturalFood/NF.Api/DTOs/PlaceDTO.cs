namespace NF.Api.DTOs
{
    public class PlaceDTO
    {

        public string SocialName { get; set; }
        public string FantasyName { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public FoodTypeDTO FoodType { get; set; }
        public int FoodTypeId { get; set; }
    }
}
