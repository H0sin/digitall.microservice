using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class appleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppleIdTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppleIdTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppleIdTypes_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppleId",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppleIdTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Question1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    OrderId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppleId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppleId_AppleIdTypes_AppleIdTypeId",
                        column: x => x.AppleIdTypeId,
                        principalTable: "AppleIdTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 829125L, new DateTime(2024, 11, 11, 0, 47, 8, 868, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 11, 11, 0, 47, 8, 868, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1705), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1875), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2328), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(7880), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6749), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6752), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6754), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8557), new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 11, 11, 0, 47, 8, 877, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 11, 11, 0, 47, 8, 879, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 11, 11, 0, 47, 8, 878, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 47, 8, 876, DateTimeKind.Local).AddTicks(8245), "cf48de7b3192418b8e72729584565ab0", "751658", new DateTime(2024, 11, 11, 0, 47, 8, 876, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.CreateIndex(
                name: "IX_AppleId_AppleIdTypeId",
                table: "AppleId",
                column: "AppleIdTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppleIdTypes_ProductId",
                table: "AppleIdTypes",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppleId");

            migrationBuilder.DropTable(
                name: "AppleIdTypes");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 880896L, new DateTime(2024, 11, 3, 21, 19, 53, 256, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 11, 3, 21, 19, 53, 256, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8027), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(5637), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(3731), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4082), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4085), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4101), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(7424), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(943), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(946), new DateTime(2024, 11, 3, 21, 19, 53, 266, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(5007), new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(9274), new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(394), new DateTime(2024, 11, 3, 21, 19, 53, 268, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 11, 3, 21, 19, 53, 267, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 3, 21, 19, 53, 264, DateTimeKind.Local).AddTicks(9389), "7b087e4d9e58484b873cab630d30afc7", "251633", new DateTime(2024, 11, 3, 21, 19, 53, 264, DateTimeKind.Local).AddTicks(9410) });
        }
    }
}
