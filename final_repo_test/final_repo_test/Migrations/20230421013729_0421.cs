using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class _0421 : Migration
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
                    { 1, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6854), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6856), "200元換350點", false, "點數.png", "200元換350點", 200 }
                });

            migrationBuilder.InsertData(
                table: "CaseTables",
                columns: new[] { "Case_ID", "Case_Name", "Case_PricePerDay" },
                values: new object[,]
                {
                    { 1, "豪華蛋黃熱區", 250m },
                    { 2, "中等曝光區", 200m },
                    { 3, "經濟實惠區", 150m },
                    { 4, "限時特惠專區", 100m }
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
                    { 1, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6884), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6885), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6771), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6768), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6784), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6783), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6789), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6789), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6794), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6794), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6800), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6799), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6806), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6805), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6810), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6810), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6815), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6815), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6820), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6819), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6825), "Test", 99, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6824), 1, "Test", "Test" }
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
                    { 1, 2, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6406) },
                    { 2, 5, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6458) },
                    { 3, 9, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6460) },
                    { 4, 4, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6461) },
                    { 5, 2, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6463) },
                    { 6, 7, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6465) },
                    { 7, 8, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6466) },
                    { 8, 10, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6468) },
                    { 9, 4, null, "test", true, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6469) },
                    { 10, 1, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6471) },
                    { 11, 8, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6473) },
                    { 12, 5, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6474) },
                    { 13, 4, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6475) },
                    { 14, 7, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6476) },
                    { 15, 1, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6477) },
                    { 16, 3, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6479) },
                    { 17, 4, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6480) },
                    { 18, 4, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6481) },
                    { 19, 3, null, "test", false, new DateTime(2023, 4, 21, 9, 37, 29, 664, DateTimeKind.Local).AddTicks(6483) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 4, 3, 1, 2, 49, 323, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 6, 2, 49, 323, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 2, 28, 9, 43, 45, 598, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 13, 43, 45, 598, DateTimeKind.Unspecified) },
                    { 3, 5, new DateTime(2023, 4, 2, 1, 24, 8, 941, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 6, 24, 8, 941, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2023, 2, 26, 4, 31, 6, 476, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 12, 31, 6, 476, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2023, 4, 6, 6, 30, 32, 798, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 12, 30, 32, 798, DateTimeKind.Unspecified) },
                    { 6, 8, new DateTime(2023, 2, 7, 2, 14, 50, 117, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 10, 14, 50, 117, DateTimeKind.Unspecified) },
                    { 7, 9, new DateTime(2023, 3, 18, 22, 8, 30, 379, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 4, 8, 30, 379, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 3, 29, 20, 55, 0, 982, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 22, 55, 0, 982, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(2023, 1, 9, 12, 15, 4, 612, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 14, 15, 4, 612, DateTimeKind.Unspecified) },
                    { 10, 8, new DateTime(2023, 2, 3, 1, 4, 38, 393, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 2, 4, 38, 393, DateTimeKind.Unspecified) },
                    { 11, 3, new DateTime(2023, 1, 25, 15, 53, 34, 36, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 23, 53, 34, 36, DateTimeKind.Unspecified) },
                    { 12, 9, new DateTime(2023, 4, 14, 5, 7, 35, 733, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 12, 7, 35, 733, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2023, 1, 12, 11, 19, 54, 349, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 18, 19, 54, 349, DateTimeKind.Unspecified) },
                    { 14, 7, new DateTime(2023, 2, 15, 6, 27, 6, 941, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 13, 27, 6, 941, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 2, 9, 16, 28, 59, 304, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 20, 28, 59, 304, DateTimeKind.Unspecified) },
                    { 16, 9, new DateTime(2023, 4, 5, 11, 20, 5, 967, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 18, 20, 5, 967, DateTimeKind.Unspecified) },
                    { 17, 6, new DateTime(2023, 3, 22, 21, 18, 43, 947, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 6, 18, 43, 947, DateTimeKind.Unspecified) },
                    { 18, 4, new DateTime(2023, 2, 11, 8, 17, 21, 985, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 14, 17, 21, 985, DateTimeKind.Unspecified) },
                    { 19, 6, new DateTime(2023, 4, 21, 9, 11, 18, 536, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 11, 11, 18, 536, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 4, 4, 9, 19, 31, 443, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 10, 19, 31, 443, DateTimeKind.Unspecified) },
                    { 21, 1, new DateTime(2023, 2, 5, 14, 44, 50, 170, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 22, 44, 50, 170, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 6, new DateTime(2023, 2, 20, 19, 30, 54, 588, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 21, 30, 54, 588, DateTimeKind.Unspecified) },
                    { 23, 5, new DateTime(2023, 2, 15, 9, 20, 40, 534, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 17, 20, 40, 534, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2023, 4, 30, 20, 53, 1, 285, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 6, 53, 1, 285, DateTimeKind.Unspecified) },
                    { 25, 5, new DateTime(2023, 4, 2, 20, 12, 9, 587, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 23, 12, 9, 587, DateTimeKind.Unspecified) },
                    { 26, 5, new DateTime(2023, 3, 13, 4, 49, 42, 357, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 14, 49, 42, 357, DateTimeKind.Unspecified) },
                    { 27, 5, new DateTime(2023, 2, 3, 11, 3, 15, 113, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 13, 3, 15, 113, DateTimeKind.Unspecified) },
                    { 28, 3, new DateTime(2023, 1, 15, 16, 31, 25, 918, DateTimeKind.Unspecified), new DateTime(2023, 1, 16, 1, 31, 25, 918, DateTimeKind.Unspecified) },
                    { 29, 1, new DateTime(2023, 1, 3, 8, 49, 47, 377, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 17, 49, 47, 377, DateTimeKind.Unspecified) },
                    { 30, 7, new DateTime(2023, 3, 1, 6, 30, 26, 74, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 12, 30, 26, 74, DateTimeKind.Unspecified) },
                    { 31, 8, new DateTime(2023, 4, 22, 18, 43, 45, 959, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 23, 43, 45, 959, DateTimeKind.Unspecified) },
                    { 32, 3, new DateTime(2023, 4, 5, 23, 16, 34, 864, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 3, 16, 34, 864, DateTimeKind.Unspecified) },
                    { 33, 8, new DateTime(2023, 1, 21, 6, 6, 0, 462, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 16, 6, 0, 462, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2023, 2, 18, 0, 35, 47, 841, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 4, 35, 47, 841, DateTimeKind.Unspecified) },
                    { 35, 5, new DateTime(2023, 2, 12, 7, 24, 57, 379, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 10, 24, 57, 379, DateTimeKind.Unspecified) },
                    { 36, 2, new DateTime(2023, 2, 7, 10, 24, 16, 123, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 16, 24, 16, 123, DateTimeKind.Unspecified) },
                    { 37, 8, new DateTime(2023, 3, 23, 16, 18, 56, 825, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 20, 18, 56, 825, DateTimeKind.Unspecified) },
                    { 38, 7, new DateTime(2023, 4, 7, 8, 7, 16, 189, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 17, 7, 16, 189, DateTimeKind.Unspecified) },
                    { 39, 8, new DateTime(2023, 3, 25, 17, 54, 34, 791, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 22, 54, 34, 791, DateTimeKind.Unspecified) },
                    { 40, 9, new DateTime(2023, 3, 2, 8, 53, 23, 247, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 12, 53, 23, 247, DateTimeKind.Unspecified) },
                    { 41, 6, new DateTime(2023, 2, 2, 11, 29, 36, 571, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 19, 29, 36, 571, DateTimeKind.Unspecified) },
                    { 42, 2, new DateTime(2023, 2, 8, 23, 14, 41, 420, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 6, 14, 41, 420, DateTimeKind.Unspecified) },
                    { 43, 2, new DateTime(2023, 1, 23, 4, 53, 29, 542, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 5, 53, 29, 542, DateTimeKind.Unspecified) },
                    { 44, 5, new DateTime(2023, 2, 26, 20, 6, 11, 895, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 23, 6, 11, 895, DateTimeKind.Unspecified) },
                    { 45, 8, new DateTime(2023, 2, 2, 4, 8, 19, 838, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 10, 8, 19, 838, DateTimeKind.Unspecified) },
                    { 46, 5, new DateTime(2023, 3, 15, 8, 55, 40, 737, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 16, 55, 40, 737, DateTimeKind.Unspecified) },
                    { 47, 3, new DateTime(2023, 2, 16, 13, 55, 21, 557, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 15, 55, 21, 557, DateTimeKind.Unspecified) },
                    { 48, 6, new DateTime(2023, 1, 6, 1, 4, 42, 434, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 9, 4, 42, 434, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2023, 3, 3, 9, 19, 5, 985, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 14, 19, 5, 985, DateTimeKind.Unspecified) },
                    { 50, 3, new DateTime(2023, 4, 16, 5, 5, 36, 470, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 6, 5, 36, 470, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2023, 1, 17, 16, 37, 54, 176, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 23, 37, 54, 176, DateTimeKind.Unspecified) },
                    { 52, 2, new DateTime(2023, 1, 20, 18, 56, 18, 904, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 4, 56, 18, 904, DateTimeKind.Unspecified) },
                    { 53, 9, new DateTime(2023, 1, 5, 11, 34, 31, 935, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 14, 34, 31, 935, DateTimeKind.Unspecified) },
                    { 54, 7, new DateTime(2023, 3, 3, 13, 35, 50, 661, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 17, 35, 50, 661, DateTimeKind.Unspecified) },
                    { 55, 6, new DateTime(2023, 4, 29, 3, 13, 17, 470, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 6, 13, 17, 470, DateTimeKind.Unspecified) },
                    { 56, 8, new DateTime(2023, 4, 1, 5, 20, 57, 696, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 15, 20, 57, 696, DateTimeKind.Unspecified) },
                    { 57, 5, new DateTime(2023, 1, 21, 23, 45, 38, 627, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 4, 45, 38, 627, DateTimeKind.Unspecified) },
                    { 58, 6, new DateTime(2023, 4, 16, 19, 6, 11, 937, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 22, 6, 11, 937, DateTimeKind.Unspecified) },
                    { 59, 2, new DateTime(2023, 2, 1, 20, 0, 55, 233, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 22, 0, 55, 233, DateTimeKind.Unspecified) },
                    { 60, 7, new DateTime(2023, 2, 7, 2, 52, 46, 841, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 8, 52, 46, 841, DateTimeKind.Unspecified) },
                    { 61, 9, new DateTime(2023, 1, 6, 7, 32, 40, 831, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 16, 32, 40, 831, DateTimeKind.Unspecified) },
                    { 62, 7, new DateTime(2023, 1, 22, 20, 16, 40, 747, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 0, 16, 40, 747, DateTimeKind.Unspecified) },
                    { 63, 4, new DateTime(2023, 1, 7, 18, 45, 36, 457, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 20, 45, 36, 457, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 3, new DateTime(2023, 2, 26, 17, 57, 20, 647, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 22, 57, 20, 647, DateTimeKind.Unspecified) },
                    { 65, 4, new DateTime(2023, 3, 30, 8, 1, 5, 41, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 10, 1, 5, 41, DateTimeKind.Unspecified) },
                    { 66, 8, new DateTime(2023, 2, 4, 12, 21, 8, 449, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 20, 21, 8, 449, DateTimeKind.Unspecified) },
                    { 67, 6, new DateTime(2023, 4, 15, 13, 52, 9, 528, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 18, 52, 9, 528, DateTimeKind.Unspecified) },
                    { 68, 7, new DateTime(2023, 1, 2, 8, 11, 1, 271, DateTimeKind.Unspecified), new DateTime(2023, 1, 2, 9, 11, 1, 271, DateTimeKind.Unspecified) },
                    { 69, 9, new DateTime(2023, 3, 1, 2, 42, 19, 476, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 12, 42, 19, 476, DateTimeKind.Unspecified) },
                    { 70, 3, new DateTime(2023, 3, 4, 18, 16, 5, 632, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 22, 16, 5, 632, DateTimeKind.Unspecified) },
                    { 71, 1, new DateTime(2023, 3, 24, 19, 48, 26, 641, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 23, 48, 26, 641, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 1, 7, 2, 16, 39, 37, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 5, 16, 39, 37, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 1, 7, 3, 4, 53, 175, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 12, 4, 53, 175, DateTimeKind.Unspecified) },
                    { 74, 4, new DateTime(2023, 1, 25, 23, 43, 52, 729, DateTimeKind.Unspecified), new DateTime(2023, 1, 26, 1, 43, 52, 729, DateTimeKind.Unspecified) },
                    { 75, 4, new DateTime(2023, 3, 26, 14, 28, 38, 952, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 23, 28, 38, 952, DateTimeKind.Unspecified) },
                    { 76, 9, new DateTime(2023, 4, 14, 10, 43, 12, 854, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 12, 43, 12, 854, DateTimeKind.Unspecified) },
                    { 77, 3, new DateTime(2023, 4, 13, 21, 37, 17, 557, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 6, 37, 17, 557, DateTimeKind.Unspecified) },
                    { 78, 7, new DateTime(2023, 1, 13, 7, 22, 55, 466, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 13, 22, 55, 466, DateTimeKind.Unspecified) },
                    { 79, 4, new DateTime(2023, 1, 23, 13, 12, 40, 28, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 20, 12, 40, 28, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2023, 4, 15, 14, 6, 46, 761, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 20, 6, 46, 761, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 2, 27, 12, 1, 11, 789, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 15, 1, 11, 789, DateTimeKind.Unspecified) },
                    { 82, 4, new DateTime(2023, 2, 16, 12, 58, 1, 697, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 21, 58, 1, 697, DateTimeKind.Unspecified) },
                    { 83, 2, new DateTime(2023, 3, 18, 17, 51, 13, 691, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 21, 51, 13, 691, DateTimeKind.Unspecified) },
                    { 84, 7, new DateTime(2023, 4, 1, 15, 34, 43, 329, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 18, 34, 43, 329, DateTimeKind.Unspecified) },
                    { 85, 6, new DateTime(2023, 4, 2, 13, 47, 50, 408, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 23, 47, 50, 408, DateTimeKind.Unspecified) },
                    { 86, 4, new DateTime(2023, 4, 28, 10, 53, 40, 926, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 12, 53, 40, 926, DateTimeKind.Unspecified) },
                    { 87, 4, new DateTime(2023, 1, 19, 17, 49, 54, 793, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 21, 49, 54, 793, DateTimeKind.Unspecified) },
                    { 88, 2, new DateTime(2023, 4, 27, 19, 11, 16, 752, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 1, 11, 16, 752, DateTimeKind.Unspecified) },
                    { 89, 6, new DateTime(2023, 4, 22, 17, 20, 17, 253, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 19, 20, 17, 253, DateTimeKind.Unspecified) },
                    { 90, 3, new DateTime(2023, 4, 4, 8, 42, 11, 571, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 15, 42, 11, 571, DateTimeKind.Unspecified) },
                    { 91, 2, new DateTime(2023, 4, 3, 3, 45, 22, 460, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 11, 45, 22, 460, DateTimeKind.Unspecified) },
                    { 92, 2, new DateTime(2023, 2, 21, 15, 42, 44, 135, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 21, 42, 44, 135, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 2, 20, 7, 28, 12, 727, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 12, 28, 12, 727, DateTimeKind.Unspecified) },
                    { 94, 1, new DateTime(2023, 4, 4, 16, 14, 53, 589, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 20, 14, 53, 589, DateTimeKind.Unspecified) },
                    { 95, 2, new DateTime(2023, 3, 3, 8, 14, 11, 542, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 12, 14, 11, 542, DateTimeKind.Unspecified) },
                    { 96, 2, new DateTime(2023, 4, 7, 8, 12, 33, 657, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 18, 12, 33, 657, DateTimeKind.Unspecified) },
                    { 97, 2, new DateTime(2023, 2, 10, 20, 25, 25, 910, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 23, 25, 25, 910, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2023, 2, 1, 20, 3, 37, 408, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 2, 3, 37, 408, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 1, 3, 11, 45, 19, 837, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 17, 45, 19, 837, DateTimeKind.Unspecified) },
                    { 100, 6, new DateTime(2023, 4, 22, 13, 0, 6, 941, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 20, 0, 6, 941, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 3, 7, 16, 25, 4, 975, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 0, 25, 4, 975, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6893), 2396m },
                    { 2, 1, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6894), 1198m },
                    { 3, 4, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6974), 699m },
                    { 4, 9, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(6986), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 3, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7006), 699m },
                    { 6, 4, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7016), 699m },
                    { 7, 6, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7024), 699m },
                    { 8, 5, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7032), 699m },
                    { 9, 3, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7071), 699m },
                    { 10, 6, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7080), 699m },
                    { 11, 9, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7088), 699m },
                    { 12, 6, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7096), 699m },
                    { 13, 4, false, new DateTime(2023, 4, 21, 9, 37, 29, 665, DateTimeKind.Local).AddTicks(7110), 699m }
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
