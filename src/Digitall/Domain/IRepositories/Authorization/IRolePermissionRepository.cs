using Domain.Entities.Authorization;
using Domain.IRepositories.Base;

namespace Domain.IRepositories.Authorization;

public interface IRolePermissionRepository : IBaseRepository<RolePermission>
{
}