using SampleApp.Service.Services.UserRoles;
using System.Collections.Generic;

namespace SampleApp.Service.Contracts.Services
{
    public interface IUserRoleService
    {
        IReadOnlyList<UserRoleVm> GetAllUserRoles();
    }
}
