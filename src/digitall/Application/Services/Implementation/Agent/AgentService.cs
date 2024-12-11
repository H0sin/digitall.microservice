using Application.Services.Interface.Agent;
using Application.Extensions;
using Application.Services.Interface.Notification;
using Application.Services.Interface.Telegram;
using Application.Static.Template;
using Application.Utilities;
using Data.DefaultData;
using Data.Repositories.Agent;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.DTOs.Notification;
using Domain.DTOs.Telegram;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Entities.Telegram;
using Domain.Entities.Transaction;
using Domain.Enums.Agent;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Agent;
using Domain.IRepositories.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Services.Implementation.Agent;

public class AgentService(
    IAgentRepository agentRepository,
    IAgentRequestRepository agentRequestRepository,
    IUserRepository userRepository,
    IAgentOptionRepository agentOptionRepository,
    IAgentsIncomesDetailRepository agentsIncomesDetailRepository,
    INotificationService notificationService) : IAgentService
{
    public async Task<AgencyInformationDto> GetMyAgencyInformation(long userId)
    {
        var agent = await agentRepository
            .GetQuery()
            .Include(x => x.TransactionDetail)
            .FirstOrDefaultAsync(x => x.AgentAdminId == userId);

        return new AgencyInformationDto(agent, agent.TransactionDetail);
    }

    public async Task<List<AgentDto>> AgentsReachedNegativeLimit()
    {
        return await agentRepository.GetQuery()
            .Join(userRepository.GetQuery(),
                agent => agent.AgentAdminId,
                user => user.Id,
                (agent, user) => new { Agent = agent, User = user })
            .Where(x => x.User.Balance < -100000 &&
                        x.User.Balance - 100000 < x.Agent.AmountWithNegative)
            .Select(x => new AgentDto(x.Agent))
            .ToListAsync();
    }

    public async Task<List<AgentDto>> AgentsReachedNegativeNotLimit()
    {
        return await agentRepository.GetQuery()
            .Join(userRepository.GetQuery(),
                agent => agent.AgentAdminId,
                user => user.Id,
                (agent, user) => new { Agent = agent, User = user })
            .Where(x => x.User.Balance > x.Agent.AmountWithNegative & x.Agent.DisabledAccountTime != null)
            .Select(x => new AgentDto(x.Agent))
            .ToListAsync();
    }

    public async Task<List<AgentsIncomesDetail>> ListAgentIncomeDetailsByAgentId(long agentId)
        => await agentsIncomesDetailRepository.GetQuery().Where(x => x.AgentId == agentId).ToListAsync();

    public async Task<List<UserDto>?> GetAgentUserAsync(long agentId)
    {
        Domain.Entities.Agent.Agent? agent = await agentRepository
            .GetQuery()
            .Where(x => x.Id == agentId)
            .Include(x => x.Users)
            .FirstOrDefaultAsync();

        return agent?.Users?.Select(x => new UserDto(x)).ToList();
    }

    public async Task AddAgentsIncomesDetailAsync(List<AgentsIncomesDetail> agentsTransactionsDetails, long userId)
    {
        await agentsIncomesDetailRepository.AddEntities(agentsTransactionsDetails);
        await agentsIncomesDetailRepository.SaveChanges(userId);
    }

    public async Task AddAgentsIncomesDetailAsync(AgentsIncomesDetail agentsIncomesDetail, long userId)
    {
        await agentsIncomesDetailRepository.AddEntity(agentsIncomesDetail);
        await agentsIncomesDetailRepository.SaveChanges(userId);
    }

    public async Task<AgentDto?> GetAgentByCode(long agentCode)
    {
        Domain.Entities.Agent.Agent agent =
            (await agentRepository.GetQuery()
                .SingleOrDefaultAsync(x => x.AgentCode == agentCode))!;

        User? user = await userRepository.GetEntityById(agent.AgentAdminId);

        return agent switch
        {
            null => null,
            _ => new AgentDto(agent, user)
        };
    }

    public async Task<AgentDto?> GetAgentByIdAsync(long id)
    {
        Domain.Entities.Agent.Agent? agent = await agentRepository.GetQuery()
            .Include(x => x.Users)
            .Include(c => c.TransactionDetail)
            .SingleOrDefaultAsync(x => x.Id == id);

        User user = await userRepository.GetEntityById(agent.AgentAdminId);
        return agent switch
        {
            null => null,
            _ => new AgentDto(agent, user)
        };
    }

    public async Task<AgentDto?> GetAgentByUserIdAsync(long userId)
    {
        User? user = await userRepository.GetEntityById(userId);
        if (user is null) return null;
        return await GetAgentByIdAsync(user!.AgentId);
    }

    public async Task AddAgentRequestAsync(AddRequestAgentDto request, long userId)
    {
        AgentDto? agent = await GetAgentByAdminIdAsync(userId);

        if (agent is not null)
        {
            throw new ExistsException("شما نماینده هستید");
        }

        if (await agentRequestRepository
                .GetQuery()
                .SingleOrDefaultAsync(x => x.CreateBy == userId) is not null)
            throw new ExistsException("شما نماینده هستید");


        AgentDto? parent = await GetAgentByUserIdAsync(userId);

        if (parent is null)
            parent!.Id = AgentItems.Agents.First().Id;

        AgentRequest req = request._GenerateAgentRequest(userId, parent!.Id);

        await agentRequestRepository.AddEntity(req);
        await agentRequestRepository.SaveChanges(userId);

        User? user = await userRepository.GetEntityById(userId);

        #region buttons

        List<ButtonJsonDto> buttonJsons = new()
        {
            new("تایید درخواست ✅", $"accept_agent_request?id={req.Id}"),
            new("رد درخواست ❌", $"reject_agent_request?id={req.Id}"),
        };

        #endregion

        await notificationService.AddNotificationAsync(
            NotificationTemplate.NewRequestForAgent(parent.AgentAdminId, user.ChatId ?? 0,
                user!.TelegramUsername ?? "NOT_USERNAME",
                request.Phone,
                request.Description ?? "", user!.TelegramUsername ?? "",
                buttonJsons), userId);
    }

    public async Task UpdateAgentRequest(UpdateAgentRequestDto agentRequest, long userId)
    {
        AgentRequest? request = await agentRequestRepository.GetEntityById(agentRequest.Id);

        AgentDto? parent = await GetAgentByIdAsync(request!.AgentId);

        if (request is null) throw new NotFoundException("درخواستی یافت نشد");

        switch (agentRequest.AgentRequestStatus.ToLower())
        {
            case "accept":
                Domain.Entities.Agent.Agent agent = new()
                {
                    TransactionDetail = new()
                    {
                        Description = request.PaymentDescription,
                        CardNumber = request.CardNumber,
                        CardHolderName = request.CardHolderName,
                    },
                    AgentPercent = request.AgentPercent ?? 0,
                    UserPercent = request.UserPercent ?? 0,
                    BrandAddress = request.BrandAddress,
                    BrandName = request.BrandName,
                    PersianBrandName = request.PersianBrandName,
                    AgentAdminId = request.UserId,
                    AgentCode = new Random().Next(10000, 9999999),
                    AmountWithNegative = -50000
                };

                await agentRepository.AddEntity(agent);
                await agentRepository.SaveChanges(userId);

                agent.AgentPath = HierarchyId.Parse(parent.AgentPath + agent.Id.ToString() + "/");

                await agentRepository.UpdateEntity(agent);
                await agentRepository.SaveChanges(userId);

                User? user = await userRepository.GetEntityById(agent.AgentAdminId);
                user.IsAgent = true;

                await userRepository.UpdateEntity(user);
                await userRepository.SaveChanges(userId);

                await notificationService.AddNotificationAsync(
                    NotificationTemplate.ChangeRequestAgent(agent.AgentAdminId, "تایید"),
                    userId);

                break;
            case "reject":
                await notificationService.AddNotificationAsync(
                    NotificationTemplate.ChangeRequestAgent(request.UserId, "رد"),
                    userId);
                break;
        }
    }

    public async Task<AgentTreeDto?> GetAgentsChildByFilterAsync(long userId)
    {
        AgentDto? agent = await GetAgentByAdminIdAsync(userId);
        var mainAgent = await agentRepository.GetEntityById(agent.Id);

        if (mainAgent == null || mainAgent.AgentPath == null)
        {
            return null;
        }

        var allAgents = await agentRepository.GetQuery().ToListAsync();

        var mainAgentDto = await ConvertToTree(mainAgent, allAgents, 0);

        return mainAgentDto;
    }

    public async Task<InformationPaymentDto?> GetAgentInformationPaymentAsync(long userId)
    {
        User? user = await userRepository.GetEntityById(userId);
        Domain.Entities.Agent.Agent? agent =
            await agentRepository
                .GetQuery()
                .FirstOrDefaultAsync(x => x.Id == user.AgentId);

        return agent switch
        {
            null => null,
            _ => new InformationPaymentDto()
            {
                // CardNumber = agent.CardNumber,
                // MaximumAmount = agent.MaximumAmount,
                // MinimalAmount = agent.MinimalAmount,
                // CardHolderName = agent.CardHolderName
            }
        };
    }

    public async Task<Domain.Entities.Agent.Agent?> GetAgentByPathAsync(HierarchyId path)
    {
        return await agentRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.AgentPath == path);
    }

    public async Task<User?> GetAdminAgentUserAsync(long id)
    {
        return await userRepository.GetEntityById(id);
    }

    public async Task<AgentOptionDto?> GetAgentOptionByAgentIdAsync(long id)
    {
        AgentOptions? agent = await agentOptionRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.AgentId == id);

        return new(agent);
    }

    public async Task<List<AgentRequestDto>> GetListAgentRequestAsync(long userId)
    {
        AgentDto? agent = await GetAgentByAdminIdAsync(userId);
        if (agent is null) throw new AppException("شما نماینده نیستید");
        return await agentRequestRepository.GetQuery()
            .Where(x => x.AgentId == agent.Id)
            .Include(x => x.User)
            .Select(x => new AgentRequestDto(x)).ToListAsync();
    }

    public async Task<TelegramLinkDto?> GetAgentTelegramLink(long userId)
    {
        User? user = await userRepository.GetEntityById(userId);
        AgentDto? admin = await GetAgentByAdminIdAsync(userId);

        if (admin is not null)
        {
            Domain.Entities.Agent.Agent? agentAdmin =
                await agentRepository
                    .GetQuery()
                    .Include(x => x.TelegramBot)
                    .SingleOrDefaultAsync(x => x.Id == admin!.Id);

            return new(agentAdmin?.TelegramBot?.Link, agentAdmin?.AgentCode);
        }

        Domain.Entities.Agent.Agent? agent =
            await agentRepository
                .GetQuery()
                .Include(x => x.TelegramBot)
                .SingleOrDefaultAsync(x => x.Id == user!.AgentId);

        return new(agent?.TelegramBot?.Link, agent.AgentCode);
    }

    public async Task<bool> IsAgentAsync(long userId)
    {
        AgentDto? agent = await GetAgentByAdminIdAsync(userId);

        return agent switch
        {
            null => false,
            _ => true
        };
    }

    public async Task<AgentInformationDto?> GetAgentInformationAsync(long userId)
    {
        Domain.Entities.Agent.Agent? agent = await agentRepository
            .GetQuery()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.AgentAdminId == userId);

        if (agent == null)
        {
            return null;
        }

        User? admin = await userRepository.GetEntityById(agent.AgentAdminId);


        var countLevels = await agentRepository
            .GetQuery()
            .Where(a => a.AgentPath != null && a.AgentPath.IsDescendantOf(agent.AgentPath))
            .GroupBy(a => a.AgentPath.GetLevel())
            .Select(g => new { Level = g.Key, Count = g.Count() })
            .ToListAsync();

        int? countAgentLevel_1 =
            countLevels.SingleOrDefault(g => g.Level == agent.AgentPath.GetLevel() + 1)?.Count ?? 0;

        int? countAgentLevel_2 =
            countLevels.SingleOrDefault(g => g.Level == agent.AgentPath.GetLevel() + 2)?.Count ?? 0;

        var profitSum = await agentsIncomesDetailRepository
            .GetQuery()
            .Where(x => x.AgentId == agent.Id)
            .SumAsync(x => x.Profit);

        // long sale = await agentsIncomesDetailRepository.GetQuery().Where(x => x.AgentId == agent.Id).SumAsync(x=>x.Profit);

        return new()
        {
            AdminName = admin.UserFullName(),
            AgentPercent = agent.AgentPercent,
            UserPercent = agent.UserPercent,
            AgentAdminId = agent.AgentAdminId,
            AgentCode = agent.AgentCode,
            BrandAddress = agent.BrandAddress,
            BrandName = agent.BrandName,
            PersianBrandName = agent.PersianBrandName,
            CountUser = await userRepository.GetQuery().Where(x => x.AgentId == agent.Id).CountAsync(),
            Profit = profitSum,
            Sale = profitSum,
            CountAgentLevel_1 = countAgentLevel_1,
            CountAgentLevel_2 = countAgentLevel_2,
        };
    }

    public async Task<bool> UpdateAgentAsync(AgentDto agent, long userId)
    {
        Domain.Entities.Agent.Agent? currentAgent = await agentRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.Id == agent.Id);

        currentAgent!.AgentPercent = agent.AgentPercent;
        currentAgent.UserPercent = agent.UserPercent;
        currentAgent.SpecialPercent = agent.SpecialPercent;
        currentAgent.AmountWithNegative = agent.AmountWithNegative;
        currentAgent.DisabledAccountTime = agent.DisabledAccountTime;

        currentAgent.PersianBrandName = agent.PersianBrandName;
        currentAgent.BrandName = agent.BrandName;

        await agentRepository.UpdateEntity(currentAgent);
        await agentRepository.SaveChanges(userId);

        return true;
    }

    public async Task<bool> HaveRequestAgentAsync(long userId)
    {
        AgentRequest? agentRequest = await agentRequestRepository
            .GetQuery()
            .FirstOrDefaultAsync(x => x.UserId == userId);

        return agentRequest switch
        {
            null => false,
            _ => true
        };
    }

    public async Task<List<AgentDto>> GetAgentsListAsync()
    {
        return await agentRepository.GetQuery()
            .Include(x => x.Users)
            .Select(u => new AgentDto(u)).ToListAsync();
    }

    public async Task<List<long>> GetAgentRoot(long agentId)
    {
        Domain.Entities.Agent.Agent?
            agent = await agentRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == agentId);

        if (agent is null) throw new NotFoundException("نمایندگی با این شناسه وجود ندارد");

        string[] paths = agent?.AgentPath.ToString().Split("/");

        paths = paths.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

        return paths.Select(long.Parse).ToList();
    }

    public async Task<AgentDto?> GetAgentByAdminIdAsync(long? adminId)
    {
        Domain.Entities.Agent.Agent? agent =
            await agentRepository
                .GetQuery()
                .Include(x => x.TransactionDetail)
                .SingleOrDefaultAsync(x => x.AgentAdminId == adminId);

        if (agent is null) return null;

        return new AgentDto(agent);
    }

    public async Task UpdateAgencyAsync(AgencyInformationDto agency, long userId)
    {
        var agent = await agentRepository.GetQuery().Include(y => y.TransactionDetail)
            .SingleOrDefaultAsync(x => x.AgentAdminId == userId);

        if (string.IsNullOrEmpty(agent.BrandName)) throw new AppException("brand name is empty");

        agent.BrandName = agency.BrandName;
        agent.PersianBrandName = agency.PersianBrandName ?? "";
        agent.BrandAddress = agency.BrandAddress ?? "";
        agent.AgentPercent = agency.AgentPercent;
        agent.UserPercent = agency.UserPercent;
        agent.AllowNegative = agency.AllowNegative;
        agent.TransactionDetail.MaximumAmountForAgent = agency.MaximumAmountForAgent;
        agent.TransactionDetail.MaximumAmountForAgent = agency.MaximumAmountForAgent;
        agent.TransactionDetail.MaximumAmountForAgent = agency.MaximumAmountForAgent;
        agent.TransactionDetail.MaximumAmountForAgent = agency.MaximumAmountForAgent;
        agent.TransactionDetail.CardNumber = agency.CardNumber;
        agent.TransactionDetail.CardHolderName = agency.CardHolderName;
        agent.TransactionDetail.Description = agency.Description;

        await agentRepository.UpdateEntity(agent);
        await agentRepository.SaveChanges(userId);
    }

    public async Task<FilterProfitReportDto> FilterProfitReportAsync(FilterProfitReportDto filter,long userId)
    {
        var query = agentsIncomesDetailRepository
            .GetQuery()
            .Where(x => x.UserId == userId);

        if (filter.StartDate is not null)
            query = query.Where(x => x.CreateDate >= filter.StartDate);

        var incomes = query.Select(x => new AgentIncomeDto(x));

        await filter.Paging(incomes);

        return filter;
    }

    public async Task<FilterAgentDto> FilterAgentAsync(FilterAgentDto filter)
    {
        Domain.Entities.Agent.Agent? parent = await
            agentRepository
                .GetQuery()
                .Include(c => c.Users)
                .SingleOrDefaultAsync(x => x.AgentAdminId == filter.AdminId);

        IQueryable<Domain.Entities.Agent.Agent> queryable = agentRepository
            .GetQuery()
            .Where(x => x.AgentPath!.GetAncestor(filter.Ancestor) == parent!.AgentPath);

        if (string.IsNullOrEmpty(filter.PersianBrandName))
            queryable = queryable.Where(a => EF.Functions.Like(a.PersianBrandName, $"%{filter.PersianBrandName}%"));

        var agents = queryable
            .Select(x => new AgentDto(x));

        await filter.Paging(agents);

        foreach (AgentDto agent in filter.Entities)
        {
            User? user = await userRepository.GetEntityById(agent.AgentAdminId);
            agent.User = new UserDto(user);
        }

        return filter;
    }


    public async Task<AddAgentResult> AddAgentAsync(AddAgentDto agent, long userId)
    {
        await using IDbContextTransaction transaction = await agentRepository.context.Database.BeginTransactionAsync();
        try
        {
            User? admin = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == agent.AgentAdminId);

            if (admin is null) throw new NotFoundException("چنین کاربری وجود ندارد! ");

            if (await agentRepository.GetQuery().AnyAsync(x => x.AgentAdminId == agent.AgentAdminId))
                throw new BadRequestException("این کاربرمدیر نمایندگی دیگری است");

            Domain.Entities.Agent.Agent parentAgent = (await agentRepository.GetQuery()
                .SingleOrDefaultAsync(x => x.AgentAdminId == userId))!;

            if (admin.AgentId != parentAgent.Id)
            {
                admin.AgentId = parentAgent.Id;
                await userRepository.UpdateEntity(admin);
                await userRepository.SaveChanges(userId);
            }

            Domain.Entities.Agent.Agent newAgent = new Domain.Entities.Agent.Agent
            {
                AgentAdminId = agent.AgentAdminId,
                AgentCode = new Random().Next(10000, 9999999),
                BrandAddress = agent.BrandAddress,
                BrandName = agent.BrandName,
                PersianBrandName = agent.PersianBrandName,
                AgentPercent = agent.AgentPercent,
                UserPercent = agent.UserPercent,
                AmountWithNegative = -50000,
                TransactionDetail = new()
                {
                    Description = "",
                    CardNumber = "",
                    CardHolderName = "",
                },
            };

            await agentRepository.AddEntity(newAgent);
            await agentRepository.SaveChanges(userId);

            newAgent.AgentPath = HierarchyId.Parse(parentAgent.AgentPath + newAgent.Id.ToString() + "/");

            await agentRepository.UpdateEntity(newAgent);
            await agentRepository.SaveChanges(userId);

            User? user = await userRepository.GetEntityById(newAgent.AgentAdminId);

            if (user.Balance <= 100000)
                throw new AppException("موجودی کاربر برای نمایندگی کافی نیست لطفا کاربر باید 100000 هزار تومن حداقل موجودی داشته باشه");
            
            user.IsAgent = true;

            await userRepository.UpdateEntity(user);
            await userRepository.SaveChanges(userId);

            await notificationService.AddNotificationAsync(new AddNotificationDto()
            {
                Message = "شما با موفقیت نماینده شدید ✅",
                UserId = user.Id,
                Buttons = new()
                {
                    new("مدیریت پنل نمایندگی 🏢", "agency_management")
                },
            }, user.Id);
            
            await transaction.CommitAsync();

            return AddAgentResult.Success;
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw new AppException(e.Message);
        }
    }


    private async Task<AgentTreeDto> ConvertToTree(Domain.Entities.Agent.Agent agent,
        List<Domain.Entities.Agent.Agent> allAgents,
        int level)
    {
        if (level > 2)
        {
            return null;
        }

        User? user = await userRepository.GetEntityById(agent.AgentAdminId);

        var agentDto = new AgentTreeDto()
        {
            Id = agent.Id,
            BrandName = agent.BrandName,
            PersianBrandName = agent.PersianBrandName,
            AgentAdminId = agent.AgentAdminId,
            AgentCode = agent.AgentCode,
            BrandAddress = agent.BrandAddress,
            AgentPercent = agent.AgentPercent,
            UserPercent = agent.UserPercent,
            // TelegramBotId = agent.TelegramBotId,
            AdminName = user?.UserFullName(),
            Mobile = user?.Mobile,
            Email = user?.Email,
            SubAgents = new List<AgentTreeDto>()
        };

        var subAgents = allAgents
            .Where(a => agent.AgentPath != null &&
                        a.AgentPath != null &&
                        a.AgentPath.IsDescendantOf(agent.AgentPath) &&
                        a.AgentPath.GetLevel() == agent.AgentPath.GetLevel() + 1)
            .ToList();

        foreach (var subAgent in subAgents)
        {
            var subAgentDto = await ConvertToTree(subAgent, allAgents, level + 1);

            agentDto.SubAgents.Add(subAgentDto);
        }

        return agentDto;
    }
}