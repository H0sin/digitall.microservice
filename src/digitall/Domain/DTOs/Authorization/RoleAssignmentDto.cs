namespace Domain.DTOs.Authorization;

/// <summary>
/// Represents a role and its assignment status.
/// </summary>
public class RoleAssignmentDto
{
    /// <summary>
    /// ID of the role.
    /// </summary>
    public long RoleId { get; set; }

    /// <summary>
    /// Indicates whether the role is assigned to the user.
    /// </summary>
    public bool IsAssigned { get; set; }
}
