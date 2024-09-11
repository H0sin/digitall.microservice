using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TelegramTopicId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpireDetailInbound",
                table: "MarzbanVpns");

            migrationBuilder.AddColumn<string>(
                name: "IconCustomEmojiId",
                table: "TelegramTopics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AddedHolderInbound",
                table: "MarzbanUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HolderInbound",
                table: "MarzbanServers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeHolderInbound",
                table: "MarzbanServers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

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
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IconCustomEmojiId", "Name", "TelegramTopicCategory" },
                values: new object[] { "🔧", "استارت ربات 🔧", "Start" });

            migrationBuilder.InsertData(
                table: "TelegramTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IconCustomEmojiId", "IsDelete", "ModifiedDate", "ModifyBy", "Name", "TelegramTopicCategory" },
                values: new object[,]
                {
                    { 2L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "💰", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات مالی 💰", "FinancialReports" },
                    { 3L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "🐞", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات باگ 🐞", "BogsReports" },
                    { 4L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "🛒", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات خرید 🛒", "BuyReports" },
                    { 5L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "🔄", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات تمدید 🔄", "RenewReports" },
                    { 6L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "💳", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات پرداخت 💳", "PaymentReport" }
                });

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

            migrationBuilder.InsertData(
                table: "TelegramGroupTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "TelegramGroupId", "TelegramTopicId" },
                values: new object[,]
                {
                    { 2L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 2L },
                    { 3L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 3L },
                    { 4L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 4L },
                    { 5L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 5L },
                    { 6L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 6L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DropColumn(
                name: "IconCustomEmojiId",
                table: "TelegramTopics");

            migrationBuilder.DropColumn(
                name: "AddedHolderInbound",
                table: "MarzbanUsers");

            migrationBuilder.DropColumn(
                name: "HolderInbound",
                table: "MarzbanServers");

            migrationBuilder.DropColumn(
                name: "TypeHolderInbound",
                table: "MarzbanServers");

            migrationBuilder.AddColumn<string>(
                name: "ExpireDetailInbound",
                table: "MarzbanVpns",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 840655L, new DateTime(2024, 9, 9, 17, 6, 8, 346, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 9, 9, 17, 6, 8, 346, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1756), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1758), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8847), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8849), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8857), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8861), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8863), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8865), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(3494), new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5390), new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5425), new DateTime(2024, 9, 9, 17, 6, 8, 353, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(210), new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 9, 9, 17, 6, 8, 356, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Name", "TelegramTopicCategory" },
                values: new object[] { "استارت ربات", "start" });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(7352), new DateTime(2024, 9, 9, 17, 6, 8, 355, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(3774), new DateTime(2024, 9, 9, 17, 6, 8, 354, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 6, 8, 351, DateTimeKind.Local).AddTicks(8736), "e3093ff646704338ad5c6c18d75dbb08", "135014", new DateTime(2024, 9, 9, 17, 6, 8, 351, DateTimeKind.Local).AddTicks(8754) });
        }
    }
}
