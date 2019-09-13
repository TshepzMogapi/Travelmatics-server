using Abp.Authorization;
using Travelmatics.Authorization.Roles;
using Travelmatics.Authorization.Users;

namespace Travelmatics.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
