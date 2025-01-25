namespace Domain.DTOs.Authorization;

/// <summary>
/// Represents a permission and its assignment status.
/// </summary>
public class PermissionAssignmentDto
{
    /// <summary>
    /// ID of the permission.
    /// </summary>
    public long PermissionId { get; set; }

    /// <summary>
    /// Indicates whether the permission is assigned to the role.
    /// </summary>
    public bool IsAssigned { get; set; }
}
