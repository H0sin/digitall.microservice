using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFiledPeerServerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "WireguardServerId",
                table: "Peers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 312034L, new DateTime(2024, 10, 16, 19, 16, 12, 33, DateTimeKind.Local).AddTicks(8528), new DateTime(2024, 10, 16, 19, 16, 12, 33, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(4693), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5489), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5550), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5552), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(1576), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(338), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(341), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(343), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(1289), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(1308), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 10, 16, 19, 16, 12, 50, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 10, 16, 19, 16, 12, 49, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 10, 16, 19, 16, 12, 48, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 16, 12, 47, DateTimeKind.Local).AddTicks(1258), "263f846164494d1e94d51fc03b323b21", "648591", new DateTime(2024, 10, 16, 19, 16, 12, 47, DateTimeKind.Local).AddTicks(1277) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WireguardServerId",
                table: "Peers");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 379643L, new DateTime(2024, 10, 15, 20, 45, 4, 792, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 10, 15, 20, 45, 4, 792, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(299), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6214), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(3503), new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(1553), new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 796, DateTimeKind.Local).AddTicks(7081), "4280ea57768e4de98ca7f970d0d1d894", "587570", new DateTime(2024, 10, 15, 20, 45, 4, 796, DateTimeKind.Local).AddTicks(7092) });
        }
    }
}
