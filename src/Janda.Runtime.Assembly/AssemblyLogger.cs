using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;

namespace Janda.Runtime
{
    public class AssemblyLogger : IAssemblyLogger
    {
        public static LogLevel LogLevel { get; set; } = LogLevel.Debug;
        public static string NamespaceStartsWith { get; set; } = typeof(AssemblyLogger).Namespace?.Split('.').FirstOrDefault();

        public AssemblyLogger(ILogger<AssemblyLogger> logger)
        {
            AssemblyLoaded((assembly) => { logger.Log(LogLevel, "Loaded {@Assembly}", new { assembly }); }, NamespaceStartsWith);
        }

        private static dynamic GetAssemblyInfo(Assembly assembly)
        {
            return new 
            { 
                Name = assembly.GetAssemblyName(), 
                Version = assembly.GetInformationalVersion() 
            };
        }

        public static void AssemblyLoaded(Action<dynamic> callback)
        {
            AppDomain.CurrentDomain.AssemblyLoad += (object sender, AssemblyLoadEventArgs args) =>
            {
                callback(GetAssemblyInfo(args.LoadedAssembly));
            };
        }

        public static void AssemblyLoaded(Action<dynamic> callback, string namespaceStartsWith)
        {
            if (namespaceStartsWith == null)
                throw new ArgumentNullException(namespaceStartsWith);

            AppDomain.CurrentDomain.AssemblyLoad += (object sender, AssemblyLoadEventArgs args) =>
            {
                if (args.LoadedAssembly.FullName.StartsWith(namespaceStartsWith))
                    callback(GetAssemblyInfo(args.LoadedAssembly));
            };
        }
    }
}
