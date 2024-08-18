using Application.Services.Interface.Agent;
using Application.Services.Interface.Marzban;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Marzban;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Entities.Marzban;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.Helper;

public class Percent(IAgentService agentService,IMarzbanService? marzbanService = null) : IDisposable
{
    // public async Task<>

    public async Task<List<MarzbanVpnTemplateDto?>> CalcuteVpnTemplatePrice(List<MarzbanVpnTemplateDto>? marzbanVpn,
        long userId,
        int numberOfAgents = 2)
    {
        try
        {
            if (marzbanVpn.Count > 0)
            {
                AgentDto? admin = await agentService
                    .GetAgentByAdminIdAsync(userId);

                AgentDto? agent =
                    await agentService.GetAgentByUserIdAsync(userId);

                if (agent == null)
                    throw new NotFoundException("نمایندگی شم غیر فعال شده است");

                double totalMultiplier = 1.0;

                for (int i = 0; i < numberOfAgents; i++)
                {
                    HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
                    Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

                    if (agentByPath != null)
                    {
                        double percent = (admin != null
                            ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
                            : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
                        totalMultiplier *= percent != 1 ? 1 + (percent / 100.0) : 1;
                    }
                }

                foreach (var mv in marzbanVpn)
                {
                    mv.Price = Convert.ToInt64(mv.Price * totalMultiplier);
                }
            }
            return marzbanVpn;
        }
        catch (Exception e)
        {
            throw new AppException(e.Message);
        }
    }


    public async Task<List<MarzbanVpn?>> CalcuteVpnPrice(List<MarzbanVpn?> marzbanVpn, long userId,
        int numberOfAgents = 2)
    {
        if (marzbanVpn.Count > 0)
        {
            AgentDto? admin = await agentService
                .GetAgentByAdminIdAsync(userId);

            AgentDto? agent =
                await agentService.GetAgentByUserIdAsync(userId);

            if (agent == null)
                throw new NotFoundException("نمایندگی شم غیر فعال شده است");

            double totalMultiplier = 1.0;

            for (int i = 0; i < numberOfAgents; i++)
            {
                HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
                Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

                if (agentByPath != null)
                {
                    double percent = (admin != null
                        ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
                        : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
                    totalMultiplier *= percent != 1 ? 1 + (percent / 100.0) : 1;
                }
            }

            foreach (var mv in marzbanVpn)
            {
                mv.DayPrice = Convert.ToInt64(mv.DayPrice * totalMultiplier);
                mv.GbPrice = Convert.ToInt64(mv.GbPrice * totalMultiplier);
            }
        }
        return marzbanVpn;
    }

    public async Task<MarzbanVpn?> CalcuteVpnPrice(MarzbanVpn? marzbanVpn, long userId,
        int numberOfAgents = 2)
    {
        AgentDto? admin = await agentService
            .GetAgentByAdminIdAsync(userId);

        AgentDto? agent =
            await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شم غیر فعال شده است");

        double totalMultiplier = 1.0;

        for (int i = 0; i < numberOfAgents; i++)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            if (agentByPath != null)
            {
                double percent = (admin != null
                    ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
                    : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
                totalMultiplier *= percent != 1 ? 1 + (percent / 100.0) : 1;
            }
        }

        marzbanVpn.DayPrice = Convert.ToInt64(marzbanVpn.DayPrice * totalMultiplier);
        marzbanVpn.GbPrice = Convert.ToInt64(marzbanVpn.GbPrice * totalMultiplier);

        return marzbanVpn;
    }

    public async Task<GetMarzbanVpnDto?> CalcuteVpnPrice(long vpnId,long userId,
        int numberOfAgents = 2)
    {
        AgentDto? admin = await agentService
            .GetAgentByAdminIdAsync(userId);

        AgentDto? agent =
            await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شم غیر فعال شده است");

        double totalMultiplier = 1.0;

        for (int i = 0; i < numberOfAgents; i++)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            if (agentByPath != null)
            {
                double percent = (admin != null
                    ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
                    : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
                totalMultiplier *= percent != 1 ? 1 + (percent / 100.0) : 1;
            }
        }

        GetMarzbanVpnDto? marzbanVpn = await marzbanService!.GetMarzbanVpnByIdAsync(vpnId);
        
        marzbanVpn!.DayPrice = Convert.ToInt64(marzbanVpn.DayPrice * totalMultiplier);
        marzbanVpn!.GbPrice = Convert.ToInt64(marzbanVpn.GbPrice * totalMultiplier);

        return marzbanVpn;
    }
    
    public async Task<List<User>> CalculateAgentIncome(
        long userId,
        long price,
        int count = 1,
        int numberOfAgents = 2)
    {
        AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
        AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شما غیر فعال شده است");

        double totalMultiplier = 1.0;
        List<User> users = new();

        for (int i = 0; i < numberOfAgents; i++)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            if (agentByPath != null)
            {
                double percent = (admin != null
                    ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
                    : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
                double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
                User? user = await agentService.GetAdminAgentUserAsync(agentByPath.AgentAdminId);
                long income = Convert.ToInt64((price - (price / (multiplier))) * count);
                user.Balance += income;
                users.Add(user);
            }
        }

        return users;
    }

    public async Task<long> CalculatorVpnPrice(long price, long userId, int numberOfAgents = 2)
    {
        AgentDto? admin = await agentService
            .GetAgentByAdminIdAsync(userId);

        AgentDto? agent =
            await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شم غیر فعال شده است");

        double totalMultiplier = 1.0;

        for (int i = 0; i < numberOfAgents; i++)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            if (agentByPath != null)
            {
                double percent = (admin != null
                    ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
                    : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
                totalMultiplier *= percent != 1 ? 1 + (percent / 100.0) : 1;
            }
        }

        return Convert.ToInt64(price * totalMultiplier);
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
        // agentService = null;
    }
}