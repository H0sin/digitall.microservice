using Domain.DTOs.Apple;
using Domain.Entities.Account;
using Domain.Entities.Apple;
using Domain.Enums.Apple;

namespace Application.Services.Interface.Apple;

public interface IAppleService
{
     Task<List<GetAppleIdTypeDto>> GetAppleIdTypesAsync();
     Task<List<GetAppleIdTypeDto>> GetListHaveExistAppleIdAsync(long userId);
     Task<List<AppleIdType>> GetAppleIdTypeAsync();
     Task<AppleIdType?> GetAppleIdTypeByIdAsync(long id);
     Task<GetAppleIdTypeDto> GetAppleIdTypeByIdAsync(long id,long userId);
     Task<AppleId> BuyAppleIdAsync(long id, long? userId = null,long? chatId = null);
     Task<FilterAppleId> FilterAppleIdListAsync(FilterAppleId filter);
     Task<AppleId?> GetAppleIdByIdAsync(long id,long userId);
     Task<AppleId?> AddAppleIdAsync(AddAppleIdDto appleId, long userId);
     Task<bool> SendToWarrantyAppleId(long id,User user);
     Task<bool> SendToWrongInformationAppleId(long id,User user);
     Task<AppleIdDto?> AssignToMeAsync(long id,long? userId = null,long? chatId = null);
     Task<AppleIdDto?> GetAppleIdAssignToSupportAsync(long supportId);
     Task<AppleIdInformationDto?> GetAppleIdInformation(long id);
     Task RejectWarrantyRequestAsync(long id, string message,long userId);
     Task<AppleId?> ApplyWarrantyServicesAsync(long id,AppleIdStatus status);
     Task<AppleIdDto?> GetAppleIdByIdAsync(long id);
     Task UpdateAppleIdAsync(AppleIdDto appleId, long userId);
}