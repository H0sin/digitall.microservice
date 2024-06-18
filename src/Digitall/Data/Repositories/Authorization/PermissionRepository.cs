using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Authorization;
using Domain.IRepositories.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Authorization;

public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
{
    public PermissionRepository(DigitallDbContext context) : base(context)
    {
    }

    #region has permission

    public async Task<bool> HasUserPermission(long userId, string permissionName)
    {
        return await _context.UserRoles.Include(s => s.Role)
            .ThenInclude(s => s.RolePermissions)
            .ThenInclude(s => s.Permission)
            .Where(z => !z.IsDelete)
            .AnyAsync(userRole =>
                userRole.UserId == userId
                && userRole.Role.RolePermissions.Any(rolePermission => rolePermission.Permission.SystemName == permissionName));
    }

    #endregion
}