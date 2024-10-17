using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedPeerCulomsItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 415954L, new DateTime(2024, 10, 16, 19, 45, 15, 32, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 10, 16, 19, 45, 15, 32, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(4665), new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5617), new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5621), new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5633), new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(387), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(391), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(396), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(398), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(405), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 37, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 10, 16, 19, 45, 15, 37, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 37, DateTimeKind.Local).AddTicks(9293), new DateTime(2024, 10, 16, 19, 45, 15, 37, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 37, DateTimeKind.Local).AddTicks(9295), new DateTime(2024, 10, 16, 19, 45, 15, 37, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(7664), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 10, 16, 19, 45, 15, 39, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 10, 16, 19, 45, 15, 38, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 45, 15, 36, DateTimeKind.Local).AddTicks(6569), "ba998e8f89c34da88dc38d95c6b837ab", "635639", new DateTime(2024, 10, 16, 19, 45, 15, 36, DateTimeKind.Local).AddTicks(6609) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
