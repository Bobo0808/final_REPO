using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class _20230510 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ads_OrderStatuses",
                columns: table => new
                {
                    OS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OS_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS_FullfillmentRate = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    OS_PaymentMultiplier = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads_OrderStatuses", x => x.OS_ID);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CA_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CA_Price = table.Column<int>(type: "int", nullable: false),
                    CA_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CA_Describe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CA_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CA_Discontinuted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CA_ID);
                });

            migrationBuilder.CreateTable(
                name: "CardTypes",
                columns: table => new
                {
                    CT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CT_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTypes", x => x.CT_ID);
                });

            migrationBuilder.CreateTable(
                name: "CaseTables",
                columns: table => new
                {
                    Case_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Case_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Case_PricePerDay = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseTables", x => x.Case_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    E_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    E_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Gender = table.Column<int>(type: "int", nullable: false),
                    E_UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Pwd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Title = table.Column<int>(type: "int", nullable: false),
                    E_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Birthday = table.Column<DateTime>(type: "Date", nullable: false),
                    E_HireDate = table.Column<DateTime>(type: "Date", nullable: false),
                    E_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Permission = table.Column<int>(type: "int", nullable: false),
                    E_Work = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.E_ID);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    M_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M_MapType = table.Column<int>(type: "int", nullable: false),
                    M_Src = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M_minX = table.Column<int>(type: "int", nullable: false),
                    M_minY = table.Column<int>(type: "int", nullable: false),
                    M_maxX = table.Column<int>(type: "int", nullable: false),
                    M_maxY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.M_ID);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.P_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_ProductType = table.Column<int>(type: "int", nullable: false),
                    P_Price = table.Column<int>(type: "int", nullable: false),
                    P_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_Describe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_Instock = table.Column<int>(type: "int", nullable: false),
                    P_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    P_Discount = table.Column<int>(type: "int", nullable: false),
                    P_Discontinuted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.P_ID);
                });

            migrationBuilder.CreateTable(
                name: "BlockSpaces",
                columns: table => new
                {
                    Mb_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_ID = table.Column<int>(type: "int", nullable: false),
                    Mb_starX = table.Column<int>(type: "int", nullable: false),
                    Mb_starY = table.Column<int>(type: "int", nullable: false),
                    Mb_EndX = table.Column<int>(type: "int", nullable: false),
                    Mb_EndY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockSpaces", x => x.Mb_ID);
                    table.ForeignKey(
                        name: "FK_BlockSpaces_Maps_M_ID",
                        column: x => x.M_ID,
                        principalTable: "Maps",
                        principalColumn: "M_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Map_ADAreas",
                columns: table => new
                {
                    Area_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    M_ID = table.Column<int>(type: "int", nullable: false),
                    CaseID = table.Column<int>(type: "int", nullable: false),
                    Area_StartX = table.Column<int>(type: "int", nullable: false),
                    Area_EndX = table.Column<int>(type: "int", nullable: false),
                    Area_StartY = table.Column<int>(type: "int", nullable: false),
                    Area_EndY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map_ADAreas", x => x.Area_ID);
                    table.ForeignKey(
                        name: "FK_Map_ADAreas_CaseTables_CaseID",
                        column: x => x.CaseID,
                        principalTable: "CaseTables",
                        principalColumn: "Case_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Map_ADAreas_Maps_M_ID",
                        column: x => x.M_ID,
                        principalTable: "Maps",
                        principalColumn: "M_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Ad_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnerID = table.Column<int>(type: "int", nullable: false),
                    CaseID = table.Column<int>(type: "int", nullable: false),
                    Ad_StartTime = table.Column<DateTime>(type: "Date", nullable: false),
                    Ad_EndTime = table.Column<DateTime>(type: "Date", nullable: false),
                    Ad_DayCount = table.Column<int>(type: "int", nullable: false),
                    Ad_ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad_TargetURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad_Clicks = table.Column<int>(type: "int", nullable: false),
                    Ad_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad_PaymentDueDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Ad_TimeOfPayment = table.Column<DateTime>(type: "Date", nullable: false),
                    Ad_ActiveStatus = table.Column<int>(type: "int", nullable: false),
                    OS_ID = table.Column<int>(type: "int", nullable: false),
                    AD_FinalPaymentAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Ad_ID);
                    table.ForeignKey(
                        name: "FK_Ads_Ads_OrderStatuses_OS_ID",
                        column: x => x.OS_ID,
                        principalTable: "Ads_OrderStatuses",
                        principalColumn: "OS_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_CaseTables_CaseID",
                        column: x => x.CaseID,
                        principalTable: "CaseTables",
                        principalColumn: "Case_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Partners_PartnerID",
                        column: x => x.PartnerID,
                        principalTable: "Partners",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    A_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPWD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Gender = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "Date", nullable: false),
                    P_id = table.Column<int>(type: "int", nullable: false),
                    A_level = table.Column<int>(type: "int", nullable: false),
                    A_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_add = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_RegisteredAt = table.Column<DateTime>(type: "Date", nullable: false),
                    A_NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Coin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.A_ID);
                    table.ForeignKey(
                        name: "FK_Accounts_Products_P_id",
                        column: x => x.P_id,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardOrders",
                columns: table => new
                {
                    CO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_ID = table.Column<int>(type: "int", nullable: false),
                    CA_ID = table.Column<int>(type: "int", nullable: false),
                    CT_ID = table.Column<int>(type: "int", nullable: false),
                    CO_Sum = table.Column<int>(type: "int", nullable: false),
                    CO_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CO_Cancel = table.Column<bool>(type: "bit", nullable: false),
                    CO_Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardOrders", x => x.CO_ID);
                    table.ForeignKey(
                        name: "FK_CardOrders_Accounts_A_ID",
                        column: x => x.A_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardOrders_Cards_CA_ID",
                        column: x => x.CA_ID,
                        principalTable: "Cards",
                        principalColumn: "CA_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardOrders_CardTypes_CT_ID",
                        column: x => x.CT_ID,
                        principalTable: "CardTypes",
                        principalColumn: "CT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DebugLogs",
                columns: table => new
                {
                    D_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_ID = table.Column<int>(type: "int", nullable: false),
                    D_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    D_event = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_isSolved = table.Column<bool>(type: "bit", nullable: false),
                    D_Comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebugLogs", x => x.D_ID);
                    table.ForeignKey(
                        name: "FK_DebugLogs_Accounts_A_ID",
                        column: x => x.A_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoginStaus",
                columns: table => new
                {
                    L_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_ID = table.Column<int>(type: "int", nullable: false),
                    L_cTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    L_dcTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginStaus", x => x.L_ID);
                    table.ForeignKey(
                        name: "FK_LoginStaus_Accounts_A_ID",
                        column: x => x.A_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    O_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_ID = table.Column<int>(type: "int", nullable: false),
                    O_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    O_TotalPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    O_Cancle = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.O_ID);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_A_ID",
                        column: x => x.A_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    R_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_ID = table.Column<int>(type: "int", nullable: false),
                    ReportedA_ID = table.Column<int>(type: "int", nullable: false),
                    R_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    R_ReportType = table.Column<int>(type: "int", nullable: false),
                    R_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    R_ReportStatus = table.Column<int>(type: "int", nullable: false),
                    R_Reply = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.R_ID);
                    table.ForeignKey(
                        name: "FK_Reports_Accounts_A_ID",
                        column: x => x.A_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_Accounts_ReportedA_ID",
                        column: x => x.ReportedA_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Societies",
                columns: table => new
                {
                    S_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_ID = table.Column<int>(type: "int", nullable: false),
                    TargetA_ID = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societies", x => x.S_ID);
                    table.ForeignKey(
                        name: "FK_Societies_Accounts_A_ID",
                        column: x => x.A_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Societies_Accounts_TargetA_ID",
                        column: x => x.TargetA_ID,
                        principalTable: "Accounts",
                        principalColumn: "A_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Od_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    O_ID = table.Column<int>(type: "int", nullable: false),
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    Od_UnitPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Od_Sum = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Od_Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Od_ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_O_ID",
                        column: x => x.O_ID,
                        principalTable: "Orders",
                        principalColumn: "O_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Products",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Ads_OrderStatuses",
                columns: new[] { "OS_ID", "OS_FullfillmentRate", "OS_Name", "OS_PaymentMultiplier" },
                values: new object[] { 1, 1m, "完全履約", 1m });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "CT_ID", "CT_Name" },
                values: new object[,]
                {
                    { 1, "綠界" },
                    { 2, "LinePay" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CA_ID", "CA_Date", "CA_Describe", "CA_Discontinuted", "CA_Image", "CA_Name", "CA_Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9813), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9814), "200元換350點", false, "點數.png", "200元換350點", 200 }
                });

            migrationBuilder.InsertData(
                table: "CaseTables",
                columns: new[] { "Case_ID", "Case_Desc", "Case_Name", "Case_PricePerDay" },
                values: new object[,]
                {
                    { 1, null, "豪華蛋黃熱區", 250m },
                    { 2, null, "中等曝光區", 200m },
                    { 3, null, "經濟實惠區", 150m },
                    { 4, null, "限時特惠專區", 100m }
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9825), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9826), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9698), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9695), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9710), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9709), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9716), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9716), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9721), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9721), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9726), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9726), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9733), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9732), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9737), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9737), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9742), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9742), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9747), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9747), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9774), "Test", 99, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9773), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 67, 15, "", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 2, 15000, 1, 154, 18, "", new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 3, 15000, 1, 198, 19, "", new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 13 },
                    { 4, 15000, 1, 108, 8, "", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 5, 15000, 1, 74, 21, "", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 6, 15000, 1, 106, 13, "", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 7, 15000, 1, 72, 21, "", new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 8, 15000, 1, 128, 7, "", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 9, 15000, 1, 177, 19, "", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 10, 15000, 1, 114, 16, "", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 11, 15000, 1, 76, 14, "", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 12, 15000, 1, 127, 20, "", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 13, 15000, 1, 140, 19, "", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 17 },
                    { 14, 15000, 1, 117, 13, "", new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 15, 15000, 1, 51, 23, "", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 16, 15000, 1, 209, 15, "", new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 17, 15000, 1, 89, 24, "", new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 18, 15000, 1, 189, 10, "", new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 19, 15000, 1, 102, 11, "", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 20, 15000, 1, 78, 21, "", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 },
                    { 21, 15000, 1, 124, 23, "", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 22, 15000, 1, 126, 23, "", new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 23, 15000, 1, 156, 16, "", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 24, 15000, 1, 212, 22, "", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 },
                    { 25, 15000, 1, 170, 13, "", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 26, 15000, 1, 227, 12, "", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 27, 15000, 1, 210, 14, "", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 28, 15000, 1, 111, 22, "", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 29, 15000, 1, 39, 7, "", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9794), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9796), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 1, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9375) },
                    { 2, 8, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9422) },
                    { 3, 3, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9424) },
                    { 4, 9, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9425) },
                    { 5, 5, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9426) },
                    { 6, 1, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9429) },
                    { 7, 9, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9430) },
                    { 8, 6, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9432) },
                    { 9, 4, null, "test", true, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9432) },
                    { 10, 4, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9435) },
                    { 11, 3, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9436) },
                    { 12, 9, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9437) },
                    { 13, 5, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9438) },
                    { 14, 10, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9439) },
                    { 15, 7, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9440) },
                    { 16, 5, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9441) },
                    { 17, 7, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9443) },
                    { 18, 6, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9444) },
                    { 19, 2, null, "test", false, new DateTime(2023, 5, 10, 10, 31, 45, 394, DateTimeKind.Local).AddTicks(9445) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 3, 29, 21, 58, 18, 144, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 2, 58, 18, 144, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(2023, 3, 3, 16, 19, 53, 821, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 0, 19, 53, 821, DateTimeKind.Unspecified) },
                    { 3, 8, new DateTime(2023, 4, 16, 11, 0, 54, 92, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 16, 0, 54, 92, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2023, 4, 2, 15, 58, 56, 476, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 18, 58, 56, 476, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2023, 5, 28, 23, 57, 54, 17, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 5, 57, 54, 17, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2023, 3, 13, 19, 38, 15, 789, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 22, 38, 15, 789, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 5, 11, 0, 47, 9, 862, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 9, 47, 9, 862, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 2, 10, 3, 12, 10, 608, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 9, 12, 10, 608, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(2023, 4, 21, 14, 27, 47, 309, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 20, 27, 47, 309, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2023, 3, 30, 19, 51, 20, 662, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 22, 51, 20, 662, DateTimeKind.Unspecified) },
                    { 11, 6, new DateTime(2023, 2, 4, 17, 5, 56, 62, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 18, 5, 56, 62, DateTimeKind.Unspecified) },
                    { 12, 9, new DateTime(2023, 4, 2, 5, 12, 1, 730, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 15, 12, 1, 730, DateTimeKind.Unspecified) },
                    { 13, 8, new DateTime(2023, 4, 13, 13, 41, 32, 590, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 21, 41, 32, 590, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 4, 10, 23, 28, 1, 907, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 4, 28, 1, 907, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 2, 16, 17, 33, 50, 762, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 23, 33, 50, 762, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 5, 3, 22, 3, 53, 359, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 3, 3, 53, 359, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2023, 3, 16, 13, 9, 16, 211, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 14, 9, 16, 211, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2023, 3, 7, 0, 19, 32, 573, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 9, 19, 32, 573, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2023, 5, 5, 13, 46, 39, 969, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 14, 46, 39, 969, DateTimeKind.Unspecified) },
                    { 20, 1, new DateTime(2023, 5, 17, 10, 37, 25, 541, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 13, 37, 25, 541, DateTimeKind.Unspecified) },
                    { 21, 1, new DateTime(2023, 5, 29, 6, 31, 22, 820, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 14, 31, 22, 820, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 9, new DateTime(2023, 3, 15, 13, 22, 44, 993, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 15, 22, 44, 993, DateTimeKind.Unspecified) },
                    { 23, 6, new DateTime(2023, 3, 20, 20, 36, 4, 236, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 23, 36, 4, 236, DateTimeKind.Unspecified) },
                    { 24, 6, new DateTime(2023, 3, 20, 18, 29, 16, 287, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 23, 29, 16, 287, DateTimeKind.Unspecified) },
                    { 25, 6, new DateTime(2023, 2, 11, 18, 45, 43, 885, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 1, 45, 43, 885, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2023, 2, 16, 18, 26, 41, 255, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 2, 26, 41, 255, DateTimeKind.Unspecified) },
                    { 27, 3, new DateTime(2023, 2, 7, 20, 2, 56, 135, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 4, 2, 56, 135, DateTimeKind.Unspecified) },
                    { 28, 1, new DateTime(2023, 4, 30, 4, 15, 45, 261, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 12, 15, 45, 261, DateTimeKind.Unspecified) },
                    { 29, 7, new DateTime(2023, 4, 16, 21, 56, 59, 447, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 2, 56, 59, 447, DateTimeKind.Unspecified) },
                    { 30, 6, new DateTime(2023, 4, 26, 22, 31, 17, 475, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 3, 31, 17, 475, DateTimeKind.Unspecified) },
                    { 31, 7, new DateTime(2023, 2, 3, 9, 37, 25, 948, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 10, 37, 25, 948, DateTimeKind.Unspecified) },
                    { 32, 4, new DateTime(2023, 3, 26, 19, 31, 25, 902, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 2, 31, 25, 902, DateTimeKind.Unspecified) },
                    { 33, 5, new DateTime(2023, 4, 6, 5, 23, 22, 452, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 12, 23, 22, 452, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2023, 2, 2, 16, 43, 36, 251, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 1, 43, 36, 251, DateTimeKind.Unspecified) },
                    { 35, 8, new DateTime(2023, 3, 30, 2, 56, 11, 972, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 6, 56, 11, 972, DateTimeKind.Unspecified) },
                    { 36, 2, new DateTime(2023, 5, 6, 9, 2, 5, 689, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 19, 2, 5, 689, DateTimeKind.Unspecified) },
                    { 37, 1, new DateTime(2023, 2, 21, 17, 57, 9, 792, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 23, 57, 9, 792, DateTimeKind.Unspecified) },
                    { 38, 2, new DateTime(2023, 5, 20, 5, 34, 31, 564, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 6, 34, 31, 564, DateTimeKind.Unspecified) },
                    { 39, 8, new DateTime(2023, 2, 23, 23, 15, 35, 71, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 6, 15, 35, 71, DateTimeKind.Unspecified) },
                    { 40, 9, new DateTime(2023, 4, 4, 23, 59, 31, 702, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 9, 59, 31, 702, DateTimeKind.Unspecified) },
                    { 41, 1, new DateTime(2023, 5, 14, 19, 18, 56, 597, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 4, 18, 56, 597, DateTimeKind.Unspecified) },
                    { 42, 1, new DateTime(2023, 3, 9, 15, 50, 50, 47, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 16, 50, 50, 47, DateTimeKind.Unspecified) },
                    { 43, 4, new DateTime(2023, 3, 25, 3, 38, 10, 537, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 8, 38, 10, 537, DateTimeKind.Unspecified) },
                    { 44, 5, new DateTime(2023, 5, 31, 2, 31, 38, 559, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 5, 31, 38, 559, DateTimeKind.Unspecified) },
                    { 45, 4, new DateTime(2023, 5, 28, 20, 23, 14, 757, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 0, 23, 14, 757, DateTimeKind.Unspecified) },
                    { 46, 6, new DateTime(2023, 5, 22, 6, 55, 56, 511, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 12, 55, 56, 511, DateTimeKind.Unspecified) },
                    { 47, 2, new DateTime(2023, 5, 11, 6, 15, 57, 466, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 7, 15, 57, 466, DateTimeKind.Unspecified) },
                    { 48, 5, new DateTime(2023, 4, 28, 15, 5, 23, 645, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 17, 5, 23, 645, DateTimeKind.Unspecified) },
                    { 49, 2, new DateTime(2023, 2, 27, 12, 23, 14, 817, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 18, 23, 14, 817, DateTimeKind.Unspecified) },
                    { 50, 4, new DateTime(2023, 2, 2, 0, 36, 55, 69, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 5, 36, 55, 69, DateTimeKind.Unspecified) },
                    { 51, 9, new DateTime(2023, 3, 19, 22, 23, 14, 238, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 7, 23, 14, 238, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2023, 4, 22, 7, 38, 28, 763, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 11, 38, 28, 763, DateTimeKind.Unspecified) },
                    { 53, 7, new DateTime(2023, 4, 18, 2, 27, 3, 430, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 12, 27, 3, 430, DateTimeKind.Unspecified) },
                    { 54, 8, new DateTime(2023, 5, 30, 23, 33, 42, 917, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 1, 33, 42, 917, DateTimeKind.Unspecified) },
                    { 55, 4, new DateTime(2023, 2, 24, 17, 17, 29, 381, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 22, 17, 29, 381, DateTimeKind.Unspecified) },
                    { 56, 5, new DateTime(2023, 3, 17, 14, 15, 13, 580, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 22, 15, 13, 580, DateTimeKind.Unspecified) },
                    { 57, 3, new DateTime(2023, 4, 27, 12, 29, 42, 289, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 29, 42, 289, DateTimeKind.Unspecified) },
                    { 58, 2, new DateTime(2023, 3, 5, 23, 22, 50, 348, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 1, 22, 50, 348, DateTimeKind.Unspecified) },
                    { 59, 6, new DateTime(2023, 5, 12, 1, 44, 4, 578, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 4, 44, 4, 578, DateTimeKind.Unspecified) },
                    { 60, 1, new DateTime(2023, 3, 18, 17, 24, 6, 988, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 18, 24, 6, 988, DateTimeKind.Unspecified) },
                    { 61, 5, new DateTime(2023, 2, 21, 3, 25, 59, 428, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 13, 25, 59, 428, DateTimeKind.Unspecified) },
                    { 62, 1, new DateTime(2023, 5, 4, 16, 14, 5, 58, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 22, 14, 5, 58, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 5, 31, 19, 56, 52, 505, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 5, 56, 52, 505, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 1, new DateTime(2023, 2, 1, 0, 0, 22, 768, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 2, 0, 22, 768, DateTimeKind.Unspecified) },
                    { 65, 3, new DateTime(2023, 3, 15, 8, 38, 15, 123, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 16, 38, 15, 123, DateTimeKind.Unspecified) },
                    { 66, 6, new DateTime(2023, 4, 4, 11, 40, 19, 560, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 13, 40, 19, 560, DateTimeKind.Unspecified) },
                    { 67, 9, new DateTime(2023, 3, 4, 20, 38, 32, 57, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 0, 38, 32, 57, DateTimeKind.Unspecified) },
                    { 68, 6, new DateTime(2023, 3, 26, 17, 56, 9, 992, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 1, 56, 9, 992, DateTimeKind.Unspecified) },
                    { 69, 4, new DateTime(2023, 2, 6, 17, 40, 42, 89, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 19, 40, 42, 89, DateTimeKind.Unspecified) },
                    { 70, 7, new DateTime(2023, 2, 15, 16, 28, 23, 200, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 23, 28, 23, 200, DateTimeKind.Unspecified) },
                    { 71, 2, new DateTime(2023, 4, 21, 22, 17, 43, 956, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 8, 17, 43, 956, DateTimeKind.Unspecified) },
                    { 72, 5, new DateTime(2023, 3, 24, 23, 28, 2, 566, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 5, 28, 2, 566, DateTimeKind.Unspecified) },
                    { 73, 3, new DateTime(2023, 3, 25, 9, 45, 13, 374, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 18, 45, 13, 374, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2023, 2, 24, 10, 32, 15, 513, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 11, 32, 15, 513, DateTimeKind.Unspecified) },
                    { 75, 2, new DateTime(2023, 2, 21, 11, 46, 28, 780, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 12, 46, 28, 780, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 5, 18, 11, 8, 59, 793, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 15, 8, 59, 793, DateTimeKind.Unspecified) },
                    { 77, 2, new DateTime(2023, 4, 26, 11, 33, 4, 822, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 21, 33, 4, 822, DateTimeKind.Unspecified) },
                    { 78, 5, new DateTime(2023, 4, 25, 12, 26, 28, 21, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 16, 26, 28, 21, DateTimeKind.Unspecified) },
                    { 79, 9, new DateTime(2023, 3, 18, 7, 37, 38, 166, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 11, 37, 38, 166, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2023, 3, 3, 20, 37, 18, 916, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 1, 37, 18, 916, DateTimeKind.Unspecified) },
                    { 81, 7, new DateTime(2023, 4, 18, 15, 39, 36, 487, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 21, 39, 36, 487, DateTimeKind.Unspecified) },
                    { 82, 9, new DateTime(2023, 5, 14, 1, 26, 38, 626, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 9, 26, 38, 626, DateTimeKind.Unspecified) },
                    { 83, 5, new DateTime(2023, 4, 29, 4, 17, 35, 713, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 13, 17, 35, 713, DateTimeKind.Unspecified) },
                    { 84, 8, new DateTime(2023, 2, 27, 11, 35, 47, 37, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 20, 35, 47, 37, DateTimeKind.Unspecified) },
                    { 85, 9, new DateTime(2023, 2, 24, 23, 48, 56, 91, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 0, 48, 56, 91, DateTimeKind.Unspecified) },
                    { 86, 2, new DateTime(2023, 3, 28, 10, 13, 42, 584, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 11, 13, 42, 584, DateTimeKind.Unspecified) },
                    { 87, 6, new DateTime(2023, 2, 9, 23, 56, 10, 791, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 4, 56, 10, 791, DateTimeKind.Unspecified) },
                    { 88, 8, new DateTime(2023, 5, 10, 15, 2, 36, 734, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 22, 2, 36, 734, DateTimeKind.Unspecified) },
                    { 89, 8, new DateTime(2023, 5, 24, 0, 5, 22, 513, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 3, 5, 22, 513, DateTimeKind.Unspecified) },
                    { 90, 5, new DateTime(2023, 3, 1, 5, 54, 26, 698, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 14, 54, 26, 698, DateTimeKind.Unspecified) },
                    { 91, 5, new DateTime(2023, 5, 10, 15, 10, 14, 511, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 17, 10, 14, 511, DateTimeKind.Unspecified) },
                    { 92, 7, new DateTime(2023, 3, 7, 6, 42, 22, 28, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 10, 42, 22, 28, DateTimeKind.Unspecified) },
                    { 93, 8, new DateTime(2023, 3, 29, 22, 28, 9, 958, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 0, 28, 9, 958, DateTimeKind.Unspecified) },
                    { 94, 2, new DateTime(2023, 3, 27, 20, 55, 29, 788, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 21, 55, 29, 788, DateTimeKind.Unspecified) },
                    { 95, 7, new DateTime(2023, 2, 18, 12, 29, 37, 229, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 17, 29, 37, 229, DateTimeKind.Unspecified) },
                    { 96, 4, new DateTime(2023, 4, 23, 15, 11, 12, 68, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 16, 11, 12, 68, DateTimeKind.Unspecified) },
                    { 97, 1, new DateTime(2023, 4, 11, 3, 42, 18, 118, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 4, 42, 18, 118, DateTimeKind.Unspecified) },
                    { 98, 6, new DateTime(2023, 5, 12, 17, 30, 33, 340, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 22, 30, 33, 340, DateTimeKind.Unspecified) },
                    { 99, 9, new DateTime(2023, 5, 31, 6, 41, 44, 679, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 9, 41, 44, 679, DateTimeKind.Unspecified) },
                    { 100, 8, new DateTime(2023, 5, 7, 15, 47, 35, 412, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 20, 47, 35, 412, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 2, 15, 7, 23, 23, 551, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 15, 23, 23, 551, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9835), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 10, 10, 31, 45, 395, DateTimeKind.Local).AddTicks(9836), 1198m },
                    { 3, 3, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(577), 699m },
                    { 4, 4, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(596), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 7, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(605), 699m },
                    { 6, 3, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(613), 699m },
                    { 7, 2, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(622), 699m },
                    { 8, 5, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(674), 699m },
                    { 9, 9, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(683), 699m },
                    { 10, 9, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(692), 699m },
                    { 11, 7, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(701), 699m },
                    { 12, 6, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(715), 699m },
                    { 13, 7, false, new DateTime(2023, 5, 10, 10, 31, 45, 396, DateTimeKind.Local).AddTicks(723), 699m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Od_ID", "O_ID", "Od_Quantity", "Od_Sum", "Od_UnitPrice", "P_ID" },
                values: new object[,]
                {
                    { 1, 1, 2, 1398m, 699m, 1 },
                    { 2, 1, 2, 998m, 499m, 2 },
                    { 3, 2, 1, 699m, 699m, 1 },
                    { 4, 2, 1, 499m, 499m, 2 },
                    { 5, 3, 1, 699m, 699m, 1 },
                    { 6, 4, 1, 699m, 699m, 1 },
                    { 7, 5, 1, 699m, 699m, 1 },
                    { 8, 6, 1, 699m, 699m, 1 },
                    { 9, 7, 1, 699m, 699m, 1 },
                    { 10, 8, 1, 699m, 699m, 1 },
                    { 11, 9, 1, 699m, 699m, 1 },
                    { 12, 10, 1, 699m, 699m, 1 },
                    { 13, 11, 1, 699m, 699m, 1 },
                    { 14, 12, 1, 699m, 699m, 1 },
                    { 15, 13, 1, 699m, 699m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_P_id",
                table: "Accounts",
                column: "P_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_CaseID",
                table: "Ads",
                column: "CaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_OS_ID",
                table: "Ads",
                column: "OS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_PartnerID",
                table: "Ads",
                column: "PartnerID");

            migrationBuilder.CreateIndex(
                name: "IX_BlockSpaces_M_ID",
                table: "BlockSpaces",
                column: "M_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CardOrders_A_ID",
                table: "CardOrders",
                column: "A_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CardOrders_CA_ID",
                table: "CardOrders",
                column: "CA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CardOrders_CT_ID",
                table: "CardOrders",
                column: "CT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DebugLogs_A_ID",
                table: "DebugLogs",
                column: "A_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LoginStaus_A_ID",
                table: "LoginStaus",
                column: "A_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Map_ADAreas_CaseID",
                table: "Map_ADAreas",
                column: "CaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Map_ADAreas_M_ID",
                table: "Map_ADAreas",
                column: "M_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_O_ID",
                table: "OrderDetails",
                column: "O_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_P_ID",
                table: "OrderDetails",
                column: "P_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_A_ID",
                table: "Orders",
                column: "A_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_A_ID",
                table: "Reports",
                column: "A_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportedA_ID",
                table: "Reports",
                column: "ReportedA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Societies_A_ID",
                table: "Societies",
                column: "A_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Societies_TargetA_ID",
                table: "Societies",
                column: "TargetA_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ads");

            migrationBuilder.DropTable(
                name: "BlockSpaces");

            migrationBuilder.DropTable(
                name: "CardOrders");

            migrationBuilder.DropTable(
                name: "DebugLogs");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "LoginStaus");

            migrationBuilder.DropTable(
                name: "Map_ADAreas");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Societies");

            migrationBuilder.DropTable(
                name: "Ads_OrderStatuses");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "CardTypes");

            migrationBuilder.DropTable(
                name: "CaseTables");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
