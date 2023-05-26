using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenLife.Migrations
{
    public partial class d4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "E_Pwd",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "E_Phone",
                table: "Employees",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 2,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 3,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 4,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 5,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 6,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 7,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 8,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 9,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5656), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 10,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5662), new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 1,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 190, 19, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 116, 14, new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 81, 11, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 179, 10, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 5,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 152, 7, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 229, 18, new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 173, 23, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 8,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 114, 14, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 33, 14, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 10,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 41, 14, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 50, 18, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 12,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 96, 19, new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 13,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 148, 14, new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 225, 9, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 15,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 120, 19, new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 16,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 89, 23, new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 194, 17, new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 6 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 18,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 135, 13, new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 19,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 141, 7, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 20,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 94, 12, new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 201, 19, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 126, 7, new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 154, 16, new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 134, 20, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 214, 21, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 33, 21, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 27,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 235, 8, new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 173, 20, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 13 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 149, 19, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 });

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 1,
                column: "CO_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 2,
                column: "CO_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 1,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 2,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 3,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 4,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 2,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "hxzdc601g4@gmail.com", 0, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914372113", "hxzdc601g4", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "g56o0v259ei@gmail.com", 1, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0918121737", "g56o0v259ei" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "rr4dyr33y@gmail.com", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915840420", "rr4dyr33y" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "h0vmrjmcv@gmail.com", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0914252549", "h0vmrjmcv" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8mtxxnvbj@gmail.com", 1, new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0910061960", "8mtxxnvbj", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "pazszq9w@gmail.com", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0919052412", "pazszq9w" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "8cu8g88h@gmail.com", new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914628587", "8cu8g88h", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2oz2syjv@gmail.com", 0, new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918970602", "2oz2syjv" });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 14, 3, 3, 12, 235, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 10, 3, 12, 235, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 26, 4, 32, 32, 232, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 5, 32, 32, 232, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 14, 9, 4, 15, 494, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 15, 4, 15, 494, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 12, 23, 17, 51, 530, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 6, 17, 51, 530, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 1, 19, 25, 34, 501, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 5, 25, 34, 501, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 18, 17, 42, 55, 233, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 1, 42, 55, 233, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 3, 5, 40, 7, 691, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 8, 40, 7, 691, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 2, 22, 38, 55, 864, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 7, 38, 55, 864, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 28, 20, 54, 58, 325, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 23, 54, 58, 325, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 18, 10, 44, 51, 132, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 16, 44, 51, 132, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 24, 21, 8, 26, 313, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 5, 8, 26, 313, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 4, 15, 51, 53, 73, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 21, 51, 53, 73, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 6, 2, 53, 46, 915, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 7, 53, 46, 915, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 14,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 20, 4, 49, 56, 384, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 11, 49, 56, 384, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 22, 10, 31, 39, 213, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 13, 31, 39, 213, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 21, 16, 22, 29, 310, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 0, 22, 29, 310, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 9, 1, 59, 22, 999, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 6, 59, 22, 999, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 25, 3, 15, 34, 260, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 5, 15, 34, 260, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 15, 12, 54, 27, 510, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 17, 54, 27, 510, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 20,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 13, 3, 52, 30, 228, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 52, 30, 228, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 21,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 3, 9, 27, 54, 217, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 17, 27, 54, 217, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 22,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 1, 1, 25, 18, 317, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 11, 25, 18, 317, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 23,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 18, 19, 34, 10, 911, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 2, 34, 10, 911, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 24,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 23, 7, 56, 15, 759, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 9, 56, 15, 759, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 25,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 29, 13, 17, 49, 706, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 22, 17, 49, 706, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 26,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 18, 3, 48, 20, 573, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 5, 48, 20, 573, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 27,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 11, 21, 28, 14, 279, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 22, 28, 14, 279, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 28,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 28, 18, 19, 30, 154, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 20, 19, 30, 154, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 29,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 17, 17, 7, 30, 302, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 23, 7, 30, 302, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 30,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 6, 11, 43, 57, 107, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 15, 43, 57, 107, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 31,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 26, 16, 16, 4, 755, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 2, 16, 4, 755, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 32,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 12, 1, 59, 35, 196, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 4, 59, 35, 196, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 33,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 12, 20, 35, 0, 720, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 0, 35, 0, 720, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 13, 1, 39, 50, 117, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 2, 39, 50, 117, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 35,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 13, 11, 57, 21, 570, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 20, 57, 21, 570, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 36,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 27, 14, 16, 10, 658, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 0, 16, 10, 658, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 37,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 20, 21, 57, 2, 699, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 0, 57, 2, 699, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 38,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 31, 13, 56, 37, 573, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 16, 56, 37, 573, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 39,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 17, 0, 16, 10, 196, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 3, 16, 10, 196, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 40,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 7, 5, 23, 8, 907, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 10, 23, 8, 907, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 41,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 12, 8, 47, 5, 64, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 14, 47, 5, 64, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 42,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 2, 5, 1, 18, 963, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 10, 1, 18, 963, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 43,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 42, 22, 793, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 16, 42, 22, 793, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 44,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 14, 20, 38, 49, 224, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 3, 38, 49, 224, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 45,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 10, 11, 58, 13, 582, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 21, 58, 13, 582, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 46,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 8, 21, 15, 37, 709, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 23, 15, 37, 709, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 47,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 19, 23, 33, 35, 498, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 7, 33, 35, 498, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 30, 4, 0, 51, 669, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 7, 0, 51, 669, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 49,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 31, 10, 51, 19, 385, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 20, 51, 19, 385, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 50,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 2, 19, 8, 4, 670, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 22, 8, 4, 670, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 51,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 30, 16, 0, 59, 498, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 0, 59, 498, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 52,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 8, 9, 13, 8, 379, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 17, 13, 8, 379, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 53,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 4, 6, 36, 59, 685, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 14, 36, 59, 685, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 54,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 25, 21, 32, 30, 646, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 0, 32, 30, 646, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 55,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 27, 23, 56, 25, 886, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 5, 56, 25, 886, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 56,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 30, 21, 27, 34, 340, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 0, 27, 34, 340, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 57,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 7, 23, 1, 50, 208, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 1, 1, 50, 208, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 58,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 14, 18, 44, 35, 851, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 20, 44, 35, 851, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 59,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 10, 16, 23, 15, 432, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 19, 23, 15, 432, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 60,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 27, 5, 32, 2, 290, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 14, 32, 2, 290, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 13, 23, 46, 8, 279, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 2, 46, 8, 279, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 62,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 7, 8, 3, 20, 412, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 12, 3, 20, 412, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 63,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 11, 23, 32, 58, 627, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 0, 32, 58, 627, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 64,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 19, 10, 27, 12, 697, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 19, 27, 12, 697, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 65,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 13, 4, 24, 8, 55, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 6, 24, 8, 55, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 66,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 23, 12, 49, 5, 718, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 13, 49, 5, 718, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 67,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 22, 10, 22, 23, 112, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 19, 22, 23, 112, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 68,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 13, 23, 40, 15, 541, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 5, 40, 15, 541, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 69,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 1, 4, 54, 11, 843, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 14, 54, 11, 843, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 70,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 19, 11, 43, 3, 116, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 18, 43, 3, 116, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 71,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 17, 0, 4, 24, 307, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 8, 4, 24, 307, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 72,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 22, 11, 58, 9, 536, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 19, 58, 9, 536, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 73,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 6, 13, 34, 45, 471, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 16, 34, 45, 471, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 74,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 26, 8, 51, 30, 566, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 12, 51, 30, 566, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 75,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 20, 15, 53, 27, 469, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 21, 53, 27, 469, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 76,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 10, 57, 55, 363, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 19, 57, 55, 363, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 77,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 24, 18, 31, 16, 167, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 22, 31, 16, 167, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 78,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 6, 6, 53, 28, 817, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 15, 53, 28, 817, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 79,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 14, 17, 6, 26, 190, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 3, 6, 26, 190, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 5, 23, 0, 48, 689, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 0, 0, 48, 689, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 81,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 12, 8, 27, 50, 139, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 16, 27, 50, 139, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 82,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 30, 7, 36, 27, 33, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 14, 36, 27, 33, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 83,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 12, 7, 34, 12, 301, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 10, 34, 12, 301, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 84,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 11, 8, 34, 50, 438, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 11, 34, 50, 438, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 30, 14, 34, 26, 651, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 19, 34, 26, 651, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 86,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 6, 16, 57, 43, 197, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 19, 57, 43, 197, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 87,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 22, 4, 3, 44, 610, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 13, 3, 44, 610, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 88,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 9, 2, 53, 23, 244, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 8, 53, 23, 244, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 89,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 7, 22, 38, 46, 766, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 5, 38, 46, 766, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 90,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 27, 14, 9, 16, 572, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 0, 9, 16, 572, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 91,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 21, 5, 58, 36, 595, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 13, 58, 36, 595, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 92,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 7, 19, 26, 25, 157, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 1, 26, 25, 157, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 93,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 21, 22, 24, 46, 112, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 3, 24, 46, 112, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 94,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 28, 0, 32, 7, 458, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 2, 32, 7, 458, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 95,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 26, 14, 19, 27, 18, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 19, 27, 18, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 96,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 2, 10, 27, 36, 767, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 11, 27, 36, 767, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 97,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 28, 21, 7, 23, 133, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 1, 7, 23, 133, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 98,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 11, 2, 21, 42, 228, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 4, 21, 42, 228, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 99,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 14, 4, 54, 46, 386, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 8, 54, 46, 386, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 12, 6, 15, 1, 104, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 8, 15, 1, 104, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 101,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 10, 10, 27, 42, 103, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 16, 27, 42, 103, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 1,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 2,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 3,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 4,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 9, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 8, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 8,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 12,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 8, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 3,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 4,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 5,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 6,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 7,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 8,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 9,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 10,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 11,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 12,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(5713));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "E_Pwd",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "E_Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8426), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 2,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8437), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 3,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8442), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 4,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8446), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 5,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8451), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 6,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8456), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 7,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 8,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8465), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 9,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8491), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 10,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 1,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 178, 7, new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 195, 22, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 155, 21, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 31, 23, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 5,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 59, 9, new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 145, 8, new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 109, 16, new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 8,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 168, 22, new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 186, 24, new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 10,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 234, 11, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 102, 20, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 12,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 85, 17, new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 13,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 108, 15, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 166, 16, new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 15,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 178, 18, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 13 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 16,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 103, 15, new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 184, 20, new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 18,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 42, 15, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 19,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 42, 13, new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 20,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 40, 7, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 134, 23, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 110, 21, new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 31, 14, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 118, 9, new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 235, 22, new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 75, 23, new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 27,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 102, 16, new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 164, 16, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 178, 16, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20 });

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 1,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 2,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 1,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 2,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 3,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 4,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 2,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "hy75qbn9t@gmail.com", 1, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913537647", "hy75qbn9t", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jai674yq7ox@gmail.com", 0, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0911993377", "jai674yq7ox" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "jg0lzmt@gmail.com", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914689866", "jg0lzmt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tmmuan@gmail.com", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0916485664", "tmmuan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "bubm3y8x@gmail.com", 0, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915626796", "bubm3y8x", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "s0vykwph2@gmail.com", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0915308326", "s0vykwph2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "24wjmzpa0h@gmail.com", new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915295782", "24wjmzpa0h", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "xck9gi@gmail.com", 1, new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914948689", "xck9gi" });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 12, 7, 59, 8, 179, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 13, 59, 8, 179, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 3, 16, 18, 23, 322, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 1, 18, 23, 322, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 16, 10, 21, 52, 611, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 20, 21, 52, 611, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 16, 1, 17, 58, 341, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 3, 17, 58, 341, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 28, 13, 39, 4, 723, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 14, 39, 4, 723, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 3, 3, 43, 53, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 10, 43, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 9, 12, 43, 47, 207, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 22, 43, 47, 207, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 10, 2, 19, 1, 202, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 12, 19, 1, 202, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 26, 10, 43, 19, 793, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 12, 43, 19, 793, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 16, 15, 3, 10, 280, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 19, 3, 10, 280, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 12, 4, 22, 18, 174, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 11, 22, 18, 174, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 21, 2, 56, 18, 909, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 4, 56, 18, 909, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 6, 22, 43, 58, 635, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 5, 43, 58, 635, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 14,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 10, 2, 49, 54, 628, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 3, 49, 54, 628, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 18, 12, 14, 1, 669, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 22, 14, 1, 669, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 24, 5, 44, 53, 5, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 15, 44, 53, 5, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 21, 9, 32, 0, 656, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 13, 32, 0, 656, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 28, 18, 27, 38, 267, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 23, 27, 38, 267, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 8, 3, 17, 43, 970, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 10, 17, 43, 970, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 20,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 18, 10, 6, 25, 984, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 14, 6, 25, 984, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 21,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 4, 13, 50, 26, 703, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 17, 50, 26, 703, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 22,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 9, 2, 57, 27, 396, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 3, 57, 27, 396, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 23,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 19, 22, 25, 22, 384, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 5, 25, 22, 384, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 24,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 18, 11, 48, 2, 281, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 12, 48, 2, 281, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 25,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 15, 19, 26, 57, 380, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 0, 26, 57, 380, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 26,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 7, 4, 1, 42, 407, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 8, 1, 42, 407, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 27,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 25, 18, 11, 5, 804, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 23, 11, 5, 804, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 28,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 27, 6, 49, 4, 389, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 10, 49, 4, 389, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 29,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 20, 16, 33, 32, 888, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 2, 33, 32, 888, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 30,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 27, 20, 4, 29, 697, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 1, 4, 29, 697, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 31,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 26, 10, 0, 26, 554, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 13, 0, 26, 554, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 32,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 28, 3, 47, 0, 336, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 8, 47, 0, 336, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 33,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 29, 6, 51, 7, 148, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 11, 51, 7, 148, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 16, 9, 33, 14, 643, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 14, 33, 14, 643, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 35,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 24, 4, 8, 56, 242, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 14, 8, 56, 242, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 36,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 23, 21, 31, 9, 24, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 3, 31, 9, 24, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 37,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 22, 17, 16, 38, 950, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 0, 16, 38, 950, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 38,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 15, 17, 29, 39, 592, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 2, 29, 39, 592, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 39,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 26, 23, 1, 35, 130, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 0, 1, 35, 130, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 40,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 12, 8, 21, 34, 654, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 10, 21, 34, 654, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 41,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 5, 14, 6, 249, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 6, 14, 6, 249, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 42,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 24, 1, 18, 42, 316, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 6, 18, 42, 316, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 43,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 30, 3, 35, 6, 588, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 8, 35, 6, 588, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 44,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 27, 22, 4, 22, 545, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 23, 4, 22, 545, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 45,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 9, 17, 42, 33, 518, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 3, 42, 33, 518, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 46,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 10, 16, 1, 57, 113, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 22, 1, 57, 113, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 47,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 7, 16, 37, 2, 668, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 17, 37, 2, 668, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 6, 11, 31, 22, 681, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 12, 31, 22, 681, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 49,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 27, 10, 38, 56, 183, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 38, 56, 183, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 50,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 12, 21, 49, 9, 811, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 2, 49, 9, 811, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 51,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 25, 5, 4, 46, 518, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 7, 4, 46, 518, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 52,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 5, 22, 59, 47, 935, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 8, 59, 47, 935, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 53,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 26, 6, 29, 15, 520, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 10, 29, 15, 520, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 54,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 22, 0, 38, 6, 925, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 9, 38, 6, 925, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 55,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 29, 2, 54, 20, 826, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 8, 54, 20, 826, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 56,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 18, 14, 57, 53, 233, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 22, 57, 53, 233, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 57,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 42, 32, 459, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 22, 42, 32, 459, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 58,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 4, 0, 0, 8, 931, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 10, 0, 8, 931, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 59,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 24, 11, 25, 3, 668, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 15, 25, 3, 668, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 60,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 10, 19, 46, 32, 389, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 22, 46, 32, 389, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 8, 9, 37, 2, 358, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 16, 37, 2, 358, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 62,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 6, 11, 40, 16, 920, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 16, 40, 16, 920, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 63,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 5, 20, 50, 33, 172, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 5, 50, 33, 172, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 64,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 30, 14, 39, 41, 876, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 0, 39, 41, 876, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 65,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 30, 17, 8, 0, 389, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 2, 8, 0, 389, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 66,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 10, 2, 53, 33, 46, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 5, 53, 33, 46, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 67,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 25, 16, 12, 50, 184, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 1, 12, 50, 184, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 68,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 22, 11, 36, 41, 304, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 17, 36, 41, 304, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 69,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 27, 3, 27, 38, 744, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 10, 27, 38, 744, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 70,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 22, 10, 32, 12, 459, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 19, 32, 12, 459, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 71,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 13, 3, 33, 24, 183, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 33, 24, 183, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 72,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 18, 15, 46, 42, 977, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 18, 46, 42, 977, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 73,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 20, 5, 56, 13, 239, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 7, 56, 13, 239, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 74,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 11, 11, 1, 50, 803, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 13, 1, 50, 803, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 75,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 20, 13, 58, 45, 340, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 16, 58, 45, 340, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 76,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 24, 23, 26, 59, 954, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 8, 26, 59, 954, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 77,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 4, 5, 54, 52, 229, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 10, 54, 52, 229, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 78,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 21, 17, 50, 33, 578, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 20, 50, 33, 578, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 79,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 30, 21, 53, 19, 958, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 6, 53, 19, 958, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 24, 8, 31, 50, 49, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 12, 31, 50, 49, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 81,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 14, 18, 18, 54, 353, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 4, 18, 54, 353, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 82,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 1, 4, 25, 36, 781, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 9, 25, 36, 781, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 83,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 30, 19, 15, 42, 58, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 5, 15, 42, 58, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 84,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 5, 20, 40, 17, 173, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 5, 40, 17, 173, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 13, 2, 31, 30, 382, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 12, 31, 30, 382, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 86,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 20, 5, 34, 10, 371, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 7, 34, 10, 371, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 87,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 20, 17, 42, 30, 954, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 1, 42, 30, 954, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 88,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 19, 17, 2, 50, 709, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 22, 2, 50, 709, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 89,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 26, 10, 24, 52, 800, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 16, 24, 52, 800, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 90,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 1, 23, 29, 25, 112, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 3, 29, 25, 112, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 91,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 5, 21, 8, 44, 722, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 4, 8, 44, 722, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 92,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 5, 20, 31, 34, 675, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 2, 31, 34, 675, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 93,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 19, 55, 27, 908, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 0, 55, 27, 908, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 94,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 8, 4, 36, 17, 487, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 14, 36, 17, 487, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 95,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 16, 2, 42, 50, 206, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 4, 42, 50, 206, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 96,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 26, 10, 17, 9, 894, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 17, 9, 894, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 97,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 5, 16, 59, 26, 312, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 0, 59, 26, 312, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 98,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 14, 21, 21, 1, 634, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 23, 21, 1, 634, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 99,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 8, 23, 36, 23, 311, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 3, 36, 23, 311, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 18, 1, 18, 49, 552, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 2, 18, 49, 552, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 101,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 5, 3, 47, 45, 102, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 8, 47, 45, 102, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 1,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 2,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 3,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 4,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 8,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 12,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 3,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 4,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 5,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 6,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 7,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 8,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 9,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 10,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 11,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 12,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 4, 3, 4, 209, DateTimeKind.Local).AddTicks(8552));
        }
    }
}
