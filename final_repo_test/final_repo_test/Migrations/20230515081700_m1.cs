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
                    { 1, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7543), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7545), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                table: "Employees",
                columns: new[] { "E_ID", "E_Address", "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Name", "E_Permission", "E_Phone", "E_Pwd", "E_Title", "E_UserName", "E_Work", "Locked", "Role" },
                values: new object[] { 1, "高雄市前金區", new DateTime(1999, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", 0, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "bobo", 0, "0963915584", "1234", 0, "bobo", true, false, "user" });

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
                    { 1, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7553), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7554), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7442), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7438), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7455), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7454), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7461), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7460), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7466), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7466), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7471), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7470), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7498), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7497), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7503), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7502), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7508), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7507), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7512), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7512), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7517), "Test", 99, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7517), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 104, 7, "", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 13 },
                    { 2, 15000, 1, 67, 10, "", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 20 },
                    { 3, 15000, 1, 46, 15, "", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 4, 15000, 1, 122, 11, "", new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 5, 15000, 1, 107, 22, "", new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 13 },
                    { 6, 15000, 1, 96, 24, "", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 7, 15000, 1, 36, 17, "", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 8, 15000, 1, 155, 11, "", new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 9, 15000, 1, 177, 13, "", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 10, 15000, 1, 77, 7, "", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 11, 15000, 1, 138, 9, "", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 12, 15000, 1, 189, 18, "", new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 13, 15000, 1, 149, 9, "", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 14, 15000, 1, 102, 7, "", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 15, 15000, 1, 122, 10, "", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 16, 15000, 1, 112, 9, "", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 17, 15000, 1, 220, 19, "", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 18, 15000, 1, 69, 22, "", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 7 },
                    { 19, 15000, 1, 56, 19, "", new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 20, 15000, 1, 133, 11, "", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 21, 15000, 1, 183, 20, "", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 22, 15000, 1, 196, 24, "", new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 23, 15000, 1, 231, 13, "", new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 24, 15000, 1, 139, 13, "", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 25, 15000, 1, 141, 23, "", new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 26, 15000, 1, 40, 24, "", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 27, 15000, 1, 113, 17, "", new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 28, 15000, 1, 131, 18, "", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 29, 15000, 1, 142, 15, "", new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7533), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7535), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 6, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6818) },
                    { 2, 2, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6863) },
                    { 3, 9, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6865) },
                    { 4, 1, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6867) },
                    { 5, 3, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6868) },
                    { 6, 9, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6870) },
                    { 7, 4, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6872) },
                    { 8, 7, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6873) },
                    { 9, 5, null, "test", true, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6874) },
                    { 10, 10, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6876) },
                    { 11, 4, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6877) },
                    { 12, 6, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6879) },
                    { 13, 8, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6880) },
                    { 14, 9, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6881) },
                    { 15, 6, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6882) },
                    { 16, 3, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6883) },
                    { 17, 5, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6884) },
                    { 18, 6, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6886) },
                    { 19, 7, null, "test", false, new DateTime(2023, 5, 15, 16, 17, 0, 44, DateTimeKind.Local).AddTicks(6887) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 3, 31, 12, 47, 23, 814, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 19, 47, 23, 814, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 5, 25, 19, 32, 5, 808, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 2, 32, 5, 808, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2023, 2, 12, 1, 23, 14, 200, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 8, 23, 14, 200, DateTimeKind.Unspecified) },
                    { 4, 6, new DateTime(2023, 2, 24, 14, 33, 28, 903, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 20, 33, 28, 903, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2023, 3, 31, 7, 53, 21, 669, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 8, 53, 21, 669, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(2023, 2, 3, 0, 58, 46, 202, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 8, 58, 46, 202, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2023, 2, 2, 18, 18, 24, 765, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 22, 18, 24, 765, DateTimeKind.Unspecified) },
                    { 8, 9, new DateTime(2023, 5, 7, 7, 55, 56, 560, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 15, 55, 56, 560, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2023, 5, 6, 1, 24, 59, 221, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 4, 24, 59, 221, DateTimeKind.Unspecified) },
                    { 10, 3, new DateTime(2023, 3, 8, 1, 23, 15, 735, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 6, 23, 15, 735, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2023, 2, 5, 13, 33, 34, 43, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 18, 33, 34, 43, DateTimeKind.Unspecified) },
                    { 12, 5, new DateTime(2023, 5, 8, 3, 27, 0, 77, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 7, 27, 0, 77, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2023, 4, 23, 1, 31, 18, 185, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 10, 31, 18, 185, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 5, 16, 23, 34, 38, 522, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 8, 34, 38, 522, DateTimeKind.Unspecified) },
                    { 15, 4, new DateTime(2023, 2, 11, 14, 1, 36, 518, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 15, 1, 36, 518, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 3, 1, 5, 57, 54, 876, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 13, 57, 54, 876, DateTimeKind.Unspecified) },
                    { 17, 9, new DateTime(2023, 3, 18, 20, 22, 20, 723, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 6, 22, 20, 723, DateTimeKind.Unspecified) },
                    { 18, 5, new DateTime(2023, 5, 11, 14, 36, 22, 153, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 18, 36, 22, 153, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2023, 5, 17, 3, 33, 6, 223, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 11, 33, 6, 223, DateTimeKind.Unspecified) },
                    { 20, 8, new DateTime(2023, 5, 27, 14, 5, 24, 892, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 21, 5, 24, 892, DateTimeKind.Unspecified) },
                    { 21, 5, new DateTime(2023, 4, 24, 0, 52, 3, 637, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 6, 52, 3, 637, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 8, new DateTime(2023, 3, 26, 15, 4, 25, 570, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 17, 4, 25, 570, DateTimeKind.Unspecified) },
                    { 23, 8, new DateTime(2023, 4, 26, 10, 38, 11, 547, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 12, 38, 11, 547, DateTimeKind.Unspecified) },
                    { 24, 8, new DateTime(2023, 3, 24, 21, 42, 44, 674, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 6, 42, 44, 674, DateTimeKind.Unspecified) },
                    { 25, 5, new DateTime(2023, 2, 4, 11, 30, 0, 510, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 19, 30, 0, 510, DateTimeKind.Unspecified) },
                    { 26, 7, new DateTime(2023, 2, 22, 10, 1, 13, 243, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 14, 1, 13, 243, DateTimeKind.Unspecified) },
                    { 27, 5, new DateTime(2023, 5, 2, 14, 27, 59, 925, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 16, 27, 59, 925, DateTimeKind.Unspecified) },
                    { 28, 1, new DateTime(2023, 5, 22, 1, 57, 12, 559, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 10, 57, 12, 559, DateTimeKind.Unspecified) },
                    { 29, 6, new DateTime(2023, 4, 1, 20, 56, 10, 395, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 3, 56, 10, 395, DateTimeKind.Unspecified) },
                    { 30, 8, new DateTime(2023, 4, 10, 12, 40, 1, 407, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 13, 40, 1, 407, DateTimeKind.Unspecified) },
                    { 31, 6, new DateTime(2023, 5, 17, 2, 32, 59, 807, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 9, 32, 59, 807, DateTimeKind.Unspecified) },
                    { 32, 2, new DateTime(2023, 5, 8, 13, 52, 1, 380, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 23, 52, 1, 380, DateTimeKind.Unspecified) },
                    { 33, 6, new DateTime(2023, 2, 25, 20, 12, 53, 317, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 5, 12, 53, 317, DateTimeKind.Unspecified) },
                    { 34, 7, new DateTime(2023, 3, 6, 15, 39, 8, 195, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 16, 39, 8, 195, DateTimeKind.Unspecified) },
                    { 35, 3, new DateTime(2023, 5, 7, 0, 1, 17, 546, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 7, 1, 17, 546, DateTimeKind.Unspecified) },
                    { 36, 1, new DateTime(2023, 5, 25, 7, 8, 29, 98, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 15, 8, 29, 98, DateTimeKind.Unspecified) },
                    { 37, 9, new DateTime(2023, 5, 24, 15, 48, 58, 129, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 19, 48, 58, 129, DateTimeKind.Unspecified) },
                    { 38, 1, new DateTime(2023, 3, 8, 2, 21, 8, 960, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 5, 21, 8, 960, DateTimeKind.Unspecified) },
                    { 39, 9, new DateTime(2023, 3, 31, 14, 19, 54, 246, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 22, 19, 54, 246, DateTimeKind.Unspecified) },
                    { 40, 1, new DateTime(2023, 4, 6, 16, 33, 35, 344, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 0, 33, 35, 344, DateTimeKind.Unspecified) },
                    { 41, 1, new DateTime(2023, 4, 5, 5, 53, 5, 951, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 14, 53, 5, 951, DateTimeKind.Unspecified) },
                    { 42, 4, new DateTime(2023, 3, 14, 15, 20, 3, 244, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 23, 20, 3, 244, DateTimeKind.Unspecified) },
                    { 43, 1, new DateTime(2023, 4, 19, 20, 23, 54, 181, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 0, 23, 54, 181, DateTimeKind.Unspecified) },
                    { 44, 6, new DateTime(2023, 5, 27, 15, 46, 17, 347, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 20, 46, 17, 347, DateTimeKind.Unspecified) },
                    { 45, 8, new DateTime(2023, 4, 13, 21, 39, 13, 30, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 3, 39, 13, 30, DateTimeKind.Unspecified) },
                    { 46, 5, new DateTime(2023, 3, 7, 2, 26, 12, 820, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 8, 26, 12, 820, DateTimeKind.Unspecified) },
                    { 47, 8, new DateTime(2023, 3, 9, 5, 2, 49, 702, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 9, 2, 49, 702, DateTimeKind.Unspecified) },
                    { 48, 2, new DateTime(2023, 4, 17, 2, 18, 41, 656, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 11, 18, 41, 656, DateTimeKind.Unspecified) },
                    { 49, 8, new DateTime(2023, 5, 27, 9, 49, 32, 312, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 16, 49, 32, 312, DateTimeKind.Unspecified) },
                    { 50, 2, new DateTime(2023, 2, 10, 15, 50, 14, 749, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 18, 50, 14, 749, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2023, 5, 15, 14, 11, 50, 899, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 16, 11, 50, 899, DateTimeKind.Unspecified) },
                    { 52, 5, new DateTime(2023, 2, 3, 12, 28, 18, 353, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 19, 28, 18, 353, DateTimeKind.Unspecified) },
                    { 53, 5, new DateTime(2023, 5, 20, 17, 55, 13, 157, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 1, 55, 13, 157, DateTimeKind.Unspecified) },
                    { 54, 5, new DateTime(2023, 3, 28, 7, 22, 7, 479, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 10, 22, 7, 479, DateTimeKind.Unspecified) },
                    { 55, 3, new DateTime(2023, 5, 23, 0, 29, 48, 440, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 6, 29, 48, 440, DateTimeKind.Unspecified) },
                    { 56, 1, new DateTime(2023, 4, 17, 0, 18, 22, 613, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 4, 18, 22, 613, DateTimeKind.Unspecified) },
                    { 57, 9, new DateTime(2023, 3, 30, 5, 26, 40, 60, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 12, 26, 40, 60, DateTimeKind.Unspecified) },
                    { 58, 9, new DateTime(2023, 5, 28, 23, 2, 57, 48, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 7, 2, 57, 48, DateTimeKind.Unspecified) },
                    { 59, 6, new DateTime(2023, 4, 9, 19, 16, 39, 663, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 4, 16, 39, 663, DateTimeKind.Unspecified) },
                    { 60, 9, new DateTime(2023, 5, 2, 12, 41, 18, 743, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 13, 41, 18, 743, DateTimeKind.Unspecified) },
                    { 61, 2, new DateTime(2023, 2, 10, 1, 57, 35, 120, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 7, 57, 35, 120, DateTimeKind.Unspecified) },
                    { 62, 7, new DateTime(2023, 4, 19, 14, 58, 20, 661, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 18, 58, 20, 661, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 5, 5, 7, 34, 50, 820, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 17, 34, 50, 820, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 7, new DateTime(2023, 4, 2, 13, 13, 8, 852, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 22, 13, 8, 852, DateTimeKind.Unspecified) },
                    { 65, 9, new DateTime(2023, 5, 23, 16, 42, 3, 153, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 2, 42, 3, 153, DateTimeKind.Unspecified) },
                    { 66, 6, new DateTime(2023, 4, 1, 16, 51, 58, 907, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 18, 51, 58, 907, DateTimeKind.Unspecified) },
                    { 67, 5, new DateTime(2023, 5, 18, 11, 13, 7, 689, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 17, 13, 7, 689, DateTimeKind.Unspecified) },
                    { 68, 3, new DateTime(2023, 2, 11, 11, 44, 13, 505, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 20, 44, 13, 505, DateTimeKind.Unspecified) },
                    { 69, 6, new DateTime(2023, 3, 2, 1, 8, 36, 861, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 3, 8, 36, 861, DateTimeKind.Unspecified) },
                    { 70, 9, new DateTime(2023, 5, 27, 2, 39, 34, 15, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 10, 39, 34, 15, DateTimeKind.Unspecified) },
                    { 71, 7, new DateTime(2023, 5, 20, 13, 0, 13, 538, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 22, 0, 13, 538, DateTimeKind.Unspecified) },
                    { 72, 2, new DateTime(2023, 4, 27, 19, 11, 35, 116, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 22, 11, 35, 116, DateTimeKind.Unspecified) },
                    { 73, 8, new DateTime(2023, 5, 27, 23, 36, 37, 942, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 5, 36, 37, 942, DateTimeKind.Unspecified) },
                    { 74, 3, new DateTime(2023, 3, 15, 19, 28, 51, 450, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 23, 28, 51, 450, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 2, 11, 20, 32, 26, 769, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 5, 32, 26, 769, DateTimeKind.Unspecified) },
                    { 76, 9, new DateTime(2023, 2, 21, 6, 58, 26, 319, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 7, 58, 26, 319, DateTimeKind.Unspecified) },
                    { 77, 8, new DateTime(2023, 3, 10, 23, 38, 12, 687, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 3, 38, 12, 687, DateTimeKind.Unspecified) },
                    { 78, 8, new DateTime(2023, 5, 8, 0, 20, 57, 229, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 2, 20, 57, 229, DateTimeKind.Unspecified) },
                    { 79, 6, new DateTime(2023, 2, 10, 9, 11, 21, 757, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 16, 11, 21, 757, DateTimeKind.Unspecified) },
                    { 80, 5, new DateTime(2023, 3, 13, 0, 29, 31, 833, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 10, 29, 31, 833, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 2, 14, 4, 8, 40, 93, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 9, 8, 40, 93, DateTimeKind.Unspecified) },
                    { 82, 5, new DateTime(2023, 3, 24, 19, 2, 5, 332, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 3, 2, 5, 332, DateTimeKind.Unspecified) },
                    { 83, 9, new DateTime(2023, 4, 4, 22, 14, 59, 518, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 3, 14, 59, 518, DateTimeKind.Unspecified) },
                    { 84, 2, new DateTime(2023, 3, 10, 17, 11, 49, 11, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 0, 11, 49, 11, DateTimeKind.Unspecified) },
                    { 85, 2, new DateTime(2023, 4, 3, 15, 18, 47, 884, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 19, 18, 47, 884, DateTimeKind.Unspecified) },
                    { 86, 2, new DateTime(2023, 5, 12, 7, 42, 2, 803, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 17, 42, 2, 803, DateTimeKind.Unspecified) },
                    { 87, 2, new DateTime(2023, 2, 28, 11, 39, 15, 210, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 12, 39, 15, 210, DateTimeKind.Unspecified) },
                    { 88, 7, new DateTime(2023, 5, 3, 22, 46, 51, 436, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 6, 46, 51, 436, DateTimeKind.Unspecified) },
                    { 89, 6, new DateTime(2023, 2, 7, 7, 3, 5, 624, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 16, 3, 5, 624, DateTimeKind.Unspecified) },
                    { 90, 2, new DateTime(2023, 4, 19, 6, 55, 3, 825, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 7, 55, 3, 825, DateTimeKind.Unspecified) },
                    { 91, 7, new DateTime(2023, 2, 2, 19, 26, 10, 709, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 22, 26, 10, 709, DateTimeKind.Unspecified) },
                    { 92, 2, new DateTime(2023, 2, 7, 12, 52, 59, 283, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 14, 52, 59, 283, DateTimeKind.Unspecified) },
                    { 93, 2, new DateTime(2023, 4, 2, 21, 51, 4, 356, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 51, 4, 356, DateTimeKind.Unspecified) },
                    { 94, 8, new DateTime(2023, 5, 30, 0, 6, 35, 792, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 6, 6, 35, 792, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 5, 19, 1, 36, 20, 831, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 7, 36, 20, 831, DateTimeKind.Unspecified) },
                    { 96, 1, new DateTime(2023, 4, 24, 15, 58, 46, 940, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 22, 58, 46, 940, DateTimeKind.Unspecified) },
                    { 97, 3, new DateTime(2023, 5, 10, 23, 28, 19, 682, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 7, 28, 19, 682, DateTimeKind.Unspecified) },
                    { 98, 6, new DateTime(2023, 3, 28, 14, 42, 5, 447, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 18, 42, 5, 447, DateTimeKind.Unspecified) },
                    { 99, 7, new DateTime(2023, 4, 27, 16, 3, 31, 510, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 22, 3, 31, 510, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2023, 5, 30, 4, 4, 3, 919, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 5, 4, 3, 919, DateTimeKind.Unspecified) },
                    { 101, 5, new DateTime(2023, 4, 11, 6, 22, 21, 551, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 7, 22, 21, 551, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7564), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(7565), 1198m },
                    { 3, 4, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8234), 699m },
                    { 4, 1, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8247), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 1, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8293), 699m },
                    { 6, 3, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8303), 699m },
                    { 7, 1, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8311), 699m },
                    { 8, 6, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8320), 699m },
                    { 9, 9, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8334), 699m },
                    { 10, 6, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8343), 699m },
                    { 11, 8, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8351), 699m },
                    { 12, 2, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8358), 699m },
                    { 13, 1, false, new DateTime(2023, 5, 15, 16, 17, 0, 45, DateTimeKind.Local).AddTicks(8373), 699m }
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
