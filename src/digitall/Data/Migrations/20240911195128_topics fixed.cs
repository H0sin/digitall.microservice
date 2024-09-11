using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class topicsfixed : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Execption",
                table: "Notification",
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
                values: new object[] { 882671L, new DateTime(2024, 9, 11, 23, 21, 27, 874, DateTimeKind.Local).AddTicks(796), new DateTime(2024, 9, 11, 23, 21, 27, 874, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(2670), new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4337), new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4354), new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(4157), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2381), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2689), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2692), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2693), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2695), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2699), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2701), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2702), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2707), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2709), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(6131), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 878, DateTimeKind.Local).AddTicks(5933), new DateTime(2024, 9, 11, 23, 21, 27, 878, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 878, DateTimeKind.Local).AddTicks(5949), new DateTime(2024, 9, 11, 23, 21, 27, 878, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 878, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 9, 11, 23, 21, 27, 878, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 881, DateTimeKind.Local).AddTicks(1748), new DateTime(2024, 9, 11, 23, 21, 27, 881, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 881, DateTimeKind.Local).AddTicks(4235), new DateTime(2024, 9, 11, 23, 21, 27, 881, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Created", "MessageThreadId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "TelegramGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ChatId",
                value: -1002449260173L);

            migrationBuilder.UpdateData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "IconCustomEmojiId", "Name", "TelegramTopicCategory" },
                values: new object[] { "🔧", "استارت ربات 🔧", "StartReports" });

            migrationBuilder.InsertData(
                table: "TelegramTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IconCustomEmojiId", "IsDelete", "ModifiedDate", "ModifyBy", "Name", "TelegramTopicCategory" },
                values: new object[,]
                {
                    { 2L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "💰", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات مالی 💰", "FinancialReports" },
                    { 3L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "🐞", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات باگ 🐞", "BogsReports" },
                    { 4L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "🛒", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات خرید 🛒", "BuyReports" },
                    { 5L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "🔄", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات تمدید 🔄", "RenewReports" },
                    { 6L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "💳", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات پرداخت 💳", "PaymentReports" },
                    { 7L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "❌", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات حذفی ها ❌", "DeletedReports" }
                });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(9262), new DateTime(2024, 9, 11, 23, 21, 27, 880, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 9, 11, 23, 21, 27, 879, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 21, 27, 877, DateTimeKind.Local).AddTicks(3965), "a2117414c8a34384878fc264d96f1bb2", "919829", new DateTime(2024, 9, 11, 23, 21, 27, 877, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.InsertData(
                table: "TelegramGroupTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Created", "IsDelete", "MessageThreadId", "ModifiedDate", "ModifyBy", "TelegramGroupId", "TelegramTopicId" },
                values: new object[,]
                {
                    { 2L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 2L },
                    { 3L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 3L },
                    { 4L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 4L },
                    { 5L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 5L },
                    { 6L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 6L },
                    { 7L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 7L }
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
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 7L);

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

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DropColumn(
                name: "IconCustomEmojiId",
                table: "TelegramTopics");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TelegramGroupTopics");

            migrationBuilder.DropColumn(
                name: "MessageThreadId",
                table: "TelegramGroupTopics");

            migrationBuilder.DropColumn(
                name: "Execption",
                table: "Notification");

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
                values: new object[] { 758097L, new DateTime(2024, 9, 9, 16, 41, 38, 587, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 9, 9, 16, 41, 38, 587, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8615), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9725), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9728), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9730), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9744), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5229), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5533), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5546), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5552), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4542), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4544), new DateTime(2024, 9, 9, 16, 41, 38, 592, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "TelegramGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ChatId",
                value: -4178759105L);

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
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(2206), new DateTime(2024, 9, 9, 16, 41, 38, 594, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 9, 9, 16, 41, 38, 593, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 41, 38, 591, DateTimeKind.Local).AddTicks(1028), "6a6d917b556543209bbab489cc09ceac", "898907", new DateTime(2024, 9, 9, 16, 41, 38, 591, DateTimeKind.Local).AddTicks(1037) });
        }
    }
}
