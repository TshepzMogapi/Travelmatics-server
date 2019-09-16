using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace Travelmatics.Contacts
{
    [Table("Contacts")]
    public class Contact : Entity, IHasCreationTime
    {
       

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string EmailAddress { get; set; }

        public DateTime CreationTime { get; set; }


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
    }

   
}
