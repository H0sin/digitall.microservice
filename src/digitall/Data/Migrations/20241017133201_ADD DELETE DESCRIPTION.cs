using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ADDDELETEDESCRIPTION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeleteDescription",
                table: "Peers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 561524L, new DateTime(2024, 10, 17, 17, 1, 59, 191, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 10, 17, 17, 1, 59, 191, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7669), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7673), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7684), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3098), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3331), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3337), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3338), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3340), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3748), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3763), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3765), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(8588), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(9376), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 205, DateTimeKind.Local).AddTicks(3862), "9c6fd3ba38de463ca6afcfdebe1baf4e", "488831", new DateTime(2024, 10, 17, 17, 1, 59, 205, DateTimeKind.Local).AddTicks(3880) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteDescription",
                table: "Peers");

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
    }
}
