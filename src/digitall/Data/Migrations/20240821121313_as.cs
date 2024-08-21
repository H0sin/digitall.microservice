using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class @as : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ButtonsJson",
                table: "Notification",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 796470L, new DateTime(2024, 8, 21, 15, 43, 11, 849, DateTimeKind.Local).AddTicks(2605), new DateTime(2024, 8, 21, 15, 43, 11, 849, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8042), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8878), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8880), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8932), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4767), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(1811), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(1828), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(1830), new DateTime(2024, 8, 21, 15, 43, 11, 854, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 856, DateTimeKind.Local).AddTicks(414), new DateTime(2024, 8, 21, 15, 43, 11, 856, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 8, 21, 15, 43, 11, 855, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 43, 11, 852, DateTimeKind.Local).AddTicks(9428), "a3d38c55536842418f4dc635fb4395e7", "845537", new DateTime(2024, 8, 21, 15, 43, 11, 852, DateTimeKind.Local).AddTicks(9438) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonsJson",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 658929L, new DateTime(2024, 8, 20, 16, 49, 41, 18, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 8, 20, 16, 49, 41, 18, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6517), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6917), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8387), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2179), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2202), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 25, DateTimeKind.Local).AddTicks(1742), new DateTime(2024, 8, 20, 16, 49, 41, 25, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(402), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 22, DateTimeKind.Local).AddTicks(1082), "984265db65614672827d9cb433dcd5c7", "176740", new DateTime(2024, 8, 20, 16, 49, 41, 22, DateTimeKind.Local).AddTicks(1093) });
        }
    }
}
