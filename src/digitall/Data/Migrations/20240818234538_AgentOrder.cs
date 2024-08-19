using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AgentOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentsIncomesDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    Profit = table.Column<long>(type: "bigint", nullable: false),
                    OrderDetailId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentsIncomesDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentsIncomesDetail_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 754943L, new DateTime(2024, 8, 19, 3, 15, 37, 324, DateTimeKind.Local).AddTicks(8027), new DateTime(2024, 8, 19, 3, 15, 37, 324, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(4268), new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5882), new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5885), new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(2913), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3264), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3269), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3271), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3278), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3279), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 329, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 8, 19, 3, 15, 37, 329, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 329, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 8, 19, 3, 15, 37, 329, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 329, DateTimeKind.Local).AddTicks(9710), new DateTime(2024, 8, 19, 3, 15, 37, 329, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(9396), new DateTime(2024, 8, 19, 3, 15, 37, 331, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 8, 19, 3, 15, 37, 330, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 15, 37, 328, DateTimeKind.Local).AddTicks(6820), "de77f116ec67435591a8081ba9d6ff95", "37257", new DateTime(2024, 8, 19, 3, 15, 37, 328, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.CreateIndex(
                name: "IX_AgentsIncomesDetail_AgentId",
                table: "AgentsIncomesDetail",
                column: "AgentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentsIncomesDetail");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 935372L, new DateTime(2024, 8, 17, 16, 37, 46, 493, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 8, 17, 16, 37, 46, 493, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7269), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7271), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(2669), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3005), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3014), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(6622), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2046), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2063), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2065), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 8, 17, 16, 37, 46, 499, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 8, 17, 16, 37, 46, 498, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 37, 46, 497, DateTimeKind.Local).AddTicks(1332), "9ac8655b77554162b1d444382572dd1c", "228956", new DateTime(2024, 8, 17, 16, 37, 46, 497, DateTimeKind.Local).AddTicks(1344) });
        }
    }
}
