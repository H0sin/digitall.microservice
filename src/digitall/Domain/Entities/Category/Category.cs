using System.ComponentModel.DataAnnotations;
using Domain.Common;
using Domain.Enums.Category;

namespace Domain.Entities.Category;

public class Category : BaseEntity
{
    #region peroperties

    [Display(Name = "عنوان دسته بندی")] public string? Title { get; set; }

    public CategoryType CategoryType { get; set; }

    #endregion

    #region reletation

    public ICollection<Product.Product>? Products { get; set; }

    #endregion
}