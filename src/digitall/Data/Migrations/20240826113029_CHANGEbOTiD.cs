using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class CHANGEbOTiD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agent_TelegramBots_TelegramBotId",
                table: "Agent");

            migrationBuilder.DropIndex(
                name: "IX_Agent_TelegramBotId",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "TelegramBotId",
                table: "Agent");

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
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 0, 28, 167, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 8, 26, 15, 0, 28, 167, DateTimeKind.Local).AddTicks(131) });

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

            migrationBuilder.CreateIndex(
                name: "IX_TelegramBots_AgentId",
                table: "TelegramBots",
                column: "AgentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TelegramBots_Agent_AgentId",
                table: "TelegramBots",
                column: "AgentId",
                principalTable: "Agent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TelegramBots_Agent_AgentId",
                table: "TelegramBots");

            migrationBuilder.DropIndex(
                name: "IX_TelegramBots_AgentId",
                table: "TelegramBots");

            migrationBuilder.AddColumn<long>(
                name: "TelegramBotId",
                table: "Agent",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate", "TelegramBotId" },
                values: new object[] { 512061L, new DateTime(2024, 8, 24, 15, 8, 7, 78, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 8, 24, 15, 8, 7, 78, DateTimeKind.Local).AddTicks(4261), null });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(1922), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(2374), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3292), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3299), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(424), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(921), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(925), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(932), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(933), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(935), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 8, 24, 15, 8, 7, 85, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(9111), new DateTime(2024, 8, 24, 15, 8, 7, 87, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(5453), new DateTime(2024, 8, 24, 15, 8, 7, 86, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 8, 7, 84, DateTimeKind.Local).AddTicks(1381), "ab0f7fc460d9414abdcd5abf29433552", "40953", new DateTime(2024, 8, 24, 15, 8, 7, 84, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.CreateIndex(
                name: "IX_Agent_TelegramBotId",
                table: "Agent",
                column: "TelegramBotId",
                unique: true,
                filter: "[TelegramBotId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Agent_TelegramBots_TelegramBotId",
                table: "Agent",
                column: "TelegramBotId",
                principalTable: "TelegramBots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
