using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Product;
using Domain.DTOs.Product;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Domain.DTOs.Vpn;
using Api.Filters;
using Api.Controllers.Base;

namespace Api.Controllers.Product;

[ApiVersion(1)]
public class ProductController : BaseController
{
    #region constructor

    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    #endregion

    #region get

    [HttpGet]
    public async Task<ApiResult<FilterProductDto>> GetProductByFilterAsync([FromQuery] FilterProductDto filter)
    {
        FilterProductDto response = await _productService.FilterProductAsync(filter, User.GetUserId());
        return Ok(response);
    }

    #endregion

    #region add

    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    public async Task<ApiResult> AddProduct([FromBody] AddProductDto product)
    {
        var result = await _productService.AddProductAsync(product, User.GetUserId());
        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    public async Task<ApiResult> AddVpnProduct([FromForm] AddVpnProductDto product)
    {
        var result = await _productService.AddVpnProductAsync(product, User.GetUserId());

        return Ok();
    }
    #endregion
}

