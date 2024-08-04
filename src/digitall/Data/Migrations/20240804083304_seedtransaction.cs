using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seedtransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 557008L, new DateTime(2024, 8, 4, 12, 3, 1, 301, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 8, 4, 12, 3, 1, 302, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(7348), new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(234), new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(9574), new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(335), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 8, 4, 12, 3, 1, 311, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(950), new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(953), new DateTime(2024, 8, 4, 12, 3, 1, 309, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.InsertData(
                table: "TransactionDetail",
                columns: new[] { "Id", "AgentId", "CardHolderName", "CardNumber", "CreateBy", "CreateDate", "Description", "IsDelete", "MaximumAmount", "MinimalAmount", "ModifiedDate", "ModifyBy" },
                values: new object[] { 1L, 100001L, "حسین فرجی", "6037-6916-1079-1079", 1L, new DateTime(2024, 8, 4, 12, 3, 1, 312, DateTimeKind.Local).AddTicks(1155), "توضیحات", false, 2000000, 200000, new DateTime(2024, 8, 4, 12, 3, 1, 312, DateTimeKind.Local).AddTicks(1160), 1L });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 8, 4, 12, 3, 1, 310, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 307, DateTimeKind.Local).AddTicks(1706), "2e71456a82d94e02ad5e69bf5cec29b4", "879462", new DateTime(2024, 8, 4, 12, 3, 1, 307, DateTimeKind.Local).AddTicks(1713) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L);

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
    }
}
