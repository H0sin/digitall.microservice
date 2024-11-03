using Application.Services.Interface.Account;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Notification;
using Domain.DTOs.Agent;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace Application.Jobs;

public class ActiveNegativeBalanceJob(IServiceScopeFactory serviceScopeFactory) : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        await using var scope = serviceScopeFactory.CreateAsyncScope();
        var agentService = scope.ServiceProvider.GetRequiredService<IAgentService>();
        var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
        var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

        List<AgentDto> agents = await agentService.AgentsReachedNegativeNotLimit();

        foreach (var agent in agents)
        {
            await userService.ActiveAllUserAccount(agent.AgentAdminId);
            agent.DisabledAccountTime = null;
            await agentService.UpdateAgentAsync(agent, 1);
        }
    }
}