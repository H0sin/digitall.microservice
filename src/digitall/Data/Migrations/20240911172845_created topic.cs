using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class createdtopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Created",
                table: "TelegramGroupTopics",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MessageThreadId",
                table: "TelegramGroupTopics",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 948877L, new DateTime(2024, 9, 11, 20, 58, 43, 991, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 9, 11, 20, 58, 43, 991, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(8816), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9966), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(7483), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5522), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5972), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5987), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 998, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 9, 11, 20, 58, 43, 998, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(4348), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(4364), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(4366), new DateTime(2024, 9, 11, 20, 58, 43, 996, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 998, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 9, 11, 20, 58, 43, 998, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 998, DateTimeKind.Local).AddTicks(9871), new DateTime(2024, 9, 11, 20, 58, 43, 999, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "MessageThreadId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Created", "MessageThreadId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Created", "MessageThreadId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Created", "MessageThreadId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Created", "MessageThreadId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Created", "MessageThreadId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 998, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 9, 11, 20, 58, 43, 998, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(1596), new DateTime(2024, 9, 11, 20, 58, 43, 997, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 58, 43, 995, DateTimeKind.Local).AddTicks(2723), "b09532c278cb424e9adf2cb1949db29a", "92458", new DateTime(2024, 9, 11, 20, 58, 43, 995, DateTimeKind.Local).AddTicks(2739) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "TelegramGroupTopics");

            migrationBuilder.DropColumn(
                name: "MessageThreadId",
                table: "TelegramGroupTopics");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 383143L, new DateTime(2024, 9, 11, 20, 33, 20, 487, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 9, 11, 20, 33, 20, 487, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(1351), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(1702), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2671), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8513), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8517), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8616), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(2148), new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 492, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 9, 11, 20, 33, 20, 492, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 492, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 9, 11, 20, 33, 20, 492, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 492, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 9, 11, 20, 33, 20, 492, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(8901), new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 495, DateTimeKind.Local).AddTicks(1359), new DateTime(2024, 9, 11, 20, 33, 20, 495, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 9, 11, 20, 33, 20, 494, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(4286), new DateTime(2024, 9, 11, 20, 33, 20, 493, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 33, 20, 491, DateTimeKind.Local).AddTicks(2707), "cddcbd33752648ff94f8571481079c51", "278644", new DateTime(2024, 9, 11, 20, 33, 20, 491, DateTimeKind.Local).AddTicks(2720) });
        }
    }
}
