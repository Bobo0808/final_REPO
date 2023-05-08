using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class dd1 : Migration
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
                    { 1, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4785), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4786), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 1, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4796), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4797), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4685), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4682), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4698), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4697), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4703), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4702), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4707), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4707), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4713), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4712), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4719), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4718), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4724), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4723), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4728), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4728), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4733), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4733), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4738), "Test", 99, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4738), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 98, 10, "", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 2, 15000, 1, 125, 21, "", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 3, 15000, 1, 215, 7, "", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 4, 15000, 1, 236, 13, "", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 5, 15000, 1, 144, 18, "", new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 6, 15000, 1, 88, 19, "", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 7, 15000, 1, 161, 13, "", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 4 },
                    { 8, 15000, 1, 67, 8, "", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 9, 15000, 1, 157, 21, "", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 10, 15000, 1, 144, 14, "", new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 11, 15000, 1, 188, 8, "", new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 12, 15000, 1, 65, 18, "", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 13, 15000, 1, 198, 18, "", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 14, 15000, 1, 239, 19, "", new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 15, 15000, 1, 218, 13, "", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 16, 15000, 1, 205, 18, "", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 17, 15000, 1, 203, 23, "", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 18, 15000, 1, 171, 9, "", new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 19, 15000, 1, 210, 19, "", new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 20, 15000, 1, 90, 11, "", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 21, 15000, 1, 40, 13, "", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 22, 15000, 1, 237, 24, "", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 5 },
                    { 23, 15000, 1, 163, 20, "", new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 24, 15000, 1, 121, 24, "", new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 25, 15000, 1, 223, 18, "", new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 26, 15000, 1, 32, 17, "", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 27, 15000, 1, 43, 16, "", new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 },
                    { 28, 15000, 1, 234, 23, "", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 29, 15000, 1, 40, 13, "", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 }
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
                    { 1, 4, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3839) },
                    { 2, 8, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3882) },
                    { 3, 6, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3884) },
                    { 4, 1, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3885) },
                    { 5, 7, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3886) },
                    { 6, 9, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3888) },
                    { 7, 7, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3890) },
                    { 8, 4, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3891) },
                    { 9, 7, null, "test", true, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3892) },
                    { 10, 4, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3894) },
                    { 11, 9, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3896) },
                    { 12, 10, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3897) },
                    { 13, 4, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3898) },
                    { 14, 8, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3899) },
                    { 15, 8, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3900) },
                    { 16, 3, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3901) },
                    { 17, 4, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3902) },
                    { 18, 3, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3904) },
                    { 19, 10, null, "test", false, new DateTime(2023, 5, 8, 12, 11, 23, 944, DateTimeKind.Local).AddTicks(3905) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 3, 6, 9, 26, 48, 82, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 14, 26, 48, 82, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(2023, 3, 12, 14, 37, 51, 321, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 17, 37, 51, 321, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 3, 5, 7, 56, 51, 255, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 11, 56, 51, 255, DateTimeKind.Unspecified) },
                    { 4, 9, new DateTime(2023, 2, 16, 21, 34, 44, 794, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 23, 34, 44, 794, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2023, 1, 19, 0, 42, 11, 194, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 2, 42, 11, 194, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(2023, 2, 16, 21, 57, 1, 518, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 3, 57, 1, 518, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(2023, 1, 18, 7, 7, 19, 425, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 11, 7, 19, 425, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2023, 2, 2, 14, 49, 43, 719, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 19, 49, 43, 719, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(2023, 3, 29, 23, 6, 20, 657, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 8, 6, 20, 657, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 3, 17, 12, 22, 21, 167, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 21, 22, 21, 167, DateTimeKind.Unspecified) },
                    { 11, 3, new DateTime(2023, 4, 29, 6, 36, 7, 829, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 8, 36, 7, 829, DateTimeKind.Unspecified) },
                    { 12, 8, new DateTime(2023, 2, 14, 19, 11, 50, 606, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 2, 11, 50, 606, DateTimeKind.Unspecified) },
                    { 13, 6, new DateTime(2023, 4, 28, 5, 39, 47, 516, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 15, 39, 47, 516, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2023, 2, 4, 17, 27, 45, 857, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 20, 27, 45, 857, DateTimeKind.Unspecified) },
                    { 15, 5, new DateTime(2023, 2, 26, 19, 7, 51, 232, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 20, 7, 51, 232, DateTimeKind.Unspecified) },
                    { 16, 5, new DateTime(2023, 4, 13, 16, 54, 32, 658, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 19, 54, 32, 658, DateTimeKind.Unspecified) },
                    { 17, 9, new DateTime(2023, 2, 7, 3, 44, 0, 150, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 12, 44, 0, 150, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2023, 2, 24, 17, 58, 2, 597, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 22, 58, 2, 597, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2023, 4, 20, 1, 59, 7, 771, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 7, 59, 7, 771, DateTimeKind.Unspecified) },
                    { 20, 9, new DateTime(2023, 1, 17, 13, 3, 56, 465, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 22, 3, 56, 465, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 20, 22, 38, 8, 38, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 0, 38, 8, 38, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 8, new DateTime(2023, 3, 1, 8, 5, 45, 147, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 15, 5, 45, 147, DateTimeKind.Unspecified) },
                    { 23, 6, new DateTime(2023, 4, 11, 2, 23, 32, 403, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 11, 23, 32, 403, DateTimeKind.Unspecified) },
                    { 24, 6, new DateTime(2023, 2, 11, 21, 16, 3, 238, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 6, 16, 3, 238, DateTimeKind.Unspecified) },
                    { 25, 6, new DateTime(2023, 4, 7, 12, 1, 45, 9, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 19, 1, 45, 9, DateTimeKind.Unspecified) },
                    { 26, 8, new DateTime(2023, 1, 2, 18, 25, 10, 288, DateTimeKind.Unspecified), new DateTime(2023, 1, 2, 19, 25, 10, 288, DateTimeKind.Unspecified) },
                    { 27, 7, new DateTime(2023, 4, 28, 3, 31, 4, 292, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 12, 31, 4, 292, DateTimeKind.Unspecified) },
                    { 28, 4, new DateTime(2023, 2, 8, 23, 7, 30, 915, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 0, 7, 30, 915, DateTimeKind.Unspecified) },
                    { 29, 8, new DateTime(2023, 1, 27, 14, 5, 47, 893, DateTimeKind.Unspecified), new DateTime(2023, 1, 27, 18, 5, 47, 893, DateTimeKind.Unspecified) },
                    { 30, 7, new DateTime(2023, 3, 31, 4, 36, 27, 30, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 11, 36, 27, 30, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2023, 3, 11, 3, 12, 17, 924, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 7, 12, 17, 924, DateTimeKind.Unspecified) },
                    { 32, 8, new DateTime(2023, 3, 3, 13, 50, 59, 137, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 20, 50, 59, 137, DateTimeKind.Unspecified) },
                    { 33, 5, new DateTime(2023, 4, 25, 2, 14, 41, 706, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 5, 14, 41, 706, DateTimeKind.Unspecified) },
                    { 34, 9, new DateTime(2023, 3, 21, 19, 56, 20, 851, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 4, 56, 20, 851, DateTimeKind.Unspecified) },
                    { 35, 5, new DateTime(2023, 2, 26, 13, 40, 49, 479, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 16, 40, 49, 479, DateTimeKind.Unspecified) },
                    { 36, 8, new DateTime(2023, 1, 22, 0, 3, 46, 779, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 10, 3, 46, 779, DateTimeKind.Unspecified) },
                    { 37, 1, new DateTime(2023, 4, 10, 15, 26, 42, 74, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 23, 26, 42, 74, DateTimeKind.Unspecified) },
                    { 38, 5, new DateTime(2023, 3, 21, 18, 42, 52, 145, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 0, 42, 52, 145, DateTimeKind.Unspecified) },
                    { 39, 4, new DateTime(2023, 3, 7, 0, 37, 42, 458, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 3, 37, 42, 458, DateTimeKind.Unspecified) },
                    { 40, 1, new DateTime(2023, 4, 15, 21, 2, 5, 439, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 23, 2, 5, 439, DateTimeKind.Unspecified) },
                    { 41, 8, new DateTime(2023, 1, 27, 5, 29, 34, 126, DateTimeKind.Unspecified), new DateTime(2023, 1, 27, 6, 29, 34, 126, DateTimeKind.Unspecified) },
                    { 42, 1, new DateTime(2023, 3, 17, 19, 51, 36, 228, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 22, 51, 36, 228, DateTimeKind.Unspecified) },
                    { 43, 5, new DateTime(2023, 4, 7, 14, 11, 59, 419, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 17, 11, 59, 419, DateTimeKind.Unspecified) },
                    { 44, 6, new DateTime(2023, 4, 15, 13, 18, 40, 748, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 18, 18, 40, 748, DateTimeKind.Unspecified) },
                    { 45, 9, new DateTime(2023, 3, 5, 15, 52, 48, 713, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 1, 52, 48, 713, DateTimeKind.Unspecified) },
                    { 46, 7, new DateTime(2023, 3, 31, 21, 39, 1, 862, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 0, 39, 1, 862, DateTimeKind.Unspecified) },
                    { 47, 9, new DateTime(2023, 4, 26, 20, 47, 56, 313, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 21, 47, 56, 313, DateTimeKind.Unspecified) },
                    { 48, 5, new DateTime(2023, 4, 7, 20, 4, 13, 212, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 1, 4, 13, 212, DateTimeKind.Unspecified) },
                    { 49, 6, new DateTime(2023, 1, 30, 9, 54, 17, 73, DateTimeKind.Unspecified), new DateTime(2023, 1, 30, 18, 54, 17, 73, DateTimeKind.Unspecified) },
                    { 50, 8, new DateTime(2023, 2, 4, 11, 43, 34, 472, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 19, 43, 34, 472, DateTimeKind.Unspecified) },
                    { 51, 2, new DateTime(2023, 4, 23, 4, 18, 57, 765, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 14, 18, 57, 765, DateTimeKind.Unspecified) },
                    { 52, 7, new DateTime(2023, 4, 20, 17, 40, 6, 541, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 0, 40, 6, 541, DateTimeKind.Unspecified) },
                    { 53, 1, new DateTime(2023, 2, 1, 13, 47, 8, 89, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 19, 47, 8, 89, DateTimeKind.Unspecified) },
                    { 54, 6, new DateTime(2023, 1, 8, 15, 22, 13, 504, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 23, 22, 13, 504, DateTimeKind.Unspecified) },
                    { 55, 4, new DateTime(2023, 4, 23, 23, 38, 42, 360, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 7, 38, 42, 360, DateTimeKind.Unspecified) },
                    { 56, 2, new DateTime(2023, 3, 21, 0, 55, 56, 905, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 4, 55, 56, 905, DateTimeKind.Unspecified) },
                    { 57, 8, new DateTime(2023, 4, 1, 14, 6, 17, 370, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 16, 6, 17, 370, DateTimeKind.Unspecified) },
                    { 58, 8, new DateTime(2023, 1, 17, 9, 14, 0, 369, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 18, 14, 0, 369, DateTimeKind.Unspecified) },
                    { 59, 8, new DateTime(2023, 2, 24, 7, 12, 26, 369, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 12, 12, 26, 369, DateTimeKind.Unspecified) },
                    { 60, 8, new DateTime(2023, 4, 4, 7, 43, 9, 872, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 14, 43, 9, 872, DateTimeKind.Unspecified) },
                    { 61, 7, new DateTime(2023, 1, 25, 11, 37, 48, 552, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 14, 37, 48, 552, DateTimeKind.Unspecified) },
                    { 62, 9, new DateTime(2023, 4, 9, 15, 38, 7, 70, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 1, 38, 7, 70, DateTimeKind.Unspecified) },
                    { 63, 4, new DateTime(2023, 2, 23, 13, 14, 13, 793, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 23, 14, 13, 793, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 6, new DateTime(2023, 2, 11, 8, 32, 27, 339, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 15, 32, 27, 339, DateTimeKind.Unspecified) },
                    { 65, 2, new DateTime(2023, 2, 19, 0, 44, 31, 176, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 1, 44, 31, 176, DateTimeKind.Unspecified) },
                    { 66, 4, new DateTime(2023, 2, 8, 0, 13, 43, 208, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 4, 13, 43, 208, DateTimeKind.Unspecified) },
                    { 67, 5, new DateTime(2023, 1, 29, 13, 40, 10, 877, DateTimeKind.Unspecified), new DateTime(2023, 1, 29, 17, 40, 10, 877, DateTimeKind.Unspecified) },
                    { 68, 9, new DateTime(2023, 4, 8, 19, 18, 59, 475, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 1, 18, 59, 475, DateTimeKind.Unspecified) },
                    { 69, 6, new DateTime(2023, 2, 19, 6, 24, 6, 137, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 8, 24, 6, 137, DateTimeKind.Unspecified) },
                    { 70, 5, new DateTime(2023, 1, 5, 15, 8, 10, 103, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 21, 8, 10, 103, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 3, 24, 11, 9, 12, 211, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 14, 9, 12, 211, DateTimeKind.Unspecified) },
                    { 72, 9, new DateTime(2023, 2, 27, 6, 31, 15, 185, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 15, 31, 15, 185, DateTimeKind.Unspecified) },
                    { 73, 2, new DateTime(2023, 3, 24, 19, 25, 4, 4, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 1, 25, 4, 4, DateTimeKind.Unspecified) },
                    { 74, 7, new DateTime(2023, 2, 21, 1, 43, 51, 491, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 6, 43, 51, 491, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 4, 10, 11, 3, 7, 883, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 14, 3, 7, 883, DateTimeKind.Unspecified) },
                    { 76, 4, new DateTime(2023, 2, 14, 21, 26, 15, 296, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 6, 26, 15, 296, DateTimeKind.Unspecified) },
                    { 77, 1, new DateTime(2023, 4, 4, 16, 27, 56, 697, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 17, 27, 56, 697, DateTimeKind.Unspecified) },
                    { 78, 4, new DateTime(2023, 4, 20, 2, 47, 47, 824, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 3, 47, 47, 824, DateTimeKind.Unspecified) },
                    { 79, 8, new DateTime(2023, 1, 17, 14, 54, 7, 868, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 23, 54, 7, 868, DateTimeKind.Unspecified) },
                    { 80, 7, new DateTime(2023, 2, 23, 11, 46, 18, 992, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 19, 46, 18, 992, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 1, 12, 9, 45, 0, 113, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 15, 45, 0, 113, DateTimeKind.Unspecified) },
                    { 82, 7, new DateTime(2023, 1, 19, 16, 3, 2, 200, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 18, 3, 2, 200, DateTimeKind.Unspecified) },
                    { 83, 7, new DateTime(2023, 1, 1, 0, 49, 40, 88, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 8, 49, 40, 88, DateTimeKind.Unspecified) },
                    { 84, 5, new DateTime(2023, 4, 30, 8, 6, 3, 4, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 12, 6, 3, 4, DateTimeKind.Unspecified) },
                    { 85, 3, new DateTime(2023, 1, 15, 12, 30, 30, 592, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 19, 30, 30, 592, DateTimeKind.Unspecified) },
                    { 86, 7, new DateTime(2023, 2, 6, 18, 17, 2, 111, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 1, 17, 2, 111, DateTimeKind.Unspecified) },
                    { 87, 9, new DateTime(2023, 2, 8, 17, 17, 5, 234, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 22, 17, 5, 234, DateTimeKind.Unspecified) },
                    { 88, 5, new DateTime(2023, 1, 31, 12, 41, 32, 703, DateTimeKind.Unspecified), new DateTime(2023, 1, 31, 18, 41, 32, 703, DateTimeKind.Unspecified) },
                    { 89, 8, new DateTime(2023, 4, 19, 12, 24, 30, 991, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 16, 24, 30, 991, DateTimeKind.Unspecified) },
                    { 90, 3, new DateTime(2023, 2, 20, 22, 14, 26, 449, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 1, 14, 26, 449, DateTimeKind.Unspecified) },
                    { 91, 1, new DateTime(2023, 4, 27, 8, 17, 35, 94, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 9, 17, 35, 94, DateTimeKind.Unspecified) },
                    { 92, 4, new DateTime(2023, 3, 21, 15, 4, 45, 492, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 0, 4, 45, 492, DateTimeKind.Unspecified) },
                    { 93, 7, new DateTime(2023, 1, 28, 17, 43, 28, 766, DateTimeKind.Unspecified), new DateTime(2023, 1, 28, 23, 43, 28, 766, DateTimeKind.Unspecified) },
                    { 94, 6, new DateTime(2023, 3, 31, 13, 5, 26, 335, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 19, 5, 26, 335, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 2, 14, 0, 25, 20, 422, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 2, 25, 20, 422, DateTimeKind.Unspecified) },
                    { 96, 5, new DateTime(2023, 4, 10, 22, 27, 51, 556, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 8, 27, 51, 556, DateTimeKind.Unspecified) },
                    { 97, 4, new DateTime(2023, 2, 7, 10, 36, 37, 66, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 15, 36, 37, 66, DateTimeKind.Unspecified) },
                    { 98, 8, new DateTime(2023, 1, 20, 4, 19, 26, 184, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 5, 19, 26, 184, DateTimeKind.Unspecified) },
                    { 99, 1, new DateTime(2023, 4, 25, 13, 19, 24, 365, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 21, 19, 24, 365, DateTimeKind.Unspecified) },
                    { 100, 1, new DateTime(2023, 4, 4, 2, 0, 36, 451, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 6, 0, 36, 451, DateTimeKind.Unspecified) },
                    { 101, 3, new DateTime(2023, 1, 24, 20, 58, 3, 857, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 22, 58, 3, 857, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4806), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(4807), 1198m },
                    { 3, 1, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5531), 699m },
                    { 4, 9, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5550), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 4, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5558), 699m },
                    { 6, 9, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5567), 699m },
                    { 7, 6, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5575), 699m },
                    { 8, 2, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5605), 699m },
                    { 9, 3, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5615), 699m },
                    { 10, 7, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5623), 699m },
                    { 11, 2, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5631), 699m },
                    { 12, 9, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5646), 699m },
                    { 13, 1, false, new DateTime(2023, 5, 8, 12, 11, 23, 945, DateTimeKind.Local).AddTicks(5654), 699m }
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
