using Domain.DTOs.Apple;
using Domain.Entities.Apple;

namespace Application.Services.Interface.Apple;

public interface IAppleService
{
     Task<List<AppleIdType>> GetListHaveExistAppleIdAsync();
     Task<List<AppleIdType>> GetAppleIdTypeAsync();
     Task<AppleIdType?> GetAppleIdTypeByIdAsync(long id);
     Task<AppleIdType> GetAppleIdTypeByIdAsync(long id,long userId);
     Task<AppleId> BuyAppleIdAsync(long id, long? userId = null,long? chatId = null);
     Task<FilterAppleId> FilterAppleIdListAsync(FilterAppleId filter);
     Task<AppleId?> GetAppleIdByIdAsync(long id,long userId);
     Task<AppleId?> AddAppleIdAsync(AddAppleIdDto appleId, long userId);
}