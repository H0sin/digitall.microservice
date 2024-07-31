using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ByteTransactionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "TransactionStatus",
                table: "Transactions",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 455887L, new DateTime(2024, 7, 31, 12, 22, 7, 939, DateTimeKind.Local).AddTicks(1854), new DateTime(2024, 7, 31, 12, 22, 7, 939, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(9845), new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3244), new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3247), new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3275), new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(6974), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4361), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4367), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4370), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4379), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4385), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4388), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4390), new DateTime(2024, 7, 31, 12, 22, 7, 950, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 951, DateTimeKind.Local).AddTicks(1262), new DateTime(2024, 7, 31, 12, 22, 7, 951, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(2253), new DateTime(2024, 7, 31, 12, 22, 7, 948, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 7, 31, 12, 22, 7, 949, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 22, 7, 945, DateTimeKind.Local).AddTicks(7393), "5379112651f040379a26bf76d8a2601a", "347302", new DateTime(2024, 7, 31, 12, 22, 7, 945, DateTimeKind.Local).AddTicks(7408) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TransactionStatus",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 737566L, new DateTime(2024, 7, 30, 13, 56, 48, 675, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 7, 30, 13, 56, 48, 675, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(856), new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(2022), new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5645), new DateTime(2024, 7, 30, 13, 56, 48, 687, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 690, DateTimeKind.Local).AddTicks(177), new DateTime(2024, 7, 30, 13, 56, 48, 690, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4579), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4608), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4616), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4620), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 7, 30, 13, 56, 48, 689, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 690, DateTimeKind.Local).AddTicks(7716), new DateTime(2024, 7, 30, 13, 56, 48, 690, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 685, DateTimeKind.Local).AddTicks(8760), new DateTime(2024, 7, 30, 13, 56, 48, 685, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 685, DateTimeKind.Local).AddTicks(8823), new DateTime(2024, 7, 30, 13, 56, 48, 685, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 685, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 7, 30, 13, 56, 48, 685, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 688, DateTimeKind.Local).AddTicks(1356), new DateTime(2024, 7, 30, 13, 56, 48, 688, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 30, 13, 56, 48, 682, DateTimeKind.Local).AddTicks(9360), "2fb0cc7cbef04a41b7a44377b9e723fa", "202223", new DateTime(2024, 7, 30, 13, 56, 48, 682, DateTimeKind.Local).AddTicks(9380) });
        }
    }
}
