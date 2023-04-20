using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 20, 10, 15, 30, 222, DateTimeKind.Local).AddTicks(5639), new DateTime(2023, 4, 20, 10, 15, 30, 222, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 20, 10, 15, 30, 221, DateTimeKind.Local).AddTicks(6766), new DateTime(2023, 4, 20, 11, 15, 30, 221, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 19, 8, 15, 30, 221, DateTimeKind.Local).AddTicks(6784), new DateTime(2023, 4, 19, 9, 15, 30, 221, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 18, 7, 15, 30, 221, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 4, 18, 8, 15, 30, 221, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 17, 6, 15, 30, 221, DateTimeKind.Local).AddTicks(6788), new DateTime(2023, 4, 17, 7, 15, 30, 221, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 5, 15, 30, 221, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 4, 16, 6, 15, 30, 221, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 4, 15, 30, 221, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 4, 16, 5, 15, 30, 221, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 3, 15, 30, 221, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 4, 16, 4, 15, 30, 221, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 10, 15, 30, 222, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 10, 15, 30, 222, DateTimeKind.Local).AddTicks(5622));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 20, 3, 40, 12, 24, DateTimeKind.Local).AddTicks(4755), new DateTime(2023, 4, 20, 3, 40, 12, 24, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 20, 3, 40, 12, 23, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 4, 20, 4, 40, 12, 23, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 19, 1, 40, 12, 23, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 4, 19, 2, 40, 12, 23, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 40, 12, 23, DateTimeKind.Local).AddTicks(7370), new DateTime(2023, 4, 18, 1, 40, 12, 23, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 23, 40, 12, 23, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 4, 17, 0, 40, 12, 23, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 22, 40, 12, 23, DateTimeKind.Local).AddTicks(7372), new DateTime(2023, 4, 15, 23, 40, 12, 23, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 21, 40, 12, 23, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 4, 15, 22, 40, 12, 23, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 20, 40, 12, 23, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 4, 15, 21, 40, 12, 23, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 3, 40, 12, 24, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 3, 40, 12, 24, DateTimeKind.Local).AddTicks(4733));
        }
    }
}
