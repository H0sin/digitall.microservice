using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Registry;

namespace Data.Repositories.Registry;

public class RegistryRepository(DigitallDbContext context)
    : BaseRepository<Domain.Entities.Registry.Registry>(context), IRegistryRepository;