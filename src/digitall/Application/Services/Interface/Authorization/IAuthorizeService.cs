using Domain.DTOs.Authorization;
using Domain.DTOs.Menu;
using Domain.Entities.Account;
using Domain.Entities.Authorization;
using Domain.Enums.Authorization;

namespace Application.Services.Interface.Authorization;

public interface IAuthorizeService
{
    Task<bool> HasUserPermission(long userId, string permissionName);
    Task<AddRoleResult> AddRoleAsync(AddRoleDto role, long userId);
    Task<AddUserRoleResult> AddRoleForUser(AddUserRolesDto userrole, long userId);
    Task<List<RoleDto>> GetRolesAsync();
    Task<AddRoleMenuResult> AddRoleMenuAsync(AddRoleMenuDto rolemenu, long userId);
    Task<List<RolePermissionDto>> GetRolePermissionsAsync();
    Task<List<PermissionDto>> GetPermissionAsync(long roleId);
    Task<RoleByMenusDto?> GetMenuByRoleIdAsync(long roleId);
    Task<UserByRolesDto?> GetRoleByUserIdAsync(long userId);
    Task<List<RoleMenusDto>> GetHasMenusByRoleId(long roleId);
    Task<List<MenuDto>> GetMenusAsync();
    Task<List<User>> GetUsersByRoleIdAsync();
    Task<List<User>> GetUsersByRoleNameAsync(string roleName);
}