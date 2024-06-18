using Domain.Common;
using Domain.Entities.Account;

namespace Domain.Entities.Authorization;

public class UserRole : BaseEntity
{
    #region properties

    public long UserId { get; set; }

    public long RoleId { get; set; }

    #endregion

    #region relation

    public User User { get; set; }

    public Role Role { get; set; }

    #endregion
}