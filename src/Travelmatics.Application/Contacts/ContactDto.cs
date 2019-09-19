using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Travelmatics.Contacts
{
    [AutoMapFrom(typeof(Contact))]
    public class ContactDto : EntityDto<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
    }
}
