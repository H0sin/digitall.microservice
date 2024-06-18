using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Authorization;
using Domain.IRepositories.Authorization;

namespace Data.Repositories.Authorization;

public class RolePermissionRepository(DigitallDbContext context) : BaseRepository<RolePermission>(context)
    , IRolePermissionRepository
{
}