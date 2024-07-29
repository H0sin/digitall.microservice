using System.Text;
using Application.Http.Request;
using Application.Services.Interface.Sanaei;
using Application.Services.Interface.Server;
using Application.Static;
using Domain.DTOs.Sanaei;
using Domain.DTOs.Sanaei.Base;
using Domain.DTOs.Sanaei.Client;
using Domain.DTOs.Sanaei.Inbound;
using Domain.DTOs.Server;
using Domain.Entities.Sanaei;
using Domain.Exceptions;
using Domain.IRepositories.Sanaei;
using Domain.IRepositories.Vpn;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;

namespace Application.Services.Implementation.Sanaei;

public class SanaeiService(
    IServerService serverService,
    IVpnRepository vpnRepository,
    IInboundRepository inboundRepository,
    IClientRepository clientRepository,
    IVpnCountryRepository vpnCountryRepository) : ISanaeiService
{
    public async Task<List<SanaeiInboundDto>> GetInboundsListAsync(long serverId)
    {
        ServerDto? server = await serverService.GetServerByIdAsync(serverId);

        SanaeiDto<List<SanaeiInboundDto>> response =
            await RequestHandler.GetRequestAsync<SanaeiDto<List<SanaeiInboundDto>>>(PathUri.InboundsList, server);

        return response.Obj;
    }

    public async Task<InboundDto> GetInboundByServerInboundId(long serverId, long sanaeiInboundId)
    {
        Inbound? inbound = await inboundRepository.GetQuery()
            .SingleOrDefaultAsync(x => x.SanaeiInboundId == sanaeiInboundId && x.ServerId == serverId);

        if (inbound == null) throw new LogicException("این inbound وجود ندارد");

        return new InboundDto()
        {
            Id = inbound.Id
        };
    }

    public async Task<bool> DeleteInboundAsync(long inboundId)
    {
        Inbound? inbound = await inboundRepository.GetEntityById(inboundId);

        if (inbound is null) throw new NotFoundException("این inbound وجود ندارد");

        ServerDto? server = await serverService.GetServerByIdAsync(inbound.ServerId);

        SanaeiDto response =
            await RequestHandler.PostRequestAsync<SanaeiDto>(PathUri.DeleteInbound + "/" + inbound.SanaeiInboundId,
                new { },
                server);

        if (response.Success)
        {
            inboundRepository.DeleteEntity(inbound);
            await inboundRepository.SaveChanges(0);
            return true;
        }

        throw new LogicException($"{response.Msg}");
    }

    public async Task DeleteInboundAsync(long inboundId, long serverId)
    {
        ServerDto? server = await serverService.GetServerByIdAsync(serverId);
        await RequestHandler.PostRequestAsync<SanaeiDto>(PathUri.DeleteInbound + "/" + inboundId,
            new { },
            server);
    }

    public async Task<string> GetSanaeiConfigAsync(long clientId, long serverId)
    {
        ServerDto? server = await serverService.GetServerByIdAsync(serverId);

        Client? _client = await clientRepository.GetEntityById(clientId);

        if (_client is null)
            throw new AppException("چنین کانفیگی وجود ندارد");

        using var client = new HttpClient();

        string path = server.SubDomain + ":" + server.SubPort + "/" + server.SubPath + "/" + _client.SubId;

        HttpResponseMessage? response =
            await client.GetAsync(path);

        string result = await response.Content.ReadAsStringAsync();

        return result;
    }

    public async Task<string> GetClientConfigAsync(GetClientDto client)
    {
        List<Client> clients = await clientRepository.GetQuery().Where(x => x.OrderDetailId == client.OrderDetailsId)
            .ToListAsync();

        List<IGrouping<string, Client>> _clients = new();

        if (client.ServerId != 0)
        {
            _clients = clients
                .Where(x => x.ServerId == client.ServerId)
                .GroupBy(x => x.SubId)
                .ToList();
        }
        else
        {
            var s = clients
                .GroupBy(x => new { x.SubId, x.ServerId }).ToList();
        }

        if (clients.Count == 0)
        {
            throw new NotFoundException("این کانفیگ وجود ندارد");
        }

        StringBuilder stringBuilder = new StringBuilder();

        foreach (Client _client in clients)
        {
            string config = await GetSanaeiConfigAsync(_client.Id, _client.ServerId);
            stringBuilder.AppendLine(config);
        }

        return "";
    }

    public async Task<InboundDto> GetInboundByIdAsync(long serverId, long inboundId)
    {
        ServerDto? server = await serverService.GetServerByIdAsync(serverId);

        Inbound? inbound = await inboundRepository.GetQuery().SingleOrDefaultAsync(x =>
            x.ServerId == serverId && x.Id == inboundId);

        if (inbound is null) throw new LogicException("این inboound وجود ندارد");

        SanaeiDto<InboundDto> response =
            await RequestHandler.GetRequestAsync<SanaeiDto<InboundDto>>(
                PathUri.Inbounds + "/get/" + inbound.SanaeiInboundId, server);

        if (response.Success)
            return response.Obj;

        throw new LogicException("خطا در دریافت اطلاعات این inbound");
    }

    public async Task AddInboundAsync(AddInboundDto addInbound, long userId)
    {
        await using IDbContextTransaction
            transaction = await inboundRepository.context.Database.BeginTransactionAsync();

        ServerDto? server = await serverService.GetServerByIdAsync(addInbound.ServerId);

        object body = new
        {
            enable = addInbound.Inbound.Enable,
            remark = addInbound.Inbound.Remark,
            listen = addInbound.Inbound.Listen,
            port = addInbound.Inbound.Port,
            protocol = addInbound.Inbound.Protocol,
            expiryTime = addInbound.Inbound.ExpiryTime,
            settings = addInbound.Inbound.Settings,
            streamSettings = addInbound.Inbound.StreamSettings,
            sniffing = addInbound.Inbound.Sniffing
        };


        SanaeiDto<InboundDto> response =
            await RequestHandler.PostRequestAsync<SanaeiDto<InboundDto>>(PathUri.AddInbound, body, server);

        if (response.Success)
        {
            Inbound inbound = new()
            {
                SanaeiInboundId = response.Obj.Id,
                ServerId = addInbound.ServerId,
                Enable = addInbound.Inbound.Enable,
                ExpiryTime = addInbound.Inbound.ExpiryTime,
                Port = addInbound.Inbound.Port,
                Listen = addInbound.Inbound.Listen,
                Remark = addInbound.Inbound.Remark,
                Protocol = addInbound.Inbound.Protocol,
                Up = addInbound.Inbound.Up,
                Down = addInbound.Inbound.Down,
                Total = addInbound.Inbound.Total
            };

            await inboundRepository.AddEntity(inbound);
            await inboundRepository.SaveChanges(userId);

            List<Client> clients = new();

            var clientsObj = JsonConvert.DeserializeObject<GetClientInbound>(response.Obj.Settings);

            foreach (AddClientDto client in clientsObj.Clients)
            {
                clients.Add(new()
                {
                    ServerId = addInbound.ServerId,
                    InboundId = inbound.Id,
                    Inbound = inbound,
                    Email = client.Email,
                    Password = client.Password,
                    ExpiryTime = client.ExpiryTime,
                    SubId = client.SubId,
                    Enable = client.Enable,
                    Name = client.Email,
                    CountryId = server.CountryId
                });
            }

            await clientRepository.AddEntities(clients);
            await clientRepository.SaveChanges(userId);

            await transaction.CommitAsync();
        }
        else
        {
            await transaction.RollbackAsync();
            await DeleteInboundAsync(response.Obj.Id, server.Id);
            throw new LogicException($"{response.Msg}");
        }
    }

    public async Task UpdateInboundAsync(UpdateInboundDto updateInbound, long userId)
    {
        await using IDbContextTransaction
            transaction = await inboundRepository.context.Database.BeginTransactionAsync();

        Inbound? upInbound = await inboundRepository.GetEntityById(updateInbound.Id);

        if (upInbound is null) throw new NotFoundException("این inbound وجود ندارد");

        ServerDto? server = await serverService
            .GetServerByIdAsync(upInbound.ServerId);

        InboundDto inbound = await GetInboundByIdAsync(upInbound.ServerId, upInbound.SanaeiInboundId);

        object body = new
        {
            updateInbound.Enable,
            updateInbound.Remark,
            updateInbound.Listen,
            updateInbound.Port,
            updateInbound.Protocol,
            updateInbound.ExpiryTime,
            inbound.Settings,
            inbound.StreamSettings,
            inbound.Sniffing
        };

        SanaeiDto<InboundDto> response =
            await RequestHandler.PostRequestAsync<SanaeiDto<InboundDto>>(PathUri.UpdateInbound + "/" + inbound.Id, body,
                server);

        if (response.Success)
        {
            upInbound.Protocol = response.Obj.Protocol;
            upInbound.Down = response.Obj.Down;
            upInbound.Listen = response.Obj.Listen;
            upInbound.Enable = response.Obj.Enable;
            upInbound.Port = response.Obj.Port;
            upInbound.Remark = response.Obj.Remark;
            upInbound.Total = response.Obj.Total;

            await inboundRepository.UpdateEntity(upInbound);
            await inboundRepository.SaveChanges(userId);

            await transaction.CommitAsync();
        }
        else
        {
            await transaction.RollbackAsync();
            throw new LogicException($"{response.Msg}");
        }
    }

    public async Task<bool> AddClientAsync(AddClientOptionsDto addClient)
    {
        try
        {
            Domain.Entities.Vpn.Vpn? vpn = await vpnRepository.GetEntityById(addClient.VpnId);

            ServerDto server = await serverService.GetServerByIdAsync(addClient.ServerId);

            if (vpn is null) throw new NotFoundException("وی پی انی با این شناسه یافت نشد");

            List<SanaeiInboundDto> inbounds = await GetInboundsListAsync(addClient.ServerId);

            DateTime dateTime = new DateTime().AddDays(vpn.Days);

            long unixTimestamp = (long)(dateTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                .TotalMilliseconds;

            foreach (SanaeiInboundDto inbound in inbounds)
            {
                List<Client> clinetsEntity = new();

                List<AddClientDto> clients = new();

                InboundDto _inbound = await GetInboundByServerInboundId(server.Id, inbound.Id);

                for (int i = 0; i < addClient.Count; i++)
                {
                    long? lastItem = inbound.ClientStats.LastOrDefault()?.Id ?? 0;
                    string email = inbound.Remark + " "
                                                  + addClient.Client.Email
                                                  + " "
                                                  + (lastItem + i)
                                                  + new Random().Next(1000, 9999);

                    string clientId = Guid.NewGuid().ToString("N");

                    clients.Add(new()
                    {
                        Id = clientId,
                        Email = email,
                        Enable = true,
                        ExpiryTime = unixTimestamp,
                        AlterId = 1,
                        LimitIp = vpn.NumberUser,
                        SubId = addClient.Guids[i],
                        Password = Guid.NewGuid().ToString("N"),
                        TgId = "",
                        TotalGb = vpn.TotoalGb
                    });

                    clinetsEntity.Add(new()
                    {
                        ServerId = addClient.ServerId,
                        SanaeiClientId = clientId,
                        Email = email,
                        Enable = true,
                        ExpiryTime = unixTimestamp,
                        SubId = addClient.Guids[i],
                        Password = Guid.NewGuid().ToString("N"),
                        TotalGb = vpn.TotoalGb,
                        CountryId = addClient.CountryId,
                        InboundId = _inbound.Id,
                        OrderDetailId = addClient.OrderDetailId,
                        Name = server.ServerName
                    });
                }

                object body = new BaseRequestSanaei()
                {
                    Id = inbound.Id,
                    Settings = JsonConvert.SerializeObject(new { clients }, Formatting.Indented)
                };

                SanaeiDto response =
                    await RequestHandler.PostRequestAsync<SanaeiDto>(PathUri.AddClient, body,
                        new ServerDto()
                        {
                            ServerAddress = server.ServerAddress,
                            Password = server.Password,
                            Port = server.Port,
                            UserName = server.UserName,
                            ServerName = server.ServerName,
                            ServerStatus = server.ServerStatus,
                            Id = server.Id
                        });

                if (response.Success)
                {
                    await clientRepository.AddEntities(clinetsEntity);
                    await clientRepository.SaveChanges(addClient.UserId);
                    // foreach (var client in clinetsEntity)
                    // {
                    //     if (!Directory.Exists(PathExtension.FileOriginOriginServer))
                    //     {
                    //         Directory.CreateDirectory(PathExtension.FileOriginOriginServer);
                    //     }
                    //
                    //     if (!File.Exists(PathExtension.FileOriginOriginServer + client.SubId + ".txt"))
                    //     {
                    //         using (StreamWriter writer =
                    //                File.CreateText(PathExtension.FileOriginOriginServer + client.SubId + ".txt"))
                    //         {
                    //             string _config = await GetSanaeiConfigAsync(client.Id, client.ServerId);
                    //             writer.WriteLine(_config);
                    //         }
                    //     }
                    //     else
                    //     {
                    //         using (StreamWriter writer =
                    //                File.AppendText(PathExtension.FileOriginOriginServer + client.SubId + ".txt"))
                    //         {
                    //             string _config = await GetSanaeiConfigAsync(client.Id, client.ServerId);
                    //             writer.WriteLine(_config);
                    //         }
                    //     }
                    // {
                    //     // Create the file and use streamWriter to write text to it.
                    //     //If the file existence is not check, this will overwrite said file.
                    //     //Use the using block so the file can close and vairable disposed correctly
                    //     using (StreamWriter writer = File.CreateText(fileName)) 
                    //     {
                    //         writer.WriteLine("Hello World");
                    //     }	
                    // }
                    // else
                    // {
                    //     // Append text to the file
                    //     // using (StreamWriter writer = File.AppendText(fileName))
                    //     // {
                    //     //     writer.WriteLine("Hello World");
                    //     // }
                    // }
                    // }
                }
                else
                {
                    throw new LogicException($"{response.Msg}");
                }
            }
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}