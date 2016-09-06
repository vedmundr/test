using Abp.Authorization;
using Vysotskyi.Authorization.Roles;
using Vysotskyi.MultiTenancy;
using Vysotskyi.Users;

namespace Vysotskyi.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
