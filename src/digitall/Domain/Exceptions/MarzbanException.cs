using System.Net;
using Domain.Enums;

namespace Domain.Exceptions;

public class MarzbanException : AppException
{
    public MarzbanException(ApiResultStatusCode statusCode) : base(ApiResultStatusCode.MarzbanError)
    {
    }
    
    public MarzbanException(string message) : base(message)
    {
    }

    public MarzbanException(ApiResultStatusCode statusCode, string massage) : base(statusCode,
        massage)
    {
    }

    public MarzbanException(ApiResultStatusCode statusCode, string message, object additionalData) : base(
        ApiResultStatusCode.MarzbanError, message,
        additionalData)
    {
    }
}