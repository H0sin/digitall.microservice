using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class deafualtData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 976639L, new DateTime(2024, 8, 28, 15, 12, 38, 892, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 8, 28, 15, 12, 38, 892, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7636), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(5745), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(3845), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4163), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4167), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(2035), new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 895, DateTimeKind.Local).AddTicks(8189), "1d528897d8124ada92b982745145c72b", "14728", new DateTime(2024, 8, 28, 15, 12, 38, 895, DateTimeKind.Local).AddTicks(8197) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 466734L, new DateTime(2024, 8, 27, 13, 36, 33, 40, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 8, 27, 13, 36, 33, 41, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(495), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1584), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1586), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1599), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7455), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7460), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7462), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 47, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 8, 27, 13, 36, 33, 47, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 45, DateTimeKind.Local).AddTicks(5823), new DateTime(2024, 8, 27, 13, 36, 33, 45, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 45, DateTimeKind.Local).AddTicks(5847), new DateTime(2024, 8, 27, 13, 36, 33, 45, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 45, DateTimeKind.Local).AddTicks(5849), new DateTime(2024, 8, 27, 13, 36, 33, 45, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 47, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 8, 27, 13, 36, 33, 47, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 47, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 8, 27, 13, 36, 33, 47, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 8, 27, 13, 36, 33, 46, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 36, 33, 44, DateTimeKind.Local).AddTicks(4145), "ad1426639eaf4e9e89663edcb39f9312", "55960", new DateTime(2024, 8, 27, 13, 36, 33, 44, DateTimeKind.Local).AddTicks(4160) });
        }
    }
}
