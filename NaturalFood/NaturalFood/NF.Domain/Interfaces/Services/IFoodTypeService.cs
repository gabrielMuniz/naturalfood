using NF.Domain.Entities;

namespace NF.Domain.Interfaces.Services
{
    public interface IFoodTypeService
    {

        FoodType GetById(int id);

    }
}
