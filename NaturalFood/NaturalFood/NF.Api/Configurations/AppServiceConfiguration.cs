using Microsoft.Extensions.DependencyInjection;
using NF.Application.ApplicationServices;
using NF.Application.ApplicationServices.Interfaces;

namespace NF.Api.Configurations
{
    public static class AppServiceConfiguration
    {

        public static void AddAppServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPlaceAppService, PlaceAppService>();
            services.AddTransient<IFoodTypeAppService, FoodTypeAppService>();
            services.AddTransient<IOrderAppService, OrderAppService>();
        }

    }
}
