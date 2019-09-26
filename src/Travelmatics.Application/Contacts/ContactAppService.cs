using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Travelmatics.Authorization;
using Travelmatics.Roles.Dto;

namespace Travelmatics.Contacts
{

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

            var contactsDto = new List<ContactDto>();

            foreach (var item in contacts)
            {
                var dto = ObjectMapper.Map<ContactDto>(item);

                dto.FirstName = item.FirstName;
                dto.LastName = item.LastName;

                contactsDto.Add(dto);
            }



            return contactsDto;

        }

        public async Task CreateContact(ContactDto contactDto)
        {


            //var contact = ObjectMapper.Map<Contact>(contactDto);

            var contact = new Contact();
            contact.FirstName = "Tshepiso";
            contact.LastName = "Mogapi";
            contact.EmailAddress = "tshepzmogapi@gmail.com";
            //{
            //    LastName = contactDto.LastName
            //};

            contact = await contactManager.CreateContactAsync(contact);

            //var output = ObjectMapper.Map<ContactDto>(contact);

            //await contactManager.CreateContactAsync("Tshepiso", "Mogapi", "tshepz@email.com");

            return;



        }
    }
}


   
