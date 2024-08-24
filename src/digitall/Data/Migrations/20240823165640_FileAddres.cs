using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FileAddres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileAddress",
                table: "Notification",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileAddress",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 421678L, new DateTime(2024, 8, 23, 19, 25, 40, 915, DateTimeKind.Local).AddTicks(608), new DateTime(2024, 8, 23, 19, 25, 40, 915, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3349), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3366), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(8916), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9219), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9223), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9225), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9232), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9234), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9238), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7936), new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7951), new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7953), new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(5240), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 918, DateTimeKind.Local).AddTicks(6885), "fa0b423df77b4b8ca8d56ba0b810d3b1", "22432", new DateTime(2024, 8, 23, 19, 25, 40, 918, DateTimeKind.Local).AddTicks(6893) });
        }
    }
}
