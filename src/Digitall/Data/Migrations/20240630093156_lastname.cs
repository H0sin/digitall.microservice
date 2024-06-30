using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class lastname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 316140L, new DateTime(2024, 6, 30, 12, 37, 17, 226, DateTimeKind.Local).AddTicks(2105), new DateTime(2024, 6, 30, 12, 37, 17, 228, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(8112), new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2030), new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2035), new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2056), new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(8155), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5240), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5252), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5255), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5257), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5262), new DateTime(2024, 6, 30, 12, 37, 17, 239, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 240, DateTimeKind.Local).AddTicks(3507), new DateTime(2024, 6, 30, 12, 37, 17, 240, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(497), new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(533), new DateTime(2024, 6, 30, 12, 37, 17, 237, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 6, 30, 12, 37, 17, 238, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 234, DateTimeKind.Local).AddTicks(9848), "76a342cee8c74ebab0f379ad652788fd", "854866", new DateTime(2024, 6, 30, 12, 37, 17, 234, DateTimeKind.Local).AddTicks(9867) });
        }
    }
}
