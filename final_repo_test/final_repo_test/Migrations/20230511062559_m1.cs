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
                    { 1, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9427), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9428), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                columns: new[] { "E_ID", "E_Address", "E_Birthday", "E_Email", "E_Gender", "E_HireDate", "E_Name", "E_Permission", "E_Phone", "E_Pwd", "E_Title", "E_UserName", "E_Work" },
                values: new object[,]
                {
                    { 1, "高雄市前金區", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "k@gmail.com", 0, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 1, "0917351486", "k", 0, "1", true },
                    { 2, "高雄市前金區", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "qu@gmail.com", 1, new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0916229743", "qu", 0, "2", true },
                    { 3, "高雄市前金區", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "apv@gmail.com", 0, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0911591569", "apv", 1, "3", true },
                    { 4, "高雄市前金區", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "kl4x@gmail.com", 0, new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0910411098", "kl4x", 0, "4", true },
                    { 5, "高雄市前金區", new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fksd0@gmail.com", 1, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 2, "0919385711", "fksd0", 0, "5", true },
                    { 6, "高雄市前金區", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "rcjble@gmail.com", 1, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0917387026", "rcjble", 1, "6", true },
                    { 7, "高雄市前金區", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "hjucmy1@gmail.com", 0, new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0913099648", "hjucmy1", 0, "7", true },
                    { 8, "高雄市前金區", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "7b7i231q@gmail.com", 0, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 1, "0912917795", "7b7i231q", 1, "8", true },
                    { 9, "高雄市前金區", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "1czbdgn7n@gmail.com", 1, new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0917014487", "1czbdgn7n", 0, "9", true }
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
                    { 1, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9437), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9439), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9311), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9307), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9322), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9321), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9328), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9327), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9333), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9332), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9338), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9338), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9344), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9344), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9349), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9349), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9355), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9354), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9359), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9359), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9365), "Test", 99, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9364), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 99, 7, "", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 2, 15000, 1, 30, 17, "", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 },
                    { 3, 15000, 1, 123, 11, "", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 4, 15000, 1, 34, 7, "", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 5, 15000, 1, 87, 8, "", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 6, 15000, 1, 99, 7, "", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 },
                    { 7, 15000, 1, 42, 14, "", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 },
                    { 8, 15000, 1, 50, 9, "", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 9, 15000, 1, 118, 17, "", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 10, 15000, 1, 98, 9, "", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 11, 15000, 1, 212, 15, "", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 3 },
                    { 12, 15000, 1, 226, 11, "", new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 12 },
                    { 13, 15000, 1, 157, 9, "", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 14, 15000, 1, 165, 15, "", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 15, 15000, 1, 231, 7, "", new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 16, 15000, 1, 75, 15, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 6 },
                    { 17, 15000, 1, 171, 8, "", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 3 },
                    { 18, 15000, 1, 76, 15, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 4 },
                    { 19, 15000, 1, 208, 12, "", new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 7 },
                    { 20, 15000, 1, 122, 9, "", new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5 },
                    { 21, 15000, 1, 233, 9, "", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 6 },
                    { 22, 15000, 1, 79, 18, "", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 23, 15000, 1, 75, 23, "", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 24, 15000, 1, 124, 21, "", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 25, 15000, 1, 117, 9, "", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5 },
                    { 26, 15000, 1, 62, 19, "", new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 4 },
                    { 27, 15000, 1, 210, 22, "", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 28, 15000, 1, 35, 18, "", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 15 },
                    { 29, 15000, 1, 144, 18, "", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9414), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9415), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 4, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8803) },
                    { 2, 8, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8847) },
                    { 3, 5, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8849) },
                    { 4, 1, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8850) },
                    { 5, 10, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8852) },
                    { 6, 5, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8854) },
                    { 7, 1, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8856) },
                    { 8, 5, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8857) },
                    { 9, 1, null, "test", true, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8858) },
                    { 10, 6, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8861) },
                    { 11, 5, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8862) },
                    { 12, 9, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8863) },
                    { 13, 1, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8884) },
                    { 14, 6, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8886) },
                    { 15, 4, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8887) },
                    { 16, 10, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8888) },
                    { 17, 4, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8889) },
                    { 18, 9, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8891) },
                    { 19, 5, null, "test", false, new DateTime(2023, 5, 11, 14, 25, 59, 417, DateTimeKind.Local).AddTicks(8892) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 2, 25, 3, 33, 16, 901, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 13, 33, 16, 901, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(2023, 3, 16, 13, 58, 9, 712, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 16, 58, 9, 712, DateTimeKind.Unspecified) },
                    { 3, 5, new DateTime(2023, 4, 19, 18, 56, 13, 633, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 0, 56, 13, 633, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 5, 13, 2, 34, 54, 913, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 11, 34, 54, 913, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2023, 4, 1, 19, 19, 50, 98, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 5, 19, 50, 98, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(2023, 2, 13, 0, 39, 36, 583, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 10, 39, 36, 583, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 3, 8, 15, 31, 0, 741, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 0, 31, 0, 741, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 4, 22, 14, 37, 10, 322, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 23, 37, 10, 322, DateTimeKind.Unspecified) },
                    { 9, 6, new DateTime(2023, 2, 7, 18, 40, 25, 232, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 23, 40, 25, 232, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 2, 4, 18, 30, 3, 916, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 0, 30, 3, 916, DateTimeKind.Unspecified) },
                    { 11, 5, new DateTime(2023, 3, 31, 0, 5, 34, 956, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 8, 5, 34, 956, DateTimeKind.Unspecified) },
                    { 12, 3, new DateTime(2023, 3, 16, 6, 42, 3, 807, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 12, 42, 3, 807, DateTimeKind.Unspecified) },
                    { 13, 6, new DateTime(2023, 2, 17, 19, 24, 54, 609, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 2, 24, 54, 609, DateTimeKind.Unspecified) },
                    { 14, 7, new DateTime(2023, 5, 7, 15, 40, 37, 645, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 17, 40, 37, 645, DateTimeKind.Unspecified) },
                    { 15, 9, new DateTime(2023, 2, 26, 16, 49, 10, 656, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 18, 49, 10, 656, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 5, 13, 1, 58, 11, 554, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 11, 58, 11, 554, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2023, 5, 2, 1, 24, 26, 952, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 8, 24, 26, 952, DateTimeKind.Unspecified) },
                    { 18, 9, new DateTime(2023, 4, 24, 21, 37, 57, 914, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 22, 37, 57, 914, DateTimeKind.Unspecified) },
                    { 19, 7, new DateTime(2023, 2, 8, 9, 9, 26, 749, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 18, 9, 26, 749, DateTimeKind.Unspecified) },
                    { 20, 7, new DateTime(2023, 4, 25, 0, 6, 30, 717, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 10, 6, 30, 717, DateTimeKind.Unspecified) },
                    { 21, 1, new DateTime(2023, 5, 26, 11, 43, 38, 483, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 15, 43, 38, 483, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 9, new DateTime(2023, 2, 6, 10, 8, 59, 93, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 11, 8, 59, 93, DateTimeKind.Unspecified) },
                    { 23, 7, new DateTime(2023, 4, 18, 14, 18, 41, 610, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 19, 18, 41, 610, DateTimeKind.Unspecified) },
                    { 24, 8, new DateTime(2023, 4, 16, 6, 9, 55, 976, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 9, 9, 55, 976, DateTimeKind.Unspecified) },
                    { 25, 4, new DateTime(2023, 2, 11, 15, 54, 4, 80, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 22, 54, 4, 80, DateTimeKind.Unspecified) },
                    { 26, 1, new DateTime(2023, 4, 17, 19, 56, 8, 419, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 21, 56, 8, 419, DateTimeKind.Unspecified) },
                    { 27, 6, new DateTime(2023, 3, 14, 3, 51, 58, 172, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 9, 51, 58, 172, DateTimeKind.Unspecified) },
                    { 28, 8, new DateTime(2023, 2, 24, 6, 28, 18, 774, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 15, 28, 18, 774, DateTimeKind.Unspecified) },
                    { 29, 9, new DateTime(2023, 5, 20, 12, 31, 57, 6, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 22, 31, 57, 6, DateTimeKind.Unspecified) },
                    { 30, 6, new DateTime(2023, 2, 17, 8, 51, 4, 797, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 12, 51, 4, 797, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2023, 2, 8, 9, 27, 18, 525, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 12, 27, 18, 525, DateTimeKind.Unspecified) },
                    { 32, 7, new DateTime(2023, 3, 9, 6, 2, 5, 323, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 7, 2, 5, 323, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2023, 5, 30, 11, 7, 52, 972, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 17, 7, 52, 972, DateTimeKind.Unspecified) },
                    { 34, 9, new DateTime(2023, 4, 8, 18, 28, 53, 958, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 2, 28, 53, 958, DateTimeKind.Unspecified) },
                    { 35, 2, new DateTime(2023, 3, 17, 8, 59, 18, 710, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 15, 59, 18, 710, DateTimeKind.Unspecified) },
                    { 36, 3, new DateTime(2023, 4, 30, 12, 1, 9, 974, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 20, 1, 9, 974, DateTimeKind.Unspecified) },
                    { 37, 6, new DateTime(2023, 3, 31, 9, 25, 11, 743, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 17, 25, 11, 743, DateTimeKind.Unspecified) },
                    { 38, 7, new DateTime(2023, 2, 25, 8, 17, 3, 382, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 12, 17, 3, 382, DateTimeKind.Unspecified) },
                    { 39, 3, new DateTime(2023, 2, 25, 15, 46, 57, 255, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 22, 46, 57, 255, DateTimeKind.Unspecified) },
                    { 40, 5, new DateTime(2023, 3, 15, 2, 48, 9, 198, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 10, 48, 9, 198, DateTimeKind.Unspecified) },
                    { 41, 7, new DateTime(2023, 2, 26, 8, 35, 24, 585, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 10, 35, 24, 585, DateTimeKind.Unspecified) },
                    { 42, 4, new DateTime(2023, 3, 12, 22, 7, 15, 775, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 0, 7, 15, 775, DateTimeKind.Unspecified) },
                    { 43, 2, new DateTime(2023, 5, 16, 0, 7, 10, 584, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 2, 7, 10, 584, DateTimeKind.Unspecified) },
                    { 44, 6, new DateTime(2023, 5, 8, 17, 10, 44, 337, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 23, 10, 44, 337, DateTimeKind.Unspecified) },
                    { 45, 5, new DateTime(2023, 2, 16, 11, 3, 3, 857, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 20, 3, 3, 857, DateTimeKind.Unspecified) },
                    { 46, 4, new DateTime(2023, 4, 10, 4, 20, 23, 15, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 12, 20, 23, 15, DateTimeKind.Unspecified) },
                    { 47, 4, new DateTime(2023, 4, 2, 17, 45, 24, 267, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 45, 24, 267, DateTimeKind.Unspecified) },
                    { 48, 3, new DateTime(2023, 2, 6, 14, 36, 27, 670, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 16, 36, 27, 670, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2023, 3, 23, 10, 10, 36, 294, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 16, 10, 36, 294, DateTimeKind.Unspecified) },
                    { 50, 2, new DateTime(2023, 2, 15, 20, 42, 46, 974, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 6, 42, 46, 974, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2023, 4, 14, 3, 12, 42, 188, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 9, 12, 42, 188, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2023, 4, 1, 20, 31, 2, 198, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 21, 31, 2, 198, DateTimeKind.Unspecified) },
                    { 53, 4, new DateTime(2023, 5, 17, 10, 25, 25, 841, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 13, 25, 25, 841, DateTimeKind.Unspecified) },
                    { 54, 2, new DateTime(2023, 5, 10, 9, 38, 29, 493, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 15, 38, 29, 493, DateTimeKind.Unspecified) },
                    { 55, 6, new DateTime(2023, 3, 4, 0, 15, 9, 107, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 8, 15, 9, 107, DateTimeKind.Unspecified) },
                    { 56, 9, new DateTime(2023, 5, 16, 11, 40, 16, 722, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 15, 40, 16, 722, DateTimeKind.Unspecified) },
                    { 57, 8, new DateTime(2023, 2, 9, 1, 18, 46, 430, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 2, 18, 46, 430, DateTimeKind.Unspecified) },
                    { 58, 5, new DateTime(2023, 3, 31, 12, 21, 25, 480, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 22, 21, 25, 480, DateTimeKind.Unspecified) },
                    { 59, 3, new DateTime(2023, 2, 15, 8, 19, 50, 703, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 13, 19, 50, 703, DateTimeKind.Unspecified) },
                    { 60, 1, new DateTime(2023, 5, 10, 0, 40, 42, 124, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 10, 40, 42, 124, DateTimeKind.Unspecified) },
                    { 61, 9, new DateTime(2023, 4, 4, 8, 34, 24, 130, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 12, 34, 24, 130, DateTimeKind.Unspecified) },
                    { 62, 8, new DateTime(2023, 2, 18, 2, 1, 12, 294, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 11, 1, 12, 294, DateTimeKind.Unspecified) },
                    { 63, 6, new DateTime(2023, 2, 23, 11, 20, 2, 326, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 12, 20, 2, 326, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 3, new DateTime(2023, 2, 18, 6, 23, 18, 441, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 14, 23, 18, 441, DateTimeKind.Unspecified) },
                    { 65, 9, new DateTime(2023, 4, 14, 2, 13, 24, 530, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 5, 13, 24, 530, DateTimeKind.Unspecified) },
                    { 66, 3, new DateTime(2023, 4, 25, 2, 43, 54, 822, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 12, 43, 54, 822, DateTimeKind.Unspecified) },
                    { 67, 4, new DateTime(2023, 5, 11, 2, 0, 54, 378, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 10, 0, 54, 378, DateTimeKind.Unspecified) },
                    { 68, 4, new DateTime(2023, 3, 21, 7, 39, 46, 430, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 9, 39, 46, 430, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 5, 27, 9, 57, 21, 818, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 19, 57, 21, 818, DateTimeKind.Unspecified) },
                    { 70, 3, new DateTime(2023, 4, 14, 17, 26, 7, 365, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 22, 26, 7, 365, DateTimeKind.Unspecified) },
                    { 71, 8, new DateTime(2023, 5, 19, 13, 43, 48, 670, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 19, 43, 48, 670, DateTimeKind.Unspecified) },
                    { 72, 4, new DateTime(2023, 3, 1, 0, 40, 17, 727, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 6, 40, 17, 727, DateTimeKind.Unspecified) },
                    { 73, 2, new DateTime(2023, 5, 25, 23, 16, 30, 929, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 8, 16, 30, 929, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2023, 5, 1, 12, 57, 22, 282, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 19, 57, 22, 282, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 5, 2, 1, 44, 6, 856, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 2, 44, 6, 856, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 2, 27, 3, 59, 3, 626, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 9, 59, 3, 626, DateTimeKind.Unspecified) },
                    { 77, 4, new DateTime(2023, 3, 16, 2, 36, 33, 10, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 11, 36, 33, 10, DateTimeKind.Unspecified) },
                    { 78, 2, new DateTime(2023, 2, 16, 15, 45, 40, 616, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 20, 45, 40, 616, DateTimeKind.Unspecified) },
                    { 79, 9, new DateTime(2023, 2, 1, 16, 7, 0, 490, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 2, 7, 0, 490, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2023, 2, 28, 22, 54, 39, 854, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 4, 54, 39, 854, DateTimeKind.Unspecified) },
                    { 81, 4, new DateTime(2023, 3, 9, 11, 2, 21, 249, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 14, 2, 21, 249, DateTimeKind.Unspecified) },
                    { 82, 2, new DateTime(2023, 3, 13, 6, 31, 50, 559, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 9, 31, 50, 559, DateTimeKind.Unspecified) },
                    { 83, 2, new DateTime(2023, 2, 9, 11, 35, 38, 554, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 14, 35, 38, 554, DateTimeKind.Unspecified) },
                    { 84, 4, new DateTime(2023, 4, 4, 20, 47, 10, 91, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 3, 47, 10, 91, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 5, 31, 15, 26, 46, 766, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 22, 26, 46, 766, DateTimeKind.Unspecified) },
                    { 86, 4, new DateTime(2023, 4, 19, 3, 23, 44, 394, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 9, 23, 44, 394, DateTimeKind.Unspecified) },
                    { 87, 4, new DateTime(2023, 4, 27, 15, 56, 54, 136, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 0, 56, 54, 136, DateTimeKind.Unspecified) },
                    { 88, 4, new DateTime(2023, 4, 17, 5, 10, 6, 186, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 8, 10, 6, 186, DateTimeKind.Unspecified) },
                    { 89, 9, new DateTime(2023, 5, 18, 12, 42, 34, 10, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 18, 42, 34, 10, DateTimeKind.Unspecified) },
                    { 90, 8, new DateTime(2023, 4, 5, 8, 28, 26, 581, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 16, 28, 26, 581, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 4, 1, 1, 31, 3, 945, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 6, 31, 3, 945, DateTimeKind.Unspecified) },
                    { 92, 1, new DateTime(2023, 3, 14, 12, 58, 3, 539, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 17, 58, 3, 539, DateTimeKind.Unspecified) },
                    { 93, 5, new DateTime(2023, 4, 1, 7, 37, 58, 388, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 14, 37, 58, 388, DateTimeKind.Unspecified) },
                    { 94, 4, new DateTime(2023, 5, 4, 2, 39, 21, 387, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 10, 39, 21, 387, DateTimeKind.Unspecified) },
                    { 95, 9, new DateTime(2023, 2, 10, 12, 35, 4, 162, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 19, 35, 4, 162, DateTimeKind.Unspecified) },
                    { 96, 6, new DateTime(2023, 2, 21, 1, 49, 22, 938, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 2, 49, 22, 938, DateTimeKind.Unspecified) },
                    { 97, 3, new DateTime(2023, 3, 31, 1, 40, 59, 385, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 10, 40, 59, 385, DateTimeKind.Unspecified) },
                    { 98, 4, new DateTime(2023, 2, 19, 2, 7, 32, 311, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 11, 7, 32, 311, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 4, 5, 22, 9, 42, 336, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 3, 9, 42, 336, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2023, 4, 29, 17, 9, 6, 283, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 3, 9, 6, 283, DateTimeKind.Unspecified) },
                    { 101, 8, new DateTime(2023, 2, 16, 8, 7, 19, 214, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 17, 7, 19, 214, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9447), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 11, 14, 25, 59, 418, DateTimeKind.Local).AddTicks(9448), 1198m },
                    { 3, 3, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(90), 699m },
                    { 4, 3, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(101), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 1, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(117), 699m },
                    { 6, 1, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(126), 699m },
                    { 7, 7, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(135), 699m },
                    { 8, 2, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(143), 699m },
                    { 9, 6, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(192), 699m },
                    { 10, 9, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(202), 699m },
                    { 11, 2, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(211), 699m },
                    { 12, 5, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(219), 699m },
                    { 13, 1, false, new DateTime(2023, 5, 11, 14, 25, 59, 419, DateTimeKind.Local).AddTicks(235), 699m }
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
