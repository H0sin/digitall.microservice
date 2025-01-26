namespace Domain.DTOs.Authorization;

public class UserRolePermissionsDto
{
    public long RoleId { get; set; }
    public string RoleName { get; set; }
    public List<Permission> Permissions { get; set; }
}

public record Permission(long PermissionId, string PermissionName);

