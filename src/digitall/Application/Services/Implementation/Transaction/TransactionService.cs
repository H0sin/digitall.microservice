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
using Application.Services.Interface.Agent;
using Domain.DTOs.Agent;
using Domain.Entities.Transaction;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Services.Implementation.Transaction;

public class TransactionService(
    ITransactionRepository transactionRepository,
    ITransactionDetailRepository transactionDetailRepository,
    IAgentService agentService,
    IUserService userService)
    : ITransactionService
{
    public async Task<AddTransactionResult> AddTransactionAsync(AddTransactionDto transaction, long userId)
    {
        UserDto? user = await userService.GetUserByIdAsync(userId);
        if (user is null)
            return AddTransactionResult.NotUserExists;

        AgentDto? agent = await agentService.GetAgentByIdAsync(user.AgentId);

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
            TransactionDetailId = agent?.TransactionDeatilId ?? 0
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
        await transactionRepository.SaveChanges(userId);

        return AddTransactionResult.Success;
    }


    public async Task UpdateTransactionStatusAsync(
        UpdateTransactionStatusDto transaction, long userId)
    {
        using IDbContextTransaction t = await transactionRepository.context.Database.BeginTransactionAsync();
        try
        {
            Domain.Entities.Transaction.Transaction? transe =
                await transactionRepository.GetEntityById(transaction.TransactionId);
            TransactionDetail? transactionDetail =
                await transactionDetailRepository.GetEntityById(transe.TransactionDetailId);
            AgentDto? agent = await agentService.GetAgentByIdAsync(transactionDetail.AgentId);
            UserDto? user = await userService.GetUserByIdAsync(agent.AgentAdminId);

            if (transe.Price > (user?.Balance ?? 0))
                throw new BadRequestException("مبلغ شارج درخواستی بیشتر از موجودی حساب شما است!");

            if (transaction.TransactionStatus == TransactionStatus.Accepted &&
                transe.TransactionStatus == TransactionStatus.Waiting)
            {
                await userService.UpdateUserBalanceAsync(transe.Price, transe.CreateBy);
                await userService.UpdateUserBalanceAsync(-transe.Price, user!.Id);
            }

            else
                throw new BadRequestException("شما قبلا این تراکنش را برسی کردید!");

            transe!.TransactionStatus = transaction.TransactionStatus;

            await transactionRepository.UpdateEntity(transe);
            await transactionRepository.SaveChanges(userId);
            await t.CommitAsync();
        }
        catch (Exception e)
        {
            await t.RollbackAsync();
            throw;
        }
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
        return new TransactionDto(await transactionRepository.GetEntityById(id));
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

    public async Task AddTransactionDetailAsync(AddTransactionDetialDto transaction, long userId)
    {
        if (await transactionDetailRepository.GetQuery()
                .AnyAsync(x => x.CardNumber == transaction.CardNumber))
            throw new ExistsException("این شماره کارت از قبل ثبت شده است");

        await transactionDetailRepository.AddEntity(transaction._GenerateTransaction());
        await transactionDetailRepository.SaveChanges(userId);
    }

    public async Task<TransactionDetailDto?> GetTransactionDetailsAsync(long agentId)
    {
        TransactionDetail? transactionDetail = await transactionDetailRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.AgentId == agentId);
        return new TransactionDetailDto(transactionDetail);
    }

    public async Task<bool> UpdateTransactionDetailsAsync(TransactionDetailDto transactionDetail, long userId)
    {
        TransactionDetail? detail = await transactionDetailRepository
            .GetQuery()
            .Include(x => x.Agent)
            .SingleOrDefaultAsync(x => x.Id == transactionDetail.Id);
        
        if (detail?.Agent?.AgentAdminId != userId)
            throw new NotFoundException("چنین نمایندگی وجود ندارد");

        detail!.CardNumber ??= transactionDetail.CardNumber;
        detail!.CardHolderName ??= transactionDetail.CardHolderName;
        detail!.Description ??= transactionDetail.Description;
        detail.MaximumAmount =
            transactionDetail.MaximumAmount > 0 ? transactionDetail.MaximumAmount : detail.MaximumAmount;
        detail.MinimalAmount =
            transactionDetail.MinimalAmount > 0 ? transactionDetail.MinimalAmount : detail.MinimalAmount;
        await transactionDetailRepository.UpdateEntity(detail);
        await transactionDetailRepository.SaveChanges(userId);

        return true;
    }
}