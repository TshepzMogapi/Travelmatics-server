using System.Threading.Tasks;
using Abp.Application.Services;
using Travelmatics.Sessions.Dto;

namespace Travelmatics.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
