using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Category;

public class AddCategoryDto
{
    [Display(Name = "عنوان دسته بندی")] public string? Title { get; set; }
}