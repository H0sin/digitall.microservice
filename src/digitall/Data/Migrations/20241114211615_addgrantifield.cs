using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addgrantifield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Warranty",
                table: "AppleIdTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 687209L, new DateTime(2024, 11, 15, 0, 46, 13, 524, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 11, 15, 0, 46, 13, 524, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4551), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9673), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9874), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9887), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(2710), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9363), new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9376), new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(5276), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 532, DateTimeKind.Local).AddTicks(9607), "0a450bae3a3345d4a517adeb6467fe9d", "344583", new DateTime(2024, 11, 15, 0, 46, 13, 532, DateTimeKind.Local).AddTicks(9620) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Warranty",
                table: "AppleIdTypes");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 829125L, new DateTime(2024, 11, 11, 0, 47, 8, 868, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 11, 11, 0, 47, 8, 868, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1705), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1875), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2328), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(7880), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6749), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6752), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6754), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8557), new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 876, DateTimeKind.Local).AddTicks(8245), "cf48de7b3192418b8e72729584565ab0", "751658", new DateTime(2024, 11, 11, 0, 47, 8, 876, DateTimeKind.Local).AddTicks(8259) });
        }
    }
}
