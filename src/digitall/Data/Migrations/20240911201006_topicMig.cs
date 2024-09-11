using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class topicMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 313581L, new DateTime(2024, 9, 11, 23, 40, 4, 485, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 9, 11, 23, 40, 4, 485, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8888), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4566), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4599), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4602), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3621), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(6625), new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(6940) });

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
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(1672), new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 505, DateTimeKind.Local).AddTicks(1102), "24abba3e260f4f35ad0e875841caaca1", "628325", new DateTime(2024, 9, 11, 23, 40, 4, 505, DateTimeKind.Local).AddTicks(1118) });

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

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 604508L, new DateTime(2024, 9, 10, 14, 48, 13, 443, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 9, 10, 14, 48, 13, 443, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1951), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1966), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9892), new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9912), new DateTime(2024, 9, 10, 14, 48, 13, 447, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(1245), new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 9, 10, 14, 48, 13, 450, DateTimeKind.Local).AddTicks(4222) });

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
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 9, 10, 14, 48, 13, 449, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 9, 10, 14, 48, 13, 448, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 48, 13, 446, DateTimeKind.Local).AddTicks(7998), "f56c593d5018465d928b99309c15b2c4", "450987", new DateTime(2024, 9, 10, 14, 48, 13, 446, DateTimeKind.Local).AddTicks(8011) });
        }
    }
}
