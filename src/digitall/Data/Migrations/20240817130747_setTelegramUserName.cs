using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class setTelegramUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelegramUsername",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 935372L, new DateTime(2024, 8, 17, 16, 37, 46, 493, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 8, 17, 16, 37, 46, 493, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7269), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7271), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(2669), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3005), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3014), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(6622), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2046), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2063), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2065), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate", "TelegramUsername" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 497, DateTimeKind.Local).AddTicks(1332), "9ac8655b77554162b1d444382572dd1c", "228956", new DateTime(2024, 8, 17, 16, 37, 46, 497, DateTimeKind.Local).AddTicks(1344), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelegramUsername",
                table: "Users");

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
    }
}
