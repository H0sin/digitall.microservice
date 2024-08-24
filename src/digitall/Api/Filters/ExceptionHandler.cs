using System.Net;
using Api.Filters;
using Application.Extensions;
using Domain.DTOs.Marzban;
using Domain.Enums;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Serilog;
using Telegram.Bot;

namespace Api.Filters;

public class ExceptionHandler : IAsyncExceptionFilter
{
    public async Task OnExceptionAsync(ExceptionContext context)
    {
        try
        {
            string? controller = context.RouteData.Values["controller"]?.ToString();
            string? action = context.RouteData.Values["action"]?.ToString();
            string? version = context.RouteData.Values["v"]?.ToString();

            long? userId = context.HttpContext.User.GetId();

            object information = new
            {
                controller,
                action,
                userId,
                version,
                message = context.Exception.Message,
                detail = context.Exception.InnerException,
                obj = context.Exception
            };

            Log.Error("Created {@Obj} on {@Created}", information, DateTime.Now);

            switch (context.Exception)
            {
                case TelegramExceptions exception:
                    break;
                case ImplementedException exception:
                    if (exception.ApiStatusCode == ApiResultStatusCode.NotImplemented)
                        context.Result = new JsonResult(new ApiResult(false, ApiResultStatusCode.NotImplemented,
                            "آیتم در حال توسعه است"));
                    break;
                case NotFoundException exception:
                    if (exception.ApiStatusCode == ApiResultStatusCode.NotFound)
                        context.Result =
                            new JsonResult(new ApiResult(false, ApiResultStatusCode.NotFound, exception.Message));
                    break;
                case BadRequestException exception:
                    if (exception.ApiStatusCode == ApiResultStatusCode.BadRequest)
                        context.Result =
                            new JsonResult(new ApiResult(false, ApiResultStatusCode.BadRequest, exception.Message));
                    break;
                case ExistsException exception:
                    if (exception.ApiStatusCode == ApiResultStatusCode.Duplicate)
                        context.Result =
                            new JsonResult(new ApiResult(false, ApiResultStatusCode.Duplicate, exception.Message));
                    break;
                case LogicException exception:
                    context.Result =
                        new JsonResult(new ApiResult(false, ApiResultStatusCode.ServerError,
                            exception.Message));
                    break;
                case MarzbanException exception:
                    if (exception.HttpStatusCode == HttpStatusCode.UnprocessableEntity)
                        context.Result =
                            new JsonResult(new ApiResult<object>(false,
                                ApiResultStatusCode.MarzbanError, exception.AdditionalData,
                                exception.Message));

                    if (exception.HttpStatusCode == HttpStatusCode.NotFound)
                        // ApiResult<object>(false,
                        //     ApiResultStatusCode.MarzbanError, exception.AdditionalData,
                        //     "ادرس مرزبان در دست رس نیست")
                        context.Result =
                            new JsonResult(new NotFoundResult());

                    if (exception.HttpStatusCode == HttpStatusCode.InternalServerError)
                        context.Result =
                            new JsonResult(new ApiResult<object>(false,
                                ApiResultStatusCode.MarzbanError, exception.AdditionalData,
                                "خطایی از سمت مرزبان رخ داده است :" + exception.Message));
                    break;
                case AppException exception:
                    if (exception.ApiStatusCode == ApiResultStatusCode.UnAuthorized)
                        context.Result = new JsonResult(new ApiResult(false, ApiResultStatusCode.ServerError,
                            "دوباره وارد شوید"));
                    break;
                default:
                    context.Result =
                        new JsonResult(new ApiResult(true, ApiResultStatusCode.ServerError,
                            "خظایی از سمت سرور رخ داده است"));
                    break;
            }
        }
        catch (AppException e)
        {
            if (e.ApiStatusCode == ApiResultStatusCode.UnAuthorized)
                context.Result =
                    new JsonResult(new ApiResult(true, ApiResultStatusCode.ServerError, "دوباره وارد شوید"));
        }
        catch (Exception e)
        {
            context.Result =
                new JsonResult(new ApiResult(true, ApiResultStatusCode.ServerError, "خظایی از سمت سرور رخ داده است"));
        }
        finally
        {
            await Task.CompletedTask;
        }
    }
}