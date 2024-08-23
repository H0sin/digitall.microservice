using Domain.DTOs.Transaction;
using Domain.Entities.Account;
using Domain.Entities.Transaction;
using Domain.Enums.Transaction;

namespace Application.Services.Interface.Transaction;

public interface ITransactionService
{
    Task<AddTransactionResult> AddTransactionAsync(AddTransactionDto transaction, long userId);
    Task<TransactionDto> GetTransactionByIdAsync(long id);
    Task<bool> ChangeTransactionStatusAsync(TransactionDto transaction, TransactionStatus status);

    /// <summary>
    /// get user transactions
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<List<Domain.Entities.Transaction.Transaction>> GetAllTransactionByUserIdAsync(long userId);

    /// <summary>
    /// increase user balanse
    /// </summary>
    /// <param name="transaction"></param>
    /// <param name="userId"></param>
    /// <param name="adminId"></param>
    /// <returns></returns>
    Task IncreaseUserAsync(AddTransactionDto transaction, long userId,long adminId);

    Task UpdateTransactionStatusAsync(UpdateTransactionStatusDto transaction,
        long userId);

    Task<FilterTransactionDto> FilterTransactionAsync(FilterTransactionDto filter);
    Task AddTransactionDetailAsync(AddTransactionDetialDto transaction, long userId);
    Task<TransactionDetailDto?> GetTransactionDetailsAsync(long agnetId);

    /// <summary>
    /// update agent transaction deatil
    /// </summary>
    /// <param name="transaction"></param>
    /// <returns></returns>
    Task<bool> UpdateTransactionDetailsAsync(TransactionDetailDto transactionDetail, long userId);
}