using Application.Helper;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Apple;
using Application.Services.Interface.Notification;
using Application.Static.Template;
using Domain.DTOs.Account;
using Domain.DTOs.Apple;
using Domain.Entities.Account;
using Domain.Entities.Apple;
using Domain.Entities.Order;
using Domain.Entities.Transaction;
using Domain.Enums.Order;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Apple;
using Domain.IRepositories.Order;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Apple;

public class AppleService(
    IAgentService agentService,
    IAppleIdRepository appleIdRepository,
    IUserRepository userRepository,
    IOrderRepository orderRepository,
    INotificationService notificationService,
    IAppleIdTypeRepository appleIdTypeRepository) : IAppleService
{
    public async Task<List<GetAppleIdTypeDto>> GetAppleIdTypesAsync()
    {
        return await appleIdTypeRepository
            .GetQuery()
            .Select(x => new GetAppleIdTypeDto(x)).ToListAsync();
    }

    public async Task<List<AppleIdType>> GetListHaveExistAppleIdAsync()
    {
        try
        {
            return await appleIdTypeRepository
                .GetQuery()
                .Include(z => z.AppleIds)
                .Where(x => x.AppleIds!.Count(s => s.UserId == null) > 1)
                .ToListAsync();
        }
        catch (Exception e)
        {
            return new List<AppleIdType>();
        }
    }

    public async Task<List<AppleIdType>> GetAppleIdTypeAsync()
    {
        return await appleIdTypeRepository.GetQuery().ToListAsync();
    }

    public async Task<AppleIdType?> GetAppleIdTypeByIdAsync(long id)
    {
        return await appleIdTypeRepository.GetEntityById(id);
    }

    public async Task<AppleIdType> GetAppleIdTypeByIdAsync(long id, long userId)
    {
        AppleIdType? appleIdType = await GetAppleIdTypeByIdAsync(id);

        // if (await appleIdRepository.GetQuery().CountAsync(x => userId == null & x.AppleIdTypeId == id) <= 0)
        // {
        //     throw new ApplicationException("""
        //                                    🚫 متأسفانه، در حال حاضر Apple ID موجود نیست.
        //                                    """);
        // };

        if (appleIdType is null) throw new ApplicationException("سرویس در دست رس نیست !");
        CountingVpnPrice countingVpnPrice = new();

        var price = await countingVpnPrice.CalculateFinalPrice(agentService, userId, appleIdType.Price);

        appleIdType.Price = price;

        return appleIdType;
    }

    public async Task<AppleId> BuyAppleIdAsync(long id, long? userId = null, long? chatId = null)
    {
        await using var transaction = await appleIdRepository.context.Database.BeginTransactionAsync();

        try
        {
            long price = 0;
            CountingVpnPrice countingVpnPrice = new();
            User? user = null;

            if (userId is not null) user = await userRepository.GetEntityById(userId ?? 0);

            if (chatId is not null)
                user = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.ChatId == chatId);

            AppleIdType appleIdType = await GetAppleIdTypeByIdAsync(id, user.Id);

            price = await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, appleIdType.Price);


            await countingVpnPrice.CalculateUserIncomes(agentService, user.Id, price, 0,
                0, 0, 0, price, 1);

            if (user.Balance < price)
            {
                throw new BadRequestException("موجودی شما کافی نیست");
            }

            user!.Balance -= price;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(user.Id);

            var incomes = await countingVpnPrice.CalculateUserIncomes(agentService, user.Id, price,
                0,
                0, 0, 0, price, 1);

            Domain.Entities.Order.Order order = new()
            {
                Description = $"خرید AppleId {appleIdType.Title}",
                UserId = user?.Id ?? 0,
                IsPaid = true,
                TracingCode = new Random().Next(10000, 99999899),
                PaymentDate = DateTime.Now,
                OrderDetails = new List<OrderDetail>()
                {
                    new()
                    {
                        Count = 1,
                        OrderDeatilType = OrderDeatilType.Wireguard,
                        ProductPrice = price
                    }
                }
            };

            await orderRepository.AddEntity(order);
            await orderRepository.SaveChanges(user.Id);

            long orderDetailId = order.OrderDetails.First().Id;

            foreach (var i in incomes)
            {
                User? u = await userRepository.GetEntityById(i.UserId);

                i.BalanceBeforPayment = u.Balance;
                u.Balance += i.Balance;

                await agentService.AddAgentsIncomesDetailAsync(new AgentsIncomesDetail()
                {
                    OrderDetailId = orderDetailId,
                    Profit = i.Balance,
                    AgentId = i.AgentId,
                    UserId = i.UserId,
                    Percent = i.Percent,
                }, user.Id);

                i.TelegramUserName = u.TelegramUsername ?? "NOT_USERNAME";
                i.chatId = u.ChatId;

                IOrderedEnumerable<CalculatorUserIncome> newIncomes = incomes.OrderByDescending(x => x.AgentId);

                var largestAgentIncome = newIncomes.First();

                bool isLargestAgent = i == largestAgentIncome;

                await notificationService.AddNotificationAsync(
                    NotificationTemplate.IncomeFromPaymentAsync(
                        income: i,
                        userName: user.TelegramUsername ?? "NOT_USERNAME",
                        chatId: user.ChatId ?? 0,
                        price: price,
                        userbalance: user.Balance,
                        createServiceTime: DateTime.Now,
                        marzbanVpnName: "AppleId",
                        marzbanUsername: "AppleId",
                        isLargestAgent: isLargestAgent), user.Id);

                await userRepository.UpdateEntity(u);
            }

            AppleId? appleId = await appleIdRepository.GetQuery().FirstOrDefaultAsync();

            if (appleId is null)
                throw new ApplicationException(
                    "⚠️ خطایی در فرآیند خرید رخ داد. در صورت کسر موجودی، مبلغ 💵 به حساب شما بازگردانده خواهد شد. در غیر این صورت، لطفاً با پشتیبانی 📞 تماس بگیرید.");

            appleId.UserId = user.Id;
            appleId.OrderId = order.Id;

            await appleIdRepository.UpdateEntity(appleId);
            await appleIdRepository.SaveChanges(user.Id);

            await transaction.CommitAsync();

            return appleId;
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw new ApplicationException(
                "⚠️ خطایی در فرآیند خرید رخ داد. در صورت کسر موجودی، مبلغ 💵 به حساب شما بازگردانده خواهد شد. در غیر این صورت، لطفاً با پشتیبانی 📞 تماس بگیرید.");
        }
    }

    public async Task<FilterAppleId> FilterAppleIdListAsync(FilterAppleId filter)
    {
          var query = from appleId in appleIdRepository.GetQuery().Where(x => x.IsDelete == false)
                join createByUser in userRepository.GetQuery().Where(x => x.IsDelete == false)
                on appleId.CreateBy equals createByUser.Id into createByGroup
                from createByUser in createByGroup.DefaultIfEmpty()
                
                join modifyByUser in userRepository.GetQuery().Where(x => x.IsDelete == false)
                on appleId.ModifyBy equals modifyByUser.Id into modifyByGroup
                from modifyByUser in modifyByGroup.DefaultIfEmpty()
                
                select new AppleIdDto
                {
                    Id = appleId.Id,
                    Email = appleId.Email,
                    Phone = appleId.Phone,
                    Password = appleId.Password,
                    BirthDay = appleId.BirthDay,
                    Question1 = appleId.Question1,
                    Answer1 = appleId.Answer1,
                    Question2 = appleId.Question2,
                    Answer2 = appleId.Answer2,
                    Question3 = appleId.Question3,
                    Answer3 = appleId.Answer3,
                    UserId = appleId.UserId,
                    OrderId = appleId.OrderId,
                    CreateBy = createByUser != null ? createByUser.FirstName + " " + createByUser.LastName : null,
                    ModifyBy = modifyByUser != null ? modifyByUser.FirstName + " " + modifyByUser.LastName : null,
                    CreateDate = appleId.CreateDate,
                    ModifiedDate = appleId.ModifiedDate,
                    Status = appleId.UserId != null ? "not-active" : "active"
                };

    if ((filter.UserId ?? 0) != 0)
        query = query.Where(i => i.UserId == filter.UserId);

    if (!string.IsNullOrEmpty(filter.Email))
        query = query.Where(x => EF.Functions.Like(x.Email, $"%{filter.Email}%"));

    IQueryable<AppleIdDto> appleIds = query;
    
    await filter.Paging(appleIds);
    
    return filter;
    }

    public async Task<AppleId?> GetAppleIdByIdAsync(long id, long userId)
    {
        return
            await appleIdRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == id && x.UserId == userId);
    }

    public async Task<AppleId?> AddAppleIdAsync(AddAppleIdDto appleId, long userId)
    {
        var appleIdByEmail =
            await appleIdRepository.GetQuery().SingleOrDefaultAsync(x => x.Email == appleId.Email.Trim());

        if (appleIdByEmail is not null) throw new ExistsException($"exist apple id by email {appleId.Email}");

        AppleId currentAppleId = appleId.GenerateAppleId();

        await appleIdRepository.AddEntity(currentAppleId);
        await appleIdRepository.SaveChanges(userId);

        return currentAppleId;
    }
}