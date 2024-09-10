using Application.Services.Implementation.Marzban;
using Application.Services.Interface.Marzban;
using Application.Services.Interface.Notification;
using Domain.DTOs.Marzban;
using Domain.Entities.Marzban;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace Application.Jobs;

public class MarzbanHolderBotJob : IJob
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public MarzbanHolderBotJob(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            var cts = new CancellationTokenSource(TimeSpan.FromMinutes(3));

            await using var scope = _serviceScopeFactory.CreateAsyncScope();
            IMarzbanService marzbanService = scope.ServiceProvider.GetRequiredService<IMarzbanService>();

            List<MarzbanServer> marzbanServers = await marzbanService.ListMarzbanServerAsync();

            List<MarzbanUser> marzban_users_list = new List<MarzbanUser>();

            foreach (var marzbanServer in marzbanServers)
            {
                List<MarzbanUser?> marzban_users = await marzbanService.GetListExpireUserAsync(marzbanServer.Id);

                if (marzban_users.Count > 0)
                    marzban_users_list.AddRange(marzban_users);
            }

            foreach (MarzbanUser user in marzban_users_list)
            {
                cts.Token.ThrowIfCancellationRequested();

                var server = marzbanServers.SingleOrDefault(x => x.Id == user.MarzbanServerId);
                if (server != null)
                {
                    await marzbanService.UpdateMarzbanUserHolderInboundAsync(user, server);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}