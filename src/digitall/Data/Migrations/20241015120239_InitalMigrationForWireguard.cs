using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigrationForWireguard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WireguardServers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WireguardServers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interfaces",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WireguardServerId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxPeer = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interfaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interfaces_WireguardServers_WireguardServerId",
                        column: x => x.WireguardServerId,
                        principalTable: "WireguardServers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Peers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterfaceId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peers_Interfaces_InterfaceId",
                        column: x => x.InterfaceId,
                        principalTable: "Interfaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 523468L, new DateTime(2024, 10, 15, 15, 32, 37, 708, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 10, 15, 15, 32, 37, 708, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(6043), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4557), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4576), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4581), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4583), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5839), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5859), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5861), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 725, DateTimeKind.Local).AddTicks(5757), "f95021a8b0484841bd7871e5b35dd630", "117466", new DateTime(2024, 10, 15, 15, 32, 37, 725, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.CreateIndex(
                name: "IX_Interfaces_WireguardServerId",
                table: "Interfaces",
                column: "WireguardServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Peers_InterfaceId",
                table: "Peers",
                column: "InterfaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peers");

            migrationBuilder.DropTable(
                name: "Interfaces");

            migrationBuilder.DropTable(
                name: "WireguardServers");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 874841L, new DateTime(2024, 9, 18, 13, 15, 38, 175, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 9, 18, 13, 15, 38, 175, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(5185), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3699), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3707), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3708), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3713), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2710), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2724), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2726), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(9458), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 179, DateTimeKind.Local).AddTicks(1318), "a1e5251c805843bd8a2cabdcd1780c76", "813324", new DateTime(2024, 9, 18, 13, 15, 38, 179, DateTimeKind.Local).AddTicks(1326) });
        }
    }
}
