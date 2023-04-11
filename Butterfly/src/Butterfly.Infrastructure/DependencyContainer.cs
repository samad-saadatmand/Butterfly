using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Butterfly.Infrastructure;
public static class DependencyContainer
{
    /// <summary>
    /// Configuration for external services and infra...
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
    }
}