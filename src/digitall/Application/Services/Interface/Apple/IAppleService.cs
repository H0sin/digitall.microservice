using Domain.Entities.Apple;

namespace Application.Services.Interface.Apple;

public interface IAppleService
{
     Task<List<AppleIdType>> GetListHaveExistAppleId();
     Task<List<AppleIdType>> GetAppleIdType();
     Task<AppleIdType?> GetAppleIdTypeById(long id);
     Task<AppleIdType> GetAppleIdTypeById(long id,long userId);
}