using Domain.DTOs.Transaction;
using Domain.Entities.Account;
using Domain.Enums.Transaction;

namespace Application.Services.Interface.Transaction;

public interface ITransactionService
{
    Task<AddTransactionResult> AddTransactionAsync(AddTransactionDto transaction, long userId);
    Task<TransactionDto> GetTransactionByIdAsync(long id);
    Task<bool> ChangeTransactionStatusAsync(TransactionDto transaction, TransactionStatus status);

    Task UpdateTransactionStatusAsync(UpdateTransactionStatusDto transaction,
        long userId);
    Task<FilterTransactionDto> FilterTransactionAsync(FilterTransactionDto filter);
    Task AddTransactionDetailAsync(AddTransactionDetialDto transaction,long userId);
    Task<TransactionDetailDto?> GetTransactionDetailsAsync(long agnetId);
}