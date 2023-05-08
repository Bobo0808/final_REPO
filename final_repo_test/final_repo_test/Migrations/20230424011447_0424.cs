using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class _0424 : Migration
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
                    { 1, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5780), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5782), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5791), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5793), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5688), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5684), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5707), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5706), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5713), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5713), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5718), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5717), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5722), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5722), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5729), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5728), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5733), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5733), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5738), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5737), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5742), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5742), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5748), "Test", 99, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5747), 1, "Test", "Test" }
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
                    { 1, 9, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3590) },
                    { 2, 8, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3659) },
                    { 3, 4, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3660) },
                    { 4, 4, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3661) },
                    { 5, 4, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3663) },
                    { 6, 6, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3665) },
                    { 7, 8, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3666) },
                    { 8, 10, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3668) },
                    { 9, 4, null, "test", true, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3669) },
                    { 10, 3, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3671) },
                    { 11, 9, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3673) },
                    { 12, 8, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3674) },
                    { 13, 4, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3675) },
                    { 14, 6, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3676) },
                    { 15, 7, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3677) },
                    { 16, 10, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3678) },
                    { 17, 10, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3679) },
                    { 18, 6, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3707) },
                    { 19, 2, null, "test", false, new DateTime(2023, 4, 24, 9, 14, 47, 691, DateTimeKind.Local).AddTicks(3709) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 31, 17, 21, 30, 329, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 1, 21, 30, 329, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(2023, 3, 24, 17, 20, 3, 758, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 19, 20, 3, 758, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2023, 1, 8, 23, 39, 12, 754, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 8, 39, 12, 754, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 1, 28, 5, 57, 43, 851, DateTimeKind.Unspecified), new DateTime(2023, 1, 28, 11, 57, 43, 851, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(2023, 3, 23, 21, 8, 58, 224, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 6, 8, 58, 224, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(2023, 2, 20, 1, 26, 57, 17, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 6, 26, 57, 17, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 2, 1, 18, 59, 3, 709, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 4, 59, 3, 709, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2023, 4, 22, 0, 51, 33, 543, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 10, 51, 33, 543, DateTimeKind.Unspecified) },
                    { 9, 6, new DateTime(2023, 1, 1, 6, 44, 23, 383, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 16, 44, 23, 383, DateTimeKind.Unspecified) },
                    { 10, 8, new DateTime(2023, 3, 19, 22, 12, 30, 279, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 2, 12, 30, 279, DateTimeKind.Unspecified) },
                    { 11, 4, new DateTime(2023, 4, 19, 16, 10, 24, 983, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 22, 10, 24, 983, DateTimeKind.Unspecified) },
                    { 12, 6, new DateTime(2023, 1, 15, 2, 30, 13, 16, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 6, 30, 13, 16, DateTimeKind.Unspecified) },
                    { 13, 6, new DateTime(2023, 3, 23, 15, 22, 25, 87, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 17, 22, 25, 87, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 4, 17, 4, 44, 59, 243, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 9, 44, 59, 243, DateTimeKind.Unspecified) },
                    { 15, 3, new DateTime(2023, 3, 30, 14, 16, 20, 874, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 19, 16, 20, 874, DateTimeKind.Unspecified) },
                    { 16, 8, new DateTime(2023, 4, 2, 8, 55, 34, 171, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 10, 55, 34, 171, DateTimeKind.Unspecified) },
                    { 17, 6, new DateTime(2023, 4, 13, 4, 35, 34, 228, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 9, 35, 34, 228, DateTimeKind.Unspecified) },
                    { 18, 7, new DateTime(2023, 4, 13, 11, 52, 28, 806, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 21, 52, 28, 806, DateTimeKind.Unspecified) },
                    { 19, 6, new DateTime(2023, 4, 14, 9, 45, 6, 11, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 16, 45, 6, 11, DateTimeKind.Unspecified) },
                    { 20, 6, new DateTime(2023, 1, 31, 23, 1, 53, 849, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 1, 1, 53, 849, DateTimeKind.Unspecified) },
                    { 21, 9, new DateTime(2023, 1, 4, 8, 23, 40, 843, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 12, 23, 40, 843, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 7, new DateTime(2023, 1, 4, 13, 33, 12, 639, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 14, 33, 12, 639, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2023, 1, 5, 7, 11, 0, 975, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 13, 11, 0, 975, DateTimeKind.Unspecified) },
                    { 24, 8, new DateTime(2023, 4, 28, 12, 37, 13, 323, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 18, 37, 13, 323, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2023, 1, 13, 18, 32, 49, 776, DateTimeKind.Unspecified), new DateTime(2023, 1, 14, 0, 32, 49, 776, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2023, 3, 15, 18, 20, 15, 821, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 23, 20, 15, 821, DateTimeKind.Unspecified) },
                    { 27, 3, new DateTime(2023, 3, 29, 2, 23, 17, 120, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 12, 23, 17, 120, DateTimeKind.Unspecified) },
                    { 28, 8, new DateTime(2023, 2, 11, 21, 15, 45, 625, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 5, 15, 45, 625, DateTimeKind.Unspecified) },
                    { 29, 5, new DateTime(2023, 4, 21, 7, 31, 10, 445, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 13, 31, 10, 445, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2023, 4, 19, 15, 42, 27, 791, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 16, 42, 27, 791, DateTimeKind.Unspecified) },
                    { 31, 4, new DateTime(2023, 3, 21, 2, 39, 12, 863, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 8, 39, 12, 863, DateTimeKind.Unspecified) },
                    { 32, 2, new DateTime(2023, 3, 9, 16, 8, 31, 515, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 19, 8, 31, 515, DateTimeKind.Unspecified) },
                    { 33, 1, new DateTime(2023, 3, 6, 17, 39, 54, 732, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 23, 39, 54, 732, DateTimeKind.Unspecified) },
                    { 34, 9, new DateTime(2023, 4, 23, 22, 5, 56, 666, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 23, 5, 56, 666, DateTimeKind.Unspecified) },
                    { 35, 3, new DateTime(2023, 3, 8, 10, 26, 10, 629, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 19, 26, 10, 629, DateTimeKind.Unspecified) },
                    { 36, 1, new DateTime(2023, 2, 18, 1, 8, 32, 190, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 8, 8, 32, 190, DateTimeKind.Unspecified) },
                    { 37, 5, new DateTime(2023, 4, 2, 18, 23, 38, 645, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 0, 23, 38, 645, DateTimeKind.Unspecified) },
                    { 38, 4, new DateTime(2023, 1, 17, 8, 1, 11, 431, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 15, 1, 11, 431, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 2, 8, 23, 6, 22, 23, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 6, 6, 22, 23, DateTimeKind.Unspecified) },
                    { 40, 7, new DateTime(2023, 2, 18, 5, 44, 4, 335, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 6, 44, 4, 335, DateTimeKind.Unspecified) },
                    { 41, 8, new DateTime(2023, 2, 5, 14, 48, 55, 610, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 15, 48, 55, 610, DateTimeKind.Unspecified) },
                    { 42, 2, new DateTime(2023, 4, 12, 10, 39, 42, 920, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 18, 39, 42, 920, DateTimeKind.Unspecified) },
                    { 43, 7, new DateTime(2023, 4, 25, 16, 43, 55, 36, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 19, 43, 55, 36, DateTimeKind.Unspecified) },
                    { 44, 4, new DateTime(2023, 3, 16, 10, 0, 16, 161, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 12, 0, 16, 161, DateTimeKind.Unspecified) },
                    { 45, 6, new DateTime(2023, 2, 15, 7, 23, 16, 344, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 13, 23, 16, 344, DateTimeKind.Unspecified) },
                    { 46, 9, new DateTime(2023, 3, 20, 22, 17, 34, 366, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 7, 17, 34, 366, DateTimeKind.Unspecified) },
                    { 47, 7, new DateTime(2023, 2, 17, 5, 34, 6, 688, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 8, 34, 6, 688, DateTimeKind.Unspecified) },
                    { 48, 5, new DateTime(2023, 4, 28, 2, 16, 15, 604, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 10, 16, 15, 604, DateTimeKind.Unspecified) },
                    { 49, 8, new DateTime(2023, 1, 17, 13, 20, 3, 378, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 15, 20, 3, 378, DateTimeKind.Unspecified) },
                    { 50, 9, new DateTime(2023, 1, 9, 22, 4, 1, 470, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 23, 4, 1, 470, DateTimeKind.Unspecified) },
                    { 51, 8, new DateTime(2023, 1, 27, 9, 38, 42, 993, DateTimeKind.Unspecified), new DateTime(2023, 1, 27, 17, 38, 42, 993, DateTimeKind.Unspecified) },
                    { 52, 2, new DateTime(2023, 1, 8, 8, 19, 50, 831, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 18, 19, 50, 831, DateTimeKind.Unspecified) },
                    { 53, 1, new DateTime(2023, 3, 1, 13, 51, 44, 936, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 20, 51, 44, 936, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 3, 26, 21, 37, 18, 216, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 0, 37, 18, 216, DateTimeKind.Unspecified) },
                    { 55, 7, new DateTime(2023, 4, 12, 20, 33, 31, 313, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 4, 33, 31, 313, DateTimeKind.Unspecified) },
                    { 56, 2, new DateTime(2023, 2, 19, 10, 5, 54, 63, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 14, 5, 54, 63, DateTimeKind.Unspecified) },
                    { 57, 9, new DateTime(2023, 4, 11, 2, 27, 34, 34, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 4, 27, 34, 34, DateTimeKind.Unspecified) },
                    { 58, 9, new DateTime(2023, 3, 15, 22, 8, 12, 611, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 2, 8, 12, 611, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2023, 2, 3, 11, 13, 6, 43, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 19, 13, 6, 43, DateTimeKind.Unspecified) },
                    { 60, 2, new DateTime(2023, 3, 17, 22, 49, 25, 1, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 49, 25, 1, DateTimeKind.Unspecified) },
                    { 61, 4, new DateTime(2023, 4, 10, 19, 48, 34, 350, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 20, 48, 34, 350, DateTimeKind.Unspecified) },
                    { 62, 5, new DateTime(2023, 4, 4, 11, 48, 8, 519, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 19, 48, 8, 519, DateTimeKind.Unspecified) },
                    { 63, 1, new DateTime(2023, 3, 23, 6, 3, 27, 778, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 11, 3, 27, 778, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 7, new DateTime(2023, 4, 28, 1, 55, 56, 59, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 3, 55, 56, 59, DateTimeKind.Unspecified) },
                    { 65, 8, new DateTime(2023, 4, 19, 12, 8, 49, 88, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 13, 8, 49, 88, DateTimeKind.Unspecified) },
                    { 66, 8, new DateTime(2023, 3, 24, 9, 24, 20, 652, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 16, 24, 20, 652, DateTimeKind.Unspecified) },
                    { 67, 7, new DateTime(2023, 3, 23, 20, 2, 45, 166, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 1, 2, 45, 166, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2023, 1, 3, 4, 24, 4, 989, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 12, 24, 4, 989, DateTimeKind.Unspecified) },
                    { 69, 1, new DateTime(2023, 3, 13, 21, 10, 14, 451, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 3, 10, 14, 451, DateTimeKind.Unspecified) },
                    { 70, 6, new DateTime(2023, 2, 17, 13, 23, 8, 288, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 15, 23, 8, 288, DateTimeKind.Unspecified) },
                    { 71, 9, new DateTime(2023, 1, 23, 20, 21, 26, 425, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 3, 21, 26, 425, DateTimeKind.Unspecified) },
                    { 72, 5, new DateTime(2023, 3, 5, 16, 23, 56, 607, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 17, 23, 56, 607, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 3, 14, 11, 25, 55, 262, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 16, 25, 55, 262, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 3, 24, 22, 52, 46, 931, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 1, 52, 46, 931, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 2, 10, 23, 27, 11, 595, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 5, 27, 11, 595, DateTimeKind.Unspecified) },
                    { 76, 1, new DateTime(2023, 4, 26, 15, 57, 53, 58, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 16, 57, 53, 58, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 4, 24, 19, 35, 49, 996, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 0, 35, 49, 996, DateTimeKind.Unspecified) },
                    { 78, 6, new DateTime(2023, 1, 20, 8, 46, 50, 669, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 11, 46, 50, 669, DateTimeKind.Unspecified) },
                    { 79, 9, new DateTime(2023, 2, 3, 5, 52, 54, 336, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 11, 52, 54, 336, DateTimeKind.Unspecified) },
                    { 80, 3, new DateTime(2023, 1, 19, 20, 51, 51, 697, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 2, 51, 51, 697, DateTimeKind.Unspecified) },
                    { 81, 7, new DateTime(2023, 1, 22, 12, 58, 51, 760, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 18, 58, 51, 760, DateTimeKind.Unspecified) },
                    { 82, 3, new DateTime(2023, 1, 6, 0, 57, 21, 687, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 8, 57, 21, 687, DateTimeKind.Unspecified) },
                    { 83, 4, new DateTime(2023, 2, 3, 20, 27, 42, 231, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 1, 27, 42, 231, DateTimeKind.Unspecified) },
                    { 84, 2, new DateTime(2023, 1, 5, 18, 39, 32, 243, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 22, 39, 32, 243, DateTimeKind.Unspecified) },
                    { 85, 4, new DateTime(2023, 1, 11, 5, 29, 9, 400, DateTimeKind.Unspecified), new DateTime(2023, 1, 11, 14, 29, 9, 400, DateTimeKind.Unspecified) },
                    { 86, 7, new DateTime(2023, 3, 8, 5, 11, 33, 126, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 13, 11, 33, 126, DateTimeKind.Unspecified) },
                    { 87, 9, new DateTime(2023, 3, 24, 23, 17, 32, 457, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 7, 17, 32, 457, DateTimeKind.Unspecified) },
                    { 88, 2, new DateTime(2023, 1, 11, 15, 46, 48, 968, DateTimeKind.Unspecified), new DateTime(2023, 1, 11, 16, 46, 48, 968, DateTimeKind.Unspecified) },
                    { 89, 8, new DateTime(2023, 4, 30, 21, 27, 5, 819, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 6, 27, 5, 819, DateTimeKind.Unspecified) },
                    { 90, 7, new DateTime(2023, 3, 26, 14, 38, 57, 755, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 20, 38, 57, 755, DateTimeKind.Unspecified) },
                    { 91, 1, new DateTime(2023, 3, 30, 18, 45, 34, 446, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 20, 45, 34, 446, DateTimeKind.Unspecified) },
                    { 92, 7, new DateTime(2023, 4, 24, 10, 15, 0, 472, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 20, 15, 0, 472, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 3, 6, 15, 10, 28, 666, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 18, 10, 28, 666, DateTimeKind.Unspecified) },
                    { 94, 4, new DateTime(2023, 4, 18, 9, 52, 3, 280, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 16, 52, 3, 280, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 3, 1, 9, 27, 25, 939, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 10, 27, 25, 939, DateTimeKind.Unspecified) },
                    { 96, 9, new DateTime(2023, 4, 12, 19, 7, 54, 45, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 21, 7, 54, 45, DateTimeKind.Unspecified) },
                    { 97, 5, new DateTime(2023, 4, 11, 11, 7, 28, 290, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 14, 7, 28, 290, DateTimeKind.Unspecified) },
                    { 98, 4, new DateTime(2023, 1, 29, 16, 8, 55, 366, DateTimeKind.Unspecified), new DateTime(2023, 1, 29, 18, 8, 55, 366, DateTimeKind.Unspecified) },
                    { 99, 6, new DateTime(2023, 2, 5, 18, 43, 53, 461, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 0, 43, 53, 461, DateTimeKind.Unspecified) },
                    { 100, 9, new DateTime(2023, 1, 20, 15, 20, 55, 961, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 19, 20, 55, 961, DateTimeKind.Unspecified) },
                    { 101, 4, new DateTime(2023, 3, 16, 12, 6, 55, 128, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 14, 6, 55, 128, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5803), 2396m },
                    { 2, 1, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5804), 1198m },
                    { 3, 9, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5890), 699m },
                    { 4, 2, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5903), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 7, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5933), 699m },
                    { 6, 1, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5942), 699m },
                    { 7, 9, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5951), 699m },
                    { 8, 9, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5960), 699m },
                    { 9, 9, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5975), 699m },
                    { 10, 6, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5984), 699m },
                    { 11, 3, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(5993), 699m },
                    { 12, 4, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(6002), 699m },
                    { 13, 4, false, new DateTime(2023, 4, 24, 9, 14, 47, 692, DateTimeKind.Local).AddTicks(6017), 699m }
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
