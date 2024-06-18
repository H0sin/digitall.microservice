using Api.Filters;
using Api.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Base
{
    [Route("api/v{v:apiVersion}/[controller]/[action]")]
    [ServiceFilter(typeof(ExceptionHandler))]
    [ApiResultFilter]
    [ApiController]
    [Authorize]
    public class BaseController : ControllerBase
    {
    }
}
