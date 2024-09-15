using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NegativeChargeCeiling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NegativeChargeCeiling",
                table: "Agent",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate", "NegativeChargeCeiling" },
                values: new object[] { 463514L, new DateTime(2024, 9, 15, 13, 48, 37, 796, DateTimeKind.Local).AddTicks(2175), new DateTime(2024, 9, 15, 13, 48, 37, 796, DateTimeKind.Local).AddTicks(2432), 0L });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6441), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6444), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(4348), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2358), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2680), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2682), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2684), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2689), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2691), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2692), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2697), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2699), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(6484), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 9, 15, 13, 48, 37, 803, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 9, 15, 13, 48, 37, 802, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(8268), new DateTime(2024, 9, 15, 13, 48, 37, 801, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 48, 37, 799, DateTimeKind.Local).AddTicks(6396), "7abc4becf28349a3a48518b06dfdcd8e", "85172", new DateTime(2024, 9, 15, 13, 48, 37, 799, DateTimeKind.Local).AddTicks(6406) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NegativeChargeCeiling",
                table: "Agent");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 445024L, new DateTime(2024, 9, 12, 18, 18, 7, 570, DateTimeKind.Local).AddTicks(1472), new DateTime(2024, 9, 12, 18, 18, 7, 570, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(2664), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3776), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3781), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 576, DateTimeKind.Local).AddTicks(1199), new DateTime(2024, 9, 12, 18, 18, 7, 576, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9414), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9419), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9427), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9429), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9430), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9470), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 576, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 9, 12, 18, 18, 7, 576, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 574, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 9, 12, 18, 18, 7, 574, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 574, DateTimeKind.Local).AddTicks(8612), new DateTime(2024, 9, 12, 18, 18, 7, 574, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 574, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 9, 12, 18, 18, 7, 574, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 577, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 9, 12, 18, 18, 7, 577, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 577, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 9, 12, 18, 18, 7, 577, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 576, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 9, 12, 18, 18, 7, 576, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(5465), new DateTime(2024, 9, 12, 18, 18, 7, 575, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 18, 7, 573, DateTimeKind.Local).AddTicks(8012), "5352b4ea831448289512943fc6ee46c9", "366800", new DateTime(2024, 9, 12, 18, 18, 7, 573, DateTimeKind.Local).AddTicks(8022) });
        }
    }
}
