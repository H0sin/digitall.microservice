namespace Domain.Enums.Agent;

[Flags]
public enum AgentRequestStatus : byte
{
    Accept,
    Wating,
    Reject
}