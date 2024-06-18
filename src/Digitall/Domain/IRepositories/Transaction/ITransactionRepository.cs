using Domain.IRepositories.Base;

namespace Domain.IRepositories.Transaction;

public interface ITransactionRepository : IBaseRepository<Entities.Transaction.Transaction>
{
}