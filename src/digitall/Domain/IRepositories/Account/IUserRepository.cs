using Domain.Entities.Account;
using Domain.IRepositories.Base;

namespace Domain.IRepositories.Account;

public interface IUserRepository : IBaseRepository<User>
{
}