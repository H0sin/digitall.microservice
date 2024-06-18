using Domain.DTOs.Menu;

namespace Domain.DTOs.Authorization;

public class RoleByMenusDto
{
    public RoleDto Role { get; set; }
    public List<MenuDto> Menus { get; set; }
}