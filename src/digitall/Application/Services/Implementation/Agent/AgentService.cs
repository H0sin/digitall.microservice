using Application.Services.Interface.Agent;
using Application.Extensions;
using Application.Services.Interface.Notification;
using Application.Static.Template;
using Data.DefaultData;
using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Enums.Agent;
using Domain.Exceptions;
using Domain.IRepositories.Account;
using Domain.IRepositories.Agent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Services.Implementation.Agent;

public class AgentService(
    IAgentRepository agentRepository,
    IUserRepository userRepository,
    INotificationService notificationService) : IAgentService
{
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
            .SingleOrDefaultAsync(x => x.Id == id);

        return agent switch
        {
            null => null,
            _ => new AgentDto(agent)
        };
    }

    public async Task<AgentDto> GetAgentByUserIdAsync(long userId)
    {
        User? user = await userRepository.GetEntityById(userId);

        return await GetAgentByIdAsync(user.AgentId);
    }

    public async Task AddAgentRequestAsync(AddRequestAgentDto request, long userId)
    {
        if (await GetAgentByAdminId(userId) is not null)
            throw new ExistsException("شما قبلا درخواستی ثبت کردید");

        AgentDto? parent = await GetAgentByUserIdAsync(userId);

        Domain.Entities.Agent.Agent agent = new()
        {
            BrandAddress = request.BrandAddress,
            BrandName = request.BrandName,
            PersianBrandName = request.PersianBrandName,
            AgentPercent = request.AgentPercent,
            AgentAdminId = userId,
            AgentPath = parent.AgentPath,
            UserPercent = request.UserPercent
        };

        await agentRepository.AddEntity(agent);
        await agentRepository.SaveChanges(userId);

        agent.AgentPath = HierarchyId.Parse(parent.AgentPath + agent.Id.ToString() + "/");

        await agentRepository.UpdateEntity(agent);
        await agentRepository.SaveChanges(userId);

        User? user = await userRepository.GetEntityById(userId);
        await notificationService.AddNotificationAsync(
            NotificationTemplate.NewRequestForAgent(parent.AgentAdminId, user!.UserFullName()), userId);
    }

    public async Task UpdateAgentRequest(UpdateAgentRequestDto agent, long userId)
    {
        AgentDto? parent = await GetAgentByAdminId(userId);
        Domain.Entities.Agent.Agent? ag = await agentRepository.GetEntityById(agent.Id);

        if (ag?.AgentPath?.GetAncestor(1) != parent?.AgentPath)
            throw new NotFoundException("نمیاندگی وجود ندارد");

        if (ag is null) throw new NotFoundException("نمیاندگی وجود ندارد");

        if (ag.AgentRequestStatus.ToLower() == "accept")
            throw new BadRequestException("نمیتوانید کاربری که در خواست ان را قبول کردید تغییر بدهید.");

        ag!.AgentRequestStatus = agent.AgentRequestStatus;
        await agentRepository.UpdateEntity(ag);
        await agentRepository.SaveChanges(1);
        string status = agent.AgentRequestStatus.ToLower() == "accept" ? "پذیرفته" : "رد شده";
        await notificationService.AddNotificationAsync(NotificationTemplate.ChangeRequestAgent(ag.AgentAdminId, status),
            userId);
    }

    public async Task<AgentTreeDto?> GetAgentsChildByFilterAsync(long userId)
    {
        AgentDto? agent = await GetAgentByAdminId(userId);
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
                CardNumber = agent.CardNumber,
                MaximumAmount = agent.MaximumAmount,
                MinimalAmount = agent.MinimalAmount,
                CardHolderName = agent.CardHolderName
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

    public async Task<AgentDto?> GetAgentByAdminId(long adminId)
    {
        Domain.Entities.Agent.Agent? agent =
            await agentRepository.GetQuery().FirstOrDefaultAsync(x => x.AgentAdminId == adminId);

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
            AgentDto? agent = await GetAgentByAdminId(filter.AdminId ?? 0);
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

    public async ValueTask DisposeAsync()
    {
        await agentRepository.DisposeAsync();
        await userRepository.DisposeAsync();
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
            CardNumber = agent.CardNumber,
            AgentRequestStatus = agent.AgentRequestStatus,
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