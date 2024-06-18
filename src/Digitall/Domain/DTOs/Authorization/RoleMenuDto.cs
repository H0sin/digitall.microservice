using Domain.DTOs.Menu;

namespace Domain.DTOs.Authorization;

public class RoleMenuDto
{
    public string? Tilte { get; set; }
    public long RoleId { get; set; }
    public List<MenuDto> Menus { get; set; }
}