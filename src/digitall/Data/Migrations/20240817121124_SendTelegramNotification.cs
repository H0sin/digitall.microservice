using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SendTelegramNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BotId",
                table: "TelegramBots",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "Send",
                table: "Notification",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 523547L, new DateTime(2024, 8, 17, 15, 41, 22, 727, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 8, 17, 15, 41, 22, 727, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(234), new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(9802), new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(480), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(490), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(494), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(503), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 8, 17, 15, 41, 22, 737, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 8, 17, 15, 41, 22, 735, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 738, DateTimeKind.Local).AddTicks(1558), new DateTime(2024, 8, 17, 15, 41, 22, 738, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(3192), new DateTime(2024, 8, 17, 15, 41, 22, 736, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 41, 22, 733, DateTimeKind.Local).AddTicks(2704), "9925e444d64f4e599e93eced50b37c99", "555883", new DateTime(2024, 8, 17, 15, 41, 22, 733, DateTimeKind.Local).AddTicks(2721) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BotId",
                table: "TelegramBots");

            migrationBuilder.DropColumn(
                name: "Send",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 671680L, new DateTime(2024, 8, 17, 12, 0, 1, 942, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 8, 17, 12, 0, 1, 942, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(2175), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(2488), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3371), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3374), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3388), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 949, DateTimeKind.Local).AddTicks(1148), new DateTime(2024, 8, 17, 12, 0, 1, 949, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9269), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9624), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9631), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9636), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9637), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 949, DateTimeKind.Local).AddTicks(3401), new DateTime(2024, 8, 17, 12, 0, 1, 949, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 947, DateTimeKind.Local).AddTicks(7702), new DateTime(2024, 8, 17, 12, 0, 1, 947, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 947, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 8, 17, 12, 0, 1, 947, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 947, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 8, 17, 12, 0, 1, 947, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 949, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 8, 17, 12, 0, 1, 949, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(5168), new DateTime(2024, 8, 17, 12, 0, 1, 948, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 0, 1, 946, DateTimeKind.Local).AddTicks(2381), "fa2a73cef65d4f478b2c4890892309b3", "207420", new DateTime(2024, 8, 17, 12, 0, 1, 946, DateTimeKind.Local).AddTicks(2399) });
        }
    }
}
