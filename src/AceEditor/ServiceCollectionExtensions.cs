using System.Linq;

#if NET
using EPiServer.Shell.Modules;
using Microsoft.Extensions.DependencyInjection;
#else
using EPiServer.Shell.Modules.Internal;
using EPiServer.ServiceLocation;
using IServiceCollection = EPiServer.ServiceLocation.IServiceConfigurationProvider;
#endif

namespace AceEditor
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAceEditor(this IServiceCollection services)
        {
            return services.Configure<ProtectedModuleOptions>(pmo =>
            {
                if (!pmo.Items.Any(x => x.Name.Equals("AceEditor")))
                {
                    pmo.Items.Add(new ModuleDetails { Name = "AceEditor" });
                }
            });
        }
    }
}
