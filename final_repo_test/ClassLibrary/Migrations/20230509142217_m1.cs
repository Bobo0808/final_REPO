using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    public partial class m1 : Migration
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
                    OS_FullfillmentRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OS_PaymentMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    { 1, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9446), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9449), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9469), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9471), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9316), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9313), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9332), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9332), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9342), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9341), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9352), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9351), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9361), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9360), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9372), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9372), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9382), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9381), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9391), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9391), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9401), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9400), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9412), "Test", 99, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9411), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 143, 11, "", new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 2, 15000, 1, 139, 8, "", new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 3, 15000, 1, 106, 24, "", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 4, 15000, 1, 51, 8, "", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 5, 15000, 1, 202, 21, "", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 6, 15000, 1, 227, 12, "", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 7, 15000, 1, 147, 15, "", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 8, 15000, 1, 50, 22, "", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 5 },
                    { 9, 15000, 1, 170, 10, "", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 10, 15000, 1, 154, 9, "", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 11, 15000, 1, 91, 17, "", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 12, 15000, 1, 62, 8, "", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 13, 15000, 1, 235, 16, "", new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 14, 15000, 1, 158, 12, "", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 15, 15000, 1, 88, 17, "", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 16, 15000, 1, 160, 22, "", new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 5 },
                    { 17, 15000, 1, 218, 19, "", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 18, 15000, 1, 71, 11, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 19 },
                    { 19, 15000, 1, 212, 15, "", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 20, 15000, 1, 187, 12, "", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 6 },
                    { 21, 15000, 1, 187, 12, "", new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 22, 15000, 1, 39, 11, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 23, 15000, 1, 34, 24, "", new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 24, 15000, 1, 96, 13, "", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 25, 15000, 1, 145, 9, "", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 26, 15000, 1, 153, 16, "", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 27, 15000, 1, 73, 9, "", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 28, 15000, 1, 114, 23, "", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 29, 15000, 1, 237, 15, "", new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 100, 1 },
                    { 2, 1, 2, 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 10, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2297) },
                    { 2, 7, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2337) },
                    { 3, 7, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2339) },
                    { 4, 3, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2341) },
                    { 5, 3, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2343) },
                    { 6, 7, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2346) },
                    { 7, 5, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2348) },
                    { 8, 10, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2350) },
                    { 9, 2, null, "test", true, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2352) },
                    { 10, 8, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2355) },
                    { 11, 5, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2358) },
                    { 12, 9, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2359) },
                    { 13, 3, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2361) },
                    { 14, 2, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2363) },
                    { 15, 6, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2365) },
                    { 16, 8, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2367) },
                    { 17, 8, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2369) },
                    { 18, 4, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2371) },
                    { 19, 3, null, "test", false, new DateTime(2023, 5, 9, 22, 22, 17, 415, DateTimeKind.Local).AddTicks(2373) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 3, 25, 11, 43, 23, 833, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 19, 43, 23, 833, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 3, 5, 9, 34, 52, 948, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 19, 34, 52, 948, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2023, 4, 10, 19, 10, 57, 462, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 4, 10, 57, 462, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 3, 31, 9, 44, 13, 989, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 12, 44, 13, 989, DateTimeKind.Unspecified) },
                    { 5, 9, new DateTime(2023, 3, 3, 6, 28, 3, 477, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 10, 28, 3, 477, DateTimeKind.Unspecified) },
                    { 6, 8, new DateTime(2023, 4, 30, 4, 39, 5, 829, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 13, 39, 5, 829, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2023, 2, 6, 20, 1, 30, 501, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 22, 1, 30, 501, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2023, 4, 19, 21, 23, 44, 613, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 6, 23, 44, 613, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2023, 4, 4, 5, 21, 13, 557, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 12, 21, 13, 557, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(2023, 4, 23, 21, 35, 57, 356, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 4, 35, 57, 356, DateTimeKind.Unspecified) },
                    { 11, 7, new DateTime(2023, 5, 10, 14, 46, 19, 885, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 19, 46, 19, 885, DateTimeKind.Unspecified) },
                    { 12, 9, new DateTime(2023, 3, 7, 6, 33, 28, 223, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 9, 33, 28, 223, DateTimeKind.Unspecified) },
                    { 13, 6, new DateTime(2023, 3, 27, 22, 17, 57, 886, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 5, 17, 57, 886, DateTimeKind.Unspecified) },
                    { 14, 5, new DateTime(2023, 5, 29, 16, 32, 55, 121, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 19, 32, 55, 121, DateTimeKind.Unspecified) },
                    { 15, 8, new DateTime(2023, 2, 21, 18, 21, 35, 803, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 0, 21, 35, 803, DateTimeKind.Unspecified) },
                    { 16, 6, new DateTime(2023, 4, 30, 6, 40, 35, 692, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 8, 40, 35, 692, DateTimeKind.Unspecified) },
                    { 17, 5, new DateTime(2023, 2, 18, 8, 42, 10, 704, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 18, 42, 10, 704, DateTimeKind.Unspecified) },
                    { 18, 6, new DateTime(2023, 2, 27, 7, 7, 1, 203, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 15, 7, 1, 203, DateTimeKind.Unspecified) },
                    { 19, 5, new DateTime(2023, 5, 29, 6, 9, 29, 386, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 16, 9, 29, 386, DateTimeKind.Unspecified) },
                    { 20, 4, new DateTime(2023, 2, 5, 8, 58, 57, 745, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 12, 58, 57, 745, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 15, 13, 4, 53, 665, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 20, 4, 53, 665, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 2, new DateTime(2023, 2, 15, 22, 4, 0, 837, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 5, 4, 0, 837, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2023, 4, 30, 3, 57, 13, 217, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 7, 57, 13, 217, DateTimeKind.Unspecified) },
                    { 24, 6, new DateTime(2023, 2, 4, 23, 32, 46, 629, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 4, 32, 46, 629, DateTimeKind.Unspecified) },
                    { 25, 7, new DateTime(2023, 5, 29, 0, 35, 50, 803, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 4, 35, 50, 803, DateTimeKind.Unspecified) },
                    { 26, 5, new DateTime(2023, 4, 3, 3, 30, 48, 358, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 12, 30, 48, 358, DateTimeKind.Unspecified) },
                    { 27, 8, new DateTime(2023, 3, 8, 7, 20, 1, 579, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 9, 20, 1, 579, DateTimeKind.Unspecified) },
                    { 28, 6, new DateTime(2023, 4, 17, 17, 18, 30, 566, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 19, 18, 30, 566, DateTimeKind.Unspecified) },
                    { 29, 8, new DateTime(2023, 2, 26, 3, 19, 12, 832, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 7, 19, 12, 832, DateTimeKind.Unspecified) },
                    { 30, 2, new DateTime(2023, 4, 20, 7, 37, 2, 945, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 8, 37, 2, 945, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2023, 5, 20, 21, 27, 42, 665, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 23, 27, 42, 665, DateTimeKind.Unspecified) },
                    { 32, 7, new DateTime(2023, 4, 13, 13, 34, 53, 622, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 16, 34, 53, 622, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2023, 3, 6, 1, 29, 34, 688, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 4, 29, 34, 688, DateTimeKind.Unspecified) },
                    { 34, 4, new DateTime(2023, 3, 1, 12, 47, 5, 435, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 20, 47, 5, 435, DateTimeKind.Unspecified) },
                    { 35, 1, new DateTime(2023, 5, 24, 5, 28, 5, 82, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 6, 28, 5, 82, DateTimeKind.Unspecified) },
                    { 36, 1, new DateTime(2023, 4, 2, 17, 41, 57, 764, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 3, 41, 57, 764, DateTimeKind.Unspecified) },
                    { 37, 2, new DateTime(2023, 2, 12, 1, 11, 7, 454, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 11, 11, 7, 454, DateTimeKind.Unspecified) },
                    { 38, 1, new DateTime(2023, 3, 29, 7, 7, 12, 176, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 16, 7, 12, 176, DateTimeKind.Unspecified) },
                    { 39, 7, new DateTime(2023, 4, 24, 1, 57, 28, 488, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 8, 57, 28, 488, DateTimeKind.Unspecified) },
                    { 40, 5, new DateTime(2023, 5, 19, 1, 44, 45, 163, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 4, 44, 45, 163, DateTimeKind.Unspecified) },
                    { 41, 9, new DateTime(2023, 4, 19, 15, 46, 20, 133, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 22, 46, 20, 133, DateTimeKind.Unspecified) },
                    { 42, 3, new DateTime(2023, 4, 17, 20, 34, 38, 99, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 0, 34, 38, 99, DateTimeKind.Unspecified) },
                    { 43, 3, new DateTime(2023, 5, 6, 22, 33, 26, 478, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 2, 33, 26, 478, DateTimeKind.Unspecified) },
                    { 44, 8, new DateTime(2023, 2, 17, 3, 8, 35, 974, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 9, 8, 35, 974, DateTimeKind.Unspecified) },
                    { 45, 3, new DateTime(2023, 5, 29, 10, 56, 59, 792, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 12, 56, 59, 792, DateTimeKind.Unspecified) },
                    { 46, 1, new DateTime(2023, 3, 7, 22, 57, 30, 403, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 6, 57, 30, 403, DateTimeKind.Unspecified) },
                    { 47, 7, new DateTime(2023, 3, 30, 4, 9, 30, 998, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 14, 9, 30, 998, DateTimeKind.Unspecified) },
                    { 48, 8, new DateTime(2023, 2, 14, 23, 53, 41, 113, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 3, 53, 41, 113, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2023, 4, 27, 4, 8, 14, 331, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 14, 8, 14, 331, DateTimeKind.Unspecified) },
                    { 50, 9, new DateTime(2023, 3, 3, 1, 45, 6, 890, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 7, 45, 6, 890, DateTimeKind.Unspecified) },
                    { 51, 7, new DateTime(2023, 2, 21, 9, 27, 11, 44, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 13, 27, 11, 44, DateTimeKind.Unspecified) },
                    { 52, 9, new DateTime(2023, 2, 13, 12, 49, 6, 170, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 16, 49, 6, 170, DateTimeKind.Unspecified) },
                    { 53, 8, new DateTime(2023, 5, 7, 17, 50, 45, 559, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 21, 50, 45, 559, DateTimeKind.Unspecified) },
                    { 54, 5, new DateTime(2023, 2, 8, 9, 4, 57, 154, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 17, 4, 57, 154, DateTimeKind.Unspecified) },
                    { 55, 7, new DateTime(2023, 2, 7, 17, 8, 27, 935, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 20, 8, 27, 935, DateTimeKind.Unspecified) },
                    { 56, 1, new DateTime(2023, 4, 19, 23, 53, 47, 764, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 0, 53, 47, 764, DateTimeKind.Unspecified) },
                    { 57, 2, new DateTime(2023, 5, 8, 23, 51, 35, 873, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 6, 51, 35, 873, DateTimeKind.Unspecified) },
                    { 58, 6, new DateTime(2023, 2, 1, 11, 22, 16, 328, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 21, 22, 16, 328, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2023, 2, 20, 17, 47, 7, 475, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 20, 47, 7, 475, DateTimeKind.Unspecified) },
                    { 60, 8, new DateTime(2023, 5, 5, 11, 37, 59, 892, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 19, 37, 59, 892, DateTimeKind.Unspecified) },
                    { 61, 8, new DateTime(2023, 4, 5, 15, 50, 57, 823, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 20, 50, 57, 823, DateTimeKind.Unspecified) },
                    { 62, 6, new DateTime(2023, 2, 7, 7, 38, 19, 831, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 17, 38, 19, 831, DateTimeKind.Unspecified) },
                    { 63, 2, new DateTime(2023, 4, 2, 2, 30, 47, 327, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 5, 30, 47, 327, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 8, new DateTime(2023, 4, 18, 0, 35, 32, 566, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 10, 35, 32, 566, DateTimeKind.Unspecified) },
                    { 65, 3, new DateTime(2023, 3, 9, 17, 54, 53, 624, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 18, 54, 53, 624, DateTimeKind.Unspecified) },
                    { 66, 5, new DateTime(2023, 3, 8, 19, 38, 58, 3, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 22, 38, 58, 3, DateTimeKind.Unspecified) },
                    { 67, 3, new DateTime(2023, 3, 3, 8, 18, 40, 665, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 12, 18, 40, 665, DateTimeKind.Unspecified) },
                    { 68, 1, new DateTime(2023, 2, 13, 16, 45, 51, 344, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 18, 45, 51, 344, DateTimeKind.Unspecified) },
                    { 69, 3, new DateTime(2023, 4, 21, 3, 29, 17, 758, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 11, 29, 17, 758, DateTimeKind.Unspecified) },
                    { 70, 9, new DateTime(2023, 4, 28, 14, 1, 3, 323, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 18, 1, 3, 323, DateTimeKind.Unspecified) },
                    { 71, 7, new DateTime(2023, 3, 6, 14, 4, 35, 582, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 15, 4, 35, 582, DateTimeKind.Unspecified) },
                    { 72, 3, new DateTime(2023, 3, 20, 9, 28, 36, 819, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 19, 28, 36, 819, DateTimeKind.Unspecified) },
                    { 73, 6, new DateTime(2023, 3, 29, 19, 36, 0, 891, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 2, 36, 0, 891, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 3, 6, 9, 21, 50, 482, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 16, 21, 50, 482, DateTimeKind.Unspecified) },
                    { 75, 2, new DateTime(2023, 2, 16, 2, 34, 45, 278, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 12, 34, 45, 278, DateTimeKind.Unspecified) },
                    { 76, 8, new DateTime(2023, 4, 6, 7, 47, 45, 146, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 12, 47, 45, 146, DateTimeKind.Unspecified) },
                    { 77, 2, new DateTime(2023, 2, 24, 3, 41, 28, 943, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 8, 41, 28, 943, DateTimeKind.Unspecified) },
                    { 78, 8, new DateTime(2023, 2, 28, 18, 54, 0, 994, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 20, 54, 0, 994, DateTimeKind.Unspecified) },
                    { 79, 7, new DateTime(2023, 3, 29, 3, 31, 27, 58, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 13, 31, 27, 58, DateTimeKind.Unspecified) },
                    { 80, 1, new DateTime(2023, 2, 14, 10, 13, 34, 436, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 14, 13, 34, 436, DateTimeKind.Unspecified) },
                    { 81, 5, new DateTime(2023, 5, 15, 1, 9, 22, 316, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 11, 9, 22, 316, DateTimeKind.Unspecified) },
                    { 82, 8, new DateTime(2023, 3, 24, 4, 19, 57, 639, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 8, 19, 57, 639, DateTimeKind.Unspecified) },
                    { 83, 5, new DateTime(2023, 3, 17, 8, 6, 57, 533, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 10, 6, 57, 533, DateTimeKind.Unspecified) },
                    { 84, 2, new DateTime(2023, 3, 31, 9, 20, 52, 625, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 10, 20, 52, 625, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 3, 9, 12, 50, 4, 528, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 16, 50, 4, 528, DateTimeKind.Unspecified) },
                    { 86, 9, new DateTime(2023, 3, 23, 12, 46, 26, 229, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 20, 46, 26, 229, DateTimeKind.Unspecified) },
                    { 87, 4, new DateTime(2023, 3, 23, 11, 32, 39, 246, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 12, 32, 39, 246, DateTimeKind.Unspecified) },
                    { 88, 9, new DateTime(2023, 4, 2, 21, 33, 7, 952, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 33, 7, 952, DateTimeKind.Unspecified) },
                    { 89, 4, new DateTime(2023, 5, 15, 11, 50, 0, 606, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 14, 50, 0, 606, DateTimeKind.Unspecified) },
                    { 90, 8, new DateTime(2023, 3, 20, 13, 10, 23, 132, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 21, 10, 23, 132, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 2, 21, 15, 17, 29, 29, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 21, 17, 29, 29, DateTimeKind.Unspecified) },
                    { 92, 2, new DateTime(2023, 3, 22, 14, 33, 48, 960, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 0, 33, 48, 960, DateTimeKind.Unspecified) },
                    { 93, 8, new DateTime(2023, 3, 18, 16, 53, 10, 423, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 1, 53, 10, 423, DateTimeKind.Unspecified) },
                    { 94, 6, new DateTime(2023, 3, 12, 15, 46, 46, 330, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 23, 46, 46, 330, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 3, 21, 23, 26, 14, 476, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 1, 26, 14, 476, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 5, 28, 19, 35, 0, 398, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 0, 35, 0, 398, DateTimeKind.Unspecified) },
                    { 97, 6, new DateTime(2023, 4, 9, 13, 12, 26, 598, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 16, 12, 26, 598, DateTimeKind.Unspecified) },
                    { 98, 2, new DateTime(2023, 4, 15, 22, 16, 54, 14, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 6, 16, 54, 14, DateTimeKind.Unspecified) },
                    { 99, 9, new DateTime(2023, 3, 29, 7, 13, 35, 64, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 8, 13, 35, 64, DateTimeKind.Unspecified) },
                    { 100, 1, new DateTime(2023, 4, 24, 8, 15, 55, 365, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 9, 15, 55, 365, DateTimeKind.Unspecified) },
                    { 101, 3, new DateTime(2023, 2, 7, 4, 21, 49, 11, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 11, 21, 49, 11, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9483), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 9, 22, 22, 17, 416, DateTimeKind.Local).AddTicks(9484), 1198m },
                    { 3, 6, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(140), 699m },
                    { 4, 3, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(161), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 2, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(178), 699m },
                    { 6, 2, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(198), 699m },
                    { 7, 7, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(215), 699m },
                    { 8, 9, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(233), 699m },
                    { 9, 9, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(250), 699m },
                    { 10, 1, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(275), 699m },
                    { 11, 8, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(292), 699m },
                    { 12, 8, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(309), 699m },
                    { 13, 2, false, new DateTime(2023, 5, 9, 22, 22, 17, 417, DateTimeKind.Local).AddTicks(326), 699m }
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
