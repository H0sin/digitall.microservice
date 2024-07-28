using Application.Services.Interface.Notification;
using Data.Context;
using Domain.Entities.Category;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace Application.Jobs;

public class DeleteExpiredNotificationsJob : IJob
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public DeleteExpiredNotificationsJob(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        using (var scope = _serviceScopeFactory.CreateScope())
        {
            var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
            var now = DateTime.UtcNow;
            await notificationService.DeleteExpireNotificationAsync();
        }
    }
}