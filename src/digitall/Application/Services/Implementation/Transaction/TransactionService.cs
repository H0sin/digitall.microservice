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
using Domain.Exceptions;

namespace Application.Services.Implementation.Transaction;

public class TransactionService(
    ITransactionRepository transactionRepository,
    ITransactionDetailRepository transactionDetailRepository,
    IUserService userService)
    : ITransactionService
{
    public async Task<AddTransactionResult> AddTransactionAsync(AddTransactionDto transaction, long userId)
    {
        if (await userService.GetUserByIdAsync(userId) is null)
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

        //transaction.AvatarTransaction.IsImage()
        if (transaction.AvatarTransaction != null)
        {
            var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(transaction.AvatarTransaction.FileName);
            transaction.AvatarTransaction.AddImageToServer(imageName,
                PathExtension.TransactionAvatarOriginServer
                , 100, 100,
                PathExtension.TransactionAvatarThumbServer,
                transaction.AvatarTransaction.FileName);
            newTransaction.AvatarTransaction = imageName;
        }

        await transactionRepository.AddEntity(newTransaction);
        await transactionRepository.SaveChanges(newTransaction.UserId);

        return AddTransactionResult.Success;
    }

    public async Task<UpdateTransactionStatusResult> UpdateTransactionStatusAsync(
        UpdateTransactionStatusDto transaction, long userId)
    {
        Domain.Entities.Transaction.Transaction? newTransaction =
            await transactionRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == transaction.TransactionId);

        if (newTransaction is null)
            return UpdateTransactionStatusResult.Error;

        if (transaction.TransactionStatus == TransactionStatus.Accepted &&
            newTransaction.TransactionStatus != TransactionStatus.Accepted)
            await userService.UpdateUserBalance(newTransaction.Price, newTransaction.CreateBy, userId);

        newTransaction!.TransactionStatus = transaction.TransactionStatus;

        await transactionRepository.UpdateEntity(newTransaction);
        await transactionRepository.SaveChanges(userId);

        return UpdateTransactionStatusResult.Success;
    }

    public async Task<bool> ChangeTransactionStatusAsync(TransactionDto transaction, TransactionStatus status)
    {
        try
        {
            Domain.Entities.Transaction.Transaction? newTransaction =
                await transactionRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == transaction.Id);

            newTransaction!.TransactionStatus = status;

            await transactionRepository.UpdateEntity(newTransaction);

            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<TransactionDto> GetTransactionByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<FilterTransactionDto> FilterTransactionAsync(FilterTransactionDto filter)
    {
        IQueryable<Domain.Entities.Transaction.Transaction> query = transactionRepository.GetQuery();

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

    public async Task AddTransactionDetailAsync(AddTransactionDetialDto transaction,long userId)
    {
        if (await transactionDetailRepository.GetQuery()
            .AnyAsync(x => x.CardNumber == transaction.CardNumber))
            throw new ExistsException("این شماره کارت از قبل ثبت شده است");

        await transactionDetailRepository.AddEntity(transaction._GenerateTransaction());
        await transactionDetailRepository.SaveChanges(userId);
    }

    public async Task<List<TransactionDetailDto>> GetTransactionDetailsAsync() =>
        await transactionDetailRepository.GetQuery().Select(x => new TransactionDetailDto(x)).ToListAsync();
}