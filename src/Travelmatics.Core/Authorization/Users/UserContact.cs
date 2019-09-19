using System;
using System.ComponentModel.DataAnnotations.Schema;
using Travelmatics.Contacts;

namespace Travelmatics.Authorization.Users
{
    [Table("UserContacts")]
    public class UserContact
    {

        public long UserId { get; set; }

        public User User { get; set; }

        public int ContactId { get; set; }

        public Contact Contact { get; set; }

    }
}
