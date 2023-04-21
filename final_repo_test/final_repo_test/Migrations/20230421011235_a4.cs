using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class a4 : Migration
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
                    { 1, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7603), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7604), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7615), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7618), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7497), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7494), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7509), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7509), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7515), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7515), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7540), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7540), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7546), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7546), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7552), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7552), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7558), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7557), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7563), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7563), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7568), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7568), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7574), "Test", 99, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7573), 1, "Test", "Test" }
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
                    { 1, 4, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7173) },
                    { 2, 5, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7238) },
                    { 3, 9, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7240) },
                    { 4, 4, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7242) },
                    { 5, 1, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7244) },
                    { 6, 10, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7246) },
                    { 7, 10, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7248) },
                    { 8, 4, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7249) },
                    { 9, 7, null, "test", true, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7251) },
                    { 10, 5, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7253) },
                    { 11, 8, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7255) },
                    { 12, 7, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7257) },
                    { 13, 6, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7258) },
                    { 14, 5, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7259) },
                    { 15, 3, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7261) },
                    { 16, 5, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7263) },
                    { 17, 9, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7264) },
                    { 18, 10, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7266) },
                    { 19, 6, null, "test", false, new DateTime(2023, 4, 21, 9, 12, 35, 731, DateTimeKind.Local).AddTicks(7267) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 3, 11, 13, 24, 53, 272, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 15, 24, 53, 272, DateTimeKind.Unspecified) },
                    { 2, 6, new DateTime(2023, 1, 6, 23, 32, 16, 912, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 7, 32, 16, 912, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 4, 7, 18, 24, 24, 514, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 20, 24, 24, 514, DateTimeKind.Unspecified) },
                    { 4, 6, new DateTime(2023, 4, 27, 16, 7, 3, 827, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 18, 7, 3, 827, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2023, 1, 18, 7, 22, 49, 744, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 14, 22, 49, 744, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2023, 4, 6, 8, 10, 30, 501, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 15, 10, 30, 501, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2023, 4, 4, 21, 2, 15, 718, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 4, 2, 15, 718, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2023, 3, 28, 3, 10, 57, 80, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 8, 10, 57, 80, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2023, 4, 13, 9, 1, 54, 799, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 13, 1, 54, 799, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(2023, 3, 24, 9, 11, 40, 428, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 17, 11, 40, 428, DateTimeKind.Unspecified) },
                    { 11, 5, new DateTime(2023, 4, 2, 7, 36, 3, 173, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 16, 36, 3, 173, DateTimeKind.Unspecified) },
                    { 12, 4, new DateTime(2023, 2, 19, 5, 17, 1, 62, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 10, 17, 1, 62, DateTimeKind.Unspecified) },
                    { 13, 7, new DateTime(2023, 4, 26, 4, 6, 4, 917, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 12, 6, 4, 917, DateTimeKind.Unspecified) },
                    { 14, 9, new DateTime(2023, 4, 16, 5, 41, 37, 259, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 8, 41, 37, 259, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 4, 11, 8, 13, 28, 107, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 14, 13, 28, 107, DateTimeKind.Unspecified) },
                    { 16, 3, new DateTime(2023, 4, 10, 17, 19, 50, 205, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 0, 19, 50, 205, DateTimeKind.Unspecified) },
                    { 17, 3, new DateTime(2023, 4, 23, 23, 24, 51, 348, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 7, 24, 51, 348, DateTimeKind.Unspecified) },
                    { 18, 7, new DateTime(2023, 2, 21, 0, 57, 17, 741, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 5, 57, 17, 741, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 4, 20, 9, 5, 1, 538, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 19, 5, 1, 538, DateTimeKind.Unspecified) },
                    { 20, 4, new DateTime(2023, 1, 16, 15, 0, 28, 957, DateTimeKind.Unspecified), new DateTime(2023, 1, 16, 17, 0, 28, 957, DateTimeKind.Unspecified) },
                    { 21, 8, new DateTime(2023, 2, 13, 11, 0, 55, 766, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 17, 0, 55, 766, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 1, new DateTime(2023, 3, 25, 0, 0, 38, 349, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 4, 0, 38, 349, DateTimeKind.Unspecified) },
                    { 23, 9, new DateTime(2023, 2, 23, 17, 26, 10, 890, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 19, 26, 10, 890, DateTimeKind.Unspecified) },
                    { 24, 2, new DateTime(2023, 3, 15, 6, 4, 33, 176, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 9, 4, 33, 176, DateTimeKind.Unspecified) },
                    { 25, 7, new DateTime(2023, 3, 26, 17, 36, 17, 435, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 23, 36, 17, 435, DateTimeKind.Unspecified) },
                    { 26, 9, new DateTime(2023, 2, 4, 20, 18, 55, 89, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 6, 18, 55, 89, DateTimeKind.Unspecified) },
                    { 27, 5, new DateTime(2023, 4, 29, 6, 36, 3, 757, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 8, 36, 3, 757, DateTimeKind.Unspecified) },
                    { 28, 3, new DateTime(2023, 3, 19, 5, 50, 48, 370, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 10, 50, 48, 370, DateTimeKind.Unspecified) },
                    { 29, 7, new DateTime(2023, 2, 25, 12, 16, 43, 608, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 18, 16, 43, 608, DateTimeKind.Unspecified) },
                    { 30, 8, new DateTime(2023, 2, 10, 13, 9, 6, 607, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 17, 9, 6, 607, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2023, 4, 1, 18, 58, 3, 133, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 20, 58, 3, 133, DateTimeKind.Unspecified) },
                    { 32, 5, new DateTime(2023, 4, 17, 7, 28, 0, 452, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 14, 28, 0, 452, DateTimeKind.Unspecified) },
                    { 33, 7, new DateTime(2023, 4, 17, 5, 39, 53, 501, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 7, 39, 53, 501, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2023, 3, 13, 11, 38, 58, 437, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 17, 38, 58, 437, DateTimeKind.Unspecified) },
                    { 35, 6, new DateTime(2023, 4, 9, 19, 23, 57, 571, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 3, 23, 57, 571, DateTimeKind.Unspecified) },
                    { 36, 5, new DateTime(2023, 3, 28, 8, 5, 37, 429, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 9, 5, 37, 429, DateTimeKind.Unspecified) },
                    { 37, 3, new DateTime(2023, 1, 5, 2, 15, 15, 879, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 10, 15, 15, 879, DateTimeKind.Unspecified) },
                    { 38, 9, new DateTime(2023, 2, 9, 13, 53, 25, 511, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 21, 53, 25, 511, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 2, 12, 14, 39, 1, 131, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 15, 39, 1, 131, DateTimeKind.Unspecified) },
                    { 40, 6, new DateTime(2023, 2, 13, 18, 3, 6, 906, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 4, 3, 6, 906, DateTimeKind.Unspecified) },
                    { 41, 8, new DateTime(2023, 2, 15, 0, 55, 3, 202, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 2, 55, 3, 202, DateTimeKind.Unspecified) },
                    { 42, 1, new DateTime(2023, 2, 23, 11, 49, 6, 868, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 14, 49, 6, 868, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 1, 13, 2, 59, 47, 242, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 11, 59, 47, 242, DateTimeKind.Unspecified) },
                    { 44, 2, new DateTime(2023, 4, 13, 4, 38, 16, 453, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 11, 38, 16, 453, DateTimeKind.Unspecified) },
                    { 45, 7, new DateTime(2023, 2, 11, 8, 23, 50, 860, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 9, 23, 50, 860, DateTimeKind.Unspecified) },
                    { 46, 3, new DateTime(2023, 4, 20, 8, 54, 0, 866, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 12, 54, 0, 866, DateTimeKind.Unspecified) },
                    { 47, 9, new DateTime(2023, 2, 10, 17, 47, 20, 183, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 2, 47, 20, 183, DateTimeKind.Unspecified) },
                    { 48, 6, new DateTime(2023, 2, 24, 13, 0, 40, 449, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 20, 0, 40, 449, DateTimeKind.Unspecified) },
                    { 49, 1, new DateTime(2023, 2, 24, 13, 15, 18, 790, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 21, 15, 18, 790, DateTimeKind.Unspecified) },
                    { 50, 9, new DateTime(2023, 4, 2, 10, 20, 24, 884, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 19, 20, 24, 884, DateTimeKind.Unspecified) },
                    { 51, 2, new DateTime(2023, 3, 18, 0, 10, 28, 985, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 5, 10, 28, 985, DateTimeKind.Unspecified) },
                    { 52, 9, new DateTime(2023, 3, 26, 22, 54, 16, 338, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 8, 54, 16, 338, DateTimeKind.Unspecified) },
                    { 53, 9, new DateTime(2023, 4, 30, 1, 56, 44, 588, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 11, 56, 44, 588, DateTimeKind.Unspecified) },
                    { 54, 2, new DateTime(2023, 2, 26, 9, 39, 6, 792, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 11, 39, 6, 792, DateTimeKind.Unspecified) },
                    { 55, 6, new DateTime(2023, 4, 5, 8, 35, 7, 894, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 13, 35, 7, 894, DateTimeKind.Unspecified) },
                    { 56, 4, new DateTime(2023, 2, 1, 18, 4, 21, 479, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 4, 4, 21, 479, DateTimeKind.Unspecified) },
                    { 57, 2, new DateTime(2023, 2, 17, 19, 26, 13, 500, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 4, 26, 13, 500, DateTimeKind.Unspecified) },
                    { 58, 3, new DateTime(2023, 4, 30, 17, 9, 45, 158, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 19, 9, 45, 158, DateTimeKind.Unspecified) },
                    { 59, 7, new DateTime(2023, 1, 12, 21, 8, 19, 342, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 4, 8, 19, 342, DateTimeKind.Unspecified) },
                    { 60, 9, new DateTime(2023, 1, 8, 13, 56, 19, 187, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 22, 56, 19, 187, DateTimeKind.Unspecified) },
                    { 61, 4, new DateTime(2023, 2, 12, 22, 52, 24, 286, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 52, 24, 286, DateTimeKind.Unspecified) },
                    { 62, 7, new DateTime(2023, 1, 4, 6, 37, 51, 226, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 8, 37, 51, 226, DateTimeKind.Unspecified) },
                    { 63, 5, new DateTime(2023, 1, 4, 6, 28, 46, 545, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 8, 28, 46, 545, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 6, new DateTime(2023, 4, 25, 15, 31, 15, 869, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 1, 31, 15, 869, DateTimeKind.Unspecified) },
                    { 65, 9, new DateTime(2023, 4, 9, 23, 35, 44, 477, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 4, 35, 44, 477, DateTimeKind.Unspecified) },
                    { 66, 6, new DateTime(2023, 3, 13, 9, 20, 14, 142, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 18, 20, 14, 142, DateTimeKind.Unspecified) },
                    { 67, 7, new DateTime(2023, 2, 23, 15, 22, 19, 240, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 20, 22, 19, 240, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2023, 4, 21, 20, 23, 0, 912, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 5, 23, 0, 912, DateTimeKind.Unspecified) },
                    { 69, 9, new DateTime(2023, 3, 13, 8, 46, 33, 301, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 17, 46, 33, 301, DateTimeKind.Unspecified) },
                    { 70, 1, new DateTime(2023, 1, 18, 14, 31, 52, 375, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 18, 31, 52, 375, DateTimeKind.Unspecified) },
                    { 71, 5, new DateTime(2023, 1, 16, 23, 44, 54, 267, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 1, 44, 54, 267, DateTimeKind.Unspecified) },
                    { 72, 3, new DateTime(2023, 3, 10, 9, 27, 49, 435, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 10, 27, 49, 435, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 2, 15, 6, 21, 23, 465, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 11, 21, 23, 465, DateTimeKind.Unspecified) },
                    { 74, 8, new DateTime(2023, 2, 7, 18, 28, 18, 690, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 23, 28, 18, 690, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 4, 25, 12, 5, 18, 380, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 15, 5, 18, 380, DateTimeKind.Unspecified) },
                    { 76, 9, new DateTime(2023, 2, 22, 18, 9, 15, 781, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 1, 9, 15, 781, DateTimeKind.Unspecified) },
                    { 77, 4, new DateTime(2023, 4, 21, 2, 30, 15, 454, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 3, 30, 15, 454, DateTimeKind.Unspecified) },
                    { 78, 2, new DateTime(2023, 1, 8, 23, 42, 40, 326, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 3, 42, 40, 326, DateTimeKind.Unspecified) },
                    { 79, 9, new DateTime(2023, 4, 10, 5, 52, 51, 105, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 7, 52, 51, 105, DateTimeKind.Unspecified) },
                    { 80, 9, new DateTime(2023, 1, 9, 23, 0, 34, 634, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 9, 0, 34, 634, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 1, 13, 13, 3, 44, 274, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 19, 3, 44, 274, DateTimeKind.Unspecified) },
                    { 82, 5, new DateTime(2023, 3, 21, 1, 25, 1, 894, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 11, 25, 1, 894, DateTimeKind.Unspecified) },
                    { 83, 7, new DateTime(2023, 3, 1, 19, 0, 36, 143, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 22, 0, 36, 143, DateTimeKind.Unspecified) },
                    { 84, 5, new DateTime(2023, 4, 30, 15, 21, 48, 779, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 1, 21, 48, 779, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 3, 29, 14, 56, 26, 349, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 18, 56, 26, 349, DateTimeKind.Unspecified) },
                    { 86, 3, new DateTime(2023, 3, 23, 6, 4, 30, 632, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 10, 4, 30, 632, DateTimeKind.Unspecified) },
                    { 87, 5, new DateTime(2023, 4, 6, 18, 24, 17, 523, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 23, 24, 17, 523, DateTimeKind.Unspecified) },
                    { 88, 9, new DateTime(2023, 2, 6, 20, 18, 54, 85, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 4, 18, 54, 85, DateTimeKind.Unspecified) },
                    { 89, 7, new DateTime(2023, 4, 20, 13, 28, 57, 268, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 15, 28, 57, 268, DateTimeKind.Unspecified) },
                    { 90, 8, new DateTime(2023, 3, 28, 11, 1, 4, 498, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 17, 1, 4, 498, DateTimeKind.Unspecified) },
                    { 91, 8, new DateTime(2023, 1, 10, 14, 3, 25, 980, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 21, 3, 25, 980, DateTimeKind.Unspecified) },
                    { 92, 6, new DateTime(2023, 3, 10, 19, 10, 9, 740, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 1, 10, 9, 740, DateTimeKind.Unspecified) },
                    { 93, 1, new DateTime(2023, 2, 14, 5, 31, 43, 139, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 6, 31, 43, 139, DateTimeKind.Unspecified) },
                    { 94, 3, new DateTime(2023, 1, 12, 3, 20, 25, 372, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 11, 20, 25, 372, DateTimeKind.Unspecified) },
                    { 95, 2, new DateTime(2023, 2, 20, 5, 35, 38, 292, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 6, 35, 38, 292, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 3, 11, 18, 44, 25, 552, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 0, 44, 25, 552, DateTimeKind.Unspecified) },
                    { 97, 4, new DateTime(2023, 3, 21, 14, 29, 1, 411, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 23, 29, 1, 411, DateTimeKind.Unspecified) },
                    { 98, 3, new DateTime(2023, 4, 8, 21, 26, 50, 415, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 0, 26, 50, 415, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 2, 21, 20, 55, 22, 653, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 0, 55, 22, 653, DateTimeKind.Unspecified) },
                    { 100, 3, new DateTime(2023, 4, 9, 22, 35, 30, 856, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 6, 35, 30, 856, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 4, 28, 16, 49, 9, 814, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 18, 49, 9, 814, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7627), 2396m },
                    { 2, 1, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7629), 1198m },
                    { 3, 5, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7705), 699m },
                    { 4, 4, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7718), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 4, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7739), 699m },
                    { 6, 3, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7749), 699m },
                    { 7, 2, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7758), 699m },
                    { 8, 2, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7768), 699m },
                    { 9, 3, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7785), 699m },
                    { 10, 1, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7794), 699m },
                    { 11, 7, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7803), 699m },
                    { 12, 7, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7812), 699m },
                    { 13, 3, false, new DateTime(2023, 4, 21, 9, 12, 35, 732, DateTimeKind.Local).AddTicks(7828), 699m }
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
