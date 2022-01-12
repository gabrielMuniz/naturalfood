using Microsoft.Extensions.DependencyInjection;
using NF.Domain.Interfaces.Services;
using NF.Domain.Services;

namespace NF.Api.Configurations
{
    public static class ServiceConfiguration
    {

        public static void AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPlaceService, PlaceService>();
            services.AddTransient<IFoodTypeService, FoodTypeService>();
        }

    }
}
