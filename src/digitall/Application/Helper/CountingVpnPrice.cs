using Application.Services.Interface.Agent;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.Helper;

public class CountingVpnPrice
{
    public async Task<long> CalculateFinalPrice(IAgentService agentService, long userId, long initialPrice,
        int numberOfAgents = 1)
    {
        AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
        AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شما غیر فعال شده است");

        double totalMultiplier = 1.0;
        long finalPrice = initialPrice;

        for (int i = numberOfAgents; i >= 0; i--)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            HierarchyId? childAncestorPath = null;

            if (i != 0)
                childAncestorPath = agent.AgentPath.GetAncestor(i - 1);

            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            Domain.Entities.Agent.Agent?
                childByPath = await agentService.GetAgentByPathAsync(childAncestorPath ?? null);

            if (agentByPath != null)
            {
                double percent;
                if (admin != null)
                {
                    percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
                    if (childByPath != null && childByPath.SpecialPercent.HasValue && childByPath.SpecialPercent != 0)
                    {
                        percent = childByPath?.SpecialPercent == 0 ? 1 : childByPath?.SpecialPercent ?? 1;
                    }

                    if (admin?.SpecialPercent != 0 && admin?.SpecialPercent != null && i == 0)
                        percent = admin?.SpecialPercent == 0 ? 1 : admin?.SpecialPercent ?? 1;
                }
                else
                {
                    percent = (i == 0
                        ? (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent)
                        : (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent));
                }

                double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
                totalMultiplier *= multiplier;
            }
        }

        finalPrice = Convert.ToInt64(initialPrice * totalMultiplier);
        return finalPrice;
    }

    public async Task<List<CalculatorUserIncome>> CalculateUserIncomes(IAgentService agentService, long userId,
        long price, long totalGb, long totalDays, long gbPrice, long dayPrice, long templatePrice = 0, long count = 1,
        int numberOfAgents = 1)
    {
        AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
        AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شما غیر فعال شده است");

        List<CalculatorUserIncome> users = new();

        long initialGbPrice = gbPrice;
        long initialDayPrice = dayPrice;

        long currentGbPrice = initialGbPrice;
        long currentDayPrice = initialDayPrice;
        long currentTemplatePrice = templatePrice;

        // محاسبه درآمد از پایین‌ترین سطح
        for (int i = numberOfAgents; i >= 0; i--)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            HierarchyId? childAncestorPath = null;

            if (i != 0)
                childAncestorPath = agent.AgentPath.GetAncestor(i - 1);

            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
            Domain.Entities.Agent.Agent?
                childByPath = await agentService.GetAgentByPathAsync(childAncestorPath ?? null);

            if (agentByPath != null)
            {
                double percent = GetAgentPercent(agentByPath, admin, i);

                if (childByPath?.SpecialPercent != null && childByPath?.SpecialPercent != 0)
                {
                    percent = childByPath?.SpecialPercent == 0 ? 1 : childByPath?.SpecialPercent ?? 1;
                }

                if (admin?.SpecialPercent != 0 && admin?.SpecialPercent != null && i == 0)
                    percent = admin?.SpecialPercent == 0 ? 1 : admin?.SpecialPercent ?? 1;

                double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;

                long totalProfit = 0;

                if (templatePrice != 0)
                {
                    totalProfit = Convert.ToInt64(currentTemplatePrice * multiplier) - currentTemplatePrice;
                    currentTemplatePrice += totalProfit;
                }
                else
                {
                    long newGbPrice = Convert.ToInt64(currentGbPrice * multiplier);
                    long newDayPrice = Convert.ToInt64(currentDayPrice * multiplier);
                    long gbProfit = (newGbPrice - currentGbPrice) * totalGb;
                    long dayProfit = (newDayPrice - currentDayPrice) * totalDays;
                    currentGbPrice = newGbPrice;
                    currentDayPrice = newDayPrice;
                    totalProfit = gbProfit + dayProfit;
                }

                users.Add(new CalculatorUserIncome(agentByPath.AgentAdminId, totalProfit, agentByPath.Id,
                    (int)multiplier, agentByPath?.BrandName ?? agentByPath?.PersianBrandName));
            }
        }

        return users;
    }

    private double GetAgentPercent(Domain.Entities.Agent.Agent agent, AgentDto? admin, int level)
    {
        if (admin != null)
        {
            return agent.AgentPercent == 0 ? 1 : agent.AgentPercent;
        }
        else
        {
            return level == 0
                ? (agent.UserPercent == 0 ? 1 : agent.UserPercent)
                : (agent.AgentPercent == 0 ? 1 : agent.AgentPercent);
        }
    }
}