using Butterfly.Application.Features.MathOperation.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Butterfly.Application;
public static class DependencyContainer
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IMathOperationService, MathOperationService>();
    }
}