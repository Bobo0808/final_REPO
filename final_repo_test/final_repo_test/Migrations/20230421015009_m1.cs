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
                    { 1, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1817), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1818), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1827), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1828), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1733), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1729), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1746), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1745), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1751), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1751), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1757), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1757), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1762), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1762), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1769), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1768), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1774), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1773), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1779), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1779), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1784), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1784), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1790), "Test", 99, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1789), 1, "Test", "Test" }
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
                    { 1, 1, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1623) },
                    { 2, 2, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1663) },
                    { 3, 6, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1665) },
                    { 4, 2, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1667) },
                    { 5, 8, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1668) },
                    { 6, 7, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1670) },
                    { 7, 4, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1672) },
                    { 8, 8, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1673) },
                    { 9, 3, null, "test", true, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1674) },
                    { 10, 4, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1676) },
                    { 11, 3, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1678) },
                    { 12, 2, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1679) },
                    { 13, 9, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1680) },
                    { 14, 2, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1681) },
                    { 15, 2, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1682) },
                    { 16, 9, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1683) },
                    { 17, 9, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1684) },
                    { 18, 8, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1704) },
                    { 19, 4, null, "test", false, new DateTime(2023, 4, 21, 9, 50, 9, 297, DateTimeKind.Local).AddTicks(1705) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 2, 16, 17, 40, 10, 851, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 3, 40, 10, 851, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 2, 13, 19, 48, 42, 750, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 4, 48, 42, 750, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2023, 1, 3, 4, 30, 2, 190, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 5, 30, 2, 190, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2023, 1, 24, 6, 2, 51, 397, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 11, 2, 51, 397, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2023, 4, 19, 17, 49, 3, 171, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 1, 49, 3, 171, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2023, 1, 6, 18, 47, 33, 689, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 20, 47, 33, 689, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 3, 25, 11, 33, 40, 159, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 14, 33, 40, 159, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(2023, 2, 11, 13, 24, 35, 230, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 16, 24, 35, 230, DateTimeKind.Unspecified) },
                    { 9, 8, new DateTime(2023, 2, 11, 0, 0, 8, 308, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 9, 0, 8, 308, DateTimeKind.Unspecified) },
                    { 10, 3, new DateTime(2023, 2, 13, 4, 35, 53, 697, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 11, 35, 53, 697, DateTimeKind.Unspecified) },
                    { 11, 9, new DateTime(2023, 4, 8, 22, 35, 8, 806, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 23, 35, 8, 806, DateTimeKind.Unspecified) },
                    { 12, 5, new DateTime(2023, 4, 23, 14, 32, 19, 299, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 22, 32, 19, 299, DateTimeKind.Unspecified) },
                    { 13, 4, new DateTime(2023, 1, 19, 15, 11, 46, 834, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 18, 11, 46, 834, DateTimeKind.Unspecified) },
                    { 14, 5, new DateTime(2023, 1, 23, 11, 52, 7, 991, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 18, 52, 7, 991, DateTimeKind.Unspecified) },
                    { 15, 9, new DateTime(2023, 2, 24, 5, 13, 4, 69, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 15, 13, 4, 69, DateTimeKind.Unspecified) },
                    { 16, 9, new DateTime(2023, 1, 27, 2, 53, 5, 182, DateTimeKind.Unspecified), new DateTime(2023, 1, 27, 4, 53, 5, 182, DateTimeKind.Unspecified) },
                    { 17, 9, new DateTime(2023, 1, 19, 11, 5, 14, 845, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 20, 5, 14, 845, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2023, 4, 29, 15, 36, 59, 649, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 18, 36, 59, 649, DateTimeKind.Unspecified) },
                    { 19, 7, new DateTime(2023, 3, 27, 12, 35, 15, 820, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 14, 35, 15, 820, DateTimeKind.Unspecified) },
                    { 20, 9, new DateTime(2023, 3, 5, 14, 16, 58, 936, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 20, 16, 58, 936, DateTimeKind.Unspecified) },
                    { 21, 7, new DateTime(2023, 3, 6, 14, 22, 13, 182, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 15, 22, 13, 182, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 3, new DateTime(2023, 2, 18, 20, 28, 36, 884, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 0, 28, 36, 884, DateTimeKind.Unspecified) },
                    { 23, 4, new DateTime(2023, 2, 13, 8, 39, 20, 143, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 39, 20, 143, DateTimeKind.Unspecified) },
                    { 24, 6, new DateTime(2023, 4, 19, 23, 41, 36, 462, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 7, 41, 36, 462, DateTimeKind.Unspecified) },
                    { 25, 8, new DateTime(2023, 2, 6, 15, 21, 52, 226, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 19, 21, 52, 226, DateTimeKind.Unspecified) },
                    { 26, 6, new DateTime(2023, 3, 7, 13, 43, 58, 668, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 19, 43, 58, 668, DateTimeKind.Unspecified) },
                    { 27, 5, new DateTime(2023, 3, 28, 20, 27, 58, 914, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 6, 27, 58, 914, DateTimeKind.Unspecified) },
                    { 28, 8, new DateTime(2023, 4, 23, 0, 24, 53, 841, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 1, 24, 53, 841, DateTimeKind.Unspecified) },
                    { 29, 6, new DateTime(2023, 3, 4, 13, 7, 49, 23, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 22, 7, 49, 23, DateTimeKind.Unspecified) },
                    { 30, 4, new DateTime(2023, 1, 1, 15, 19, 5, 67, DateTimeKind.Unspecified), new DateTime(2023, 1, 2, 0, 19, 5, 67, DateTimeKind.Unspecified) },
                    { 31, 8, new DateTime(2023, 1, 26, 5, 43, 54, 925, DateTimeKind.Unspecified), new DateTime(2023, 1, 26, 14, 43, 54, 925, DateTimeKind.Unspecified) },
                    { 32, 6, new DateTime(2023, 2, 5, 7, 42, 52, 937, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 17, 42, 52, 937, DateTimeKind.Unspecified) },
                    { 33, 8, new DateTime(2023, 3, 19, 1, 49, 47, 133, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 4, 49, 47, 133, DateTimeKind.Unspecified) },
                    { 34, 9, new DateTime(2023, 3, 22, 15, 56, 1, 33, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 22, 56, 1, 33, DateTimeKind.Unspecified) },
                    { 35, 5, new DateTime(2023, 4, 30, 4, 37, 17, 980, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 6, 37, 17, 980, DateTimeKind.Unspecified) },
                    { 36, 6, new DateTime(2023, 4, 15, 3, 43, 45, 177, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 12, 43, 45, 177, DateTimeKind.Unspecified) },
                    { 37, 9, new DateTime(2023, 4, 12, 0, 5, 54, 652, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 1, 5, 54, 652, DateTimeKind.Unspecified) },
                    { 38, 7, new DateTime(2023, 4, 16, 3, 17, 45, 227, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 10, 17, 45, 227, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 1, 28, 7, 4, 21, 600, DateTimeKind.Unspecified), new DateTime(2023, 1, 28, 8, 4, 21, 600, DateTimeKind.Unspecified) },
                    { 40, 7, new DateTime(2023, 4, 1, 22, 28, 18, 186, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 0, 28, 18, 186, DateTimeKind.Unspecified) },
                    { 41, 8, new DateTime(2023, 1, 25, 1, 32, 38, 195, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 7, 32, 38, 195, DateTimeKind.Unspecified) },
                    { 42, 3, new DateTime(2023, 3, 15, 17, 54, 59, 69, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 21, 54, 59, 69, DateTimeKind.Unspecified) },
                    { 43, 8, new DateTime(2023, 4, 24, 0, 26, 38, 855, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 3, 26, 38, 855, DateTimeKind.Unspecified) },
                    { 44, 9, new DateTime(2023, 1, 14, 4, 56, 31, 643, DateTimeKind.Unspecified), new DateTime(2023, 1, 14, 10, 56, 31, 643, DateTimeKind.Unspecified) },
                    { 45, 9, new DateTime(2023, 4, 22, 6, 6, 15, 807, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 16, 6, 15, 807, DateTimeKind.Unspecified) },
                    { 46, 3, new DateTime(2023, 1, 28, 0, 51, 14, 930, DateTimeKind.Unspecified), new DateTime(2023, 1, 28, 9, 51, 14, 930, DateTimeKind.Unspecified) },
                    { 47, 2, new DateTime(2023, 2, 21, 3, 12, 39, 438, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 9, 12, 39, 438, DateTimeKind.Unspecified) },
                    { 48, 2, new DateTime(2023, 2, 17, 23, 4, 57, 429, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 3, 4, 57, 429, DateTimeKind.Unspecified) },
                    { 49, 3, new DateTime(2023, 3, 27, 12, 12, 30, 732, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 21, 12, 30, 732, DateTimeKind.Unspecified) },
                    { 50, 3, new DateTime(2023, 1, 13, 4, 16, 42, 709, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 11, 16, 42, 709, DateTimeKind.Unspecified) },
                    { 51, 7, new DateTime(2023, 4, 20, 0, 49, 59, 673, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 5, 49, 59, 673, DateTimeKind.Unspecified) },
                    { 52, 3, new DateTime(2023, 3, 31, 21, 35, 41, 874, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 3, 35, 41, 874, DateTimeKind.Unspecified) },
                    { 53, 2, new DateTime(2023, 4, 2, 5, 24, 55, 840, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 6, 24, 55, 840, DateTimeKind.Unspecified) },
                    { 54, 6, new DateTime(2023, 4, 6, 21, 15, 46, 263, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 1, 15, 46, 263, DateTimeKind.Unspecified) },
                    { 55, 4, new DateTime(2023, 3, 27, 20, 50, 31, 29, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 3, 50, 31, 29, DateTimeKind.Unspecified) },
                    { 56, 7, new DateTime(2023, 2, 14, 16, 18, 1, 155, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 21, 18, 1, 155, DateTimeKind.Unspecified) },
                    { 57, 5, new DateTime(2023, 3, 12, 17, 11, 42, 941, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 1, 11, 42, 941, DateTimeKind.Unspecified) },
                    { 58, 2, new DateTime(2023, 2, 10, 4, 39, 59, 310, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 11, 39, 59, 310, DateTimeKind.Unspecified) },
                    { 59, 9, new DateTime(2023, 1, 31, 12, 12, 58, 231, DateTimeKind.Unspecified), new DateTime(2023, 1, 31, 20, 12, 58, 231, DateTimeKind.Unspecified) },
                    { 60, 6, new DateTime(2023, 2, 18, 3, 44, 30, 299, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 4, 44, 30, 299, DateTimeKind.Unspecified) },
                    { 61, 7, new DateTime(2023, 4, 14, 3, 54, 21, 795, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 4, 54, 21, 795, DateTimeKind.Unspecified) },
                    { 62, 5, new DateTime(2023, 3, 24, 11, 23, 8, 428, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 18, 23, 8, 428, DateTimeKind.Unspecified) },
                    { 63, 4, new DateTime(2023, 1, 13, 9, 29, 12, 998, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 19, 29, 12, 998, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 3, new DateTime(2023, 1, 21, 20, 53, 2, 974, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 22, 53, 2, 974, DateTimeKind.Unspecified) },
                    { 65, 8, new DateTime(2023, 3, 6, 14, 43, 27, 944, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 18, 43, 27, 944, DateTimeKind.Unspecified) },
                    { 66, 8, new DateTime(2023, 1, 4, 11, 43, 16, 851, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 16, 43, 16, 851, DateTimeKind.Unspecified) },
                    { 67, 7, new DateTime(2023, 3, 16, 5, 9, 33, 368, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 12, 9, 33, 368, DateTimeKind.Unspecified) },
                    { 68, 3, new DateTime(2023, 3, 25, 17, 30, 5, 978, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 3, 30, 5, 978, DateTimeKind.Unspecified) },
                    { 69, 1, new DateTime(2023, 4, 13, 22, 27, 36, 902, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 1, 27, 36, 902, DateTimeKind.Unspecified) },
                    { 70, 4, new DateTime(2023, 3, 13, 9, 59, 5, 574, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 16, 59, 5, 574, DateTimeKind.Unspecified) },
                    { 71, 6, new DateTime(2023, 4, 11, 14, 14, 1, 858, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 18, 14, 1, 858, DateTimeKind.Unspecified) },
                    { 72, 4, new DateTime(2023, 1, 19, 0, 30, 26, 303, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 9, 30, 26, 303, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 3, 5, 21, 19, 7, 310, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 22, 19, 7, 310, DateTimeKind.Unspecified) },
                    { 74, 3, new DateTime(2023, 4, 16, 16, 8, 9, 386, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 20, 8, 9, 386, DateTimeKind.Unspecified) },
                    { 75, 4, new DateTime(2023, 4, 20, 9, 3, 53, 232, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 18, 3, 53, 232, DateTimeKind.Unspecified) },
                    { 76, 5, new DateTime(2023, 4, 3, 23, 5, 36, 198, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 6, 5, 36, 198, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 4, 18, 5, 18, 45, 918, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 11, 18, 45, 918, DateTimeKind.Unspecified) },
                    { 78, 7, new DateTime(2023, 4, 4, 10, 38, 12, 88, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 16, 38, 12, 88, DateTimeKind.Unspecified) },
                    { 79, 6, new DateTime(2023, 3, 20, 6, 38, 57, 313, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 13, 38, 57, 313, DateTimeKind.Unspecified) },
                    { 80, 8, new DateTime(2023, 1, 28, 21, 29, 36, 505, DateTimeKind.Unspecified), new DateTime(2023, 1, 29, 2, 29, 36, 505, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 2, 15, 21, 29, 24, 297, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 3, 29, 24, 297, DateTimeKind.Unspecified) },
                    { 82, 9, new DateTime(2023, 1, 8, 21, 52, 23, 72, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 6, 52, 23, 72, DateTimeKind.Unspecified) },
                    { 83, 9, new DateTime(2023, 2, 5, 14, 54, 38, 153, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 19, 54, 38, 153, DateTimeKind.Unspecified) },
                    { 84, 3, new DateTime(2023, 4, 11, 11, 56, 48, 712, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 14, 56, 48, 712, DateTimeKind.Unspecified) },
                    { 85, 6, new DateTime(2023, 2, 5, 5, 57, 16, 431, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 10, 57, 16, 431, DateTimeKind.Unspecified) },
                    { 86, 5, new DateTime(2023, 1, 12, 11, 49, 32, 724, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 17, 49, 32, 724, DateTimeKind.Unspecified) },
                    { 87, 6, new DateTime(2023, 1, 15, 21, 44, 34, 978, DateTimeKind.Unspecified), new DateTime(2023, 1, 16, 2, 44, 34, 978, DateTimeKind.Unspecified) },
                    { 88, 1, new DateTime(2023, 1, 8, 10, 9, 33, 99, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 16, 9, 33, 99, DateTimeKind.Unspecified) },
                    { 89, 7, new DateTime(2023, 4, 10, 21, 11, 18, 181, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 5, 11, 18, 181, DateTimeKind.Unspecified) },
                    { 90, 4, new DateTime(2023, 1, 4, 19, 46, 27, 260, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 21, 46, 27, 260, DateTimeKind.Unspecified) },
                    { 91, 3, new DateTime(2023, 1, 20, 13, 15, 21, 871, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 18, 15, 21, 871, DateTimeKind.Unspecified) },
                    { 92, 9, new DateTime(2023, 4, 29, 19, 24, 45, 936, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 3, 24, 45, 936, DateTimeKind.Unspecified) },
                    { 93, 9, new DateTime(2023, 2, 28, 4, 42, 57, 794, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 9, 42, 57, 794, DateTimeKind.Unspecified) },
                    { 94, 3, new DateTime(2023, 2, 13, 19, 10, 47, 408, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 5, 10, 47, 408, DateTimeKind.Unspecified) },
                    { 95, 9, new DateTime(2023, 1, 17, 23, 0, 55, 900, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 8, 0, 55, 900, DateTimeKind.Unspecified) },
                    { 96, 1, new DateTime(2023, 2, 23, 8, 53, 46, 739, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 17, 53, 46, 739, DateTimeKind.Unspecified) },
                    { 97, 6, new DateTime(2023, 3, 13, 15, 47, 20, 939, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 1, 47, 20, 939, DateTimeKind.Unspecified) },
                    { 98, 9, new DateTime(2023, 2, 22, 4, 23, 7, 811, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 13, 23, 7, 811, DateTimeKind.Unspecified) },
                    { 99, 9, new DateTime(2023, 1, 15, 0, 16, 43, 121, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 7, 16, 43, 121, DateTimeKind.Unspecified) },
                    { 100, 2, new DateTime(2023, 4, 15, 15, 3, 7, 897, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 22, 3, 7, 897, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 2, 11, 4, 2, 24, 30, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 10, 2, 24, 30, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1838), 2396m },
                    { 2, 1, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1838), 1198m },
                    { 3, 4, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1910), 699m },
                    { 4, 6, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1922), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 6, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1941), 699m },
                    { 6, 2, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1951), 699m },
                    { 7, 8, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1960), 699m },
                    { 8, 7, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1968), 699m },
                    { 9, 9, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1983), 699m },
                    { 10, 6, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(1992), 699m },
                    { 11, 8, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(2000), 699m },
                    { 12, 7, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(2009), 699m },
                    { 13, 3, false, new DateTime(2023, 4, 21, 9, 50, 9, 298, DateTimeKind.Local).AddTicks(2024), 699m }
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
