using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class WireguardVpnTemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peers_Interfaces_InterfaceId",
                table: "Peers");

            migrationBuilder.DropTable(
                name: "Interfaces");

            migrationBuilder.RenameColumn(
                name: "InterfaceId",
                table: "Peers",
                newName: "WireguardVpnId");

            migrationBuilder.RenameIndex(
                name: "IX_Peers_InterfaceId",
                table: "Peers",
                newName: "IX_Peers_WireguardVpnId");

            migrationBuilder.CreateTable(
                name: "WireguardVpn",
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
                    Desired = table.Column<bool>(type: "bit", nullable: false),
                    Test_Active = table.Column<bool>(type: "bit", nullable: false),
                    Test_Days = table.Column<int>(type: "int", nullable: false),
                    Test_TotalMg = table.Column<int>(type: "int", nullable: false),
                    InterfaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxPeer = table.Column<long>(type: "bigint", nullable: false),
                    WireguardServerId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WireguardVpn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WireguardVpn_WireguardServers_WireguardServerId",
                        column: x => x.WireguardServerId,
                        principalTable: "WireguardServers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WireguardVpnTemplates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Gb = table.Column<int>(type: "int", nullable: false),
                    WireguardVpnId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WireguardVpnTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WireguardVpnTemplates_WireguardVpn_WireguardVpnId",
                        column: x => x.WireguardVpnId,
                        principalTable: "WireguardVpn",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 292888L, new DateTime(2024, 10, 15, 16, 40, 51, 975, DateTimeKind.Local).AddTicks(8141), new DateTime(2024, 10, 15, 16, 40, 51, 975, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(8676), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9507), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4474), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4480), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4484), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4485), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4487), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4492), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(7783), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(5376), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(5396), new DateTime(2024, 10, 15, 16, 40, 51, 980, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 982, DateTimeKind.Local).AddTicks(3913), new DateTime(2024, 10, 15, 16, 40, 51, 982, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 982, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 10, 15, 16, 40, 51, 982, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 982, DateTimeKind.Local).AddTicks(1926), new DateTime(2024, 10, 15, 16, 40, 51, 982, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(1132), new DateTime(2024, 10, 15, 16, 40, 51, 981, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 40, 51, 979, DateTimeKind.Local).AddTicks(4161), "3cf84e9a35bb44cc8e498ba249840e84", "280091", new DateTime(2024, 10, 15, 16, 40, 51, 979, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.CreateIndex(
                name: "IX_WireguardVpn_WireguardServerId",
                table: "WireguardVpn",
                column: "WireguardServerId");

            migrationBuilder.CreateIndex(
                name: "IX_WireguardVpnTemplates_WireguardVpnId",
                table: "WireguardVpnTemplates",
                column: "WireguardVpnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peers_WireguardVpn_WireguardVpnId",
                table: "Peers",
                column: "WireguardVpnId",
                principalTable: "WireguardVpn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peers_WireguardVpn_WireguardVpnId",
                table: "Peers");

            migrationBuilder.DropTable(
                name: "WireguardVpnTemplates");

            migrationBuilder.DropTable(
                name: "WireguardVpn");

            migrationBuilder.RenameColumn(
                name: "WireguardVpnId",
                table: "Peers",
                newName: "InterfaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Peers_WireguardVpnId",
                table: "Peers",
                newName: "IX_Peers_InterfaceId");

            migrationBuilder.CreateTable(
                name: "Interfaces",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WireguardServerId = table.Column<long>(type: "bigint", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    MaxPeer = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 240973L, new DateTime(2024, 10, 15, 16, 16, 25, 356, DateTimeKind.Local).AddTicks(1783), new DateTime(2024, 10, 15, 16, 16, 25, 356, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5445), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(2838), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1658), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1662), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1664), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1669), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1672), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1673), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1675), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(837), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(9030), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 363, DateTimeKind.Local).AddTicks(753), new DateTime(2024, 10, 15, 16, 16, 25, 363, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(7917), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 359, DateTimeKind.Local).AddTicks(5871), "61ccbc364bf740c99c7621f3f82dbcf9", "910223", new DateTime(2024, 10, 15, 16, 16, 25, 359, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.CreateIndex(
                name: "IX_Interfaces_WireguardServerId",
                table: "Interfaces",
                column: "WireguardServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peers_Interfaces_InterfaceId",
                table: "Peers",
                column: "InterfaceId",
                principalTable: "Interfaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
