using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ali2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 198249L, new DateTime(2024, 9, 3, 22, 31, 28, 182, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 9, 3, 22, 31, 28, 182, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(441), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 190, DateTimeKind.Local).AddTicks(553), new DateTime(2024, 9, 3, 22, 31, 28, 190, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7817), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7819), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 190, DateTimeKind.Local).AddTicks(5073), new DateTime(2024, 9, 3, 22, 31, 28, 190, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(4550), new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 9, 3, 22, 31, 28, 188, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 191, DateTimeKind.Local).AddTicks(2823), new DateTime(2024, 9, 3, 22, 31, 28, 191, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 191, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 9, 3, 22, 31, 28, 191, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(2427), new DateTime(2024, 9, 3, 22, 31, 28, 189, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 31, 28, 186, DateTimeKind.Local).AddTicks(4953), "410457c8bbc549a38a35205cf5538df0", "258618", new DateTime(2024, 9, 3, 22, 31, 28, 186, DateTimeKind.Local).AddTicks(4967) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 101525L, new DateTime(2024, 9, 3, 20, 46, 6, 73, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 9, 3, 20, 46, 6, 73, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9426), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(216), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(218), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(7873), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6068), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6083), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 78, DateTimeKind.Local).AddTicks(9112), "93558a737ea4467c958aea564ca2875e", "544135", new DateTime(2024, 9, 3, 20, 46, 6, 78, DateTimeKind.Local).AddTicks(9130) });
        }
    }
}
