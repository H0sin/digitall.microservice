namespace Domain.DTOs.Authorization;

/// <summary>
/// DTO for updating roles assigned to a user.
/// </summary>
public class UserRoleUpdateDto
{
    /// <summary>
    /// ID of the user whose roles are being updated.
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// List of roles with their assigned status.
    /// </summary>
    public List<RoleAssignmentDto> Roles { get; set; } = new();
}
