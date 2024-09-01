using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class datta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HolderBotInbound",
                table: "MarzbanVpns",
                newName: "ExpireDetailInbound");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 830842L, new DateTime(2024, 9, 1, 14, 45, 31, 149, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 9, 1, 14, 45, 31, 150, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(7555), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(6212), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4493), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4816), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4819), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4827), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(8308), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(2540), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(2557), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(2559), new DateTime(2024, 9, 1, 14, 45, 31, 155, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 157, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 9, 1, 14, 45, 31, 157, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 157, DateTimeKind.Local).AddTicks(1551), new DateTime(2024, 9, 1, 14, 45, 31, 157, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(483), new DateTime(2024, 9, 1, 14, 45, 31, 156, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 45, 31, 154, DateTimeKind.Local).AddTicks(1735), "df7707d409914440a5959da37d362d87", "833671", new DateTime(2024, 9, 1, 14, 45, 31, 154, DateTimeKind.Local).AddTicks(1742) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpireDetailInbound",
                table: "MarzbanVpns",
                newName: "HolderBotInbound");

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
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 1, 47, 337, DateTimeKind.Local).AddTicks(5489), "ce906ded88ce43e9b4ce4cdacb1fd5a7", "412602", new DateTime(2024, 8, 31, 19, 1, 47, 337, DateTimeKind.Local).AddTicks(5517) });
        }
    }
}
