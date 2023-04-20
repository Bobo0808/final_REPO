using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class s1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 20, 11, 53, 37, 202, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 4, 20, 11, 53, 37, 202, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 20, 11, 53, 37, 201, DateTimeKind.Local).AddTicks(3609), new DateTime(2023, 4, 20, 12, 53, 37, 201, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 19, 9, 53, 37, 201, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 4, 19, 10, 53, 37, 201, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 18, 8, 53, 37, 201, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 4, 18, 9, 53, 37, 201, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 17, 7, 53, 37, 201, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 4, 17, 8, 53, 37, 201, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 6, 53, 37, 201, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 4, 16, 7, 53, 37, 201, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 5, 53, 37, 201, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 4, 16, 6, 53, 37, 201, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 4, 53, 37, 201, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 4, 16, 5, 53, 37, 201, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 11, 53, 37, 202, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 11, 53, 37, 202, DateTimeKind.Local).AddTicks(3898));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
