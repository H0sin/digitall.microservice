using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class nullabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "MarzbanVpnId",
                table: "MarzbanUsers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 306827L, new DateTime(2024, 10, 13, 19, 38, 44, 597, DateTimeKind.Local).AddTicks(5202), new DateTime(2024, 10, 13, 19, 38, 44, 597, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7796), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7798), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7818), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2141), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2342), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2344), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2384), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(3619), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 10, 13, 19, 38, 44, 609, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 609, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 10, 13, 19, 38, 44, 609, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(7900), new DateTime(2024, 10, 13, 19, 38, 44, 608, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 10, 13, 19, 38, 44, 607, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 38, 44, 606, DateTimeKind.Local).AddTicks(3528), "b038a0c6c70744c88ada646f53087344", "752842", new DateTime(2024, 10, 13, 19, 38, 44, 606, DateTimeKind.Local).AddTicks(3543) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "MarzbanVpnId",
                table: "MarzbanUsers",
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
                values: new object[] { 974751L, new DateTime(2024, 10, 13, 19, 31, 5, 785, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 10, 13, 19, 31, 5, 785, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4393), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4856), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9512), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9534), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9542), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9544), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9546), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9547), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(137), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(157), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(159), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(8855), new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 10, 13, 19, 31, 5, 796, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 10, 13, 19, 31, 5, 795, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 31, 5, 793, DateTimeKind.Local).AddTicks(5048), "5f80f7abbdcb41f3a285f46d44d64d05", "608907", new DateTime(2024, 10, 13, 19, 31, 5, 793, DateTimeKind.Local).AddTicks(5065) });
        }
    }
}
