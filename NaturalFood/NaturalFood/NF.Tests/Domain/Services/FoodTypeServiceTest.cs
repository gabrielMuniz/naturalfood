using Moq;
using NF.Domain.Interfaces.Repositories;
using NF.Domain.Interfaces.Services;
using NF.Domain.Services;
using NF.Tests.FakeData.Domain;
using System.Linq;
using Xunit;

namespace NF.Tests.Domain.Services
{
    public class FoodTypeServiceTest
    {

        private IFoodTypeService _foodTypeService;
        private readonly Mock<IFoodTypeRepository> _foodTypeRepositoryMock = new Mock<IFoodTypeRepository>();
        private readonly FoodTypeDataFaker foodTypeDataFaker;

        public FoodTypeServiceTest()
        {
            foodTypeDataFaker = new FoodTypeDataFaker();
        }

        [Fact]
        public void WhenTheFoodTypeListIsRequiredThenTheListShouldBeReturned()
        {
            _foodTypeRepositoryMock.Setup(repository => repository.GetAll())
                .Returns(foodTypeDataFaker.GenerateFoodTypes(10));

            _foodTypeService = new FoodTypeService(_foodTypeRepositoryMock.Object);

            var actualResults = _foodTypeService.GetAll();

            Assert.True(actualResults.ToList().Count > 0);

        }

        [Fact]
        public void WhenTheFoodTypeUpdateIsCalledThenTheRepositoryUpdateShouldBeCalled()
        {
            var foodType = foodTypeDataFaker.GenerateFoodType();
            _foodTypeRepositoryMock.Setup(repository =>
                repository.Update(foodType))
                .Returns(foodType);

            _foodTypeService = new FoodTypeService(_foodTypeRepositoryMock.Object);

            var actualResult = _foodTypeService.Update(foodType);

            _foodTypeRepositoryMock.Verify(repository => repository.Update(foodType),
                times: Times.Once);

        }
    }
}
