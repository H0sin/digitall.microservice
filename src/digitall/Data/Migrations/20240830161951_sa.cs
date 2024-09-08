using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class sa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 961789L, new DateTime(2024, 8, 30, 19, 49, 50, 143, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 8, 30, 19, 49, 50, 143, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3210), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4502), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(2790), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1111), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(6814), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(4421), new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 157, DateTimeKind.Local).AddTicks(5369), "2d6d9790e97b43d49aaa9158e8b2716d", "329069", new DateTime(2024, 8, 30, 19, 49, 50, 157, DateTimeKind.Local).AddTicks(5389) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 334478L, new DateTime(2024, 8, 30, 19, 13, 19, 865, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 8, 30, 19, 13, 19, 865, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(3960), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(4378), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5175), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5194), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(2780), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1014), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1335), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1338), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1344), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1345), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1347), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1352), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 874, DateTimeKind.Local).AddTicks(1446), new DateTime(2024, 8, 30, 19, 13, 19, 874, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 870, DateTimeKind.Local).AddTicks(1556), "ba72131c6dad419bad010cdfcc27b7f9", "155923", new DateTime(2024, 8, 30, 19, 13, 19, 870, DateTimeKind.Local).AddTicks(1573) });
        }
    }
}
