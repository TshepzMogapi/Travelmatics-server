using System.Threading.Tasks;
using Travelmatics.Configuration.Dto;

namespace Travelmatics.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
