namespace Application.Sessions;

public class CustomMarzbanVpnSession
{
    public int Gb { get; set; }
    public int Date { get; set; }
    public CustomMarzbanVpnSessionState State { get; set; } = CustomMarzbanVpnSessionState.None;
}

public enum CustomMarzbanVpnSessionState
{
    None,
    AwaitingFirstNumber,
    AwaitingSecondNumber,
    AwaitingSubscibeCount
}