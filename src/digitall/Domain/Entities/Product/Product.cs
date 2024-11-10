using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.Entities.Apple;

namespace Domain.Entities.Product;

public class Product : BaseEntity
{
    #region peroperties

    [Display(Name = "نام محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? ProductName { get; set; }

    [Display(Name = "قیمت محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public long Price { get; set; }

    [Display(Name = "شناسه دسته بندی")] public long CategoryId { get; set; }

    [Display(Name = "توضیحات")]
    [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
    public string? Description { get; set; }

    public string? ProductImage { get; set; }

    public long VpnId { get; set; }
    
    public ICollection<AppleIdType>? AppleIdTypes { get; set; }

    #endregion

    #region reletion

    [ForeignKey(nameof(CategoryId))] public Category.Category? Category { get; set; }

    #endregion
}