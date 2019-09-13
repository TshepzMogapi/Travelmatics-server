using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Travelmatics.Authorization;

namespace Travelmatics
{
    [DependsOn(
        typeof(TravelmaticsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TravelmaticsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TravelmaticsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TravelmaticsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
