using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class sandy : Migration
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
                    { 1, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7134), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7136), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7145), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7147), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7017), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7013), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7029), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7028), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7035), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7035), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7040), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7040), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7045), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7045), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7074), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7073), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7080), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7079), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7092), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7091), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7096), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7095), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7101), "Test", 99, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7101), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 102, 19, "", new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 2, 15000, 1, 71, 13, "", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 3, 15000, 1, 84, 22, "", new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 6 },
                    { 4, 15000, 1, 61, 12, "", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 13 },
                    { 5, 15000, 1, 67, 24, "", new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 4 },
                    { 6, 15000, 1, 216, 16, "", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 7, 15000, 1, 130, 17, "", new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 8, 15000, 1, 184, 20, "", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 9, 15000, 1, 140, 24, "", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 10, 15000, 1, 144, 11, "", new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 11, 15000, 1, 193, 15, "", new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 12, 15000, 1, 41, 24, "", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 13, 15000, 1, 98, 12, "", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 14, 15000, 1, 83, 7, "", new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 15, 15000, 1, 117, 7, "", new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 4 },
                    { 16, 15000, 1, 52, 23, "", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 12 },
                    { 17, 15000, 1, 54, 19, "", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 4 },
                    { 18, 15000, 1, 148, 14, "", new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 19, 15000, 1, 109, 10, "", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 15 },
                    { 20, 15000, 1, 99, 16, "", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 21, 15000, 1, 180, 12, "", new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 22, 15000, 1, 41, 10, "", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 23, 15000, 1, 147, 9, "", new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 24, 15000, 1, 47, 17, "", new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 25, 15000, 1, 236, 20, "", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 26, 15000, 1, 90, 13, "", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 27, 15000, 1, 142, 23, "", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 28, 15000, 1, 131, 14, "", new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 29, 15000, 1, 121, 24, "", new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7120), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7121), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 2, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6319) },
                    { 2, 5, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6368) },
                    { 3, 5, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6370) },
                    { 4, 9, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6371) },
                    { 5, 7, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6373) },
                    { 6, 10, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6375) },
                    { 7, 2, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6376) },
                    { 8, 8, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6378) },
                    { 9, 8, null, "test", true, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6379) },
                    { 10, 2, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6381) },
                    { 11, 9, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6382) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6384) },
                    { 13, 9, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6385) },
                    { 14, 7, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6386) },
                    { 15, 2, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6387) },
                    { 16, 10, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6388) },
                    { 17, 9, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6389) },
                    { 18, 3, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6391) },
                    { 19, 4, null, "test", false, new DateTime(2023, 5, 10, 14, 31, 8, 997, DateTimeKind.Local).AddTicks(6392) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 9, new DateTime(2023, 4, 17, 12, 52, 51, 337, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 21, 52, 51, 337, DateTimeKind.Unspecified) },
                    { 2, 6, new DateTime(2023, 4, 21, 6, 24, 2, 635, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 11, 24, 2, 635, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 2, 5, 13, 24, 14, 569, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 14, 24, 14, 569, DateTimeKind.Unspecified) },
                    { 4, 5, new DateTime(2023, 5, 11, 21, 22, 26, 488, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 6, 22, 26, 488, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2023, 4, 21, 0, 40, 55, 567, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 10, 40, 55, 567, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2023, 2, 6, 8, 12, 10, 873, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 12, 12, 10, 873, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 5, 8, 7, 58, 41, 848, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 8, 58, 41, 848, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(2023, 2, 11, 5, 47, 56, 234, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 6, 47, 56, 234, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2023, 2, 13, 5, 59, 15, 281, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 15, 59, 15, 281, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 2, 21, 4, 2, 9, 51, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 11, 2, 9, 51, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2023, 5, 19, 0, 9, 55, 897, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 10, 9, 55, 897, DateTimeKind.Unspecified) },
                    { 12, 2, new DateTime(2023, 3, 15, 5, 6, 42, 170, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 7, 6, 42, 170, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2023, 2, 24, 23, 0, 3, 741, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 5, 0, 3, 741, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 3, 4, 5, 11, 43, 308, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 12, 11, 43, 308, DateTimeKind.Unspecified) },
                    { 15, 7, new DateTime(2023, 4, 27, 12, 20, 57, 270, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 17, 20, 57, 270, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 4, 4, 0, 0, 53, 985, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 10, 0, 53, 985, DateTimeKind.Unspecified) },
                    { 17, 6, new DateTime(2023, 4, 25, 12, 15, 8, 417, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 19, 15, 8, 417, DateTimeKind.Unspecified) },
                    { 18, 7, new DateTime(2023, 3, 8, 17, 56, 27, 29, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 22, 56, 27, 29, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 3, 26, 20, 41, 20, 585, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 1, 41, 20, 585, DateTimeKind.Unspecified) },
                    { 20, 5, new DateTime(2023, 3, 11, 5, 13, 5, 818, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 6, 13, 5, 818, DateTimeKind.Unspecified) },
                    { 21, 4, new DateTime(2023, 5, 15, 18, 5, 44, 271, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 21, 5, 44, 271, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 7, new DateTime(2023, 5, 20, 16, 0, 14, 450, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 23, 0, 14, 450, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2023, 5, 29, 11, 56, 0, 692, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 56, 0, 692, DateTimeKind.Unspecified) },
                    { 24, 2, new DateTime(2023, 4, 6, 3, 54, 25, 398, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 12, 54, 25, 398, DateTimeKind.Unspecified) },
                    { 25, 4, new DateTime(2023, 4, 11, 2, 36, 18, 43, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 7, 36, 18, 43, DateTimeKind.Unspecified) },
                    { 26, 7, new DateTime(2023, 4, 8, 2, 46, 30, 419, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 8, 46, 30, 419, DateTimeKind.Unspecified) },
                    { 27, 9, new DateTime(2023, 3, 30, 10, 4, 3, 391, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 18, 4, 3, 391, DateTimeKind.Unspecified) },
                    { 28, 5, new DateTime(2023, 2, 24, 5, 16, 50, 367, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 8, 16, 50, 367, DateTimeKind.Unspecified) },
                    { 29, 9, new DateTime(2023, 5, 11, 14, 26, 35, 513, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 18, 26, 35, 513, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2023, 2, 26, 15, 43, 10, 851, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 23, 43, 10, 851, DateTimeKind.Unspecified) },
                    { 31, 9, new DateTime(2023, 4, 13, 6, 41, 39, 601, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 9, 41, 39, 601, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2023, 4, 14, 9, 44, 17, 291, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 17, 44, 17, 291, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2023, 4, 29, 8, 56, 10, 732, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 16, 56, 10, 732, DateTimeKind.Unspecified) },
                    { 34, 4, new DateTime(2023, 3, 12, 16, 21, 1, 53, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 2, 21, 1, 53, DateTimeKind.Unspecified) },
                    { 35, 8, new DateTime(2023, 2, 8, 15, 59, 30, 357, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 19, 59, 30, 357, DateTimeKind.Unspecified) },
                    { 36, 6, new DateTime(2023, 4, 15, 14, 22, 38, 404, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 21, 22, 38, 404, DateTimeKind.Unspecified) },
                    { 37, 8, new DateTime(2023, 4, 18, 6, 32, 24, 939, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 11, 32, 24, 939, DateTimeKind.Unspecified) },
                    { 38, 5, new DateTime(2023, 5, 7, 9, 21, 18, 345, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 10, 21, 18, 345, DateTimeKind.Unspecified) },
                    { 39, 8, new DateTime(2023, 4, 17, 10, 59, 4, 868, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 17, 59, 4, 868, DateTimeKind.Unspecified) },
                    { 40, 2, new DateTime(2023, 2, 3, 17, 16, 45, 324, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 2, 16, 45, 324, DateTimeKind.Unspecified) },
                    { 41, 5, new DateTime(2023, 4, 16, 21, 43, 12, 55, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 6, 43, 12, 55, DateTimeKind.Unspecified) },
                    { 42, 9, new DateTime(2023, 3, 10, 3, 15, 51, 601, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 4, 15, 51, 601, DateTimeKind.Unspecified) },
                    { 43, 7, new DateTime(2023, 3, 19, 12, 23, 42, 784, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 18, 23, 42, 784, DateTimeKind.Unspecified) },
                    { 44, 9, new DateTime(2023, 2, 20, 11, 5, 8, 455, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 21, 5, 8, 455, DateTimeKind.Unspecified) },
                    { 45, 8, new DateTime(2023, 4, 26, 8, 22, 29, 197, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 12, 22, 29, 197, DateTimeKind.Unspecified) },
                    { 46, 2, new DateTime(2023, 2, 27, 5, 8, 20, 750, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 14, 8, 20, 750, DateTimeKind.Unspecified) },
                    { 47, 7, new DateTime(2023, 5, 5, 19, 5, 1, 611, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 23, 5, 1, 611, DateTimeKind.Unspecified) },
                    { 48, 1, new DateTime(2023, 4, 12, 4, 42, 16, 878, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 8, 42, 16, 878, DateTimeKind.Unspecified) },
                    { 49, 5, new DateTime(2023, 5, 1, 2, 18, 36, 348, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 9, 18, 36, 348, DateTimeKind.Unspecified) },
                    { 50, 2, new DateTime(2023, 2, 1, 8, 42, 54, 334, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 10, 42, 54, 334, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2023, 4, 16, 19, 44, 41, 144, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 21, 44, 41, 144, DateTimeKind.Unspecified) },
                    { 52, 6, new DateTime(2023, 2, 11, 15, 21, 3, 20, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 20, 21, 3, 20, DateTimeKind.Unspecified) },
                    { 53, 9, new DateTime(2023, 2, 16, 12, 27, 36, 423, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 18, 27, 36, 423, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 5, 29, 11, 50, 30, 143, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 50, 30, 143, DateTimeKind.Unspecified) },
                    { 55, 4, new DateTime(2023, 3, 2, 8, 57, 17, 446, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 12, 57, 17, 446, DateTimeKind.Unspecified) },
                    { 56, 5, new DateTime(2023, 5, 25, 22, 20, 6, 497, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 23, 20, 6, 497, DateTimeKind.Unspecified) },
                    { 57, 8, new DateTime(2023, 3, 9, 21, 24, 47, 144, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 0, 24, 47, 144, DateTimeKind.Unspecified) },
                    { 58, 2, new DateTime(2023, 3, 10, 20, 30, 18, 703, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 23, 30, 18, 703, DateTimeKind.Unspecified) },
                    { 59, 2, new DateTime(2023, 3, 7, 6, 5, 4, 256, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 16, 5, 4, 256, DateTimeKind.Unspecified) },
                    { 60, 5, new DateTime(2023, 3, 15, 19, 59, 17, 464, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 3, 59, 17, 464, DateTimeKind.Unspecified) },
                    { 61, 2, new DateTime(2023, 5, 29, 5, 11, 9, 57, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 11, 9, 57, DateTimeKind.Unspecified) },
                    { 62, 2, new DateTime(2023, 3, 15, 11, 14, 8, 824, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 13, 14, 8, 824, DateTimeKind.Unspecified) },
                    { 63, 4, new DateTime(2023, 3, 7, 4, 38, 13, 821, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 8, 38, 13, 821, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 6, new DateTime(2023, 3, 15, 0, 23, 58, 586, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 3, 23, 58, 586, DateTimeKind.Unspecified) },
                    { 65, 2, new DateTime(2023, 2, 7, 0, 11, 53, 143, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 9, 11, 53, 143, DateTimeKind.Unspecified) },
                    { 66, 6, new DateTime(2023, 3, 6, 7, 58, 52, 171, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 10, 58, 52, 171, DateTimeKind.Unspecified) },
                    { 67, 3, new DateTime(2023, 5, 10, 16, 25, 48, 784, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 0, 25, 48, 784, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2023, 2, 28, 12, 53, 37, 877, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 13, 53, 37, 877, DateTimeKind.Unspecified) },
                    { 69, 3, new DateTime(2023, 5, 5, 7, 3, 26, 411, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 9, 3, 26, 411, DateTimeKind.Unspecified) },
                    { 70, 1, new DateTime(2023, 3, 15, 14, 50, 46, 765, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 22, 50, 46, 765, DateTimeKind.Unspecified) },
                    { 71, 7, new DateTime(2023, 4, 21, 10, 15, 54, 114, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 12, 15, 54, 114, DateTimeKind.Unspecified) },
                    { 72, 3, new DateTime(2023, 5, 13, 13, 25, 31, 860, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 22, 25, 31, 860, DateTimeKind.Unspecified) },
                    { 73, 6, new DateTime(2023, 2, 24, 20, 16, 5, 703, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 5, 16, 5, 703, DateTimeKind.Unspecified) },
                    { 74, 9, new DateTime(2023, 5, 7, 4, 44, 48, 908, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 12, 44, 48, 908, DateTimeKind.Unspecified) },
                    { 75, 6, new DateTime(2023, 3, 18, 5, 12, 21, 310, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 9, 12, 21, 310, DateTimeKind.Unspecified) },
                    { 76, 7, new DateTime(2023, 4, 2, 22, 44, 31, 958, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 7, 44, 31, 958, DateTimeKind.Unspecified) },
                    { 77, 8, new DateTime(2023, 2, 12, 14, 44, 40, 89, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 23, 44, 40, 89, DateTimeKind.Unspecified) },
                    { 78, 5, new DateTime(2023, 4, 8, 14, 38, 31, 762, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 23, 38, 31, 762, DateTimeKind.Unspecified) },
                    { 79, 9, new DateTime(2023, 5, 30, 11, 32, 41, 746, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 32, 41, 746, DateTimeKind.Unspecified) },
                    { 80, 1, new DateTime(2023, 3, 4, 16, 14, 1, 919, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 0, 14, 1, 919, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 4, 21, 21, 8, 25, 539, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 7, 8, 25, 539, DateTimeKind.Unspecified) },
                    { 82, 7, new DateTime(2023, 2, 1, 12, 9, 11, 656, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 21, 9, 11, 656, DateTimeKind.Unspecified) },
                    { 83, 3, new DateTime(2023, 3, 18, 17, 51, 44, 752, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 22, 51, 44, 752, DateTimeKind.Unspecified) },
                    { 84, 4, new DateTime(2023, 2, 11, 5, 39, 36, 743, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 14, 39, 36, 743, DateTimeKind.Unspecified) },
                    { 85, 6, new DateTime(2023, 3, 21, 13, 56, 8, 750, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 22, 56, 8, 750, DateTimeKind.Unspecified) },
                    { 86, 9, new DateTime(2023, 3, 8, 22, 2, 33, 144, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 5, 2, 33, 144, DateTimeKind.Unspecified) },
                    { 87, 8, new DateTime(2023, 4, 26, 22, 7, 50, 17, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 0, 7, 50, 17, DateTimeKind.Unspecified) },
                    { 88, 5, new DateTime(2023, 5, 15, 9, 45, 45, 361, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 13, 45, 45, 361, DateTimeKind.Unspecified) },
                    { 89, 8, new DateTime(2023, 3, 15, 10, 57, 12, 864, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 11, 57, 12, 864, DateTimeKind.Unspecified) },
                    { 90, 5, new DateTime(2023, 5, 6, 20, 3, 40, 965, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 4, 3, 40, 965, DateTimeKind.Unspecified) },
                    { 91, 2, new DateTime(2023, 2, 8, 19, 31, 6, 959, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 3, 31, 6, 959, DateTimeKind.Unspecified) },
                    { 92, 9, new DateTime(2023, 3, 16, 11, 34, 33, 248, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 18, 34, 33, 248, DateTimeKind.Unspecified) },
                    { 93, 8, new DateTime(2023, 5, 22, 15, 5, 16, 823, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 16, 5, 16, 823, DateTimeKind.Unspecified) },
                    { 94, 4, new DateTime(2023, 4, 25, 18, 26, 13, 6, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 21, 26, 13, 6, DateTimeKind.Unspecified) },
                    { 95, 5, new DateTime(2023, 3, 27, 8, 28, 45, 470, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 12, 28, 45, 470, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 4, 7, 15, 35, 8, 67, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 23, 35, 8, 67, DateTimeKind.Unspecified) },
                    { 97, 9, new DateTime(2023, 3, 5, 23, 0, 40, 40, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 4, 0, 40, 40, DateTimeKind.Unspecified) },
                    { 98, 2, new DateTime(2023, 4, 2, 6, 28, 10, 305, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 12, 28, 10, 305, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 5, 9, 22, 10, 38, 919, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 10, 38, 919, DateTimeKind.Unspecified) },
                    { 100, 9, new DateTime(2023, 3, 5, 16, 43, 39, 446, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 17, 43, 39, 446, DateTimeKind.Unspecified) },
                    { 101, 6, new DateTime(2023, 2, 11, 4, 18, 30, 293, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 13, 18, 30, 293, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7154), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7155), 1198m },
                    { 3, 2, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7892), 699m },
                    { 4, 4, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7912), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 2, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7943), 699m },
                    { 6, 4, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7953), 699m },
                    { 7, 7, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7962), 699m },
                    { 8, 2, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7979), 699m },
                    { 9, 1, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(7987), 699m },
                    { 10, 4, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(8003), 699m },
                    { 11, 4, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(8011), 699m },
                    { 12, 2, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(8026), 699m },
                    { 13, 4, false, new DateTime(2023, 5, 10, 14, 31, 8, 998, DateTimeKind.Local).AddTicks(8035), 699m }
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
