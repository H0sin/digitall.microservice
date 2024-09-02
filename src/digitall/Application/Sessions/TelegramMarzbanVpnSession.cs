using System.Collections.Concurrent;

namespace Application.Sessions;

public class TelegramMarzbanVpnSession
{
    public int? Gb { get; set; } = null;
    public int? Date { get; set; } = null;
    public TelegramMarzbanVpnSessionState State { get; set; } = TelegramMarzbanVpnSessionState.None;
    public long? VpnId { get; set; }
    public int Price { get; set; }
    public string? CardNumber { get; set; }
    public string? CardHolderName { get; set; }
    public long? UserSubscribeId { get; set; }
    public int AgentPercent { get; set; }
    public int UserPercent { get; set; }
    public string PersionBrandName { get; set; }
    public string EnglishBrandName { get; set; }
    public string Phone { get; set; }
    public string RequestDescription { get; set; }
    public long IncreasePrice { get; set; }
    public long DecreasePrice { get; set; }
    public long UserChatId { get; set; }
    public long MaximumAmountForAgent { get; set; }
    public long MinimalAmountForAgent { get; set; }
    public long MaximumAmountForUser { get; set; }
    public long MinimalAmountForUser { get; set; }
    public long ChildAgentId { get; set; }
    public string? Message { get; set; }
    public string ServiceName { get; set; }
    
    public TelegramMarzbanVpnSession()
    {
        
    }
    
    public TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState state, int? gb = null, int? date = null,
        long? vpnId = null, long? UserSubscribeId = null, string? cardNumber = null, string? cardHolderName = null)
    {
        Gb = gb;
        Date = date;
        State = state;
        VpnId = vpnId;
        UserSubscribeId = UserSubscribeId;
    }
}

public enum TelegramMarzbanVpnSessionState
{
    None,
    AwaitingGb,
    AwaitingDate,
    AwaitingFactor,
    AwaitingSendPrice,
    AwaitingSubscribeCount,
    AwaitingSendTransactionImage,
    AwaitingSendAppendGbForService,
    AwaitingSendAppendDaysForService,
    AwaitingSendDescriptionForAddAgentRequest,
    AwaitingSendCardNumber,
    AwaitingSendCardHolderName,
    AwaitingSendAgentPercent,
    AwaitingSendUserPercent,
    AwaitingSendPersianBrandName,
    AwaitingSendEnglishBrandName,
    AwaitingSendPhone,
    AwaitingSendPriceForIncrease,
    AwaitingSendDescriptionForIncrease,
    AwaitingSendPriceForDecrease,
    AwaitingSendDescriptionForDecrease,
    AwaitingSearchUserByChatId,
    AwaitingSendMaximumAmountForAgent,
    AwaitingSendMinimalAmountForAgent,
    AwaitingSendMaximumAmountForUser,
    AwaitingSendMinimalAmountForUser,
    AwaitingSendSpecialPercent,
    AwaitingSendTicketMessage,
    AwaitingSendMessageForUser,
    AwaitingSendMessageForAllUser,
    AwaitingSendServiceName
}

public static class BotSessions
{
    public static ConcurrentDictionary<long, TelegramMarzbanVpnSession>? users_Sessions =
        new ConcurrentDictionary<long, TelegramMarzbanVpnSession>();
}