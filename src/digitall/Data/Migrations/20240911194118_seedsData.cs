using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seedsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 967439L, new DateTime(2024, 9, 11, 23, 11, 17, 670, DateTimeKind.Local).AddTicks(1418), new DateTime(2024, 9, 11, 23, 11, 17, 670, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(8119), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9029), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9032), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5294), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5298), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(1004), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 9, 11, 23, 11, 17, 676, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 678, DateTimeKind.Local).AddTicks(5409), new DateTime(2024, 9, 11, 23, 11, 17, 678, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 678, DateTimeKind.Local).AddTicks(8139), new DateTime(2024, 9, 11, 23, 11, 17, 678, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "TelegramGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ChatId",
                value: -1002449260173L);

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 678, DateTimeKind.Local).AddTicks(2691), new DateTime(2024, 9, 11, 23, 11, 17, 678, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 9, 11, 23, 11, 17, 677, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 11, 17, 674, DateTimeKind.Local).AddTicks(7219), "27aab05a69d245848415e07b93767ce0", "577344", new DateTime(2024, 9, 11, 23, 11, 17, 674, DateTimeKind.Local).AddTicks(7250) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 138080L, new DateTime(2024, 9, 11, 21, 56, 41, 468, DateTimeKind.Local).AddTicks(34), new DateTime(2024, 9, 11, 21, 56, 41, 468, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1239), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1241), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 475, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 9, 11, 21, 56, 41, 475, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "TelegramGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ChatId",
                value: -4178759105L);

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(3408), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 471, DateTimeKind.Local).AddTicks(3354), "6772c2bc47ae4c8297aa83e2177f44d7", "49888", new DateTime(2024, 9, 11, 21, 56, 41, 471, DateTimeKind.Local).AddTicks(3362) });
        }
    }
}
