using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TransactionDeatilIdChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TransactionDetailId",
                table: "Transactions",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 665117L, new DateTime(2024, 8, 22, 20, 32, 27, 151, DateTimeKind.Local).AddTicks(1946), new DateTime(2024, 8, 22, 20, 32, 27, 151, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2567), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2587), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3147), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3151), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3155), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3164), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3728), new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3756), new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3759), new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 161, DateTimeKind.Local).AddTicks(3071), new DateTime(2024, 8, 22, 20, 32, 27, 161, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 156, DateTimeKind.Local).AddTicks(4112), "5395dcb39e034aa6894bd69ce4b1fe18", "814848", new DateTime(2024, 8, 22, 20, 32, 27, 156, DateTimeKind.Local).AddTicks(4128) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TransactionDetailId",
                table: "Transactions",
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
                values: new object[] { 547638L, new DateTime(2024, 8, 22, 11, 46, 13, 455, DateTimeKind.Local).AddTicks(8942), new DateTime(2024, 8, 22, 11, 46, 13, 455, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(429), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(806), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1651), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1654), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1663), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(8863), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7454), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7457), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7460), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7467), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7468), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7474), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 462, DateTimeKind.Local).AddTicks(1631), new DateTime(2024, 8, 22, 11, 46, 13, 462, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 460, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 8, 22, 11, 46, 13, 460, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 460, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 8, 22, 11, 46, 13, 460, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 460, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 8, 22, 11, 46, 13, 460, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 462, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 8, 22, 11, 46, 13, 462, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 8, 22, 11, 46, 13, 461, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 11, 46, 13, 459, DateTimeKind.Local).AddTicks(6295), "1af3ea0342bc4510ab8f12cb84c7e696", "603210", new DateTime(2024, 8, 22, 11, 46, 13, 459, DateTimeKind.Local).AddTicks(6302) });
        }
    }
}
