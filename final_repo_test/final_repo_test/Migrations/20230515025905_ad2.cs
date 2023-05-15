using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class ad2 : Migration
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
                    E_Work = table.Column<bool>(type: "bit", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    { 1, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3556), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3558), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3566), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3568), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3474), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3470), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3486), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3485), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3492), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3491), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3497), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3497), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3502), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3502), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3508), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3508), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3513), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3513), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3518), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3517), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3522), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3522), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3527), "Test", 99, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3527), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 133, 17, "", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 2, 15000, 1, 85, 12, "", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 3, 15000, 1, 116, 15, "", new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 4, 15000, 1, 218, 18, "", new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 5, 15000, 1, 56, 8, "", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 6, 15000, 1, 169, 19, "", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 7, 15000, 1, 33, 7, "", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 8, 15000, 1, 85, 21, "", new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 9, 15000, 1, 169, 11, "", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 10, 15000, 1, 116, 24, "", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 11, 15000, 1, 200, 9, "", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 12, 15000, 1, 30, 16, "", new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 13, 15000, 1, 193, 19, "", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 14, 15000, 1, 80, 12, "", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 15, 15000, 1, 120, 16, "", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 16, 15000, 1, 81, 18, "", new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 17, 15000, 1, 67, 23, "", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 20 },
                    { 18, 15000, 1, 65, 11, "", new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 4 },
                    { 19, 15000, 1, 137, 14, "", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 20, 15000, 1, 97, 11, "", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 21, 15000, 1, 173, 22, "", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 6 },
                    { 22, 15000, 1, 35, 11, "", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 23, 15000, 1, 131, 8, "", new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 24, 15000, 1, 163, 20, "", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 25, 15000, 1, 60, 17, "", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 26, 15000, 1, 51, 19, "", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 27, 15000, 1, 46, 16, "", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 12 },
                    { 28, 15000, 1, 153, 14, "", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 29, 15000, 1, 136, 15, "", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3546), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3548), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 9, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3429) },
                    { 2, 2, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3479) },
                    { 3, 10, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3480) },
                    { 4, 3, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3481) },
                    { 5, 2, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3482) },
                    { 6, 7, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3485) },
                    { 7, 3, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3486) },
                    { 8, 4, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3487) },
                    { 9, 7, null, "test", true, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3508) },
                    { 10, 5, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3510) },
                    { 11, 7, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3511) },
                    { 12, 3, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3512) },
                    { 13, 10, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3513) },
                    { 14, 6, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3515) },
                    { 15, 4, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3516) },
                    { 16, 10, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3516) },
                    { 17, 9, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3518) },
                    { 18, 10, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3519) },
                    { 19, 8, null, "test", false, new DateTime(2023, 5, 15, 10, 59, 5, 274, DateTimeKind.Local).AddTicks(3520) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2023, 3, 26, 7, 27, 38, 725, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 9, 27, 38, 725, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(2023, 3, 10, 16, 59, 5, 530, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 17, 59, 5, 530, DateTimeKind.Unspecified) },
                    { 3, 5, new DateTime(2023, 2, 18, 16, 21, 42, 172, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 2, 21, 42, 172, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 5, 4, 11, 16, 29, 917, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 20, 16, 29, 917, DateTimeKind.Unspecified) },
                    { 5, 9, new DateTime(2023, 3, 30, 2, 32, 53, 148, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 4, 32, 53, 148, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2023, 4, 7, 3, 22, 2, 515, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 11, 22, 2, 515, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(2023, 2, 3, 2, 8, 54, 670, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 12, 8, 54, 670, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2023, 5, 5, 19, 46, 9, 251, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 5, 46, 9, 251, DateTimeKind.Unspecified) },
                    { 9, 6, new DateTime(2023, 3, 20, 17, 32, 27, 593, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 18, 32, 27, 593, DateTimeKind.Unspecified) },
                    { 10, 7, new DateTime(2023, 2, 12, 1, 58, 54, 734, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 8, 58, 54, 734, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2023, 2, 5, 0, 25, 58, 903, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 2, 25, 58, 903, DateTimeKind.Unspecified) },
                    { 12, 4, new DateTime(2023, 4, 24, 1, 54, 12, 62, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 3, 54, 12, 62, DateTimeKind.Unspecified) },
                    { 13, 9, new DateTime(2023, 3, 19, 15, 30, 29, 911, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 21, 30, 29, 911, DateTimeKind.Unspecified) },
                    { 14, 5, new DateTime(2023, 5, 25, 5, 4, 2, 463, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 15, 4, 2, 463, DateTimeKind.Unspecified) },
                    { 15, 6, new DateTime(2023, 2, 25, 15, 49, 26, 342, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 1, 49, 26, 342, DateTimeKind.Unspecified) },
                    { 16, 6, new DateTime(2023, 4, 3, 4, 59, 31, 797, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 7, 59, 31, 797, DateTimeKind.Unspecified) },
                    { 17, 3, new DateTime(2023, 2, 21, 15, 6, 30, 427, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 17, 6, 30, 427, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2023, 4, 20, 17, 35, 24, 282, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 21, 35, 24, 282, DateTimeKind.Unspecified) },
                    { 19, 7, new DateTime(2023, 3, 20, 4, 17, 53, 552, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 7, 17, 53, 552, DateTimeKind.Unspecified) },
                    { 20, 4, new DateTime(2023, 3, 31, 6, 27, 28, 770, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 10, 27, 28, 770, DateTimeKind.Unspecified) },
                    { 21, 1, new DateTime(2023, 2, 27, 8, 13, 31, 329, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 18, 13, 31, 329, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 5, new DateTime(2023, 3, 4, 16, 54, 45, 132, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 18, 54, 45, 132, DateTimeKind.Unspecified) },
                    { 23, 9, new DateTime(2023, 5, 26, 20, 6, 25, 280, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 5, 6, 25, 280, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2023, 2, 8, 4, 57, 12, 21, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 5, 57, 12, 21, DateTimeKind.Unspecified) },
                    { 25, 3, new DateTime(2023, 5, 8, 2, 50, 16, 989, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 4, 50, 16, 989, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2023, 5, 16, 5, 8, 54, 341, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 10, 8, 54, 341, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 3, 2, 12, 4, 15, 630, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 22, 4, 15, 630, DateTimeKind.Unspecified) },
                    { 28, 7, new DateTime(2023, 2, 16, 21, 39, 48, 682, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 4, 39, 48, 682, DateTimeKind.Unspecified) },
                    { 29, 2, new DateTime(2023, 4, 3, 13, 51, 51, 238, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 15, 51, 51, 238, DateTimeKind.Unspecified) },
                    { 30, 5, new DateTime(2023, 5, 28, 8, 49, 50, 746, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 16, 49, 50, 746, DateTimeKind.Unspecified) },
                    { 31, 4, new DateTime(2023, 5, 26, 0, 28, 37, 281, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 2, 28, 37, 281, DateTimeKind.Unspecified) },
                    { 32, 5, new DateTime(2023, 2, 3, 16, 33, 28, 234, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 22, 33, 28, 234, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2023, 2, 14, 4, 16, 55, 56, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 8, 16, 55, 56, DateTimeKind.Unspecified) },
                    { 34, 6, new DateTime(2023, 3, 10, 16, 8, 12, 70, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 0, 8, 12, 70, DateTimeKind.Unspecified) },
                    { 35, 6, new DateTime(2023, 5, 3, 10, 16, 29, 744, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 20, 16, 29, 744, DateTimeKind.Unspecified) },
                    { 36, 4, new DateTime(2023, 4, 10, 10, 7, 21, 273, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 15, 7, 21, 273, DateTimeKind.Unspecified) },
                    { 37, 2, new DateTime(2023, 5, 22, 21, 56, 13, 286, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 22, 56, 13, 286, DateTimeKind.Unspecified) },
                    { 38, 4, new DateTime(2023, 5, 4, 21, 37, 53, 743, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 4, 37, 53, 743, DateTimeKind.Unspecified) },
                    { 39, 9, new DateTime(2023, 5, 24, 23, 27, 40, 998, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 5, 27, 40, 998, DateTimeKind.Unspecified) },
                    { 40, 8, new DateTime(2023, 4, 4, 22, 25, 47, 768, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 7, 25, 47, 768, DateTimeKind.Unspecified) },
                    { 41, 9, new DateTime(2023, 5, 29, 20, 9, 4, 409, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 3, 9, 4, 409, DateTimeKind.Unspecified) },
                    { 42, 8, new DateTime(2023, 2, 3, 10, 41, 45, 754, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 14, 41, 45, 754, DateTimeKind.Unspecified) },
                    { 43, 3, new DateTime(2023, 3, 12, 23, 53, 58, 694, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 5, 53, 58, 694, DateTimeKind.Unspecified) },
                    { 44, 7, new DateTime(2023, 5, 17, 7, 7, 48, 37, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 12, 7, 48, 37, DateTimeKind.Unspecified) },
                    { 45, 2, new DateTime(2023, 4, 25, 16, 34, 31, 34, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 0, 34, 31, 34, DateTimeKind.Unspecified) },
                    { 46, 1, new DateTime(2023, 4, 29, 9, 11, 38, 403, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 15, 11, 38, 403, DateTimeKind.Unspecified) },
                    { 47, 5, new DateTime(2023, 2, 2, 22, 9, 53, 532, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 23, 9, 53, 532, DateTimeKind.Unspecified) },
                    { 48, 1, new DateTime(2023, 4, 3, 6, 23, 59, 333, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 8, 23, 59, 333, DateTimeKind.Unspecified) },
                    { 49, 3, new DateTime(2023, 2, 20, 20, 57, 42, 212, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 3, 57, 42, 212, DateTimeKind.Unspecified) },
                    { 50, 5, new DateTime(2023, 4, 21, 21, 54, 3, 245, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 4, 54, 3, 245, DateTimeKind.Unspecified) },
                    { 51, 9, new DateTime(2023, 4, 15, 21, 8, 7, 445, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 4, 8, 7, 445, DateTimeKind.Unspecified) },
                    { 52, 8, new DateTime(2023, 2, 6, 23, 2, 7, 479, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 0, 2, 7, 479, DateTimeKind.Unspecified) },
                    { 53, 9, new DateTime(2023, 4, 3, 8, 43, 54, 208, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 17, 43, 54, 208, DateTimeKind.Unspecified) },
                    { 54, 9, new DateTime(2023, 2, 17, 0, 2, 50, 341, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 4, 2, 50, 341, DateTimeKind.Unspecified) },
                    { 55, 5, new DateTime(2023, 4, 27, 13, 23, 3, 44, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 14, 23, 3, 44, DateTimeKind.Unspecified) },
                    { 56, 4, new DateTime(2023, 4, 16, 13, 24, 5, 21, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 22, 24, 5, 21, DateTimeKind.Unspecified) },
                    { 57, 1, new DateTime(2023, 5, 1, 13, 42, 10, 252, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 20, 42, 10, 252, DateTimeKind.Unspecified) },
                    { 58, 8, new DateTime(2023, 4, 4, 8, 37, 3, 774, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 10, 37, 3, 774, DateTimeKind.Unspecified) },
                    { 59, 7, new DateTime(2023, 3, 8, 0, 18, 12, 833, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 4, 18, 12, 833, DateTimeKind.Unspecified) },
                    { 60, 7, new DateTime(2023, 5, 27, 12, 59, 40, 950, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 22, 59, 40, 950, DateTimeKind.Unspecified) },
                    { 61, 9, new DateTime(2023, 2, 28, 17, 17, 21, 386, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 2, 17, 21, 386, DateTimeKind.Unspecified) },
                    { 62, 8, new DateTime(2023, 2, 28, 11, 46, 36, 941, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 12, 46, 36, 941, DateTimeKind.Unspecified) },
                    { 63, 9, new DateTime(2023, 4, 21, 18, 43, 59, 839, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 20, 43, 59, 839, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 4, new DateTime(2023, 4, 21, 10, 23, 51, 76, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 17, 23, 51, 76, DateTimeKind.Unspecified) },
                    { 65, 8, new DateTime(2023, 3, 1, 21, 38, 19, 386, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 3, 38, 19, 386, DateTimeKind.Unspecified) },
                    { 66, 3, new DateTime(2023, 5, 3, 5, 34, 6, 627, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 8, 34, 6, 627, DateTimeKind.Unspecified) },
                    { 67, 6, new DateTime(2023, 4, 13, 23, 52, 23, 170, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 4, 52, 23, 170, DateTimeKind.Unspecified) },
                    { 68, 7, new DateTime(2023, 3, 24, 2, 23, 20, 940, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 7, 23, 20, 940, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 4, 27, 8, 24, 50, 409, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 9, 24, 50, 409, DateTimeKind.Unspecified) },
                    { 70, 7, new DateTime(2023, 4, 30, 14, 49, 5, 621, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 23, 49, 5, 621, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 2, 16, 15, 43, 5, 896, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 19, 43, 5, 896, DateTimeKind.Unspecified) },
                    { 72, 6, new DateTime(2023, 2, 14, 17, 17, 48, 646, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 23, 17, 48, 646, DateTimeKind.Unspecified) },
                    { 73, 1, new DateTime(2023, 5, 5, 13, 34, 23, 371, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 23, 34, 23, 371, DateTimeKind.Unspecified) },
                    { 74, 7, new DateTime(2023, 4, 21, 15, 30, 36, 457, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 21, 30, 36, 457, DateTimeKind.Unspecified) },
                    { 75, 6, new DateTime(2023, 3, 1, 19, 27, 8, 462, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 22, 27, 8, 462, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 3, 10, 3, 56, 12, 517, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 12, 56, 12, 517, DateTimeKind.Unspecified) },
                    { 77, 4, new DateTime(2023, 4, 19, 3, 15, 40, 124, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 11, 15, 40, 124, DateTimeKind.Unspecified) },
                    { 78, 7, new DateTime(2023, 2, 21, 21, 16, 37, 243, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 0, 16, 37, 243, DateTimeKind.Unspecified) },
                    { 79, 8, new DateTime(2023, 4, 15, 0, 5, 59, 158, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 7, 5, 59, 158, DateTimeKind.Unspecified) },
                    { 80, 7, new DateTime(2023, 3, 19, 10, 8, 13, 787, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 20, 8, 13, 787, DateTimeKind.Unspecified) },
                    { 81, 7, new DateTime(2023, 5, 4, 8, 41, 1, 438, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 13, 41, 1, 438, DateTimeKind.Unspecified) },
                    { 82, 9, new DateTime(2023, 4, 3, 16, 54, 12, 973, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 0, 54, 12, 973, DateTimeKind.Unspecified) },
                    { 83, 5, new DateTime(2023, 4, 19, 15, 59, 25, 976, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 17, 59, 25, 976, DateTimeKind.Unspecified) },
                    { 84, 3, new DateTime(2023, 3, 1, 12, 5, 33, 660, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 22, 5, 33, 660, DateTimeKind.Unspecified) },
                    { 85, 6, new DateTime(2023, 2, 24, 11, 33, 20, 567, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 13, 33, 20, 567, DateTimeKind.Unspecified) },
                    { 86, 5, new DateTime(2023, 5, 13, 9, 29, 11, 453, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 19, 29, 11, 453, DateTimeKind.Unspecified) },
                    { 87, 3, new DateTime(2023, 3, 24, 16, 22, 12, 905, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 21, 22, 12, 905, DateTimeKind.Unspecified) },
                    { 88, 8, new DateTime(2023, 5, 18, 13, 1, 36, 236, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 21, 1, 36, 236, DateTimeKind.Unspecified) },
                    { 89, 4, new DateTime(2023, 5, 6, 6, 3, 20, 223, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 12, 3, 20, 223, DateTimeKind.Unspecified) },
                    { 90, 3, new DateTime(2023, 4, 24, 19, 3, 38, 552, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 5, 3, 38, 552, DateTimeKind.Unspecified) },
                    { 91, 2, new DateTime(2023, 3, 27, 14, 33, 14, 852, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 21, 33, 14, 852, DateTimeKind.Unspecified) },
                    { 92, 5, new DateTime(2023, 2, 27, 18, 9, 38, 433, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 0, 9, 38, 433, DateTimeKind.Unspecified) },
                    { 93, 2, new DateTime(2023, 2, 7, 10, 28, 59, 708, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 17, 28, 59, 708, DateTimeKind.Unspecified) },
                    { 94, 1, new DateTime(2023, 4, 28, 21, 59, 42, 629, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 2, 59, 42, 629, DateTimeKind.Unspecified) },
                    { 95, 6, new DateTime(2023, 3, 10, 22, 25, 54, 666, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 2, 25, 54, 666, DateTimeKind.Unspecified) },
                    { 96, 7, new DateTime(2023, 5, 18, 3, 23, 32, 67, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 6, 23, 32, 67, DateTimeKind.Unspecified) },
                    { 97, 2, new DateTime(2023, 5, 31, 20, 54, 22, 624, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 2, 54, 22, 624, DateTimeKind.Unspecified) },
                    { 98, 5, new DateTime(2023, 4, 2, 5, 9, 7, 230, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 8, 9, 7, 230, DateTimeKind.Unspecified) },
                    { 99, 2, new DateTime(2023, 5, 20, 8, 45, 53, 663, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 11, 45, 53, 663, DateTimeKind.Unspecified) },
                    { 100, 9, new DateTime(2023, 4, 6, 9, 50, 16, 444, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 12, 50, 16, 444, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 2, 12, 22, 18, 17, 327, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 18, 17, 327, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3575), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(3576), 1198m },
                    { 3, 2, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4271), 699m },
                    { 4, 1, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4282), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 1, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4297), 699m },
                    { 6, 5, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4306), 699m },
                    { 7, 8, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4315), 699m },
                    { 8, 4, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4324), 699m },
                    { 9, 5, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4339), 699m },
                    { 10, 8, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4348), 699m },
                    { 11, 4, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4355), 699m },
                    { 12, 5, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4392), 699m },
                    { 13, 8, false, new DateTime(2023, 5, 15, 10, 59, 5, 275, DateTimeKind.Local).AddTicks(4407), 699m }
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
