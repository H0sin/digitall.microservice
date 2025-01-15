using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initialforaddedregistry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeI_1 = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    ImeI_2 = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    AcceptTheRules = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registries", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registries");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 953396L, new DateTime(2024, 12, 5, 1, 58, 11, 833, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 12, 5, 1, 58, 11, 833, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(1849), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2502), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(358), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8297), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8309), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8313), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8427), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8447), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 12, 5, 1, 58, 11, 837, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(6873), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(8629), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 12, 5, 1, 58, 11, 839, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4051), new DateTime(2024, 12, 5, 1, 58, 11, 838, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 58, 11, 836, DateTimeKind.Local).AddTicks(8245), "e0692a5208bf4a5498ec86930534b033", "627757", new DateTime(2024, 12, 5, 1, 58, 11, 836, DateTimeKind.Local).AddTicks(8253) });
        }
    }
}
