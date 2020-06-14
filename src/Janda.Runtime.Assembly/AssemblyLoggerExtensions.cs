using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Janda.Runtime
{
    public static class AssemblyLoggerExtensions
    {
        public static IServiceCollection AddAssemblyLogger(this IServiceCollection services)
        {
            return services.AddTransient<IAssemblyLogger, AssemblyLogger>();
        }

        public static IServiceCollection AddAssemblyLogger(this IServiceCollection services, LogLevel logLevel)
        {
            AssemblyLogger.LogLevel = logLevel;
            return services.AddAssemblyLogger();
        }

        public static IServiceCollection AddAssemblyLogger(this IServiceCollection services, string namespaceStartsWith)
        {
            AssemblyLogger.NamespaceStartsWith = namespaceStartsWith;
            return services.AddAssemblyLogger();
        }


        public static IServiceCollection AddAssemblyLogger(this IServiceCollection services, LogLevel logLevel, string namespaceStartsWith)
        {
            AssemblyLogger.NamespaceStartsWith = namespaceStartsWith;
            AssemblyLogger.LogLevel = logLevel;
            return services.AddAssemblyLogger();
        }

    }
}
