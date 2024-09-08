using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Desired",
                table: "MarzbanVpns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HolderBotInbound",
                table: "MarzbanVpns",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 334478L, new DateTime(2024, 8, 30, 19, 13, 19, 865, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 8, 30, 19, 13, 19, 865, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(3960), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(4378), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5175), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5194), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(2780), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1014), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1335), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1338), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1344), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1345), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1347), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1352), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 8, 30, 19, 13, 19, 871, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 874, DateTimeKind.Local).AddTicks(1446), new DateTime(2024, 8, 30, 19, 13, 19, 874, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 8, 30, 19, 13, 19, 873, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 8, 30, 19, 13, 19, 872, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 13, 19, 870, DateTimeKind.Local).AddTicks(1556), "ba72131c6dad419bad010cdfcc27b7f9", "155923", new DateTime(2024, 8, 30, 19, 13, 19, 870, DateTimeKind.Local).AddTicks(1573) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desired",
                table: "MarzbanVpns");

            migrationBuilder.DropColumn(
                name: "HolderBotInbound",
                table: "MarzbanVpns");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 976639L, new DateTime(2024, 8, 28, 15, 12, 38, 892, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 8, 28, 15, 12, 38, 892, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7636), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(5745), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(3845), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4163), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4167), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 8, 28, 15, 12, 38, 898, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(2035), new DateTime(2024, 8, 28, 15, 12, 38, 899, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 8, 28, 15, 12, 38, 897, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 12, 38, 895, DateTimeKind.Local).AddTicks(8189), "1d528897d8124ada92b982745145c72b", "14728", new DateTime(2024, 8, 28, 15, 12, 38, 895, DateTimeKind.Local).AddTicks(8197) });
        }
    }
}
