using Application.Services.Interface.Agent;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.Entities.Account;

namespace Application.Helper;

public class Percent(IAgentService agentService) : IDisposable
{
    public async Task<long> Calculate(List<long> agentIds, long price)
    {
        long _price = price;

        foreach (long id in agentIds)
        {
            AgentDto? agent = await agentService.GetAgentByIdAsync(id);
            _price += _price * agent!.UserPercent / 100;
        }

        return _price;
    }

    public async Task<List<CalculatorUserIncome>> CalculateBalanse(List<long> agentIds, long price)
    {
        List<CalculatorUserIncome> users = new();

        long _price = price;

        foreach (long id in agentIds)
        {
            AgentDto? agent = await agentService.GetAgentByIdAsync(id);
            users.Add(new(agent.AgentAdminId, _price * agent!.UserPercent / 100));
            _price += _price * agent!.UserPercent / 100;
        }
        return users;
    }

    public void Dispose()
    {
        agentService = null;
    }
}