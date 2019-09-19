using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Travelmatics.Authorization.Users;

namespace Travelmatics
{
    public class ContactDetail : User
    {

        public string MobileNumber { get; set; }
        public string WebsiteUrl { get; set; }


        public ContactDetail()
        {
        }
    }
}
