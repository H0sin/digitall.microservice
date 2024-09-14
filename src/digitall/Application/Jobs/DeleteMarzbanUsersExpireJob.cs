using Application.Services.Interface.Marzban;
using Domain.Entities.Marzban;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace Application.Jobs;

public class DeleteMarzbanUsersExpireJob : IJob
{
    private readonly IServiceScopeFactory _serviceScopeFactory;
    
    public DeleteMarzbanUsersExpireJob(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }
    
    public async Task Execute(IJobExecutionContext context)
    {
        var cts = new CancellationTokenSource(TimeSpan.FromMinutes(10));
        await using var scope = _serviceScopeFactory.CreateAsyncScope();
        IMarzbanService marzbanService = scope.ServiceProvider.GetRequiredService<IMarzbanService>();
    
        List<MarzbanServer> marzbanServers = await marzbanService.ListMarzbanServerAsync();
    
        foreach (var marzbanServer in marzbanServers)
        {
            cts.Token.ThrowIfCancellationRequested();
            await marzbanService.DeleteMarzbanUserExpire(marzbanServer,15,null);
        }
    }
}