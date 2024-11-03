using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AgentTimeDisabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DisabledAccountTime",
                table: "Agent",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "DisabledAccountTime", "ModifiedDate" },
                values: new object[] { 880896L, new DateTime(2024, 11, 3, 21, 19, 53, 256, DateTimeKind.Local).AddTicks(1068), null, new DateTime(2024, 11, 3, 21, 19, 53, 256, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8027), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(5637), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(3731), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4082), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4085), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4101), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(7424), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(943), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(5007), new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(9274), new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(394), new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 264, DateTimeKind.Local).AddTicks(9389), "7b087e4d9e58484b873cab630d30afc7", "251633", new DateTime(2024, 11, 3, 21, 19, 53, 264, DateTimeKind.Local).AddTicks(9410) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisabledAccountTime",
                table: "Agent");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 561524L, new DateTime(2024, 10, 17, 17, 1, 59, 191, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 10, 17, 17, 1, 59, 191, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7669), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7673), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7684), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3098), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3331), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3337), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3338), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3340), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3748), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3763), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3765), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 10, 17, 17, 1, 59, 208, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(8588), new DateTime(2024, 10, 17, 17, 1, 59, 207, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(9376), new DateTime(2024, 10, 17, 17, 1, 59, 206, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 1, 59, 205, DateTimeKind.Local).AddTicks(3862), "9c6fd3ba38de463ca6afcfdebe1baf4e", "488831", new DateTime(2024, 10, 17, 17, 1, 59, 205, DateTimeKind.Local).AddTicks(3880) });
        }
    }
}
