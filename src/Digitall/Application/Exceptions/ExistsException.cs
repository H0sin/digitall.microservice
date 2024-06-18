using Domain.Enums;

namespace Application.Exceptions;

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