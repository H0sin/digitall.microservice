using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class wireguardserverfixeditems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Port",
                table: "WireguardServers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Ssl",
                table: "WireguardServers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 580984L, new DateTime(2024, 10, 15, 18, 52, 18, 52, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 10, 15, 18, 52, 18, 52, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(9284), new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(7), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(9), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(5945), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4649), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4839), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4845), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4848), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(5912), new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(5930), new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 10, 15, 18, 52, 18, 69, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 71, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 10, 15, 18, 52, 18, 71, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 71, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 10, 15, 18, 52, 18, 71, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 71, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 10, 15, 18, 52, 18, 71, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 10, 15, 18, 52, 18, 70, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 18, 52, 18, 68, DateTimeKind.Local).AddTicks(5144), "10da9b66f450468088b21c54b86bb1c6", "935451", new DateTime(2024, 10, 15, 18, 52, 18, 68, DateTimeKind.Local).AddTicks(5158) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Port",
                table: "WireguardServers");

            migrationBuilder.DropColumn(
                name: "Ssl",
                table: "WireguardServers");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 751796L, new DateTime(2024, 10, 15, 16, 42, 36, 899, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 10, 15, 16, 42, 36, 899, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3306), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3855), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3858), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3873), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(9905), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8649), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8656), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9533), new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9554), new DateTime(2024, 10, 15, 16, 42, 36, 903, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(6475), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 10, 15, 16, 42, 36, 905, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(5346), new DateTime(2024, 10, 15, 16, 42, 36, 904, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 42, 36, 902, DateTimeKind.Local).AddTicks(8108), "e448c36f1bbf40e795036968deb04a98", "813638", new DateTime(2024, 10, 15, 16, 42, 36, 902, DateTimeKind.Local).AddTicks(8125) });
        }
    }
}
