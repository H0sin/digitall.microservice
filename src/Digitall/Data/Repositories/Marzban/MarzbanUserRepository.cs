using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Marzban;
using Domain.IRepositories.Marzban;

namespace Data.Repositories.Marzban;

public class MarzbanUserRepository(DigitallDbContext context)
    : BaseRepository<MarzbanUser>(context), IMarzbanUserRepository;