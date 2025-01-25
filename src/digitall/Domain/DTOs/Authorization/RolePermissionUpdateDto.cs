namespace Domain.DTOs.Authorization;

/// <summary>
/// DTO for updating permissions assigned to a role.
/// </summary>
public class RolePermissionUpdateDto
{
    /// <summary>
    /// ID of the role whose permissions are being updated.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// List of permissions with their assigned status.
    /// </summary>
    public List<PermissionAssignmentDto> Permissions { get; set; } = new();
}
