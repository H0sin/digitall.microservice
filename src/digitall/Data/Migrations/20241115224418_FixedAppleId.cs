using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedAppleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AssignSupporterUserId",
                table: "AppleId",
                type: "bigint",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "Title" },
                values: new object[] { 4L, 1L, new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1689), false, new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(1690), 1L, "پشتیبانی اپل ایدی" });

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 16, 2, 14, 17, 583, DateTimeKind.Local).AddTicks(430), "327fe1cac0cb4c5bb8b3959c0430d0d6", "651474", new DateTime(2024, 11, 16, 2, 14, 17, 583, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "RoleId", "UserId" },
                values: new object[] { 2L, 1L, new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(7363), false, new DateTime(2024, 11, 16, 2, 14, 17, 584, DateTimeKind.Local).AddTicks(7364), 1L, 4L, 1L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "AssignSupporterUserId",
                table: "AppleId");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 612554L, new DateTime(2024, 11, 15, 2, 23, 30, 123, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 11, 15, 2, 23, 30, 123, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(7856), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3104), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3116), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3118), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(1950), new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 127, DateTimeKind.Local).AddTicks(4518), "986ee3b94ac441bd9913055c392e53fe", "345782", new DateTime(2024, 11, 15, 2, 23, 30, 127, DateTimeKind.Local).AddTicks(4531) });
        }
    }
}
