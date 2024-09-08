using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class s : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileCaption",
                table: "Notification",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 512061L, new DateTime(2024, 8, 24, 15, 8, 7, 78, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 8, 24, 15, 8, 7, 78, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(1922), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(2374), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3292), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3299), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(424), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(921), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(925), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(932), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(933), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(9111), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(5453), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 84, DateTimeKind.Local).AddTicks(1381), "ab0f7fc460d9414abdcd5abf29433552", "40953", new DateTime(2024, 8, 24, 15, 8, 7, 84, DateTimeKind.Local).AddTicks(1401) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileCaption",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 702391L, new DateTime(2024, 8, 23, 20, 26, 39, 310, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 8, 23, 20, 26, 39, 310, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1351), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7548), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7554), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7555), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7557), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7558), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7561), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7563), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 317, DateTimeKind.Local).AddTicks(1681), new DateTime(2024, 8, 23, 20, 26, 39, 317, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 315, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 8, 23, 20, 26, 39, 315, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 315, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 8, 23, 20, 26, 39, 315, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 315, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 8, 23, 20, 26, 39, 315, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 317, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 8, 23, 20, 26, 39, 317, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(3626), new DateTime(2024, 8, 23, 20, 26, 39, 316, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 26, 39, 314, DateTimeKind.Local).AddTicks(4348), "7dae1da7cdd34e11b4d81c02ff70d7c9", "279048", new DateTime(2024, 8, 23, 20, 26, 39, 314, DateTimeKind.Local).AddTicks(4355) });
        }
    }
}
