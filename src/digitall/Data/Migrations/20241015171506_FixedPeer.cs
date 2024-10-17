using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedPeer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TotalDay",
                table: "Peers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TotalVolume",
                table: "Peers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Peers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 379643L, new DateTime(2024, 10, 15, 20, 45, 4, 792, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 10, 15, 20, 45, 4, 792, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(299), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6214), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 10, 15, 20, 45, 4, 797, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(3503), new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(1553), new DateTime(2024, 10, 15, 20, 45, 4, 799, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 10, 15, 20, 45, 4, 798, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 45, 4, 796, DateTimeKind.Local).AddTicks(7081), "4280ea57768e4de98ca7f970d0d1d894", "587570", new DateTime(2024, 10, 15, 20, 45, 4, 796, DateTimeKind.Local).AddTicks(7092) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalDay",
                table: "Peers");

            migrationBuilder.DropColumn(
                name: "TotalVolume",
                table: "Peers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Peers");

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
    }
}
