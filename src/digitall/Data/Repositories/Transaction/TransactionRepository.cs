using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Base;
using Domain.IRepositories.Transaction;
using T = Domain.Entities.Transaction;

namespace Data.Repositories.Transaction;

public class TransactionRepository : BaseRepository<T.Transaction>, ITransactionRepository
{
    public TransactionRepository(DigitallDbContext context) : base(context)
    {
    }
}