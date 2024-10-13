using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class releationMarzbanVpn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_MarzbanUsers_MarzbanVpnId",
                table: "MarzbanUsers",
                column: "MarzbanVpnId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarzbanUsers_MarzbanVpns_MarzbanVpnId",
                table: "MarzbanUsers",
                column: "MarzbanVpnId",
                principalTable: "MarzbanVpns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarzbanUsers_MarzbanVpns_MarzbanVpnId",
                table: "MarzbanUsers");

            migrationBuilder.DropIndex(
                name: "IX_MarzbanUsers_MarzbanVpnId",
                table: "MarzbanUsers");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 874841L, new DateTime(2024, 9, 18, 13, 15, 38, 175, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 9, 18, 13, 15, 38, 175, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(5185), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3699), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3707), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3708), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3713), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 9, 18, 13, 15, 38, 181, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2710), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2724), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2726), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 9, 18, 13, 15, 38, 182, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(9458), new DateTime(2024, 9, 18, 13, 15, 38, 180, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 15, 38, 179, DateTimeKind.Local).AddTicks(1318), "a1e5251c805843bd8a2cabdcd1780c76", "813324", new DateTime(2024, 9, 18, 13, 15, 38, 179, DateTimeKind.Local).AddTicks(1326) });
        }
    }
}
