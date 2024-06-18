using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities.Category;

public class Category : BaseEntity
{
    #region peroperties

    [Display(Name = "عنوان دسته بندی")] public string? Title { get; set; }

    #endregion

    #region reletation

    public ICollection<Product.Product>? Products { get; set; }

    #endregion
}