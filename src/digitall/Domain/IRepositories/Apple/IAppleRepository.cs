using Domain.Entities.Apple;
using Domain.IRepositories.Base;

namespace Domain.IRepositories.Apple;

public interface IAppleIdRepository : IBaseRepository<AppleId>;
public interface IAppleIdTypeRepository : IBaseRepository<AppleIdType>;