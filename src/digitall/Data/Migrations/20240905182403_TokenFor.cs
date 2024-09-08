using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TokenFor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "MarzbanServers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 289195L, new DateTime(2024, 9, 5, 21, 54, 2, 807, DateTimeKind.Local).AddTicks(6317), new DateTime(2024, 9, 5, 21, 54, 2, 807, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(1348), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(1715), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2516), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2530), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 814, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 9, 5, 21, 54, 2, 814, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8293), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8658), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8660), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8669), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8673), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8675), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 814, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 9, 5, 21, 54, 2, 814, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 812, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 9, 5, 21, 54, 2, 812, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 812, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 9, 5, 21, 54, 2, 812, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 812, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 9, 5, 21, 54, 2, 812, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 815, DateTimeKind.Local).AddTicks(465), new DateTime(2024, 9, 5, 21, 54, 2, 815, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 815, DateTimeKind.Local).AddTicks(3034), new DateTime(2024, 9, 5, 21, 54, 2, 815, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 814, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 9, 5, 21, 54, 2, 814, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(4309), new DateTime(2024, 9, 5, 21, 54, 2, 813, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 54, 2, 811, DateTimeKind.Local).AddTicks(5259), "d7911b9723c44b51b60fa6dbd02f069f", "388544", new DateTime(2024, 9, 5, 21, 54, 2, 811, DateTimeKind.Local).AddTicks(5272) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "MarzbanServers");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 857588L, new DateTime(2024, 9, 5, 15, 40, 58, 883, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 9, 5, 15, 40, 58, 883, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1558), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2740), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2743), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2746), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2757), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9006), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9016), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9023), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7286), new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7305), new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 9, 5, 15, 40, 58, 891, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 891, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 9, 5, 15, 40, 58, 891, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(6509), new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(4527), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 887, DateTimeKind.Local).AddTicks(4941), "4bc41dceb8db4776b8566e39d3768c5b", "286390", new DateTime(2024, 9, 5, 15, 40, 58, 887, DateTimeKind.Local).AddTicks(4952) });
        }
    }
}
