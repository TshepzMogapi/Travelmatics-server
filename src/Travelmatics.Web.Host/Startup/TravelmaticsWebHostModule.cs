using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Travelmatics.Configuration;

namespace Travelmatics.Web.Host.Startup
{
    [DependsOn(
       typeof(TravelmaticsWebCoreModule))]
    public class TravelmaticsWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TravelmaticsWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TravelmaticsWebHostModule).GetAssembly());
        }
    }
}
