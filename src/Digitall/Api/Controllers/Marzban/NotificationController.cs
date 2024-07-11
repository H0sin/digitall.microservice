using Api.Filters;
using Asp.Versioning;
using Api.Filters;
using Application.Exceptions;
using Application.Utilities;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;

namespace Api.Controllers.Marzban;

[ApiVersion(1)]
[Route("api/v{v:apiVersion}/[controller]/[action]")]
[ServiceFilter(typeof(ExceptionHandler))]
[ApiResultFilter]
[ApiController]
public class NotificationController : ControllerBase
{
    [HttpPost]
    public ApiResult MarzbanNotification([FromBody] object body)
    {
        Log.Information(JsonConvert.SerializeObject(body));

        if (!Directory.Exists(PathExtension.FileOriginServer))
        {
            Directory.CreateDirectory(PathExtension.FileOriginServer);
        }

        using (StreamWriter writer =
               System.IO.File.CreateText(PathExtension.FileOriginServer + Guid.NewGuid() + ".json"))
        {
            writer.WriteLine(body);
        }

        return Ok();
    }
}