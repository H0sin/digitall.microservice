using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDefulatDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 877989L, new DateTime(2024, 9, 4, 14, 42, 34, 549, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 9, 4, 14, 42, 34, 549, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1601), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1603), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1606), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1617), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(8933), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7412), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7424), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6363), new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6386), new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6388), new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 553, DateTimeKind.Local).AddTicks(2423), "e88e378e19034e198b0aba213ec859a7", "605918", new DateTime(2024, 9, 4, 14, 42, 34, 553, DateTimeKind.Local).AddTicks(2430) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 269304L, new DateTime(2024, 9, 4, 14, 40, 56, 98, DateTimeKind.Local).AddTicks(5843), new DateTime(2024, 9, 4, 14, 40, 56, 98, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1154), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1156), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1159), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(6876), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7205), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 102, DateTimeKind.Local).AddTicks(2917), "659332a6feba41c4b533668feb930018", "959976", new DateTime(2024, 9, 4, 14, 40, 56, 102, DateTimeKind.Local).AddTicks(2928) });
        }
    }
}
