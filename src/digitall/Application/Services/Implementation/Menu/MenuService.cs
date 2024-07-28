using Application.Services.Interface.Menu;
using Domain.DTOs.Account;
using Domain.DTOs.Menu;
using Domain.Entities.Menu;
using Domain.Enums.Menu;
using Domain.IRepositories.Menu;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Menu;

public class MenuService(IMenuRepository menuRepository) : IMenuService
{

    #region add

    public async Task<AddMenuResult> AddMenuAsync(AddMenuDto menu, long userId)
    {
        if (await menuRepository.GetQuery().AnyAsync(x => x.Title == menu.Title!.Trim()))
            return AddMenuResult.Exists;

        Domain.Entities.Menu.Menu newMenu = new()
        {
            Title = menu.Title,
            Icon = menu.Icon,
            Sorted = menu.Sorted,
            ParentId = menu.ParentId,
            Link = menu.Link,
        };

        await menuRepository.AddEntity(newMenu);
        await menuRepository.SaveChanges(userId);

        return AddMenuResult.Success;
    }

    #endregion

    #region get user menu

    public async Task<List<MenuDto>> GetMenuByUserId(long userId)
    {

        List<MenuDto> menus = await menuRepository.GetMenusByUserId(userId);

        return menus.Select(x => new MenuDto()
        {
            Title = x.Title,
            Sorted = x.Sorted,
            Action = x.Action,
            Area = x.Area,
            Controller = x.Controller,
            Active = x.Active,
            Icon = x.Icon,
            Link = x.Link,
            Menus = x.Menus,
            Id = x.Id
        }).ToList();
    }

    public async Task<List<MenuDto>> GetMenus()
    {
        return await menuRepository
            .GetQuery()
            .Where(x => x.IsDelete == false)
            .Select(x => new MenuDto
            {
                Title = x.Title,
                Sorted = x.Sorted,
                Action = x.Action,
                Area = x.Area,
                Controller = x.Controller,
                Active = x.Active,
                Icon = x.Icon,
                Link = x.Link,
                Id = x.Id
            }).ToListAsync();
    }

    #endregion
}