using System.Net;
using Domain.Enums;

namespace Domain.Exceptions;

public class MarzbanException : AppException
{
    public MarzbanException(HttpStatusCode statusCode) : base(ApiResultStatusCode.MarzbanError)
    {
    }

    public MarzbanException(HttpStatusCode response, string massage) : base(ApiResultStatusCode.MarzbanError,
        massage)
    {
    }

    public MarzbanException(HttpStatusCode response, string message, object additionalData) : base(
        ApiResultStatusCode.MarzbanError, message,
        additionalData)
    {
    }
}