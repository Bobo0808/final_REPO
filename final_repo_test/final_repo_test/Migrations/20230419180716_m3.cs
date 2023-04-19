using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Ads_OrderStatus_OS_ID",
                table: "Ads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ads_OrderStatus",
                table: "Ads_OrderStatus");

            migrationBuilder.RenameTable(
                name: "Ads_OrderStatus",
                newName: "Ads_OrderStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ads_OrderStatuses",
                table: "Ads_OrderStatuses",
                column: "OS_ID");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 20, 2, 7, 16, 692, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 4, 20, 2, 7, 16, 692, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.InsertData(
                table: "CaseTables",
                columns: new[] { "Case_ID", "Case_Name", "Case_PricePerDay" },
                values: new object[,]
                {
                    { 1, "兇兇肥婆", 50m },
                    { 2, "兇兇大魷魚", 20m },
                    { 3, "兇兇肥婆", 50m },
                    { 4, "兇兇大魷魚", 20m }
                });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 20, 2, 7, 16, 692, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 4, 20, 3, 7, 16, 692, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 7, 16, 692, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 4, 19, 1, 7, 16, 692, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 17, 23, 7, 16, 692, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 4, 18, 0, 7, 16, 692, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 22, 7, 16, 692, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 4, 16, 23, 7, 16, 692, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 21, 7, 16, 692, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 4, 15, 22, 7, 16, 692, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 20, 7, 16, 692, DateTimeKind.Local).AddTicks(275), new DateTime(2023, 4, 15, 21, 7, 16, 692, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 19, 7, 16, 692, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 4, 15, 20, 7, 16, 692, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 2, 7, 16, 692, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 4, 20, 2, 7, 16, 692, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Ads_OrderStatuses_OS_ID",
                table: "Ads",
                column: "OS_ID",
                principalTable: "Ads_OrderStatuses",
                principalColumn: "OS_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Ads_OrderStatuses_OS_ID",
                table: "Ads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ads_OrderStatuses",
                table: "Ads_OrderStatuses");

            migrationBuilder.DeleteData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Ads_OrderStatuses",
                newName: "Ads_OrderStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ads_OrderStatus",
                table: "Ads_OrderStatus",
                column: "OS_ID");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 17, 30, 129, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 4, 19, 22, 17, 30, 129, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 1,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 17, 30, 129, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 4, 19, 23, 17, 30, 129, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 2,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 18, 20, 17, 30, 129, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 4, 18, 21, 17, 30, 129, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 3,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 17, 19, 17, 30, 129, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 4, 17, 20, 17, 30, 129, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 4,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 17, 30, 129, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 4, 16, 19, 17, 30, 129, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 5,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 17, 17, 30, 129, DateTimeKind.Local).AddTicks(3308), new DateTime(2023, 4, 15, 18, 17, 30, 129, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 6,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 17, 30, 129, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 4, 15, 17, 17, 30, 129, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "LoginStaus",
                keyColumn: "L_ID",
                keyValue: 7,
                columns: new[] { "L_cTime", "L_dcTime" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 17, 30, 129, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 4, 15, 16, 17, 30, 129, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 1,
                column: "P_Date",
                value: new DateTime(2023, 4, 19, 22, 17, 30, 129, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "P_ID",
                keyValue: 2,
                column: "P_Date",
                value: new DateTime(2023, 4, 19, 22, 17, 30, 129, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Ads_OrderStatus_OS_ID",
                table: "Ads",
                column: "OS_ID",
                principalTable: "Ads_OrderStatus",
                principalColumn: "OS_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
