using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;
using Travelmatics.Contacts;

namespace Travelmatics.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public string IdNumber { get; set; }

        public string PassportNumber { get; set; }

        public string ProfilePicUrl { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        //public ContactDetail ContactDetails { get; set; }


        //public List<Contact> UserContacts { get; set; }


        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }

        
    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
        NonBinary = 3
    }
}
