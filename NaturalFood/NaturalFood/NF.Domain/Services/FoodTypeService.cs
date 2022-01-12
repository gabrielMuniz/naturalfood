using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Domain.Interfaces.Services;

namespace NF.Domain.Services
{
    public class FoodTypeService : IFoodTypeService
    {

        private readonly IFoodTypeRepository foodTypeRepository;

        public FoodTypeService(IFoodTypeRepository foodTypeRepository)
        {
            this.foodTypeRepository = foodTypeRepository;
        }

        public FoodType GetById(int id)
        {
            return foodTypeRepository.GetById(id);
        }
    }
}
