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
                    E_Pwd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    E_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    E_Title = table.Column<int>(type: "int", nullable: false),
                    E_Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
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
                    { 1, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(334), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(336), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(337), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(338), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "k5fr86z@gmail.com", 1, new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0918008753", "k5fr86z", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0un6k7b3f@gmail.com", 1, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0917313271", "0un6k7b3f", 0, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "eb5n2jyiwc@gmail.com", 0, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 1, "0911588682", "eb5n2jyiwc", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "29asofvkj7@gmail.com", 1, new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0918597863", "29asofvkj7", 1, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "zwfjdi74@gmail.com", 0, new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0918443405", "zwfjdi74", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "mxzkjfjiq0i@gmail.com", 0, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0915853444", "mxzkjfjiq0i", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "n5pj28psj@gmail.com", 0, new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0919070693", "n5pj28psj", 0, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "y0j34wpq@gmail.com", 1, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0915727436", "y0j34wpq", 0, "9", true, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "P_ID", "Contact", "Email", "P_Name", "P_Note", "Phone" },
                values: new object[] { 1, "林小明", "apple@gmail.com", "Apple", "好合作", "0912345678" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(352), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(354), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 },
                    { 3, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(356), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(357), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(358), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(359), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(360), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(361), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(362), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(363), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(364), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(365), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(172), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(170), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(190), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(189), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(238), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(238), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(248), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(247), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(255), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(255), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(264), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(264), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(272), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(271), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(279), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(278), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(286), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(285), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(294), "Test", 99, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(293), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 124, 13, "", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 17 },
                    { 2, 15000, 1, 224, 22, "", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 3, 15000, 1, 120, 10, "", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 4, 15000, 1, 38, 8, "", new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 5, 15000, 1, 54, 22, "", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 10 },
                    { 6, 15000, 1, 227, 23, "", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 7, 15000, 1, 75, 13, "", new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 8, 15000, 1, 116, 16, "", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 9, 15000, 1, 104, 7, "", new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 10, 15000, 1, 206, 15, "", new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 11, 15000, 1, 158, 12, "", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 12, 15000, 1, 182, 15, "", new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 13, 15000, 1, 147, 12, "", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 14, 15000, 1, 184, 18, "", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 15, 15000, 1, 196, 19, "", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 16, 15000, 1, 77, 20, "", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 12 },
                    { 17, 15000, 1, 72, 20, "", new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 18, 15000, 1, 148, 14, "", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 19, 15000, 1, 142, 22, "", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 20, 15000, 1, 125, 16, "", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 21, 15000, 1, 224, 8, "", new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 22, 15000, 1, 97, 18, "", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 23, 15000, 1, 62, 11, "", new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 24, 15000, 1, 184, 24, "", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 25, 15000, 1, 180, 12, "", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 26, 15000, 1, 57, 12, "", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 27, 15000, 1, 48, 24, "", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 28, 15000, 1, 43, 14, "", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 29, 15000, 1, 61, 15, "", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(319), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(321), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 3, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3313) },
                    { 2, 3, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3367) },
                    { 3, 4, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3370) },
                    { 4, 1, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3371) },
                    { 5, 8, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3373) },
                    { 6, 7, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3376) },
                    { 7, 10, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3378) },
                    { 8, 2, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3380) },
                    { 9, 3, null, "test", true, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3381) },
                    { 10, 1, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3384) },
                    { 11, 7, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3386) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3458) },
                    { 13, 5, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3460) },
                    { 14, 8, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3462) },
                    { 15, 7, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3463) },
                    { 16, 4, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3465) },
                    { 17, 5, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3467) },
                    { 18, 1, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3470) },
                    { 19, 4, null, "test", false, new DateTime(2023, 5, 28, 12, 21, 29, 822, DateTimeKind.Local).AddTicks(3471) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 5, 13, 1, 53, 50, 565, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 7, 53, 50, 565, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(2023, 4, 17, 18, 29, 59, 890, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 19, 29, 59, 890, DateTimeKind.Unspecified) },
                    { 3, 8, new DateTime(2023, 3, 1, 2, 6, 54, 491, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 12, 6, 54, 491, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 5, 3, 23, 55, 28, 463, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 7, 55, 28, 463, DateTimeKind.Unspecified) },
                    { 5, 8, new DateTime(2023, 3, 11, 14, 39, 27, 284, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 20, 39, 27, 284, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2023, 3, 9, 3, 45, 48, 291, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 10, 45, 48, 291, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 2, 23, 11, 34, 2, 873, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 16, 34, 2, 873, DateTimeKind.Unspecified) },
                    { 8, 7, new DateTime(2023, 2, 22, 1, 19, 39, 220, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 11, 19, 39, 220, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(2023, 5, 24, 13, 48, 19, 311, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 19, 48, 19, 311, DateTimeKind.Unspecified) },
                    { 10, 6, new DateTime(2023, 4, 1, 7, 41, 32, 818, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 15, 41, 32, 818, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2023, 4, 23, 6, 45, 58, 53, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 14, 45, 58, 53, DateTimeKind.Unspecified) },
                    { 12, 6, new DateTime(2023, 2, 27, 14, 55, 5, 850, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 20, 55, 5, 850, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2023, 3, 8, 11, 10, 18, 452, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 21, 10, 18, 452, DateTimeKind.Unspecified) },
                    { 14, 3, new DateTime(2023, 2, 11, 5, 14, 44, 854, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 15, 14, 44, 854, DateTimeKind.Unspecified) },
                    { 15, 5, new DateTime(2023, 3, 4, 18, 30, 57, 605, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 20, 30, 57, 605, DateTimeKind.Unspecified) },
                    { 16, 9, new DateTime(2023, 2, 24, 22, 26, 5, 2, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 1, 26, 5, 2, DateTimeKind.Unspecified) },
                    { 17, 6, new DateTime(2023, 3, 17, 10, 50, 34, 46, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 18, 50, 34, 46, DateTimeKind.Unspecified) },
                    { 18, 7, new DateTime(2023, 4, 28, 4, 45, 38, 121, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 6, 45, 38, 121, DateTimeKind.Unspecified) },
                    { 19, 8, new DateTime(2023, 2, 23, 6, 53, 41, 209, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 8, 53, 41, 209, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 3, 22, 6, 14, 19, 481, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 15, 14, 19, 481, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 4, 18, 12, 44, 51, 229, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 22, 44, 51, 229, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 6, new DateTime(2023, 3, 10, 4, 48, 46, 924, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 13, 48, 46, 924, DateTimeKind.Unspecified) },
                    { 23, 9, new DateTime(2023, 3, 18, 20, 14, 1, 463, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 22, 14, 1, 463, DateTimeKind.Unspecified) },
                    { 24, 7, new DateTime(2023, 2, 10, 14, 43, 28, 831, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 0, 43, 28, 831, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2023, 5, 12, 22, 2, 37, 770, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 2, 2, 37, 770, DateTimeKind.Unspecified) },
                    { 26, 1, new DateTime(2023, 5, 21, 21, 21, 40, 507, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 7, 21, 40, 507, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 4, 15, 13, 3, 48, 674, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 15, 3, 48, 674, DateTimeKind.Unspecified) },
                    { 28, 3, new DateTime(2023, 4, 21, 19, 20, 6, 837, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 2, 20, 6, 837, DateTimeKind.Unspecified) },
                    { 29, 6, new DateTime(2023, 4, 8, 22, 4, 12, 620, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 8, 4, 12, 620, DateTimeKind.Unspecified) },
                    { 30, 6, new DateTime(2023, 2, 20, 15, 6, 42, 492, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 17, 6, 42, 492, DateTimeKind.Unspecified) },
                    { 31, 2, new DateTime(2023, 2, 24, 13, 16, 51, 425, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 18, 16, 51, 425, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2023, 5, 19, 13, 4, 1, 3, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 19, 4, 1, 3, DateTimeKind.Unspecified) },
                    { 33, 2, new DateTime(2023, 3, 16, 6, 56, 23, 817, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 7, 56, 23, 817, DateTimeKind.Unspecified) },
                    { 34, 4, new DateTime(2023, 5, 15, 23, 20, 45, 995, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 2, 20, 45, 995, DateTimeKind.Unspecified) },
                    { 35, 9, new DateTime(2023, 5, 8, 9, 31, 53, 748, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 16, 31, 53, 748, DateTimeKind.Unspecified) },
                    { 36, 7, new DateTime(2023, 5, 2, 16, 39, 1, 189, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 19, 39, 1, 189, DateTimeKind.Unspecified) },
                    { 37, 9, new DateTime(2023, 2, 3, 10, 44, 7, 778, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 13, 44, 7, 778, DateTimeKind.Unspecified) },
                    { 38, 2, new DateTime(2023, 4, 19, 20, 33, 41, 730, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 22, 33, 41, 730, DateTimeKind.Unspecified) },
                    { 39, 4, new DateTime(2023, 3, 25, 14, 31, 1, 701, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 16, 31, 1, 701, DateTimeKind.Unspecified) },
                    { 40, 4, new DateTime(2023, 5, 9, 10, 48, 34, 480, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 12, 48, 34, 480, DateTimeKind.Unspecified) },
                    { 41, 7, new DateTime(2023, 3, 4, 2, 37, 35, 635, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 5, 37, 35, 635, DateTimeKind.Unspecified) },
                    { 42, 9, new DateTime(2023, 4, 13, 8, 57, 28, 837, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 13, 57, 28, 837, DateTimeKind.Unspecified) },
                    { 43, 7, new DateTime(2023, 2, 19, 1, 44, 19, 933, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 3, 44, 19, 933, DateTimeKind.Unspecified) },
                    { 44, 5, new DateTime(2023, 4, 27, 1, 21, 10, 504, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 9, 21, 10, 504, DateTimeKind.Unspecified) },
                    { 45, 6, new DateTime(2023, 2, 20, 4, 58, 46, 796, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 13, 58, 46, 796, DateTimeKind.Unspecified) },
                    { 46, 9, new DateTime(2023, 4, 26, 18, 35, 53, 154, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 22, 35, 53, 154, DateTimeKind.Unspecified) },
                    { 47, 6, new DateTime(2023, 2, 19, 19, 11, 52, 460, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 21, 11, 52, 460, DateTimeKind.Unspecified) },
                    { 48, 7, new DateTime(2023, 2, 6, 5, 50, 25, 697, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 13, 50, 25, 697, DateTimeKind.Unspecified) },
                    { 49, 2, new DateTime(2023, 3, 2, 21, 16, 6, 440, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 22, 16, 6, 440, DateTimeKind.Unspecified) },
                    { 50, 9, new DateTime(2023, 2, 27, 0, 53, 22, 800, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 5, 53, 22, 800, DateTimeKind.Unspecified) },
                    { 51, 5, new DateTime(2023, 3, 30, 20, 44, 19, 577, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 3, 44, 19, 577, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2023, 4, 25, 10, 5, 49, 116, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 17, 5, 49, 116, DateTimeKind.Unspecified) },
                    { 53, 2, new DateTime(2023, 4, 26, 13, 21, 1, 795, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 18, 21, 1, 795, DateTimeKind.Unspecified) },
                    { 54, 6, new DateTime(2023, 3, 4, 19, 26, 51, 18, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 1, 26, 51, 18, DateTimeKind.Unspecified) },
                    { 55, 7, new DateTime(2023, 5, 18, 17, 19, 48, 478, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 0, 19, 48, 478, DateTimeKind.Unspecified) },
                    { 56, 5, new DateTime(2023, 5, 4, 3, 53, 27, 678, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 7, 53, 27, 678, DateTimeKind.Unspecified) },
                    { 57, 4, new DateTime(2023, 4, 27, 22, 2, 32, 871, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 0, 2, 32, 871, DateTimeKind.Unspecified) },
                    { 58, 3, new DateTime(2023, 5, 3, 23, 25, 31, 320, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 5, 25, 31, 320, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 4, 9, 0, 4, 37, 390, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 4, 4, 37, 390, DateTimeKind.Unspecified) },
                    { 60, 5, new DateTime(2023, 2, 12, 15, 8, 58, 498, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 1, 8, 58, 498, DateTimeKind.Unspecified) },
                    { 61, 9, new DateTime(2023, 5, 26, 0, 50, 58, 657, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 9, 50, 58, 657, DateTimeKind.Unspecified) },
                    { 62, 5, new DateTime(2023, 3, 13, 13, 48, 35, 898, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 22, 48, 35, 898, DateTimeKind.Unspecified) },
                    { 63, 5, new DateTime(2023, 4, 16, 6, 32, 29, 177, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 9, 32, 29, 177, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 7, new DateTime(2023, 5, 23, 2, 28, 57, 543, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 7, 28, 57, 543, DateTimeKind.Unspecified) },
                    { 65, 8, new DateTime(2023, 2, 23, 7, 22, 6, 743, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 10, 22, 6, 743, DateTimeKind.Unspecified) },
                    { 66, 4, new DateTime(2023, 5, 9, 20, 45, 35, 144, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 6, 45, 35, 144, DateTimeKind.Unspecified) },
                    { 67, 9, new DateTime(2023, 3, 11, 8, 49, 18, 715, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 10, 49, 18, 715, DateTimeKind.Unspecified) },
                    { 68, 2, new DateTime(2023, 3, 25, 10, 2, 6, 171, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 15, 2, 6, 171, DateTimeKind.Unspecified) },
                    { 69, 2, new DateTime(2023, 4, 5, 9, 32, 41, 212, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 17, 32, 41, 212, DateTimeKind.Unspecified) },
                    { 70, 1, new DateTime(2023, 5, 4, 3, 58, 2, 16, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 7, 58, 2, 16, DateTimeKind.Unspecified) },
                    { 71, 6, new DateTime(2023, 3, 10, 11, 36, 26, 991, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 16, 36, 26, 991, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 4, 23, 4, 39, 34, 191, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 11, 39, 34, 191, DateTimeKind.Unspecified) },
                    { 73, 7, new DateTime(2023, 2, 23, 15, 8, 36, 560, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 16, 8, 36, 560, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2023, 5, 15, 18, 26, 57, 738, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 2, 26, 57, 738, DateTimeKind.Unspecified) },
                    { 75, 7, new DateTime(2023, 4, 4, 16, 25, 55, 281, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 0, 25, 55, 281, DateTimeKind.Unspecified) },
                    { 76, 2, new DateTime(2023, 5, 7, 12, 56, 52, 345, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 13, 56, 52, 345, DateTimeKind.Unspecified) },
                    { 77, 9, new DateTime(2023, 3, 8, 16, 54, 52, 397, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 23, 54, 52, 397, DateTimeKind.Unspecified) },
                    { 78, 1, new DateTime(2023, 4, 3, 18, 26, 34, 781, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 0, 26, 34, 781, DateTimeKind.Unspecified) },
                    { 79, 5, new DateTime(2023, 2, 19, 21, 21, 23, 895, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 7, 21, 23, 895, DateTimeKind.Unspecified) },
                    { 80, 2, new DateTime(2023, 3, 2, 14, 25, 13, 956, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 21, 25, 13, 956, DateTimeKind.Unspecified) },
                    { 81, 3, new DateTime(2023, 3, 21, 6, 17, 26, 310, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 7, 17, 26, 310, DateTimeKind.Unspecified) },
                    { 82, 8, new DateTime(2023, 3, 12, 15, 44, 52, 336, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 17, 44, 52, 336, DateTimeKind.Unspecified) },
                    { 83, 6, new DateTime(2023, 4, 2, 20, 47, 22, 937, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 1, 47, 22, 937, DateTimeKind.Unspecified) },
                    { 84, 3, new DateTime(2023, 3, 9, 20, 48, 15, 900, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 3, 48, 15, 900, DateTimeKind.Unspecified) },
                    { 85, 3, new DateTime(2023, 3, 25, 5, 34, 1, 368, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 8, 34, 1, 368, DateTimeKind.Unspecified) },
                    { 86, 6, new DateTime(2023, 2, 21, 4, 15, 38, 101, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 9, 15, 38, 101, DateTimeKind.Unspecified) },
                    { 87, 7, new DateTime(2023, 4, 20, 6, 19, 43, 942, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 16, 19, 43, 942, DateTimeKind.Unspecified) },
                    { 88, 5, new DateTime(2023, 5, 14, 2, 44, 30, 211, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 7, 44, 30, 211, DateTimeKind.Unspecified) },
                    { 89, 4, new DateTime(2023, 2, 4, 0, 28, 32, 82, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 4, 28, 32, 82, DateTimeKind.Unspecified) },
                    { 90, 3, new DateTime(2023, 3, 3, 15, 44, 13, 773, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 21, 44, 13, 773, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 4, 30, 1, 16, 49, 54, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 6, 16, 49, 54, DateTimeKind.Unspecified) },
                    { 92, 8, new DateTime(2023, 3, 14, 5, 58, 47, 151, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 10, 58, 47, 151, DateTimeKind.Unspecified) },
                    { 93, 2, new DateTime(2023, 4, 8, 2, 12, 56, 335, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 6, 12, 56, 335, DateTimeKind.Unspecified) },
                    { 94, 2, new DateTime(2023, 2, 2, 5, 20, 27, 1, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 14, 20, 27, 1, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 2, 25, 6, 58, 50, 99, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 16, 58, 50, 99, DateTimeKind.Unspecified) },
                    { 96, 4, new DateTime(2023, 4, 13, 7, 30, 57, 768, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 15, 30, 57, 768, DateTimeKind.Unspecified) },
                    { 97, 2, new DateTime(2023, 5, 12, 0, 44, 4, 476, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 6, 44, 4, 476, DateTimeKind.Unspecified) },
                    { 98, 6, new DateTime(2023, 4, 4, 23, 13, 46, 914, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 5, 13, 46, 914, DateTimeKind.Unspecified) },
                    { 99, 4, new DateTime(2023, 2, 17, 9, 59, 58, 20, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 16, 59, 58, 20, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2023, 4, 18, 2, 27, 55, 735, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 5, 27, 55, 735, DateTimeKind.Unspecified) },
                    { 101, 7, new DateTime(2023, 3, 16, 19, 48, 48, 307, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 1, 48, 48, 307, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(380), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(381), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(382), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(383), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 2, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1121), 700m },
                    { 6, 7, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1140), 700m },
                    { 7, 3, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1156), 700m },
                    { 8, 7, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1169), 700m },
                    { 9, 3, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1182), 700m },
                    { 10, 1, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1197), 700m },
                    { 11, 7, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1211), 700m },
                    { 12, 4, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1224), 700m },
                    { 13, 6, false, new DateTime(2023, 5, 28, 12, 21, 29, 824, DateTimeKind.Local).AddTicks(1237), 700m }
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
