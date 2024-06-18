using Domain.DTOs.Menu;
using Domain.IRepositories.Base;

namespace Domain.IRepositories.Menu;

public interface IMenuRepository : IBaseRepository<Entities.Menu.Menu>
{
    Task<List<MenuDto>> GetMenusByUserId(long userId);
}