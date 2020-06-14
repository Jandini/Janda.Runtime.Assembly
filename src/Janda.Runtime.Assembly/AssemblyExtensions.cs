using System.Reflection;

namespace Janda.Runtime
{
    public static class AssemblyExtensions
    {
        public static string GetInformationalVersion(this Assembly assembly)
        {
            return assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
        
        public static string GetAssemblyName(this Assembly assembly)
        {
            return assembly.GetName().Name;
        }
    }
}
