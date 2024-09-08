using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addedagentrequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentRequestStatus",
                table: "Agent");

            migrationBuilder.CreateTable(
                name: "AgentRequest",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PersianBrandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BrandAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentPercent = table.Column<long>(type: "bigint", nullable: false),
                    UserPercent = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumAmount = table.Column<int>(type: "int", nullable: false),
                    MinimalAmount = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CardHolderName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PaymentDescription = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    AgentRequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentRequest_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 805943L, new DateTime(2024, 8, 5, 13, 5, 14, 65, DateTimeKind.Local).AddTicks(8931), new DateTime(2024, 8, 5, 13, 5, 14, 65, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(6607), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9543), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9546), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9569), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(1806), new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9414), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9416), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9418), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(5840), new DateTime(2024, 8, 5, 13, 5, 14, 75, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(432), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 8, 5, 13, 5, 14, 73, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 76, DateTimeKind.Local).AddTicks(105), new DateTime(2024, 8, 5, 13, 5, 14, 76, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 8, 5, 13, 5, 14, 74, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 5, 14, 71, DateTimeKind.Local).AddTicks(3049), "04e6363d2d4b4d5488e84c0ddd34af91", "589773", new DateTime(2024, 8, 5, 13, 5, 14, 71, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.CreateIndex(
                name: "IX_AgentRequest_UserId",
                table: "AgentRequest",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentRequest");

            migrationBuilder.AddColumn<string>(
                name: "AgentRequestStatus",
                table: "Agent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "AgentRequestStatus", "CreateDate", "ModifiedDate" },
                values: new object[] { 557008L, "wating", new DateTime(2024, 8, 4, 12, 3, 1, 301, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 8, 4, 12, 3, 1, 302, DateTimeKind.Local).AddTicks(407) });

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

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 3, 1, 312, DateTimeKind.Local).AddTicks(1155), new DateTime(2024, 8, 4, 12, 3, 1, 312, DateTimeKind.Local).AddTicks(1160) });

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
    }
}
