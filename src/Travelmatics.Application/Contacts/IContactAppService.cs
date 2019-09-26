using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Travelmatics.Roles.Dto;

namespace Travelmatics.Contacts

{
    public interface IContactAppService : IAsyncCrudAppService<ContactDto>
    {

        //Task<ListResultDto<ContactDto>> GetAllContacts();

    }
}


