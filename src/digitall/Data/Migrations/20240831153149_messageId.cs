using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class messageId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 528504L, new DateTime(2024, 8, 31, 19, 1, 47, 333, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 8, 31, 19, 1, 47, 333, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(4689), new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5081), new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5903), new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5908), new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5924), new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(5200), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3198), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 8, 31, 19, 1, 47, 340, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 338, DateTimeKind.Local).AddTicks(8520), new DateTime(2024, 8, 31, 19, 1, 47, 338, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 338, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 8, 31, 19, 1, 47, 338, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 338, DateTimeKind.Local).AddTicks(8572), new DateTime(2024, 8, 31, 19, 1, 47, 338, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 341, DateTimeKind.Local).AddTicks(3736), new DateTime(2024, 8, 31, 19, 1, 47, 341, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 341, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 8, 31, 19, 1, 47, 341, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(8006), new DateTime(2024, 8, 31, 19, 1, 47, 339, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MessageId", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 337, DateTimeKind.Local).AddTicks(5489), "ce906ded88ce43e9b4ce4cdacb1fd5a7", null, "412602", new DateTime(2024, 8, 31, 19, 1, 47, 337, DateTimeKind.Local).AddTicks(5517) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 961789L, new DateTime(2024, 8, 30, 19, 49, 50, 143, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 8, 30, 19, 49, 50, 143, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3210), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4502), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(2790), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1111), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(6814), new DateTime(2024, 8, 30, 19, 49, 50, 160, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 8, 30, 19, 49, 50, 158, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(4421), new DateTime(2024, 8, 30, 19, 49, 50, 161, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 8, 30, 19, 49, 50, 159, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 49, 50, 157, DateTimeKind.Local).AddTicks(5369), "2d6d9790e97b43d49aaa9158e8b2716d", "329069", new DateTime(2024, 8, 30, 19, 49, 50, 157, DateTimeKind.Local).AddTicks(5389) });
        }
    }
}
