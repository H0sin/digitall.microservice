using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class notificationDto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Execption",
                table: "Notification",
                type: "nvarchar(max)",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Execption",
                table: "Notification");

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
    }
}
