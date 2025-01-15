using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addPhoneForRegistry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Registries",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 628356L, new DateTime(2024, 12, 18, 19, 3, 6, 167, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 12, 18, 19, 3, 6, 167, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8064), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8066), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8068), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8082), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2623), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2879), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2885), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2890), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2895), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(5972), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3679), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3677), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(8539), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9650), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 181, DateTimeKind.Local).AddTicks(2608), "b4ec16fb86df48dd874d8be69822a040", "854813", new DateTime(2024, 12, 18, 19, 3, 6, 181, DateTimeKind.Local).AddTicks(2621) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Registries");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 403720L, new DateTime(2024, 12, 18, 18, 17, 22, 970, DateTimeKind.Local).AddTicks(9053), new DateTime(2024, 12, 18, 18, 17, 22, 970, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5434), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5439), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(3031), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1174), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1482), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1595), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1597), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1598), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1603), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1604), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9942), new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9981), new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 12, 18, 18, 17, 22, 984, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 12, 18, 18, 17, 22, 987, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 987, DateTimeKind.Local).AddTicks(2078), new DateTime(2024, 12, 18, 18, 17, 22, 987, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(7818), new DateTime(2024, 12, 18, 18, 17, 22, 986, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(7663), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 12, 18, 18, 17, 22, 985, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 17, 22, 983, DateTimeKind.Local).AddTicks(3839), "3657b13dc1d642d8a77bb83447208d53", "990870", new DateTime(2024, 12, 18, 18, 17, 22, 983, DateTimeKind.Local).AddTicks(3852) });
        }
    }
}
