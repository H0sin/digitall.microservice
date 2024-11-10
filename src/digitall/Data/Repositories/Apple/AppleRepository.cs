using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Apple;
using Domain.IRepositories.Apple;
using Domain.IRepositories.Base;

namespace Data.Repositories.Apple;

public class AppleIdRepository(DigitallDbContext context) : BaseRepository<AppleId>(context) , IAppleIdRepository;

public class AppleIdTypeRepository(DigitallDbContext context) : BaseRepository<AppleIdType>(context) , IAppleIdTypeRepository;