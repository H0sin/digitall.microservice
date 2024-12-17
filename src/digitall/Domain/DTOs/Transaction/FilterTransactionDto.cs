using Domain.DTOs.Paging;
using Domain.Enums.Transaction;

namespace Domain.DTOs.Transaction;

public class FilterTransactionDto : BasePaging<TransactionDto>
{
    public TransactionType? Type { get; set; }
    
    public TransactionStatus? Status { get; set; }

    /// <summary>
    /// price or code
    /// </summary>
    public long? Details { get; set; }

    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public long? UserId { get; set; }
}