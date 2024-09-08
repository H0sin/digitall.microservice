using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAgent",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "MarzbanServers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TelegramGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TelegramBotId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramGroups_TelegramBots_TelegramBotId",
                        column: x => x.TelegramBotId,
                        principalTable: "TelegramBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelegramTopics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelegramTopicCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TelegramGroupTopics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelegramGroupId = table.Column<long>(type: "bigint", nullable: true),
                    TelegramTopicId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramGroupTopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramGroupTopics_TelegramGroups_TelegramGroupId",
                        column: x => x.TelegramGroupId,
                        principalTable: "TelegramGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TelegramGroupTopics_TelegramTopics_TelegramTopicId",
                        column: x => x.TelegramTopicId,
                        principalTable: "TelegramTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 909338L, new DateTime(2024, 9, 8, 20, 16, 43, 139, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 9, 8, 20, 16, 43, 139, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8866), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(3342), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(352), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1003), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1009), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1022), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 9, 8, 20, 16, 43, 153, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1358), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 9, 8, 20, 16, 43, 151, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "HostAddress", "ModifiedDate", "Route", "Token" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(7404), "https://364c-80-240-30-200.ngrok-free.app", new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(9484), "/7332050396:AAHvkWaF4MhUb3U8yfvSlD1y81i_jF2tCN0", "7332050396:AAHvkWaF4MhUb3U8yfvSlD1y81i_jF2tCN0" });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 155, DateTimeKind.Local).AddTicks(2323), new DateTime(2024, 9, 8, 20, 16, 43, 155, DateTimeKind.Local).AddTicks(2999) });

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
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 9, 8, 20, 16, 43, 154, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 9, 8, 20, 16, 43, 152, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "IsAgent", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 16, 43, 149, DateTimeKind.Local).AddTicks(1458), "90fed7aac211490ca118ada20da7386c", false, "321230", new DateTime(2024, 9, 8, 20, 16, 43, 149, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.InsertData(
                table: "TelegramGroupTopics",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "TelegramGroupId", "TelegramTopicId" },
                values: new object[] { 1L, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_TelegramGroups_TelegramBotId",
                table: "TelegramGroups",
                column: "TelegramBotId",
                unique: true,
                filter: "[TelegramBotId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TelegramGroupTopics_TelegramGroupId",
                table: "TelegramGroupTopics",
                column: "TelegramGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TelegramGroupTopics_TelegramTopicId",
                table: "TelegramGroupTopics",
                column: "TelegramTopicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TelegramGroupTopics");

            migrationBuilder.DropTable(
                name: "TelegramGroups");

            migrationBuilder.DropTable(
                name: "TelegramTopics");

            migrationBuilder.DropColumn(
                name: "IsAgent",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "MarzbanServers");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 877989L, new DateTime(2024, 9, 4, 14, 42, 34, 549, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 9, 4, 14, 42, 34, 549, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1601), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1603), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1606), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1617), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(8933), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7412), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7424), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7425), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6363), new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6386), new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6388), new DateTime(2024, 9, 4, 14, 42, 34, 554, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "HostAddress", "ModifiedDate", "Route", "Token" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(6860), "https://test.samanii.com", new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(7920), "/7419690675:AAGpFGOAt_Nei0qQoppFct1V9NdY4MfzinE", "7419690675:AAGpFGOAt_Nei0qQoppFct1V9NdY4MfzinE" });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 9, 4, 14, 42, 34, 556, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 9, 4, 14, 42, 34, 555, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 42, 34, 553, DateTimeKind.Local).AddTicks(2423), "e88e378e19034e198b0aba213ec859a7", "605918", new DateTime(2024, 9, 4, 14, 42, 34, 553, DateTimeKind.Local).AddTicks(2430) });
        }
    }
}
