using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class bnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 18, 17, 38, 29, 879, DateTimeKind.Local).AddTicks(7125), new DateTime(2023, 4, 18, 17, 38, 29, 879, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 18, 17, 38, 29, 878, DateTimeKind.Local).AddTicks(8238), new DateTime(2023, 4, 18, 18, 38, 29, 878, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 17, 15, 38, 29, 878, DateTimeKind.Local).AddTicks(8251), new DateTime(2023, 4, 17, 16, 38, 29, 878, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 14, 38, 29, 878, DateTimeKind.Local).AddTicks(8252), new DateTime(2023, 4, 16, 15, 38, 29, 878, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 13, 38, 29, 878, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 4, 15, 14, 38, 29, 878, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 14, 12, 38, 29, 878, DateTimeKind.Local).AddTicks(8255), new DateTime(2023, 4, 14, 13, 38, 29, 878, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 14, 11, 38, 29, 878, DateTimeKind.Local).AddTicks(8256), new DateTime(2023, 4, 14, 12, 38, 29, 878, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 14, 10, 38, 29, 878, DateTimeKind.Local).AddTicks(8257), new DateTime(2023, 4, 14, 11, 38, 29, 878, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 4, 18, 17, 38, 29, 879, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 4, 18, 17, 38, 29, 879, DateTimeKind.Local).AddTicks(7110));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 21, 35, 592, DateTimeKind.Local).AddTicks(5001), new DateTime(2023, 4, 18, 16, 21, 35, 592, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 21, 35, 591, DateTimeKind.Local).AddTicks(5958), new DateTime(2023, 4, 18, 17, 21, 35, 591, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 21, 35, 591, DateTimeKind.Local).AddTicks(5969), new DateTime(2023, 4, 17, 15, 21, 35, 591, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 13, 21, 35, 591, DateTimeKind.Local).AddTicks(5970), new DateTime(2023, 4, 16, 14, 21, 35, 591, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 12, 21, 35, 591, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 4, 15, 13, 21, 35, 591, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 14, 11, 21, 35, 591, DateTimeKind.Local).AddTicks(5973), new DateTime(2023, 4, 14, 12, 21, 35, 591, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 14, 10, 21, 35, 591, DateTimeKind.Local).AddTicks(5974), new DateTime(2023, 4, 14, 11, 21, 35, 591, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 14, 9, 21, 35, 591, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 4, 14, 10, 21, 35, 591, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 4, 18, 16, 21, 35, 592, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 4, 18, 16, 21, 35, 592, DateTimeKind.Local).AddTicks(4986));
        }
    }
}
