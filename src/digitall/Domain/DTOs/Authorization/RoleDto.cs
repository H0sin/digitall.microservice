namespace Domain.DTOs.Authorization;

/// <summary>
/// Represents a role with its assignment status.
/// </summary>
public class RoleDto
{
    /// <summary>
    /// ID of the role.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// Name of the role.
    /// </summary>
    public string RoleName { get; set; }

    /// <summary>
    /// Indicates whether the role is assigned (used for user-role mapping).
    /// </summary>
    public bool IsAssigned { get; set; }
}
