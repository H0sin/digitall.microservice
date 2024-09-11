using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class asdss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 138080L, new DateTime(2024, 9, 11, 21, 56, 41, 468, DateTimeKind.Local).AddTicks(34), new DateTime(2024, 9, 11, 21, 56, 41, 468, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1239), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1241), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 9, 11, 21, 56, 41, 472, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(8875), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 475, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 9, 11, 21, 56, 41, 475, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TelegramTopicCategory",
                value: "StartReports");

            migrationBuilder.UpdateData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TelegramTopicCategory",
                value: "PaymentReports");

            migrationBuilder.InsertData(
                table: "TelegramTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IconCustomEmojiId", "IsDelete", "ModifiedDate", "ModifyBy", "Name", "TelegramTopicCategory" },
                values: new object[] { 7L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "❌", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "گزارشات حذفی ها ❌", "DeletedReports" });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 9, 11, 21, 56, 41, 474, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(3408), new DateTime(2024, 9, 11, 21, 56, 41, 473, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 56, 41, 471, DateTimeKind.Local).AddTicks(3354), "6772c2bc47ae4c8297aa83e2177f44d7", "49888", new DateTime(2024, 9, 11, 21, 56, 41, 471, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.InsertData(
                table: "TelegramGroupTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Created", "IsDelete", "MessageThreadId", "ModifiedDate", "ModifyBy", "TelegramGroupId", "TelegramTopicId" },
                values: new object[] { 7L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 7L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 7L);

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
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TelegramTopicCategory",
                value: "Start");

            migrationBuilder.UpdateData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TelegramTopicCategory",
                value: "PaymentReport");

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
    }
}
