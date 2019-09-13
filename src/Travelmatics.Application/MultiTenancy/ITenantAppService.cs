using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Travelmatics.MultiTenancy.Dto;

namespace Travelmatics.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

