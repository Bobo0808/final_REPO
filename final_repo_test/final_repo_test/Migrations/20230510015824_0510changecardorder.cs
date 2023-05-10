using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class _0510changecardorder : Migration
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
                    { 1, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8585), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8586), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8595), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8596), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8481), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8477), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8494), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8494), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8499), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8499), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8505), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8504), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8510), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8510), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8516), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8516), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8521), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8520), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8545), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8545), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8550), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8549), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8555), "Test", 99, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8555), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 87, 11, "", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 2, 15000, 1, 200, 21, "", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 3, 15000, 1, 87, 7, "", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 4, 15000, 1, 176, 19, "", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 17 },
                    { 5, 15000, 1, 201, 11, "", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 5 },
                    { 6, 15000, 1, 67, 21, "", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 7, 15000, 1, 109, 9, "", new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 8, 15000, 1, 163, 10, "", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 9, 15000, 1, 96, 14, "", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 10, 15000, 1, 224, 8, "", new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 },
                    { 11, 15000, 1, 51, 10, "", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 12, 15000, 1, 123, 15, "", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 13, 15000, 1, 141, 15, "", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 14, 15000, 1, 233, 9, "", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 15, 15000, 1, 221, 18, "", new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 16, 15000, 1, 124, 17, "", new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 17, 15000, 1, 216, 24, "", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 18, 15000, 1, 200, 11, "", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 19, 15000, 1, 134, 24, "", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 20, 15000, 1, 116, 15, "", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 21, 15000, 1, 49, 7, "", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 22, 15000, 1, 87, 11, "", new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 23, 15000, 1, 119, 15, "", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 24, 15000, 1, 83, 8, "", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 25, 15000, 1, 154, 16, "", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 15 },
                    { 26, 15000, 1, 153, 20, "", new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 27, 15000, 1, 186, 9, "", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 28, 15000, 1, 143, 21, "", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 29, 15000, 1, 190, 9, "", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8571), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8573), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 2, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(7958) },
                    { 2, 3, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8001) },
                    { 3, 10, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8002) },
                    { 4, 6, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8004) },
                    { 5, 10, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8005) },
                    { 6, 6, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8008) },
                    { 7, 7, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8009) },
                    { 8, 8, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8010) },
                    { 9, 7, null, "test", true, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8011) },
                    { 10, 8, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8013) },
                    { 11, 7, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8015) },
                    { 12, 6, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8016) },
                    { 13, 3, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8017) },
                    { 14, 6, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8018) },
                    { 15, 6, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8019) },
                    { 16, 6, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8020) },
                    { 17, 10, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8021) },
                    { 18, 10, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8023) },
                    { 19, 3, null, "test", false, new DateTime(2023, 5, 10, 9, 58, 24, 674, DateTimeKind.Local).AddTicks(8024) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 9, new DateTime(2023, 3, 5, 23, 54, 15, 931, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 7, 54, 15, 931, DateTimeKind.Unspecified) },
                    { 2, 6, new DateTime(2023, 4, 17, 9, 11, 14, 912, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 14, 11, 14, 912, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(2023, 4, 15, 9, 32, 28, 238, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 10, 32, 28, 238, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2023, 4, 23, 8, 4, 26, 433, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 11, 4, 26, 433, DateTimeKind.Unspecified) },
                    { 5, 7, new DateTime(2023, 3, 30, 21, 11, 18, 494, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 22, 11, 18, 494, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2023, 5, 31, 5, 54, 29, 577, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 14, 54, 29, 577, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2023, 2, 24, 16, 44, 15, 227, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 20, 44, 15, 227, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(2023, 4, 16, 2, 58, 9, 16, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 5, 58, 9, 16, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2023, 3, 12, 4, 54, 50, 429, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 13, 54, 50, 429, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2023, 3, 21, 5, 45, 17, 567, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 14, 45, 17, 567, DateTimeKind.Unspecified) },
                    { 11, 5, new DateTime(2023, 5, 18, 17, 41, 52, 977, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 18, 41, 52, 977, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2023, 2, 24, 19, 13, 25, 213, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 23, 13, 25, 213, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2023, 2, 8, 23, 14, 42, 441, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 9, 14, 42, 441, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 5, 28, 5, 31, 46, 307, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 13, 31, 46, 307, DateTimeKind.Unspecified) },
                    { 15, 9, new DateTime(2023, 5, 23, 11, 12, 26, 810, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 21, 12, 26, 810, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 2, 5, 6, 1, 43, 923, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 8, 1, 43, 923, DateTimeKind.Unspecified) },
                    { 17, 3, new DateTime(2023, 3, 16, 20, 16, 30, 942, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 3, 16, 30, 942, DateTimeKind.Unspecified) },
                    { 18, 5, new DateTime(2023, 3, 18, 1, 31, 35, 689, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 4, 31, 35, 689, DateTimeKind.Unspecified) },
                    { 19, 5, new DateTime(2023, 2, 24, 19, 11, 20, 792, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 5, 11, 20, 792, DateTimeKind.Unspecified) },
                    { 20, 7, new DateTime(2023, 3, 24, 4, 18, 28, 590, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 7, 18, 28, 590, DateTimeKind.Unspecified) },
                    { 21, 6, new DateTime(2023, 5, 18, 4, 32, 53, 769, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 11, 32, 53, 769, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 3, new DateTime(2023, 5, 22, 13, 33, 32, 491, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 14, 33, 32, 491, DateTimeKind.Unspecified) },
                    { 23, 2, new DateTime(2023, 4, 6, 4, 3, 47, 540, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 14, 3, 47, 540, DateTimeKind.Unspecified) },
                    { 24, 5, new DateTime(2023, 5, 31, 2, 29, 46, 320, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 9, 29, 46, 320, DateTimeKind.Unspecified) },
                    { 25, 5, new DateTime(2023, 3, 15, 22, 3, 31, 738, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 4, 3, 31, 738, DateTimeKind.Unspecified) },
                    { 26, 3, new DateTime(2023, 2, 24, 5, 40, 2, 421, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 15, 40, 2, 421, DateTimeKind.Unspecified) },
                    { 27, 8, new DateTime(2023, 2, 23, 18, 40, 24, 987, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 1, 40, 24, 987, DateTimeKind.Unspecified) },
                    { 28, 8, new DateTime(2023, 2, 12, 21, 14, 5, 906, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 6, 14, 5, 906, DateTimeKind.Unspecified) },
                    { 29, 3, new DateTime(2023, 3, 22, 15, 25, 36, 213, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 1, 25, 36, 213, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2023, 4, 10, 23, 41, 14, 792, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 4, 41, 14, 792, DateTimeKind.Unspecified) },
                    { 31, 2, new DateTime(2023, 5, 25, 1, 57, 12, 855, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 4, 57, 12, 855, DateTimeKind.Unspecified) },
                    { 32, 8, new DateTime(2023, 3, 1, 18, 18, 51, 233, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 3, 18, 51, 233, DateTimeKind.Unspecified) },
                    { 33, 9, new DateTime(2023, 3, 20, 5, 32, 23, 498, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 7, 32, 23, 498, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2023, 4, 17, 3, 7, 59, 673, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 13, 7, 59, 673, DateTimeKind.Unspecified) },
                    { 35, 1, new DateTime(2023, 4, 14, 11, 48, 17, 388, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 21, 48, 17, 388, DateTimeKind.Unspecified) },
                    { 36, 5, new DateTime(2023, 3, 13, 10, 43, 51, 390, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 19, 43, 51, 390, DateTimeKind.Unspecified) },
                    { 37, 5, new DateTime(2023, 4, 12, 9, 33, 1, 72, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 14, 33, 1, 72, DateTimeKind.Unspecified) },
                    { 38, 2, new DateTime(2023, 2, 7, 0, 4, 13, 951, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 4, 4, 13, 951, DateTimeKind.Unspecified) },
                    { 39, 6, new DateTime(2023, 5, 19, 7, 49, 30, 458, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 14, 49, 30, 458, DateTimeKind.Unspecified) },
                    { 40, 8, new DateTime(2023, 5, 29, 16, 46, 38, 144, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 21, 46, 38, 144, DateTimeKind.Unspecified) },
                    { 41, 7, new DateTime(2023, 4, 29, 10, 24, 19, 803, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 11, 24, 19, 803, DateTimeKind.Unspecified) },
                    { 42, 9, new DateTime(2023, 5, 7, 4, 30, 30, 537, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 11, 30, 30, 537, DateTimeKind.Unspecified) },
                    { 43, 3, new DateTime(2023, 3, 25, 20, 56, 57, 387, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 2, 56, 57, 387, DateTimeKind.Unspecified) },
                    { 44, 4, new DateTime(2023, 5, 8, 14, 52, 12, 721, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 20, 52, 12, 721, DateTimeKind.Unspecified) },
                    { 45, 7, new DateTime(2023, 5, 14, 6, 30, 6, 490, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 14, 30, 6, 490, DateTimeKind.Unspecified) },
                    { 46, 9, new DateTime(2023, 4, 13, 9, 9, 47, 975, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 13, 9, 47, 975, DateTimeKind.Unspecified) },
                    { 47, 3, new DateTime(2023, 4, 21, 23, 1, 4, 741, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 7, 1, 4, 741, DateTimeKind.Unspecified) },
                    { 48, 2, new DateTime(2023, 2, 1, 0, 27, 5, 915, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 10, 27, 5, 915, DateTimeKind.Unspecified) },
                    { 49, 9, new DateTime(2023, 5, 31, 16, 21, 11, 251, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 21, 11, 251, DateTimeKind.Unspecified) },
                    { 50, 1, new DateTime(2023, 2, 24, 10, 36, 58, 829, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 18, 36, 58, 829, DateTimeKind.Unspecified) },
                    { 51, 7, new DateTime(2023, 3, 30, 8, 32, 17, 372, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 15, 32, 17, 372, DateTimeKind.Unspecified) },
                    { 52, 7, new DateTime(2023, 3, 4, 7, 29, 58, 792, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 17, 29, 58, 792, DateTimeKind.Unspecified) },
                    { 53, 6, new DateTime(2023, 2, 9, 11, 44, 3, 337, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 12, 44, 3, 337, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 3, 16, 0, 10, 26, 359, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 9, 10, 26, 359, DateTimeKind.Unspecified) },
                    { 55, 5, new DateTime(2023, 5, 14, 16, 17, 39, 560, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 22, 17, 39, 560, DateTimeKind.Unspecified) },
                    { 56, 4, new DateTime(2023, 5, 22, 20, 39, 52, 54, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 6, 39, 52, 54, DateTimeKind.Unspecified) },
                    { 57, 5, new DateTime(2023, 3, 19, 21, 0, 57, 235, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 1, 0, 57, 235, DateTimeKind.Unspecified) },
                    { 58, 7, new DateTime(2023, 4, 7, 16, 57, 29, 132, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 1, 57, 29, 132, DateTimeKind.Unspecified) },
                    { 59, 7, new DateTime(2023, 4, 23, 15, 55, 11, 498, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 23, 55, 11, 498, DateTimeKind.Unspecified) },
                    { 60, 9, new DateTime(2023, 2, 19, 15, 58, 45, 494, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 21, 58, 45, 494, DateTimeKind.Unspecified) },
                    { 61, 4, new DateTime(2023, 2, 25, 11, 26, 49, 261, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 20, 26, 49, 261, DateTimeKind.Unspecified) },
                    { 62, 6, new DateTime(2023, 5, 28, 4, 43, 54, 20, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 11, 43, 54, 20, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 4, 15, 9, 23, 17, 227, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 14, 23, 17, 227, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 9, new DateTime(2023, 3, 22, 11, 11, 1, 908, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 18, 11, 1, 908, DateTimeKind.Unspecified) },
                    { 65, 2, new DateTime(2023, 2, 8, 22, 24, 29, 306, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 6, 24, 29, 306, DateTimeKind.Unspecified) },
                    { 66, 3, new DateTime(2023, 2, 9, 17, 37, 24, 72, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 19, 37, 24, 72, DateTimeKind.Unspecified) },
                    { 67, 5, new DateTime(2023, 5, 24, 14, 15, 34, 405, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 0, 15, 34, 405, DateTimeKind.Unspecified) },
                    { 68, 1, new DateTime(2023, 5, 24, 20, 17, 49, 308, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 2, 17, 49, 308, DateTimeKind.Unspecified) },
                    { 69, 4, new DateTime(2023, 3, 11, 0, 6, 13, 503, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 7, 6, 13, 503, DateTimeKind.Unspecified) },
                    { 70, 8, new DateTime(2023, 5, 27, 6, 23, 53, 818, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 7, 23, 53, 818, DateTimeKind.Unspecified) },
                    { 71, 1, new DateTime(2023, 3, 24, 16, 30, 52, 525, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 20, 30, 52, 525, DateTimeKind.Unspecified) },
                    { 72, 7, new DateTime(2023, 5, 28, 11, 26, 34, 836, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 12, 26, 34, 836, DateTimeKind.Unspecified) },
                    { 73, 3, new DateTime(2023, 2, 21, 12, 5, 52, 900, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 18, 5, 52, 900, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 5, 15, 20, 2, 27, 749, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 3, 2, 27, 749, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 4, 24, 11, 28, 0, 919, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 15, 28, 0, 919, DateTimeKind.Unspecified) },
                    { 76, 9, new DateTime(2023, 4, 17, 7, 26, 43, 884, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 15, 26, 43, 884, DateTimeKind.Unspecified) },
                    { 77, 4, new DateTime(2023, 3, 9, 20, 48, 13, 321, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 22, 48, 13, 321, DateTimeKind.Unspecified) },
                    { 78, 1, new DateTime(2023, 2, 27, 10, 44, 58, 886, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 20, 44, 58, 886, DateTimeKind.Unspecified) },
                    { 79, 2, new DateTime(2023, 3, 19, 17, 36, 37, 496, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 0, 36, 37, 496, DateTimeKind.Unspecified) },
                    { 80, 4, new DateTime(2023, 5, 16, 17, 58, 4, 731, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 19, 58, 4, 731, DateTimeKind.Unspecified) },
                    { 81, 1, new DateTime(2023, 5, 28, 13, 9, 3, 842, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 17, 9, 3, 842, DateTimeKind.Unspecified) },
                    { 82, 6, new DateTime(2023, 3, 28, 13, 24, 25, 762, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 19, 24, 25, 762, DateTimeKind.Unspecified) },
                    { 83, 3, new DateTime(2023, 4, 22, 15, 22, 41, 552, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 22, 22, 41, 552, DateTimeKind.Unspecified) },
                    { 84, 5, new DateTime(2023, 2, 6, 20, 41, 20, 850, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 21, 41, 20, 850, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 4, 7, 13, 52, 31, 314, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 21, 52, 31, 314, DateTimeKind.Unspecified) },
                    { 86, 6, new DateTime(2023, 3, 13, 1, 58, 19, 489, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 9, 58, 19, 489, DateTimeKind.Unspecified) },
                    { 87, 2, new DateTime(2023, 4, 18, 5, 59, 50, 439, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 15, 59, 50, 439, DateTimeKind.Unspecified) },
                    { 88, 7, new DateTime(2023, 4, 20, 13, 42, 55, 360, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 23, 42, 55, 360, DateTimeKind.Unspecified) },
                    { 89, 8, new DateTime(2023, 4, 24, 4, 20, 18, 932, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 13, 20, 18, 932, DateTimeKind.Unspecified) },
                    { 90, 4, new DateTime(2023, 4, 5, 20, 23, 5, 592, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 4, 23, 5, 592, DateTimeKind.Unspecified) },
                    { 91, 2, new DateTime(2023, 5, 22, 9, 6, 41, 571, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 15, 6, 41, 571, DateTimeKind.Unspecified) },
                    { 92, 2, new DateTime(2023, 2, 21, 11, 43, 16, 377, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 12, 43, 16, 377, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 2, 12, 6, 16, 13, 973, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 12, 16, 13, 973, DateTimeKind.Unspecified) },
                    { 94, 8, new DateTime(2023, 3, 6, 13, 57, 16, 181, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 22, 57, 16, 181, DateTimeKind.Unspecified) },
                    { 95, 8, new DateTime(2023, 5, 15, 1, 37, 8, 798, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 7, 37, 8, 798, DateTimeKind.Unspecified) },
                    { 96, 6, new DateTime(2023, 4, 27, 20, 28, 15, 51, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 23, 28, 15, 51, DateTimeKind.Unspecified) },
                    { 97, 7, new DateTime(2023, 2, 16, 11, 24, 53, 96, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 21, 24, 53, 96, DateTimeKind.Unspecified) },
                    { 98, 2, new DateTime(2023, 4, 9, 11, 17, 50, 424, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 13, 17, 50, 424, DateTimeKind.Unspecified) },
                    { 99, 8, new DateTime(2023, 5, 19, 6, 28, 26, 663, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 11, 28, 26, 663, DateTimeKind.Unspecified) },
                    { 100, 8, new DateTime(2023, 5, 24, 21, 31, 20, 51, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 4, 31, 20, 51, DateTimeKind.Unspecified) },
                    { 101, 5, new DateTime(2023, 5, 18, 13, 58, 51, 196, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 17, 58, 51, 196, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8604), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(8606), 1198m },
                    { 3, 8, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9274), 699m },
                    { 4, 2, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9293), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 2, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9302), 699m },
                    { 6, 6, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9340), 699m },
                    { 7, 1, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9348), 699m },
                    { 8, 7, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9364), 699m },
                    { 9, 7, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9373), 699m },
                    { 10, 8, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9381), 699m },
                    { 11, 4, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9389), 699m },
                    { 12, 8, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9404), 699m },
                    { 13, 1, false, new DateTime(2023, 5, 10, 9, 58, 24, 675, DateTimeKind.Local).AddTicks(9412), 699m }
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
