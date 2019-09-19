using System;
using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Authorization;
using Travelmatics.Authorization;
using Travelmatics.Roles.Dto;

namespace Travelmatics.Contacts
{
    [AbpAuthorize]
    public class ContactAppService : TravelmaticsAppServiceBase
    {
        private readonly ContactManager contactManager;


        public ContactAppService(
            ContactManager contactManager)
        {
            this.contactManager = contactManager;
        }

        public List<ContactDto> GetAllContacts()
        {

            var contacts = contactManager.GetAllContacts();

            var outputContacts = new List<ContactDto>();


            return outputContacts;

        }
    }
}


   
