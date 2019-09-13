using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Travelmatics.Controllers
{
    public abstract class TravelmaticsControllerBase: AbpController
    {
        protected TravelmaticsControllerBase()
        {
            LocalizationSourceName = TravelmaticsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
