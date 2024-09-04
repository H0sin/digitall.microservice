using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class asdasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TelegramButtons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CallBackQuery = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp2 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp3 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AdditionalProp4 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    TelegramBotId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramButtons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramButtons_TelegramBots_TelegramBotId",
                        column: x => x.TelegramBotId,
                        principalTable: "TelegramBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 269304L, new DateTime(2024, 9, 4, 14, 40, 56, 98, DateTimeKind.Local).AddTicks(5843), new DateTime(2024, 9, 4, 14, 40, 56, 98, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1154), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1156), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1159), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(6876), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7205), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 9, 4, 14, 40, 56, 103, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate", "Route" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(8038), "/7419690675:AAGpFGOAt_Nei0qQoppFct1V9NdY4MfzinE" });

            migrationBuilder.InsertData(
                table: "TelegramButtons",
                columns: new[] { "Id", "AdditionalProp1", "AdditionalProp2", "AdditionalProp3", "AdditionalProp4", "CallBackQuery", "CreateBy", "CreateDate", "IsDelete", "IsLike", "Link", "ModifiedDate", "ModifyBy", "Name", "TelegramBotId", "Title" },
                values: new object[] { 1L, null, null, null, null, null, 1L, new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(9625), false, true, "https://t.me/master_digitall_vpn_bot", new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(9934), 1L, "master_digitall_vpn_bot", null, "شروع ربات" });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 9, 4, 14, 40, 56, 105, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 9, 4, 14, 40, 56, 104, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 40, 56, 102, DateTimeKind.Local).AddTicks(2917), "659332a6feba41c4b533668feb930018", "959976", new DateTime(2024, 9, 4, 14, 40, 56, 102, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.CreateIndex(
                name: "IX_TelegramButtons_TelegramBotId",
                table: "TelegramButtons",
                column: "TelegramBotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TelegramButtons");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 101525L, new DateTime(2024, 9, 3, 20, 46, 6, 73, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 9, 3, 20, 46, 6, 73, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9426), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(216), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(218), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(7873), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6068), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6083), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate", "Route" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(7442), "/master_digitall_vpn_bot" });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 78, DateTimeKind.Local).AddTicks(9112), "93558a737ea4467c958aea564ca2875e", "544135", new DateTime(2024, 9, 3, 20, 46, 6, 78, DateTimeKind.Local).AddTicks(9130) });
        }
    }
}
