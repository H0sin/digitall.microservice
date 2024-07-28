using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Marzban;
using Domain.IRepositories.Marzban;

namespace Data.Repositories.Marzban;

public class MarzbanVpnTemplatesRepository(DigitallDbContext context)
    : BaseRepository<MarzbanVpnTemplate>(context), IMarzbanVpnTemplatesRepository;