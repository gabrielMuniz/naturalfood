using NF.Application.ApplicationServices.Interfaces;
using NF.Domain.Entities;
using NF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace NF.Application.ApplicationServices
{
    public class FoodTypeAppService : IFoodTypeAppService
    {

        private readonly IFoodTypeService foodTypeService;

        public FoodTypeAppService(IFoodTypeService foodTypeService)
        {
            this.foodTypeService = foodTypeService;
        }

        public int Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FoodType> GetAll() => foodTypeService.GetAll();

        public FoodType GetById(int id) => foodTypeService.GetById(id);

        public FoodType Update(FoodType foodType) => foodTypeService.Update(foodType);
    }
}
