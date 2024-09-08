using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class userIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "AgentsIncomesDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 724402L, new DateTime(2024, 8, 20, 13, 47, 21, 436, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 8, 20, 13, 47, 21, 436, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7076), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8454), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6535), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6537), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(3886), new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2397), new DateTime(2024, 8, 20, 13, 47, 21, 448, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(7686), new DateTime(2024, 8, 20, 13, 47, 21, 450, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(331), new DateTime(2024, 8, 20, 13, 47, 21, 449, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 47, 21, 446, DateTimeKind.Local).AddTicks(9950), "09afd13a92a2423c9750c144de6e612f", "520129", new DateTime(2024, 8, 20, 13, 47, 21, 446, DateTimeKind.Local).AddTicks(9983) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AgentsIncomesDetail");

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
        }
    }
}
