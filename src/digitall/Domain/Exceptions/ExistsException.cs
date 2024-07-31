using Domain.Enums;

namespace Domain.Exceptions;

public class ExistsException : AppException
{
    public ExistsException()
    {

    }

    public ExistsException(string message)
        : base(ApiResultStatusCode.Duplicate, message)
    {
    }

}