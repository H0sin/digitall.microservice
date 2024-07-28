using Data.DefaultData;
using Data.SeedsData;
using Domain.Common;
using Domain.Entities.Account;
using Domain.Entities.Agent;
using Domain.Entities.Authorization;
using Domain.Entities.Category;
using Domain.Entities.Country;
using Domain.Entities.Marzban;

using Domain.Entities.Menu;
using Domain.Entities.Notification;
using Domain.Entities.Order;
using Domain.Entities.Product;
using Domain.Entities.Sanaei;
using Domain.Entities.Server;
using Domain.Entities.Subscription;
using Domain.Entities.Telegram;
using Domain.Entities.Transaction;
using Domain.Entities.Vpn;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Data.Context;

public class DigitallDbContext : DbContext
{
    public DigitallDbContext(DbContextOptions<DigitallDbContext> options) : base(options)
    {
    }

    #region db set

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<RoleMenus> RoleMenus { get; set; }
    public DbSet<Agent> Agent { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionDetail> TransactionDetail { get; set; }
    public DbSet<Server> Server { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Vpn> Vpn { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderDetail> OrderDetail { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<VpnCountry> VpnCountry { get; set; }
    public DbSet<Inbound> Inbounds { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<MarzbanServer> MarzbanServers { get; set; }
    public DbSet<MarzbanVpn> MarzbanVpns { get; set; }
    public DbSet<MarzbanUser> MarzbanUsers { get; set; }
    public DbSet<MarzbanVpnTemplate> MarzbanVpnTemplates { get; set; }
    public DbSet<TelegramBot> TelegramBots { get; set; }
    public DbSet<Notification> Notification { get; set; }
    #endregion

    #region properties

    /// <summary>
    /// set auto when update or delete
    /// </summary>
    public long UserId { get; set; }

    #endregion

    #region config

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreateDate = DateTime.Now;
                    entry.Entity.CreateBy = UserId;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedDate = DateTime.Now;
                    entry.Entity.ModifyBy = UserId;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges()
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreateDate = DateTime.Now;
                    entry.Entity.CreateBy = UserId;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedDate = DateTime.Now;
                    entry.Entity.ModifyBy = UserId;
                    break;
            }
        }

        return base.SaveChanges();
    }

    #endregion

    #region flounet api

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
        {
            if (!relationship.IsSelfReferencing())
            {
                relationship.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }

        #region seeds data

        modelBuilder.AddData(AgentItems.Agents);
        modelBuilder.AddData(UserItems.Users);
        modelBuilder.AddData(RoleItems.Roles);
        modelBuilder.AddData(MenuItems.Menu);
        modelBuilder.AddData(UserRoleItems.UserRoles);
        modelBuilder.AddData(RoleMenuItems.RoleMenus);
        modelBuilder.AddData(PermissionsItems.Permissions);
        modelBuilder.AddData(RolePermissionItems.RolePermissions);

        #endregion

        #region agent id started

        //modelBuilder.Entity<Agent>(b =>
        //{
        //    b.ToTable("Agent");
        //    b.Property<long>(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(10000, 1);
        //});

        #endregion

        base.OnModelCreating(modelBuilder);
    }

    #endregion
}