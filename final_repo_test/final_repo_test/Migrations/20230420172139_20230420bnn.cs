using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class _20230420bnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ads_OrderStatus",
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
                    table.PrimaryKey("PK_Ads_OrderStatus", x => x.OS_ID);
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
                        name: "FK_Ads_Ads_OrderStatus_OS_ID",
                        column: x => x.OS_ID,
                        principalTable: "Ads_OrderStatus",
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
                    { 1, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3037), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3039), "200元換350點", false, "點數.png", "200元換350點", 200 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3054), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3056), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2823), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2818), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2843), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2842), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2854), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2854), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2866), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2865), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2877), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2876), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2946), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2945), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2958), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2957), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2969), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2968), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2980), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2979), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2993), "Test", 99, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(2992), 1, "Test", "Test" }
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
                    { 1, 9, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9369) },
                    { 2, 6, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9414) },
                    { 3, 5, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9416) },
                    { 4, 8, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9418) },
                    { 5, 10, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9420) },
                    { 6, 3, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9424) },
                    { 7, 3, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9426) },
                    { 8, 9, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9427) },
                    { 9, 6, null, "test", true, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9429) },
                    { 10, 5, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9433) },
                    { 11, 1, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9435) },
                    { 12, 3, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9437) },
                    { 13, 3, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9439) },
                    { 14, 7, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9440) },
                    { 15, 8, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9442) },
                    { 16, 5, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9444) },
                    { 17, 8, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9446) },
                    { 18, 3, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9449) },
                    { 19, 6, null, "test", false, new DateTime(2023, 4, 21, 1, 21, 39, 237, DateTimeKind.Local).AddTicks(9451) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 30, 5, 47, 17, 647, DateTimeKind.Unspecified), new DateTime(2023, 1, 30, 10, 47, 17, 647, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 1, 24, 10, 9, 12, 41, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 13, 9, 12, 41, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(2023, 4, 17, 18, 11, 32, 149, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 23, 11, 32, 149, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2023, 1, 8, 7, 33, 37, 582, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 9, 33, 37, 582, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2023, 4, 17, 16, 45, 57, 40, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 1, 45, 57, 40, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2023, 2, 23, 2, 32, 14, 837, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 9, 32, 14, 837, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2023, 1, 26, 10, 5, 12, 886, DateTimeKind.Unspecified), new DateTime(2023, 1, 26, 11, 5, 12, 886, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 1, 15, 2, 52, 47, 15, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 6, 52, 47, 15, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2023, 4, 3, 14, 44, 44, 714, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 16, 44, 44, 714, DateTimeKind.Unspecified) },
                    { 10, 6, new DateTime(2023, 1, 15, 0, 28, 8, 1, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 3, 28, 8, 1, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2023, 3, 24, 7, 47, 26, 910, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 12, 47, 26, 910, DateTimeKind.Unspecified) },
                    { 12, 2, new DateTime(2023, 1, 19, 0, 4, 29, 917, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 6, 4, 29, 917, DateTimeKind.Unspecified) },
                    { 13, 3, new DateTime(2023, 2, 10, 1, 42, 6, 100, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 2, 42, 6, 100, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 1, 18, 7, 7, 13, 495, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 12, 7, 13, 495, DateTimeKind.Unspecified) },
                    { 15, 4, new DateTime(2023, 2, 2, 15, 40, 55, 313, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 1, 40, 55, 313, DateTimeKind.Unspecified) },
                    { 16, 5, new DateTime(2023, 3, 5, 23, 4, 21, 555, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 2, 4, 21, 555, DateTimeKind.Unspecified) },
                    { 17, 3, new DateTime(2023, 2, 25, 16, 13, 30, 373, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 23, 13, 30, 373, DateTimeKind.Unspecified) },
                    { 18, 4, new DateTime(2023, 1, 29, 8, 31, 26, 997, DateTimeKind.Unspecified), new DateTime(2023, 1, 29, 16, 31, 26, 997, DateTimeKind.Unspecified) },
                    { 19, 6, new DateTime(2023, 4, 21, 9, 46, 21, 149, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 16, 46, 21, 149, DateTimeKind.Unspecified) },
                    { 20, 5, new DateTime(2023, 3, 5, 4, 46, 38, 930, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 8, 46, 38, 930, DateTimeKind.Unspecified) },
                    { 21, 4, new DateTime(2023, 4, 6, 13, 16, 21, 309, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 16, 16, 21, 309, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 1, new DateTime(2023, 1, 3, 17, 57, 42, 635, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 0, 57, 42, 635, DateTimeKind.Unspecified) },
                    { 23, 5, new DateTime(2023, 3, 17, 12, 31, 38, 819, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 19, 31, 38, 819, DateTimeKind.Unspecified) },
                    { 24, 4, new DateTime(2023, 3, 9, 6, 26, 59, 93, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 11, 26, 59, 93, DateTimeKind.Unspecified) },
                    { 25, 2, new DateTime(2023, 4, 18, 7, 5, 19, 56, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 12, 5, 19, 56, DateTimeKind.Unspecified) },
                    { 26, 3, new DateTime(2023, 1, 21, 10, 34, 44, 35, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 20, 34, 44, 35, DateTimeKind.Unspecified) },
                    { 27, 8, new DateTime(2023, 1, 12, 12, 43, 49, 655, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 20, 43, 49, 655, DateTimeKind.Unspecified) },
                    { 28, 1, new DateTime(2023, 4, 22, 1, 37, 35, 218, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 2, 37, 35, 218, DateTimeKind.Unspecified) },
                    { 29, 2, new DateTime(2023, 2, 13, 4, 26, 24, 222, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 26, 24, 222, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2023, 1, 4, 12, 14, 7, 16, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 15, 14, 7, 16, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2023, 1, 8, 18, 40, 15, 557, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 22, 40, 15, 557, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2023, 3, 18, 1, 12, 28, 690, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 2, 12, 28, 690, DateTimeKind.Unspecified) },
                    { 33, 6, new DateTime(2023, 3, 21, 22, 18, 31, 557, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 6, 18, 31, 557, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2023, 2, 15, 14, 3, 21, 355, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 15, 3, 21, 355, DateTimeKind.Unspecified) },
                    { 35, 5, new DateTime(2023, 1, 20, 4, 38, 24, 32, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 11, 38, 24, 32, DateTimeKind.Unspecified) },
                    { 36, 5, new DateTime(2023, 4, 26, 15, 51, 13, 96, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 22, 51, 13, 96, DateTimeKind.Unspecified) },
                    { 37, 8, new DateTime(2023, 1, 23, 17, 12, 3, 486, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 23, 12, 3, 486, DateTimeKind.Unspecified) },
                    { 38, 9, new DateTime(2023, 1, 15, 5, 42, 7, 399, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 13, 42, 7, 399, DateTimeKind.Unspecified) },
                    { 39, 8, new DateTime(2023, 2, 28, 6, 55, 47, 853, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 13, 55, 47, 853, DateTimeKind.Unspecified) },
                    { 40, 8, new DateTime(2023, 1, 20, 6, 30, 33, 698, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 16, 30, 33, 698, DateTimeKind.Unspecified) },
                    { 41, 2, new DateTime(2023, 1, 1, 13, 42, 45, 858, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 18, 42, 45, 858, DateTimeKind.Unspecified) },
                    { 42, 7, new DateTime(2023, 2, 8, 17, 13, 57, 432, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 19, 13, 57, 432, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 2, 8, 22, 52, 21, 403, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 7, 52, 21, 403, DateTimeKind.Unspecified) },
                    { 44, 1, new DateTime(2023, 3, 19, 21, 31, 55, 215, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 6, 31, 55, 215, DateTimeKind.Unspecified) },
                    { 45, 6, new DateTime(2023, 4, 19, 5, 24, 45, 375, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 9, 24, 45, 375, DateTimeKind.Unspecified) },
                    { 46, 1, new DateTime(2023, 1, 26, 16, 51, 48, 392, DateTimeKind.Unspecified), new DateTime(2023, 1, 26, 21, 51, 48, 392, DateTimeKind.Unspecified) },
                    { 47, 9, new DateTime(2023, 2, 5, 16, 9, 8, 908, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 22, 9, 8, 908, DateTimeKind.Unspecified) },
                    { 48, 6, new DateTime(2023, 2, 27, 8, 31, 11, 112, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 17, 31, 11, 112, DateTimeKind.Unspecified) },
                    { 49, 1, new DateTime(2023, 2, 26, 12, 33, 13, 958, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 16, 33, 13, 958, DateTimeKind.Unspecified) },
                    { 50, 6, new DateTime(2023, 1, 23, 19, 30, 29, 441, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 1, 30, 29, 441, DateTimeKind.Unspecified) },
                    { 51, 6, new DateTime(2023, 1, 21, 11, 19, 28, 158, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 15, 19, 28, 158, DateTimeKind.Unspecified) },
                    { 52, 8, new DateTime(2023, 1, 21, 15, 33, 11, 956, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 21, 33, 11, 956, DateTimeKind.Unspecified) },
                    { 53, 8, new DateTime(2023, 1, 28, 22, 42, 8, 773, DateTimeKind.Unspecified), new DateTime(2023, 1, 29, 5, 42, 8, 773, DateTimeKind.Unspecified) },
                    { 54, 5, new DateTime(2023, 1, 25, 10, 54, 57, 592, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 16, 54, 57, 592, DateTimeKind.Unspecified) },
                    { 55, 5, new DateTime(2023, 1, 5, 10, 20, 58, 865, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 20, 20, 58, 865, DateTimeKind.Unspecified) },
                    { 56, 8, new DateTime(2023, 2, 20, 12, 50, 40, 923, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 17, 50, 40, 923, DateTimeKind.Unspecified) },
                    { 57, 3, new DateTime(2023, 3, 12, 12, 42, 26, 782, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 18, 42, 26, 782, DateTimeKind.Unspecified) },
                    { 58, 7, new DateTime(2023, 4, 4, 17, 2, 6, 620, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 1, 2, 6, 620, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2023, 1, 25, 21, 5, 11, 156, DateTimeKind.Unspecified), new DateTime(2023, 1, 26, 2, 5, 11, 156, DateTimeKind.Unspecified) },
                    { 60, 8, new DateTime(2023, 2, 5, 2, 31, 2, 532, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 10, 31, 2, 532, DateTimeKind.Unspecified) },
                    { 61, 3, new DateTime(2023, 3, 12, 16, 39, 3, 413, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 22, 39, 3, 413, DateTimeKind.Unspecified) },
                    { 62, 5, new DateTime(2023, 4, 11, 13, 54, 3, 905, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 21, 54, 3, 905, DateTimeKind.Unspecified) },
                    { 63, 7, new DateTime(2023, 4, 19, 4, 22, 37, 953, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 14, 22, 37, 953, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 4, new DateTime(2023, 2, 13, 2, 11, 9, 372, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 4, 11, 9, 372, DateTimeKind.Unspecified) },
                    { 65, 3, new DateTime(2023, 3, 16, 17, 29, 47, 668, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 18, 29, 47, 668, DateTimeKind.Unspecified) },
                    { 66, 9, new DateTime(2023, 2, 12, 2, 12, 2, 306, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 3, 12, 2, 306, DateTimeKind.Unspecified) },
                    { 67, 1, new DateTime(2023, 4, 9, 17, 44, 52, 108, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 2, 44, 52, 108, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2023, 4, 24, 5, 11, 28, 940, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 13, 11, 28, 940, DateTimeKind.Unspecified) },
                    { 69, 8, new DateTime(2023, 4, 10, 19, 31, 4, 533, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 23, 31, 4, 533, DateTimeKind.Unspecified) },
                    { 70, 3, new DateTime(2023, 2, 8, 9, 47, 16, 68, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 14, 47, 16, 68, DateTimeKind.Unspecified) },
                    { 71, 6, new DateTime(2023, 3, 1, 14, 38, 28, 966, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 20, 38, 28, 966, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 4, 8, 22, 9, 41, 313, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 23, 9, 41, 313, DateTimeKind.Unspecified) },
                    { 73, 6, new DateTime(2023, 2, 14, 4, 12, 54, 536, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 12, 12, 54, 536, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2023, 3, 31, 12, 8, 56, 27, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 21, 8, 56, 27, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 3, 8, 19, 51, 55, 527, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 5, 51, 55, 527, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 3, 5, 13, 5, 43, 220, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 23, 5, 43, 220, DateTimeKind.Unspecified) },
                    { 77, 4, new DateTime(2023, 3, 14, 2, 4, 3, 769, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 12, 4, 3, 769, DateTimeKind.Unspecified) },
                    { 78, 6, new DateTime(2023, 4, 23, 7, 55, 4, 842, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 12, 55, 4, 842, DateTimeKind.Unspecified) },
                    { 79, 4, new DateTime(2023, 4, 14, 13, 40, 58, 980, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 14, 40, 58, 980, DateTimeKind.Unspecified) },
                    { 80, 1, new DateTime(2023, 1, 18, 5, 18, 51, 987, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 10, 18, 51, 987, DateTimeKind.Unspecified) },
                    { 81, 9, new DateTime(2023, 3, 18, 4, 3, 27, 982, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 9, 3, 27, 982, DateTimeKind.Unspecified) },
                    { 82, 4, new DateTime(2023, 4, 20, 1, 42, 31, 300, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 5, 42, 31, 300, DateTimeKind.Unspecified) },
                    { 83, 2, new DateTime(2023, 2, 28, 11, 6, 37, 39, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 15, 6, 37, 39, DateTimeKind.Unspecified) },
                    { 84, 4, new DateTime(2023, 2, 14, 21, 18, 52, 618, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 7, 18, 52, 618, DateTimeKind.Unspecified) },
                    { 85, 8, new DateTime(2023, 3, 28, 23, 33, 43, 521, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 6, 33, 43, 521, DateTimeKind.Unspecified) },
                    { 86, 5, new DateTime(2023, 2, 9, 1, 56, 54, 517, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 8, 56, 54, 517, DateTimeKind.Unspecified) },
                    { 87, 6, new DateTime(2023, 4, 16, 22, 8, 51, 91, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 5, 8, 51, 91, DateTimeKind.Unspecified) },
                    { 88, 4, new DateTime(2023, 2, 14, 18, 27, 16, 579, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 2, 27, 16, 579, DateTimeKind.Unspecified) },
                    { 89, 7, new DateTime(2023, 3, 28, 5, 57, 17, 975, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 13, 57, 17, 975, DateTimeKind.Unspecified) },
                    { 90, 2, new DateTime(2023, 2, 11, 13, 23, 50, 261, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 19, 23, 50, 261, DateTimeKind.Unspecified) },
                    { 91, 5, new DateTime(2023, 4, 16, 1, 52, 57, 100, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 7, 52, 57, 100, DateTimeKind.Unspecified) },
                    { 92, 1, new DateTime(2023, 3, 2, 0, 27, 30, 139, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 10, 27, 30, 139, DateTimeKind.Unspecified) },
                    { 93, 1, new DateTime(2023, 1, 31, 5, 57, 27, 146, DateTimeKind.Unspecified), new DateTime(2023, 1, 31, 8, 57, 27, 146, DateTimeKind.Unspecified) },
                    { 94, 2, new DateTime(2023, 2, 25, 15, 30, 19, 768, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 21, 30, 19, 768, DateTimeKind.Unspecified) },
                    { 95, 8, new DateTime(2023, 2, 19, 21, 8, 24, 731, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 22, 8, 24, 731, DateTimeKind.Unspecified) },
                    { 96, 5, new DateTime(2023, 1, 27, 21, 26, 18, 917, DateTimeKind.Unspecified), new DateTime(2023, 1, 28, 6, 26, 18, 917, DateTimeKind.Unspecified) },
                    { 97, 8, new DateTime(2023, 1, 31, 1, 54, 51, 686, DateTimeKind.Unspecified), new DateTime(2023, 1, 31, 3, 54, 51, 686, DateTimeKind.Unspecified) },
                    { 98, 8, new DateTime(2023, 3, 3, 17, 15, 17, 993, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 0, 15, 17, 993, DateTimeKind.Unspecified) },
                    { 99, 5, new DateTime(2023, 4, 4, 13, 30, 9, 369, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 23, 30, 9, 369, DateTimeKind.Unspecified) },
                    { 100, 3, new DateTime(2023, 2, 28, 13, 42, 59, 429, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 23, 42, 59, 429, DateTimeKind.Unspecified) },
                    { 101, 1, new DateTime(2023, 1, 15, 19, 13, 16, 272, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 22, 13, 16, 272, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3070), 2396m },
                    { 2, 1, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3072), 1198m },
                    { 3, 2, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3112), 699m },
                    { 4, 4, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3135), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 9, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3156), 699m },
                    { 6, 9, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3189), 699m },
                    { 7, 3, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3209), 699m },
                    { 8, 1, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3302), 699m },
                    { 9, 6, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3323), 699m },
                    { 10, 3, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3347), 699m },
                    { 11, 1, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3367), 699m },
                    { 12, 6, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3387), 699m },
                    { 13, 9, false, new DateTime(2023, 4, 21, 1, 21, 39, 239, DateTimeKind.Local).AddTicks(3407), 699m }
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
                name: "Ads_OrderStatus");

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
