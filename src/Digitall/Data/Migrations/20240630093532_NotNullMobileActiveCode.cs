using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NotNullMobileActiveCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MobileActiveCode",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 102427L, new DateTime(2024, 6, 30, 13, 5, 30, 918, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 6, 30, 13, 5, 30, 920, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3192), new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(5745), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3188), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3195), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3197), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3199), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3205), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3207), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3209), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3210), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3213), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 6, 30, 13, 5, 30, 929, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 930, DateTimeKind.Local).AddTicks(2), new DateTime(2024, 6, 30, 13, 5, 30, 930, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 927, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 6, 30, 13, 5, 30, 927, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 927, DateTimeKind.Local).AddTicks(3766), new DateTime(2024, 6, 30, 13, 5, 30, 927, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 927, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 6, 30, 13, 5, 30, 927, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 6, 30, 13, 5, 30, 928, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 5, 30, 925, DateTimeKind.Local).AddTicks(5780), "df05ad281f0a4222961d2f26de103f22", "278734", new DateTime(2024, 6, 30, 13, 5, 30, 925, DateTimeKind.Local).AddTicks(5797) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MobileActiveCode",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 502514L, new DateTime(2024, 6, 30, 13, 1, 54, 150, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 6, 30, 13, 1, 54, 152, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(4956), new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8064), new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8067), new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8070), new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8086), new DateTime(2024, 6, 30, 13, 1, 54, 160, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 162, DateTimeKind.Local).AddTicks(1696), new DateTime(2024, 6, 30, 13, 1, 54, 162, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8711), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8713), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8715), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8722), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8725), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8730), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 162, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 6, 30, 13, 1, 54, 162, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 159, DateTimeKind.Local).AddTicks(8389), new DateTime(2024, 6, 30, 13, 1, 54, 159, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 159, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 6, 30, 13, 1, 54, 159, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 159, DateTimeKind.Local).AddTicks(8418), new DateTime(2024, 6, 30, 13, 1, 54, 159, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 6, 30, 13, 1, 54, 161, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 13, 1, 54, 157, DateTimeKind.Local).AddTicks(9832), "f80c0e30e7a94385a14c0ae5e320a241", "462728", new DateTime(2024, 6, 30, 13, 1, 54, 157, DateTimeKind.Local).AddTicks(9846) });
        }
    }
}
