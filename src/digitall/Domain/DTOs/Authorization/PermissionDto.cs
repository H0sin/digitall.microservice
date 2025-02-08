namespace Domain.DTOs.Authorization;

/// <summary>
/// Represents a permission with its assignment status.
/// </summary>
public class PermissionDto
{
    /// <summary>
    /// ID of the permission.
    /// </summary>
    public long PermissionId { get; set; }

    /// <summary>
    /// Name of the permission.
    /// </summary>
    public string? PermissionName { get; set; }

    /// <summary>
    /// Indicates whether the permission is assigned (used for role-permission mapping).
    /// </summary>
    public bool IsAssigned { get; set; }

    
    /// <summary>
    /// For Persian Name Permissions
    /// </summary>
    public string? Title { get; set; }
}
