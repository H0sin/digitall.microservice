using Application.Exceptions;
using Application.Services.Interface.Agent;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Entities.Marzban;
using Microsoft.EntityFrameworkCore;

namespace Application.Helper;

public class Percent(IAgentService agentService) : IDisposable
{
    // public async Task<>

    public async Task<List<MarzbanVpnTemplateDto?>> CalcuteVpnTemplatePrice(List<MarzbanVpnTemplateDto?> marzbanVpn, long userId,
        int numberOfAgents = 2)
    {
        AgentDto? admin = await agentService
            .GetAgentByAdminId(userId);

        AgentDto? agent =
            await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شم غیر فعال شده است");

        double totalMultiplier = 1.0;

        for (int i = 0; i < numberOfAgents; i++)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPath(ancestorPath);

            if (agentByPath != null)
            {
                double percent = (admin != null
                    ? (agent.AgentPercent == 0 ? 1 : agent.AgentPercent)
                    : (agent.UserPercent == 0 ? 1 : agent.UserPercent));
                totalMultiplier *= 1 + (percent / 100.0);
            }
        }

        foreach (var mv in marzbanVpn)
        {
            mv.Price = Convert.ToInt64(mv.Price * totalMultiplier);
        }

        return marzbanVpn;
    }


    public async Task<List<MarzbanVpn?>> CalcuteVpnPrice(List<MarzbanVpn?> marzbanVpn, long userId,
        int numberOfAgents = 2)
    {
        AgentDto? admin = await agentService
            .GetAgentByAdminId(userId);

        AgentDto? agent =
            await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شم غیر فعال شده است");

        double totalMultiplier = 1.0;

        for (int i = 0; i < numberOfAgents; i++)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPath(ancestorPath);

            if (agentByPath != null)
            {
                double percent = (admin != null
                    ? (agent.AgentPercent == 0 ? 1 : agent.AgentPercent)
                    : (agent.UserPercent == 0 ? 1 : agent.UserPercent));
                totalMultiplier *= 1 + (percent / 100.0);
            }
        }

        foreach (var mv in marzbanVpn)
        {
            mv.DayPrice = Convert.ToInt64(mv.DayPrice * totalMultiplier);
            mv.GbPrice = Convert.ToInt64(mv.GbPrice * totalMultiplier);
        }

        return marzbanVpn;
    }

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