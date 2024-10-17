using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addwireguardvpntemplatemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 751796L, new DateTime(2024, 10, 15, 16, 42, 36, 899, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 10, 15, 16, 42, 36, 899, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3306), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3855), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3858), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3873), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(9905), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8649), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8656), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9533), new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9554), new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(6475), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(5346), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 902, DateTimeKind.Local).AddTicks(8108), "e448c36f1bbf40e795036968deb04a98", "813638", new DateTime(2024, 10, 15, 16, 42, 36, 902, DateTimeKind.Local).AddTicks(8125) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
