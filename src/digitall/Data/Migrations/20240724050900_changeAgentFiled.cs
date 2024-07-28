using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class changeAgentFiled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardHolderName",
                table: "Agent",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaximumAmount",
                table: "Agent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimalAmount",
                table: "Agent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "AgentRequestStatus", "CardHolderName", "CreateDate", "MaximumAmount", "MinimalAmount", "ModifiedDate" },
                values: new object[] { 778011L, "wating", null, new DateTime(2024, 7, 24, 8, 38, 57, 688, DateTimeKind.Local).AddTicks(6359), 2000000, 1000000, new DateTime(2024, 7, 24, 8, 38, 57, 688, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(8506), new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(788), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(832), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(8689), new DateTime(2024, 7, 24, 8, 38, 57, 710, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(1318), new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 7, 24, 8, 38, 57, 708, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 7, 24, 8, 38, 57, 709, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 24, 8, 38, 57, 706, DateTimeKind.Local).AddTicks(3633), "2372bd5e4d74400cac1f1d8b8a12b45c", "263964", new DateTime(2024, 7, 24, 8, 38, 57, 706, DateTimeKind.Local).AddTicks(3651) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardHolderName",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "MaximumAmount",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "MinimalAmount",
                table: "Agent");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "AgentRequestStatus", "CreateDate", "ModifiedDate" },
                values: new object[] { 692437L, "Wating", new DateTime(2024, 7, 23, 11, 13, 35, 495, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 7, 23, 11, 13, 35, 495, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(3196), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(4485), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8433), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 7, 23, 11, 13, 35, 504, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 507, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 7, 23, 11, 13, 35, 507, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(7778), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 7, 23, 11, 13, 35, 506, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 508, DateTimeKind.Local).AddTicks(2469), new DateTime(2024, 7, 23, 11, 13, 35, 508, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1134), new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 7, 23, 11, 13, 35, 503, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 505, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 7, 23, 11, 13, 35, 505, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 13, 35, 500, DateTimeKind.Local).AddTicks(3344), "ad39bf8bd22c46b6904af6d639b7f4e8", "484566", new DateTime(2024, 7, 23, 11, 13, 35, 500, DateTimeKind.Local).AddTicks(3357) });
        }
    }
}
