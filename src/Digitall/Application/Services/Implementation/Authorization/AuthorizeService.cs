using System.Net;
using Domain.IRepositories.Authorization;
using Domain.DTOs.Authorization;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.Authorization;
using Domain.Enums.Authorization;
using Domain.IRepositories.Account;
using Domain.IRepositories.Menu;
using System.Data;
using Domain.DTOs.Menu;
using Domain.Entities.Menu;
using Microsoft.EntityFrameworkCore.Query;
using Domain.Entities.Account;
using SixLabors.ImageSharp.ColorSpaces;
using Application.Services.Interface.Authorization;

namespace Application.Services.Implementation.Authorization;

public class AuthorizeService(
    IPermissionRepository permissionRepository,
    IRoleRepository roleRepository,
    IUserRoleRepository userRoleRepository,
    IUserRepository userRepository,
    IMenuRepository menuRepository,
    IRoleMenuRepository roleMenuRepository,
    IRolePermissionRepository rolePermissionRepository)
    : IAuthorizeService
{
    #region add

    public async Task<AddRoleResult> AddRoleAsync(AddRoleDto role, long userId)
    {
        if (await roleRepository.GetQuery().AnyAsync(x => x.Title == role.Title.Trim()))
            return AddRoleResult.Exists;

        Role newRole = new()
        {
            Title = role.Title
        };

        await roleRepository.AddEntity(newRole);
        await roleRepository.SaveChanges(userId);

        return AddRoleResult.Success;
    }

    public async Task<AddUserRoleResult> AddRoleForUser(AddUserRolesDto userrole, long userId)
    {
        if (!await userRepository.GetQuery().AnyAsync(x => x.Id == userrole.UserId && x.IsDelete == false))
            return AddUserRoleResult.NotUserExists;

        IReadOnlyList<UserRole> userRole = await userRoleRepository
            .GetAsync(x => x.UserId == userrole.UserId);

        foreach (var role in userrole.HasRoles)
        {
            UserRole? ur = userRole.SingleOrDefault(x => x.RoleId == role.RoleId);
            if (ur != null)
            {
                ur.IsDelete = !role.Has;
                await userRoleRepository.UpdateEntity(ur);
            }
        }

        await userRoleRepository.SaveChanges(userId);
        return AddUserRoleResult.Success;
    }

    public async Task<AddRoleMenuResult> AddRoleMenuAsync(AddRoleMenuDto rolemenu, long userId)
    {
        if (!await roleRepository.GetQuery().AnyAsync(x => x.Id == rolemenu.RoleId && x.IsDelete == false))
            return AddRoleMenuResult.NotExists;

        IReadOnlyList<RoleMenus> roleMenu = await roleMenuRepository
            .GetAsync(x => x.RoleId == rolemenu.RoleId);

        foreach (var menu in rolemenu.HasMenues)
        {
            RoleMenus? rm = roleMenu.SingleOrDefault(x => x.MenuId == menu.MenuId);
            if (rm != null)
            {
                rm.IsDelete = !menu.Has;
                await roleMenuRepository.UpdateEntity(rm);
            }
            else
            {
                var newRoleMenu = new RoleMenus
                {
                    RoleId = rolemenu.RoleId,
                    MenuId = menu.MenuId,
                    IsDelete = !menu.Has
                };
                await roleMenuRepository.AddEntity(newRoleMenu);
            }
        }

        await roleMenuRepository.SaveChanges(userId);
        return AddRoleMenuResult.Success;
    }

    #endregion

    #region get

    public Task<List<RolePermissionDto>> GetRolePermissionsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<List<PermissionDto>> GetPermissionAsync(long roleId)
    {
        return await rolePermissionRepository.GetQuery().Where(x => x.RoleId == roleId)
            .Include(x => x.Permission)
            .Select(x => new PermissionDto
            {
                Id = x.Permission.Id,
                Title = x.Permission.Title
            }).ToListAsync();
    }

    public async Task<List<RoleDto>> GetRolesAsync()
    {
        return await roleRepository.GetQuery()
            .Where(x => x.IsDelete == false).Select(x => new RoleDto
            {
                Id = x.Id,
                Title = x.Title
            }).ToListAsync();
    }

    public async Task<RoleByMenusDto?> GetMenuByRoleIdAsync(long roleId)
    {
        Role? role = await roleRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == roleId);
        if (role is not null)
        {
            IIncludableQueryable<RoleMenus, Domain.Entities.Menu.Menu> roleMenu = roleMenuRepository
                .GetQuery()
                .Where(y => y.RoleId == roleId)
                .Include(x => x.Menu)!;

            return new RoleByMenusDto
            {
                Role = new()
                {
                    Id = role.Id,
                    Title = role!.Title
                },
                Menus = await roleMenu.Select(x => new Domain.DTOs.Menu.MenuDto
                {
                    Title = x.Menu!.Title,
                    Sorted = x.Menu.Sorted,
                    Controller = x.Menu.Controller,
                    Icon = x.Menu.Icon,
                    Action = x.Menu.Action,
                    Link = x.Menu.Link,
                    Active = x.Menu.Active
                }).ToListAsync()
            };
        }

        return null;
    }

    public async Task<UserByRolesDto?> GetRoleByUserIdAsync(long userId)
    {
        User? user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == userId);
        if (user is not null)
        {
            IIncludableQueryable<UserRole, Role> userRole = userRoleRepository
                .GetQuery()
                .Where(x => x.UserId == userId)
                .Include(x => x.Role)!;

            return new()
            {
                User = new()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Id = user.Id
                },
                Roles = await userRole.Select(x => new RoleDto()
                {
                    Id = x.Role.Id,
                    Title = x.Role.Title
                }).ToListAsync()
            };
        }

        return null;
    }

    public async Task<List<RoleMenusDto>> GetHasMenusByRoleId(long roleId)
    {
        List<MenuDto> menus = await GetMenusAsync();

        List<RoleMenus> roleMenu = await roleMenuRepository
            .GetQuery()
            .Where(x => x.RoleId == roleId)
            .ToListAsync();

        List<RoleMenusDto> roleMenusList = new();

        foreach (MenuDto menu in menus)
        {
            bool has = roleMenu.Any(x => x.MenuId == menu.Id);
            roleMenusList.Add(new(has, menu.Title, menu.Id));
        }

        return roleMenusList;
    }

    public async Task<List<MenuDto>> GetMenusAsync()
    {
        return await menuRepository.GetQuery().Select(x => new MenuDto()
        {
            Title = x.Title,
            Link = x.Link,
            Id = x.Id
        }).ToListAsync();
    }

    #endregion

    #region has permission

    public async Task<bool> HasUserPermission(long userId, string permissionName)
    {
        return await permissionRepository.HasUserPermission(userId, permissionName);
    }

    #endregion
}