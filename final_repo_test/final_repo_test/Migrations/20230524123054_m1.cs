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
                    A_Coin = table.Column<int>(type: "int", nullable: false),
                    VerifycationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordRestToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetTokenExpries = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
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
                    { 1, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7287), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7289), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7290), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7290), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                values: new object[,]
                {
                    { 1, "高雄市前金區", new DateTime(1999, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", 0, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "bobo", 0, "0963915584", "1234", 0, "bobo", true, false, "user" },
                    { 2, "高雄市前金區", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "gkrh8sg3@gmail.com", 0, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0915697766", "gkrh8sg3", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "v1j0qbdty@gmail.com", 0, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 1, "0919763853", "v1j0qbdty", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "7du3395p@gmail.com", 0, new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0911838170", "7du3395p", 0, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "qc7e5jbgp4h@gmail.com", 0, new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0910590823", "qc7e5jbgp4h", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "hve18x9y3@gmail.com", 1, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 2, "0918001691", "hve18x9y3", 1, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "e5p236vns@gmail.com", 1, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 1, "0914530130", "e5p236vns", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ger9ts5mq@gmail.com", 0, new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 1, "0911191944", "ger9ts5mq", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "nldcnysc@gmail.com", 1, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 2, "0917326578", "nldcnysc", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7303), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7305), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7306), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7307), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7308), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7309), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7310), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7311), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7312), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7314), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7315), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7316), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7124), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7123), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7142), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7142), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7151), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7150), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7158), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7157), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7202), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7202), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7213), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7213), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7221), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7220), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7228), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7227), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7235), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7234), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7243), "Test", 99, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7243), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 218, 19, "", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 17 },
                    { 2, 15000, 1, 121, 10, "", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 3, 15000, 1, 44, 12, "", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 4, 15000, 1, 229, 14, "", new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 13 },
                    { 5, 15000, 1, 177, 20, "", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 },
                    { 6, 15000, 1, 160, 9, "", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 7, 15000, 1, 161, 9, "", new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 },
                    { 8, 15000, 1, 54, 7, "", new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 9, 15000, 1, 196, 20, "", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 17 },
                    { 10, 15000, 1, 122, 7, "", new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 11, 15000, 1, 141, 10, "", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 7 },
                    { 12, 15000, 1, 190, 10, "", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 15 },
                    { 13, 15000, 1, 50, 22, "", new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 14, 15000, 1, 126, 7, "", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 15, 15000, 1, 207, 11, "", new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 16, 15000, 1, 97, 16, "", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 17, 15000, 1, 80, 20, "", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 18, 15000, 1, 36, 11, "", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5 },
                    { 19, 15000, 1, 73, 19, "", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 20, 15000, 1, 113, 16, "", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 21, 15000, 1, 110, 14, "", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 22, 15000, 1, 223, 17, "", new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 3 },
                    { 23, 15000, 1, 207, 12, "", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 24, 15000, 1, 150, 20, "", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 25, 15000, 1, 115, 24, "", new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 26, 15000, 1, 114, 24, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 27, 15000, 1, 122, 8, "", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 28, 15000, 1, 189, 17, "", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 29, 15000, 1, 143, 16, "", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 13 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7271), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7274), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 2, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(969) },
                    { 2, 8, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1053) },
                    { 3, 10, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1055) },
                    { 4, 10, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1057) },
                    { 5, 1, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1059) },
                    { 6, 7, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1063) },
                    { 7, 10, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1064) },
                    { 8, 7, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1066) },
                    { 9, 5, null, "test", true, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1068) },
                    { 10, 5, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1070) },
                    { 11, 9, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1072) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1074) },
                    { 13, 8, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1076) },
                    { 14, 3, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1077) },
                    { 15, 3, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1079) },
                    { 16, 2, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1080) },
                    { 17, 6, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1120) },
                    { 18, 1, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1123) },
                    { 19, 3, null, "test", false, new DateTime(2023, 5, 24, 20, 30, 54, 86, DateTimeKind.Local).AddTicks(1125) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 3, 16, 20, 23, 44, 634, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 1, 23, 44, 634, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 2, 8, 0, 41, 7, 617, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 9, 41, 7, 617, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2023, 5, 28, 17, 44, 29, 976, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 23, 44, 29, 976, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2023, 3, 16, 22, 52, 35, 384, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 5, 52, 35, 384, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(2023, 4, 9, 10, 13, 8, 848, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 13, 13, 8, 848, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2023, 4, 18, 16, 35, 33, 63, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 0, 35, 33, 63, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2023, 3, 23, 0, 52, 59, 169, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 10, 52, 59, 169, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 3, 6, 16, 38, 1, 494, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 22, 38, 1, 494, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2023, 5, 22, 17, 53, 29, 229, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 2, 53, 29, 229, DateTimeKind.Unspecified) },
                    { 10, 4, new DateTime(2023, 4, 22, 22, 51, 32, 859, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 1, 51, 32, 859, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2023, 4, 25, 6, 15, 56, 186, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 16, 15, 56, 186, DateTimeKind.Unspecified) },
                    { 12, 5, new DateTime(2023, 5, 30, 13, 10, 35, 31, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 19, 10, 35, 31, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2023, 3, 16, 5, 46, 29, 168, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 12, 46, 29, 168, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 2, 14, 15, 48, 14, 733, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 19, 48, 14, 733, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2023, 3, 17, 17, 32, 2, 575, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 22, 32, 2, 575, DateTimeKind.Unspecified) },
                    { 16, 8, new DateTime(2023, 3, 16, 3, 55, 23, 997, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 5, 55, 23, 997, DateTimeKind.Unspecified) },
                    { 17, 9, new DateTime(2023, 4, 25, 7, 6, 4, 326, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 16, 6, 4, 326, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2023, 3, 4, 16, 49, 36, 188, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 18, 49, 36, 188, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 3, 22, 10, 39, 39, 34, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 18, 39, 39, 34, DateTimeKind.Unspecified) },
                    { 20, 9, new DateTime(2023, 2, 4, 2, 37, 0, 92, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 11, 37, 0, 92, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2023, 3, 6, 11, 24, 35, 209, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 18, 24, 35, 209, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 1, new DateTime(2023, 2, 17, 21, 57, 36, 209, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 3, 57, 36, 209, DateTimeKind.Unspecified) },
                    { 23, 2, new DateTime(2023, 3, 2, 4, 16, 49, 319, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 13, 16, 49, 319, DateTimeKind.Unspecified) },
                    { 24, 6, new DateTime(2023, 3, 27, 2, 36, 54, 723, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 12, 36, 54, 723, DateTimeKind.Unspecified) },
                    { 25, 7, new DateTime(2023, 4, 27, 2, 14, 30, 12, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 3, 14, 30, 12, DateTimeKind.Unspecified) },
                    { 26, 6, new DateTime(2023, 2, 4, 12, 52, 37, 498, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 18, 52, 37, 498, DateTimeKind.Unspecified) },
                    { 27, 5, new DateTime(2023, 3, 4, 8, 8, 12, 720, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 17, 8, 12, 720, DateTimeKind.Unspecified) },
                    { 28, 3, new DateTime(2023, 2, 17, 16, 10, 19, 694, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 21, 10, 19, 694, DateTimeKind.Unspecified) },
                    { 29, 2, new DateTime(2023, 3, 4, 12, 9, 35, 733, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 22, 9, 35, 733, DateTimeKind.Unspecified) },
                    { 30, 8, new DateTime(2023, 2, 13, 5, 36, 57, 324, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 8, 36, 57, 324, DateTimeKind.Unspecified) },
                    { 31, 2, new DateTime(2023, 4, 12, 16, 24, 44, 700, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 21, 24, 44, 700, DateTimeKind.Unspecified) },
                    { 32, 8, new DateTime(2023, 3, 2, 19, 48, 39, 157, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 23, 48, 39, 157, DateTimeKind.Unspecified) },
                    { 33, 9, new DateTime(2023, 3, 8, 12, 37, 59, 209, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 15, 37, 59, 209, DateTimeKind.Unspecified) },
                    { 34, 9, new DateTime(2023, 4, 19, 15, 21, 17, 110, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 21, 21, 17, 110, DateTimeKind.Unspecified) },
                    { 35, 3, new DateTime(2023, 5, 29, 8, 49, 56, 133, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 49, 56, 133, DateTimeKind.Unspecified) },
                    { 36, 8, new DateTime(2023, 5, 13, 19, 3, 43, 622, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 1, 3, 43, 622, DateTimeKind.Unspecified) },
                    { 37, 4, new DateTime(2023, 3, 31, 9, 28, 24, 461, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 16, 28, 24, 461, DateTimeKind.Unspecified) },
                    { 38, 1, new DateTime(2023, 5, 4, 18, 41, 54, 63, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 4, 41, 54, 63, DateTimeKind.Unspecified) },
                    { 39, 3, new DateTime(2023, 2, 14, 7, 23, 23, 315, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 8, 23, 23, 315, DateTimeKind.Unspecified) },
                    { 40, 2, new DateTime(2023, 4, 16, 21, 0, 30, 725, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 4, 0, 30, 725, DateTimeKind.Unspecified) },
                    { 41, 3, new DateTime(2023, 4, 14, 12, 54, 28, 283, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 16, 54, 28, 283, DateTimeKind.Unspecified) },
                    { 42, 2, new DateTime(2023, 2, 7, 11, 43, 59, 758, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 19, 43, 59, 758, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 4, 26, 14, 4, 13, 338, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 22, 4, 13, 338, DateTimeKind.Unspecified) },
                    { 44, 5, new DateTime(2023, 5, 27, 14, 1, 34, 263, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 18, 1, 34, 263, DateTimeKind.Unspecified) },
                    { 45, 7, new DateTime(2023, 5, 6, 0, 0, 5, 37, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 1, 0, 5, 37, DateTimeKind.Unspecified) },
                    { 46, 6, new DateTime(2023, 3, 26, 12, 8, 48, 740, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 17, 8, 48, 740, DateTimeKind.Unspecified) },
                    { 47, 2, new DateTime(2023, 5, 20, 5, 10, 19, 693, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 9, 10, 19, 693, DateTimeKind.Unspecified) },
                    { 48, 3, new DateTime(2023, 5, 6, 15, 13, 15, 621, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 19, 13, 15, 621, DateTimeKind.Unspecified) },
                    { 49, 5, new DateTime(2023, 2, 19, 18, 33, 19, 155, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 20, 33, 19, 155, DateTimeKind.Unspecified) },
                    { 50, 5, new DateTime(2023, 4, 24, 1, 51, 23, 129, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 6, 51, 23, 129, DateTimeKind.Unspecified) },
                    { 51, 5, new DateTime(2023, 3, 23, 20, 18, 53, 715, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 4, 18, 53, 715, DateTimeKind.Unspecified) },
                    { 52, 2, new DateTime(2023, 2, 5, 13, 53, 54, 482, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 19, 53, 54, 482, DateTimeKind.Unspecified) },
                    { 53, 7, new DateTime(2023, 2, 13, 7, 4, 40, 138, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 4, 40, 138, DateTimeKind.Unspecified) },
                    { 54, 8, new DateTime(2023, 3, 4, 18, 31, 44, 799, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 4, 31, 44, 799, DateTimeKind.Unspecified) },
                    { 55, 3, new DateTime(2023, 4, 24, 18, 3, 2, 545, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 22, 3, 2, 545, DateTimeKind.Unspecified) },
                    { 56, 4, new DateTime(2023, 3, 24, 21, 33, 42, 822, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 2, 33, 42, 822, DateTimeKind.Unspecified) },
                    { 57, 2, new DateTime(2023, 3, 7, 1, 43, 34, 402, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 2, 43, 34, 402, DateTimeKind.Unspecified) },
                    { 58, 8, new DateTime(2023, 2, 19, 9, 45, 0, 962, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 14, 45, 0, 962, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2023, 5, 30, 9, 44, 48, 368, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 13, 44, 48, 368, DateTimeKind.Unspecified) },
                    { 60, 7, new DateTime(2023, 4, 27, 9, 57, 10, 269, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 14, 57, 10, 269, DateTimeKind.Unspecified) },
                    { 61, 8, new DateTime(2023, 4, 30, 4, 22, 56, 976, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 6, 22, 56, 976, DateTimeKind.Unspecified) },
                    { 62, 1, new DateTime(2023, 4, 20, 17, 54, 40, 254, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 21, 54, 40, 254, DateTimeKind.Unspecified) },
                    { 63, 7, new DateTime(2023, 4, 22, 10, 40, 37, 248, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 15, 40, 37, 248, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 3, new DateTime(2023, 3, 5, 11, 8, 59, 607, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 15, 8, 59, 607, DateTimeKind.Unspecified) },
                    { 65, 7, new DateTime(2023, 4, 19, 0, 25, 53, 650, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 5, 25, 53, 650, DateTimeKind.Unspecified) },
                    { 66, 7, new DateTime(2023, 5, 25, 5, 8, 55, 796, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 7, 8, 55, 796, DateTimeKind.Unspecified) },
                    { 67, 8, new DateTime(2023, 3, 27, 9, 56, 41, 532, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 15, 56, 41, 532, DateTimeKind.Unspecified) },
                    { 68, 8, new DateTime(2023, 2, 14, 15, 8, 40, 334, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 20, 8, 40, 334, DateTimeKind.Unspecified) },
                    { 69, 6, new DateTime(2023, 4, 7, 19, 46, 57, 135, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 3, 46, 57, 135, DateTimeKind.Unspecified) },
                    { 70, 9, new DateTime(2023, 5, 5, 5, 41, 23, 845, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 15, 41, 23, 845, DateTimeKind.Unspecified) },
                    { 71, 6, new DateTime(2023, 2, 19, 21, 29, 36, 313, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 3, 29, 36, 313, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 2, 24, 3, 53, 20, 492, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 6, 53, 20, 492, DateTimeKind.Unspecified) },
                    { 73, 9, new DateTime(2023, 5, 17, 21, 14, 23, 989, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 6, 14, 23, 989, DateTimeKind.Unspecified) },
                    { 74, 8, new DateTime(2023, 5, 15, 2, 48, 13, 725, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 10, 48, 13, 725, DateTimeKind.Unspecified) },
                    { 75, 2, new DateTime(2023, 5, 1, 14, 30, 7, 400, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 20, 30, 7, 400, DateTimeKind.Unspecified) },
                    { 76, 9, new DateTime(2023, 3, 2, 19, 43, 40, 150, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 20, 43, 40, 150, DateTimeKind.Unspecified) },
                    { 77, 8, new DateTime(2023, 4, 25, 6, 54, 33, 736, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 15, 54, 33, 736, DateTimeKind.Unspecified) },
                    { 78, 7, new DateTime(2023, 5, 8, 14, 24, 1, 613, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 16, 24, 1, 613, DateTimeKind.Unspecified) },
                    { 79, 2, new DateTime(2023, 3, 12, 9, 30, 6, 868, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 14, 30, 6, 868, DateTimeKind.Unspecified) },
                    { 80, 3, new DateTime(2023, 4, 3, 19, 56, 54, 186, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 22, 56, 54, 186, DateTimeKind.Unspecified) },
                    { 81, 3, new DateTime(2023, 4, 29, 11, 51, 37, 300, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 14, 51, 37, 300, DateTimeKind.Unspecified) },
                    { 82, 9, new DateTime(2023, 3, 2, 0, 11, 1, 505, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 6, 11, 1, 505, DateTimeKind.Unspecified) },
                    { 83, 9, new DateTime(2023, 2, 2, 17, 23, 48, 83, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 20, 23, 48, 83, DateTimeKind.Unspecified) },
                    { 84, 7, new DateTime(2023, 3, 31, 7, 25, 5, 739, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 9, 25, 5, 739, DateTimeKind.Unspecified) },
                    { 85, 6, new DateTime(2023, 5, 16, 17, 5, 12, 879, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 2, 5, 12, 879, DateTimeKind.Unspecified) },
                    { 86, 5, new DateTime(2023, 5, 14, 1, 17, 0, 353, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 4, 17, 0, 353, DateTimeKind.Unspecified) },
                    { 87, 5, new DateTime(2023, 2, 4, 3, 22, 56, 373, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 4, 22, 56, 373, DateTimeKind.Unspecified) },
                    { 88, 3, new DateTime(2023, 5, 27, 23, 17, 28, 843, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 1, 17, 28, 843, DateTimeKind.Unspecified) },
                    { 89, 7, new DateTime(2023, 5, 29, 20, 50, 48, 963, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 22, 50, 48, 963, DateTimeKind.Unspecified) },
                    { 90, 5, new DateTime(2023, 4, 1, 22, 58, 54, 798, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 4, 58, 54, 798, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 2, 11, 13, 21, 32, 189, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 20, 21, 32, 189, DateTimeKind.Unspecified) },
                    { 92, 3, new DateTime(2023, 3, 16, 23, 13, 0, 851, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 5, 13, 0, 851, DateTimeKind.Unspecified) },
                    { 93, 6, new DateTime(2023, 3, 10, 7, 11, 42, 816, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 16, 11, 42, 816, DateTimeKind.Unspecified) },
                    { 94, 8, new DateTime(2023, 3, 31, 22, 9, 46, 920, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 1, 9, 46, 920, DateTimeKind.Unspecified) },
                    { 95, 9, new DateTime(2023, 3, 19, 8, 40, 13, 180, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 11, 40, 13, 180, DateTimeKind.Unspecified) },
                    { 96, 4, new DateTime(2023, 5, 15, 0, 6, 40, 369, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 2, 6, 40, 369, DateTimeKind.Unspecified) },
                    { 97, 2, new DateTime(2023, 4, 27, 16, 44, 47, 677, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 20, 44, 47, 677, DateTimeKind.Unspecified) },
                    { 98, 1, new DateTime(2023, 2, 8, 17, 3, 25, 771, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 2, 3, 25, 771, DateTimeKind.Unspecified) },
                    { 99, 2, new DateTime(2023, 2, 20, 2, 8, 12, 482, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 10, 8, 12, 482, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2023, 2, 6, 7, 34, 44, 619, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 8, 34, 44, 619, DateTimeKind.Unspecified) },
                    { 101, 5, new DateTime(2023, 2, 21, 19, 41, 29, 894, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 5, 41, 29, 894, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7330), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7331), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7332), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(7332), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 4, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8085), 700m },
                    { 6, 4, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8106), 700m },
                    { 7, 8, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8120), 700m },
                    { 8, 2, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8133), 700m },
                    { 9, 5, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8147), 700m },
                    { 10, 3, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8164), 700m },
                    { 11, 9, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8177), 700m },
                    { 12, 5, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8189), 700m },
                    { 13, 1, false, new DateTime(2023, 5, 24, 20, 30, 54, 87, DateTimeKind.Local).AddTicks(8202), 700m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Od_ID", "O_ID", "Od_Quantity", "Od_Sum", "Od_UnitPrice", "P_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, 750m, 750m, 1 },
                    { 2, 2, 1, 600m, 600m, 10 },
                    { 3, 3, 1, 500m, 500m, 9 },
                    { 4, 4, 1, 500m, 500m, 7 },
                    { 5, 5, 1, 699m, 699m, 1 },
                    { 6, 6, 1, 699m, 699m, 1 },
                    { 7, 7, 1, 699m, 699m, 1 },
                    { 8, 8, 1, 699m, 699m, 1 },
                    { 9, 9, 1, 699m, 699m, 1 },
                    { 10, 10, 1, 699m, 699m, 1 },
                    { 11, 11, 1, 699m, 699m, 1 },
                    { 12, 12, 1, 699m, 699m, 1 },
                    { 13, 13, 1, 699m, 699m, 1 }
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
