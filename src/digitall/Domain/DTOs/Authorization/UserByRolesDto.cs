using Domain.DTOs.Account;

namespace Domain.DTOs.Authorization;

public class UserByRolesDto
{
    public UserDto User { get; set; }
    public List<RoleDto> Roles { get; set; }
}