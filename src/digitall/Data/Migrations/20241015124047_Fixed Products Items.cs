using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedProductsItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "CategoryType",
                table: "Category",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 523468L, new DateTime(2024, 10, 15, 15, 32, 37, 708, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 10, 15, 15, 32, 37, 708, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(6043), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4557), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4576), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4581), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4583), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5839), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5859), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5861), new DateTime(2024, 10, 15, 15, 32, 37, 726, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 10, 15, 15, 32, 37, 728, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 10, 15, 15, 32, 37, 727, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 32, 37, 725, DateTimeKind.Local).AddTicks(5757), "f95021a8b0484841bd7871e5b35dd630", "117466", new DateTime(2024, 10, 15, 15, 32, 37, 725, DateTimeKind.Local).AddTicks(5773) });
        }
    }
}
