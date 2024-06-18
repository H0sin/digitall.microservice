using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Authorization;

public class Role : BaseEntity
{
    #region properties

    [Display(Name = "نام نمایشی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string Title { get; set; }

    #endregion

    #region relations

    public ICollection<RolePermission> RolePermissions { get; set; }
    public ICollection<RoleMenus> RoleMenus { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }

    #endregion
}