using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Asp.Versioning;
using Application.Extensions;
using Application.Services.Interface.Transaction;
using Domain.DTOs.Transaction;
using Domain.Enums;
using Domain.Enums.Transaction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Api.Controllers.Transaction;

/// <summary>
/// for transaction services 
/// </summary>
/// <param name="transactionService"></param>
[ApiVersion(1)]
public class TransactionController(ITransactionService transactionService) : BaseController
{
    /// <summary>
    /// add transaction for user
    /// فقط کاربری که لاگین هست مجاز به ثبت است
    /// </summary>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> AddTransaction([FromForm] AddTransactionDto transaction)
    {
        AddTransactionResult response = await transactionService.AddTransactionAsync(transaction, User.GetId());

        return response switch
        {
            AddTransactionResult.Success =>
                new ApiResult(true, ApiResultStatusCode.Success,
                    "عملیات با موفقیت انجام شد منتظر برسی کارشناسان ما باشید"),
            AddTransactionResult.Error =>
                new ApiResult(false, ApiResultStatusCode.LogicError,
                    "عملیات با خطا مواجع شد با پشتیبانی تماس بگیرید"),
            _ => new NotFoundResult()
        };
    }


    /// <summary>
    /// after admin show transaction acept transaction
    /// تغییر وضعیت تراکنش
    /// </summary>
    /// <param name="transaction">TransactionStatus 1 = accepted, 2 not accepted, 3 waiting</param>
    [HttpPut]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult> UpdateTransactionStatus([FromForm] UpdateTransactionStatusDto transaction)
    {
        UpdateTransactionStatusResult response =
            await transactionService.UpdateTransactionStatusAsync(transaction, User.GetId());

        return response switch
        {
            UpdateTransactionStatusResult.Success =>
                new ApiResult(true, ApiResultStatusCode.Success,
                    "عملیات با موفقیت انجام شد"),
            UpdateTransactionStatusResult.Error =>
                new ApiResult(false, ApiResultStatusCode.LogicError,
                    "عملیات با خطا مواجع شد با پشتیبانی تماس بگیرید"),
            _ => new NotFoundResult()
        };
    }

    /// <summary>
    /// get transaction list by filter
    /// </summary>
    /// <returns>FilterTransaction</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult<FilterTransactionDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
    public async Task<ApiResult<FilterTransactionDto>> FilterTransaction([FromQuery] FilterTransactionDto transaction)
    {
        FilterTransactionDto response = await transactionService.FilterTransactionAsync(transaction);

        return Ok(response);
    }

    /// <summary>
    /// add transaction detail
    /// </summary>
    /// <returns>FilterTransaction</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
    public async Task<ApiResult> AddTransactionDetial(
        [FromBody] AddTransactionDetialDto transaction)
    {
        await transactionService.AddTransactionDetailAsync(transaction, User.GetId());
        return Ok();
    }

    /// <summary>
    /// get transaciton detail list
    /// </summary>
    /// <returns>FilterTransaction</returns>
    [HttpGet]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult<TransactionDetailDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult<List<TransactionDetailDto>>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ApiResult<List<TransactionDetailDto>>> GetTransactionDetail()
    {
        return Ok(await transactionService.GetTransactionDetailsAsync(1));
    }
}