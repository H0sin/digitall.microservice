// using Application.Services.Interface.Agent;
// using Application.Services.Interface.Marzban;
// using Domain.DTOs.Account;
// using Domain.DTOs.Agent;
// using Domain.DTOs.Marzban;
// using Domain.DTOs.Transaction;
// using Domain.Entities.Account;
// using Domain.Entities.Agent;
// using Domain.Entities.Marzban;
// using Domain.Entities.Transaction;
// using Domain.Exceptions;
// using Microsoft.EntityFrameworkCore;
//
// namespace Application.Helper;
//
// public class Percent(IAgentService agentService, IMarzbanService? marzbanService = null) : IDisposable
// {
//     // public async Task<>
//
//     public async Task<List<MarzbanVpnTemplateDto?>> CalcuteVpnTemplatePrice(List<MarzbanVpnTemplateDto>? marzbanVpn,
//         long userId,
//         int numberOfAgents = 2)
//     {
//         try
//         {
//             if (marzbanVpn.Count > 0)
//             {
//                 AgentDto? admin = await agentService
//                     .GetAgentByAdminIdAsync(userId);
//
//                 AgentDto? agent =
//                     await agentService.GetAgentByUserIdAsync(userId);
//
//                 if (agent == null)
//                     throw new NotFoundException("نمایندگی شم غیر فعال شده است");
//
//                 double totalMultiplier = 1.0;
//
//                 for (int i = 0; i < numberOfAgents; i++)
//                 {
//                     HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
//                     Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
//
//                     if (agentByPath != null)
//                     {
//                         double percent = (admin != null
//                             ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
//                             : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
//                         totalMultiplier *= percent != 1 ? 1 + (percent / 100.0) : 1;
//                     }
//                 }
//
//                 foreach (var mv in marzbanVpn)
//                 {
//                     mv.Price = Convert.ToInt64(mv.Price * totalMultiplier);
//                 }
//             }
//
//             return marzbanVpn;
//         }
//         catch (Exception e)
//         {
//             throw new AppException(e.Message);
//         }
//     }
//
//
//     public async Task<List<MarzbanVpn?>> CalcuteVpnPrice(List<MarzbanVpn?> marzbanVpn, long userId,
//         int numberOfAgents = 2)
//     {
//         if (marzbanVpn.Count > 0)
//         {
//             AgentDto? admin = await agentService
//                 .GetAgentByAdminIdAsync(userId);
//
//             AgentDto? agent =
//                 await agentService.GetAgentByUserIdAsync(userId);
//
//             if (agent == null)
//                 throw new NotFoundException("نمایندگی شم غیر فعال شده است");
//
//             double totalMultiplier = 1.0;
//
//             for (int i = 0; i < numberOfAgents; i++)
//             {
//                 HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
//                 Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
//
//                 if (agentByPath != null)
//                 {
//                     double percent = (admin != null
//                         ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
//                         : (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent));
//                     totalMultiplier *= percent != 1 ? 1 + (percent / 100.0) : 1;
//                 }
//             }
//
//             foreach (var mv in marzbanVpn)
//             {
//                 mv.DayPrice = Convert.ToInt64(mv.DayPrice * totalMultiplier);
//                 mv.GbPrice = Convert.ToInt64(mv.GbPrice * totalMultiplier);
//             }
//         }
//
//         return marzbanVpn;
//     }
//
//     public async Task<MarzbanVpnDto?> CalcuteVpnPrice(long vpnId, long userId, int numberOfAgents = 2)
//     {
//         AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
//
//         AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);
//
//         if (agent == null)
//             throw new NotFoundException("نمایندگی شما غیر فعال شده است");
//
//         double totalMultiplier = 1.0;
//
//         MarzbanVpnDto? marzbanVpn = await marzbanService.GetMarzbanVpnByIdAsync(vpnId);
//
//         if (marzbanVpn == null)
//             throw new NotFoundException("VPN مورد نظر پیدا نشد");
//
//         AgentsIncomesDetailByPriceDto agentsIncomesDetailByPrice = new()
//         {
//             AgentsIncomesDetail = new()
//         };
//
//         long totalProfit = 0;
//         long currentDayPrice = marzbanVpn.DayPrice;
//         long currentGbPrice = marzbanVpn.GbPrice;
//
//         for (int i = numberOfAgents; i >= 0; i--)
//         {
//             HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
//             Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
//
//             if (agentByPath != null)
//             {
//                 double percent;
//
//                 if (admin != null)
//                 {
//                     percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                 }
//                 else
//                 {
//                     if (i == 0)
//                     {
//                         percent = agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent;
//                     }
//                     else
//                     {
//                         percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                     }
//                 }
//
//                 double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
//
//
//                 long newDayPrice = Convert.ToInt64(currentDayPrice * multiplier);
//                 long newGbPrice = Convert.ToInt64(currentGbPrice * multiplier);
//
//                 long dp = newDayPrice - currentDayPrice;
//                 long gp = newGbPrice - currentGbPrice;
//
//                 long profit = dp + gp;
//                 totalProfit += profit;
//
//
//                 currentDayPrice = newDayPrice;
//                 currentGbPrice = newGbPrice;
//
//
//                 agentsIncomesDetailByPrice.AgentsIncomesDetail.Add(new()
//                 {
//                     AgentId = agentByPath.Id,
//                     Profit = profit,
//                 });
//             }
//         }
//
//         marzbanVpn.DayPrice = currentDayPrice;
//         marzbanVpn.GbPrice = currentGbPrice;
//
//         // marzbanVpn.AgentsIncomesDetailByPrice = agentsIncomesDetailByPrice;
//
//         return marzbanVpn;
//     }
//
//     public async Task<GetMarzbanVpnDto?> CalcuteVpnPrice(long vpnId, long userId, int totalGb, int totalDay,
//         int numberOfAgents = 2)
//     {
//         AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
//         AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);
//
//         if (agent == null)
//             throw new NotFoundException("نمایندگی شما غیر فعال شده است");
//
//         double totalMultiplier = 1.0;
//
//         MarzbanVpnDto? marzbanVpn = await marzbanService.GetMarzbanVpnByIdAsync(vpnId);
//
//         if (marzbanVpn == null)
//             throw new NotFoundException("VPN مورد نظر پیدا نشد");
//
//         AgentsIncomesDetailByPriceDto agentsIncomesDetailByPrice = new()
//         {
//             AgentsIncomesDetail = new()
//         };
//
//         long totalProfit = 0;
//         long currentDayPrice = marzbanVpn.DayPrice;
//         long currentGbPrice = marzbanVpn.GbPrice;
//
//         for (int i = numberOfAgents; i >= 0; i--)
//         {
//             HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
//             Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
//
//             if (agentByPath != null)
//             {
//                 double percent;
//
//                 if (admin != null)
//                 {
//                     percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                 }
//                 else
//                 {
//                     if (i == 0)
//                     {
//                         percent = agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent;
//                     }
//                     else
//                     {
//                         percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                     }
//                 }
//
//                 double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
//
//
//                 long newDayPrice = Convert.ToInt64(currentDayPrice * multiplier);
//                 long newGbPrice = Convert.ToInt64(currentGbPrice * multiplier);
//
//                 long dp = newDayPrice - currentDayPrice;
//                 long gp = newGbPrice - currentGbPrice;
//
//                 long profit = (dp * totalDay) + (gp * totalGb);
//                 totalProfit += profit;
//
//
//                 currentDayPrice = newDayPrice;
//                 currentGbPrice = newGbPrice;
//
//
//                 agentsIncomesDetailByPrice.AgentsIncomesDetail.Add(new()
//                 {
//                     AgentId = agentByPath.Id,
//                     Profit = profit,
//                 });
//             }
//         }
//
//         marzbanVpn.DayPrice = currentDayPrice;
//         marzbanVpn.GbPrice = currentGbPrice;
//
//         // marzbanVpn.AgentsIncomesDetailByPrice = agentsIncomesDetailByPrice;
//
//         return marzbanVpn;
//     }
//
//     public async Task<long> CalculateFinalVpnPriceAsync(long initialPrice, long userId, int numberOfAgents = 2)
//     {
//         var adminAgent = await agentService.GetAgentByAdminIdAsync(userId);
//         var currentAgent = await agentService.GetAgentByUserIdAsync(userId);
//
//         if (currentAgent == null)
//             throw new NotFoundException("نمایندگی شما غیر فعال شده است");
//
//         long finalPrice = initialPrice;
//
//         for (int i = numberOfAgents; i >= 0; i--)
//         {
//             HierarchyId ancestorPath = currentAgent.AgentPath.GetAncestor(i);
//             var agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
//
//             if (agentByPath != null)
//             {
//                 double percent = adminAgent != null
//                     ? (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent)
//                     : (i == 0
//                         ? (agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent)
//                         : (agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent));
//
//                 double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
//                 finalPrice = Convert.ToInt64(finalPrice * multiplier);
//             }
//         }
//
//         return finalPrice;
//     }
//
//     public async Task<List<User>> CalculateAgentIncome(
//         long userId,
//         long price,
//         int count = 1,
//         int numberOfAgents = 2)
//     {
//         AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
//
//         AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);
//
//         if (agent == null)
//             throw new NotFoundException("نمایندگی شما غیر فعال شده است");
//
//         List<User> users = new();
//
//         for (int i = numberOfAgents; i >= 0; i--)
//         {
//             HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
//             Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
//
//             if (agentByPath != null)
//             {
//                 double percent;
//                 if (admin != null)
//                 {
//                     percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                 }
//                 else
//                 {
//                     if (i == 0)
//                     {
//                         percent = agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent;
//                     }
//                     else
//                     {
//                         percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                     }
//                 }
//
//                 double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
//                 User? user = await agentService.GetAdminAgentUserAsync(agentByPath.AgentAdminId);
//
//                 if (user != null)
//                 {
//                     long income = Convert.ToInt64((price - (price / multiplier)) * count);
//                     user.Balance += income;
//                     users.Add(user);
//                 }
//             }
//         }
//
//         return users;
//     }
//
//
//     public async Task<AgentsIncomesDetailByPriceDto?> CalculatorVpnPrice(long price, long userId,
//         int numberOfAgents = 2)
//     {
//         AgentDto? admin = await agentService.GetAgentByAdminIdAsync(userId);
//
//         AgentDto? agent = await agentService.GetAgentByUserIdAsync(userId);
//
//         if (agent == null)
//             throw new NotFoundException("نمایندگی شما غیر فعال شده است");
//
//         double totalMultiplier = 1.0;
//
//         AgentsIncomesDetailByPriceDto agentTransactionByPrice = new()
//         {
//             AgentsIncomesDetail = new()
//         };
//
//         long p = price;
//
//         for (int i = numberOfAgents; i >= 0; i--)
//         {
//             HierarchyId ancestorPath = agent.AgentPath.GetAncestor(i);
//             Domain.Entities.Agent.Agent? agentByPath = await agentService.GetAgentByPathAsync(ancestorPath);
//
//             if (agentByPath != null)
//             {
//                 double percent;
//
//                 if (admin != null)
//                 {
//                     percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                 }
//                 else
//                 {
//                     if (i == 0)
//                     {
//                         percent = agentByPath.UserPercent == 0 ? 1 : agentByPath.UserPercent;
//                     }
//                     else
//                     {
//                         percent = agentByPath.AgentPercent == 0 ? 1 : agentByPath.AgentPercent;
//                     }
//                 }
//
//                 double multiplier = percent != 1 ? 1 + (percent / 100.0) : 1;
//
//                 long previousPrice = p;
//                 p = Convert.ToInt64(p * multiplier);
//
//                 agentTransactionByPrice.AgentsIncomesDetail.Add(new()
//                 {
//                     AgentId = agentByPath.Id,
//                     Profit = p - previousPrice // سود این نماینده
//                 });
//
//                 totalMultiplier *= multiplier;
//             }
//         }
//
//         agentTransactionByPrice.Price = Convert.ToInt64(price * totalMultiplier);
//         return agentTransactionByPrice;
//     }
//
//
//     public async Task<long> Calculate(List<long> agentIds, long price)
//     {
//         long _price = price;
//
//         foreach (long id in agentIds)
//         {
//             AgentDto? agent = await agentService.GetAgentByIdAsync(id);
//             _price += _price * agent!.UserPercent / 100;
//         }
//
//         return _price;
//     }
//
//     public async Task<List<CalculatorUserIncome>> CalculateBalanse(List<long> agentIds, long price)
//     {
//         List<CalculatorUserIncome> users = new();
//
//         long _price = price;
//
//         foreach (long id in agentIds)
//         {
//             AgentDto? agent = await agentService.GetAgentByIdAsync(id);
//             // users.Add(new(agent.AgentAdminId, _price * agent!.UserPercent / 100));
//             _price += _price * agent!.UserPercent / 100;
//         }
//
//         return users;
//     }
//
//     public void Dispose()
//     {
//         // agentService = null;
//     }
// }