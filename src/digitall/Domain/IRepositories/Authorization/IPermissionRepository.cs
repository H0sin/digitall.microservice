using Domain.Entities.Authorization;
using Domain.IRepositories.Base;

namespace Domain.IRepositories.Authorization;

public interface IPermissionRepository : IBaseRepository<Permission>
{
    Task<bool> HasUserPermission(long userId, string permissionName);
}