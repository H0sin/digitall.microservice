using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class transaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TransactionCode",
                table: "Transactions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 421678L, new DateTime(2024, 8, 23, 19, 25, 40, 915, DateTimeKind.Local).AddTicks(608), new DateTime(2024, 8, 23, 19, 25, 40, 915, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3349), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3366), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(8916), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9219), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9223), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9225), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9232), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9234), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9238), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7936), new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7951), new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7953), new DateTime(2024, 8, 23, 19, 25, 40, 919, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 8, 23, 19, 25, 40, 921, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(5240), new DateTime(2024, 8, 23, 19, 25, 40, 920, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 25, 40, 918, DateTimeKind.Local).AddTicks(6885), "fa0b423df77b4b8ca8d56ba0b810d3b1", "22432", new DateTime(2024, 8, 23, 19, 25, 40, 918, DateTimeKind.Local).AddTicks(6893) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionCode",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 665117L, new DateTime(2024, 8, 22, 20, 32, 27, 151, DateTimeKind.Local).AddTicks(1946), new DateTime(2024, 8, 22, 20, 32, 27, 151, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2567), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2587), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3147), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3151), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3155), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3164), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 8, 22, 20, 32, 27, 160, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3728), new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3756), new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3759), new DateTime(2024, 8, 22, 20, 32, 27, 158, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 161, DateTimeKind.Local).AddTicks(3071), new DateTime(2024, 8, 22, 20, 32, 27, 161, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 8, 22, 20, 32, 27, 159, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 22, 20, 32, 27, 156, DateTimeKind.Local).AddTicks(4112), "5395dcb39e034aa6894bd69ce4b1fe18", "814848", new DateTime(2024, 8, 22, 20, 32, 27, 156, DateTimeKind.Local).AddTicks(4128) });
        }
    }
}
