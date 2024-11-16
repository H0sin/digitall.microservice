using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addstatusforappleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AppleId",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "AppleId");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 546644L, new DateTime(2024, 11, 16, 2, 14, 17, 578, DateTimeKind.Local).AddTicks(7801), new DateTime(2024, 11, 16, 2, 14, 17, 578, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5552), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(1815), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(668), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(673), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(675), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(678), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(764), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1671), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1691), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1693), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1689), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(5882), new DateTime(2024, 11, 16, 2, 14, 17, 585, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(7363), new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 583, DateTimeKind.Local).AddTicks(430), "327fe1cac0cb4c5bb8b3959c0430d0d6", "651474", new DateTime(2024, 11, 16, 2, 14, 17, 583, DateTimeKind.Local).AddTicks(440) });
        }
    }
}
