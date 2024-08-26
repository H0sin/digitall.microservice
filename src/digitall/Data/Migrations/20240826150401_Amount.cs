using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Amount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumAmount",
                table: "TransactionDetail");

            migrationBuilder.DropColumn(
                name: "MinimalAmount",
                table: "TransactionDetail");

            migrationBuilder.AddColumn<long>(
                name: "MaximumAmountForAgent",
                table: "TransactionDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MaximumAmountForUser",
                table: "TransactionDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MinimalAmountForAgent",
                table: "TransactionDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MinimalAmountForUser",
                table: "TransactionDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 134145L, new DateTime(2024, 8, 26, 18, 34, 0, 196, DateTimeKind.Local).AddTicks(6605), new DateTime(2024, 8, 26, 18, 34, 0, 196, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4566), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5534), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5549), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(2752), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1328), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1329), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1336), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1339), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1341), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1343), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1345), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(252), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CardNumber", "CreateDate", "MaximumAmountForAgent", "MaximumAmountForUser", "MinimalAmountForAgent", "MinimalAmountForUser", "ModifiedDate" },
                values: new object[] { "6037691610791079", new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(8294), 2000000L, 2000000L, 100000L, 10000L, new DateTime(2024, 8, 26, 18, 34, 0, 202, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 8, 26, 18, 34, 0, 201, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 18, 34, 0, 199, DateTimeKind.Local).AddTicks(9785), "a5378cd0baca415da37944398b1b414e", "891425", new DateTime(2024, 8, 26, 18, 34, 0, 199, DateTimeKind.Local).AddTicks(9793) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumAmountForAgent",
                table: "TransactionDetail");

            migrationBuilder.DropColumn(
                name: "MaximumAmountForUser",
                table: "TransactionDetail");

            migrationBuilder.DropColumn(
                name: "MinimalAmountForAgent",
                table: "TransactionDetail");

            migrationBuilder.DropColumn(
                name: "MinimalAmountForUser",
                table: "TransactionDetail");

            migrationBuilder.AddColumn<int>(
                name: "MaximumAmount",
                table: "TransactionDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimalAmount",
                table: "TransactionDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 515884L, new DateTime(2024, 8, 26, 15, 0, 28, 161, DateTimeKind.Local).AddTicks(1546), new DateTime(2024, 8, 26, 15, 0, 28, 161, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(7474), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8711), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4431), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4481), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4483), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4484), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(3455), new DateTime(2024, 8, 26, 15, 0, 28, 165, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CardNumber", "CreateDate", "MaximumAmount", "MinimalAmount", "ModifiedDate" },
                values: new object[] { "6037-6916-1079-1079", new DateTime(2024, 8, 26, 15, 0, 28, 167, DateTimeKind.Local).AddTicks(128), 2000000, 200000, new DateTime(2024, 8, 26, 15, 0, 28, 167, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 8, 26, 15, 0, 28, 166, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 164, DateTimeKind.Local).AddTicks(2924), "7b0e35ad1d314aa98f358a16c7d12d99", "826511", new DateTime(2024, 8, 26, 15, 0, 28, 164, DateTimeKind.Local).AddTicks(2936) });
        }
    }
}
