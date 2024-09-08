using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class IsSupperAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSupperAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 263202L, new DateTime(2024, 9, 3, 19, 48, 28, 603, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 9, 3, 19, 48, 28, 603, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2229), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2551), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3383), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3385), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3387), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9223), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9225), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(3513), new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 9, 3, 19, 48, 28, 612, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 615, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 9, 3, 19, 48, 28, 615, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(7878), new DateTime(2024, 9, 3, 19, 48, 28, 614, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 9, 3, 19, 48, 28, 613, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "IsSupperAdmin", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 48, 28, 611, DateTimeKind.Local).AddTicks(5906), "7fdc066dae964e208faca53a2bdc953f", false, "982199", new DateTime(2024, 9, 3, 19, 48, 28, 611, DateTimeKind.Local).AddTicks(5920) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSupperAdmin",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 860084L, new DateTime(2024, 9, 3, 17, 11, 58, 438, DateTimeKind.Local).AddTicks(2139), new DateTime(2024, 9, 3, 17, 11, 58, 438, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(9751), new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(117), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(870), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7000), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7001), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7003), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7010), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7013), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 446, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 9, 3, 17, 11, 58, 446, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(5621), new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(5641), new DateTime(2024, 9, 3, 17, 11, 58, 444, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 446, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 9, 3, 17, 11, 58, 446, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 446, DateTimeKind.Local).AddTicks(5084), new DateTime(2024, 9, 3, 17, 11, 58, 446, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(2865), new DateTime(2024, 9, 3, 17, 11, 58, 445, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 11, 58, 443, DateTimeKind.Local).AddTicks(3108), "61bb9fe394484799bc54cb1c588645d0", "890814", new DateTime(2024, 9, 3, 17, 11, 58, 443, DateTimeKind.Local).AddTicks(3122) });
        }
    }
}
