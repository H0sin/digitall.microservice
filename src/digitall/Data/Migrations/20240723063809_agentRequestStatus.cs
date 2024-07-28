using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class agentRequestStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "AgentRequestStatus",
                table: "Agent",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentRequestStatus",
                table: "Agent");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 408974L, new DateTime(2024, 7, 22, 13, 8, 33, 315, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 7, 22, 13, 8, 33, 315, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4809), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4894), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(3845), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4602), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4607), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4612), new DateTime(2024, 7, 22, 13, 8, 33, 324, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 325, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 7, 22, 13, 8, 33, 325, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6086), new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6116), new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 7, 22, 13, 8, 33, 322, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(7788), new DateTime(2024, 7, 22, 13, 8, 33, 323, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 8, 33, 320, DateTimeKind.Local).AddTicks(9010), "fcde6054acd842f6a827825c17b04130", "815699", new DateTime(2024, 7, 22, 13, 8, 33, 320, DateTimeKind.Local).AddTicks(9019) });
        }
    }
}
