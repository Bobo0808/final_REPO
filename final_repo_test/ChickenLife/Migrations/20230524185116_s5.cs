using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenLife.Migrations
{
    public partial class s5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2121), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 2,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2135), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 3,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2140), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 4,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 5,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 6,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2182), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 7,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2186), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 8,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 9,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 10,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 1,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 225, 7, new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 89, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 236, 24, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 232, 21, new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 5,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 112, 14, new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 91, 21, new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 169, 20, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 8,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 213, 8, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 96, 20, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 10,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 176, 12, new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 124, 8, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 12,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 64, 17, new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 13,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 58, 11, new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 176, 8, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 15,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 154, 24, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 16,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 173, 18, new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 155, 21, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 18,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 75, 17, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 19,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 68, 22, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 20,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 230, 15, new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 156, 7, new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 224, new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 235, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 180, 21, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 153, 15, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 173, 16, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 27,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 227, 16, new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 110, 9, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 191, 22, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 1,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 2,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 1,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 2,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 3,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 4,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 7,
                column: "D_time",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 9,
                column: "D_time",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 16,
                column: "D_time",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 2, 51, 15, 438, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 2,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ky8wryo@gmail.com", new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0919589910", "ky8wryo" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "e3x9v9t@gmail.com", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0910895970", "e3x9v9t", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "tr7u3c8os1a@gmail.com", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915120185", "tr7u3c8os1a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ywqvpjer5w@gmail.com", new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0910964159", "ywqvpjer5w" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "tt22sstes@gmail.com", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917899887", "tt22sstes" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "9k3gr7@gmail.com", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917217018", "9k3gr7", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "bdjxxkjl02j@gmail.com", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917289548", "bdjxxkjl02j", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "qfcstq@gmail.com", 0, new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0910728111", "qfcstq", 1 });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 3, 11, 46, 41, 217, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 20, 46, 41, 217, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 9, 11, 55, 22, 741, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 16, 55, 22, 741, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 42, 36, 599, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 6, 42, 36, 599, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 23, 21, 53, 37, 758, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 22, 53, 37, 758, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 30, 10, 2, 54, 266, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 13, 2, 54, 266, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 11, 0, 12, 43, 467, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 7, 12, 43, 467, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 15, 11, 51, 30, 153, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 13, 51, 30, 153, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 3, 15, 44, 23, 335, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 19, 44, 23, 335, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 1, 2, 45, 8, 373, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 6, 45, 8, 373, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 17, 0, 25, 9, 993, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 8, 25, 9, 993, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 20, 11, 17, 0, 751, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 17, 17, 0, 751, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 6, 23, 41, 59, 416, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 9, 41, 59, 416, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 1, 7, 6, 3, 155, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 16, 6, 3, 155, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 18, 22, 39, 15, 620, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 0, 39, 15, 620, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 13, 0, 19, 36, 623, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 19, 36, 623, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 13, 13, 35, 26, 178, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 16, 35, 26, 178, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 17,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 27, 15, 18, 19, 129, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 16, 18, 19, 129, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 18,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 15, 22, 20, 55, 850, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 8, 20, 55, 850, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 27, 9, 41, 52, 404, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 17, 41, 52, 404, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 20,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 15, 4, 45, 16, 999, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 10, 45, 16, 999, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 21,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 23, 2, 52, 9, 556, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 3, 52, 9, 556, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 22,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 25, 12, 43, 46, 501, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 20, 43, 46, 501, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 23,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 17, 2, 14, 18, 569, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 4, 14, 18, 569, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 24,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 14, 5, 55, 29, 406, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 14, 55, 29, 406, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 25,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 23, 17, 50, 58, 839, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 1, 50, 58, 839, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 26,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 9, 17, 40, 7, 503, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 22, 40, 7, 503, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 27,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 20, 9, 32, 9, 978, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 19, 32, 9, 978, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 28,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 10, 9, 7, 3, 916, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 11, 7, 3, 916, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 29,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 16, 13, 15, 59, 550, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 22, 15, 59, 550, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 30,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 2, 7, 43, 19, 989, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 13, 43, 19, 989, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 31,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 28, 13, 44, 49, 989, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 17, 44, 49, 989, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 32,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 23, 5, 49, 23, 936, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 15, 49, 23, 936, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 33,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 27, 16, 50, 51, 326, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 19, 50, 51, 326, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 7, 23, 23, 41, 507, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 4, 23, 41, 507, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 35,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 30, 16, 34, 59, 674, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 18, 34, 59, 674, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 36,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 30, 15, 22, 15, 385, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 16, 22, 15, 385, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 37,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 31, 0, 14, 39, 607, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 10, 14, 39, 607, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 38,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 4, 1, 42, 3, 956, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 11, 42, 3, 956, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 39,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 26, 20, 2, 45, 672, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 0, 2, 45, 672, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 40,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 28, 22, 36, 22, 675, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 2, 36, 22, 675, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 41,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 8, 6, 5, 31, 994, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 13, 5, 31, 994, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 42,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 28, 22, 42, 44, 270, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 6, 42, 44, 270, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 43,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 13, 5, 22, 59, 275, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 13, 22, 59, 275, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 44,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 25, 17, 22, 54, 747, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 21, 22, 54, 747, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 45,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 6, 7, 51, 28, 129, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 10, 51, 28, 129, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 46,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 18, 3, 40, 12, 647, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 13, 40, 12, 647, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 47,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 25, 5, 59, 42, 734, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 9, 59, 42, 734, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 21, 1, 10, 12, 350, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 8, 10, 12, 350, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 49,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 31, 22, 5, 46, 789, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 23, 5, 46, 789, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 50,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 16, 15, 4, 53, 955, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 18, 4, 53, 955, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 51,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 22, 11, 34, 59, 104, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 14, 34, 59, 104, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 52,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 4, 8, 47, 9, 545, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 15, 47, 9, 545, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 53,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 5, 2, 26, 7, 637, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 11, 26, 7, 637, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 54,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 8, 18, 7, 19, 953, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 4, 7, 19, 953, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 55,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 9, 0, 49, 43, 543, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 6, 49, 43, 543, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 56,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 7, 8, 6, 58, 289, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 17, 6, 58, 289, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 57,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 3, 14, 50, 3, 96, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 17, 50, 3, 96, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 58,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 6, 19, 24, 56, 173, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 20, 24, 56, 173, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 59,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 5, 10, 33, 12, 567, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 17, 33, 12, 567, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 60,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 1, 7, 28, 7, 438, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 12, 28, 7, 438, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 8, 5, 54, 35, 479, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 10, 54, 35, 479, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 62,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 13, 6, 10, 30, 937, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 10, 30, 937, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 63,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 25, 20, 1, 9, 382, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 4, 1, 9, 382, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 64,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 10, 1, 21, 34, 489, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 4, 21, 34, 489, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 65,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 2, 12, 56, 58, 769, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 18, 56, 58, 769, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 66,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 11, 12, 22, 29, 91, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 14, 22, 29, 91, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 67,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 9, 1, 51, 30, 875, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 11, 51, 30, 875, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 68,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 45, 54, 252, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 6, 45, 54, 252, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 69,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 22, 20, 6, 49, 623, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 6, 6, 49, 623, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 70,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 8, 20, 58, 40, 414, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 23, 58, 40, 414, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 71,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 6, 13, 39, 41, 12, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 22, 39, 41, 12, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 72,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 21, 10, 15, 14, 559, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 15, 15, 14, 559, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 73,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 29, 11, 27, 42, 542, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 17, 27, 42, 542, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 74,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 11, 2, 27, 53, 666, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 7, 27, 53, 666, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 75,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 18, 1, 50, 27, 931, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 9, 50, 27, 931, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 76,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 15, 0, 16, 51, 214, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 2, 16, 51, 214, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 77,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 9, 11, 0, 9, 168, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 15, 0, 9, 168, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 78,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 28, 18, 46, 56, 842, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 1, 46, 56, 842, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 79,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 29, 11, 33, 33, 927, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 17, 33, 33, 927, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 30, 11, 54, 26, 788, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 20, 54, 26, 788, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 81,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 13, 9, 53, 31, 71, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 53, 31, 71, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 82,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 5, 12, 10, 27, 197, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 19, 10, 27, 197, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 83,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 28, 17, 33, 45, 591, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 0, 33, 45, 591, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 84,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 20, 11, 59, 25, 64, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 17, 59, 25, 64, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 14, 9, 24, 11, 271, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 17, 24, 11, 271, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 86,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 16, 13, 16, 36, 759, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 19, 16, 36, 759, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 87,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 22, 16, 48, 47, 900, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 19, 48, 47, 900, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 88,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 17, 17, 27, 27, 868, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 2, 27, 27, 868, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 89,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 14, 16, 27, 30, 15, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 22, 27, 30, 15, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 90,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 2, 42, 23, 901, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 6, 42, 23, 901, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 91,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 22, 15, 28, 42, 907, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 22, 28, 42, 907, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 92,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 3, 1, 40, 18, 798, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 9, 40, 18, 798, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 93,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 30, 4, 39, 37, 222, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 13, 39, 37, 222, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 94,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 23, 3, 50, 22, 130, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 8, 50, 22, 130, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 95,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 10, 17, 47, 46, 881, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 23, 47, 46, 881, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 96,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 5, 12, 17, 10, 610, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 20, 17, 10, 610, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 97,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 27, 1, 26, 42, 864, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 3, 26, 42, 864, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 98,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 24, 16, 55, 41, 904, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 2, 55, 41, 904, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 99,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 16, 4, 18, 51, 101, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 12, 18, 51, 101, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 7, 12, 31, 1, 593, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 15, 31, 1, 593, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 101,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 5, 14, 51, 20, 580, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 22, 51, 20, 580, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 1,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 2,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 3,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 4,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 3,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 4,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 5,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 6,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 7,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 8,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 9,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 10,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 11,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 12,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 2, 51, 15, 439, DateTimeKind.Local).AddTicks(2247));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5635), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 2,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5651), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 3,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 4,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5662), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 5,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 6,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5674), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 7,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 8,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 9,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5689), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 10,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5694), new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 1,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 38, 14, new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 178, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 216, 12, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 158, 17, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 13 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 5,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 85, 24, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 223, 14, new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 210, 16, new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 8,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 129, 15, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 40, 7, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 10,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 111, 10, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 63, 18, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 12,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 55, 11, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 13,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 193, 18, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 57, 15, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 15,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 153, 17, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 16,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 147, 20, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 6 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 128, 19, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 18,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 43, 21, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 19,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 148, 11, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 20,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 223, 18, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 202, 11, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 190, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 167, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 32, 24, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 220, 9, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 45, 19, new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 27,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 223, 21, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 85, 21, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 66, 20, new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 1,
                column: "CO_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 2,
                column: "CO_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 1,
                column: "CA_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 2,
                column: "CA_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 3,
                column: "CA_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 4,
                column: "CA_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 7,
                column: "D_time",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 9,
                column: "D_time",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 16,
                column: "D_time",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 2,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "81vglj@gmail.com", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0911128004", "81vglj" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "5jxn8kzkez@gmail.com", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0915161579", "5jxn8kzkez", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "b323ij0@gmail.com", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912582204", "b323ij0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0rrk4zmwfrp@gmail.com", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913332647", "0rrk4zmwfrp" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2o0ny6xh@gmail.com", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915362260", "2o0ny6xh" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6sg2i9@gmail.com", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911161206", "6sg2i9", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "jik68qp470b@gmail.com", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916708847", "jik68qp470b", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5kcea8au6u@gmail.com", 1, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0917155952", "f5kcea8au6u", 0 });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 6, 20, 38, 3, 141, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 21, 38, 3, 141, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 20, 0, 21, 40, 241, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 7, 21, 40, 241, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 23, 16, 31, 39, 212, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 2, 31, 39, 212, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 16, 16, 0, 49, 18, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 17, 0, 49, 18, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 4, 11, 41, 18, 903, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 16, 41, 18, 903, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 8, 15, 42, 53, 277, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 19, 42, 53, 277, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 16, 13, 37, 22, 67, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 16, 37, 22, 67, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 24, 19, 0, 36, 629, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 1, 0, 36, 629, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 13, 11, 47, 18, 206, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 15, 47, 18, 206, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 8, 14, 25, 39, 501, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 18, 25, 39, 501, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 5, 18, 25, 54, 104, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 3, 25, 54, 104, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 28, 15, 2, 9, 298, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 18, 2, 9, 298, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 19, 5, 21, 10, 987, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 6, 21, 10, 987, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 1, 2, 18, 25, 239, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 7, 18, 25, 239, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 21, 13, 22, 25, 494, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 18, 22, 25, 494, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 19, 2, 18, 42, 398, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 9, 18, 42, 398, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 17,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 24, 23, 45, 7, 834, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 4, 45, 7, 834, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 18,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 20, 10, 23, 55, 708, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 20, 23, 55, 708, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 18, 4, 43, 50, 687, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 6, 43, 50, 687, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 20,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 20, 6, 41, 40, 801, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 14, 41, 40, 801, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 21,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 2, 13, 42, 13, 2, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 23, 42, 13, 2, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 22,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 21, 17, 23, 25, 807, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 21, 23, 25, 807, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 23,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 18, 22, 18, 16, 929, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 1, 18, 16, 929, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 24,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 27, 23, 39, 55, 138, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 4, 39, 55, 138, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 25,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 17, 8, 9, 1, 909, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 13, 9, 1, 909, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 26,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 14, 4, 29, 53, 346, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 13, 29, 53, 346, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 27,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 4, 18, 37, 17, 936, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 20, 37, 17, 936, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 28,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 13, 19, 35, 21, 988, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 3, 35, 21, 988, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 29,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 14, 13, 0, 27, 824, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 21, 0, 27, 824, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 30,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 1, 23, 37, 54, 69, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 2, 37, 54, 69, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 31,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 12, 7, 24, 57, 860, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 17, 24, 57, 860, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 32,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 3, 2, 12, 31, 132, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 3, 12, 31, 132, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 33,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 57, 8, 533, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 22, 57, 8, 533, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 7, 11, 44, 39, 96, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 20, 44, 39, 96, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 35,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 10, 11, 41, 8, 484, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 20, 41, 8, 484, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 36,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 12, 12, 51, 0, 870, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 15, 51, 0, 870, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 37,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 4, 6, 46, 17, 322, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 15, 46, 17, 322, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 38,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 28, 9, 0, 32, 640, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 12, 0, 32, 640, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 39,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 30, 14, 10, 11, 312, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 18, 10, 11, 312, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 40,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 6, 5, 37, 5, 360, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 6, 37, 5, 360, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 41,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 18, 0, 10, 58, 310, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 3, 10, 58, 310, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 42,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 23, 19, 51, 3, 784, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 3, 51, 3, 784, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 43,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 15, 22, 58, 55, 913, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 23, 58, 55, 913, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 44,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 29, 19, 3, 25, 524, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 3, 3, 25, 524, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 45,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 23, 23, 17, 26, 983, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 5, 17, 26, 983, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 46,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 24, 2, 26, 28, 351, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 9, 26, 28, 351, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 47,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 3, 16, 5, 6, 894, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 19, 5, 6, 894, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 7, 6, 18, 59, 317, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 11, 18, 59, 317, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 49,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 20, 0, 56, 35, 344, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 7, 56, 35, 344, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 50,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 3, 11, 28, 3, 767, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 12, 28, 3, 767, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 51,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 20, 15, 3, 38, 218, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 18, 3, 38, 218, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 52,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 4, 18, 47, 15, 58, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 1, 47, 15, 58, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 53,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 27, 11, 20, 50, 461, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 20, 50, 461, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 54,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 20, 3, 31, 19, 961, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 6, 31, 19, 961, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 55,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 11, 23, 49, 12, 302, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 8, 49, 12, 302, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 56,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 23, 19, 24, 5, 449, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 0, 24, 5, 449, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 57,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 16, 18, 11, 29, 526, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 4, 11, 29, 526, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 58,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 25, 19, 48, 8, 980, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 20, 48, 8, 980, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 59,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 20, 16, 11, 22, 979, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 17, 11, 22, 979, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 60,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 12, 12, 42, 47, 841, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 17, 42, 47, 841, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 4, 20, 27, 44, 262, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 4, 27, 44, 262, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 62,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 22, 14, 50, 8, 44, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 21, 50, 8, 44, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 63,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 31, 4, 48, 14, 438, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 12, 48, 14, 438, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 64,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 14, 1, 57, 59, 671, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 4, 57, 59, 671, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 65,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 20, 22, 24, 32, 600, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 1, 24, 32, 600, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 66,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 15, 5, 29, 31, 144, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 9, 29, 31, 144, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 67,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 6, 21, 24, 17, 984, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 3, 24, 17, 984, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 68,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 24, 17, 55, 34, 875, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 1, 55, 34, 875, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 69,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 2, 10, 35, 49, 19, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 15, 35, 49, 19, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 70,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 19, 22, 55, 54, 634, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 6, 55, 54, 634, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 71,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 1, 7, 57, 44, 990, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 8, 57, 44, 990, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 72,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 25, 21, 20, 22, 768, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 23, 20, 22, 768, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 73,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 27, 8, 51, 17, 890, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 12, 51, 17, 890, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 74,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 1, 20, 5, 45, 846, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 21, 5, 45, 846, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 75,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 27, 7, 27, 16, 802, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 27, 16, 802, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 76,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 1, 5, 11, 48, 717, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 7, 11, 48, 717, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 77,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 5, 17, 26, 15, 434, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 3, 26, 15, 434, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 78,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 16, 1, 3, 32, 273, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 5, 3, 32, 273, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 79,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 17, 16, 33, 18, 786, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 20, 33, 18, 786, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 5, 5, 7, 46, 615, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 7, 7, 46, 615, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 81,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 8, 15, 52, 23, 280, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 1, 52, 23, 280, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 82,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 10, 11, 58, 10, 409, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 15, 58, 10, 409, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 83,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 4, 20, 55, 7, 915, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 0, 55, 7, 915, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 84,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 16, 17, 27, 59, 433, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 3, 27, 59, 433, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 4, 4, 23, 45, 391, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 13, 23, 45, 391, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 86,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 23, 23, 48, 42, 449, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 9, 48, 42, 449, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 87,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 4, 3, 43, 43, 29, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 4, 43, 43, 29, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 88,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 1, 7, 3, 37, 216, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 15, 3, 37, 216, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 89,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 23, 8, 27, 8, 292, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 12, 27, 8, 292, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 90,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 31, 18, 17, 23, 41, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 21, 17, 23, 41, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 91,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 29, 9, 9, 57, 750, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 9, 57, 750, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 92,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 23, 2, 44, 31, 952, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 10, 44, 31, 952, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 93,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 19, 23, 51, 49, 362, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 5, 51, 49, 362, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 94,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 29, 15, 16, 35, 359, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 19, 16, 35, 359, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 95,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 6, 17, 37, 29, 602, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 20, 37, 29, 602, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 96,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 4, 10, 49, 1, 672, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 19, 49, 1, 672, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 97,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 4, 2, 2, 46, 408, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 6, 2, 46, 408, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 98,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 12, 3, 44, 21, 214, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 8, 44, 21, 214, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 99,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 31, 3, 23, 21, 630, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 12, 23, 21, 630, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 25, 22, 58, 29, 710, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 4, 58, 29, 710, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 101,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 22, 9, 20, 54, 173, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 13, 20, 54, 173, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 1,
                column: "O_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 2,
                column: "O_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 3,
                column: "O_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 4,
                column: "O_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 3, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 7, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 5, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 5, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 3, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 3,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 4,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 5,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 6,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 7,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 8,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 9,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 10,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 11,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 12,
                column: "P_Date",
                value: new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5764));
        }
    }
}
