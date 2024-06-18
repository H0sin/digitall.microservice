using Domain.Enums.Transaction;

namespace Domain.DTOs.Transaction;

public class UpdateTransactionStatusDto
{
    public TransactionStatus TransactionStatus { get; set; }
    public long TransactionId { get; set; }
}