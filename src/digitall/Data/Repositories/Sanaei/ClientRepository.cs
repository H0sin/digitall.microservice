using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Sanaei;

namespace Data.Repositories.Sanaei;

public class ClientRepository(DigitallDbContext context)
    : BaseRepository<Client>(context), Domain.IRepositories.Sanaei.IClientRepository;