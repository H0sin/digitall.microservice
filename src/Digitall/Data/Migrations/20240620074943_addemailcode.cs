using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addemailcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailActiveCode",
                table: "Users",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreateDate", "Email", "EmailActiveCode", "IsEmailActive", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 11, 19, 41, 472, DateTimeKind.Local).AddTicks(3784), "h.faraji8079@gmail.com", "833a751973b847dd9192507c309c2d6b", true, "958323", new DateTime(2024, 6, 20, 11, 19, 41, 472, DateTimeKind.Local).AddTicks(3796) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailActiveCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsEmailActive",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 425309L, new DateTime(2024, 6, 20, 9, 53, 21, 116, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 6, 20, 9, 53, 21, 117, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(2403), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5440), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5442), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5445), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5460), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5013), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5799), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5805), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5893), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5897), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 126, DateTimeKind.Local).AddTicks(2815), new DateTime(2024, 6, 20, 9, 53, 21, 126, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5553), new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "Email", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 122, DateTimeKind.Local).AddTicks(7186), null, "404867", new DateTime(2024, 6, 20, 9, 53, 21, 122, DateTimeKind.Local).AddTicks(7194) });
        }
    }
}
