using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.SqlServer.Types;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    AgentPercent = table.Column<long>(type: "bigint", nullable: false),
                    UserPercent = table.Column<long>(type: "bigint", nullable: false),
                    SpecialPercent = table.Column<long>(type: "bigint", nullable: true),
                    AgentPath = table.Column<SqlHierarchyId>(type: "hierarchyid", nullable: true),
                    AllowNegative = table.Column<bool>(type: "bit", nullable: false),
                    AmountWithNegative = table.Column<long>(type: "bigint", nullable: false),
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
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Token = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
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
                name: "TelegramTopics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelegramTopicCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramTopics", x => x.Id);
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
                name: "AgentOption",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WelcomeMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentOption_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelegramBots",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Route = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    HostAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    SecretToken = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BotId = table.Column<long>(type: "bigint", nullable: false),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramBots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramBots_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaximumAmountForAgent = table.Column<long>(type: "bigint", nullable: true),
                    MinimalAmountForAgent = table.Column<long>(type: "bigint", nullable: true),
                    MaximumAmountForUser = table.Column<long>(type: "bigint", nullable: true),
                    MinimalAmountForUser = table.Column<long>(type: "bigint", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CardHolderName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MobileActiveCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmailActiveCode = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsMobileActive = table.Column<bool>(type: "bit", nullable: false),
                    IsEmailActive = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    Balance = table.Column<long>(type: "bigint", nullable: false),
                    ChatId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    UserStatus = table.Column<bool>(type: "bit", nullable: false),
                    FinalCountTestMarzbanAccount = table.Column<long>(type: "bigint", nullable: false),
                    BotId = table.Column<long>(type: "bigint", nullable: true),
                    TelegramUsername = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CardToCardPayment = table.Column<bool>(type: "bit", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    IsSupperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsAgent = table.Column<bool>(type: "bit", nullable: false),
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
                    GbMax = table.Column<int>(type: "int", nullable: false),
                    GbMin = table.Column<int>(type: "int", nullable: false),
                    GbPrice = table.Column<long>(type: "bigint", nullable: false),
                    DayMax = table.Column<int>(type: "int", nullable: false),
                    DayMin = table.Column<int>(type: "int", nullable: false),
                    DayPrice = table.Column<long>(type: "bigint", nullable: false),
                    ExpireDetailInbound = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Desired = table.Column<bool>(type: "bit", nullable: false),
                    Test_Active = table.Column<bool>(type: "bit", nullable: false),
                    Test_Days = table.Column<int>(type: "int", nullable: false),
                    Test_TotalMg = table.Column<int>(type: "int", nullable: false),
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
                name: "TelegramButtons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CallBackQuery = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp2 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp3 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp4 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    TelegramBotId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramButtons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramButtons_TelegramBots_TelegramBotId",
                        column: x => x.TelegramBotId,
                        principalTable: "TelegramBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelegramGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TelegramBotId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramGroups_TelegramBots_TelegramBotId",
                        column: x => x.TelegramBotId,
                        principalTable: "TelegramBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDetailId = table.Column<long>(type: "bigint", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TransactionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AvatarTransaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    TransactionStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    TransactionCode = table.Column<long>(type: "bigint", nullable: false),
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
                        name: "FK_Transactions_TransactionDetail_TransactionDetailId",
                        column: x => x.TransactionDetailId,
                        principalTable: "TransactionDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentRequest",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PersianBrandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BrandAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentPercent = table.Column<long>(type: "bigint", nullable: true),
                    UserPercent = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumAmount = table.Column<int>(type: "int", nullable: false),
                    MinimalAmount = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CardHolderName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PaymentDescription = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    AgentRequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentRequest_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationType = table.Column<byte>(type: "tinyint", nullable: false),
                    ForAllMember = table.Column<bool>(type: "bit", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileCaption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Send = table.Column<bool>(type: "bit", nullable: false),
                    ButtonsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    FileAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Users_UserId",
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
                name: "MarzbanVpnTemplates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Gb = table.Column<int>(type: "int", nullable: false),
                    MarzbanVpnId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarzbanVpnTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarzbanVpnTemplates_MarzbanVpns_MarzbanVpnId",
                        column: x => x.MarzbanVpnId,
                        principalTable: "MarzbanVpns",
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
                name: "TelegramGroupTopics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelegramGroupId = table.Column<long>(type: "bigint", nullable: true),
                    TelegramTopicId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramGroupTopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramGroupTopics_TelegramGroups_TelegramGroupId",
                        column: x => x.TelegramGroupId,
                        principalTable: "TelegramGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TelegramGroupTopics_TelegramTopics_TelegramTopicId",
                        column: x => x.TelegramTopicId,
                        principalTable: "TelegramTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentsIncomesDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    Profit = table.Column<long>(type: "bigint", nullable: false),
                    OrderDetailId = table.Column<long>(type: "bigint", nullable: false),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentsIncomesDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentsIncomesDetail_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentsIncomesDetail_OrderDetail_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetail",
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
                    Username = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Expire = table.Column<long>(type: "bigint", maxLength: 500, nullable: true),
                    Data_Limit = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    OrderDetailId = table.Column<long>(type: "bigint", nullable: false),
                    Sub_Updated_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sub_Last_User_Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Online_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Subscription_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnHoldExpireDuration = table.Column<long>(type: "bigint", nullable: true),
                    OnHoldTimeout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Used_Traffic = table.Column<long>(type: "bigint", nullable: true),
                    Lifetime_Used_Traffic = table.Column<long>(type: "bigint", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Links = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "AgentAdminId", "AgentCode", "AgentPath", "AgentPercent", "AllowNegative", "AmountWithNegative", "BrandAddress", "BrandName", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "PersianBrandName", "SpecialPercent", "UserPercent" },
                values: new object[] { 100001L, 1L, 261160L, Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/"), 0L, false, 0L, null, "Samani", 1L, new DateTime(2024, 9, 8, 20, 2, 44, 116, DateTimeKind.Local).AddTicks(9464), false, new DateTime(2024, 9, 8, 20, 2, 44, 116, DateTimeKind.Local).AddTicks(9659), 1L, "سامانی", null, 0L });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Action", "Active", "Area", "Controller", "CreateBy", "CreateDate", "Icon", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "ParentId", "Sorted", "Title" },
                values: new object[,]
                {
                    { 1L, null, true, null, null, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(83), null, false, null, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(80), 1L, null, 1, "اصلی" },
                    { 3L, null, true, null, null, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(1989), null, false, null, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(1987), 1L, null, 3, "عملیات" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "ParentId", "SystemName", "Title" },
                values: new object[] { 1L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(3816), false, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(3819), 1L, null, "FilterUsers", "لیست کاربران" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 122, DateTimeKind.Local).AddTicks(3499), false, new DateTime(2024, 9, 8, 20, 2, 44, 122, DateTimeKind.Local).AddTicks(3516), 1L, "مدیر" },
                    { 2L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 122, DateTimeKind.Local).AddTicks(3533), false, new DateTime(2024, 9, 8, 20, 2, 44, 122, DateTimeKind.Local).AddTicks(3534), 1L, "همکار" },
                    { 3L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 122, DateTimeKind.Local).AddTicks(3535), false, new DateTime(2024, 9, 8, 20, 2, 44, 122, DateTimeKind.Local).AddTicks(3536), 1L, "کاربر" }
                });

            migrationBuilder.InsertData(
                table: "TelegramButtons",
                columns: new[] { "Id", "AdditionalProp1", "AdditionalProp2", "AdditionalProp3", "AdditionalProp4", "CallBackQuery", "CreateBy", "CreateDate", "IsDelete", "IsLike", "Link", "ModifiedDate", "ModifyBy", "Name", "TelegramBotId", "Title" },
                values: new object[] { 1L, null, null, null, null, null, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 125, DateTimeKind.Local).AddTicks(6465), false, true, "https://t.me/master_digitall_vpn_bot", new DateTime(2024, 9, 8, 20, 2, 44, 125, DateTimeKind.Local).AddTicks(6814), 1L, "master_digitall_vpn_bot", null, "شروع ربات" });

            migrationBuilder.InsertData(
                table: "TelegramTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "Name", "TelegramTopicCategory" },
                values: new object[] { 1L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "استارت ربات", "start" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Action", "Active", "Area", "Controller", "CreateBy", "CreateDate", "Icon", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "ParentId", "Sorted", "Title" },
                values: new object[,]
                {
                    { 2L, "Index", true, "", "Home", 1L, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(561), "box", false, "/", new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(560), 1L, 1L, 2, "داشبورد" },
                    { 4L, null, true, null, null, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(1991), "list", false, null, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(1991), 1L, 3L, 4, "کاربران" }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "MenuId", "ModifiedDate", "ModifyBy", "RoleId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(889), false, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(892), 1L, 1L },
                    { 3L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1398), false, 3L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1399), 1L, 1L },
                    { 7L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1410), false, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1410), 1L, 2L },
                    { 9L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1413), false, 3L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1414), 1L, 2L }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "PermissionId", "RoleId" },
                values: new object[] { 1L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(6629), false, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(6633), 1L, 1L, 1L });

            migrationBuilder.InsertData(
                table: "TelegramBots",
                columns: new[] { "Id", "AgentId", "BotId", "CreateBy", "CreateDate", "Description", "HostAddress", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "Name", "PersionName", "Route", "SecretToken", "Token" },
                values: new object[] { 1L, 100001L, 7419690675L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 125, DateTimeKind.Local).AddTicks(3594), "ربات مستر ما", "https://364c-80-240-30-200.ngrok-free.app", false, "https://t.me/master_digitall_vpn_bot", new DateTime(2024, 9, 8, 20, 2, 44, 125, DateTimeKind.Local).AddTicks(4741), 1L, "master_digitall_vpn_bot", "ربات اصلی مستر", "/7332050396:AAHvkWaF4MhUb3U8yfvSlD1y81i_jF2tCN0", "", "7332050396:AAHvkWaF4MhUb3U8yfvSlD1y81i_jF2tCN0" });

            migrationBuilder.InsertData(
                table: "TransactionDetail",
                columns: new[] { "Id", "AgentId", "CardHolderName", "CardNumber", "CreateBy", "CreateDate", "Description", "IsDelete", "MaximumAmountForAgent", "MaximumAmountForUser", "MinimalAmountForAgent", "MinimalAmountForUser", "ModifiedDate", "ModifyBy" },
                values: new object[] { 1L, 100001L, "حسین فرجی", "6037691610791079", 1L, new DateTime(2024, 9, 8, 20, 2, 44, 125, DateTimeKind.Local).AddTicks(702), "توضیحات", false, 2000000L, 2000000L, 100000L, 10000L, new DateTime(2024, 9, 8, 20, 2, 44, 125, DateTimeKind.Local).AddTicks(706), 1L });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "AgentId", "Avatar", "Balance", "BotId", "CardToCardPayment", "ChatId", "CreateBy", "CreateDate", "Description", "Email", "EmailActiveCode", "FinalCountTestMarzbanAccount", "FirstName", "IsAgent", "IsBlocked", "IsDelete", "IsEmailActive", "IsMobileActive", "IsSupperAdmin", "LastName", "MessageId", "Mobile", "MobileActiveCode", "ModifiedDate", "ModifyBy", "Password", "TelegramUsername", "UserStatus" },
                values: new object[] { 1L, null, 100001L, "", 10000000000L, 7419690675L, false, 1246211305L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 120, DateTimeKind.Local).AddTicks(6609), null, "h.faraji8079@gmail.com", "dfa6252e58404280a1bbb293dd01abb8", 0L, "حسین", false, false, false, true, true, false, "فرجی", null, "09913737962", "377365", new DateTime(2024, 9, 8, 20, 2, 44, 120, DateTimeKind.Local).AddTicks(6651), 1L, "FC-EA-92-0F-74-12-B5-DA-7B-E0-CF-42-B8-C9-37-59", "lll_hosin_lll", false });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Action", "Active", "Area", "Controller", "CreateBy", "CreateDate", "Icon", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "ParentId", "Sorted", "Title" },
                values: new object[,]
                {
                    { 5L, "Users", true, "", "Account", 1L, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(1994), null, false, "Account/Users", new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(1993), 1L, 4L, 5, "لیست کاربران" },
                    { 6L, "AllUsers", true, "", "Account", 1L, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(2009), null, false, "Account/AllUsers", new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(2008), 1L, 4L, 6, "لیست همه کاربران" }
                });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "MenuId", "ModifiedDate", "ModifyBy", "RoleId" },
                values: new object[,]
                {
                    { 2L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1395), false, 2L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1396), 1L, 1L },
                    { 4L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1400), false, 4L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1400), 1L, 1L },
                    { 8L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1412), false, 2L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1412), 1L, 2L },
                    { 10L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1416), false, 4L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1416), 1L, 2L }
                });

            migrationBuilder.InsertData(
                table: "TelegramGroups",
                columns: new[] { "Id", "ChatId", "CreateBy", "CreateDate", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "Name", "TelegramBotId" },
                values: new object[] { 1L, -4178759105L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "مستر گروه", 1L });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "RoleId", "UserId" },
                values: new object[] { 1L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(4541), false, new DateTime(2024, 9, 8, 20, 2, 44, 123, DateTimeKind.Local).AddTicks(4544), 1L, 1L, 1L });

            migrationBuilder.InsertData(
                table: "RoleMenus",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "MenuId", "ModifiedDate", "ModifyBy", "RoleId" },
                values: new object[,]
                {
                    { 5L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1402), false, 5L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1402), 1L, 1L },
                    { 6L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1408), false, 6L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1409), 1L, 1L },
                    { 11L, 1L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1417), false, 5L, new DateTime(2024, 9, 8, 20, 2, 44, 124, DateTimeKind.Local).AddTicks(1418), 1L, 2L }
                });

            migrationBuilder.InsertData(
                table: "TelegramGroupTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "TelegramGroupId", "TelegramTopicId" },
                values: new object[] { 1L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_AgentOption_AgentId",
                table: "AgentOption",
                column: "AgentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AgentRequest_UserId",
                table: "AgentRequest",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AgentsIncomesDetail_AgentId",
                table: "AgentsIncomesDetail",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentsIncomesDetail_OrderDetailId",
                table: "AgentsIncomesDetail",
                column: "OrderDetailId");

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
                name: "IX_MarzbanVpnTemplates_MarzbanVpnId",
                table: "MarzbanVpnTemplates",
                column: "MarzbanVpnId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentId",
                table: "Menu",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");

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
                name: "IX_TelegramBots_AgentId",
                table: "TelegramBots",
                column: "AgentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelegramButtons_TelegramBotId",
                table: "TelegramButtons",
                column: "TelegramBotId");

            migrationBuilder.CreateIndex(
                name: "IX_TelegramGroups_TelegramBotId",
                table: "TelegramGroups",
                column: "TelegramBotId",
                unique: true,
                filter: "[TelegramBotId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TelegramGroupTopics_TelegramGroupId",
                table: "TelegramGroupTopics",
                column: "TelegramGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TelegramGroupTopics_TelegramTopicId",
                table: "TelegramGroupTopics",
                column: "TelegramTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_AgentId",
                table: "TransactionDetail",
                column: "AgentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionDetailId",
                table: "Transactions",
                column: "TransactionDetailId");

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
                name: "AgentOption");

            migrationBuilder.DropTable(
                name: "AgentRequest");

            migrationBuilder.DropTable(
                name: "AgentsIncomesDetail");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "MarzbanUsers");

            migrationBuilder.DropTable(
                name: "MarzbanVpnTemplates");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "RoleMenus");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "TelegramButtons");

            migrationBuilder.DropTable(
                name: "TelegramGroupTopics");

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
                name: "MarzbanVpns");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "TelegramGroups");

            migrationBuilder.DropTable(
                name: "TelegramTopics");

            migrationBuilder.DropTable(
                name: "TransactionDetail");

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
                name: "MarzbanServers");

            migrationBuilder.DropTable(
                name: "TelegramBots");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Vpn");

            migrationBuilder.DropTable(
                name: "Agent");
        }
    }
}
