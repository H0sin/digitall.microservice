using Domain.DTOs.Server;
using Domain.Enums.Server;
using Domain.IRepositories.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.DTOs.Country;
using Application.Services.Interface.Country;
using Application.Services.Interface.Server;
using Domain.Exceptions;

namespace Application.Services.Implementation.Server;

public class ServerService(
    IServerRepository serverRepository,
    ICountryService countryService,
    IConfiguration configuration,
    long userId = 1)
    : IServerService
{
    public long UserId { get; set; } = userId;

    #region add

    public async Task<AddServerResult> AddServerAsync(AddServerDto server)
    {
        if (await serverRepository.GetQuery()
                .AnyAsync(x => x.ServerAddress == server.ServerAddress || x.ServerName == server.ServerName))
            throw new ExistsException("سروری با این نام یا آدرس وجود دارد");

        CountryDto country = await countryService.GetCountryByIdAsync(server.CountryId);

        Domain.Entities.Server.Server newServer = new()
        {
            ServerAddress = server.ServerAddress,
            Password = server.Password,
            UserName = server.UserName,
            ServerName = server.ServerName,
            Port = server.Port,
            CountryId = country.Id,
            ServerStatus = server.ServerStatus,
            SubDomain = server.SubDomain,
            SubPath = server.SubPath,
            SubPort = server.SubPort,
        };

        await serverRepository.AddEntity(newServer);
        await serverRepository.SaveChanges(UserId);

        return AddServerResult.Success;
    }

    #endregion

    #region get

    public async Task<List<ServerDto>> GetServersAsync()
    {
        return await serverRepository.GetQuery()
            .Where(x => x.ServerStatus == ServerStatus.Active)
            .Select(s => new ServerDto(s))
            .ToListAsync();
    }

    public async Task<ServerDto?> GetServerByIdAsync(long serverId)
    {
        Domain.Entities.Server.Server? server = await serverRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.Id == serverId);

        if (server is null) throw new NotFoundException("چنین سروری وجود ندارد");

        return new ServerDto(server);
    }

    #endregion

    #region filter

    public async Task<FilterServerDto> FilterServerAsync(FilterServerDto filter)
    {
        IQueryable<Domain.Entities.Server.Server> query = serverRepository.GetQuery();

        #region conditional

        if (!string.IsNullOrEmpty(filter.ServerAddress))
            query = query.Where(x => EF.Functions
                .Like(x.ServerAddress, $"%{filter.ServerAddress}%"));

        if (!string.IsNullOrEmpty(filter.ServerName))
            query = query.Where(x => EF.Functions
                .Like(x.ServerName, $"%{filter.ServerName}%"));

        #endregion

        IQueryable<ServerDto> servers = query.Select(x => new ServerDto(x));

        await filter.Paging(servers);

        return filter;
    }

    public Task<bool> TestServerAsync(long serverId)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region test

    // public async Task<bool> TestServerAsync(long serverId)
    // {
    //     ServerDto? server = await GetServerByIdAsync(serverId);
    //     PathUri url = new PathUri(server);
    //
    //     await SetCookieHandler(server);
    //
    //     object body = new
    //     {
    //         UserName = server.UserName,
    //         Password = server.Password
    //     };
    //
    //     SanaeiDto response =
    //         await RequestHandler.PostRequestAsync<SanaeiDto>(url.Login, body, _configuration);
    //
    //     return response.Success;
    // }

    #endregion

    #region method

    // private async Task SetCookieHandler(ServerDto? server)
    //     using var client = new HttpClient();
    //
    //     PathUri url = new PathUri(server);
    //
    //     object body = new
    //     {
    //         UserName = server.UserName,
    //         Password = server.Password
    //     };
    //
    //     StringContent content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
    //
    //     HttpResponseMessage? response = await client.PostAsync(url.Login, content);
    //
    //     IEnumerable<string> cookie = response.Headers.SingleOrDefault(x => x.Key == "Set-Cookie").Value;
    //
    //     var listCookie = cookie.ToList()[0].Split(';');
    //
    //     _configuration["Request:CookieToken"] = listCookie[0];
    // }

    #endregion
}