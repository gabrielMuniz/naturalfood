using NF.Domain.Entities;
using NF.Domain.Interfaces.Repositories;
using NF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace NF.Domain.Services
{
    public class FoodTypeService : IFoodTypeService
    {

        private readonly IFoodTypeRepository foodTypeRepository;

        public FoodTypeService(IFoodTypeRepository foodTypeRepository)
        {
            this.foodTypeRepository = foodTypeRepository;
        }

        public IEnumerable<FoodType> GetAll() => foodTypeRepository.GetAll();


        public FoodType GetById(int id) => foodTypeRepository.GetById(id);

        public int Update(FoodType foodType) => foodTypeRepository.Update(foodType);
    }
}
