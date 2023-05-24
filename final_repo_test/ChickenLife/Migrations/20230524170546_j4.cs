using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenLife.Migrations
{
    public partial class j4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5345), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 2,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 3,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5385), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 4,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5389), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 5,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5394), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 6,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 7,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5403), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 8,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 9,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5411), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 10,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5416), new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 1,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 105, 22, new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 2,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 118, 20, new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 3,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 132, 15, new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 4,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 134, 16, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 5,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 216, 10, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 47, 23, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 199, new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 8,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 197, 9, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 9,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 204, 17, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 10,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 187, 14, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 11,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 88, 8, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 13 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 12,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 99, 20, new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 13,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 149, 24, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 171, 11, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 15,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 108, 11, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 16,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 231, 19, new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 17,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 43, 12, new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 18,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 177, 18, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 19,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 160, 18, new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 20,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 148, 13, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 21,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 127, 23, new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 165, 15, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 12 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 203, 15, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 24,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 236, 15, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 25,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 225, 15, new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 77, 24, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 27,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 86, 11, new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 28,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 130, 9, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 29,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 168, 17, new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6 });

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 1,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "CardOrders",
                keyColumn: "CO_ID",
                keyValue: 2,
                column: "CO_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 1,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 2,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 3,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CA_ID",
                keyValue: 4,
                column: "CA_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 7, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 8, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 17,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 18,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "DebugLogs",
                keyColumn: "D_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "D_time" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 1, 5, 45, 842, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 2,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "oqi00ft8732@gmail.com", new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0915026680", "oqi00ft8732", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hktuag3jck@gmail.com", 1, new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0919584488", "hktuag3jck" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 4,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "p5no7z7n@gmail.com", 1, new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0915047502", "p5no7z7n" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 5,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "0nz8sfw@gmail.com", 0, new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0919647789", "0nz8sfw", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "6pxyzx0u2w@gmail.com", 1, new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915847728", "6pxyzx0u2w", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "8fignxq@gmail.com", 1, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0914460703", "8fignxq" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "8d8l1b85g@gmail.com", 1, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0916241807", "8d8l1b85g", 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "aatnk5gds@gmail.com", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0911077813", "aatnk5gds", 1 });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 5, 22, 22, 25, 12, 753, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 23, 25, 12, 753, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 8, 17, 18, 6, 516, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 23, 18, 6, 516, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 14, 18, 8, 30, 455, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 22, 8, 30, 455, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 6, 12, 46, 52, 95, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 19, 46, 52, 95, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 27, 23, 6, 7, 380, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 5, 6, 7, 380, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 15, 16, 37, 20, 884, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 22, 37, 20, 884, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 19, 4, 29, 45, 886, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 7, 29, 45, 886, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 7, 8, 37, 48, 496, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 14, 37, 48, 496, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 16, 8, 24, 49, 956, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 13, 24, 49, 956, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 17, 20, 37, 38, 347, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 1, 37, 38, 347, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 19, 4, 6, 46, 884, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 14, 6, 46, 884, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 18, 17, 11, 49, 770, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 22, 11, 49, 770, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 20, 19, 13, 41, 287, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 1, 13, 41, 287, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 14,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 2, 20, 13, 0, 43, 353, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 16, 0, 43, 353, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 15,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 17, 18, 27, 56, 844, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 23, 27, 56, 844, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 16,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 16, 17, 4, 22, 153, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 18, 4, 22, 153, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 17,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 9, 22, 53, 1, 177, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 2, 53, 1, 177, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 18,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 10, 20, 21, 38, 559, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 5, 21, 38, 559, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 19,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 13, 16, 58, 35, 207, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 2, 58, 35, 207, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 20,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 1, 8, 25, 39, 692, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 13, 25, 39, 692, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 21,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 18, 12, 34, 14, 558, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 22, 34, 14, 558, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 22,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 21, 21, 10, 14, 564, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 22, 10, 14, 564, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 23,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 5, 16, 43, 31, 32, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 19, 43, 31, 32, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 24,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 5, 10, 15, 8, 49, 243, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 0, 8, 49, 243, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 25,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 22, 3, 8, 24, 695, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 6, 8, 24, 695, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 26,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 21, 18, 46, 14, 586, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 23, 46, 14, 586, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 27,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 28, 26, 957, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 7, 28, 26, 957, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 28,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 28, 21, 39, 35, 398, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 5, 39, 35, 398, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 29,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 31, 17, 0, 42, 218, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 18, 0, 42, 218, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 30,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 5, 1, 3, 5, 413, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 5, 3, 5, 413, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 31,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 28, 6, 11, 57, 779, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 11, 11, 57, 779, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 32,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 15, 3, 22, 27, 500, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 9, 22, 27, 500, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 33,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 8, 13, 49, 41, 424, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 19, 49, 41, 424, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 34,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 4, 15, 20, 30, 40, 252, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 22, 30, 40, 252, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 35,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 2, 9, 0, 57, 54, 209, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 5, 57, 54, 209, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 36,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 8, 16, 34, 51, 533, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 21, 34, 51, 533, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 37,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 11, 7, 49, 46, 374, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 13, 49, 46, 374, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 38,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 4, 26, 19, 54, 32, 344, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 20, 54, 32, 344, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 39,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 17, 8, 21, 58, 256, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 9, 21, 58, 256, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 40,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 30, 14, 18, 30, 185, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 23, 18, 30, 185, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 41,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 10, 12, 39, 39, 322, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 16, 39, 39, 322, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 42,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 15, 16, 21, 49, 814, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 23, 21, 49, 814, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 43,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 20, 9, 2, 56, 756, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 15, 2, 56, 756, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 44,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 7, 7, 36, 44, 730, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 10, 36, 44, 730, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 45,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 22, 21, 1, 9, 641, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 23, 1, 9, 641, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 46,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 4, 13, 3, 48, 1, 894, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 8, 48, 1, 894, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 47,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 3, 14, 8, 46, 38, 106, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 17, 46, 38, 106, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 48,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 5, 17, 57, 44, 528, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 23, 57, 44, 528, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 49,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 2, 20, 12, 46, 22, 811, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 16, 46, 22, 811, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 50,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 18, 4, 26, 21, 302, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 8, 26, 21, 302, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 51,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 30, 2, 47, 20, 338, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 6, 47, 20, 338, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 52,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 22, 15, 36, 43, 484, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 17, 36, 43, 484, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 53,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 17, 1, 33, 32, 269, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 3, 33, 32, 269, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 54,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 26, 18, 26, 23, 436, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 2, 26, 23, 436, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 55,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 5, 9, 9, 9, 14, 986, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 14, 9, 14, 986, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 56,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 28, 20, 42, 26, 166, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 6, 42, 26, 166, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 57,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 25, 10, 48, 49, 148, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 17, 48, 49, 148, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 58,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 10, 7, 13, 56, 994, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 9, 13, 56, 994, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 59,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 16, 7, 3, 44, 117, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 12, 3, 44, 117, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 60,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 3, 7, 9, 36, 52, 473, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 18, 36, 52, 473, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 61,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 2, 28, 10, 13, 3, 634, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 16, 13, 3, 634, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 62,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 3, 9, 23, 51, 47, 240, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 2, 51, 47, 240, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 63,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 24, 1, 17, 12, 346, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 9, 17, 12, 346, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 64,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 2, 18, 11, 50, 33, 104, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 19, 50, 33, 104, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 65,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 4, 10, 39, 38, 154, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 13, 39, 38, 154, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 66,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 17, 10, 9, 22, 632, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 12, 9, 22, 632, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 67,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 27, 18, 5, 21, 336, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 21, 5, 21, 336, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 68,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 4, 15, 17, 51, 47, 56, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 1, 51, 47, 56, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 69,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 26, 3, 53, 16, 934, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 9, 53, 16, 934, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 70,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 5, 1, 5, 50, 47, 368, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 7, 50, 47, 368, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 71,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 13, 18, 5, 24, 382, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 23, 5, 24, 382, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 72,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 14, 17, 21, 6, 642, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 18, 21, 6, 642, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 73,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 31, 14, 51, 57, 817, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 17, 51, 57, 817, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 74,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 4, 24, 16, 20, 49, 617, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 23, 20, 49, 617, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 75,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 28, 9, 44, 42, 865, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 16, 44, 42, 865, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 76,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 19, 21, 35, 19, 722, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 22, 35, 19, 722, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 77,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 18, 10, 56, 58, 135, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 15, 56, 58, 135, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 78,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 5, 15, 6, 11, 481, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 17, 6, 11, 481, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 79,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 7, new DateTime(2023, 5, 7, 6, 43, 41, 322, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 13, 43, 41, 322, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 80,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 3, 5, 10, 58, 20, 736, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 19, 58, 20, 736, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 81,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 5, 14, 22, 16, 36, 261, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 23, 16, 36, 261, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 82,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 13, 9, 25, 17, 170, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 10, 25, 17, 170, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 83,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 5, 18, 20, 7, 12, 328, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 5, 7, 12, 328, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 84,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 3, 19, 54, 40, 296, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 0, 54, 40, 296, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 0, 29, 615, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 17, 0, 29, 615, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 86,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 8, new DateTime(2023, 3, 29, 20, 16, 26, 302, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 1, 16, 26, 302, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 87,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 22, 5, 35, 48, 790, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 6, 35, 48, 790, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 88,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 4, new DateTime(2023, 4, 17, 17, 7, 1, 853, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 20, 7, 1, 853, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 89,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 1, new DateTime(2023, 3, 29, 1, 14, 16, 911, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 3, 14, 16, 911, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 90,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 3, 28, 15, 30, 3, 183, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 17, 30, 3, 183, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 91,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 4, 20, 21, 48, 4, 424, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 23, 48, 4, 424, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 92,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 4, 5, 21, 59, 50, 151, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 3, 59, 50, 151, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 93,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 9, new DateTime(2023, 2, 28, 11, 18, 30, 610, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 16, 18, 30, 610, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 94,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 5, 11, 31, 8, 828, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 21, 31, 8, 828, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 95,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 3, 16, 20, 39, 36, 83, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 2, 39, 36, 83, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 96,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 14, 1, 30, 33, 512, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 9, 30, 33, 512, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 97,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 3, new DateTime(2023, 2, 6, 3, 16, 54, 607, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 7, 16, 54, 607, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 98,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 3, 1, 23, 3, 48, 922, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 4, 3, 48, 922, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 99,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 5, new DateTime(2023, 4, 18, 8, 23, 8, 973, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 17, 23, 8, 973, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 100,
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 6, new DateTime(2023, 2, 23, 13, 58, 55, 425, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 23, 58, 55, 425, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 101,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 3, 6, 13, 14, 23, 309, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 22, 14, 23, 309, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 1,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 2,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 3,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 4,
                column: "O_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 5,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 6,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 3, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 7,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 8,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 1, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 9,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 10,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 9, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 11,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 6, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 12,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 5, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "O_ID",
                keyValue: 13,
                columns: new[] { "A_ID", "O_Date" },
                values: new object[] { 4, new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 3,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 4,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 5,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 6,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 7,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 8,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 9,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 10,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 11,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 12,
                column: "P_Date",
                value: new DateTime(2023, 5, 25, 1, 5, 45, 843, DateTimeKind.Local).AddTicks(5468));
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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 38, 14, new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 85, 24, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 13 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 6,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 223, 14, new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 7,
                columns: new[] { "Ad_Clicks", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 210, new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 17 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 111, 10, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 193, 18, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 14,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 57, 15, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 147, 20, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID" },
                values: new object[] { 43, 21, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 202, 11, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 16 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 22,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 190, 9, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 18 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 23,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 167, 19, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "CaseID", "PartnerID" },
                values: new object[] { 220, 9, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9 });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Ad_ID",
                keyValue: 26,
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 45, 19, new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

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
                columns: new[] { "Ad_Clicks", "Ad_DayCount", "Ad_EndTime", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TimeOfPayment", "PartnerID" },
                values: new object[] { 85, 21, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

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
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "81vglj@gmail.com", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0911128004", "81vglj", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 3,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "5jxn8kzkez@gmail.com", 0, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0915161579", "5jxn8kzkez" });

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
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0rrk4zmwfrp@gmail.com", 1, new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0913332647", "0rrk4zmwfrp", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 6,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2o0ny6xh@gmail.com", 0, new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0915362260", "2o0ny6xh", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 7,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd" },
                values: new object[] { new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6sg2i9@gmail.com", 0, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0911161206", "6sg2i9" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 8,
                columns: new[] { "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "jik68qp470b@gmail.com", 0, new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0916708847", "jik68qp470b", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "E_ID",
                keyValue: 9,
                columns: new[] { "E_Birthday", "E_Email", "E_HireDate", "E_Permission", "E_Phone", "E_Pwd", "E_Title" },
                values: new object[] { new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5kcea8au6u@gmail.com", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0917155952", "f5kcea8au6u", 0 });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 41, 18, 903, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 16, 41, 18, 903, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 20, 6, 41, 40, 801, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 14, 41, 40, 801, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 4, 18, 37, 17, 936, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 20, 37, 17, 936, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 1, 23, 37, 54, 69, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 2, 37, 54, 69, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 10, 11, 312, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 18, 10, 11, 312, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 15, 22, 58, 55, 913, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 23, 58, 55, 913, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 20, 3, 31, 19, 961, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 6, 31, 19, 961, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 2, 16, 18, 11, 29, 526, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 4, 11, 29, 526, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 15, 5, 29, 31, 144, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 9, 29, 31, 144, DateTimeKind.Unspecified) });

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
                columns: new[] { "A_ID", "L_cTime", "L_dcTime" },
                values: new object[] { 2, new DateTime(2023, 5, 24, 17, 55, 34, 875, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 1, 55, 34, 875, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 27, 59, 433, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 3, 27, 59, 433, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 85,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 4, 4, 23, 45, 391, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 13, 23, 45, 391, DateTimeKind.Unspecified) });

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
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 22, 9, 20, 54, 173, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 13, 20, 54, 173, DateTimeKind.Unspecified) });

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
