using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class maxlen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 398962L, new DateTime(2024, 9, 4, 12, 55, 20, 1, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 9, 4, 12, 55, 20, 1, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5819), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5821), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5828), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5833), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5837), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(9884), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(3968), new DateTime(2024, 9, 4, 12, 55, 20, 6, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 8, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 9, 4, 12, 55, 20, 8, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 8, DateTimeKind.Local).AddTicks(3624), new DateTime(2024, 9, 4, 12, 55, 20, 8, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(1357), new DateTime(2024, 9, 4, 12, 55, 20, 7, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 55, 20, 5, DateTimeKind.Local).AddTicks(1926), "45d8b495aa7949f6a696d1eaac80241e", "712235", new DateTime(2024, 9, 4, 12, 55, 20, 5, DateTimeKind.Local).AddTicks(1940) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
