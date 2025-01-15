using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Registry;
using Domain.IRepositories.Registry;

namespace Data.Repositories.Registry;

public class RegistryRepository(DigitallDbContext context)
    : BaseRepository<Domain.Entities.Registry.Registry>(context), IRegistryRepository;

public class RegistrationOptionsRepository(DigitallDbContext context)
    : BaseRepository<RegistrationOptions>(context), IRegistrationOptionsRepository;