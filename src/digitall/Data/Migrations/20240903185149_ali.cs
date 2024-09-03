using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ali : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "On_Hold_Expire_Duration",
                table: "MarzbanUsers",
                newName: "OnHoldExpireDuration");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 900274L, new DateTime(2024, 9, 3, 22, 21, 48, 187, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 9, 3, 22, 21, 48, 187, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(6367), new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8877), new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8880), new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8884), new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8901), new DateTime(2024, 9, 3, 22, 21, 48, 196, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 199, DateTimeKind.Local).AddTicks(3505), new DateTime(2024, 9, 3, 22, 21, 48, 199, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8322), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8325), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8335), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 9, 3, 22, 21, 48, 198, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 199, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 9, 3, 22, 21, 48, 199, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 195, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 9, 3, 22, 21, 48, 195, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 195, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 9, 3, 22, 21, 48, 195, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 195, DateTimeKind.Local).AddTicks(4620), new DateTime(2024, 9, 3, 22, 21, 48, 195, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 201, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 9, 3, 22, 21, 48, 201, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 200, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 9, 3, 22, 21, 48, 200, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 197, DateTimeKind.Local).AddTicks(5496), new DateTime(2024, 9, 3, 22, 21, 48, 197, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 21, 48, 193, DateTimeKind.Local).AddTicks(1056), "29bb70aa822f446eb68067907a61ec7d", "822267", new DateTime(2024, 9, 3, 22, 21, 48, 193, DateTimeKind.Local).AddTicks(1073) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OnHoldExpireDuration",
                table: "MarzbanUsers",
                newName: "On_Hold_Expire_Duration");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 101525L, new DateTime(2024, 9, 3, 20, 46, 6, 73, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 9, 3, 20, 46, 6, 73, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9426), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(216), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(218), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(7873), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6068), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6083), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 9, 3, 20, 46, 6, 80, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 9, 3, 20, 46, 6, 82, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 9, 3, 20, 46, 6, 81, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 46, 6, 78, DateTimeKind.Local).AddTicks(9112), "93558a737ea4467c958aea564ca2875e", "544135", new DateTime(2024, 9, 3, 20, 46, 6, 78, DateTimeKind.Local).AddTicks(9130) });
        }
    }
}
