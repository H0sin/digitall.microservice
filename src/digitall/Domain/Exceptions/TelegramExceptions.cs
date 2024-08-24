using Domain.Enums;

namespace Domain.Exceptions;

public class TelegramExceptions : AppException
{
    public string? token { get; set; }
    public long chatId { get; set; }
    
    public TelegramExceptions()
        : base(ApiResultStatusCode.TelegramException)
    {
    }
    
    public TelegramExceptions(string message,string token,long chatId)
        : base(message)
    {
        token = token;
        chatId = chatId;
    }

}