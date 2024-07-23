using Domain.Enums.Agent;

namespace Domain.DTOs.Agent;

public class UpdateAgentRequestDto
{
    private string _agentRequestStatus;

    public string AgentRequestStatus
    {
        get { return _agentRequestStatus; }
        set
        {
            if (!Enum.GetNames(typeof(AgentRequestStatus)).ToList().Contains(value.ToLower()))
            {
                throw new ArgumentException("مقدار ارسالی اشتباه است");
            }

            _agentRequestStatus = value;
        }
    }

    public long Id { get; set; }
}