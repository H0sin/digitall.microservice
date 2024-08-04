using Domain.Entities.Agent;
using Domain.Entities.Transaction;
using Microsoft.EntityFrameworkCore;

namespace Data.DefaultData;

public class AgentItems
{
    public static List<Agent> Agents = new List<Agent>()
    {
        new Agent()
        {
            Id = 100001,
            BrandName = "Samani",
            CreateBy = 1,
            CreateDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            ModifyBy = 1,
            AgentAdminId = 1,
            PersianBrandName = "سامانی",
            AgentCode = new Random().Next(100000,999999),
            AgentPath = HierarchyId.Parse("/"),
        }
    };
}