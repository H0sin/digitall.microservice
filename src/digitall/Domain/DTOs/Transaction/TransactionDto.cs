using System.ComponentModel.DataAnnotations;
using Domain.DTOs.Account;
using Domain.Entities.Account;
using Domain.Enums.Transaction;

namespace Domain.DTOs.Transaction;

public class TransactionDto
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public long? Price { get; set; }
    public string? Description { get; set; }
    public TransactionType? TransactionType { get; set; }
    public TransactionStatus? TransactionStatus { get; set; }
    public string? AccountName { get; set; }
    public DateTime TransactionTime { get; set; }
    public string? CardNumber { get; set; }
    public string? BankName { get; set; }
    [Display(Name = "عکس تراکنش")] public string? AvatarTransaction { get; set; }
    public long TransactionCode { get; set; }
    
    public long CreateBy { get; set; }
    public string? Username { get; set; }
    public long ChatId { get; set; }
    public long TransactionDetailId { get; set; }
    public long? Balance { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public long UserId { get; set; }
    
    public TransactionDto()
    {
    }

    public TransactionDto(Entities.Transaction.Transaction? transaction)
    {
        Id = transaction?.Id ?? 0;
        Title = transaction?.Title;
        Price = transaction?.Price;
        Description = transaction?.Description;
        TransactionType = transaction?.TransactionType;
        TransactionStatus = transaction?.TransactionStatus;
        AccountName = transaction?.AccountName;
        TransactionTime = transaction.TransactionTime;
        CardNumber = transaction.CardNumber;
        BankName = transaction.BankName;
        AvatarTransaction = transaction?.AvatarTransaction;
        TransactionDetailId = transaction.TransactionDetailId ?? 0;
        TransactionCode = transaction.TransactionCode;
    }
    
    public TransactionDto(Entities.Transaction.Transaction? transaction,User user)
    {
        Id = transaction?.Id ?? 0;
        Title = transaction?.Title;
        Price = transaction?.Price;
        Description = transaction?.Description;
        TransactionType = transaction?.TransactionType;
        TransactionStatus = transaction?.TransactionStatus;
        AccountName = transaction?.AccountName;
        TransactionTime = transaction.TransactionTime;
        CardNumber = transaction.CardNumber;
        BankName = transaction.BankName;
        AvatarTransaction = transaction?.AvatarTransaction;
        TransactionDetailId = transaction.TransactionDetailId ?? 0;
        TransactionCode = transaction.TransactionCode;
        ChatId = user.ChatId ?? 0;
        Username = user.TelegramUsername;
    }
    
    public TransactionDto(Entities.Transaction.Transaction? transaction,UserDto? user)
    {
        Id = transaction?.Id ?? 0;
        Title = transaction?.Title;
        Price = transaction?.Price;
        Description = transaction?.Description;
        TransactionType = transaction?.TransactionType;
        TransactionStatus = transaction?.TransactionStatus;
        AccountName = transaction?.AccountName;
        TransactionTime = transaction.TransactionTime;
        CardNumber = transaction.CardNumber;
        BankName = transaction.BankName;
        AvatarTransaction = transaction?.AvatarTransaction;
        TransactionDetailId = transaction?.TransactionDetailId ?? 0;
        TransactionCode = transaction?.TransactionCode ?? 0;
        ChatId = user?.ChatId ?? 0;
        Username = user?.TelegramUsername ?? "";
        FirstName = user?.FirstName ?? "";
        LastName = user?.LastName ?? "";
        Balance = user?.Balance;
        UserId = user.Id;
    }
}