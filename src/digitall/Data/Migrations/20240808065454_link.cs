using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class link : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "TelegramBots",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserPercent",
                table: "AgentRequest",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "AgentPercent",
                table: "AgentRequest",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 751935L, new DateTime(2024, 8, 8, 10, 24, 51, 285, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 8, 8, 10, 24, 51, 285, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(7764), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(576), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1473), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1483), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1489), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1492), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1494), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 332, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 8, 8, 10, 24, 51, 332, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 327, DateTimeKind.Local).AddTicks(1230), "da295f02a39b45ceb977cbfa230bf8c7", "619799", new DateTime(2024, 8, 8, 10, 24, 51, 327, DateTimeKind.Local).AddTicks(1252) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "TelegramBots");

            migrationBuilder.AlterColumn<long>(
                name: "UserPercent",
                table: "AgentRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "AgentPercent",
                table: "AgentRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 805943L, new DateTime(2024, 8, 5, 13, 5, 14, 65, DateTimeKind.Local).AddTicks(8931), new DateTime(2024, 8, 5, 13, 5, 14, 65, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(6607), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9543), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9546), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9569), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(1806), new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9414), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9416), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9418), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(5840), new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(432), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 76, DateTimeKind.Local).AddTicks(105), new DateTime(2024, 8, 5, 13, 5, 14, 76, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 71, DateTimeKind.Local).AddTicks(3049), "04e6363d2d4b4d5488e84c0ddd34af91", "589773", new DateTime(2024, 8, 5, 13, 5, 14, 71, DateTimeKind.Local).AddTicks(3066) });
        }
    }
}
