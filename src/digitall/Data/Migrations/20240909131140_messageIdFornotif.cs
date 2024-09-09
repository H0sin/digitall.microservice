using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class messageIdFornotif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Forward",
                table: "Notification",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "ForwarderChatId",
                table: "Notification",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Notification",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 758097L, new DateTime(2024, 9, 9, 16, 41, 38, 587, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 9, 9, 16, 41, 38, 587, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9725), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9728), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9730), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9744), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5229), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5533), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5546), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5552), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4542), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4544), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(2206), new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 591, DateTimeKind.Local).AddTicks(1028), "6a6d917b556543209bbab489cc09ceac", "898907", new DateTime(2024, 9, 9, 16, 41, 38, 591, DateTimeKind.Local).AddTicks(1037) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Forward",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "ForwarderChatId",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 909338L, new DateTime(2024, 9, 8, 20, 16, 43, 139, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 9, 8, 20, 16, 43, 139, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(3342), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(352), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1003), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1009), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1022), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1358), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 155, DateTimeKind.Local).AddTicks(2323), new DateTime(2024, 9, 8, 20, 16, 43, 155, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 149, DateTimeKind.Local).AddTicks(1458), "90fed7aac211490ca118ada20da7386c", "321230", new DateTime(2024, 9, 8, 20, 16, 43, 149, DateTimeKind.Local).AddTicks(1479) });
        }
    }
}
