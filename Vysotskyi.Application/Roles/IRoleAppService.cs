using System.Threading.Tasks;
using Abp.Application.Services;
using Vysotskyi.Roles.Dto;

namespace Vysotskyi.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
