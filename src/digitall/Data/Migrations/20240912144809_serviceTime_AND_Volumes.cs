using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class serviceTime_AND_Volumes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "MarzbanUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<int>(
                name: "ServiceTime",
                table: "MarzbanUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Volume",
                table: "MarzbanUsers",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceTime",
                table: "MarzbanUsers");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "MarzbanUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "MarzbanUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 313581L, new DateTime(2024, 9, 11, 23, 40, 4, 485, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 9, 11, 23, 40, 4, 485, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8888), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4566), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4599), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4602), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3621), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 9, 11, 23, 40, 4, 506, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "TelegramButtons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(6625), new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(1672), new DateTime(2024, 9, 11, 23, 40, 4, 508, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 9, 11, 23, 40, 4, 507, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 40, 4, 505, DateTimeKind.Local).AddTicks(1102), "24abba3e260f4f35ad0e875841caaca1", "628325", new DateTime(2024, 9, 11, 23, 40, 4, 505, DateTimeKind.Local).AddTicks(1118) });
        }
    }
}
