using Application.Services.Interface.Account;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Notification;
using Domain.DTOs.Agent;
using Domain.DTOs.Notification;
using Domain.Enums.Notification;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace Application.Jobs;

public class ActiveNegativeBalanceJob(IServiceScopeFactory serviceScopeFactory) : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        await using var scope = serviceScopeFactory.CreateAsyncScope();
        var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
        try
        {
            var agentService = scope.ServiceProvider.GetRequiredService<IAgentService>();
            var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
            
            List<AgentDto> agents = await agentService.AgentsReachedNegativeNotLimit();
            
            foreach (var agent in agents)
            {
                await notificationService.AddNotificationAsync(new AddNotificationDto()
                {
                    Message = $"""
                               نماینده در جاب.ActiveNegativeBalanceJob 
                               {agent.AgentAdminId}
                               {agent.BrandName}
                               {agent.PersianBrandName}
                               """,
                    NotificationType = NotificationType.BogsReports,
                    UserId = 1,
                }, 1);
                
                await userService.ActiveAllUserAccount(agent.AgentAdminId);
                agent.DisabledAccountTime = null;
                await agentService.UpdateAgentAsync(agent, 1);
            }
        }
        catch (Exception e)
        {
            await notificationService.AddNotificationAsync(new AddNotificationDto()
            {
                Message = $"""
                           هنگام اجرای job CheckAndNotifyNegativeBalanceJob به مشکل خوردیم.
                           {e.Message}
                           {e.Data}
                           {e.InnerException}
                           """,
                NotificationType = NotificationType.BogsReports,
                UserId = 1,
            }, 1);
        }
    }
}