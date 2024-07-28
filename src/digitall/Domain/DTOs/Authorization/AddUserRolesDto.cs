namespace Domain.DTOs.Authorization;

public class AddUserRolesDto
{
    public long UserId { get; set; }
    public List<HasRoleDto> HasRoles { get; set; } = new();
}