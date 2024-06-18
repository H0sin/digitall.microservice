using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.SqlServer.Types;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PersianBrandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AgentAdminId = table.Column<long>(type: "bigint", nullable: false),
                    AgentCode = table.Column<long>(type: "bigint", nullable: false),
                    BrandAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percent = table.Column<long>(type: "bigint", nullable: false),
                    AgentPath = table.Column<SqlHierarchyId>(type: "hierarchyid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarzbanServers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ServerIp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ServerPort = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ssl = table.Column<bool>(type: "bit", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Users = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarzbanServers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sorted = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    TracingCode = table.Column<long>(type: "bigint", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    SystemName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Permissions_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Permissions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vpn",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<long>(type: "bigint", nullable: false),
                    ServerId = table.Column<long>(type: "bigint", nullable: false),
                    TotoalGb = table.Column<long>(type: "bigint", nullable: false),
                    NumberUser = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vpn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MobileActiveCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsMobileActive = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    Balance = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Server",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ServerAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Port = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServerStatus = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Server", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Server_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarzbanVpns",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GbMax = table.Column<long>(type: "bigint", nullable: false),
                    GbMin = table.Column<long>(type: "bigint", nullable: false),
                    GbPrice = table.Column<long>(type: "bigint", nullable: false),
                    DayMax = table.Column<long>(type: "bigint", nullable: false),
                    DayMin = table.Column<long>(type: "bigint", nullable: false),
                    DayPrice = table.Column<long>(type: "bigint", nullable: false),
                    Vmess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vless = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shadowsocks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trojan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proxies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarzbanServerId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarzbanVpns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarzbanVpns_MarzbanServers_MarzbanServerId",
                        column: x => x.MarzbanServerId,
                        principalTable: "MarzbanServers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMenus_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenus_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    PermissionId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VpnId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Vpn_VpnId",
                        column: x => x.VpnId,
                        principalTable: "Vpn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VpnCountry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VpnId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VpnCountry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VpnCountry_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VpnCountry_Vpn_VpnId",
                        column: x => x.VpnId,
                        principalTable: "Vpn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TransactionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardNumber = table.Column<long>(type: "bigint", maxLength: 200, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AvatarTransaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    TransactionStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inbounds",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanaeiInboundId = table.Column<long>(type: "bigint", nullable: false),
                    Up = table.Column<long>(type: "bigint", nullable: false),
                    Down = table.Column<long>(type: "bigint", nullable: false),
                    Total = table.Column<long>(type: "bigint", nullable: false),
                    Listen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Port = table.Column<long>(type: "bigint", nullable: false),
                    ExpiryTime = table.Column<long>(type: "bigint", nullable: false),
                    ServerId = table.Column<long>(type: "bigint", nullable: false),
                    Protocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sniffing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreamSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inbounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inbounds_Server_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Server",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<long>(type: "bigint", nullable: false),
                    OrderDeatilType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Up = table.Column<long>(type: "bigint", nullable: false),
                    Down = table.Column<long>(type: "bigint", nullable: false),
                    ExpiryTime = table.Column<long>(type: "bigint", nullable: false),
                    TotalGb = table.Column<long>(type: "bigint", nullable: false),
                    Reset = table.Column<long>(type: "bigint", nullable: false),
                    InboundId = table.Column<long>(type: "bigint", nullable: false),
                    ServerId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    SanaeiClientId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderDetailId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Inbounds_InboundId",
                        column: x => x.InboundId,
                        principalTable: "Inbounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_OrderDetail_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarzbanUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarzbanServerId = table.Column<long>(type: "bigint", nullable: false),
                    MarzbanVpnId = table.Column<long>(type: "bigint", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_Limit = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    OrderDetailId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarzbanUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarzbanUsers_OrderDetail_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Agent",
                columns: new[] { "Id", "AgentAdminId", "AgentCode", "AgentPath", "BrandAddress", "BrandName", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "Percent", "PersianBrandName" },
                values: new object[] { 100001L, 1L, 358872L, Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/"), null, "Samani", 1L, new DateTime(2024, 6, 18, 12, 57, 42, 786, DateTimeKind.Local).AddTicks(7404), false, new DateTime(2024, 6, 18, 12, 57, 42, 788, DateTimeKind.Local).AddTicks(629), 1L, 0L, "سامانی" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Action", "Active", "Area", "Controller", "CreateBy", "CreateDate", "Icon", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "ParentId", "Sorted", "Title" },
                values: new object[,]
                {
                    { 1L, null, true, null, null, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(7288), null, false, null, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(7279), 1L, null, 1, "اصلی" },
                    { 3L, null, true, null, null, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(317), null, false, null, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(313), 1L, null, 3, "عملیات" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "ParentId", "SystemName", "Title" },
                values: new object[] { 1L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(4555), false, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(4561), 1L, null, "FilterUsers", "لیست کاربران" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(417), false, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(427), 1L, "مدیر" },
                    { 2L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(447), false, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(448), 1L, "همکار" },
                    { 3L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(580), false, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(581), 1L, "کاربر" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Action", "Active", "Area", "Controller", "CreateBy", "CreateDate", "Icon", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "ParentId", "Sorted", "Title" },
                values: new object[,]
                {
                    { 2L, "Index", true, "", "Home", 1L, new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(8063), "box", false, "/", new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(8059), 1L, 1L, 2, "داشبورد" },
                    { 4L, null, true, null, null, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(319), "list", false, null, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(319), 1L, 3L, 4, "کاربران" }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "MenuId", "ModifiedDate", "ModifyBy", "RoleId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(934), false, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(940), 1L, 1L },
                    { 3L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1896), false, 3L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1907), 1L, 1L },
                    { 7L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1917), false, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1918), 1L, 2L },
                    { 9L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1921), false, 3L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1922), 1L, 2L }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "PermissionId", "RoleId" },
                values: new object[] { 1L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(9772), false, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(9781), 1L, 1L, 1L });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "AgentId", "Avatar", "Balance", "CreateBy", "CreateDate", "Email", "FirstName", "IsBlocked", "IsDelete", "IsMobileActive", "LastName", "Mobile", "MobileActiveCode", "ModifiedDate", "ModifyBy", "Password" },
                values: new object[] { 1L, null, 100001L, "", 0L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 794, DateTimeKind.Local).AddTicks(4102), null, "حسین", false, false, true, "فرجی", "09913737962", "346033", new DateTime(2024, 6, 18, 12, 57, 42, 794, DateTimeKind.Local).AddTicks(4117), 1L, "FC-EA-92-0F-74-12-B5-DA-7B-E0-CF-42-B8-C9-37-59" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Action", "Active", "Area", "Controller", "CreateBy", "CreateDate", "Icon", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "ParentId", "Sorted", "Title" },
                values: new object[,]
                {
                    { 5L, "Users", true, "", "Account", 1L, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(324), null, false, "Account/Users", new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(324), 1L, 4L, 5, "لیست کاربران" },
                    { 6L, "AllUsers", true, "", "Account", 1L, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(335), null, false, "Account/AllUsers", new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(335), 1L, 4L, 6, "لیست همه کاربران" }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "MenuId", "ModifiedDate", "ModifyBy", "RoleId" },
                values: new object[,]
                {
                    { 2L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1889), false, 2L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1895), 1L, 1L },
                    { 4L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1909), false, 4L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1910), 1L, 1L },
                    { 8L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1919), false, 2L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1920), 1L, 2L },
                    { 10L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1924), false, 4L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1924), 1L, 2L }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "RoleId", "UserId" },
                values: new object[] { 1L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(3585), false, new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(3591), 1L, 1L, 1L });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "MenuId", "ModifiedDate", "ModifyBy", "RoleId" },
                values: new object[,]
                {
                    { 5L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1911), false, 5L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1912), 1L, 1L },
                    { 6L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1915), false, 6L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1916), 1L, 1L },
                    { 11L, 1L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1925), false, 5L, new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1926), 1L, 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_InboundId",
                table: "Clients",
                column: "InboundId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_OrderDetailId",
                table: "Clients",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Inbounds_ServerId",
                table: "Inbounds",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_MarzbanUsers_OrderDetailId",
                table: "MarzbanUsers",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_MarzbanVpns_MarzbanServerId",
                table: "MarzbanVpns",
                column: "MarzbanServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentId",
                table: "Menu",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ParentId",
                table: "Permissions",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VpnId",
                table: "Product",
                column: "VpnId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenus_MenuId",
                table: "RoleMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenus_RoleId",
                table: "RoleMenus",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Server_CountryId",
                table: "Server",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AgentId",
                table: "Users",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_VpnCountry_CountryId",
                table: "VpnCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VpnCountry_VpnId",
                table: "VpnCountry",
                column: "VpnId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "MarzbanUsers");

            migrationBuilder.DropTable(
                name: "MarzbanVpns");

            migrationBuilder.DropTable(
                name: "RoleMenus");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "VpnCountry");

            migrationBuilder.DropTable(
                name: "Inbounds");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "MarzbanServers");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Server");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Vpn");
        }
    }
}
