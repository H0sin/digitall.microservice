using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class BotId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BotId",
                table: "Users",
                type: "bigint",
                nullable: true);

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
                columns: new[] { "BotId", "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { null, new DateTime(2024, 8, 17, 12, 0, 1, 946, DateTimeKind.Local).AddTicks(2381), "fa2a73cef65d4f478b2c4890892309b3", "207420", new DateTime(2024, 8, 17, 12, 0, 1, 946, DateTimeKind.Local).AddTicks(2399) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BotId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 274683L, new DateTime(2024, 8, 17, 10, 59, 32, 698, DateTimeKind.Local).AddTicks(3377), new DateTime(2024, 8, 17, 10, 59, 32, 698, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(2992), new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(3459), new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4484), new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4487), new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(5964), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(2784), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3468), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3473), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3475), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3480), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3483), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3488), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3490), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(9038), new DateTime(2024, 8, 17, 10, 59, 32, 705, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 703, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 8, 17, 10, 59, 32, 703, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 703, DateTimeKind.Local).AddTicks(7686), new DateTime(2024, 8, 17, 10, 59, 32, 703, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 703, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 8, 17, 10, 59, 32, 703, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 706, DateTimeKind.Local).AddTicks(1729), new DateTime(2024, 8, 17, 10, 59, 32, 706, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 8, 17, 10, 59, 32, 704, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 10, 59, 32, 702, DateTimeKind.Local).AddTicks(1713), "946ae18a3ea648c7b05937969f7e8c34", "903535", new DateTime(2024, 8, 17, 10, 59, 32, 702, DateTimeKind.Local).AddTicks(1727) });
        }
    }
}
