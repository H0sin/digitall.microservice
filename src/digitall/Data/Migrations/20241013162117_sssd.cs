using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class sssd : Migration
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
                values: new object[] { 763194L, new DateTime(2024, 10, 13, 19, 51, 16, 668, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 10, 13, 19, 51, 16, 668, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(8466), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9191), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(4972), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3477), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3735), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3775), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3776), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3778), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3782), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(6435), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(5128), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 10, 13, 19, 51, 16, 673, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 675, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 10, 13, 19, 51, 16, 675, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 675, DateTimeKind.Local).AddTicks(2390), new DateTime(2024, 10, 13, 19, 51, 16, 675, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(8927), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 10, 13, 19, 51, 16, 674, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 51, 16, 672, DateTimeKind.Local).AddTicks(5036), "e3af8f2ab103422a8b91314630138d7a", "231165", new DateTime(2024, 10, 13, 19, 51, 16, 672, DateTimeKind.Local).AddTicks(5050) });

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
