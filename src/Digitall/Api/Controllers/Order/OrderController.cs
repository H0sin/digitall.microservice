using System.Net;
using Api.Controllers.Base;
using Api.Filters;
using Application.Extensions;
using Application.Services.Interface.Order;
using Domain.DTOs.Order;
using Domain.Enums;
using Domain.Enums.Order;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Order
{
    public class OrderController(IOrderService orderService) : BaseController
    {
        #region add

        /// <summary>
        /// add product to order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResult), (int)HttpStatusCode.NotFound)]
        public async Task<ApiResult> AddOrder([FromBody] List<AddProductToOrderDto> order)
        {
            AddProductToOrderResult response = await orderService.AddProductToOrderAsync(order, User.GetUserId());

            return response switch
            {
                AddProductToOrderResult.Success => new ApiResult(true, ApiResultStatusCode.Success,
                    "محصولات با موفقیت به سبد خرید اضافه شد"),
                _ => new ApiResult(false, ApiResultStatusCode.LogicError,
                    "خطایی در اضافه کردن محصول به سبد خرید رخ داد")
            };
        }

        #endregion

        #region filter

        /// <summary>
        /// filter all Item
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult<FilterOrderDto>), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult<FilterOrderDto>> FilterOrder([FromQuery] FilterOrderDto filter)
        {
            FilterOrderDto response = await orderService.FilterOrderAsync(filter);
            return new ApiResult<FilterOrderDto>(true, ApiResultStatusCode.Success, response);
        }

        /// <summary>
        /// filter user orders
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult<FilterOrderDto>), (int)HttpStatusCode.OK)]
        [ProducesDefaultResponseType]
        public async Task<ApiResult<FilterOrderDto>> FilterUserOrder([FromQuery] FilterOrderDto filter)
        {
            filter.UserId = User.GetUserId();
            FilterOrderDto response = await orderService.FilterOrderAsync(filter);
            return new ApiResult<FilterOrderDto>(true, ApiResultStatusCode.Success, response);
        }


        #endregion
    }
}