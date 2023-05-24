using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class s5 : Migration
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
                    { 1, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2826), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2827), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2828), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2828), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "m8oyo0@gmail.com", 0, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0911059960", "m8oyo0", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "1a8nc9p2v1@gmail.com", 1, new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 1, "0917057154", "1a8nc9p2v1", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "b7q9ibvcxn@gmail.com", 0, new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 1, "0918022530", "b7q9ibvcxn", 0, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "tvylmebl7@gmail.com", 0, new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 2, "0915546498", "tvylmebl7", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "lvgxx8v4@gmail.com", 0, new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0914683407", "lvgxx8v4", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "09jb47o7@gmail.com", 1, new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 1, "0919698422", "09jb47o7", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "5oq00tuwzid@gmail.com", 1, new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0916238388", "5oq00tuwzid", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "zidqt5hau@gmail.com", 1, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 2, "0916561481", "zidqt5hau", 1, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2838), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2840), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2841), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2842), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2843), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2844), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2845), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2845), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2846), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2847), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2848), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2849), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2713), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2712), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2728), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2728), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2735), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2734), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2741), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2740), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2746), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2746), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2753), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2753), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2759), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2759), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2765), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2764), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2770), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2770), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2776), "Test", 99, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2776), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 90, 21, "", new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 2, 15000, 1, 201, 24, "", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 3, 15000, 1, 69, 18, "", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 4, 15000, 1, 117, 11, "", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 10 },
                    { 5, 15000, 1, 145, 23, "", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 6, 15000, 1, 144, 7, "", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 7, 15000, 1, 136, 9, "", new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 8, 15000, 1, 87, 16, "", new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 9, 15000, 1, 77, 13, "", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 10, 15000, 1, 173, 20, "", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 11, 15000, 1, 115, 15, "", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 13 },
                    { 12, 15000, 1, 135, 20, "", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 13, 15000, 1, 164, 12, "", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 14, 15000, 1, 205, 21, "", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 17 },
                    { 15, 15000, 1, 108, 16, "", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 16, 15000, 1, 211, 16, "", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 17, 15000, 1, 91, 20, "", new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 18, 15000, 1, 222, 14, "", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 19, 15000, 1, 231, 14, "", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 20, 15000, 1, 213, 7, "", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2 },
                    { 21, 15000, 1, 235, 21, "", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 22, 15000, 1, 69, 15, "", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 23, 15000, 1, 190, 10, "", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 24, 15000, 1, 211, 7, "", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 25, 15000, 1, 88, 8, "", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 26, 15000, 1, 53, 18, "", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 27, 15000, 1, 92, 17, "", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 28, 15000, 1, 116, 19, "", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 29, 15000, 1, 108, 13, "", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2795), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2797), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 2, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1227) },
                    { 2, 7, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1268) },
                    { 3, 2, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1270) },
                    { 4, 7, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1271) },
                    { 5, 8, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1273) },
                    { 6, 7, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1275) },
                    { 7, 1, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1276) },
                    { 8, 8, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1278) },
                    { 9, 9, null, "test", true, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1279) },
                    { 10, 6, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1281) },
                    { 11, 2, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1282) },
                    { 12, 1, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1283) },
                    { 13, 9, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1284) },
                    { 14, 10, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1286) },
                    { 15, 3, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1287) },
                    { 16, 1, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1288) },
                    { 17, 2, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1289) },
                    { 18, 7, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1291) },
                    { 19, 5, null, "test", false, new DateTime(2023, 5, 24, 17, 19, 48, 19, DateTimeKind.Local).AddTicks(1292) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 3, 11, 3, 34, 35, 471, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 12, 34, 35, 471, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(2023, 5, 15, 12, 9, 38, 304, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 17, 9, 38, 304, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 3, 17, 3, 5, 3, 417, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 13, 5, 3, 417, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 2, 13, 5, 13, 31, 5, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 15, 13, 31, 5, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2023, 5, 17, 11, 44, 2, 579, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 17, 44, 2, 579, DateTimeKind.Unspecified) },
                    { 6, 9, new DateTime(2023, 5, 11, 17, 22, 51, 727, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 22, 22, 51, 727, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2023, 3, 9, 7, 43, 26, 629, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 14, 43, 26, 629, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(2023, 2, 21, 22, 32, 21, 711, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 4, 32, 21, 711, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2023, 2, 15, 12, 34, 34, 493, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 15, 34, 34, 493, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 3, 27, 14, 29, 15, 96, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 18, 29, 15, 96, DateTimeKind.Unspecified) },
                    { 11, 2, new DateTime(2023, 4, 7, 2, 49, 28, 425, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 7, 49, 28, 425, DateTimeKind.Unspecified) },
                    { 12, 8, new DateTime(2023, 3, 10, 23, 0, 57, 290, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 8, 0, 57, 290, DateTimeKind.Unspecified) },
                    { 13, 9, new DateTime(2023, 3, 28, 16, 48, 38, 143, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 0, 48, 38, 143, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 5, 19, 10, 51, 31, 6, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 19, 51, 31, 6, DateTimeKind.Unspecified) },
                    { 15, 6, new DateTime(2023, 5, 10, 0, 4, 25, 147, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 7, 4, 25, 147, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 4, 15, 21, 18, 41, 418, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 3, 18, 41, 418, DateTimeKind.Unspecified) },
                    { 17, 7, new DateTime(2023, 5, 25, 13, 57, 50, 710, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 17, 57, 50, 710, DateTimeKind.Unspecified) },
                    { 18, 9, new DateTime(2023, 3, 17, 19, 57, 56, 125, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 5, 57, 56, 125, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2023, 5, 13, 10, 32, 9, 970, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 14, 32, 9, 970, DateTimeKind.Unspecified) },
                    { 20, 5, new DateTime(2023, 5, 16, 21, 2, 39, 4, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 22, 2, 39, 4, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 5, 27, 10, 19, 23, 105, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 13, 19, 23, 105, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 8, new DateTime(2023, 2, 20, 12, 47, 23, 691, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 16, 47, 23, 691, DateTimeKind.Unspecified) },
                    { 23, 4, new DateTime(2023, 2, 12, 15, 34, 46, 496, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 0, 34, 46, 496, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2023, 5, 11, 20, 47, 26, 858, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 22, 47, 26, 858, DateTimeKind.Unspecified) },
                    { 25, 8, new DateTime(2023, 2, 16, 0, 20, 14, 884, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 1, 20, 14, 884, DateTimeKind.Unspecified) },
                    { 26, 9, new DateTime(2023, 4, 2, 2, 12, 10, 341, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 7, 12, 10, 341, DateTimeKind.Unspecified) },
                    { 27, 3, new DateTime(2023, 3, 8, 1, 57, 53, 534, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 5, 57, 53, 534, DateTimeKind.Unspecified) },
                    { 28, 6, new DateTime(2023, 3, 12, 6, 40, 42, 276, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 14, 40, 42, 276, DateTimeKind.Unspecified) },
                    { 29, 8, new DateTime(2023, 2, 20, 4, 45, 45, 776, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 11, 45, 45, 776, DateTimeKind.Unspecified) },
                    { 30, 2, new DateTime(2023, 4, 23, 4, 31, 53, 943, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 11, 31, 53, 943, DateTimeKind.Unspecified) },
                    { 31, 9, new DateTime(2023, 2, 4, 15, 29, 2, 883, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 21, 29, 2, 883, DateTimeKind.Unspecified) },
                    { 32, 6, new DateTime(2023, 3, 2, 8, 50, 38, 386, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 17, 50, 38, 386, DateTimeKind.Unspecified) },
                    { 33, 7, new DateTime(2023, 4, 20, 11, 18, 6, 209, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 18, 18, 6, 209, DateTimeKind.Unspecified) },
                    { 34, 4, new DateTime(2023, 4, 23, 11, 18, 29, 14, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 17, 18, 29, 14, DateTimeKind.Unspecified) },
                    { 35, 2, new DateTime(2023, 2, 17, 15, 17, 47, 188, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 20, 17, 47, 188, DateTimeKind.Unspecified) },
                    { 36, 2, new DateTime(2023, 3, 26, 2, 47, 57, 60, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 9, 47, 57, 60, DateTimeKind.Unspecified) },
                    { 37, 3, new DateTime(2023, 3, 24, 0, 26, 46, 426, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 3, 26, 46, 426, DateTimeKind.Unspecified) },
                    { 38, 7, new DateTime(2023, 2, 3, 13, 19, 27, 144, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 18, 19, 27, 144, DateTimeKind.Unspecified) },
                    { 39, 6, new DateTime(2023, 2, 7, 20, 17, 9, 646, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 23, 17, 9, 646, DateTimeKind.Unspecified) },
                    { 40, 9, new DateTime(2023, 4, 29, 18, 25, 10, 820, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 4, 25, 10, 820, DateTimeKind.Unspecified) },
                    { 41, 4, new DateTime(2023, 4, 21, 19, 12, 1, 569, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 20, 12, 1, 569, DateTimeKind.Unspecified) },
                    { 42, 8, new DateTime(2023, 2, 5, 9, 56, 3, 515, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 19, 56, 3, 515, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 2, 4, 14, 22, 51, 545, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 22, 22, 51, 545, DateTimeKind.Unspecified) },
                    { 44, 4, new DateTime(2023, 2, 20, 21, 44, 20, 466, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 23, 44, 20, 466, DateTimeKind.Unspecified) },
                    { 45, 3, new DateTime(2023, 3, 30, 4, 17, 55, 140, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 10, 17, 55, 140, DateTimeKind.Unspecified) },
                    { 46, 4, new DateTime(2023, 3, 19, 21, 15, 36, 211, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 5, 15, 36, 211, DateTimeKind.Unspecified) },
                    { 47, 3, new DateTime(2023, 2, 7, 19, 15, 34, 313, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 22, 15, 34, 313, DateTimeKind.Unspecified) },
                    { 48, 7, new DateTime(2023, 3, 10, 19, 55, 33, 937, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 23, 55, 33, 937, DateTimeKind.Unspecified) },
                    { 49, 5, new DateTime(2023, 3, 28, 4, 27, 6, 334, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 7, 27, 6, 334, DateTimeKind.Unspecified) },
                    { 50, 6, new DateTime(2023, 3, 25, 2, 41, 23, 555, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 5, 41, 23, 555, DateTimeKind.Unspecified) },
                    { 51, 8, new DateTime(2023, 5, 6, 9, 52, 59, 630, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 17, 52, 59, 630, DateTimeKind.Unspecified) },
                    { 52, 2, new DateTime(2023, 2, 14, 1, 57, 30, 243, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 2, 57, 30, 243, DateTimeKind.Unspecified) },
                    { 53, 2, new DateTime(2023, 4, 22, 3, 28, 46, 317, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 13, 28, 46, 317, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 2, 23, 22, 15, 19, 324, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 6, 15, 19, 324, DateTimeKind.Unspecified) },
                    { 55, 2, new DateTime(2023, 4, 13, 21, 33, 37, 328, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 0, 33, 37, 328, DateTimeKind.Unspecified) },
                    { 56, 6, new DateTime(2023, 2, 12, 7, 51, 29, 311, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 17, 51, 29, 311, DateTimeKind.Unspecified) },
                    { 57, 2, new DateTime(2023, 4, 15, 9, 3, 40, 43, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 3, 40, 43, DateTimeKind.Unspecified) },
                    { 58, 1, new DateTime(2023, 3, 31, 3, 43, 53, 726, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 9, 43, 53, 726, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 5, 4, 2, 48, 21, 551, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 4, 48, 21, 551, DateTimeKind.Unspecified) },
                    { 60, 8, new DateTime(2023, 2, 11, 7, 37, 36, 409, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 11, 37, 36, 409, DateTimeKind.Unspecified) },
                    { 61, 3, new DateTime(2023, 5, 18, 17, 51, 25, 988, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 2, 51, 25, 988, DateTimeKind.Unspecified) },
                    { 62, 6, new DateTime(2023, 4, 11, 12, 33, 47, 929, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 19, 33, 47, 929, DateTimeKind.Unspecified) },
                    { 63, 5, new DateTime(2023, 3, 30, 2, 50, 31, 551, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 12, 50, 31, 551, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 4, new DateTime(2023, 4, 20, 9, 44, 55, 570, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 12, 44, 55, 570, DateTimeKind.Unspecified) },
                    { 65, 3, new DateTime(2023, 5, 4, 16, 5, 28, 489, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 2, 5, 28, 489, DateTimeKind.Unspecified) },
                    { 66, 6, new DateTime(2023, 2, 18, 13, 22, 58, 932, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 17, 22, 58, 932, DateTimeKind.Unspecified) },
                    { 67, 7, new DateTime(2023, 2, 27, 1, 11, 21, 489, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 8, 11, 21, 489, DateTimeKind.Unspecified) },
                    { 68, 9, new DateTime(2023, 5, 28, 10, 55, 9, 537, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 18, 55, 9, 537, DateTimeKind.Unspecified) },
                    { 69, 8, new DateTime(2023, 2, 10, 11, 37, 32, 604, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 16, 37, 32, 604, DateTimeKind.Unspecified) },
                    { 70, 2, new DateTime(2023, 4, 11, 16, 27, 7, 553, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 19, 27, 7, 553, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 5, 23, 18, 13, 22, 838, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 23, 13, 22, 838, DateTimeKind.Unspecified) },
                    { 72, 4, new DateTime(2023, 3, 4, 11, 1, 25, 251, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 17, 1, 25, 251, DateTimeKind.Unspecified) },
                    { 73, 2, new DateTime(2023, 5, 18, 9, 26, 24, 902, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 10, 26, 24, 902, DateTimeKind.Unspecified) },
                    { 74, 2, new DateTime(2023, 4, 13, 18, 52, 44, 927, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 4, 52, 44, 927, DateTimeKind.Unspecified) },
                    { 75, 6, new DateTime(2023, 5, 27, 22, 37, 21, 93, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 3, 37, 21, 93, DateTimeKind.Unspecified) },
                    { 76, 5, new DateTime(2023, 5, 22, 21, 25, 4, 572, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 0, 25, 4, 572, DateTimeKind.Unspecified) },
                    { 77, 5, new DateTime(2023, 5, 16, 8, 51, 1, 375, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 16, 51, 1, 375, DateTimeKind.Unspecified) },
                    { 78, 3, new DateTime(2023, 3, 15, 8, 33, 48, 448, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 14, 33, 48, 448, DateTimeKind.Unspecified) },
                    { 79, 5, new DateTime(2023, 2, 9, 4, 18, 52, 973, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 8, 18, 52, 973, DateTimeKind.Unspecified) },
                    { 80, 3, new DateTime(2023, 3, 4, 8, 11, 21, 489, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 12, 11, 21, 489, DateTimeKind.Unspecified) },
                    { 81, 1, new DateTime(2023, 4, 29, 20, 34, 5, 630, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 23, 34, 5, 630, DateTimeKind.Unspecified) },
                    { 82, 8, new DateTime(2023, 5, 8, 21, 27, 9, 479, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 2, 27, 9, 479, DateTimeKind.Unspecified) },
                    { 83, 1, new DateTime(2023, 3, 19, 15, 21, 18, 632, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 17, 21, 18, 632, DateTimeKind.Unspecified) },
                    { 84, 9, new DateTime(2023, 4, 3, 2, 52, 17, 492, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 9, 52, 17, 492, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 5, 16, 4, 34, 15, 595, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 10, 34, 15, 595, DateTimeKind.Unspecified) },
                    { 86, 5, new DateTime(2023, 3, 30, 23, 51, 18, 909, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 8, 51, 18, 909, DateTimeKind.Unspecified) },
                    { 87, 1, new DateTime(2023, 5, 9, 15, 12, 31, 944, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 19, 12, 31, 944, DateTimeKind.Unspecified) },
                    { 88, 8, new DateTime(2023, 5, 4, 22, 23, 28, 529, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 23, 23, 28, 529, DateTimeKind.Unspecified) },
                    { 89, 5, new DateTime(2023, 5, 28, 8, 2, 21, 749, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 15, 2, 21, 749, DateTimeKind.Unspecified) },
                    { 90, 8, new DateTime(2023, 4, 25, 19, 12, 20, 492, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 21, 12, 20, 492, DateTimeKind.Unspecified) },
                    { 91, 4, new DateTime(2023, 2, 18, 23, 15, 32, 891, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 1, 15, 32, 891, DateTimeKind.Unspecified) },
                    { 92, 9, new DateTime(2023, 2, 1, 11, 26, 1, 260, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 19, 26, 1, 260, DateTimeKind.Unspecified) },
                    { 93, 7, new DateTime(2023, 3, 25, 22, 53, 43, 891, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 3, 53, 43, 891, DateTimeKind.Unspecified) },
                    { 94, 2, new DateTime(2023, 3, 20, 18, 27, 36, 344, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 3, 27, 36, 344, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 5, 16, 8, 27, 37, 190, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 11, 27, 37, 190, DateTimeKind.Unspecified) },
                    { 96, 6, new DateTime(2023, 4, 6, 19, 32, 14, 582, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 0, 32, 14, 582, DateTimeKind.Unspecified) },
                    { 97, 4, new DateTime(2023, 3, 4, 22, 5, 30, 142, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 23, 5, 30, 142, DateTimeKind.Unspecified) },
                    { 98, 8, new DateTime(2023, 4, 22, 10, 7, 14, 205, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 11, 7, 14, 205, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 4, 28, 4, 44, 34, 417, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 5, 44, 34, 417, DateTimeKind.Unspecified) },
                    { 100, 1, new DateTime(2023, 4, 26, 9, 11, 52, 180, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 17, 11, 52, 180, DateTimeKind.Unspecified) },
                    { 101, 7, new DateTime(2023, 3, 27, 23, 12, 5, 614, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 6, 12, 5, 614, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2861), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2863), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2863), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(2864), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 3, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3589), 700m },
                    { 6, 5, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3610), 700m },
                    { 7, 8, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3619), 700m },
                    { 8, 9, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3628), 700m },
                    { 9, 3, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3656), 700m },
                    { 10, 4, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3673), 700m },
                    { 11, 8, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3681), 700m },
                    { 12, 2, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3690), 700m },
                    { 13, 5, false, new DateTime(2023, 5, 24, 17, 19, 48, 20, DateTimeKind.Local).AddTicks(3698), 700m }
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
