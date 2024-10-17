using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRelationProductToVpn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Vpn_VpnId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_VpnId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 240973L, new DateTime(2024, 10, 15, 16, 16, 25, 356, DateTimeKind.Local).AddTicks(1783), new DateTime(2024, 10, 15, 16, 16, 25, 356, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5445), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(2838), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1658), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1662), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1664), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1669), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1672), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1673), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1675), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1677), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(837), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(9030), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 363, DateTimeKind.Local).AddTicks(753), new DateTime(2024, 10, 15, 16, 16, 25, 363, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 10, 15, 16, 16, 25, 362, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(7917), new DateTime(2024, 10, 15, 16, 16, 25, 361, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 16, 25, 359, DateTimeKind.Local).AddTicks(5871), "61ccbc364bf740c99c7621f3f82dbcf9", "910223", new DateTime(2024, 10, 15, 16, 16, 25, 359, DateTimeKind.Local).AddTicks(5887) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 405670L, new DateTime(2024, 10, 15, 16, 10, 46, 636, DateTimeKind.Local).AddTicks(7488), new DateTime(2024, 10, 15, 16, 10, 46, 636, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(2259), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3059), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3063), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7334), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7526), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7579), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7581), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7582), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7585), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7587), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 652, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 10, 15, 16, 10, 46, 652, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 652, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 10, 15, 16, 10, 46, 652, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 652, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 10, 15, 16, 10, 46, 652, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(5046), new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(3109), new DateTime(2024, 10, 15, 16, 10, 46, 654, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(4400), new DateTime(2024, 10, 15, 16, 10, 46, 653, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 10, 46, 651, DateTimeKind.Local).AddTicks(7284), "f5cf7ab5871c4b20abb61dfe459a3f9f", "889732", new DateTime(2024, 10, 15, 16, 10, 46, 651, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.CreateIndex(
                name: "IX_Product_VpnId",
                table: "Product",
                column: "VpnId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Vpn_VpnId",
                table: "Product",
                column: "VpnId",
                principalTable: "Vpn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
