using Application.Helper;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Apple;
using Domain.Entities.Apple;
using Domain.IRepositories.Apple;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Apple;

public class AppleService(
    IAgentService agentService,
    IAppleIdRepository appleIdRepository,
    IAppleIdTypeRepository appleIdTypeRepository) : IAppleService
{
    public async Task<List<AppleIdType>> GetListHaveExistAppleId()
    {
        try
        {
            return await appleIdTypeRepository
                .GetQuery()
                .Where(x => x.AppleIds!.Count(s => s.UserId == null) > 1)
                .ToListAsync();
        }
        catch (Exception e)
        {
            return new List<AppleIdType>();
        }
    }

    public async Task<List<AppleIdType>> GetAppleIdType()
    {
        return await appleIdTypeRepository.GetQuery().ToListAsync();
    }

    public async Task<AppleIdType?> GetAppleIdTypeById(long id)
    {
        return await appleIdTypeRepository.GetEntityById(id);
    }

    public async Task<AppleIdType> GetAppleIdTypeById(long id, long userId)
    {
        AppleIdType? appleIdType = await GetAppleIdTypeById(id);

        if (await appleIdRepository.GetQuery().CountAsync(x => userId == null & x.AppleIdTypeId == id) <= 0)
        {
            throw new ApplicationException("""
                                           🚫 متأسفانه، در حال حاضر Apple ID موجود نیست.
                                           """);
        };
        
        if (appleIdType is null) throw new ApplicationException("سرویس در دست رس نیست !");
        CountingVpnPrice countingVpnPrice = new();

        var price = await countingVpnPrice.CalculateFinalPrice(agentService, userId, appleIdType.Price);

        appleIdType.Price = price;

        return appleIdType;
    }
}