using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Travelmatics.Roles.Dto;
using Travelmatics.Users.Dto;

namespace Travelmatics.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
