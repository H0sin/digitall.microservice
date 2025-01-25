using Domain.DTOs.Authorization;
using Domain.DTOs.Menu;
using Domain.Entities.Account;
using Domain.Entities.Authorization;
using Domain.Enums.Authorization;

namespace Application.Services.Interface.Authorization;

public interface IAuthorizeService
{
    /// <summary>
    /// Updates roles assigned to a user. 
    /// Adds or removes roles based on the provided `IsAssigned` flag.
    /// </summary>
    /// <param name="userRoleUpdateDto">DTO containing user ID and roles with their assigned status.</param>
    /// <param name="userId"></param>
    /// <returns>Result of the operation (success, user not found, etc.).</returns>
    Task UpdateUserRolesAsync(UserRoleUpdateDto userRoleUpdateDto,long userId);

    /// <summary>
    /// Retrieves all roles, marking those assigned to the specified user.
    /// </summary>
    /// <param name="userId">ID of the user for whom roles are being fetched.</param>
    /// <returns>List of roles with their assigned status.</returns>
    Task<List<RoleDto>> GetAllRolesForUserAsync(long userId);

    /// <summary>
    /// Updates permissions assigned to a role.
    /// Adds or removes permissions based on the provided `IsAssigned` flag.
    /// </summary>
    /// <param name="rolePermissionUpdateDto">DTO containing role ID and permissions with their assigned status.</param>
    /// <param name="userId"></param>
    /// <returns>Result of the operation (success, role not found, etc.).</returns>
    Task UpdateRolePermissionsAsync(RolePermissionUpdateDto rolePermissionUpdateDto,long userId);

    /// <summary>
    /// Retrieves all permissions, marking those assigned to the specified role.
    /// </summary>
    /// <param name="roleId">ID of the role for whom permissions are being fetched.</param>
    /// <returns>List of permissions with their assigned status.</returns>
    Task<List<PermissionDto>> GetAllPermissionsForRoleAsync(long roleId);

    /// <summary>
    /// Retrieves all available permissions in the system.
    /// </summary>
    /// <returns>List of all permissions.</returns>
    Task<List<PermissionDto>> GetAllPermissionsAsync();

    /// <summary>
    /// Retrieves all available roles in the system.
    /// </summary>
    /// <returns>List of all roles.</returns>
    Task<List<RoleDto>> GetAllRolesAsync();

    /// <summary>
    /// Hase Permission Role By User Id
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="permissionName"></param>
    /// <returns></returns>
    Task<bool> HasUserPermission(long userId, string permissionName);
    
    
    /// <summary>
    /// list user have role
    /// </summary>
    /// <param name="roleName"></param>
    /// <returns></returns>
    Task<List<User>> GetUsersByRoleNameAsync(string roleName);   
    
    // Task<UserByRolesDto> GetUserRoles(long userId);
    // Task<AddRoleResult> AddRoleAsync(AddRoleDto role, long userId);
    // Task<AddUserRoleResult> AddRoleForUser(AddUserRolesDto userrole, long userId);
    // Task<List<RoleDto>> GetRolesAsync();
    // Task<AddRoleMenuResult> AddRoleMenuAsync(AddRoleMenuDto rolemenu, long userId);
    // Task<List<RolePermissionDto>> GetRolePermissionsAsync();
    // Task<List<PermissionDto>> GetPermissionAsync(long roleId);
    // Task<RoleByMenusDto?> GetMenuByRoleIdAsync(long roleId);
    // Task<UserByRolesDto?> GetRoleByUserIdAsync(long userId);
    // Task<List<RoleMenusDto>> GetHasMenusByRoleId(long roleId);
    // Task<List<MenuDto>> GetMenusAsync();
    // Task<List<User>> GetUsersByRoleIdAsync();
 
}