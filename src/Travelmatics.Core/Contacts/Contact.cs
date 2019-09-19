using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using Travelmatics.Authorization.Users;

namespace Travelmatics.Contacts
{
    public class Contact : FullAuditedEntity 
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public long UserId { get; set; }

        public int ContactId { get; set; }

        public User User { get; set; }

        public List<UserContact> UserContacts;


        public Contact()
        {
            CreationTime = Clock.Now;
        }

        public Contact(string firstName, string lastName = null)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public static Contact Create(string firstName, string lastName = null)
        {
            var contact = new Contact
            {
                FirstName = firstName,
                LastName = lastName

            };

            return contact;
        }
    }

   
}
