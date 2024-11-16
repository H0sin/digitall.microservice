using Application.Helper;
using Application.Services.Interface.Agent;
using Application.Services.Interface.Apple;
using Application.Services.Interface.Authorization;
using Application.Services.Interface.Notification;
using Application.Static.Template;
using Data.DefaultData;
using Data.Migrations;
using Domain.DTOs.Account;
using Domain.DTOs.Apple;
using Domain.DTOs.Notification;
using Domain.Entities.Account;
using Domain.Entities.Apple;
using Domain.Entities.Order;
using Domain.Entities.Transaction;
using Domain.Enums.Notification;
using Domain.Enums.Order;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Apple;
using Domain.IRepositories.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation.Apple;

public class AppleService(
    IAgentService agentService,
    IAppleIdRepository appleIdRepository,
    IUserRepository userRepository,
    IOrderRepository orderRepository,
    IOrderDetailRepository orderDetailRepository,
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
                // .Where(x => x.AppleIds!.Count(s => s.UserId == null) > 1)
                .Include(z => z.AppleIds)
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
        return await appleIdTypeRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<GetAppleIdTypeDto> GetAppleIdTypeByIdAsync(long id, long userId)
    {
        AppleIdType? appleIdType = await GetAppleIdTypeByIdAsync(id);

        GetAppleIdTypeDto appleIdTypeDto = new GetAppleIdTypeDto(appleIdType);

        if (appleIdType is null) throw new ApplicationException("سرویس در دست رس نیست !");
        CountingVpnPrice countingVpnPrice = new();

        var price = await countingVpnPrice.CalculateFinalPrice(agentService, userId, appleIdType.Price);

        appleIdTypeDto.Price = price;

        return new GetAppleIdTypeDto(appleIdType);
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

            GetAppleIdTypeDto appleIdType = await GetAppleIdTypeByIdAsync(id, user.Id);

            price = appleIdType.Price;
            // await countingVpnPrice.CalculateFinalPrice(agentService, user.Id, appleIdType.Price);
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

            AppleId? appleId = await appleIdRepository
                .GetQuery()
                .FirstOrDefaultAsync(x => x.UserId == null && x.AppleIdTypeId == appleIdType.Id);

            if (appleId is null)
                throw new ApplicationException("""
                                               ⚠️ اپل آیدی در انبار موجود نیست. در صورت کسر موجودی 💵، مبلغ به حساب شما بازگردانده خواهد شد.  
                                               در غیر این صورت، لطفاً با پشتیبانی 📞 تماس بگیرید.  
                                               """);

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
            throw new ApplicationException(e.Message);
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
        return await appleIdRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.Id == id && x.UserId == userId);
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

    public async Task<bool> SendToWarrantyAppleId(long id, User? user)
    {
        try
        {
            AppleId? appleId = await appleIdRepository.GetEntityById(id);

            if (appleId is null) throw new NotFoundException("not found apple id");

            appleId.SendToWarranty = true;

            string? roleName = RoleItems.Roles.SingleOrDefault(x => x.Id == 4).Title;

            await notificationService.AddNotificationForRole(
                NotificationTemplate.WarrantyNotificationForSupports(appleId), roleName);

            await appleIdRepository.UpdateEntity(appleId);
            await appleIdRepository.SaveChanges(user.Id);

            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<bool> SendToWrongInformationAppleId(long id, User user)
    {
        try
        {
            AppleId? appleId = await appleIdRepository.GetEntityById(id);

            if (appleId is null) throw new NotFoundException("not found apple id");

            appleId.SendToWarranty = true;

            string? roleName = RoleItems.Roles.SingleOrDefault(x => x.Id == 4).Title;

            await notificationService.AddNotificationForRole(
                NotificationTemplate.WarrantyNotificationForSupports(appleId), roleName);

            await appleIdRepository.UpdateEntity(appleId);
            await appleIdRepository.SaveChanges(user.Id);

            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<AppleIdDto?> AssignToMeAsync(long id, long? userId = null, long? chatId = null)
    {
        AppleId? appleId = await appleIdRepository.GetEntityById(id);

        if (appleId is null) throw new NotFoundException("اپل آیدی یافت نشد");

        User? user = userId is null
            ? await userRepository.GetQuery().SingleOrDefaultAsync(x => x.ChatId == chatId)
            : await userRepository.GetEntityById(userId ?? 0);

        if (await GetAppleIdAssignToSupportAsync(user.Id) is not null)
            throw new ExistsException("شما یک اپل ایدی را قبلا ثبت کردید برای برسی .");

        if (appleId.AssignSupporterUserId is not null & appleId.AssignSupporterUserId != user.Id)
            throw new AppException("این اپل ایدی توسط پشتیبانی دیگری در حال برسی است");

        appleId.AssignSupporterUserId = user.Id;

        await appleIdRepository.UpdateEntity(appleId);
        await appleIdRepository.SaveChanges(user.Id);

        return new AppleIdDto(appleId);
    }

    public async Task<AppleIdDto?> GetAppleIdAssignToSupportAsync(long supportId)
    {
        var appleId = await appleIdRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.AssignSupporterUserId == supportId);

        return appleId switch
        {
            null => null,
            _ => new AppleIdDto(appleId)
        };
    }

    public async Task<AppleIdInformationDto?> GetAppleIdInformation(long id)
    {
        try
        {
            AppleId? appleId = await appleIdRepository
                .GetQuery()
                .Include(c => c.AppleIdType)
                .SingleOrDefaultAsync(x => x.Id == id);

            if (appleId is null) throw new NotFoundException("not found apple id");

            appleId.SendToWarranty = true;

            User? user = await userRepository.GetEntityById(appleId.UserId ?? 0);

            OrderDetail? orderDetail =
                await orderDetailRepository.GetQuery()
                    .FirstOrDefaultAsync(x => x.OrderId == appleId.OrderId);

            return new AppleIdInformationDto(user, orderDetail, appleId);
        }
        catch
        {
            return null;
        }
    }

    public async Task RejectWarrantyRequestAsync(long id, string message, long userId)
    {
        AppleId? appleId = await appleIdRepository.GetEntityById(id);

        appleId.SendToWarranty = false;
        appleId.AssignSupporterUserId = null;

        AddNotificationDto notification = new()
        {
            Message = $"""
                       ❌ درخواست گارانتی شما برای اپل آیدی  
                       📧 ایمیل: {appleId.Email}  
                       به دلیل زیر رد شده است:  

                       📝 دلیل: {message}  
                       
                       🌟 با احترام، تیم پشتیبانی  
                       """,
            NotificationType = NotificationType.Alter,
            UserId = appleId.UserId,
        };

        await notificationService.AddNotificationAsync(notification,userId);
        await appleIdRepository.UpdateEntity(appleId);
        await appleIdRepository.SaveChanges(userId);
    }

    public Task ApplyWarrantyServicesAsync(long id, string problem)
    {
        throw new NotImplementedException();
    }
}