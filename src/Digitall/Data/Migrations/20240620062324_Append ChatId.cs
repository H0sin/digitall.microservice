using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AppendChatId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ChatId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 425309L, new DateTime(2024, 6, 20, 9, 53, 21, 116, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 6, 20, 9, 53, 21, 117, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(2403), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5440), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5442), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5445), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5460), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5013), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5799), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5805), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5893), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5897), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 6, 20, 9, 53, 21, 125, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 126, DateTimeKind.Local).AddTicks(2815), new DateTime(2024, 6, 20, 9, 53, 21, 126, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5553), new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 6, 20, 9, 53, 21, 123, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 6, 20, 9, 53, 21, 124, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ChatId", "CreateDate", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { null, new DateTime(2024, 6, 20, 9, 53, 21, 122, DateTimeKind.Local).AddTicks(7186), "404867", new DateTime(2024, 6, 20, 9, 53, 21, 122, DateTimeKind.Local).AddTicks(7194) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 358872L, new DateTime(2024, 6, 18, 12, 57, 42, 786, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 6, 18, 12, 57, 42, 788, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(7288), new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(8063), new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(335), new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(4555), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1896), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1909), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1915), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1919), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1925), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 6, 18, 12, 57, 42, 797, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(580), new DateTime(2024, 6, 18, 12, 57, 42, 795, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(3585), new DateTime(2024, 6, 18, 12, 57, 42, 796, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 57, 42, 794, DateTimeKind.Local).AddTicks(4102), "346033", new DateTime(2024, 6, 18, 12, 57, 42, 794, DateTimeKind.Local).AddTicks(4117) });
        }
    }
}
