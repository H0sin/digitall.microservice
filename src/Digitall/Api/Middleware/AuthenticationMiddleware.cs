using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Api.Filters;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Api.Middleware;

public class AuthenticationMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public Task Invoke(HttpContext context)
    {
        try
        {
            string authHeader = context.Request.Headers["Authorization"];

            if (authHeader != null)
            {
                var jwtEncodedString = authHeader.Substring(7); // Bearer and space 
                var token = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);
                var identity = new ClaimsIdentity(token.Claims, "basic");
                context.User = new ClaimsPrincipal(identity);
            } 
        }
        catch (Exception e)
        {
            // todo : get ip

            Log.Information("ارسال توکن غلط");

            return context.Response.WriteAsJsonAsync(new ApiResult(false, ApiResultStatusCode.ServerError,
                "توکن شما اشتباه است"));
        }

        return _next(context);
    }
}