namespace Domain.Enums.Agent;

[Flags]
public enum AgentRequestStatus : byte
{
    accept,
    wating,
    reject
}