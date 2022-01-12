using NF.Domain.Entities;
using System.Collections.Generic;

namespace NF.Application.ApplicationServices.Interfaces
{
    public interface IFoodTypeAppService
    {
        IEnumerable<FoodType> GetAll();
        FoodType GetById(int id);
        int Delete(int id);
        int Update(FoodType foodType);
    }
}
