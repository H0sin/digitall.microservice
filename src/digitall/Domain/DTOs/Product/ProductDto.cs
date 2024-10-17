using System.ComponentModel.DataAnnotations;
using Domain.Enums.Category;

namespace Domain.DTOs.Product;

public class ProductDto
{
    public long Id { get; set; }

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
    
    public CategoryType CategoryType { get; set; }
}