using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Travelmatics.Roles.Dto;

namespace Travelmatics.Contacts

{
    public interface IContactAppService : IAsyncCrudAppService<ContactDto, int, PagedRoleResultRequestDto, ContactDto, RoleDto>
    {

        Task<ContactDto> GetContacts(ContactDto input);

    }
}


