using Application.Services.Interface.Agent;
using Application.Exceptions;
using Application.Services.Interface.Account;
using Domain.DTOs.Account;
using Domain.DTOs.Agent;
using Domain.Entities.Account;
using Domain.Enums.Agent;
using Domain.IRepositories.Account;
using Domain.IRepositories.Agent;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Services.Implementation.Agent;

public class AgentService(IAgentRepository agentRepository, IUserRepository userRepository) : IAgentService
{
    #region get

    public async Task<AgentDto?> GetAgentByCode(long agentCode)
    {
        Domain.Entities.Agent.Agent agent =
            (await agentRepository.GetQuery()
                .Include(x => x.Users)
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

        if (agent is null) throw new NotFoundException("چنین نمایندگی وجود ندارد");

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

    public async Task<List<AgentDto>> GetAgentsListAsync()
    {
        return await agentRepository.GetQuery()
            .Include(x => x.Users).Select(u => new AgentDto(u)).ToListAsync();
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

        if (agent is null) throw new NotFoundException("چنین نمایندگی ای وجود ندارد!");

        return new AgentDto(agent);
    }

    #endregion

    #region filter

    public Task<FilterAgentDto> FilterAgentAsync(FilterAgentDto filter)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region add

    public async Task<AddAgentResult> AddAgentAsync(AddAgentDto agent, long userId)
    {
        await using IDbContextTransaction transaction = await agentRepository.context.Database.BeginTransactionAsync();

        User? admin = await userRepository.GetQuery().SingleOrDefaultAsync(x => x.Id == agent.AgentAdminId);

        if (admin is null) throw new NotFoundException("چنین کاربری وجود ندارد! ");

        if (await agentRepository.GetQuery().AnyAsync(x => x.AgentAdminId == agent.AgentAdminId))
            throw new BadRequestException("این کاربرمدیر نمایندگی دیگری است");

        Domain.Entities.Agent.Agent parentAgent = (await agentRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.AgentAdminId == userId))!;

        if (admin.AgentId != parentAgent.Id) return AddAgentResult.Error;

        if (await agentRepository.GetQuery().AnyAsync(x => x.AgentAdminId == agent.AgentAdminId))
            return AddAgentResult.AgentAdminExists;

        Domain.Entities.Agent.Agent newAgent = new Domain.Entities.Agent.Agent
        {
            AgentAdminId = agent.AgentAdminId,
            AgentCode = new Random().Next(100000, 999999),
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

    #endregion

    public async ValueTask DisposeAsync()
    {
        await agentRepository.DisposeAsync();
        await userRepository.DisposeAsync();
    }
}