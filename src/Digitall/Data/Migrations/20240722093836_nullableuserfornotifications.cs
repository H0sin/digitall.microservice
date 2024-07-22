using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class nullableuserfornotifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Notification",
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
                values: new object[] { 408974L, new DateTime(2024, 7, 22, 13, 8, 33, 315, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 7, 22, 13, 8, 33, 315, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4809), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4894), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(3845), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4602), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4607), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4612), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 325, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 7, 22, 13, 8, 33, 325, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6086), new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6116), new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(7788), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 320, DateTimeKind.Local).AddTicks(9010), "fcde6054acd842f6a827825c17b04130", "815699", new DateTime(2024, 7, 22, 13, 8, 33, 320, DateTimeKind.Local).AddTicks(9019) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Notification",
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
                values: new object[] { 706616L, new DateTime(2024, 7, 21, 13, 32, 55, 844, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 7, 21, 13, 32, 55, 844, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5031), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5047), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4798), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4801), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 854, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 7, 21, 13, 32, 55, 854, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(7930), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 849, DateTimeKind.Local).AddTicks(7012), "b45bbb1d465b42de8bcb8a724b2d2618", "462664", new DateTime(2024, 7, 21, 13, 32, 55, 849, DateTimeKind.Local).AddTicks(7019) });
        }
    }
}
