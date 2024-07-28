using Data.Context;
using Data.Repositories.Base;
using Domain.DTOs.Menu;
using Domain.Entities.Authorization;
using Domain.IRepositories.Menu;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Menu;

public class MenuRepository(DigitallDbContext dbContext)
    : BaseRepository<Domain.Entities.Menu.Menu>(dbContext), IMenuRepository
{
    #region get menu user by id

    public async Task<List<MenuDto>> GetMenusByUserId(long userId)
    {
        // Step 1: Retrieve the role menus for the user
        var roleMenusList = await (
            from ur in _context.UserRoles
            join r in _context.Roles on ur.RoleId equals r.Id
            join rm in _context.RoleMenus on r.Id equals rm.RoleId
            join m in _context.Menu on rm.MenuId equals m.Id
            where ur.UserId == userId && rm.IsDelete == false
            select m
        ).Distinct().ToListAsync();

        // Step 2: Create a dictionary to map menu items by their parent ID, handling null values
        var menuDictionary = roleMenusList
            .GroupBy(m => m.ParentId)
            .ToDictionary(g => g.Key ?? 0, g => g.ToList());

        // Step 3: Build the menu hierarchy recursively
        List<MenuDto> BuildHierarchy(long? parentId)
        {
            long parentIdKey = parentId ?? 0;
            return menuDictionary.TryGetValue(parentIdKey, out var menus)
                ? menus.Select(m => new MenuDto
                {
                    Id = m.Id,
                    Title = m.Title,
                    Active = m.Active,
                    Icon = m.Icon,
                    Link = m.Link,
                    Action = m.Action,
                    Controller = m.Controller,
                    Area = m.Area,
                    Menus = BuildHierarchy(m.Id)
                }).ToList()
                : new List<MenuDto>();
        }

        // Step 4: Get the root menus (where ParentId is null)
        return BuildHierarchy(null);
    }

    #endregion
}