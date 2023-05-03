using Bogus;
using NF.Domain.Entities;
using System.Collections.Generic;

namespace NF.Tests.FakeData.Domain
{
    public class FoodTypeDataFaker
    {

        public IEnumerable<FoodType> GenerateFoodTypes(int amount) =>
            new Faker<FoodType>("pt_BR").Generate(amount);

        public FoodType GenerateFoodType() =>
            new Faker<FoodType>("pt_BR").Generate(1)[0];

    }
}
