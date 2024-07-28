using Application.Services.Interface.Category;
using Domain.DTOs.Category;
using Domain.Enums.Category;
using Domain.IRepositories.Category;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Category;

public class CategoryService : ICategoryService
{
    #region constructor

    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    #endregion

    #region add

    public async Task<AddCategoryResult> AddCategoryAsync(AddCategoryDto category, long userId)
    {
        if (await _categoryRepository.GetQuery().AnyAsync(x => x.Title == category.Title.Trim()))
            return AddCategoryResult.Exists;

        Domain.Entities.Category.Category newCategory = new()
        {
            Title = category.Title,
            IsDelete = false,
        };

        await _categoryRepository.AddEntity(newCategory);
        await _categoryRepository.SaveChanges(userId);

        return AddCategoryResult.Success;
    }

    #endregion

    #region get

    public async Task<CategoryDto?> GetCategoryByIdAsync(long id)
    {
        Domain.Entities.Category.Category? category = await _categoryRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.Id == id);

        return category switch
        {
            null => null,
            _ => new CategoryDto(category)
        };
    }

    public async Task<List<CategoryDto>> GetCategoriesAsync()
    {
        return await _categoryRepository.GetQuery().Select(x => new CategoryDto(x)
        {
        }).ToListAsync();
    }

    #endregion
}