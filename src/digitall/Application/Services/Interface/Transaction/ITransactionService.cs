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
    Task<List<TransactionDto>> GetAllTransactionByUserIdAsync(long userId);

    /// <summary>
    /// send list transaction waiting async
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<List<TransactionDto>> SendTransactionWaitingAsync(long userId);

    /// <summary>
    /// increase user balanse
    /// </summary>
    /// <param name="transaction"></param>
    /// <param name="userId"></param>
    /// <param name="agentId"></param>
    /// <returns></returns>
    Task IncreaseUserAsync(AddTransactionDto transaction, long userId,long agentId);

    /// <summary>
    /// decrease user balanse
    /// </summary>
    /// <param name="transaction"></param>
    /// <param name="userId"></param>
    /// <param name="agentId"></param>
    /// <returns></returns>
    Task DecreaseUserAsync(AddTransactionDto transaction, long userId,long agentId);
    
    Task UpdateTransactionStatusAsync(UpdateTransactionStatusDto transaction,
        long userId);

    Task<FilterTransactionDto> FilterTransactionAsync(FilterTransactionDto filter);
    Task AddTransactionDetailAsync(AddTransactionDetailDto transaction, long userId);
    Task<TransactionDetailDto?> GetTransactionDetailsAsync(long agnetId);

    /// <summary>
    /// update agent transaction deatil
    /// </summary>
    /// <param name="transaction"></param>
    /// <returns></returns>
    Task<bool> UpdateTransactionDetailsAsync(TransactionDetailDto transactionDetail, long userId);
}