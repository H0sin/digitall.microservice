using Application.Extensions;
using Application.Services.Interface.Authorization;
using Domain.DTOs.Authorization;
using Domain.DTOs.Menu;
using Domain.Enums.Authorization;
using Domain.Enums.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Domain.Entities.Authorization;
using Api.Filters;
using Api.Controllers.Base;
using Api.Utitlities;

namespace Api.Controllers.Authorization
{
    /// <inheritdoc />
    public class AuthorizationController(IAuthorizeService authorizeService) : BaseController
    {
        /// <summary>
        /// get all role permission user
        /// </summary>
        /// <returns></returns>
        [PermissionChecker("GetUserRolePermission")]
        [HttpGet]
        public async Task<ApiResult<List<UserRolePermissionsDto>>> GetUserRolePermissions()
        {
            return Ok(await authorizeService.GetRolePermissionUserAsync(User.GetId()));
        }

        /// <summary>
        /// Assign or remove roles for a user.
        /// </summary>
        /// <param name="dto">The user-role update information.</param>
        /// <returns>Result of the update operation.</returns>
        [PermissionChecker("UpdateUserRole")]
        [HttpPut("user/roles")]
        public async Task<ApiResult> UpdateUserRoles([FromBody] UserRoleUpdateDto dto)
        {
            await authorizeService.UpdateUserRolesAsync(dto, User.GetId());
            return Ok();
        }

        /// <summary>
        /// Assign or remove permissions for a role.
        /// </summary>
        /// <param name="dto">The role-permission update information.</param>
        /// <returns>Result of the update operation.</returns>
        [PermissionChecker("UpdateUserRolePermissions")]
        [HttpPut("role/permissions")]
        public async Task<ApiResult> UpdateRolePermissions([FromBody] RolePermissionUpdateDto dto)
        {
            await authorizeService.UpdateRolePermissionsAsync(dto, User.GetId());
            return Ok();
        }

        /// <summary>
        /// Get all roles with their assigned status for a specific user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>List of roles and their assigned status.</returns>
        [PermissionChecker("GetRolesForUser")]
        [HttpGet("user/{userId}/roles")]
        public async Task<ApiResult<List<RoleDto>>> GetRolesForUser(long userId)
        {
            var roles = await authorizeService.GetAllRolesForUserAsync(userId);
            return Ok(roles);
        }

        /// <summary>
        /// Get all permissions with their assigned status for a specific role.
        /// </summary>
        /// <param name="roleId">The ID of the role.</param>
        /// <returns>List of permissions and their assigned status.</returns>
        [PermissionChecker("GetPermissionsForRole")]
        [HttpGet("role/{roleId}/permissions")]
        public async Task<ApiResult<List<PermissionDto>>> GetPermissionsForRole(long roleId)
        {
            var permissions = await authorizeService.GetAllPermissionsForRoleAsync(roleId);
            return Ok(permissions);
        }

        /// <summary>
        /// Get all available roles.
        /// </summary>
        /// <returns>List of all roles.</returns>
        [PermissionChecker("GetAllRoles")]
        [HttpGet("roles")]
        public async Task<ApiResult<List<RoleDto>>> GetAllRoles()
        {
            var roles = await authorizeService.GetAllRolesAsync();
            return Ok(roles);
        }

        /// <summary>
        /// Get all available permissions.
        /// </summary>
        /// <returns>List of all permissions.</returns>
        [PermissionChecker("GetAllPermissions")]
        [HttpGet("permissions")]
        public async Task<ApiResult<List<PermissionDto>>> GetAllPermissions()
        {
            var permissions = await authorizeService.GetAllPermissionsAsync();
            return Ok(permissions);
        }
    }
}