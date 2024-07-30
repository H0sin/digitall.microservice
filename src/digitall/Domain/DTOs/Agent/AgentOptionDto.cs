using Domain.Entities.Agent;

namespace Domain.DTOs.Agent;

public class AgentOptionDto
{
    public string? WelcomeMessage { get; set; }

    public AgentOptionDto(AgentOptions? option)
    {
        WelcomeMessage = option?.WelcomeMessage;
    }
}