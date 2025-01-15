using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class amountmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Registries",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Registries",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionImages",
                table: "Registries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RegistrationOptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassportPrice = table.Column<long>(type: "bigint", nullable: false),
                    AgentShareFraction = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationOptions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 305383L, new DateTime(2024, 12, 19, 17, 39, 59, 388, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 12, 19, 17, 39, 59, 388, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7441), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7455), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "ParentId", "SystemName", "Title" },
                values: new object[] { 18L, 1L, new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6083), false, new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(6084), 1L, null, "UpdateRegistryAmountModel", "ارسال قیمت و مدل" });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3388), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3648), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3664), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7771), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7786), new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1891), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(2929), new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 12, 19, 17, 39, 59, 400, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 12, 19, 17, 39, 59, 398, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 39, 59, 396, DateTimeKind.Local).AddTicks(6203), "82c960499e1d4ed6b5578077fc79ab32", "153553", new DateTime(2024, 12, 19, 17, 39, 59, 396, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "PermissionId", "RoleId" },
                values: new object[] { 18L, 1L, new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7788), false, new DateTime(2024, 12, 19, 17, 39, 59, 399, DateTimeKind.Local).AddTicks(7789), 1L, 18L, 1L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationOptions");

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Registries");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Registries");

            migrationBuilder.DropColumn(
                name: "TransactionImages",
                table: "Registries");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 823951L, new DateTime(2024, 12, 18, 20, 1, 25, 667, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 12, 18, 20, 1, 25, 667, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2077), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2831), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9195), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9512), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7462), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7732), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7736), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7744), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7745), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(969), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8813), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4276), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 670, DateTimeKind.Local).AddTicks(8641), "bbfb42da18564c08aaf956a3eaf37d6c", "568739", new DateTime(2024, 12, 18, 20, 1, 25, 670, DateTimeKind.Local).AddTicks(8651) });
        }
    }
}
