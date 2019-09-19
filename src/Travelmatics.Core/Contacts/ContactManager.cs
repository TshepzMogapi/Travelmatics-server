using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;

namespace Travelmatics.Contacts
{
    public class ContactManager : DomainService
    {

        private readonly IRepository<Contact> contactRepository;
        
        public ContactManager(IRepository<Contact> contactRepository,
            IUnitOfWorkManager unitOfWorkManager
            )
        {
            this.contactRepository = contactRepository;
        }

        public List<Contact> GetAllContacts()
        {
            var contacts = contactRepository.GetAll().OrderBy(contact => contact.FirstName).ToList();

            return contacts;
        }


        public async Task<Contact> CreateContactAsync(string name, string surname, string emailAddress)
        {



            var contact = new Contact
            {
                FirstName = name,
                LastName = surname,
                EmailAddress = emailAddress,
                
            };

            await this.contactRepository.InsertAsync(contact);

            await CurrentUnitOfWork.SaveChangesAsync();

            return contact;
        }
    }
}
