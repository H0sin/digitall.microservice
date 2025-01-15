using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class registryStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ForWho",
                table: "Registries",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Status",
                table: "Registries",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Summery",
                table: "Registries",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForWho",
                table: "Registries");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Registries");

            migrationBuilder.DropColumn(
                name: "Summery",
                table: "Registries");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 844191L, new DateTime(2024, 12, 18, 17, 2, 4, 791, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 12, 18, 17, 2, 4, 791, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5072), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(758), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(981), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(984), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(985), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(993), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(995), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(998), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9016), new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9051), new DateTime(2024, 12, 18, 17, 2, 4, 812, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(8962), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 815, DateTimeKind.Local).AddTicks(906), new DateTime(2024, 12, 18, 17, 2, 4, 815, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 12, 18, 17, 2, 4, 814, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 12, 18, 17, 2, 4, 813, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 2, 4, 810, DateTimeKind.Local).AddTicks(8855), "ce8214825f5643e79db833049389984c", "109686", new DateTime(2024, 12, 18, 17, 2, 4, 810, DateTimeKind.Local).AddTicks(8906) });
        }
    }
}
