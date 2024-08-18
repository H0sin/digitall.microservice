using System.Collections.Concurrent;

namespace Application.Sessions;

public class TelegramMarzbanVpnSession
{
    public int? Gb { get; set; } = null;
    public int? Date { get; set; } = null;
    public TelegramMarzbanVpnSessionState State { get; set; }
    public long? VpnId { get; set; }
    public int Price { get; set; }
    public string? CardNumber { get; set; }
    public string? CardHolderName { get; set; }
    public long? UserSubscribeId { get; set; }
    public TelegramMarzbanVpnSession(TelegramMarzbanVpnSessionState state, int? gb = null, int? date = null,
        long? vpnId = null, long? UserSubscribeId = null,string? cardNumber = null,string? cardHolderName=null)
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
    AwatingFactor,
    AwatingSendPrice,
    AwaitingSubscibeCount,
    AwaitingSendTransactionImage,
    AwaitingSendAppendGbForService,
    AwaitingSendAppendDaysForService,
    AwaitingSendDescriptionForAddAgentRequest,
    AwaitingSendCardNumber,
    AwaitingSendCardHolderName,
}

public static class BotSessions
{
    public static ConcurrentDictionary<long, TelegramMarzbanVpnSession>? users_Sessions =
        new ConcurrentDictionary<long, TelegramMarzbanVpnSession>();
}