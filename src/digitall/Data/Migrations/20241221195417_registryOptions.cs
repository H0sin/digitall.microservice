using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class registryOptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardHolderName",
                table: "RegistrationOptions",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "RegistrationOptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Shaba",
                table: "RegistrationOptions",
                type: "decimal(20,0)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 296830L, new DateTime(2024, 12, 21, 23, 24, 15, 604, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 12, 21, 23, 24, 15, 604, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(4572), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5435), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5441), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5453), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(6145), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(6508), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(6510), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(2709), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3046), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3048), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3063), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3065), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3066), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3068), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3070), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3072), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 12, 21, 23, 24, 15, 620, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1056), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 621, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 12, 21, 23, 24, 15, 621, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 621, DateTimeKind.Local).AddTicks(8459), new DateTime(2024, 12, 21, 23, 24, 15, 621, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 621, DateTimeKind.Local).AddTicks(3684), new DateTime(2024, 12, 21, 23, 24, 15, 621, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(8205), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(8251), new DateTime(2024, 12, 21, 23, 24, 15, 619, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 15, 618, DateTimeKind.Local).AddTicks(307), "570baea596c341d4a0ca67cdac2ca52d", "90067", new DateTime(2024, 12, 21, 23, 24, 15, 618, DateTimeKind.Local).AddTicks(326) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardHolderName",
                table: "RegistrationOptions");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "RegistrationOptions");

            migrationBuilder.DropColumn(
                name: "Shaba",
                table: "RegistrationOptions");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 305383L, new DateTime(2024, 12, 19, 17, 39, 59, 388, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 12, 19, 17, 39, 59, 388, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7441), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7455), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6083), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3388), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3648), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3664), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7771), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7786), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7788), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1891), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(2929), new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 396, DateTimeKind.Local).AddTicks(6203), "82c960499e1d4ed6b5578077fc79ab32", "153553", new DateTime(2024, 12, 19, 17, 39, 59, 396, DateTimeKind.Local).AddTicks(6227) });
        }
    }
}
