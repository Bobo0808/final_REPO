using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 20, 3, 40, 12, 24, DateTimeKind.Local).AddTicks(4755), new DateTime(2023, 4, 20, 3, 40, 12, 24, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 1,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "豪華蛋黃熱區", 250m });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 2,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "中等曝光區", 200m });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 3,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "經濟實惠區", 150m });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 4,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "限時特惠專區", 100m });

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

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "P_ID", "Contact", "Email", "P_Name", "P_Note", "Phone" },
                values: new object[,]
                {
                    { 1, "林小明", "apple@gmail.com", "Apple", "好合作", "0912345678" },
                    { 2, "陳大名", "google@gmail.com", "Google", "溝通良好", "0923456789" },
                    { 3, "王小美", "amazon@gmail.com", "Amazon", "產品品質不錯", "0934567890" },
                    { 4, "李志明", "microsoft@gmail.com", "Microsoft", "合作愉快", "0912345678" },
                    { 5, "蔡佳玲", "facebook@gmail.com", "Facebook", "回覆速度快", "0923456789" },
                    { 6, "林小華", "netflix@gmail.com", "Netflix", "服務很好", "0934567890" },
                    { 7, "陳小明", "tesla@gmail.com", "Tesla", "值得信賴", "0912345678" },
                    { 8, "蔡小玲", "twitter@gmail.com", "Twitter", "溝通良好", "0923456789" },
                    { 9, "李小明", "uber@gmail.com", "Uber", "好合作", "0934567890" },
                    { 10, "林小美", "airbnb@gmail.com", "Airbnb", "服務很好", "0912345678" },
                    { 11, "陳大名", "linkedin@gmail.com", "LinkedIn", "回覆速度快", "0923456789" },
                    { 12, "王小華", "dropbox@gmail.com", "Dropbox", "值得信賴", "0934567890" },
                    { 13, "蔡小玲", "twitter@gmail.com", "Twitter", "溝通良好", "0923456789" },
                    { 14, "陳小明", "salesforce@gmail.com", "Salesforce", "產品品質不錯", "0912345678" },
                    { 15, "蔡佳玲", "adobe@gmail.com", "Adobe", "回覆速度快", "0923456789" },
                    { 16, "林小華", "paypal@gmail.com", "PayPal", "合作愉快", "0934567890" },
                    { 17, "陳小明", "oracle@gmail.com", "Oracle", "回覆速度快", "0912345678" },
                    { 18, "蔡小玲", "ibm@gmail.com", "IBM", "好合作", "0923456789" },
                    { 19, "李小明", "intel@gmail.com", "Intel", "值得信賴", "0934567890" },
                    { 20, "林小美", "hp@gmail.com", "HP", "溝通良好", "0912345678" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "P_ID",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "A_ID",
                keyValue: 1,
                columns: new[] { "A_RegisteredAt", "Birthday" },
                values: new object[] { new DateTime(2023, 4, 20, 2, 7, 16, 692, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 4, 20, 2, 7, 16, 692, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 1,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "兇兇肥婆", 50m });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 2,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "兇兇大魷魚", 20m });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 3,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "兇兇肥婆", 50m });

            migrationBuilder.UpdateData(
                table: "CaseTables",
                keyColumn: "Case_ID",
                keyValue: 4,
                columns: new[] { "Case_Name", "Case_PricePerDay" },
                values: new object[] { "兇兇大魷魚", 20m });

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
        }
    }
}
