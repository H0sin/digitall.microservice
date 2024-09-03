using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class longas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "OnHoldExpireDuration",
                table: "MarzbanUsers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OnHoldExpireDuration",
                table: "MarzbanUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 263202L, new DateTime(2024, 9, 3, 19, 48, 28, 603, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 9, 3, 19, 48, 28, 603, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2229), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2551), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3383), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3385), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3387), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9223), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9225), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(3513), new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 615, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 9, 3, 19, 48, 28, 615, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(7878), new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 611, DateTimeKind.Local).AddTicks(5906), "7fdc066dae964e208faca53a2bdc953f", "982199", new DateTime(2024, 9, 3, 19, 48, 28, 611, DateTimeKind.Local).AddTicks(5920) });
        }
    }
}
