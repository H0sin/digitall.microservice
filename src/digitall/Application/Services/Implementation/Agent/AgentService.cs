using Application.Services.Interface.Agent;
using Application.Extensions;
using Application.Services.Interface.Notification;
using Application.Static.Template;
using Data.DefaultData;
using Data.Repositories.Agent;
using Domain.DTOs.Agent;
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
    public async Task AddAgentsIncomesDetail(List<AgentsIncomesDetail> agentsTransactionsDetails, long userId)
    {
        await agentsIncomesDetailRepository.AddEntities(agentsTransactionsDetails);
        await agentsIncomesDetailRepository.SaveChanges(userId);
    }

    public async Task<AgentDto?> GetAgentByCode(long agentCode)
    {
        Domain.Entities.Agent.Agent agent =
            (await agentRepository.GetQuery()
                .SingleOrDefaultAsync(x => x.AgentCode == agentCode))!;

        return agent switch
        {
            null => null,
            _ => new AgentDto(agent)
        };
    }

    public async Task<AgentDto?> GetAgentByIdAsync(long id)
    {
        Domain.Entities.Agent.Agent? agent = await agentRepository.GetQuery()
            .Include(x => x.Users)
            .Include(c => c.TransactionDetail)
            .SingleOrDefaultAsync(x => x.Id == id);

        return agent switch
        {
            null => null,
            _ => new AgentDto(agent)
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
        if (await GetAgentByAdminIdAsync(userId) is not null)
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
            NotificationTemplate.NewRequestForAgent(parent.AgentAdminId, user!.UserFullName(),
                request.Description ?? "",user!.TelegramUsername ?? "",
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
                        MaximumAmount = request.MaximumAmount,
                        MinimalAmount = request.MinimalAmount,
                        CardHolderName = request.CardHolderName,
                    },
                    AgentPercent = request.AgentPercent ?? 0,
                    UserPercent = request.UserPercent ?? 0,
                    BrandAddress = request.BrandAddress,
                    BrandName = request.BrandName,
                    PersianBrandName = request.PersianBrandName,
                    AgentAdminId = request.UserId
                };

                await agentRepository.AddEntity(agent);
                await agentRepository.SaveChanges(userId);

                agent.AgentPath = HierarchyId.Parse(parent.AgentPath + agent.Id.ToString() + "/");

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
        return await agentRepository.GetQuery().SingleOrDefaultAsync(x => x.AgentPath == path);
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

    public async Task<string?> GetAgentTelegramLink(long userId)
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
            return agentAdmin?.AgentCode.ToString();
        }

        Domain.Entities.Agent.Agent? agent =
            await agentRepository
                .GetQuery()
                .Include(x => x.TelegramBot)
                .SingleOrDefaultAsync(x => x.Id == user!.AgentId);

        return agent?.AgentCode.ToString();
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
            .Include(x => x.Users)
            .Include(x => x.TelegramBot)
            .Include(x => x.AgentsTransactionsDetails)!
            .ThenInclude(x => x.OrderDetail)
            .Include(x => x.TransactionDetail)
            .ThenInclude(x => x!.Transactions)
            .SingleOrDefaultAsync(x => x.AgentAdminId == userId);

        if (agent == null)
        {
            return null;
        }

        User? admin = await userRepository.GetEntityById(agent!.AgentAdminId);

        int? countAgentLevel_1 = await agentRepository
            .GetQuery()
            .Where(a => a.AgentPath != null &&
                        a.AgentPath.IsDescendantOf(agent
                            .AgentPath) && // فرض بر این است که IsDescendantOf متد مربوط به HierarchyId است
                        a.AgentPath.GetLevel() == agent.AgentPath!.GetLevel() + 1) // بررسی سطح پایین‌تر
            .CountAsync();

        int? countAgentLevel_2 = await agentRepository
            .GetQuery()
            .Where(a => a.AgentPath != null &&
                        a.AgentPath.IsDescendantOf(agent
                            .AgentPath) && // فرض بر این است که IsDescendantOf متد مربوط به HierarchyId است
                        a.AgentPath.GetLevel() == agent.AgentPath!.GetLevel() + 2) // بررسی سطح پایین‌تر
            .CountAsync();

        return new()
        {
            AdminName = admin.UserFullName(),
            AgentPercent = agent.AgentPercent,
            UserPercent = agent.UserPercent,
            TelegramBotId = agent.TelegramBotId,
            AgentAdminId = agent.AgentAdminId,
            AgentCode = agent.AgentCode,
            BrandAddress = agent.BrandAddress,
            BrandName = agent.BrandName,
            PersianBrandName = agent.PersianBrandName,
            BotName = agent.TelegramBot?.PersionName ?? null,
            BotToken = agent.TelegramBot?.Token ?? null,
            CountUser = agent.Users?.Count() ?? 0,
            Profit = agent!.AgentsTransactionsDetails?.Sum(x => x.Profit) ?? 0,
            Sale = agent!.AgentsTransactionsDetails?.Sum(x => x.OrderDetail.ProductPrice) ?? 0,
            CountAgentLevel_1 = countAgentLevel_1,
            CountAgentLevel_2 = countAgentLevel_2,
            BotId = agent.TelegramBotId
        };
    }

    public async Task<bool> UpdateAgentAsync(AgentDto agent, long userId)
    {
        Domain.Entities.Agent.Agent? currentAgent = await agentRepository
            .GetQuery()
            .SingleOrDefaultAsync(x => x.AgentAdminId == userId);

        // if (agent.AgentAdminId != userId)
        //     throw new NotFoundException("چنین نمایندگی وجود ندارد");

        currentAgent!.AgentPercent = agent.AgentPercent;
        currentAgent!.UserPercent = agent.UserPercent;

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

    public async Task<FilterAgentDto> FilterAgentAsync(FilterAgentDto filter)
    {
        IQueryable<Domain.Entities.Agent.Agent> queryable = agentRepository
            .GetQuery();

        if (string.IsNullOrEmpty(filter.PersianBrandName))
            queryable = queryable.Where(a => EF.Functions.Like(a.PersianBrandName, $"%{filter.PersianBrandName}%"));

        if (filter.AdminId is not null and not 0)
        {
            AgentDto? agent = await GetAgentByAdminIdAsync(filter.AdminId ?? 0);
        }

        return filter;
    }


    public async Task<AddAgentResult> AddAgentAsync(AddAgentDto agent, long userId)
    {
        await using IDbContextTransaction transaction = await agentRepository.context.Database.BeginTransactionAsync();

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

        if (await agentRepository.GetQuery().AnyAsync(x => x.AgentAdminId == agent.AgentAdminId))
            return AddAgentResult.AgentAdminExists;

        Domain.Entities.Agent.Agent newAgent = new Domain.Entities.Agent.Agent
        {
            AgentAdminId = agent.AgentAdminId,
            AgentCode = new Random().Next(10000, 9999999),
            BrandAddress = agent.BrandAddress,
            BrandName = agent.BrandName,
            PersianBrandName = agent.PersianBrandName,
            AgentPercent = agent.Percent
        };

        await agentRepository.AddEntity(newAgent);
        await agentRepository.SaveChanges(userId);

        newAgent.AgentPath = HierarchyId.Parse(parentAgent.AgentPath + newAgent.Id.ToString() + "/");

        await agentRepository.UpdateEntity(newAgent);
        await agentRepository.SaveChanges(userId);

        await transaction.CommitAsync();

        return AddAgentResult.Success;
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
            TelegramBotId = agent.TelegramBotId,
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