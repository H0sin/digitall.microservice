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
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            if (agentByPath != null)
            {
                double percent;
                if (admin != null)
                {
                    percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
                }
                else
                {
                    percent = i == 0
                        ? agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent
                        : agentByPath.AgentPercent == 0
                            ? 1
                            : agentByPath.AgentPercent;
                }

                double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
                totalMultiplier *= multiplier;
            }
        }

        finalPrice = Convert.ToInt64(initialPrice * totalMultiplier);
        return finalPrice;
    }

    public async Task<List<CalculatorUserIncome>> CalculateUserIncomes(IAgentService agentService, long userId,
        long price, long totalGb, long totalDays, long gbPrice, long dayPrice,long templatePrice = 0,long count=1, int numberOfAgents = 1)
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
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            if (agentByPath != null)
            {
                double percent = GetAgentPercent(agentByPath, admin, i);
                 
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
                users.Add(new CalculatorUserIncome(agentByPath.AgentAdminId, totalProfit, agentByPath.Id));        
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

    
    public async Task<List<CalculatorUserIncome>> CalculateUserIncomesAsync(
        IAgentService agentService,
        long finalPrice,
        long userId,
        int numberOfAgents = 1)
    {
        // دریافت نماینده اصلی و نماینده فعلی
        AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
        AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);

        if (agent == null)
            throw new NotFoundException("نمایندگی شما غیر فعال شده است");

        // لیست برای ذخیره درآمدهای نمایندگان
        List<CalculatorUserIncome> users = new();
        Dictionary<long, long> userIncomes = new(); // برای ذخیره درآمد هر کاربر

        // شروع با قیمت نهایی
        long currentPrice = finalPrice;

        // محاسبه سود از داخلی‌ترین سطح به بالاترین سطح
        for (int i = 0; i <= numberOfAgents; i++)
        {
            HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
            Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);

            if (agentByPath != null)
            {
                // دریافت درصد سود نماینده
                double percent = GetAgentPercent(agentByPath, admin, i);
                double multiplier = percent / 100.0;

                // محاسبه سود بر اساس درصد سود
                long profit = Convert.ToInt64(currentPrice * multiplier);

                // ذخیره سود در دیکشنری
                if (userIncomes.ContainsKey(agentByPath.AgentAdminId))
                {
                    userIncomes[agentByPath.AgentAdminId] += profit;
                }
                else
                {
                    userIncomes[agentByPath.AgentAdminId] = profit;
                }

                // به روز رسانی قیمت برای نمایندگان بالاتر
                currentPrice -= profit; // کاهش قیمت به مقدار سود نماینده فعلی
            }
        }

        // ایجاد لیست نهایی
        foreach (var entry in userIncomes)
        {
            users.Add(new CalculatorUserIncome(entry.Key, entry.Value, entry.Key));
        }

        return users;
    }

    
    // public async Task<List<CalculatorUserIncome>> CalculateUserIncomes(IAgentService agentService, long userId,
    //     long price, int count = 1, int numberOfAgents = 2)
    // {
    //     AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
    //     AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);
    //
    //     if (agent == null)
    //         throw new NotFoundException("نمایندگی شما غیر فعال شده است");
    //
    //     List<CalculatorUserIncome> users = new();
    //
    //     for (int i = 0; i <= numberOfAgents; i++)
    //     {
    //         HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
    //         Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
    //
    //         if (agentByPath != null)
    //         {
    //             double percent;
    //             if (admin != null)
    //             {
    //                 percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
    //             }
    //             else
    //             {
    //                 percent = i == 0
    //                     ? agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent
    //                     : agentByPath.AgentPercent == 0
    //                         ? 1
    //                         : agentByPath.AgentPercent;
    //             }
    //
    //             double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
    //             User? user = await agentService.GetAdminAgentUserAsync(agentByPath.AgentAdminId);
    //
    //             if (user != null)
    //             {
    //                 long income = Convert.ToInt64((price - (price / multiplier)) * count);
    //                 user.Balance += income;
    //                 users.Add(new CalculatorUserIncome(user.Id, income, agentByPath.Id));
    //             }
    //         }
    //     }
    //
    //     return users;
    // }
}