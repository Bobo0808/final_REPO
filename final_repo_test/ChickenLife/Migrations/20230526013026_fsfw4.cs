using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenLife.Migrations
{
    public partial class fsfw4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1881), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 2,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 3,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 4,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1905), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 5,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 6,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1917), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 7,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1922), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 8,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1945), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 9,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1950), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 10,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1956), new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 1,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 209, 12, new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 78, 16, new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 80, 18, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 107, 11, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 5,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 89, 22, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 134, 11, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 13 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 205, 22, new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 8,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment" },
                values: new object[] { 167, 9, new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 70, 9, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 10,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 92, 23, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 52, 20, new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 12,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 226, 9, new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 13,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 237, 23, new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 172, 22, new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 15,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 234, 18, new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 16,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 46, 9, new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 71, new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 18,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 194, 22, new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 19,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 213, 17, new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 20,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 129, 13, new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 124, 22, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 123, 8, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "CaseID", "PartnerID" },
                values: new object[] { 176, 19, new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 156, 12, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 123, 14, new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 105, 7, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 27,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 136, 21, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 113, 14, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 136, 15, new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 1,
                column: "CO_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 2,
                column: "CO_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 1,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 2,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 3,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 4,
                column: "CA_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 5,
                column: "D_time",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 11,
                column: "D_time",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 14,
                column: "D_time",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 26, 9, 30, 25, 832, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 2,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "t2vbsxr8@gmail.com", new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919907043", "t2vbsxr8" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "h0n7hrr@gmail.com", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0912967176", "h0n7hrr" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "hd4afs1ub@gmail.com", 0, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0915039962", "hd4afs1ub" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "r2q0a45f@gmail.com", 1, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913030702", "r2q0a45f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "gy2lg5h3y@gmail.com", 0, new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917485904", "gy2lg5h3y" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fzrdko5dwk@gmail.com", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0916700832", "fzrdko5dwk", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "u68ch0@gmail.com", 1, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0910986862", "u68ch0", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "bmzly48mm@gmail.com", 1, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914867256", "bmzly48mm", 0 });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 7, 13, 59, 45, 797, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 19, 59, 45, 797, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 9, 15, 33, 39, 617, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 21, 33, 39, 617, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 16, 22, 31, 49, 592, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 4, 31, 49, 592, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 16, 10, 33, 40, 405, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 20, 33, 40, 405, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 23, 10, 22, 18, 77, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 15, 22, 18, 77, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 17, 12, 59, 21, 999, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 18, 59, 21, 999, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 1, 9, 58, 58, 242, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 11, 58, 58, 242, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 24, 14, 13, 46, 698, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 23, 13, 46, 698, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 10, 5, 51, 57, 394, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 14, 51, 57, 394, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 31, 3, 27, 57, 157, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 6, 27, 57, 157, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 7, 20, 11, 23, 153, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 0, 11, 23, 153, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 12,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 29, 19, 48, 23, 471, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 0, 48, 23, 471, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 22, 1, 59, 57, 114, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 8, 59, 57, 114, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 23, 21, 26, 44, 562, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 7, 26, 44, 562, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 30, 23, 3, 51, 560, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 0, 3, 51, 560, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 15, 14, 39, 10, 523, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 22, 39, 10, 523, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 20, 6, 43, 51, 721, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 7, 43, 51, 721, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 17, 4, 15, 3, 396, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 8, 15, 3, 396, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 18, 20, 29, 10, 925, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 23, 29, 10, 925, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 20,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 9, 13, 22, 26, 952, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 22, 22, 26, 952, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 21,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 5, 2, 14, 3, 796, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 4, 14, 3, 796, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 22,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 25, 10, 12, 51, 782, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 18, 12, 51, 782, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 23,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 13, 11, 20, 32, 630, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 16, 20, 32, 630, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 24,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 9, 2, 13, 12, 210, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 7, 13, 12, 210, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 25,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 30, 13, 3, 36, 37, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 18, 3, 36, 37, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 26,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 10, 10, 46, 18, 644, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 14, 46, 18, 644, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 27,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 2, 14, 28, 41, 587, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 22, 28, 41, 587, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 28,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 17, 14, 14, 10, 453, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 21, 14, 10, 453, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 29,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 19, 19, 25, 53, 105, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 4, 25, 53, 105, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 30,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 11, 0, 27, 26, 817, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 2, 27, 26, 817, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 31,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 27, 6, 59, 2, 828, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 7, 59, 2, 828, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 32,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 15, 3, 58, 13, 635, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 6, 58, 13, 635, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 33,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 15, 3, 30, 14, 845, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 10, 30, 14, 845, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 29, 1, 48, 27, 38, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 11, 48, 27, 38, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 35,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 19, 13, 58, 12, 835, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 18, 58, 12, 835, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 36,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 11, 2, 22, 39, 233, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 4, 22, 39, 233, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 37,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 4, 15, 25, 33, 378, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 20, 25, 33, 378, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 38,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 31, 0, 6, 51, 314, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 3, 6, 51, 314, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 39,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 19, 6, 19, 19, 804, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 11, 19, 19, 804, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 40,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 14, 6, 50, 46, 329, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 16, 50, 46, 329, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 41,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 5, 1, 11, 34, 795, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 5, 11, 34, 795, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 42,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 29, 12, 48, 30, 428, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 21, 48, 30, 428, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 43,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 27, 19, 50, 56, 132, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 21, 50, 56, 132, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 44,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 31, 5, 41, 43, 937, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 13, 41, 43, 937, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 45,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 1, 1, 28, 38, 969, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 3, 28, 38, 969, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 46,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 15, 22, 49, 12, 949, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 8, 49, 12, 949, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 47,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 9, 5, 55, 5, 470, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 13, 55, 5, 470, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 19, 4, 35, 16, 783, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 5, 35, 16, 783, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 49,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 29, 5, 50, 30, 798, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 9, 50, 30, 798, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 50,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 3, 18, 15, 50, 741, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 0, 15, 50, 741, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 51,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 20, 22, 36, 38, 854, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 0, 36, 38, 854, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 52,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 5, 5, 9, 28, 130, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 10, 9, 28, 130, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 53,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 5, 18, 24, 17, 715, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 3, 24, 17, 715, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 54,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 30, 19, 26, 42, 718, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 0, 26, 42, 718, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 55,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 6, 21, 13, 403, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 10, 21, 13, 403, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 56,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 28, 14, 38, 6, 395, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 15, 38, 6, 395, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 57,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 14, 8, 13, 44, 831, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 9, 13, 44, 831, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 58,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 27, 10, 29, 49, 6, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 29, 49, 6, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 59,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 15, 21, 22, 5, 986, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 2, 22, 5, 986, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 60,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 27, 20, 25, 46, 679, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 3, 25, 46, 679, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 18, 1, 26, 13, 196, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 8, 26, 13, 196, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 62,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 28, 1, 35, 58, 817, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 10, 35, 58, 817, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 63,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 10, 8, 20, 43, 284, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 9, 20, 43, 284, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 64,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 7, 2, 45, 12, 166, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 8, 45, 12, 166, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 65,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 12, 5, 42, 4, 434, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 13, 42, 4, 434, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 66,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 17, 23, 3, 40, 917, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 7, 3, 40, 917, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 67,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 24, 21, 45, 32, 207, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 22, 45, 32, 207, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 68,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 1, 16, 53, 35, 412, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 18, 53, 35, 412, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 69,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 26, 5, 55, 47, 16, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 6, 55, 47, 16, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 70,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 6, 13, 10, 38, 441, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 17, 10, 38, 441, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 71,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 26, 19, 2, 36, 44, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 22, 2, 36, 44, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 72,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 31, 22, 33, 53, 543, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 7, 33, 53, 543, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 73,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 20, 23, 53, 2, 539, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 9, 53, 2, 539, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 74,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 6, 9, 14, 3, 239, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 14, 14, 3, 239, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 75,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 9, 5, 10, 55, 584, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 14, 10, 55, 584, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 76,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 18, 7, 0, 45, 833, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 15, 0, 45, 833, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 77,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 27, 19, 17, 18, 641, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 21, 17, 18, 641, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 78,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 20, 22, 42, 55, 478, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 6, 42, 55, 478, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 79,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 28, 18, 23, 33, 206, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 20, 23, 33, 206, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 26, 9, 33, 45, 352, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 18, 33, 45, 352, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 81,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 12, 22, 34, 58, 780, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 23, 34, 58, 780, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 82,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 24, 15, 49, 45, 997, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 23, 49, 45, 997, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 83,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 14, 7, 36, 45, 126, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 14, 36, 45, 126, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 84,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 22, 21, 35, 6, 115, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 5, 35, 6, 115, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 5, 22, 0, 51, 508, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 3, 0, 51, 508, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 86,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 22, 2, 24, 15, 986, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 10, 24, 15, 986, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 87,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 28, 15, 49, 18, 326, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 0, 49, 18, 326, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 88,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 15, 17, 32, 54, 981, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 1, 32, 54, 981, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 89,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 27, 13, 47, 36, 287, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 19, 47, 36, 287, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 90,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 7, 11, 53, 0, 353, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 18, 53, 0, 353, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 91,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 23, 20, 37, 30, 957, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 3, 37, 30, 957, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 92,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 6, 19, 7, 47, 527, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 3, 7, 47, 527, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 93,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 15, 6, 20, 3, 787, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 10, 20, 3, 787, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 94,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 14, 11, 22, 48, 251, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 20, 22, 48, 251, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 95,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 7, 7, 37, 36, 936, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 9, 37, 36, 936, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 96,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 2, 10, 56, 30, 261, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 20, 56, 30, 261, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 97,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 12, 16, 3, 13, 194, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 20, 3, 13, 194, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 98,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 8, 9, 33, 1, 899, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 16, 33, 1, 899, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 99,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 6, 21, 20, 2, 928, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 0, 20, 2, 928, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 26, 22, 12, 55, 883, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 3, 12, 55, 883, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 101,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 22, 23, 7, 19, 263, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 7, 7, 19, 263, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 1,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 2,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 3,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 4,
                column: "O_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 8, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 3, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 1, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 5, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 3,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 4,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 5,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 6,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 7,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 8,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 9,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 10,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 11,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 12,
                column: "P_Date",
                value: new DateTime(2023, 5, 26, 9, 30, 25, 833, DateTimeKind.Local).AddTicks(2005));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 116, 14, new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 81, 11, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 179, 10, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 229, 18, new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment" },
                values: new object[] { 114, 14, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 41, 14, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 50, 18, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 148, 14, new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 225, 9, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 89, 23, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 194, new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 6 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 201, 19, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "CaseID", "PartnerID" },
                values: new object[] { 154, 16, new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 134, 20, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 214, 21, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 149, 19, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

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
                column: "D_time",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5009));

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
                column: "D_time",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5018));

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
                column: "D_time",
                value: new DateTime(2023, 5, 26, 9, 29, 49, 343, DateTimeKind.Local).AddTicks(5020));

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
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "hxzdc601g4@gmail.com", new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914372113", "hxzdc601g4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "g56o0v259ei@gmail.com", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0918121737", "g56o0v259ei" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "rr4dyr33y@gmail.com", 1, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0915840420", "rr4dyr33y" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "h0vmrjmcv@gmail.com", 0, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914252549", "h0vmrjmcv" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8mtxxnvbj@gmail.com", 1, new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "0910061960", "8mtxxnvbj" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "pazszq9w@gmail.com", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0919052412", "pazszq9w", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "8cu8g88h@gmail.com", 0, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0914628587", "8cu8g88h", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2oz2syjv@gmail.com", 0, new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918970602", "2oz2syjv", 1 });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 1, 19, 25, 34, 501, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 5, 25, 34, 501, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 3, 5, 40, 7, 691, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 8, 40, 7, 691, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 4, 15, 51, 53, 73, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 21, 51, 53, 73, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 20, 4, 49, 56, 384, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 11, 49, 56, 384, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 13, 3, 52, 30, 228, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 52, 30, 228, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 7, 5, 23, 8, 907, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 10, 23, 8, 907, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 22, 10, 42, 22, 793, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 16, 42, 22, 793, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 58, 13, 582, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 21, 58, 13, 582, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 19, 23, 33, 35, 498, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 7, 33, 35, 498, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 31, 10, 51, 19, 385, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 20, 51, 19, 385, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 27, 23, 56, 25, 886, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 5, 56, 25, 886, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 7, 23, 1, 50, 208, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 1, 1, 50, 208, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 13, 23, 46, 8, 279, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 2, 46, 8, 279, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 22, 10, 22, 23, 112, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 19, 22, 23, 112, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 24, 18, 31, 16, 167, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 22, 31, 16, 167, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 30, 7, 36, 27, 33, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 14, 36, 27, 33, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 6, 16, 57, 43, 197, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 19, 57, 43, 197, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 7, 22, 38, 46, 766, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 5, 38, 46, 766, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 21, 5, 58, 36, 595, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 13, 58, 36, 595, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 11, 2, 21, 42, 228, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 4, 21, 42, 228, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6449) });

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
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 26, 9, 29, 49, 344, DateTimeKind.Local).AddTicks(6493) });

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
    }
}
