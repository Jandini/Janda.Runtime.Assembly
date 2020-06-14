using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace Janda.Runtime
{
    public class AssemblyLogger : IAssemblyLogger
    {
        public static LogLevel LogLevel { get; set; } = LogLevel.Information;
        public static string NamespaceStartsWith { get; set; } = typeof(AssemblyLogger).Namespace?.Split('.').FirstOrDefault();

        public AssemblyLogger(ILogger<AssemblyLogger> logger)
        {
            AssemblyLoaded((assembly) => { logger.Log(LogLevel, "Loaded {@Assembly}", new { assembly }); }, NamespaceStartsWith);
        }

        public static void AssemblyLoaded(Action<dynamic> callback, string namespaceStartsWith = null)
        {
            AppDomain.CurrentDomain.AssemblyLoad += (object sender, AssemblyLoadEventArgs args) =>
            {
                if (namespaceStartsWith == null || args.LoadedAssembly.FullName.StartsWith(namespaceStartsWith))
                    callback(new { Name = args.LoadedAssembly.GetAssemblyName(), Version = args.LoadedAssembly.GetInformationalVersion() });
            };
        }
    }
}
