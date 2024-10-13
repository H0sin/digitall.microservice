using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class re2 : Migration
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
                values: new object[] { 333104L, new DateTime(2024, 10, 13, 19, 42, 54, 262, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 10, 13, 19, 42, 54, 262, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1111), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1125), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(900), new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8912), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8915), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8917), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8918), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8926), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8928), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8929), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8931), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8934), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8935), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(3131), new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 267, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 10, 13, 19, 42, 54, 267, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 267, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 10, 13, 19, 42, 54, 267, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 267, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 10, 13, 19, 42, 54, 267, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(8791), new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 270, DateTimeKind.Local).AddTicks(704), new DateTime(2024, 10, 13, 19, 42, 54, 270, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 10, 13, 19, 42, 54, 269, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(2813), new DateTime(2024, 10, 13, 19, 42, 54, 268, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 42, 54, 266, DateTimeKind.Local).AddTicks(6345), "0bb50bb671a347209a7a591883c05af4", "594463", new DateTime(2024, 10, 13, 19, 42, 54, 266, DateTimeKind.Local).AddTicks(6360) });

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
