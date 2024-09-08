using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 857588L, new DateTime(2024, 9, 5, 15, 40, 58, 883, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 9, 5, 15, 40, 58, 883, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1558), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2740), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2743), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2746), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2757), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9006), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9016), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9023), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7286), new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7305), new DateTime(2024, 9, 5, 15, 40, 58, 888, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 9, 5, 15, 40, 58, 891, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 891, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 9, 5, 15, 40, 58, 891, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.InsertData(
                table: "TelegramGroups",
                columns: new[] { "Id", "ChatId", "CreateBy", "CreateDate", "IsDelete", "Link", "ModifiedDate", "ModifyBy", "Name", "TelegramBotId" },
                values: new object[] { 1L, -4178759105L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "مستر گروه", 1L });

            migrationBuilder.InsertData(
                table: "TelegramTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "Name", "TelegramTopicCategory" },
                values: new object[] { 1L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, "استارت ربات", "start" });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(6509), new DateTime(2024, 9, 5, 15, 40, 58, 890, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(4527), new DateTime(2024, 9, 5, 15, 40, 58, 889, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 40, 58, 887, DateTimeKind.Local).AddTicks(4941), "4bc41dceb8db4776b8566e39d3768c5b", "286390", new DateTime(2024, 9, 5, 15, 40, 58, 887, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.InsertData(
                table: "TelegramGroupTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "TelegramGroupId", "TelegramTopicId" },
                values: new object[] { 1L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 1L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TelegramGroupTopics",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TelegramGroups",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TelegramTopics",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 449118L, new DateTime(2024, 9, 5, 15, 29, 39, 58, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 9, 5, 15, 29, 39, 58, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(2157), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3408), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3413), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3424), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 65, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 9, 5, 15, 29, 39, 65, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9086), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9427), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9429), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9431), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9469), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9477), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 65, DateTimeKind.Local).AddTicks(3095), new DateTime(2024, 9, 5, 15, 29, 39, 65, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 63, DateTimeKind.Local).AddTicks(8157), new DateTime(2024, 9, 5, 15, 29, 39, 63, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 63, DateTimeKind.Local).AddTicks(8175), new DateTime(2024, 9, 5, 15, 29, 39, 63, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 63, DateTimeKind.Local).AddTicks(8177), new DateTime(2024, 9, 5, 15, 29, 39, 63, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 65, DateTimeKind.Local).AddTicks(9934), new DateTime(2024, 9, 5, 15, 29, 39, 66, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 66, DateTimeKind.Local).AddTicks(2963), new DateTime(2024, 9, 5, 15, 29, 39, 66, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 65, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 9, 5, 15, 29, 39, 65, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(5066), new DateTime(2024, 9, 5, 15, 29, 39, 64, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 39, 62, DateTimeKind.Local).AddTicks(5451), "2124bdd5a98243b1805edc77d31b29cc", "451293", new DateTime(2024, 9, 5, 15, 29, 39, 62, DateTimeKind.Local).AddTicks(5461) });
        }
    }
}
