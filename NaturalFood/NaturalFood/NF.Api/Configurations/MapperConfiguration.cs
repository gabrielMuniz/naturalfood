using Microsoft.Extensions.DependencyInjection;
using NF.Application.Configurations.Profiles;

namespace NF.Api.Configurations
{
    public static class MapperConfiguration
    {

        public static AutoMapper.MapperConfiguration AddMapperConfig(this IServiceCollection services)
        {
            return new AutoMapper.MapperConfiguration(config =>
            {
                config.AddProfile<FoodTypeProfile>();
                config.AddProfile<PlaceProfile>();
                config.AddProfile<OrderProfile>();
            });
        }

    }
}
