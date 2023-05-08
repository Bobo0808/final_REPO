using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
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
                    { 1, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5691), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5693), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5707), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5708), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5498), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5491), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5520), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5519), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5529), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5529), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5584), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5584), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5594), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5594), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5605), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5605), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5615), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5614), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5624), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5623), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5633), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5633), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5644), "Test", 99, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5643), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 213, 11, "", new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 2, 15000, 1, 184, 9, "", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 3, 15000, 1, 55, 16, "", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 4, 15000, 1, 30, 15, "", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 5, 15000, 1, 53, 20, "", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 6, 15000, 1, 58, 22, "", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 7, 15000, 1, 146, 19, "", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 8, 15000, 1, 85, 13, "", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 9, 15000, 1, 115, 19, "", new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 10, 15000, 1, 35, 18, "", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 11, 15000, 1, 209, 15, "", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 12, 15000, 1, 188, 16, "", new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 13, 15000, 1, 113, 14, "", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 14, 15000, 1, 212, 15, "", new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 15, 15000, 1, 79, 13, "", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 16, 15000, 1, 191, 13, "", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 17, 15000, 1, 42, 7, "", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 18, 15000, 1, 209, 12, "", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 19, 15000, 1, 110, 13, "", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 },
                    { 20, 15000, 1, 74, 9, "", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 21, 15000, 1, 136, 18, "", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 22, 15000, 1, 158, 11, "", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 23, 15000, 1, 151, 14, "", new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 17 },
                    { 24, 15000, 1, 150, 14, "", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 25, 15000, 1, 174, 9, "", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 26, 15000, 1, 179, 21, "", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 27, 15000, 1, 178, 7, "", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 28, 15000, 1, 53, 17, "", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 4 },
                    { 29, 15000, 1, 197, 15, "", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 }
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
                    { 1, 5, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9744) },
                    { 2, 2, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9831) },
                    { 3, 8, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9833) },
                    { 4, 4, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9835) },
                    { 5, 1, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9837) },
                    { 6, 4, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9841) },
                    { 7, 3, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9843) },
                    { 8, 5, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9845) },
                    { 9, 6, null, "test", true, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9846) },
                    { 10, 1, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9849) },
                    { 11, 6, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9852) },
                    { 12, 10, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9854) },
                    { 13, 1, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9856) },
                    { 14, 10, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9857) },
                    { 15, 6, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9859) },
                    { 16, 3, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9861) },
                    { 17, 5, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9862) },
                    { 18, 8, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9865) },
                    { 19, 7, null, "test", false, new DateTime(2023, 5, 8, 20, 35, 46, 986, DateTimeKind.Local).AddTicks(9867) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 3, 6, 14, 8, 31, 960, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 17, 8, 31, 960, DateTimeKind.Unspecified) },
                    { 2, 9, new DateTime(2023, 2, 28, 17, 52, 34, 500, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 21, 52, 34, 500, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(2023, 3, 2, 3, 45, 11, 783, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 8, 45, 11, 783, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2023, 5, 30, 13, 30, 36, 304, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 22, 30, 36, 304, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2023, 4, 3, 10, 23, 29, 174, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 12, 23, 29, 174, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2023, 4, 7, 16, 16, 34, 550, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 19, 16, 34, 550, DateTimeKind.Unspecified) },
                    { 7, 9, new DateTime(2023, 4, 21, 23, 48, 33, 121, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 8, 48, 33, 121, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2023, 2, 20, 9, 25, 50, 686, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 14, 25, 50, 686, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2023, 4, 28, 13, 59, 36, 80, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 22, 59, 36, 80, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2023, 3, 21, 8, 0, 44, 337, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 13, 0, 44, 337, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2023, 4, 23, 12, 18, 26, 619, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 14, 18, 26, 619, DateTimeKind.Unspecified) },
                    { 12, 3, new DateTime(2023, 2, 9, 9, 0, 26, 148, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 12, 0, 26, 148, DateTimeKind.Unspecified) },
                    { 13, 9, new DateTime(2023, 4, 19, 2, 54, 26, 726, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 9, 54, 26, 726, DateTimeKind.Unspecified) },
                    { 14, 5, new DateTime(2023, 5, 1, 22, 3, 12, 425, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 0, 3, 12, 425, DateTimeKind.Unspecified) },
                    { 15, 6, new DateTime(2023, 5, 7, 11, 56, 7, 454, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 15, 56, 7, 454, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 5, 10, 5, 13, 44, 515, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 12, 13, 44, 515, DateTimeKind.Unspecified) },
                    { 17, 4, new DateTime(2023, 2, 22, 7, 47, 21, 808, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 17, 47, 21, 808, DateTimeKind.Unspecified) },
                    { 18, 5, new DateTime(2023, 3, 31, 2, 57, 30, 303, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 7, 57, 30, 303, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2023, 5, 19, 11, 38, 15, 123, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 13, 38, 15, 123, DateTimeKind.Unspecified) },
                    { 20, 6, new DateTime(2023, 5, 23, 6, 25, 3, 531, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 11, 25, 3, 531, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 3, 31, 20, 40, 31, 199, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 22, 40, 31, 199, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 5, new DateTime(2023, 3, 27, 19, 54, 45, 250, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 21, 54, 45, 250, DateTimeKind.Unspecified) },
                    { 23, 5, new DateTime(2023, 3, 14, 12, 10, 35, 208, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 17, 10, 35, 208, DateTimeKind.Unspecified) },
                    { 24, 9, new DateTime(2023, 5, 3, 21, 34, 20, 111, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 22, 34, 20, 111, DateTimeKind.Unspecified) },
                    { 25, 7, new DateTime(2023, 2, 5, 1, 17, 19, 99, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 9, 17, 19, 99, DateTimeKind.Unspecified) },
                    { 26, 5, new DateTime(2023, 4, 3, 23, 0, 54, 891, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 2, 0, 54, 891, DateTimeKind.Unspecified) },
                    { 27, 1, new DateTime(2023, 5, 7, 9, 39, 11, 88, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 14, 39, 11, 88, DateTimeKind.Unspecified) },
                    { 28, 7, new DateTime(2023, 3, 26, 12, 41, 57, 685, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 41, 57, 685, DateTimeKind.Unspecified) },
                    { 29, 9, new DateTime(2023, 2, 1, 2, 25, 24, 791, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 12, 25, 24, 791, DateTimeKind.Unspecified) },
                    { 30, 2, new DateTime(2023, 2, 25, 3, 1, 7, 39, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 5, 1, 7, 39, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2023, 2, 14, 23, 59, 17, 892, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 3, 59, 17, 892, DateTimeKind.Unspecified) },
                    { 32, 8, new DateTime(2023, 5, 27, 2, 17, 16, 559, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 7, 17, 16, 559, DateTimeKind.Unspecified) },
                    { 33, 7, new DateTime(2023, 5, 13, 19, 35, 45, 237, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 3, 35, 45, 237, DateTimeKind.Unspecified) },
                    { 34, 8, new DateTime(2023, 5, 13, 17, 27, 31, 839, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 23, 27, 31, 839, DateTimeKind.Unspecified) },
                    { 35, 8, new DateTime(2023, 2, 1, 17, 13, 24, 74, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 18, 13, 24, 74, DateTimeKind.Unspecified) },
                    { 36, 7, new DateTime(2023, 3, 29, 13, 36, 8, 684, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 17, 36, 8, 684, DateTimeKind.Unspecified) },
                    { 37, 3, new DateTime(2023, 2, 16, 17, 43, 15, 501, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 19, 43, 15, 501, DateTimeKind.Unspecified) },
                    { 38, 7, new DateTime(2023, 2, 10, 7, 16, 27, 682, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 16, 16, 27, 682, DateTimeKind.Unspecified) },
                    { 39, 2, new DateTime(2023, 4, 19, 23, 44, 45, 655, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 4, 44, 45, 655, DateTimeKind.Unspecified) },
                    { 40, 1, new DateTime(2023, 5, 10, 6, 1, 41, 193, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 15, 1, 41, 193, DateTimeKind.Unspecified) },
                    { 41, 2, new DateTime(2023, 2, 9, 18, 14, 54, 292, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 0, 14, 54, 292, DateTimeKind.Unspecified) },
                    { 42, 3, new DateTime(2023, 5, 31, 11, 53, 54, 286, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 14, 53, 54, 286, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 5, 10, 18, 5, 36, 783, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 22, 5, 36, 783, DateTimeKind.Unspecified) },
                    { 44, 6, new DateTime(2023, 4, 7, 15, 7, 9, 648, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 21, 7, 9, 648, DateTimeKind.Unspecified) },
                    { 45, 9, new DateTime(2023, 4, 9, 16, 41, 34, 179, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 20, 41, 34, 179, DateTimeKind.Unspecified) },
                    { 46, 5, new DateTime(2023, 3, 4, 9, 59, 45, 466, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 13, 59, 45, 466, DateTimeKind.Unspecified) },
                    { 47, 5, new DateTime(2023, 3, 2, 17, 58, 35, 589, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 23, 58, 35, 589, DateTimeKind.Unspecified) },
                    { 48, 7, new DateTime(2023, 2, 19, 19, 50, 16, 325, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 1, 50, 16, 325, DateTimeKind.Unspecified) },
                    { 49, 3, new DateTime(2023, 2, 2, 17, 35, 11, 283, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 20, 35, 11, 283, DateTimeKind.Unspecified) },
                    { 50, 2, new DateTime(2023, 3, 20, 11, 10, 39, 808, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 15, 10, 39, 808, DateTimeKind.Unspecified) },
                    { 51, 8, new DateTime(2023, 5, 22, 17, 6, 12, 47, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 1, 6, 12, 47, DateTimeKind.Unspecified) },
                    { 52, 5, new DateTime(2023, 4, 16, 19, 4, 14, 178, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 0, 4, 14, 178, DateTimeKind.Unspecified) },
                    { 53, 4, new DateTime(2023, 5, 22, 20, 25, 40, 298, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 21, 25, 40, 298, DateTimeKind.Unspecified) },
                    { 54, 8, new DateTime(2023, 5, 30, 0, 0, 41, 934, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 10, 0, 41, 934, DateTimeKind.Unspecified) },
                    { 55, 6, new DateTime(2023, 2, 27, 20, 39, 46, 416, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 3, 39, 46, 416, DateTimeKind.Unspecified) },
                    { 56, 5, new DateTime(2023, 3, 11, 9, 16, 38, 231, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 13, 16, 38, 231, DateTimeKind.Unspecified) },
                    { 57, 2, new DateTime(2023, 4, 13, 0, 24, 44, 141, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 10, 24, 44, 141, DateTimeKind.Unspecified) },
                    { 58, 3, new DateTime(2023, 4, 20, 19, 53, 17, 317, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 23, 53, 17, 317, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 3, 5, 21, 25, 47, 59, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 7, 25, 47, 59, DateTimeKind.Unspecified) },
                    { 60, 3, new DateTime(2023, 4, 19, 7, 47, 29, 353, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 8, 47, 29, 353, DateTimeKind.Unspecified) },
                    { 61, 6, new DateTime(2023, 5, 25, 4, 42, 30, 851, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 5, 42, 30, 851, DateTimeKind.Unspecified) },
                    { 62, 7, new DateTime(2023, 5, 16, 1, 4, 59, 323, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 2, 4, 59, 323, DateTimeKind.Unspecified) },
                    { 63, 4, new DateTime(2023, 5, 9, 14, 57, 52, 773, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 21, 57, 52, 773, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 8, new DateTime(2023, 4, 26, 3, 28, 36, 217, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 8, 28, 36, 217, DateTimeKind.Unspecified) },
                    { 65, 1, new DateTime(2023, 3, 23, 14, 3, 50, 783, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 21, 3, 50, 783, DateTimeKind.Unspecified) },
                    { 66, 2, new DateTime(2023, 4, 13, 15, 59, 2, 422, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 21, 59, 2, 422, DateTimeKind.Unspecified) },
                    { 67, 5, new DateTime(2023, 5, 29, 22, 25, 17, 867, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 23, 25, 17, 867, DateTimeKind.Unspecified) },
                    { 68, 8, new DateTime(2023, 5, 14, 21, 49, 16, 565, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 2, 49, 16, 565, DateTimeKind.Unspecified) },
                    { 69, 3, new DateTime(2023, 4, 21, 10, 49, 51, 256, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 18, 49, 51, 256, DateTimeKind.Unspecified) },
                    { 70, 4, new DateTime(2023, 4, 16, 19, 44, 20, 83, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 4, 44, 20, 83, DateTimeKind.Unspecified) },
                    { 71, 6, new DateTime(2023, 4, 27, 10, 44, 30, 760, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 44, 30, 760, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 4, 26, 3, 3, 10, 602, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 9, 3, 10, 602, DateTimeKind.Unspecified) },
                    { 73, 6, new DateTime(2023, 3, 3, 1, 40, 5, 562, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 10, 40, 5, 562, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2023, 3, 3, 2, 49, 24, 403, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 5, 49, 24, 403, DateTimeKind.Unspecified) },
                    { 75, 1, new DateTime(2023, 5, 27, 4, 40, 12, 577, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 12, 40, 12, 577, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 2, 18, 8, 11, 39, 788, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 9, 11, 39, 788, DateTimeKind.Unspecified) },
                    { 77, 2, new DateTime(2023, 3, 29, 18, 52, 5, 639, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 21, 52, 5, 639, DateTimeKind.Unspecified) },
                    { 78, 1, new DateTime(2023, 2, 21, 10, 44, 0, 945, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 12, 44, 0, 945, DateTimeKind.Unspecified) },
                    { 79, 7, new DateTime(2023, 4, 21, 21, 27, 35, 321, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 3, 27, 35, 321, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2023, 2, 5, 9, 19, 34, 368, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 15, 19, 34, 368, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 5, 2, 17, 32, 27, 940, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 18, 32, 27, 940, DateTimeKind.Unspecified) },
                    { 82, 1, new DateTime(2023, 3, 10, 14, 24, 10, 492, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 21, 24, 10, 492, DateTimeKind.Unspecified) },
                    { 83, 4, new DateTime(2023, 5, 1, 7, 26, 11, 510, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 8, 26, 11, 510, DateTimeKind.Unspecified) },
                    { 84, 6, new DateTime(2023, 5, 23, 3, 4, 8, 433, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 6, 4, 8, 433, DateTimeKind.Unspecified) },
                    { 85, 3, new DateTime(2023, 5, 4, 5, 56, 6, 563, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 8, 56, 6, 563, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2023, 4, 24, 23, 55, 14, 969, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 7, 55, 14, 969, DateTimeKind.Unspecified) },
                    { 87, 8, new DateTime(2023, 5, 11, 20, 14, 9, 450, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 2, 14, 9, 450, DateTimeKind.Unspecified) },
                    { 88, 4, new DateTime(2023, 5, 12, 4, 9, 46, 939, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 6, 9, 46, 939, DateTimeKind.Unspecified) },
                    { 89, 3, new DateTime(2023, 2, 28, 21, 45, 10, 958, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 5, 45, 10, 958, DateTimeKind.Unspecified) },
                    { 90, 8, new DateTime(2023, 2, 25, 12, 11, 3, 432, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 19, 11, 3, 432, DateTimeKind.Unspecified) },
                    { 91, 3, new DateTime(2023, 3, 23, 22, 46, 6, 554, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 2, 46, 6, 554, DateTimeKind.Unspecified) },
                    { 92, 5, new DateTime(2023, 2, 14, 0, 3, 33, 105, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 9, 3, 33, 105, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 4, 8, 4, 53, 59, 446, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 12, 53, 59, 446, DateTimeKind.Unspecified) },
                    { 94, 1, new DateTime(2023, 5, 23, 7, 45, 18, 156, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 8, 45, 18, 156, DateTimeKind.Unspecified) },
                    { 95, 1, new DateTime(2023, 4, 11, 20, 20, 28, 808, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 22, 20, 28, 808, DateTimeKind.Unspecified) },
                    { 96, 7, new DateTime(2023, 2, 2, 8, 24, 42, 174, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 10, 24, 42, 174, DateTimeKind.Unspecified) },
                    { 97, 9, new DateTime(2023, 4, 12, 17, 29, 32, 377, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 23, 29, 32, 377, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2023, 4, 10, 4, 51, 59, 465, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 14, 51, 59, 465, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 5, 11, 18, 21, 47, 825, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 19, 21, 47, 825, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2023, 3, 12, 0, 8, 3, 116, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 4, 8, 3, 116, DateTimeKind.Unspecified) },
                    { 101, 2, new DateTime(2023, 4, 2, 19, 29, 27, 969, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 1, 29, 27, 969, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5721), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(5723), 1198m },
                    { 3, 1, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6522), 699m },
                    { 4, 3, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6571), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 6, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6589), 699m },
                    { 6, 7, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6609), 699m },
                    { 7, 5, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6633), 699m },
                    { 8, 6, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6656), 699m },
                    { 9, 8, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6677), 699m },
                    { 10, 4, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6700), 699m },
                    { 11, 7, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6723), 699m },
                    { 12, 8, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6740), 699m },
                    { 13, 5, false, new DateTime(2023, 5, 8, 20, 35, 46, 988, DateTimeKind.Local).AddTicks(6757), 699m }
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
