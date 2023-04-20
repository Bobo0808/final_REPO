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
                    D_isSolved = table.Column<bool>(type: "bit", nullable: false)
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
                    { 1, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5126), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5127), "200元換350點", false, "點數.png", "200元換350點", 200 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5141), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5143), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(4987), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(4982), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5004), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5003), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5013), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5013), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5023), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5022), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5032), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5031), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5044), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5043), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5053), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5052), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5062), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5062), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5072), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5071), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5082), "Test", 99, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5082), 1, "Test", "Test" }
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
                columns: new[] { "D_ID", "A_ID", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 8, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(3993) },
                    { 2, 10, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4054) },
                    { 3, 10, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4057) },
                    { 4, 6, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4059) },
                    { 5, 1, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4061) },
                    { 6, 2, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4064) },
                    { 7, 10, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4066) },
                    { 8, 3, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4068) },
                    { 9, 6, "test", true, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4070) },
                    { 10, 10, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4073) },
                    { 11, 6, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4075) },
                    { 12, 9, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4077) },
                    { 13, 7, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4079) },
                    { 14, 9, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4081) },
                    { 15, 9, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4082) },
                    { 16, 7, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4085) },
                    { 17, 7, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4143) },
                    { 18, 1, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4147) },
                    { 19, 5, "test", false, new DateTime(2023, 4, 20, 22, 51, 47, 412, DateTimeKind.Local).AddTicks(4149) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 4, 3, 6, 54, 26, 652, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 10, 54, 26, 652, DateTimeKind.Unspecified) },
                    { 2, 8, new DateTime(2023, 1, 31, 0, 43, 34, 120, DateTimeKind.Unspecified), new DateTime(2023, 1, 31, 8, 43, 34, 120, DateTimeKind.Unspecified) },
                    { 3, 7, new DateTime(2023, 1, 17, 18, 12, 33, 845, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 20, 12, 33, 845, DateTimeKind.Unspecified) },
                    { 4, 9, new DateTime(2023, 1, 19, 8, 12, 42, 953, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 9, 12, 42, 953, DateTimeKind.Unspecified) },
                    { 5, 8, new DateTime(2023, 3, 5, 23, 6, 5, 978, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 4, 6, 5, 978, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2023, 4, 7, 8, 14, 16, 328, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 9, 14, 16, 328, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 4, 21, 13, 26, 10, 286, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 16, 26, 10, 286, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(2023, 3, 2, 6, 4, 47, 539, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 9, 4, 47, 539, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2023, 3, 2, 10, 46, 21, 93, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 20, 46, 21, 93, DateTimeKind.Unspecified) },
                    { 10, 4, new DateTime(2023, 1, 31, 7, 0, 26, 625, DateTimeKind.Unspecified), new DateTime(2023, 1, 31, 8, 0, 26, 625, DateTimeKind.Unspecified) },
                    { 11, 3, new DateTime(2023, 1, 4, 23, 41, 2, 804, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 3, 41, 2, 804, DateTimeKind.Unspecified) },
                    { 12, 7, new DateTime(2023, 3, 23, 10, 49, 48, 21, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 11, 49, 48, 21, DateTimeKind.Unspecified) },
                    { 13, 4, new DateTime(2023, 1, 3, 7, 27, 22, 217, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 16, 27, 22, 217, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2023, 2, 16, 14, 38, 41, 726, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 17, 38, 41, 726, DateTimeKind.Unspecified) },
                    { 15, 7, new DateTime(2023, 3, 31, 0, 38, 29, 65, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 6, 38, 29, 65, DateTimeKind.Unspecified) },
                    { 16, 6, new DateTime(2023, 2, 12, 4, 17, 17, 365, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 7, 17, 17, 365, DateTimeKind.Unspecified) },
                    { 17, 5, new DateTime(2023, 1, 22, 18, 45, 19, 190, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 4, 45, 19, 190, DateTimeKind.Unspecified) },
                    { 18, 8, new DateTime(2023, 4, 26, 0, 42, 39, 502, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 1, 42, 39, 502, DateTimeKind.Unspecified) },
                    { 19, 9, new DateTime(2023, 1, 15, 14, 14, 46, 800, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 23, 14, 46, 800, DateTimeKind.Unspecified) },
                    { 20, 7, new DateTime(2023, 1, 3, 5, 13, 3, 440, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 7, 13, 3, 440, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 25, 15, 48, 7, 591, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 0, 48, 7, 591, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 3, new DateTime(2023, 1, 25, 17, 41, 25, 231, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 23, 41, 25, 231, DateTimeKind.Unspecified) },
                    { 23, 7, new DateTime(2023, 2, 24, 21, 56, 47, 447, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 2, 56, 47, 447, DateTimeKind.Unspecified) },
                    { 24, 9, new DateTime(2023, 3, 19, 19, 34, 58, 554, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 0, 34, 58, 554, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2023, 2, 7, 8, 59, 56, 943, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 16, 59, 56, 943, DateTimeKind.Unspecified) },
                    { 26, 6, new DateTime(2023, 3, 13, 15, 0, 56, 530, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 19, 0, 56, 530, DateTimeKind.Unspecified) },
                    { 27, 7, new DateTime(2023, 3, 14, 2, 13, 4, 690, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 10, 13, 4, 690, DateTimeKind.Unspecified) },
                    { 28, 1, new DateTime(2023, 4, 20, 19, 11, 48, 928, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 4, 11, 48, 928, DateTimeKind.Unspecified) },
                    { 29, 4, new DateTime(2023, 2, 12, 21, 57, 51, 38, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 22, 57, 51, 38, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2023, 1, 17, 15, 16, 55, 633, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 17, 16, 55, 633, DateTimeKind.Unspecified) },
                    { 31, 7, new DateTime(2023, 1, 7, 3, 39, 13, 159, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 5, 39, 13, 159, DateTimeKind.Unspecified) },
                    { 32, 3, new DateTime(2023, 2, 15, 14, 43, 57, 69, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 17, 43, 57, 69, DateTimeKind.Unspecified) },
                    { 33, 6, new DateTime(2023, 2, 21, 14, 2, 52, 41, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 21, 2, 52, 41, DateTimeKind.Unspecified) },
                    { 34, 8, new DateTime(2023, 3, 20, 17, 10, 53, 621, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 3, 10, 53, 621, DateTimeKind.Unspecified) },
                    { 35, 9, new DateTime(2023, 1, 25, 4, 44, 15, 659, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 5, 44, 15, 659, DateTimeKind.Unspecified) },
                    { 36, 7, new DateTime(2023, 2, 13, 13, 35, 2, 690, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 23, 35, 2, 690, DateTimeKind.Unspecified) },
                    { 37, 9, new DateTime(2023, 2, 2, 7, 7, 0, 624, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 9, 7, 0, 624, DateTimeKind.Unspecified) },
                    { 38, 4, new DateTime(2023, 2, 4, 14, 58, 51, 26, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 16, 58, 51, 26, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 4, 19, 11, 55, 6, 833, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 13, 55, 6, 833, DateTimeKind.Unspecified) },
                    { 40, 2, new DateTime(2023, 3, 31, 14, 2, 28, 976, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 19, 2, 28, 976, DateTimeKind.Unspecified) },
                    { 41, 1, new DateTime(2023, 2, 1, 18, 32, 50, 141, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 0, 32, 50, 141, DateTimeKind.Unspecified) },
                    { 42, 3, new DateTime(2023, 4, 15, 13, 31, 11, 937, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 23, 31, 11, 937, DateTimeKind.Unspecified) },
                    { 43, 5, new DateTime(2023, 4, 17, 22, 29, 35, 819, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 1, 29, 35, 819, DateTimeKind.Unspecified) },
                    { 44, 2, new DateTime(2023, 4, 10, 15, 38, 46, 435, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 16, 38, 46, 435, DateTimeKind.Unspecified) },
                    { 45, 9, new DateTime(2023, 3, 7, 18, 20, 49, 546, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 1, 20, 49, 546, DateTimeKind.Unspecified) },
                    { 46, 7, new DateTime(2023, 3, 6, 19, 39, 48, 535, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 22, 39, 48, 535, DateTimeKind.Unspecified) },
                    { 47, 1, new DateTime(2023, 4, 27, 10, 56, 5, 632, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 12, 56, 5, 632, DateTimeKind.Unspecified) },
                    { 48, 8, new DateTime(2023, 2, 7, 16, 8, 23, 167, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 22, 8, 23, 167, DateTimeKind.Unspecified) },
                    { 49, 2, new DateTime(2023, 3, 19, 16, 23, 34, 936, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 1, 23, 34, 936, DateTimeKind.Unspecified) },
                    { 50, 5, new DateTime(2023, 2, 9, 12, 7, 58, 546, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 14, 7, 58, 546, DateTimeKind.Unspecified) },
                    { 51, 3, new DateTime(2023, 3, 24, 2, 9, 19, 706, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 9, 9, 19, 706, DateTimeKind.Unspecified) },
                    { 52, 8, new DateTime(2023, 4, 14, 18, 38, 48, 250, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 20, 38, 48, 250, DateTimeKind.Unspecified) },
                    { 53, 6, new DateTime(2023, 1, 18, 7, 29, 49, 233, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 15, 29, 49, 233, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 3, 5, 6, 9, 35, 201, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 8, 9, 35, 201, DateTimeKind.Unspecified) },
                    { 55, 5, new DateTime(2023, 3, 11, 6, 59, 4, 916, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 8, 59, 4, 916, DateTimeKind.Unspecified) },
                    { 56, 9, new DateTime(2023, 1, 22, 12, 16, 18, 792, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 16, 16, 18, 792, DateTimeKind.Unspecified) },
                    { 57, 9, new DateTime(2023, 4, 6, 21, 52, 33, 612, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 4, 52, 33, 612, DateTimeKind.Unspecified) },
                    { 58, 4, new DateTime(2023, 1, 26, 20, 35, 37, 626, DateTimeKind.Unspecified), new DateTime(2023, 1, 26, 22, 35, 37, 626, DateTimeKind.Unspecified) },
                    { 59, 8, new DateTime(2023, 2, 6, 11, 23, 58, 705, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 15, 23, 58, 705, DateTimeKind.Unspecified) },
                    { 60, 6, new DateTime(2023, 2, 13, 20, 28, 14, 218, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 22, 28, 14, 218, DateTimeKind.Unspecified) },
                    { 61, 4, new DateTime(2023, 4, 22, 19, 40, 6, 480, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 23, 40, 6, 480, DateTimeKind.Unspecified) },
                    { 62, 9, new DateTime(2023, 3, 21, 1, 52, 50, 108, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 7, 52, 50, 108, DateTimeKind.Unspecified) },
                    { 63, 6, new DateTime(2023, 1, 15, 5, 12, 3, 189, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 11, 12, 3, 189, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 6, new DateTime(2023, 3, 22, 14, 38, 0, 452, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 20, 38, 0, 452, DateTimeKind.Unspecified) },
                    { 65, 4, new DateTime(2023, 1, 22, 1, 59, 58, 603, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 4, 59, 58, 603, DateTimeKind.Unspecified) },
                    { 66, 1, new DateTime(2023, 4, 13, 14, 43, 30, 686, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 19, 43, 30, 686, DateTimeKind.Unspecified) },
                    { 67, 3, new DateTime(2023, 4, 21, 15, 36, 5, 511, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 23, 36, 5, 511, DateTimeKind.Unspecified) },
                    { 68, 6, new DateTime(2023, 3, 29, 15, 36, 15, 290, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 1, 36, 15, 290, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 1, 5, 11, 36, 47, 806, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 18, 36, 47, 806, DateTimeKind.Unspecified) },
                    { 70, 7, new DateTime(2023, 3, 29, 4, 54, 36, 596, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 13, 54, 36, 596, DateTimeKind.Unspecified) },
                    { 71, 9, new DateTime(2023, 4, 14, 14, 34, 41, 235, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 22, 34, 41, 235, DateTimeKind.Unspecified) },
                    { 72, 8, new DateTime(2023, 1, 12, 4, 18, 5, 583, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 14, 18, 5, 583, DateTimeKind.Unspecified) },
                    { 73, 4, new DateTime(2023, 1, 6, 21, 51, 7, 485, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 5, 51, 7, 485, DateTimeKind.Unspecified) },
                    { 74, 4, new DateTime(2023, 3, 25, 7, 2, 51, 426, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 16, 2, 51, 426, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 2, 16, 11, 14, 41, 58, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 16, 14, 41, 58, DateTimeKind.Unspecified) },
                    { 76, 4, new DateTime(2023, 4, 9, 20, 35, 5, 685, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 2, 35, 5, 685, DateTimeKind.Unspecified) },
                    { 77, 4, new DateTime(2023, 4, 29, 7, 6, 13, 956, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 12, 6, 13, 956, DateTimeKind.Unspecified) },
                    { 78, 1, new DateTime(2023, 1, 1, 12, 44, 52, 258, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 18, 44, 52, 258, DateTimeKind.Unspecified) },
                    { 79, 3, new DateTime(2023, 4, 30, 11, 50, 23, 705, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 15, 50, 23, 705, DateTimeKind.Unspecified) },
                    { 80, 8, new DateTime(2023, 4, 28, 16, 37, 42, 363, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 21, 37, 42, 363, DateTimeKind.Unspecified) },
                    { 81, 2, new DateTime(2023, 1, 6, 7, 31, 48, 283, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 12, 31, 48, 283, DateTimeKind.Unspecified) },
                    { 82, 3, new DateTime(2023, 3, 8, 9, 35, 29, 558, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 15, 35, 29, 558, DateTimeKind.Unspecified) },
                    { 83, 5, new DateTime(2023, 1, 4, 13, 36, 51, 873, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 18, 36, 51, 873, DateTimeKind.Unspecified) },
                    { 84, 4, new DateTime(2023, 1, 12, 7, 8, 57, 406, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 17, 8, 57, 406, DateTimeKind.Unspecified) },
                    { 85, 3, new DateTime(2023, 1, 9, 4, 12, 43, 922, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 10, 12, 43, 922, DateTimeKind.Unspecified) },
                    { 86, 8, new DateTime(2023, 1, 12, 10, 8, 19, 148, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 17, 8, 19, 148, DateTimeKind.Unspecified) },
                    { 87, 8, new DateTime(2023, 2, 17, 7, 26, 0, 353, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 16, 26, 0, 353, DateTimeKind.Unspecified) },
                    { 88, 2, new DateTime(2023, 1, 18, 7, 59, 12, 581, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 10, 59, 12, 581, DateTimeKind.Unspecified) },
                    { 89, 8, new DateTime(2023, 2, 27, 9, 38, 17, 326, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 14, 38, 17, 326, DateTimeKind.Unspecified) },
                    { 90, 1, new DateTime(2023, 1, 4, 1, 9, 17, 330, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 2, 9, 17, 330, DateTimeKind.Unspecified) },
                    { 91, 8, new DateTime(2023, 1, 20, 6, 49, 24, 846, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 9, 49, 24, 846, DateTimeKind.Unspecified) },
                    { 92, 8, new DateTime(2023, 4, 2, 4, 51, 56, 105, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 10, 51, 56, 105, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 4, 21, 6, 58, 39, 551, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 14, 58, 39, 551, DateTimeKind.Unspecified) },
                    { 94, 3, new DateTime(2023, 1, 29, 7, 57, 55, 166, DateTimeKind.Unspecified), new DateTime(2023, 1, 29, 9, 57, 55, 166, DateTimeKind.Unspecified) },
                    { 95, 4, new DateTime(2023, 1, 16, 12, 33, 47, 80, DateTimeKind.Unspecified), new DateTime(2023, 1, 16, 22, 33, 47, 80, DateTimeKind.Unspecified) },
                    { 96, 6, new DateTime(2023, 4, 6, 3, 56, 18, 745, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 5, 56, 18, 745, DateTimeKind.Unspecified) },
                    { 97, 1, new DateTime(2023, 1, 3, 23, 41, 33, 646, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 8, 41, 33, 646, DateTimeKind.Unspecified) },
                    { 98, 5, new DateTime(2023, 3, 27, 2, 0, 36, 818, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 11, 0, 36, 818, DateTimeKind.Unspecified) },
                    { 99, 2, new DateTime(2023, 1, 12, 21, 11, 36, 684, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 1, 11, 36, 684, DateTimeKind.Unspecified) },
                    { 100, 8, new DateTime(2023, 3, 3, 14, 32, 19, 803, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 16, 32, 19, 803, DateTimeKind.Unspecified) },
                    { 101, 8, new DateTime(2023, 3, 11, 22, 53, 28, 991, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 6, 53, 28, 991, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5156), 2396m },
                    { 2, 1, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5157), 1198m },
                    { 3, 8, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5192), 699m },
                    { 4, 4, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5218), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 9, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5235), 699m },
                    { 6, 7, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5278), 699m },
                    { 7, 8, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5294), 699m },
                    { 8, 5, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5315), 699m },
                    { 9, 2, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5332), 699m },
                    { 10, 1, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5350), 699m },
                    { 11, 8, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5366), 699m },
                    { 12, 2, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5385), 699m },
                    { 13, 1, false, new DateTime(2023, 4, 20, 22, 51, 47, 414, DateTimeKind.Local).AddTicks(5402), 699m }
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
