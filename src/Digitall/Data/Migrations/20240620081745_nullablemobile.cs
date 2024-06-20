using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class nullablemobile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Users",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Users",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 576933L, new DateTime(2024, 6, 20, 11, 19, 41, 465, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 6, 20, 11, 19, 41, 467, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(7812), new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1118), new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(3483), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1052), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1059), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1067), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1077), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(7606), new DateTime(2024, 6, 20, 11, 19, 41, 476, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(1664), new DateTime(2024, 6, 20, 11, 19, 41, 474, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(4151), new DateTime(2024, 6, 20, 11, 19, 41, 475, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 472, DateTimeKind.Local).AddTicks(3784), "833a751973b847dd9192507c309c2d6b", "958323", new DateTime(2024, 6, 20, 11, 19, 41, 472, DateTimeKind.Local).AddTicks(3796) });
        }
    }
}
