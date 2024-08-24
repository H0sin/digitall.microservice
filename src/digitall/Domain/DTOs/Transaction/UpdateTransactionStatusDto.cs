using Domain.Enums.Transaction;

namespace Domain.DTOs.Transaction;

public class UpdateTransactionStatusDto
{
    public UpdateTransactionStatusDto()
    {
        
    }
    public UpdateTransactionStatusDto(TransactionStatus? status, long transactionId)
    {
        TransactionStatus = status ?? TransactionStatus.Waiting;
        TransactionId = transactionId;
    }

    public TransactionStatus TransactionStatus { get; set; }
    public long TransactionId { get; set; }
}