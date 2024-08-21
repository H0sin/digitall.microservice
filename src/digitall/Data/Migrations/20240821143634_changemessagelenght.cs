using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class changemessagelenght : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Notification",
                type: "nvarchar(max)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 644357L, new DateTime(2024, 8, 21, 18, 6, 32, 127, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 8, 21, 18, 6, 32, 128, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(3500), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5279), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5282), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3725), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3733), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3735), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2246), new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 138, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 8, 21, 18, 6, 32, 138, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 132, DateTimeKind.Local).AddTicks(6589), "7972dc3861754b6dad54fee0db416ce8", "163199", new DateTime(2024, 8, 21, 18, 6, 32, 132, DateTimeKind.Local).AddTicks(6620) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Notification",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 8000,
                oldNullable: true);

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
    }
}
