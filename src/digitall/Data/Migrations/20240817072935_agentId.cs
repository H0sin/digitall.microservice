using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class agentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AgentId",
                table: "AgentRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "AgentRequest");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 751935L, new DateTime(2024, 8, 8, 10, 24, 51, 285, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 8, 8, 10, 24, 51, 285, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(7764), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(464), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(576), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1473), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1483), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1489), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1492), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1494), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 8, 8, 10, 24, 51, 331, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 8, 8, 10, 24, 51, 329, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 332, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 8, 8, 10, 24, 51, 332, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 8, 8, 10, 24, 51, 330, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 8, 10, 24, 51, 327, DateTimeKind.Local).AddTicks(1230), "da295f02a39b45ceb977cbfa230bf8c7", "619799", new DateTime(2024, 8, 8, 10, 24, 51, 327, DateTimeKind.Local).AddTicks(1252) });
        }
    }
}
