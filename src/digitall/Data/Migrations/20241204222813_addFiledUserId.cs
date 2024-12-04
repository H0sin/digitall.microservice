using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addFiledUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Transactions",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 953396L, new DateTime(2024, 12, 5, 1, 58, 11, 833, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 12, 5, 1, 58, 11, 833, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(1849), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2502), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(358), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8297), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8309), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8313), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8427), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8447), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(6873), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(8629), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4051), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 836, DateTimeKind.Local).AddTicks(8245), "e0692a5208bf4a5498ec86930534b033", "627757", new DateTime(2024, 12, 5, 1, 58, 11, 836, DateTimeKind.Local).AddTicks(8253) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 132557L, new DateTime(2024, 11, 16, 17, 15, 48, 765, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 11, 16, 17, 15, 48, 766, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(1501), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(1685), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2176), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2178), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2188), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(6863), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7099), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7239), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(81), new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7978), new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7975), new DateTime(2024, 11, 16, 17, 15, 48, 781, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 11, 16, 17, 15, 48, 783, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(3773), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(3792), new DateTime(2024, 11, 16, 17, 15, 48, 782, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 15, 48, 780, DateTimeKind.Local).AddTicks(6638), "808db1f79c524528a801717366ade728", "271118", new DateTime(2024, 11, 16, 17, 15, 48, 780, DateTimeKind.Local).AddTicks(6675) });
        }
    }
}
