using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class percent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "AgentsIncomesDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percent",
                table: "AgentsIncomesDetail");

            migrationBuilder.UpdateData(
                table: "Agent",
                keyColumn: "Id",
                keyValue: 100001L,
                columns: new[] { "AgentCode", "CreateDate", "ModifiedDate" },
                values: new object[] { 584678L, new DateTime(2024, 9, 2, 17, 3, 36, 274, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 9, 2, 17, 3, 36, 274, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3057), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3424), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4389), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4395), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4410), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(2407), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(795), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(803), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(7981), new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8005), new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 9, 2, 17, 3, 36, 279, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "TelegramBots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 282, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 9, 2, 17, 3, 36, 282, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "TransactionDetail",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 9, 2, 17, 3, 36, 281, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(6318), new DateTime(2024, 9, 2, 17, 3, 36, 280, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "EmailActiveCode", "MobileActiveCode", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 3, 36, 278, DateTimeKind.Local).AddTicks(5694), "b37d0523275e4fa3b34bcb8a5bb58e3e", "994101", new DateTime(2024, 9, 2, 17, 3, 36, 278, DateTimeKind.Local).AddTicks(5708) });
        }
    }
}
