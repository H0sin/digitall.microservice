using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SpecialPercent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SpecialPercent",
                table: "Agent",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate", "SpecialPercent" },
                values: new object[] { 466734L, new DateTime(2024, 8, 27, 13, 36, 33, 40, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 8, 27, 13, 36, 33, 41, DateTimeKind.Local).AddTicks(98), null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialPercent",
                table: "Agent");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 131530L, new DateTime(2024, 8, 26, 20, 10, 41, 728, DateTimeKind.Local).AddTicks(7754), new DateTime(2024, 8, 26, 20, 10, 41, 728, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5349), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5357), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5363), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(8888), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3127), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3129), new DateTime(2024, 8, 26, 20, 10, 41, 733, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(2449), new DateTime(2024, 8, 26, 20, 10, 41, 735, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 8, 26, 20, 10, 41, 734, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 20, 10, 41, 732, DateTimeKind.Local).AddTicks(1733), "43f38c9b4e9e40f69c22f393af5c4cd3", "709893", new DateTime(2024, 8, 26, 20, 10, 41, 732, DateTimeKind.Local).AddTicks(1741) });
        }
    }
}
