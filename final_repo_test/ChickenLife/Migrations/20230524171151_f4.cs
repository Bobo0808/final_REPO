using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenLife.Migrations
{
    public partial class f4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 2,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 3,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 4,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 5,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 6,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4209), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 7,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 8,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4243), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 9,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4247), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 10,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4252), new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 1,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 110, 22, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 108, 17, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 122, 17, new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 188, 18, new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 5,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 204, 10, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 236, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 84, 15, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 8,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 155, 9, new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 175, 21, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 10,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 137, 11, new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 91, new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 12,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 83, 21, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 13,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 93, 14, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 104, 24, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 15,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 163, 15, new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 16,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 219, 21, new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 82, 12, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 18,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 73, 24, new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 19,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 173, 17, new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 20,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 238, 22, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 97, 18, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 184, 23, new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 85, 11, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 218, 8, new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 214, new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 11 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 227, 11, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 27,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 131, 18, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 50, 11, new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 237, 12, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 17 });

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 1,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 2,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 1,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 2,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 3,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 4,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 1, 11, 51, 367, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 2,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0wv4hxiqp3@gmail.com", new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0915690170", "0wv4hxiqp3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "92wx5jv@gmail.com", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0913390668", "92wx5jv" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "q4xv7mj03@gmail.com", 1, new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0919775541", "q4xv7mj03" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "sn467wg7xxy@gmail.com", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918800016", "sn467wg7xxy", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "cr1zumxae@gmail.com", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0910390911", "cr1zumxae", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "2kc9bky@gmail.com", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914831993", "2kc9bky" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tk5owvst5bx@gmail.com", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915430796", "tk5owvst5bx" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "5oovimm9@gmail.com", 0, new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912134042", "5oovimm9", 1 });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 25, 19, 43, 57, 801, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 1, 43, 57, 801, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 9, 21, 40, 21, 841, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 23, 40, 21, 841, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 7, 21, 29, 7, 478, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 6, 29, 7, 478, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 11, 21, 54, 12, 402, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 4, 54, 12, 402, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 23, 22, 34, 46, 23, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 3, 34, 46, 23, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 9, 10, 20, 11, 376, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 18, 20, 11, 376, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 28, 15, 19, 31, 159, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 22, 19, 31, 159, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 5, 2, 30, 43, 683, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 12, 30, 43, 683, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 12, 10, 51, 58, 673, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 11, 51, 58, 673, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 20, 4, 31, 37, 479, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 7, 31, 37, 479, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 12, 5, 45, 14, 131, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 15, 45, 14, 131, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 21, 13, 46, 25, 213, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 19, 46, 25, 213, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 26, 22, 58, 30, 514, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 2, 58, 30, 514, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 3, 12, 37, 48, 460, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 19, 37, 48, 460, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 28, 3, 18, 1, 42, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 6, 18, 1, 42, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 8, 5, 58, 31, 99, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 10, 58, 31, 99, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 17,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 10, 20, 42, 6, 918, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 5, 42, 6, 918, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 29, 21, 6, 51, 815, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 6, 6, 51, 815, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 27, 18, 53, 36, 263, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 1, 53, 36, 263, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 20,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 2, 13, 25, 30, 356, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 14, 25, 30, 356, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 21,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 14, 21, 12, 8, 198, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 3, 12, 8, 198, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 22,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 27, 9, 26, 20, 685, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 19, 26, 20, 685, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 23,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 29, 16, 36, 30, 414, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 21, 36, 30, 414, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 24,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 12, 10, 32, 5, 782, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 20, 32, 5, 782, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 25,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 1, 19, 35, 41, 42, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 3, 35, 41, 42, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 26,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 9, 16, 52, 50, 590, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 20, 52, 50, 590, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 27,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 4, 22, 28, 22, 667, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 8, 28, 22, 667, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 28,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 28, 18, 36, 54, 439, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 4, 36, 54, 439, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 29,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 2, 6, 39, 39, 712, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 8, 39, 39, 712, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 30,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 12, 12, 50, 41, 733, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 22, 50, 41, 733, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 31,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 6, 15, 8, 11, 769, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 16, 8, 11, 769, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 32,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 3, 8, 15, 34, 906, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 10, 15, 34, 906, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 33,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 29, 10, 14, 54, 220, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 14, 14, 54, 220, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 2, 4, 1, 56, 983, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 13, 1, 56, 983, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 35,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 18, 21, 29, 49, 587, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 2, 29, 49, 587, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 36,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 27, 20, 36, 9, 529, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 4, 36, 9, 529, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 37,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 6, 6, 24, 40, 876, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 8, 24, 40, 876, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 38,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 3, 3, 22, 36, 677, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 8, 22, 36, 677, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 39,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 12, 2, 51, 26, 439, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 9, 51, 26, 439, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 40,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 3, 21, 39, 34, 167, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 0, 39, 34, 167, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 41,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 26, 21, 0, 14, 668, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 22, 0, 14, 668, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 42,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 15, 5, 9, 28, 750, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 6, 9, 28, 750, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 43,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 16, 17, 49, 15, 43, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 23, 49, 15, 43, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 44,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 2, 11, 58, 23, 321, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 18, 58, 23, 321, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 45,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 13, 3, 25, 18, 371, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 6, 25, 18, 371, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 46,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 15, 14, 7, 43, 550, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 15, 7, 43, 550, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 47,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 22, 14, 50, 35, 664, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 18, 50, 35, 664, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 30, 1, 54, 11, 859, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 4, 54, 11, 859, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 49,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 14, 4, 21, 46, 16, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 6, 21, 46, 16, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 50,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 1, 8, 56, 12, 321, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 18, 56, 12, 321, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 51,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 27, 19, 29, 50, 915, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 21, 29, 50, 915, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 52,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 9, 7, 43, 55, 498, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 13, 43, 55, 498, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 53,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 20, 22, 35, 57, 410, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 23, 35, 57, 410, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 54,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 29, 17, 45, 23, 230, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 20, 45, 23, 230, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 55,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 24, 14, 15, 59, 636, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 23, 15, 59, 636, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 56,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 23, 2, 50, 0, 677, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 12, 50, 0, 677, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 57,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 10, 21, 24, 51, 755, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 4, 24, 51, 755, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 58,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 10, 22, 5, 47, 637, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 0, 5, 47, 637, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 59,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 11, 15, 17, 52, 156, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 1, 17, 52, 156, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 60,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 26, 22, 4, 1, 488, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 8, 4, 1, 488, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 13, 21, 52, 42, 292, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 23, 52, 42, 292, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 62,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 20, 23, 28, 42, 891, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 7, 28, 42, 891, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 63,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 22, 11, 44, 51, 962, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 15, 44, 51, 962, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 64,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 14, 7, 26, 11, 863, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 14, 26, 11, 863, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 65,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 4, 15, 21, 49, 675, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 22, 21, 49, 675, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 66,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 25, 2, 3, 9, 286, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 5, 3, 9, 286, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 67,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 23, 13, 55, 26, 409, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 16, 55, 26, 409, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 68,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 14, 10, 5, 47, 49, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 11, 5, 47, 49, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 69,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 11, 21, 47, 3, 235, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 22, 47, 3, 235, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 70,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 5, 7, 0, 30, 979, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 9, 0, 30, 979, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 71,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 27, 15, 13, 56, 571, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 21, 13, 56, 571, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 72,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 9, 23, 3, 53, 107, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 3, 53, 107, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 73,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 22, 16, 18, 15, 391, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 23, 18, 15, 391, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 74,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 5, 23, 26, 26, 587, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 9, 26, 26, 587, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 75,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 21, 9, 19, 50, 544, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 18, 19, 50, 544, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 76,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 22, 6, 12, 21, 469, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 10, 12, 21, 469, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 77,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 27, 16, 16, 20, 290, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 22, 16, 20, 290, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 78,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 12, 19, 24, 56, 890, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 2, 24, 56, 890, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 79,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 31, 20, 7, 12, 427, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 0, 7, 12, 427, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 7, 18, 30, 21, 106, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 3, 30, 21, 106, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 81,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 22, 7, 6, 50, 293, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 17, 6, 50, 293, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 82,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 5, 18, 22, 12, 691, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 0, 22, 12, 691, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 83,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 5, 15, 15, 39, 999, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 22, 15, 39, 999, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 84,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 20, 1, 42, 18, 107, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 7, 42, 18, 107, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 12, 3, 34, 56, 256, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 10, 34, 56, 256, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 86,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 13, 23, 5, 24, 756, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 4, 5, 24, 756, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 87,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 6, 0, 19, 44, 192, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 7, 19, 44, 192, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 88,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 8, 19, 39, 37, 650, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 20, 39, 37, 650, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 89,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 2, 5, 23, 14, 19, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 7, 23, 14, 19, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 90,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 15, 5, 18, 58, 865, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 8, 18, 58, 865, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 91,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 56, 37, 314, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 22, 56, 37, 314, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 92,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 17, 19, 20, 22, 322, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 1, 20, 22, 322, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 93,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 3, 22, 1, 32, 577, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 5, 1, 32, 577, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 94,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 2, 6, 57, 14, 347, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 14, 57, 14, 347, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 95,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 9, 10, 53, 27, 575, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 14, 53, 27, 575, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 96,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 1, 2, 54, 44, 448, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 12, 54, 44, 448, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 97,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 29, 3, 4, 57, 11, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 12, 4, 57, 11, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 98,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 13, 6, 28, 4, 586, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 28, 4, 586, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 99,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 5, 18, 14, 21, 23, 163, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 21, 21, 23, 163, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 6, 7, 49, 28, 298, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 16, 49, 28, 298, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 101,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 14, 7, 26, 44, 612, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 13, 26, 44, 612, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 1,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 2,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 3,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 4,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 3,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 4,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 5,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 6,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 7,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 8,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 9,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 10,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 11,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 12,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 11, 51, 368, DateTimeKind.Local).AddTicks(4304));
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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 38, 14, new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 178, 12, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 216, 12, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 158, 17, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

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
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 223, new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 129, 15, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 40, 7, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20 });

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
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 63, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 11 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 193, 18, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 153, 17, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 223, 18, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 202, 11, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 190, 9, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 167, 19, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 32, 24, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 220, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 223, 21, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 85, 21, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 66, 20, new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10 });

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
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4978) });

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
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 10, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4980) });

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
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4990) });

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
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "5jxn8kzkez@gmail.com", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0915161579", "5jxn8kzkez" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "b323ij0@gmail.com", 0, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0912582204", "b323ij0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0rrk4zmwfrp@gmail.com", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0913332647", "0rrk4zmwfrp", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2o0ny6xh@gmail.com", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0915362260", "2o0ny6xh", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6sg2i9@gmail.com", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0911161206", "6sg2i9" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "jik68qp470b@gmail.com", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0916708847", "jik68qp470b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5kcea8au6u@gmail.com", 1, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0917155952", "f5kcea8au6u", 0 });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 23, 16, 31, 39, 212, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 2, 31, 39, 212, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 20, 10, 23, 55, 708, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 20, 23, 55, 708, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 2, 13, 42, 13, 2, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 23, 42, 13, 2, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 12, 7, 24, 57, 860, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 17, 24, 57, 860, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 23, 15, 57, 8, 533, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 22, 57, 8, 533, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 2, 7, 11, 44, 39, 96, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 20, 44, 39, 96, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 5, 6, 894, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 19, 5, 6, 894, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 7, 6, 18, 59, 317, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 11, 18, 59, 317, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 27, 11, 20, 50, 461, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 20, 50, 461, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 23, 19, 24, 5, 449, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 0, 24, 5, 449, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 12, 12, 42, 47, 841, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 17, 42, 47, 841, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 4, 20, 27, 44, 262, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 4, 27, 44, 262, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 14, 1, 57, 59, 671, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 4, 57, 59, 671, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 2, 10, 35, 49, 19, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 15, 35, 49, 19, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 25, 21, 20, 22, 768, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 23, 20, 22, 768, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 17, 16, 33, 18, 786, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 20, 33, 18, 786, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 5, 5, 7, 46, 615, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 7, 7, 46, 615, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 29, 9, 9, 57, 750, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 9, 57, 750, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 4, 10, 49, 1, 672, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 19, 49, 1, 672, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 31, 3, 23, 21, 630, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 12, 23, 21, 630, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 25, 22, 58, 29, 710, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 4, 58, 29, 710, DateTimeKind.Unspecified) });

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
