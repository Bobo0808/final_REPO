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
                    { 1, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4901), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4903), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4918), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4919), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4790), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4787), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4803), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4802), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4809), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4808), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4840), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4840), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4846), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4846), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4853), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4852), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4858), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4857), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4862), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4862), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4868), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4867), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4873), "Test", 99, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4873), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 103, 16, "", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 2, 15000, 1, 218, 8, "", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 3, 15000, 1, 147, 19, "", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 4, 15000, 1, 102, 24, "", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 5, 15000, 1, 215, 13, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 6, 15000, 1, 104, 9, "", new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 7, 15000, 1, 153, 9, "", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 8, 15000, 1, 88, 8, "", new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 9, 15000, 1, 201, 20, "", new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 17 },
                    { 10, 15000, 1, 112, 16, "", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 11, 15000, 1, 133, 21, "", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 12, 15000, 1, 109, 18, "", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 13, 15000, 1, 112, 21, "", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 },
                    { 14, 15000, 1, 103, 10, "", new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 15, 15000, 1, 78, 21, "", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 16, 15000, 1, 181, 16, "", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 17, 15000, 1, 230, 24, "", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 13 },
                    { 18, 15000, 1, 107, 7, "", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 19, 15000, 1, 61, 12, "", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 20, 15000, 1, 167, 13, "", new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 21, 15000, 1, 77, 20, "", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 22, 15000, 1, 64, 18, "", new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 23, 15000, 1, 150, 24, "", new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 5 },
                    { 24, 15000, 1, 105, 13, "", new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 25, 15000, 1, 143, 13, "", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 26, 15000, 1, 152, 14, "", new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 27, 15000, 1, 91, 8, "", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 28, 15000, 1, 168, 21, "", new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 29, 15000, 1, 69, 10, "", new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 }
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
                    { 1, 10, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4722) },
                    { 2, 5, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4764) },
                    { 3, 9, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4766) },
                    { 4, 6, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4768) },
                    { 5, 10, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4769) },
                    { 6, 8, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4772) },
                    { 7, 8, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4773) },
                    { 8, 5, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4774) },
                    { 9, 4, null, "test", true, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4775) },
                    { 10, 2, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4777) },
                    { 11, 1, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4779) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4781) },
                    { 13, 5, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4782) },
                    { 14, 2, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4783) },
                    { 15, 3, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4784) },
                    { 16, 2, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4785) },
                    { 17, 5, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4786) },
                    { 18, 2, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4788) },
                    { 19, 6, null, "test", false, new DateTime(2023, 5, 9, 13, 17, 52, 689, DateTimeKind.Local).AddTicks(4789) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 2, 3, 12, 11, 26, 209, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 15, 11, 26, 209, DateTimeKind.Unspecified) },
                    { 2, 7, new DateTime(2023, 4, 26, 12, 30, 35, 803, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 13, 30, 35, 803, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 4, 4, 16, 49, 24, 801, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 2, 49, 24, 801, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2023, 5, 1, 17, 2, 54, 363, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 1, 2, 54, 363, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2023, 3, 29, 1, 6, 57, 297, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 6, 6, 57, 297, DateTimeKind.Unspecified) },
                    { 6, 8, new DateTime(2023, 4, 8, 19, 53, 32, 145, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 3, 53, 32, 145, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 2, 12, 16, 42, 0, 438, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 19, 42, 0, 438, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2023, 4, 16, 22, 8, 48, 880, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 3, 8, 48, 880, DateTimeKind.Unspecified) },
                    { 9, 7, new DateTime(2023, 4, 15, 3, 22, 27, 988, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 9, 22, 27, 988, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(2023, 4, 2, 11, 34, 12, 174, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 16, 34, 12, 174, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2023, 2, 16, 22, 36, 24, 749, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 5, 36, 24, 749, DateTimeKind.Unspecified) },
                    { 12, 9, new DateTime(2023, 2, 15, 10, 56, 0, 136, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 11, 56, 0, 136, DateTimeKind.Unspecified) },
                    { 13, 7, new DateTime(2023, 4, 26, 22, 41, 56, 475, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 23, 41, 56, 475, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 5, 4, 7, 45, 35, 344, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 14, 45, 35, 344, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 2, 4, 1, 24, 19, 796, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 8, 24, 19, 796, DateTimeKind.Unspecified) },
                    { 16, 9, new DateTime(2023, 3, 24, 1, 19, 36, 120, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 10, 19, 36, 120, DateTimeKind.Unspecified) },
                    { 17, 6, new DateTime(2023, 3, 17, 14, 26, 56, 384, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 17, 26, 56, 384, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2023, 4, 10, 22, 4, 21, 362, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 6, 4, 21, 362, DateTimeKind.Unspecified) },
                    { 19, 5, new DateTime(2023, 2, 8, 12, 9, 36, 278, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 16, 9, 36, 278, DateTimeKind.Unspecified) },
                    { 20, 7, new DateTime(2023, 2, 13, 12, 10, 50, 716, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 15, 10, 50, 716, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 23, 4, 41, 49, 29, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 9, 41, 49, 29, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 2, new DateTime(2023, 2, 8, 9, 40, 2, 872, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 17, 40, 2, 872, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2023, 2, 6, 22, 19, 58, 592, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 3, 19, 58, 592, DateTimeKind.Unspecified) },
                    { 24, 3, new DateTime(2023, 2, 13, 11, 12, 21, 119, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 12, 21, 119, DateTimeKind.Unspecified) },
                    { 25, 9, new DateTime(2023, 5, 15, 10, 29, 54, 136, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 15, 29, 54, 136, DateTimeKind.Unspecified) },
                    { 26, 1, new DateTime(2023, 5, 14, 9, 38, 1, 96, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 16, 38, 1, 96, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 2, 26, 19, 35, 35, 367, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 22, 35, 35, 367, DateTimeKind.Unspecified) },
                    { 28, 9, new DateTime(2023, 5, 27, 21, 15, 24, 6, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 1, 15, 24, 6, DateTimeKind.Unspecified) },
                    { 29, 5, new DateTime(2023, 2, 18, 6, 47, 23, 561, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 9, 47, 23, 561, DateTimeKind.Unspecified) },
                    { 30, 1, new DateTime(2023, 3, 12, 9, 23, 7, 742, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 11, 23, 7, 742, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2023, 2, 6, 21, 3, 19, 683, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 22, 3, 19, 683, DateTimeKind.Unspecified) },
                    { 32, 8, new DateTime(2023, 2, 18, 0, 22, 42, 655, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 9, 22, 42, 655, DateTimeKind.Unspecified) },
                    { 33, 4, new DateTime(2023, 5, 12, 12, 16, 5, 364, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 20, 16, 5, 364, DateTimeKind.Unspecified) },
                    { 34, 8, new DateTime(2023, 4, 14, 17, 8, 11, 313, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 2, 8, 11, 313, DateTimeKind.Unspecified) },
                    { 35, 1, new DateTime(2023, 3, 5, 6, 35, 42, 289, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 9, 35, 42, 289, DateTimeKind.Unspecified) },
                    { 36, 7, new DateTime(2023, 5, 3, 16, 45, 33, 246, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 19, 45, 33, 246, DateTimeKind.Unspecified) },
                    { 37, 8, new DateTime(2023, 4, 25, 2, 32, 42, 613, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 7, 32, 42, 613, DateTimeKind.Unspecified) },
                    { 38, 5, new DateTime(2023, 5, 2, 10, 42, 30, 862, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 15, 42, 30, 862, DateTimeKind.Unspecified) },
                    { 39, 7, new DateTime(2023, 4, 6, 15, 14, 15, 795, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 19, 14, 15, 795, DateTimeKind.Unspecified) },
                    { 40, 6, new DateTime(2023, 2, 25, 21, 29, 25, 898, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 0, 29, 25, 898, DateTimeKind.Unspecified) },
                    { 41, 6, new DateTime(2023, 2, 24, 10, 40, 45, 251, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 12, 40, 45, 251, DateTimeKind.Unspecified) },
                    { 42, 5, new DateTime(2023, 2, 8, 13, 48, 16, 98, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 14, 48, 16, 98, DateTimeKind.Unspecified) },
                    { 43, 9, new DateTime(2023, 2, 11, 13, 18, 45, 349, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 20, 18, 45, 349, DateTimeKind.Unspecified) },
                    { 44, 8, new DateTime(2023, 4, 11, 15, 32, 8, 224, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 19, 32, 8, 224, DateTimeKind.Unspecified) },
                    { 45, 5, new DateTime(2023, 3, 2, 10, 24, 35, 67, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 17, 24, 35, 67, DateTimeKind.Unspecified) },
                    { 46, 7, new DateTime(2023, 2, 10, 14, 47, 58, 408, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 20, 47, 58, 408, DateTimeKind.Unspecified) },
                    { 47, 7, new DateTime(2023, 3, 25, 1, 5, 40, 72, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 11, 5, 40, 72, DateTimeKind.Unspecified) },
                    { 48, 5, new DateTime(2023, 4, 19, 3, 21, 57, 885, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 6, 21, 57, 885, DateTimeKind.Unspecified) },
                    { 49, 3, new DateTime(2023, 4, 20, 18, 30, 44, 147, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 4, 30, 44, 147, DateTimeKind.Unspecified) },
                    { 50, 3, new DateTime(2023, 5, 30, 8, 13, 45, 621, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 13, 13, 45, 621, DateTimeKind.Unspecified) },
                    { 51, 2, new DateTime(2023, 4, 6, 8, 20, 43, 687, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 18, 20, 43, 687, DateTimeKind.Unspecified) },
                    { 52, 5, new DateTime(2023, 5, 22, 9, 43, 19, 740, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 10, 43, 19, 740, DateTimeKind.Unspecified) },
                    { 53, 7, new DateTime(2023, 2, 27, 0, 55, 49, 727, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 8, 55, 49, 727, DateTimeKind.Unspecified) },
                    { 54, 3, new DateTime(2023, 3, 12, 20, 31, 3, 546, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 6, 31, 3, 546, DateTimeKind.Unspecified) },
                    { 55, 2, new DateTime(2023, 4, 11, 22, 5, 17, 810, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 2, 5, 17, 810, DateTimeKind.Unspecified) },
                    { 56, 7, new DateTime(2023, 5, 8, 14, 37, 46, 683, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 16, 37, 46, 683, DateTimeKind.Unspecified) },
                    { 57, 7, new DateTime(2023, 4, 19, 8, 38, 36, 995, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 16, 38, 36, 995, DateTimeKind.Unspecified) },
                    { 58, 7, new DateTime(2023, 2, 12, 15, 50, 26, 405, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 0, 50, 26, 405, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 5, 2, 15, 13, 45, 496, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 23, 13, 45, 496, DateTimeKind.Unspecified) },
                    { 60, 1, new DateTime(2023, 3, 27, 14, 11, 45, 888, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 22, 11, 45, 888, DateTimeKind.Unspecified) },
                    { 61, 3, new DateTime(2023, 4, 29, 17, 56, 21, 574, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 18, 56, 21, 574, DateTimeKind.Unspecified) },
                    { 62, 9, new DateTime(2023, 4, 4, 18, 13, 55, 924, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 3, 13, 55, 924, DateTimeKind.Unspecified) },
                    { 63, 5, new DateTime(2023, 5, 11, 20, 52, 11, 815, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 1, 52, 11, 815, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 1, new DateTime(2023, 5, 29, 15, 44, 46, 740, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 16, 44, 46, 740, DateTimeKind.Unspecified) },
                    { 65, 6, new DateTime(2023, 5, 31, 17, 3, 58, 721, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 2, 3, 58, 721, DateTimeKind.Unspecified) },
                    { 66, 8, new DateTime(2023, 4, 4, 22, 40, 13, 916, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 1, 40, 13, 916, DateTimeKind.Unspecified) },
                    { 67, 7, new DateTime(2023, 3, 25, 18, 55, 26, 952, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 22, 55, 26, 952, DateTimeKind.Unspecified) },
                    { 68, 1, new DateTime(2023, 3, 28, 7, 2, 6, 876, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 17, 2, 6, 876, DateTimeKind.Unspecified) },
                    { 69, 2, new DateTime(2023, 3, 25, 9, 8, 17, 373, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 17, 8, 17, 373, DateTimeKind.Unspecified) },
                    { 70, 4, new DateTime(2023, 5, 9, 17, 44, 57, 567, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 44, 57, 567, DateTimeKind.Unspecified) },
                    { 71, 6, new DateTime(2023, 2, 2, 13, 45, 20, 661, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 17, 45, 20, 661, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 3, 22, 0, 4, 39, 232, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 4, 4, 39, 232, DateTimeKind.Unspecified) },
                    { 73, 6, new DateTime(2023, 5, 10, 12, 23, 48, 669, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 21, 23, 48, 669, DateTimeKind.Unspecified) },
                    { 74, 6, new DateTime(2023, 3, 16, 22, 45, 39, 429, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 7, 45, 39, 429, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 3, 20, 10, 43, 31, 954, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 18, 43, 31, 954, DateTimeKind.Unspecified) },
                    { 76, 2, new DateTime(2023, 3, 26, 14, 28, 40, 557, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 19, 28, 40, 557, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 4, 22, 5, 52, 5, 520, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 8, 52, 5, 520, DateTimeKind.Unspecified) },
                    { 78, 3, new DateTime(2023, 5, 19, 0, 34, 26, 758, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 8, 34, 26, 758, DateTimeKind.Unspecified) },
                    { 79, 6, new DateTime(2023, 5, 8, 18, 33, 56, 23, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 22, 33, 56, 23, DateTimeKind.Unspecified) },
                    { 80, 1, new DateTime(2023, 3, 29, 19, 23, 37, 250, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 4, 23, 37, 250, DateTimeKind.Unspecified) },
                    { 81, 2, new DateTime(2023, 4, 13, 13, 55, 5, 321, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 18, 55, 5, 321, DateTimeKind.Unspecified) },
                    { 82, 8, new DateTime(2023, 2, 20, 9, 51, 11, 896, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 11, 51, 11, 896, DateTimeKind.Unspecified) },
                    { 83, 5, new DateTime(2023, 4, 6, 19, 13, 18, 702, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 21, 13, 18, 702, DateTimeKind.Unspecified) },
                    { 84, 6, new DateTime(2023, 5, 18, 23, 46, 31, 561, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 5, 46, 31, 561, DateTimeKind.Unspecified) },
                    { 85, 8, new DateTime(2023, 2, 2, 3, 26, 25, 435, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 9, 26, 25, 435, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2023, 4, 18, 17, 56, 35, 445, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 22, 56, 35, 445, DateTimeKind.Unspecified) },
                    { 87, 1, new DateTime(2023, 3, 16, 2, 50, 23, 907, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 4, 50, 23, 907, DateTimeKind.Unspecified) },
                    { 88, 5, new DateTime(2023, 2, 9, 4, 49, 15, 616, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 10, 49, 15, 616, DateTimeKind.Unspecified) },
                    { 89, 1, new DateTime(2023, 5, 6, 18, 21, 22, 796, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 4, 21, 22, 796, DateTimeKind.Unspecified) },
                    { 90, 8, new DateTime(2023, 4, 2, 23, 31, 40, 101, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 31, 40, 101, DateTimeKind.Unspecified) },
                    { 91, 5, new DateTime(2023, 3, 12, 15, 14, 24, 293, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 22, 14, 24, 293, DateTimeKind.Unspecified) },
                    { 92, 3, new DateTime(2023, 4, 24, 7, 6, 24, 13, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 9, 6, 24, 13, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 5, 1, 2, 18, 49, 466, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 7, 18, 49, 466, DateTimeKind.Unspecified) },
                    { 94, 5, new DateTime(2023, 5, 22, 14, 4, 57, 40, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 17, 4, 57, 40, DateTimeKind.Unspecified) },
                    { 95, 6, new DateTime(2023, 3, 24, 18, 28, 51, 753, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 23, 28, 51, 753, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 3, 14, 15, 58, 12, 566, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 1, 58, 12, 566, DateTimeKind.Unspecified) },
                    { 97, 3, new DateTime(2023, 5, 30, 13, 10, 57, 924, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 19, 10, 57, 924, DateTimeKind.Unspecified) },
                    { 98, 8, new DateTime(2023, 4, 14, 19, 16, 35, 128, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 4, 16, 35, 128, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 3, 14, 3, 21, 43, 329, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 13, 21, 43, 329, DateTimeKind.Unspecified) },
                    { 100, 8, new DateTime(2023, 3, 31, 11, 3, 13, 5, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 17, 3, 13, 5, DateTimeKind.Unspecified) },
                    { 101, 8, new DateTime(2023, 4, 10, 18, 50, 15, 286, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 19, 50, 15, 286, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4928), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(4929), 1198m },
                    { 3, 6, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5622), 699m },
                    { 4, 5, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5641), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 5, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5650), 699m },
                    { 6, 4, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5659), 699m },
                    { 7, 6, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5667), 699m },
                    { 8, 1, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5682), 699m },
                    { 9, 7, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5690), 699m },
                    { 10, 5, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5699), 699m },
                    { 11, 4, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5708), 699m },
                    { 12, 8, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5723), 699m },
                    { 13, 4, false, new DateTime(2023, 5, 9, 13, 17, 52, 690, DateTimeKind.Local).AddTicks(5731), 699m }
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
