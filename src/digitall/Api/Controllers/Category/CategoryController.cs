using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Category;
using Domain.DTOs.Category;
using Domain.Enums;
using Domain.Enums.Category;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Category;

[ApiVersion(1)]
public class CategoryController : BaseController
{
    #region constructor

    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    #endregion

    #region add

    /// <summary>
    /// add category if category exists return bad request
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(ApiResult<AddCategoryDto>), (int)HttpStatusCode.BadRequest)]
    [ProducesDefaultResponseType]
    [HttpPost]
    public async Task<ApiResult> AddCategory([FromBody] AddCategoryDto category)
    {
        AddCategoryResult response = await _categoryService.AddCategoryAsync(category, User.GetId());

        switch (response)
        {
            case AddCategoryResult.Exists:
                return new ApiResult<AddCategoryDto>(false, ApiResultStatusCode.Duplicate, category,
                    "این دسته بندی تکراری است");
            case AddCategoryResult.Success:
                return Ok();
        }

        return BadRequest();
    }

    #endregion

    #region get

    /// <summary>
    /// get categories
    /// </summary>
    /// <param name="category"></param>
    /// <returns>List Category</returns>
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult<List<CategoryDto>>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.BadRequest)]
    [ProducesDefaultResponseType]
    [HttpPost]
    public async Task<ApiResult<List<CategoryDto>>> GetCategories()
    {
        List<CategoryDto> response = await _categoryService.GetCategoriesAsync();

        return Ok(response);
    }


    /// <summary>
    /// get category by id
    /// </summary>
    /// <param name="category"></param>
    /// <returns>Category</returns>
    [ProducesResponseType(typeof(ApiResult<CategoryDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.BadRequest)]
    [ProducesDefaultResponseType]
    [HttpPost]
    public async Task<ApiResult<CategoryDto>> GetCategory([FromQuery] long? categoryId)
    {
        CategoryDto? response = await _categoryService.GetCategoryByIdAsync(categoryId!.Value);

        return Ok(response);
    }

    #endregion
}