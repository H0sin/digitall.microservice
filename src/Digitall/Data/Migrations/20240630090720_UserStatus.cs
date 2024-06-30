using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UserStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UserStatus",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreateDate", "Description", "EmailActiveCode", "MobileActiveCode", "ModifiedDate", "UserStatus" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 37, 17, 234, DateTimeKind.Local).AddTicks(9848), null, "76a342cee8c74ebab0f379ad652788fd", "854866", new DateTime(2024, 6, 30, 12, 37, 17, 234, DateTimeKind.Local).AddTicks(9867), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserStatus",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 610249L, new DateTime(2024, 6, 20, 11, 47, 43, 332, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 6, 20, 11, 47, 43, 334, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(3368), new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5848), new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5854), new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 344, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 6, 20, 11, 47, 43, 344, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(6863), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8108), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8119), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8126), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 6, 20, 11, 47, 43, 343, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 344, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 6, 20, 11, 47, 43, 344, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 341, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 6, 20, 11, 47, 43, 341, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 341, DateTimeKind.Local).AddTicks(6307), new DateTime(2024, 6, 20, 11, 47, 43, 341, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 341, DateTimeKind.Local).AddTicks(6309), new DateTime(2024, 6, 20, 11, 47, 43, 341, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(8934), new DateTime(2024, 6, 20, 11, 47, 43, 342, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 47, 43, 339, DateTimeKind.Local).AddTicks(8549), "a960c24659904e6c8a8eb88a2788eb91", "123960", new DateTime(2024, 6, 20, 11, 47, 43, 339, DateTimeKind.Local).AddTicks(8564) });
        }
    }
}
