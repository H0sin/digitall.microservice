using Domain.DTOs.Menu;
using Domain.Enums.Menu;

namespace Application.Services.Interface.Menu;

public interface IMenuService
{
    Task<List<MenuDto>> GetMenuByUserId(long userId);
    Task<AddMenuResult> AddMenuAsync(AddMenuDto menu, long userId);
    Task<List<MenuDto>> GetMenus();
}