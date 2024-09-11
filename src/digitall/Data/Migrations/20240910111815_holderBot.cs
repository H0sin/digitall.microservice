using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class holderBot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpireDetailInbound",
                table: "MarzbanVpns");

            migrationBuilder.AddColumn<bool>(
                name: "AddedHolderInbound",
                table: "MarzbanUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HolderInbound",
                table: "MarzbanServers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeHolderInbound",
                table: "MarzbanServers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 604508L, new DateTime(2024, 9, 10, 14, 48, 13, 443, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 9, 10, 14, 48, 13, 443, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1951), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1966), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9892), new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9912), new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(1245), new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 446, DateTimeKind.Local).AddTicks(7998), "f56c593d5018465d928b99309c15b2c4", "450987", new DateTime(2024, 9, 10, 14, 48, 13, 446, DateTimeKind.Local).AddTicks(8011) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedHolderInbound",
                table: "MarzbanUsers");

            migrationBuilder.DropColumn(
                name: "HolderInbound",
                table: "MarzbanServers");

            migrationBuilder.DropColumn(
                name: "TypeHolderInbound",
                table: "MarzbanServers");

            migrationBuilder.AddColumn<string>(
                name: "ExpireDetailInbound",
                table: "MarzbanVpns",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 840655L, new DateTime(2024, 9, 9, 17, 6, 8, 346, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 9, 9, 17, 6, 8, 346, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1756), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1758), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8847), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8849), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8857), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8863), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8865), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(3494), new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5390), new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5425), new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(210), new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(7352), new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(3774), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 351, DateTimeKind.Local).AddTicks(8736), "e3093ff646704338ad5c6c18d75dbb08", "135014", new DateTime(2024, 9, 9, 17, 6, 8, 351, DateTimeKind.Local).AddTicks(8754) });
        }
    }
}
