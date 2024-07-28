using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Added_notif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationType = table.Column<byte>(type: "tinyint", nullable: false),
                    ForAllMember = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifyBy = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 706616L, new DateTime(2024, 7, 21, 13, 32, 55, 844, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 7, 21, 13, 32, 55, 844, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5031), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5047), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4798), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4801), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 7, 21, 13, 32, 55, 853, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 854, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 7, 21, 13, 32, 55, 854, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5937), new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 7, 21, 13, 32, 55, 851, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(7930), new DateTime(2024, 7, 21, 13, 32, 55, 852, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 13, 32, 55, 849, DateTimeKind.Local).AddTicks(7012), "b45bbb1d465b42de8bcb8a724b2d2618", "462664", new DateTime(2024, 7, 21, 13, 32, 55, 849, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 921124L, new DateTime(2024, 7, 21, 11, 5, 28, 30, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 7, 21, 11, 5, 28, 32, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(4214), new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6554), new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 7, 21, 11, 5, 28, 41, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 43, DateTimeKind.Local).AddTicks(2467), new DateTime(2024, 7, 21, 11, 5, 28, 43, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9295), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9303), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9307), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9319), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9329), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 43, DateTimeKind.Local).AddTicks(7406), new DateTime(2024, 7, 21, 11, 5, 28, 43, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 40, DateTimeKind.Local).AddTicks(3136), new DateTime(2024, 7, 21, 11, 5, 28, 40, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 40, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 7, 21, 11, 5, 28, 40, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 40, DateTimeKind.Local).AddTicks(3178), new DateTime(2024, 7, 21, 11, 5, 28, 40, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 7, 21, 11, 5, 28, 42, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 11, 5, 28, 38, DateTimeKind.Local).AddTicks(1929), "bd98e2b4db6b4fe1b25a865b09d4bc84", "754215", new DateTime(2024, 7, 21, 11, 5, 28, 38, DateTimeKind.Local).AddTicks(1943) });
        }
    }
}
