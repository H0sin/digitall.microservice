using Domain.Common;

namespace Domain.Entities.Authorization;

public class RolePermission : BaseEntity
{
    #region properties

    public long RoleId { get; set; }

    public long PermissionId { get; set; }

    #endregion

    #region relations

    public Role Role { get; set; }

    public Permission Permission { get; set; }

    #endregion
}