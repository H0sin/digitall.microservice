using System.ComponentModel.DataAnnotations;
using Domain.Enums.Transaction;

namespace Domain.DTOs.Transaction;

public class TransactionDto
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public long? Price { get; set; }
    public string? Description { get; set; }
    public TransactionType TransactionType { get; set; }
    public TransactionStatus TransactionStatus { get; set; }
    public string? AccountName { get; set; }
    public DateTime TransactionTime { get; set; }
    public string CardNumber { get; set; }
    public string? BankName { get; set; }
    [Display(Name = "عکس تراکنش")] public string? AvatarTransaction { get; set; }
}