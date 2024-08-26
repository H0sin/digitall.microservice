using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TelegramBotsMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 131530L, new DateTime(2024, 8, 26, 20, 10, 41, 728, DateTimeKind.Local).AddTicks(7754), new DateTime(2024, 8, 26, 20, 10, 41, 728, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5349), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5357), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5363), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(8888), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3127), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3129), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.InsertData(
                table: "TelegramBots",
                columns: new[] { "Id", "AgentId", "BotId", "CreateBy", "CreateDate", "Description", "HostAddress", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "Name", "PersionName", "Route", "SecretToken", "Token" },
                values: new object[] { 1L, 100001L, 7419690675L, 1L, new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(4928), "ربات مستر ما", "https://test.samanii.com", false, "https://t.me/master_digitall_vpn_bot", new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(5895), 1L, "master_digitall_vpn_bot", "ربات اصلی مستر", "/master_digitall_vpn_bot", "", "7419690675:AAGpFGOAt_Nei0qQoppFct1V9NdY4MfzinE" });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(2449), new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Balance", "BotId", "ChatId", "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate", "TelegramUsername" },
                values: new object[] { 10000000000L, 7419690675L, 1246211305L, new DateTime(2024, 8, 26, 20, 10, 41, 732, DateTimeKind.Local).AddTicks(1733), "43f38c9b4e9e40f69c22f393af5c4cd3", "709893", new DateTime(2024, 8, 26, 20, 10, 41, 732, DateTimeKind.Local).AddTicks(1741), "lll_hosin_lll" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 134145L, new DateTime(2024, 8, 26, 18, 34, 0, 196, DateTimeKind.Local).AddTicks(6605), new DateTime(2024, 8, 26, 18, 34, 0, 196, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4566), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5534), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5549), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(2752), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1328), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1329), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1336), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1339), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1341), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1343), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1345), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(252), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Balance", "BotId", "ChatId", "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate", "TelegramUsername" },
                values: new object[] { 0L, null, null, new DateTime(2024, 8, 26, 18, 34, 0, 199, DateTimeKind.Local).AddTicks(9785), "a5378cd0baca415da37944398b1b414e", "891425", new DateTime(2024, 8, 26, 18, 34, 0, 199, DateTimeKind.Local).AddTicks(9793), null });
        }
    }
}
