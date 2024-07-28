using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Account;
using Domain.IRepositories.Account;

namespace Data.Repositories.Account;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(DigitallDbContext context) : base(context)
    {
    }
}