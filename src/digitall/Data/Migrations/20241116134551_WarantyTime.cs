using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class WarantyTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarrantyDay",
                table: "AppleIdTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WarrantyDay",
                table: "AppleIdTypes");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 100712L, new DateTime(2024, 11, 16, 5, 5, 58, 874, DateTimeKind.Local).AddTicks(5567), new DateTime(2024, 11, 16, 5, 5, 58, 874, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1245), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(7982), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6764), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(195), new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6326), new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6347), new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 11, 16, 5, 5, 58, 888, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 11, 16, 5, 5, 58, 890, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 11, 16, 5, 5, 58, 889, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 5, 58, 887, DateTimeKind.Local).AddTicks(5634), "234c8fe4dfac464bbc8527442f8d0bc6", "716215", new DateTime(2024, 11, 16, 5, 5, 58, 887, DateTimeKind.Local).AddTicks(5736) });
        }
    }
}
