using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Authorization;
using Domain.IRepositories.Authorization;
using Domain.IRepositories.Base;

namespace Data.Repositories.Authorization
{
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(DigitallDbContext context) : base(context)
        {
        }
    }
}
