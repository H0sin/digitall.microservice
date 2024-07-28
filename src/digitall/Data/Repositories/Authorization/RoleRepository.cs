using Data.Context;
using Data.Repositories.Base;
using Domain.Entities.Authorization;
using Domain.IRepositories.Authorization;

namespace Data.Repositories.Authorization
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(DigitallDbContext context) : base(context)
        {
        }
    }
}
