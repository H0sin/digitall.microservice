using Domain.DTOs.Category;
using Domain.Enums.Category;

namespace Application.Services.Interface.Category;

public interface ICategoryService
{
    Task<AddCategoryResult> AddCategoryAsync(AddCategoryDto category, long userId);

    Task<CategoryDto?> GetCategoryByIdAsync(long id);

    Task<List<CategoryDto>> GetCategoriesAsync();
}