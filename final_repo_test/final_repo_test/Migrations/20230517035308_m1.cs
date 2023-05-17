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
                    { 1, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9195), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9196), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "d2sr8r0@gmail.com", 0, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0916573999", "d2sr8r0", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "jis75v@gmail.com", 0, new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 1, "0916381466", "jis75v", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "krx1gqhqa@gmail.com", 1, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0911286343", "krx1gqhqa", 0, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "1j33rw@gmail.com", 0, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0917318739", "1j33rw", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "yp80qexp260@gmail.com", 1, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 2, "0912649758", "yp80qexp260", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "dry3ict1oz@gmail.com", 1, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0913609542", "dry3ict1oz", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "51oq94@gmail.com", 1, new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0915042482", "51oq94", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "zcyhcoo@gmail.com", 0, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0911685859", "zcyhcoo", 1, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9205), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9206), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9105), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9104), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9118), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9117), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9124), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9124), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9130), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9130), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9136), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9136), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9143), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9143), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9149), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9148), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9155), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9154), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9160), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9160), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9166), "Test", 99, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9166), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 237, 11, "", new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 2, 15000, 1, 159, 16, "", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 3, 15000, 1, 217, 11, "", new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 4, 15000, 1, 225, 15, "", new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 5, 15000, 1, 96, 10, "", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 6, 15000, 1, 81, 17, "", new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 7, 15000, 1, 164, 13, "", new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 8, 15000, 1, 179, 15, "", new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 9, 15000, 1, 199, 24, "", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 10, 15000, 1, 58, 19, "", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 11, 15000, 1, 130, 18, "", new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 12, 15000, 1, 112, 9, "", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 13, 15000, 1, 105, 10, "", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 14, 15000, 1, 195, 21, "", new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 6 },
                    { 15, 15000, 1, 124, 22, "", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 16, 15000, 1, 229, 10, "", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 17, 15000, 1, 102, 23, "", new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 18, 15000, 1, 70, 7, "", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 17 },
                    { 19, 15000, 1, 111, 19, "", new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 20, 15000, 1, 49, 14, "", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 21, 15000, 1, 54, 22, "", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 22, 15000, 1, 232, 8, "", new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 23, 15000, 1, 116, 8, "", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 24, 15000, 1, 46, 12, "", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 25, 15000, 1, 208, 16, "", new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 26, 15000, 1, 93, 15, "", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 27, 15000, 1, 55, 7, "", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 28, 15000, 1, 124, 11, "", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 29, 15000, 1, 183, 15, "", new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9184), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9186), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 5, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8400) },
                    { 2, 6, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8470) },
                    { 3, 8, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8472) },
                    { 4, 2, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8473) },
                    { 5, 8, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8475) },
                    { 6, 5, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8477) },
                    { 7, 7, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8478) },
                    { 8, 9, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8480) },
                    { 9, 7, null, "test", true, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8481) },
                    { 10, 10, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8483) },
                    { 11, 6, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8484) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8486) },
                    { 13, 1, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8487) },
                    { 14, 5, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8488) },
                    { 15, 10, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8489) },
                    { 16, 1, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8491) },
                    { 17, 8, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8492) },
                    { 18, 4, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8493) },
                    { 19, 5, null, "test", false, new DateTime(2023, 5, 17, 11, 53, 8, 17, DateTimeKind.Local).AddTicks(8494) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 18, 20, 22, 45, 621, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 1, 22, 45, 621, DateTimeKind.Unspecified) },
                    { 2, 7, new DateTime(2023, 3, 7, 23, 56, 37, 381, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 7, 56, 37, 381, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2023, 5, 24, 11, 12, 27, 53, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 14, 12, 27, 53, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(2023, 5, 19, 12, 35, 3, 711, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 19, 35, 3, 711, DateTimeKind.Unspecified) },
                    { 5, 9, new DateTime(2023, 4, 5, 17, 7, 28, 723, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 23, 7, 28, 723, DateTimeKind.Unspecified) },
                    { 6, 8, new DateTime(2023, 4, 22, 0, 13, 28, 358, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 9, 13, 28, 358, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2023, 5, 26, 4, 47, 21, 522, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 7, 47, 21, 522, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(2023, 2, 26, 4, 15, 41, 934, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 14, 15, 41, 934, DateTimeKind.Unspecified) },
                    { 9, 7, new DateTime(2023, 5, 26, 6, 44, 15, 923, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 11, 44, 15, 923, DateTimeKind.Unspecified) },
                    { 10, 9, new DateTime(2023, 3, 18, 2, 8, 43, 186, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 7, 8, 43, 186, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2023, 4, 28, 19, 12, 54, 208, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 5, 12, 54, 208, DateTimeKind.Unspecified) },
                    { 12, 7, new DateTime(2023, 2, 8, 0, 5, 41, 501, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 10, 5, 41, 501, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2023, 4, 3, 13, 15, 5, 900, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 22, 15, 5, 900, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 4, 27, 3, 58, 20, 274, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 12, 58, 20, 274, DateTimeKind.Unspecified) },
                    { 15, 3, new DateTime(2023, 5, 22, 22, 3, 51, 320, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 4, 3, 51, 320, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 3, 9, 21, 36, 22, 758, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 2, 36, 22, 758, DateTimeKind.Unspecified) },
                    { 17, 5, new DateTime(2023, 3, 13, 20, 53, 11, 62, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 22, 53, 11, 62, DateTimeKind.Unspecified) },
                    { 18, 5, new DateTime(2023, 3, 7, 22, 45, 1, 795, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 8, 45, 1, 795, DateTimeKind.Unspecified) },
                    { 19, 7, new DateTime(2023, 2, 13, 5, 15, 57, 587, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 11, 15, 57, 587, DateTimeKind.Unspecified) },
                    { 20, 9, new DateTime(2023, 5, 4, 12, 24, 50, 924, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 20, 24, 50, 924, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 26, 11, 51, 32, 712, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 20, 51, 32, 712, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 5, new DateTime(2023, 3, 23, 5, 6, 9, 389, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 6, 6, 9, 389, DateTimeKind.Unspecified) },
                    { 23, 5, new DateTime(2023, 2, 1, 10, 14, 10, 635, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 18, 14, 10, 635, DateTimeKind.Unspecified) },
                    { 24, 3, new DateTime(2023, 4, 2, 8, 0, 48, 246, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 11, 0, 48, 246, DateTimeKind.Unspecified) },
                    { 25, 3, new DateTime(2023, 5, 8, 22, 31, 58, 127, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 3, 31, 58, 127, DateTimeKind.Unspecified) },
                    { 26, 9, new DateTime(2023, 3, 22, 23, 7, 56, 799, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 8, 7, 56, 799, DateTimeKind.Unspecified) },
                    { 27, 7, new DateTime(2023, 2, 27, 17, 51, 22, 805, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 1, 51, 22, 805, DateTimeKind.Unspecified) },
                    { 28, 3, new DateTime(2023, 5, 8, 21, 0, 47, 894, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 4, 0, 47, 894, DateTimeKind.Unspecified) },
                    { 29, 8, new DateTime(2023, 2, 17, 1, 19, 57, 717, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 3, 19, 57, 717, DateTimeKind.Unspecified) },
                    { 30, 5, new DateTime(2023, 2, 12, 2, 34, 2, 975, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 5, 34, 2, 975, DateTimeKind.Unspecified) },
                    { 31, 4, new DateTime(2023, 3, 30, 21, 6, 50, 234, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 1, 6, 50, 234, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2023, 5, 10, 21, 3, 49, 273, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 7, 3, 49, 273, DateTimeKind.Unspecified) },
                    { 33, 7, new DateTime(2023, 4, 22, 23, 0, 3, 204, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 6, 0, 3, 204, DateTimeKind.Unspecified) },
                    { 34, 6, new DateTime(2023, 4, 11, 4, 55, 30, 502, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 14, 55, 30, 502, DateTimeKind.Unspecified) },
                    { 35, 5, new DateTime(2023, 5, 29, 17, 49, 58, 612, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 2, 49, 58, 612, DateTimeKind.Unspecified) },
                    { 36, 7, new DateTime(2023, 2, 1, 14, 50, 32, 122, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 23, 50, 32, 122, DateTimeKind.Unspecified) },
                    { 37, 9, new DateTime(2023, 3, 12, 21, 41, 20, 237, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 5, 41, 20, 237, DateTimeKind.Unspecified) },
                    { 38, 5, new DateTime(2023, 2, 1, 19, 24, 28, 868, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 21, 24, 28, 868, DateTimeKind.Unspecified) },
                    { 39, 4, new DateTime(2023, 4, 26, 17, 22, 30, 188, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 0, 22, 30, 188, DateTimeKind.Unspecified) },
                    { 40, 9, new DateTime(2023, 4, 25, 19, 3, 12, 689, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 22, 3, 12, 689, DateTimeKind.Unspecified) },
                    { 41, 6, new DateTime(2023, 5, 7, 13, 30, 55, 264, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 18, 30, 55, 264, DateTimeKind.Unspecified) },
                    { 42, 2, new DateTime(2023, 2, 21, 12, 43, 18, 413, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 15, 43, 18, 413, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 5, 29, 20, 41, 19, 723, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 22, 41, 19, 723, DateTimeKind.Unspecified) },
                    { 44, 3, new DateTime(2023, 2, 28, 19, 7, 28, 190, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 2, 7, 28, 190, DateTimeKind.Unspecified) },
                    { 45, 3, new DateTime(2023, 3, 1, 22, 28, 45, 59, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 2, 28, 45, 59, DateTimeKind.Unspecified) },
                    { 46, 7, new DateTime(2023, 2, 1, 12, 23, 56, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 13, 23, 56, 0, DateTimeKind.Unspecified) },
                    { 47, 4, new DateTime(2023, 4, 5, 21, 51, 51, 779, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 2, 51, 51, 779, DateTimeKind.Unspecified) },
                    { 48, 5, new DateTime(2023, 2, 25, 6, 20, 26, 607, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 14, 20, 26, 607, DateTimeKind.Unspecified) },
                    { 49, 8, new DateTime(2023, 2, 11, 3, 47, 22, 981, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 9, 47, 22, 981, DateTimeKind.Unspecified) },
                    { 50, 8, new DateTime(2023, 3, 25, 0, 47, 23, 388, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 6, 47, 23, 388, DateTimeKind.Unspecified) },
                    { 51, 6, new DateTime(2023, 2, 16, 3, 9, 6, 314, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 6, 9, 6, 314, DateTimeKind.Unspecified) },
                    { 52, 8, new DateTime(2023, 4, 22, 13, 54, 55, 229, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 21, 54, 55, 229, DateTimeKind.Unspecified) },
                    { 53, 6, new DateTime(2023, 2, 28, 19, 54, 1, 279, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 5, 54, 1, 279, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 3, 9, 12, 52, 30, 918, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 17, 52, 30, 918, DateTimeKind.Unspecified) },
                    { 55, 5, new DateTime(2023, 2, 24, 6, 51, 12, 112, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 9, 51, 12, 112, DateTimeKind.Unspecified) },
                    { 56, 6, new DateTime(2023, 4, 15, 20, 48, 59, 651, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 3, 48, 59, 651, DateTimeKind.Unspecified) },
                    { 57, 6, new DateTime(2023, 4, 5, 12, 51, 30, 120, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 14, 51, 30, 120, DateTimeKind.Unspecified) },
                    { 58, 1, new DateTime(2023, 5, 24, 4, 39, 49, 482, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 12, 39, 49, 482, DateTimeKind.Unspecified) },
                    { 59, 4, new DateTime(2023, 3, 11, 18, 40, 22, 807, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 20, 40, 22, 807, DateTimeKind.Unspecified) },
                    { 60, 4, new DateTime(2023, 5, 20, 6, 51, 12, 870, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 10, 51, 12, 870, DateTimeKind.Unspecified) },
                    { 61, 2, new DateTime(2023, 4, 6, 8, 8, 12, 64, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 14, 8, 12, 64, DateTimeKind.Unspecified) },
                    { 62, 7, new DateTime(2023, 4, 27, 15, 22, 43, 253, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 18, 22, 43, 253, DateTimeKind.Unspecified) },
                    { 63, 6, new DateTime(2023, 5, 2, 18, 43, 27, 377, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 3, 43, 27, 377, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 2, new DateTime(2023, 4, 3, 12, 19, 18, 489, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 17, 19, 18, 489, DateTimeKind.Unspecified) },
                    { 65, 4, new DateTime(2023, 4, 10, 3, 41, 33, 778, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 11, 41, 33, 778, DateTimeKind.Unspecified) },
                    { 66, 6, new DateTime(2023, 5, 14, 21, 1, 5, 7, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 3, 1, 5, 7, DateTimeKind.Unspecified) },
                    { 67, 6, new DateTime(2023, 4, 27, 17, 58, 31, 368, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 22, 58, 31, 368, DateTimeKind.Unspecified) },
                    { 68, 7, new DateTime(2023, 5, 11, 13, 10, 11, 259, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 16, 10, 11, 259, DateTimeKind.Unspecified) },
                    { 69, 2, new DateTime(2023, 2, 3, 12, 59, 23, 710, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 20, 59, 23, 710, DateTimeKind.Unspecified) },
                    { 70, 2, new DateTime(2023, 4, 21, 23, 32, 45, 747, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 6, 32, 45, 747, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 5, 18, 19, 45, 7, 129, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 0, 45, 7, 129, DateTimeKind.Unspecified) },
                    { 72, 2, new DateTime(2023, 4, 21, 5, 39, 19, 881, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 9, 39, 19, 881, DateTimeKind.Unspecified) },
                    { 73, 9, new DateTime(2023, 5, 16, 11, 1, 50, 739, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 21, 1, 50, 739, DateTimeKind.Unspecified) },
                    { 74, 7, new DateTime(2023, 4, 12, 13, 49, 57, 503, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 22, 49, 57, 503, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 2, 12, 23, 22, 43, 961, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 4, 22, 43, 961, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 2, 27, 8, 6, 24, 367, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 13, 6, 24, 367, DateTimeKind.Unspecified) },
                    { 77, 4, new DateTime(2023, 2, 22, 17, 4, 48, 152, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 1, 4, 48, 152, DateTimeKind.Unspecified) },
                    { 78, 3, new DateTime(2023, 5, 27, 17, 44, 58, 425, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 18, 44, 58, 425, DateTimeKind.Unspecified) },
                    { 79, 6, new DateTime(2023, 3, 13, 19, 32, 43, 402, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 4, 32, 43, 402, DateTimeKind.Unspecified) },
                    { 80, 4, new DateTime(2023, 3, 12, 23, 12, 31, 516, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 5, 12, 31, 516, DateTimeKind.Unspecified) },
                    { 81, 9, new DateTime(2023, 5, 1, 14, 48, 58, 940, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 19, 48, 58, 940, DateTimeKind.Unspecified) },
                    { 82, 4, new DateTime(2023, 3, 13, 22, 56, 51, 339, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 6, 56, 51, 339, DateTimeKind.Unspecified) },
                    { 83, 1, new DateTime(2023, 3, 18, 1, 20, 26, 2, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 2, 20, 26, 2, DateTimeKind.Unspecified) },
                    { 84, 3, new DateTime(2023, 2, 18, 8, 11, 24, 393, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 12, 11, 24, 393, DateTimeKind.Unspecified) },
                    { 85, 8, new DateTime(2023, 3, 21, 9, 51, 36, 255, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 12, 51, 36, 255, DateTimeKind.Unspecified) },
                    { 86, 5, new DateTime(2023, 2, 12, 12, 38, 49, 730, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 22, 38, 49, 730, DateTimeKind.Unspecified) },
                    { 87, 5, new DateTime(2023, 2, 16, 13, 36, 42, 943, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 22, 36, 42, 943, DateTimeKind.Unspecified) },
                    { 88, 3, new DateTime(2023, 2, 6, 0, 33, 37, 508, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 10, 33, 37, 508, DateTimeKind.Unspecified) },
                    { 89, 6, new DateTime(2023, 4, 16, 22, 48, 30, 202, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 23, 48, 30, 202, DateTimeKind.Unspecified) },
                    { 90, 4, new DateTime(2023, 5, 13, 19, 36, 43, 436, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 22, 36, 43, 436, DateTimeKind.Unspecified) },
                    { 91, 4, new DateTime(2023, 3, 25, 23, 28, 18, 737, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 6, 28, 18, 737, DateTimeKind.Unspecified) },
                    { 92, 6, new DateTime(2023, 3, 17, 18, 0, 21, 833, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 3, 0, 21, 833, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 2, 7, 1, 21, 58, 701, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 8, 21, 58, 701, DateTimeKind.Unspecified) },
                    { 94, 7, new DateTime(2023, 2, 18, 11, 34, 11, 356, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 19, 34, 11, 356, DateTimeKind.Unspecified) },
                    { 95, 2, new DateTime(2023, 2, 5, 4, 12, 23, 897, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 7, 12, 23, 897, DateTimeKind.Unspecified) },
                    { 96, 9, new DateTime(2023, 5, 27, 0, 58, 0, 902, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 3, 58, 0, 902, DateTimeKind.Unspecified) },
                    { 97, 3, new DateTime(2023, 4, 4, 19, 15, 8, 630, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 23, 15, 8, 630, DateTimeKind.Unspecified) },
                    { 98, 6, new DateTime(2023, 4, 24, 8, 25, 18, 577, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 13, 25, 18, 577, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 3, 28, 20, 9, 11, 728, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 1, 9, 11, 728, DateTimeKind.Unspecified) },
                    { 100, 3, new DateTime(2023, 3, 3, 14, 34, 35, 922, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 0, 34, 35, 922, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 3, 28, 0, 34, 56, 7, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 7, 34, 56, 7, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9215), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9216), 1198m },
                    { 3, 3, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9908), 699m },
                    { 4, 2, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9920), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 5, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9928), 699m },
                    { 6, 1, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9937), 699m },
                    { 7, 8, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9952), 699m },
                    { 8, 4, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9960), 699m },
                    { 9, 6, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9969), 699m },
                    { 10, 6, false, new DateTime(2023, 5, 17, 11, 53, 8, 18, DateTimeKind.Local).AddTicks(9977), 699m },
                    { 11, 2, false, new DateTime(2023, 5, 17, 11, 53, 8, 19, DateTimeKind.Local).AddTicks(9), 699m },
                    { 12, 1, false, new DateTime(2023, 5, 17, 11, 53, 8, 19, DateTimeKind.Local).AddTicks(17), 699m },
                    { 13, 6, false, new DateTime(2023, 5, 17, 11, 53, 8, 19, DateTimeKind.Local).AddTicks(25), 699m }
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
