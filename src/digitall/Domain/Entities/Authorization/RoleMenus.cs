using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities.Authorization;

public class RoleMenus : BaseEntity
{
    #region properties

    public long MenuId { get; set; }

    public long RoleId { get; set; }

    #endregion

    #region relations

    [ForeignKey(nameof(MenuId))] public Menu.Menu Menu { get; set; }

    public Role Role { get; set; }

    #endregion
}