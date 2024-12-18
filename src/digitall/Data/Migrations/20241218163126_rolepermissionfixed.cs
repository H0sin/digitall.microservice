using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class rolepermissionfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 823951L, new DateTime(2024, 12, 18, 20, 1, 25, 667, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 12, 18, 20, 1, 25, 667, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2077), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2831), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9195), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "ParentId", "SystemName", "Title" },
                values: new object[] { 17L, 1L, new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9512), false, new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(9513), 1L, null, "AllRegistryItem", "همه ریجستری ها" });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7462), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7732), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7736), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7744), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7745), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8813), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 12, 18, 20, 1, 25, 671, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4276), new DateTime(2024, 12, 18, 20, 1, 25, 672, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 20, 1, 25, 670, DateTimeKind.Local).AddTicks(8641), "bbfb42da18564c08aaf956a3eaf37d6c", "568739", new DateTime(2024, 12, 18, 20, 1, 25, 670, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifiedDate", "ModifyBy", "PermissionId", "RoleId" },
                values: new object[] { 17L, 1L, new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(969), false, new DateTime(2024, 12, 18, 20, 1, 25, 673, DateTimeKind.Local).AddTicks(970), 1L, 17L, 1L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 628356L, new DateTime(2024, 12, 18, 19, 3, 6, 167, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 12, 18, 19, 3, 6, 167, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8064), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8066), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8068), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8082), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2623), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2879), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2885), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2890), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2895), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(5972), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3679), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3677), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 12, 18, 19, 3, 6, 184, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(8539), new DateTime(2024, 12, 18, 19, 3, 6, 183, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9650), new DateTime(2024, 12, 18, 19, 3, 6, 182, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 3, 6, 181, DateTimeKind.Local).AddTicks(2608), "b4ec16fb86df48dd874d8be69822a040", "854813", new DateTime(2024, 12, 18, 19, 3, 6, 181, DateTimeKind.Local).AddTicks(2621) });
        }
    }
}
