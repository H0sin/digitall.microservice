using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderDeatril : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 658929L, new DateTime(2024, 8, 20, 16, 49, 41, 18, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 8, 20, 16, 49, 41, 18, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6517), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6917), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8387), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2179), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2202), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 8, 20, 16, 49, 41, 23, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 25, DateTimeKind.Local).AddTicks(1742), new DateTime(2024, 8, 20, 16, 49, 41, 25, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(402), new DateTime(2024, 8, 20, 16, 49, 41, 24, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 49, 41, 22, DateTimeKind.Local).AddTicks(1082), "984265db65614672827d9cb433dcd5c7", "176740", new DateTime(2024, 8, 20, 16, 49, 41, 22, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.CreateIndex(
                name: "IX_AgentsIncomesDetail_OrderDetailId",
                table: "AgentsIncomesDetail",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_AgentsIncomesDetail_OrderDetail_OrderDetailId",
                table: "AgentsIncomesDetail",
                column: "OrderDetailId",
                principalTable: "OrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgentsIncomesDetail_OrderDetail_OrderDetailId",
                table: "AgentsIncomesDetail");

            migrationBuilder.DropIndex(
                name: "IX_AgentsIncomesDetail_OrderDetailId",
                table: "AgentsIncomesDetail");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 724402L, new DateTime(2024, 8, 20, 13, 47, 21, 436, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 8, 20, 13, 47, 21, 436, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8454), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6535), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6537), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(3886), new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2397), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(7686), new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(331), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 446, DateTimeKind.Local).AddTicks(9950), "09afd13a92a2423c9750c144de6e612f", "520129", new DateTime(2024, 8, 20, 13, 47, 21, 446, DateTimeKind.Local).AddTicks(9983) });
        }
    }
}
