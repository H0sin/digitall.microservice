using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class changeRequestAgentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AgentRequestStatus",
                table: "Agent",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "AgentRequestStatus", "CreateDate", "ModifiedDate" },
                values: new object[] { 692437L, "Wating", new DateTime(2024, 7, 23, 11, 13, 35, 495, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 7, 23, 11, 13, 35, 495, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(3196), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(4485), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8433), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 507, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 7, 23, 11, 13, 35, 507, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(7778), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 508, DateTimeKind.Local).AddTicks(2469), new DateTime(2024, 7, 23, 11, 13, 35, 508, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1134), new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 505, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 7, 23, 11, 13, 35, 505, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 500, DateTimeKind.Local).AddTicks(3344), "ad39bf8bd22c46b6904af6d639b7f4e8", "484566", new DateTime(2024, 7, 23, 11, 13, 35, 500, DateTimeKind.Local).AddTicks(3357) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "AgentRequestStatus",
                table: "Agent",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "AgentRequestStatus", "CreateDate", "ModifiedDate" },
                values: new object[] { 531661L, (byte)1, new DateTime(2024, 7, 23, 10, 8, 6, 389, DateTimeKind.Local).AddTicks(9376), new DateTime(2024, 7, 23, 10, 8, 6, 389, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6186), new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6205), new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6033), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6044), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6048), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6051), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6054), new DateTime(2024, 7, 23, 10, 8, 6, 398, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 399, DateTimeKind.Local).AddTicks(2659), new DateTime(2024, 7, 23, 10, 8, 6, 399, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 396, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 7, 23, 10, 8, 6, 396, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 396, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 7, 23, 10, 8, 6, 396, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 396, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 7, 23, 10, 8, 6, 396, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 7, 23, 10, 8, 6, 397, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 10, 8, 6, 395, DateTimeKind.Local).AddTicks(152), "bd651cfe3d784a7e87978f71b4aaeb39", "401241", new DateTime(2024, 7, 23, 10, 8, 6, 395, DateTimeKind.Local).AddTicks(161) });
        }
    }
}
