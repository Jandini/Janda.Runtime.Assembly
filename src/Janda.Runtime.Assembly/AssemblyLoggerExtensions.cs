using Microsoft.Extensions.DependencyInjection;

namespace Janda.Runtime
{
    public static class AssemblyLoggerExtensions
    {
        public static IServiceCollection AddAssemblyLogger(this IServiceCollection services)
        {
            return services.AddTransient<IAssemblyLogger, AssemblyLogger>();
        }
    }
}
