using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class CardToCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelegramUsername",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CardToCardPayment",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AgentRequest",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

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
                columns: new[] { "CardToCardPayment", "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { false, new DateTime(2024, 8, 22, 11, 46, 13, 459, DateTimeKind.Local).AddTicks(6295), "1af3ea0342bc4510ab8f12cb84c7e696", "603210", new DateTime(2024, 8, 22, 11, 46, 13, 459, DateTimeKind.Local).AddTicks(6302) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardToCardPayment",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AgentRequest");

            migrationBuilder.AlterColumn<string>(
                name: "TelegramUsername",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 644357L, new DateTime(2024, 8, 21, 18, 6, 32, 127, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 8, 21, 18, 6, 32, 128, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(2779), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(3500), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5279), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5282), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3725), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3733), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3735), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 8, 21, 18, 6, 32, 137, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2246), new DateTime(2024, 8, 21, 18, 6, 32, 135, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 138, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 8, 21, 18, 6, 32, 138, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 8, 21, 18, 6, 32, 136, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 18, 6, 32, 132, DateTimeKind.Local).AddTicks(6589), "7972dc3861754b6dad54fee0db416ce8", "163199", new DateTime(2024, 8, 21, 18, 6, 32, 132, DateTimeKind.Local).AddTicks(6620) });
        }
    }
}
