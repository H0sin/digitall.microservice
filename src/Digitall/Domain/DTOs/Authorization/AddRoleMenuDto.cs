using Domain.DTOs.Menu;

namespace Domain.DTOs.Authorization;

public class AddRoleMenuDto
{
    public long RoleId { get; set; }
    public List<HasMenuDto> HasMenues { get; set; } = new();
}