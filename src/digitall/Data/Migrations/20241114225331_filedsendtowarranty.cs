using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class filedsendtowarranty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SendToWarranty",
                table: "AppleId",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 612554L, new DateTime(2024, 11, 15, 2, 23, 30, 123, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 11, 15, 2, 23, 30, 123, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(7856), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3104), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3116), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3118), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(1950), new DateTime(2024, 11, 15, 2, 23, 30, 130, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 11, 15, 2, 23, 30, 129, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(9768), new DateTime(2024, 11, 15, 2, 23, 30, 128, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 23, 30, 127, DateTimeKind.Local).AddTicks(4518), "986ee3b94ac441bd9913055c392e53fe", "345782", new DateTime(2024, 11, 15, 2, 23, 30, 127, DateTimeKind.Local).AddTicks(4531) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendToWarranty",
                table: "AppleId");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 687209L, new DateTime(2024, 11, 15, 0, 46, 13, 524, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 11, 15, 0, 46, 13, 524, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4551), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9673), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9874), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9887), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(2710), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9363), new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9376), new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 11, 15, 0, 46, 13, 533, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(5276), new DateTime(2024, 11, 15, 0, 46, 13, 535, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 11, 15, 0, 46, 13, 534, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 46, 13, 532, DateTimeKind.Local).AddTicks(9607), "0a450bae3a3345d4a517adeb6467fe9d", "344583", new DateTime(2024, 11, 15, 0, 46, 13, 532, DateTimeKind.Local).AddTicks(9620) });
        }
    }
}
