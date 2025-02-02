using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Product;
using Domain.DTOs.Product;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Domain.DTOs.Vpn;
using Api.Filters;
using Api.Controllers.Base;
using Api.Utitlities;

namespace Api.Controllers.Product;

/// <summary>
/// 
/// </summary>
/// <param name="productService"></param>
[ApiVersion(1)]
public class ProductController(IProductService productService) : BaseController
{
    #region get

    [PermissionChecker("GetProductByFilter")]
    [HttpGet]
    public async Task<ApiResult<FilterProductDto>> GetProductByFilterAsync([FromQuery] FilterProductDto filter)
    {
        FilterProductDto response = await productService.FilterProductAsync(filter, User.GetId());
        return Ok(response);
    }

    #endregion

    #region add

    [PermissionChecker("AddProduct")]
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    public async Task<ApiResult> AddProduct([FromBody] AddProductDto product)
    {
        var result = await productService.AddProductAsync(product, User.GetId());
        return Ok();
    }

    [PermissionChecker("AddVpnProduct")]
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    public async Task<ApiResult> AddVpnProduct([FromForm] AddVpnProductDto product)
    {
        var result = await productService.AddVpnProductAsync(product, User.GetId());
        return Ok();
    }
    #endregion
}

