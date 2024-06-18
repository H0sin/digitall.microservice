using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Category;

public class CategoryDto
{
    public CategoryDto()
    {
    }

    public CategoryDto(Entities.Category.Category category)
    {
        Title = category.Title;
        Id = category.Id;
    }

    [Display(Name = "عنوان دسته بندی")] public string? Title { get; set; }

    public long Id { get; set; }
}