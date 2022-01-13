using NF.Domain.Entities;
using System.Collections.Generic;

namespace NF.Domain.Interfaces.Services
{
    public interface IFoodTypeService
    {

        FoodType GetById(int id);
        IEnumerable<FoodType> GetAll();

    }
}
