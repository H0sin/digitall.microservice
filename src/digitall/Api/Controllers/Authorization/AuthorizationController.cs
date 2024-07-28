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

namespace Api.Controllers.Authorization
{
    /// <inheritdoc />
    public class AuthorizationController(IAuthorizeService authorizeService) : BaseController
    {
        #region add

        /// <summary>
        /// add role if exists role return status code 8
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult> AddRole([FromBody] AddRoleDto role)
        {
            AddRoleResult response = await authorizeService.AddRoleAsync(role, User.GetId());

            return response switch
            {
                AddRoleResult.Success => Ok(),
                AddRoleResult.Exists => BadRequest("آیتم تکراری است")
            };
        }

        /// <summary>
        /// add role for user
        /// </summary>
        /// <param name="userrole">list role id and user id</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult> AddUserRole([FromBody] AddUserRolesDto userrole)
        {
            AddUserRoleResult response = await authorizeService.AddRoleForUser(userrole, User.GetId());

            return response switch
            {
                AddUserRoleResult.Success => Ok(),
                AddUserRoleResult.NotUserExists => BadRequest("کاربر وجود ندارد")
            };
        }

        /// <summary>
        /// add menu for role
        /// </summary>
        /// <param name="roleMenu"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult> AddMenusForRole([FromBody] AddRoleMenuDto roleMenu)
        {
            AddRoleMenuResult response = await authorizeService.AddRoleMenuAsync(roleMenu, User.GetId());

            return response switch
            {
                AddRoleMenuResult.Success => Ok(),
                AddRoleMenuResult.NotExists => BadRequest("آیتم وجود ندارد")
            };
        }

        #endregion

        #region get

        /// <summary>
        /// get menu by role id
        /// </summary>
        /// <param name="userrole">role id</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResult<RoleByMenusDto>), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult<RoleByMenusDto>> GetMenuByRoleId([FromQuery] long roleId)
        {
            RoleByMenusDto? response = await authorizeService.GetMenuByRoleIdAsync(roleId);
            return Ok(response);
        }

        /// <summary>
        /// get role by user id
        /// </summary>
        /// <param name="userrole">user id</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResult<UserByRolesDto>), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult<UserByRolesDto>> GetRoleByUserId([FromQuery] long userId)
        {
            UserByRolesDto? response = await authorizeService.GetRoleByUserIdAsync(userId);
            return Ok(response);
        }

        /// <summary>
        /// get all roles
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResult<List<RoleDto>>), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult<List<RoleDto>>> GetRoles()
        {
            List<RoleDto>? response = await authorizeService.GetRolesAsync();
            return Ok(response);
        }

        /// <summary>
        /// get all menu for role has or no has
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResult<List<RoleMenusDto>>), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult<List<RoleMenusDto>>> GetRoleMenus([FromQuery] long roleId)
        {
            List<RoleMenusDto>? response = await authorizeService.GetHasMenusByRoleId(roleId);
            return Ok(response);
        }

        #endregion
    }
}