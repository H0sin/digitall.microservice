using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class nevigate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowNegative",
                table: "Agent",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "AmountWithNegative",
                table: "Agent",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "AllowNegative", "AmountWithNegative", "CreateDate", "ModifiedDate" },
                values: new object[] { 584678L, false, 0L, new DateTime(2024, 9, 2, 17, 3, 36, 274, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 9, 2, 17, 3, 36, 274, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3057), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3424), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4389), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4395), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4410), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(2407), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(795), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(803), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(7981), new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8005), new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 282, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 9, 2, 17, 3, 36, 282, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 278, DateTimeKind.Local).AddTicks(5694), "b37d0523275e4fa3b34bcb8a5bb58e3e", "994101", new DateTime(2024, 9, 2, 17, 3, 36, 278, DateTimeKind.Local).AddTicks(5708) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowNegative",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "AmountWithNegative",
                table: "Agent");

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
    }
}
