using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Authorization;

public class Permission : BaseEntity
{
    #region entities

    public long? ParentId { get; set; } = null;

    [Display(Name = "نام نمایشی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string Title { get; set; }

    [Display(Name = "نام سیستمی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
    public string SystemName { get; set; }

    #endregion

    #region relations

    // [ForeignKey("ParentId")]
    public Permission? Parent { get; set; } = null;

    public ICollection<RolePermission> RolePermissions { get; set; }

    #endregion
}