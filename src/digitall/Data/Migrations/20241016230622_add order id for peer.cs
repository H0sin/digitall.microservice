using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addorderidforpeer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Peers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 866813L, new DateTime(2024, 10, 17, 2, 36, 20, 95, DateTimeKind.Local).AddTicks(8008), new DateTime(2024, 10, 17, 2, 36, 20, 95, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(988), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1158), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1698), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(7289), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(5956), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6134), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6136), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6162), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6164), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6166), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6168), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6169), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6171), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6173), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 110, DateTimeKind.Local).AddTicks(7554), new DateTime(2024, 10, 17, 2, 36, 20, 110, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 110, DateTimeKind.Local).AddTicks(7568), new DateTime(2024, 10, 17, 2, 36, 20, 110, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 110, DateTimeKind.Local).AddTicks(7569), new DateTime(2024, 10, 17, 2, 36, 20, 110, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 112, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 10, 17, 2, 36, 20, 112, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 112, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 10, 17, 2, 36, 20, 112, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 112, DateTimeKind.Local).AddTicks(1681), new DateTime(2024, 10, 17, 2, 36, 20, 112, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 10, 17, 2, 36, 20, 111, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 36, 20, 109, DateTimeKind.Local).AddTicks(6598), "f3752167fe3c4f55ad8cf603f9c9d704", "336916", new DateTime(2024, 10, 17, 2, 36, 20, 109, DateTimeKind.Local).AddTicks(6615) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Peers");

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
    }
}
