using Microsoft.Extensions.DependencyInjection;
using NF.Domain.Interfaces.Repositories;
using NF.Infra.Data.Repositories;

namespace NF.Api.Configurations
{
    public static class RepositoryConfiguration
    {

        public static void AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPlaceRepository, PlaceRepository>();
            services.AddTransient<IFoodTypeRepository, FoodTypeRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
        }

    }
}
