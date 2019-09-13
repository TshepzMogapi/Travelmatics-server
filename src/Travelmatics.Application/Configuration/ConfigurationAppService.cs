using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Travelmatics.Configuration.Dto;

namespace Travelmatics.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TravelmaticsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
