using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class added_cardnumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Agent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CardNumber", "CreateDate", "ModifiedDate" },
                values: new object[] { 921124L, null, new DateTime(2024, 7, 21, 11, 5, 28, 30, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 7, 21, 11, 5, 28, 32, DateTimeKind.Local).AddTicks(2519) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Agent");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 264184L, new DateTime(2024, 7, 21, 9, 55, 3, 648, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 7, 21, 9, 55, 3, 650, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(7093), new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(7896), new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(286), new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(311), new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 661, DateTimeKind.Local).AddTicks(1648), new DateTime(2024, 7, 21, 9, 55, 3, 661, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(2004), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3619), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3657), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 7, 21, 9, 55, 3, 660, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 661, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 7, 21, 9, 55, 3, 661, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 7, 21, 9, 55, 3, 658, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 7, 21, 9, 55, 3, 659, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 55, 3, 656, DateTimeKind.Local).AddTicks(1743), "61e3ea26ea154bd0bc64047c4534a6b1", "199662", new DateTime(2024, 7, 21, 9, 55, 3, 656, DateTimeKind.Local).AddTicks(1756) });
        }
    }
}
