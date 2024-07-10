using Domain.IRepositories.Base;

namespace Domain.IRepositories.Transaction;

public interface ITransactionDetailRepository : IBaseRepository<Entities.Transaction.TransactionDetail>
{
}