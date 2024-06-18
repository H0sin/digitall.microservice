using Application.Services.Interface.Account;
using Application.Services.Interface.Transaction;
using Application.Utilities;
using Application.Extensions;
using Application.Utilities;
using Domain.DTOs.Account;
using Domain.DTOs.Transaction;
using Domain.Entities.Account;
using Domain.Enums.Transaction;
using Domain.IRepositories.Transaction;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace Application.Services.Implementation.Transaction;

public class TransactionService : ITransactionService
{
    #region constructor

    private readonly ITransactionRepository _transactionRepository;
    private readonly IUserService _userService;

    public TransactionService(ITransactionRepository transactionRepository, IUserService userService)
    {
        _transactionRepository = transactionRepository;
        _userService = userService;
    }

    #endregion

    #region add

    public async Task<AddTransactionResult> AddTransactionAsync(AddTransactionDto transaction, long userId)
    {
        if (await _userService.GetUserByIdAsync(userId) is null)
            return AddTransactionResult.NotUserExists;

        Domain.Entities.Transaction.Transaction newTransaction = new()
        {
            Description = transaction.Description,
            IsDelete = false,
            Price = transaction.Price,
            Title = transaction.Title,
            AccountName = transaction.AccountName,
            TransactionType = transaction.TransactionType,
            TransactionStatus = TransactionStatus.Waiting,
            BankName = transaction.BankName,
            TransactionTime = transaction.TransactionTime,
            CardNumber = transaction.CardNumber,
            UserId = userId
        };

        if (transaction.AvatarTransaction != null && transaction.AvatarTransaction.IsImage())
        {
            var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(transaction.AvatarTransaction.FileName);
            transaction.AvatarTransaction.AddImageToServer(imageName,
                PathExtension.TransactionAvatarOriginServer
                , 100, 100,
                PathExtension.TransactionAvatarThumbServer,
                transaction.AvatarTransaction.FileName);
            newTransaction.AvatarTransaction = imageName;
        }

        await _transactionRepository.AddEntity(newTransaction);
        await _transactionRepository.SaveChanges(newTransaction.UserId);

        return AddTransactionResult.Success;
    }

    #endregion

    #region update

    public async Task<UpdateTransactionStatusResult> UpdateTransactionStatusAsync(
        UpdateTransactionStatusDto transaction, long userId)
    {
        Domain.Entities.Transaction.Transaction? newTransaction =
            await _transactionRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == transaction.TransactionId);

        if (newTransaction is null)
            return UpdateTransactionStatusResult.Error;

        if (transaction.TransactionStatus == TransactionStatus.Accepted &&
            newTransaction.TransactionStatus != TransactionStatus.Accepted)
            await _userService.UpdateUserBalance(newTransaction.Price, newTransaction.CreateBy, userId);

        newTransaction!.TransactionStatus = transaction.TransactionStatus;

        await _transactionRepository.UpdateEntity(newTransaction);
        await _transactionRepository.SaveChanges(userId);

        return UpdateTransactionStatusResult.Success;
    }

    public async Task<bool> ChangeTransactionStatusAsync(TransactionDto transaction, TransactionStatus status)
    {
        try
        {
            Domain.Entities.Transaction.Transaction? newTransaction =
                await _transactionRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == transaction.Id);

            newTransaction!.TransactionStatus = status;

            await _transactionRepository.UpdateEntity(newTransaction);

            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    #endregion

    #region get

    public async Task<TransactionDto> GetTransactionByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region filter

    public async Task<FilterTransactionDto> FilterTransactionAsync(FilterTransactionDto filter)
    {
        IQueryable<Domain.Entities.Transaction.Transaction> query = _transactionRepository.GetQuery();

        IQueryable<TransactionDto> transaction = query.Select(x => new TransactionDto()
        {
            AccountName = x.AccountName,
            AvatarTransaction = PathExtension.TransactionAvatarOrigin + x.AvatarTransaction,
            BankName = x.BankName,
            CardNumber = x.CardNumber,
            Description = x.Description,
            Price = x.Price,
            Title = x.Title,
            TransactionStatus = x.TransactionStatus,
            TransactionTime = x.TransactionTime,
            TransactionType = x.TransactionType,
            Id = x.Id
        });

        await filter.Paging(transaction);

        return filter;
    }

    #endregion
}