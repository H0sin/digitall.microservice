using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderDeatil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "MarzbanUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "MarzbanUsers");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 463514L, new DateTime(2024, 9, 15, 13, 48, 37, 796, DateTimeKind.Local).AddTicks(2175), new DateTime(2024, 9, 15, 13, 48, 37, 796, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6441), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(4348), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2358), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2680), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2682), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2684), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2689), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2691), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2692), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2697), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2699), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(6484), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(8268), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 799, DateTimeKind.Local).AddTicks(6396), "7abc4becf28349a3a48518b06dfdcd8e", "85172", new DateTime(2024, 9, 15, 13, 48, 37, 799, DateTimeKind.Local).AddTicks(6406) });
        }
    }
}
