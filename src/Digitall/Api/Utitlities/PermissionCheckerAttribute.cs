using Application.Extensions;
using Application.Services.Interface.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Utitlities
{
    public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly string? _permission;
        private IAuthorizeService _authorizeService;
        public PermissionCheckerAttribute(string? permission)
        {
            _permission = permission;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                if (!context.HttpContext.User.IsUserSupperAdmin())
                {
                    long userId = context.HttpContext.User.GetUserId();
                    _authorizeService = (IAuthorizeService)context.HttpContext.RequestServices.GetService(typeof(IAuthorizeService));
                    if (!_authorizeService.HasUserPermission(userId, _permission).Result)
                    {
                        context.Result = new ForbidResult();
                    }
                }
            }
        }
    }
}
