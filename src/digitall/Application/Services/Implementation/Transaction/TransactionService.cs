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
using Application.Services.Interface.Notification;
using Application.Static.Template;
using Domain.DTOs.Agent;
using Domain.Entities.Transaction;
using Domain.Exceptions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Services.Implementation.Transaction;

public class TransactionService(
    ITransactionRepository transactionRepository,
    ITransactionDetailRepository transactionDetailRepository,
    IAgentService agentService,
    IUserService userService,
    IWebHostEnvironment _env,
    INotificationService notificationService)
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
            TransactionDetailId = agent?.TransactionDetailId ?? 0,
            UserId = agent.AgentAdminId
        };

        //transaction.AvatarTransaction.IsImage()
        if (transaction.AvatarTransaction != null)
        {
            var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(transaction.AvatarTransaction.FileName);
            transaction.AvatarTransaction.AddImageToServer(imageName,
                PathExtension.TransactionAvatarOriginServer(_env)
                , 100, 100,
                PathExtension.TransactionAvatarThumbServer(_env),
                transaction.AvatarTransaction.FileName);
            newTransaction.AvatarTransaction = imageName;
        }

        await transactionRepository.AddEntity(newTransaction);
        await transactionRepository.SaveChanges(userId);

        await notificationService.AddNotificationAsync(NotificationTemplate.AddTransactionNotification(
            agent!.AgentAdminId, user.ChatId ?? 0, newTransaction,
            PathExtension.TransactionAvatarOriginServer(_env) + newTransaction
                .AvatarTransaction, "رسید ارسالی", user.TelegramUsername), userId);
        return AddTransactionResult.Success;
    }


    public async Task<List<TransactionDto>> GetAllTransactionByUserIdAsync(long userId)
        => await transactionRepository
            .GetQuery()
            .Where(x => x.CreateBy == userId || x.ModifyBy == userId || x.UserId == userId)
            .Select(x => new TransactionDto(x))
            .ToListAsync();

    public async Task<List<TransactionDto>> GetAllTransactionParentForUserAsync(long parentId, long userId)
    {
        // var transactionCodes = await transactionRepository
        //     .GetQuery()
        //     .Where(t => t.CreateBy == parentId)
        //     .Select(t => t.TransactionCode)
        //     .Distinct()
        //     .ToListAsync();
        //
        // return await transactionRepository
        //     .GetQuery()
        //     .Where(t => transactionCodes.Contains(t.TransactionCode)
        //                 && t.CreateBy == userId)
        //     .OrderByDescending(t => t.CreateDate)
        //     .Select(x => new TransactionDto(x))
        //     .ToListAsync();

        return await transactionRepository
            .GetQuery()
            .Where(t =>
                (t.CreateBy == parentId && t.ModifyBy == userId) ||
                (t.CreateBy == userId && t.ModifyBy == parentId) ||
                (t.CreateBy == parentId && t.UserId == userId) ||
                (t.CreateBy == userId && t.UserId == parentId) ||
                (t.ModifyBy == parentId && t.UserId == userId) ||
                (t.ModifyBy == userId && t.UserId == parentId)
            )
            .Select(x => new TransactionDto(x))
            .ToListAsync();
    }

    public async Task<List<TransactionDto>> SendTransactionWaitingAsync(long agentId)
        => await transactionRepository
            .GetQuery()
            .Include(x => x.TransactionDetail)
            .Where(x => x.TransactionDetail.AgentId == agentId & x.TransactionStatus == TransactionStatus.Waiting)
            .Join(userService.GetAgentUsers(agentId),
                transaction => transaction.CreateBy,
                user => user.Id,
                (transaction, user) =>
                    new TransactionDto(transaction, user))
            .ToListAsync();

    public async Task IncreaseUserAsync(AddTransactionDto transaction, long userId, long agentId)
    {
        await using IDbContextTransaction t = await transactionRepository.context.Database.BeginTransactionAsync();
        try
        {
            await notificationService.AddNotificationAsync(
                NotificationTemplate.SendTransactionNotification(transaction, userId), agentId);
            
            Domain.Entities.Transaction.Transaction newTransaction = new()
            {
                Description = transaction.Description,
                IsDelete = false,
                Price = transaction.Price,
                Title = transaction.Title,
                AccountName = transaction.AccountName,
                TransactionType = TransactionType.ManualIncrease,
                TransactionStatus = TransactionStatus.Accepted,
                BankName = transaction.BankName,
                TransactionTime = transaction.TransactionTime,
                CardNumber = transaction.CardNumber,
                UserId = userId,
            };

            await transactionRepository.AddEntity(newTransaction);
            await transactionRepository.SaveChanges(agentId);

            await userService.UpdateUserBalanceAsync(newTransaction.Price, userId);
            await userService.UpdateUserBalanceAsync((newTransaction.Price * -1), agentId);

            await t.CommitAsync();
        }
        catch (Exception e)
        {
            await t.RollbackAsync();
            throw new AppException("خطا در عملیات");
        }
    }

    public async Task DecreaseUserAsync(AddTransactionDto transaction, long userId, long agentId)
    {
        await using IDbContextTransaction t = await transactionRepository.context.Database.BeginTransactionAsync();
        try
        {
            await notificationService.AddNotificationAsync(
                NotificationTemplate.SendTransactionNotification(transaction, userId), agentId);

            Domain.Entities.Transaction.Transaction newTransaction = new()
            {
                Description = transaction.Description,
                IsDelete = false,
                Price = transaction.Price,
                Title = transaction.Title,
                AccountName = transaction.AccountName,
                TransactionType = TransactionType.ManualDecrease,
                TransactionStatus = TransactionStatus.Accepted,
                BankName = transaction.BankName,
                TransactionTime = transaction.TransactionTime,
                CardNumber = transaction.CardNumber,
                UserId = userId
            };

            await transactionRepository.AddEntity(newTransaction);
            await transactionRepository.SaveChanges(agentId);

            await userService.UpdateUserBalanceAsync(newTransaction.Price * -1, userId);
            await userService.UpdateUserBalanceAsync((newTransaction.Price), agentId);

            await t.CommitAsync();
        }
        catch (Exception e)
        {
            await t.RollbackAsync();
            throw new AppException("خطا در عملیات");
        }
    }

    public async Task UpdateTransactionStatusAsync(
        UpdateTransactionStatusDto transaction, long userId)
    {
        await using IDbContextTransaction t = await transactionRepository.context.Database.BeginTransactionAsync();
        try
        {
            Domain.Entities.Transaction.Transaction? transe =
                await transactionRepository.GetEntityById(transaction.TransactionId);

            TransactionDetail? transactionDetail =
                await transactionDetailRepository.GetEntityById(transe.TransactionDetailId ?? 0);

            AgentDto? agent = await agentService.GetAgentByIdAsync(transactionDetail.AgentId);
            UserDto? user = await userService.GetUserByIdAsync(agent.AgentAdminId);


            long remainingBalance = user.Balance - transe.Price;

            if (remainingBalance < (agent?.NegativeChargeCeiling ?? 0) & agent?.NegativeChargeCeiling < 0)
                throw new AppException(
                    "مبلغ درخواستی باعث می‌شود که موجودی شما بیش از حد مجاز منفی شود! ❌");

            if (transe.Price > (user?.Balance ?? 0) && transaction.TransactionStatus == TransactionStatus.Accepted &
                agent?.NegativeChargeCeiling == 0)
                throw new BadRequestException("مبلغ شارژ درخواستی بیشتر از موجودی حساب شما است!");

            if (transaction.TransactionStatus == TransactionStatus.Accepted &&
                transe.TransactionStatus == TransactionStatus.Waiting)
            {
                await userService.UpdateUserBalanceAsync(transe.Price, transe.CreateBy);
                await userService.UpdateUserBalanceAsync(transe.Price * -1, user!.Id);


                transe.TransactionStatus = TransactionStatus.Accepted;

                UserDto? child = await userService.GetUserByIdAsync(transe.CreateBy);

//                 await transactionRepository.AddEntity(new Domain.Entities.Transaction.Transaction()
//                 {
//                     Description = $"""
//                                    پذیرفتن  تراکنش کاربر
//                                    شناسه تلگرامی کاربر:@{child.TelegramUsername ?? "NOT_USERNAME"}
//                                    ایدی عددی کاربر:{child.ChatId}
//                                    """,
//                     TransactionTime = DateTime.Now,
//                     TransactionType = TransactionType.Decrease,
//                     Price = transe.Price,
//                     Title = "کسر به دلیل قبول تراکنش",
//                     TransactionCode = transe.TransactionCode,
//                     TransactionStatus = TransactionStatus.Accepted,
//                     TransactionDetailId = transe.TransactionDetailId ?? 0,
//                     AccountName = agent?.User?.TelegramUsername ?? agent?.User?.UserFullName() ?? "",
//                 });

                // await transactionRepository.SaveChanges(userId);
            }
            else if (transaction.TransactionStatus == TransactionStatus.NotAccepted &&
                     transe.TransactionStatus == TransactionStatus.Waiting)
            {
                transe.TransactionStatus = TransactionStatus.NotAccepted;
                await transactionRepository.UpdateEntity(transe);
                await transactionRepository.SaveChanges(userId);
            }
            else if (transe.TransactionStatus != TransactionStatus.Waiting)
                throw new BadRequestException("شما قبلا این تراکنش را برسی کردید!");

            transe!.TransactionStatus = transaction.TransactionStatus;

            await notificationService.AddNotificationAsync(
                NotificationTemplate.TransactionStatusAsync(transe.CreateBy, transe), userId);

            await transactionRepository.UpdateEntity(transe);
            await transactionRepository.SaveChanges(transe.UserId ?? 0);

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

    public async Task AddTransactionDetailAsync(AddTransactionDetailDto transaction, long userId)
    {
        if (await transactionDetailRepository.GetQuery()
                .AnyAsync(x => x.CardNumber == transaction.CardNumber))
            throw new ExistsException("این شماره کارت از قبل ثبت شده است");

        await transactionDetailRepository.AddEntity(transaction._GenerateTransaction());
        await transactionDetailRepository.SaveChanges(userId);
    }

    public async Task<TransactionDetailDto?> GetTransactionDetailsAsync(long agentId)
    {
        TransactionDetail? transactionDetail = await transactionDetailRepository
            .GetQuery()
            .Include(x => x.Agent)
            .SingleOrDefaultAsync(x => x.AgentId == agentId);
        return new TransactionDetailDto(transactionDetail);
    }

    public async Task<TransactionDetailDto?> GetTransactionDetailsByUserIdAsync(long userId)
    {
        var agent = await agentService.GetAgentByAdminIdAsync(userId);

        TransactionDetail? transactionDetail = await transactionDetailRepository
            .GetQuery()
            .Include(x => x.Agent)
            .SingleOrDefaultAsync(x => x.AgentId == agent.Id);

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

        detail.CardNumber = transactionDetail.CardNumber ?? detail.CardNumber;
        detail.CardHolderName = transactionDetail.CardHolderName ?? detail.CardHolderName;
        detail.Description = transactionDetail.Description ?? detail.Description;
        detail.MaximumAmountForUser =
            transactionDetail.MaximumAmountForUser > 0
                ? transactionDetail.MaximumAmountForUser
                : detail.MaximumAmountForUser;
        detail.MinimalAmountForUser =
            transactionDetail.MinimalAmountForUser > 0
                ? transactionDetail.MinimalAmountForUser
                : detail.MinimalAmountForUser;
        detail.MaximumAmountForAgent =
            transactionDetail.MaximumAmountForAgent > 0
                ? transactionDetail.MaximumAmountForAgent
                : detail.MaximumAmountForAgent;
        detail.MinimalAmountForAgent =
            transactionDetail.MinimalAmountForAgent > 0
                ? transactionDetail.MinimalAmountForAgent
                : detail.MinimalAmountForAgent;
        await transactionDetailRepository.UpdateEntity(detail);
        await transactionDetailRepository.SaveChanges(userId);

        return true;
    }
}