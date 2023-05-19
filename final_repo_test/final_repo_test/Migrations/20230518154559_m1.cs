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
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8976), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8977), "200元換350點", false, "點數.png", "200元換350點", 200 }
========
                    { 1, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7730), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7731), "200元換350點", false, "點數.png", "200元換350點", 200 }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
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
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 2, "高雄市前金區", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "67og6v@gmail.com", 1, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0911240752", "67og6v", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "wy7e97e@gmail.com", 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 1, "0919084171", "wy7e97e", 0, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "tr1vripwk@gmail.com", 1, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0912549673", "tr1vripwk", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "e1h21tg8@gmail.com", 0, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0916471016", "e1h21tg8", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "319427v@gmail.com", 0, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 2, "0911975127", "319427v", 1, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "a2vs91en1p@gmail.com", 1, new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0914868300", "a2vs91en1p", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "gbrtq94@gmail.com", 1, new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0915242716", "gbrtq94", 0, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "wcrbhbg@gmail.com", 0, new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0919247395", "wcrbhbg", 1, "9", true, false, "user" }
========
                    { 2, "高雄市前金區", new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "o0slahz6@gmail.com", 1, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0918572912", "o0slahz6", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ob5vwp9uiaf@gmail.com", 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0916914431", "ob5vwp9uiaf", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "sja9tw@gmail.com", 0, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0917014304", "sja9tw", 0, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "yz5r70t@gmail.com", 1, new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0912469036", "yz5r70t", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "d7pik6rsr@gmail.com", 1, new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0910164873", "d7pik6rsr", 1, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "t8zr4ofx@gmail.com", 1, new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 1, "0912443074", "t8zr4ofx", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "mzoq7g7ph@gmail.com", 1, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0911770911", "mzoq7g7ph", 0, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "850n08x@gmail.com", 0, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 2, "0918443975", "850n08x", 0, "9", true, false, "user" }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
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
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8985), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8987), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
========
                    { 1, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7743), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7745), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8874), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8873), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8888), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8887), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8893), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8893), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8917), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8916), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8922), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8922), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8929), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8928), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8934), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8934), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8940), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8939), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8945), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8944), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8950), "Test", 99, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8950), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
========
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7599), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7596), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7621), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7621), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7629), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7629), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7637), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7637), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7645), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7645), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7655), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7654), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7662), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7662), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7670), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7669), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7677), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7677), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7685), "Test", 99, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7685), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, 15000, 1, 175, 11, "", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 2, 15000, 1, 200, 21, "", new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 3, 15000, 1, 168, 18, "", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 4, 15000, 1, 211, 10, "", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 5, 15000, 1, 111, 9, "", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 6, 15000, 1, 76, 10, "", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 7, 15000, 1, 138, 10, "", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 19 },
                    { 8, 15000, 1, 127, 16, "", new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 5 },
                    { 9, 15000, 1, 188, 14, "", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 4 },
                    { 10, 15000, 1, 184, 17, "", new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2 },
                    { 11, 15000, 1, 90, 8, "", new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 6 },
                    { 12, 15000, 1, 187, 13, "", new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 13, 15000, 1, 229, 9, "", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 14, 15000, 1, 200, 15, "", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 15, 15000, 1, 124, 14, "", new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 16, 15000, 1, 134, 7, "", new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 17, 15000, 1, 165, 18, "", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 18, 15000, 1, 173, 15, "", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 19, 15000, 1, 178, 23, "", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2 },
                    { 20, 15000, 1, 56, 12, "", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 21, 15000, 1, 195, 17, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 22, 15000, 1, 130, 22, "", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 23, 15000, 1, 41, 11, "", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 6 },
                    { 24, 15000, 1, 189, 22, "", new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 25, 15000, 1, 221, 10, "", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 26, 15000, 1, 135, 11, "", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 27, 15000, 1, 109, 19, "", new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 28, 15000, 1, 47, 21, "", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 29, 15000, 1, 39, 15, "", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 }
========
                    { 1, 15000, 1, 147, 23, "", new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 },
                    { 2, 15000, 1, 217, 23, "", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 3, 15000, 1, 152, 24, "", new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 5 },
                    { 4, 15000, 1, 113, 11, "", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 5, 15000, 1, 227, 14, "", new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 6, 15000, 1, 212, 17, "", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 7, 15000, 1, 103, 21, "", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 8, 15000, 1, 124, 18, "", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 9, 15000, 1, 172, 21, "", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 3 },
                    { 10, 15000, 1, 162, 8, "", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 11, 15000, 1, 215, 16, "", new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 12, 15000, 1, 56, 7, "", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 13, 15000, 1, 96, 7, "", new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 14, 15000, 1, 157, 18, "", new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 15, 15000, 1, 162, 20, "", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 16, 15000, 1, 129, 13, "", new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 17, 15000, 1, 166, 16, "", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 18, 15000, 1, 90, 10, "", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 19, 15000, 1, 235, 13, "", new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 20, 15000, 1, 58, 19, "", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 21, 15000, 1, 223, 17, "", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 22, 15000, 1, 106, 14, "", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 },
                    { 23, 15000, 1, 125, 19, "", new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 24, 15000, 1, 198, 20, "", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 25, 15000, 1, 64, 11, "", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 26, 15000, 1, 122, 11, "", new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 17 },
                    { 27, 15000, 1, 134, 10, "", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 28, 15000, 1, 229, 16, "", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5 },
                    { 29, 15000, 1, 116, 22, "", new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, 1, 1, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8966), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8967), 2, 400, 2 }
========
                    { 1, 1, 1, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7715), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7716), 2, 400, 2 }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, 1, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8552) },
                    { 2, 3, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8594) },
                    { 3, 4, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8596) },
                    { 4, 4, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8598) },
                    { 5, 5, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8599) },
                    { 6, 4, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8601) },
                    { 7, 7, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8603) },
                    { 8, 10, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8604) },
                    { 9, 4, null, "test", true, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8605) },
                    { 10, 10, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8607) },
                    { 11, 10, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8608) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8629) },
                    { 13, 6, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8631) },
                    { 14, 10, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8632) },
                    { 15, 10, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8633) },
                    { 16, 3, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8634) },
                    { 17, 6, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8636) },
                    { 18, 2, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8638) },
                    { 19, 7, null, "test", false, new DateTime(2023, 5, 18, 10, 25, 26, 551, DateTimeKind.Local).AddTicks(8639) }
========
                    { 1, 10, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2022) },
                    { 2, 4, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2071) },
                    { 3, 3, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2073) },
                    { 4, 3, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2075) },
                    { 5, 2, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2077) },
                    { 6, 6, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2080) },
                    { 7, 5, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2082) },
                    { 8, 5, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2084) },
                    { 9, 7, null, "test", true, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2086) },
                    { 10, 10, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2089) },
                    { 11, 3, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2092) },
                    { 12, 10, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2093) },
                    { 13, 10, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2095) },
                    { 14, 1, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2096) },
                    { 15, 10, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2098) },
                    { 16, 2, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2100) },
                    { 17, 6, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2101) },
                    { 18, 10, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2140) },
                    { 19, 5, null, "test", false, new DateTime(2023, 5, 18, 23, 45, 59, 425, DateTimeKind.Local).AddTicks(2143) }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, 9, new DateTime(2023, 4, 19, 18, 26, 33, 272, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 19, 26, 33, 272, DateTimeKind.Unspecified) },
                    { 2, 8, new DateTime(2023, 3, 7, 2, 43, 59, 1, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 3, 43, 59, 1, DateTimeKind.Unspecified) },
                    { 3, 5, new DateTime(2023, 4, 5, 22, 8, 18, 67, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 23, 8, 18, 67, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 2, 8, 20, 25, 46, 401, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 4, 25, 46, 401, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2023, 2, 21, 18, 40, 15, 817, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 21, 40, 15, 817, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2023, 4, 25, 22, 15, 39, 779, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 6, 15, 39, 779, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(2023, 4, 13, 7, 41, 57, 510, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 16, 41, 57, 510, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(2023, 2, 24, 10, 42, 51, 271, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 17, 42, 51, 271, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(2023, 5, 29, 21, 6, 44, 10, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 5, 6, 44, 10, DateTimeKind.Unspecified) },
                    { 10, 6, new DateTime(2023, 5, 30, 14, 4, 42, 985, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 17, 4, 42, 985, DateTimeKind.Unspecified) },
                    { 11, 9, new DateTime(2023, 2, 14, 18, 14, 16, 454, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 22, 14, 16, 454, DateTimeKind.Unspecified) },
                    { 12, 5, new DateTime(2023, 3, 1, 23, 40, 46, 992, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 8, 40, 46, 992, DateTimeKind.Unspecified) },
                    { 13, 3, new DateTime(2023, 5, 17, 16, 18, 30, 179, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 21, 18, 30, 179, DateTimeKind.Unspecified) },
                    { 14, 9, new DateTime(2023, 2, 26, 3, 26, 9, 657, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 6, 26, 9, 657, DateTimeKind.Unspecified) },
                    { 15, 6, new DateTime(2023, 4, 20, 15, 25, 6, 346, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 23, 25, 6, 346, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 3, 9, 4, 36, 35, 888, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 11, 36, 35, 888, DateTimeKind.Unspecified) },
                    { 17, 6, new DateTime(2023, 4, 27, 23, 35, 57, 812, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 7, 35, 57, 812, DateTimeKind.Unspecified) },
                    { 18, 8, new DateTime(2023, 3, 1, 20, 18, 41, 475, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 6, 18, 41, 475, DateTimeKind.Unspecified) },
                    { 19, 4, new DateTime(2023, 3, 17, 10, 20, 44, 772, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 11, 20, 44, 772, DateTimeKind.Unspecified) },
                    { 20, 9, new DateTime(2023, 4, 18, 7, 15, 20, 547, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 11, 15, 20, 547, DateTimeKind.Unspecified) },
                    { 21, 8, new DateTime(2023, 2, 27, 16, 49, 50, 312, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 19, 49, 50, 312, DateTimeKind.Unspecified) }
========
                    { 1, 7, new DateTime(2023, 3, 8, 6, 35, 10, 347, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 16, 35, 10, 347, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 2, 4, 20, 46, 20, 695, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 1, 46, 20, 695, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2023, 3, 7, 1, 9, 25, 858, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 3, 9, 25, 858, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2023, 5, 27, 9, 41, 20, 53, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 10, 41, 20, 53, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2023, 3, 26, 18, 0, 19, 124, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 19, 0, 19, 124, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(2023, 5, 16, 7, 52, 49, 545, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 9, 52, 49, 545, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 5, 8, 19, 25, 18, 44, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 5, 25, 18, 44, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2023, 5, 11, 18, 48, 1, 338, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 1, 48, 1, 338, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2023, 5, 13, 21, 55, 59, 391, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 3, 55, 59, 391, DateTimeKind.Unspecified) },
                    { 10, 9, new DateTime(2023, 5, 31, 1, 50, 12, 209, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 10, 50, 12, 209, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2023, 4, 2, 12, 43, 55, 399, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 16, 43, 55, 399, DateTimeKind.Unspecified) },
                    { 12, 9, new DateTime(2023, 4, 29, 11, 57, 40, 192, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 19, 57, 40, 192, DateTimeKind.Unspecified) },
                    { 13, 4, new DateTime(2023, 3, 30, 6, 26, 5, 803, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 8, 26, 5, 803, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 2, 27, 3, 34, 54, 183, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 9, 34, 54, 183, DateTimeKind.Unspecified) },
                    { 15, 7, new DateTime(2023, 2, 2, 11, 28, 55, 601, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 17, 28, 55, 601, DateTimeKind.Unspecified) },
                    { 16, 5, new DateTime(2023, 2, 28, 7, 51, 53, 504, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 14, 51, 53, 504, DateTimeKind.Unspecified) },
                    { 17, 5, new DateTime(2023, 4, 7, 22, 42, 19, 793, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 8, 42, 19, 793, DateTimeKind.Unspecified) },
                    { 18, 6, new DateTime(2023, 4, 5, 1, 16, 23, 133, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 10, 16, 23, 133, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 3, 25, 0, 39, 44, 489, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 3, 39, 44, 489, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 4, 7, 1, 37, 6, 272, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 2, 37, 6, 272, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2023, 4, 11, 17, 40, 1, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 19, 40, 1, 0, DateTimeKind.Unspecified) }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 22, 7, new DateTime(2023, 5, 30, 13, 41, 49, 619, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 22, 41, 49, 619, DateTimeKind.Unspecified) },
                    { 23, 6, new DateTime(2023, 2, 8, 3, 11, 11, 941, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 12, 11, 11, 941, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2023, 2, 2, 16, 18, 18, 320, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 22, 18, 18, 320, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2023, 3, 14, 16, 7, 28, 466, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 21, 7, 28, 466, DateTimeKind.Unspecified) },
                    { 26, 5, new DateTime(2023, 4, 1, 18, 42, 32, 501, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 2, 42, 32, 501, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 3, 2, 17, 44, 12, 967, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 1, 44, 12, 967, DateTimeKind.Unspecified) },
                    { 28, 6, new DateTime(2023, 2, 18, 15, 15, 38, 269, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 18, 15, 38, 269, DateTimeKind.Unspecified) },
                    { 29, 8, new DateTime(2023, 3, 4, 18, 39, 8, 715, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 19, 39, 8, 715, DateTimeKind.Unspecified) },
                    { 30, 2, new DateTime(2023, 3, 14, 11, 10, 49, 551, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 19, 10, 49, 551, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2023, 3, 23, 5, 43, 0, 746, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 6, 43, 0, 746, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2023, 3, 12, 9, 29, 7, 299, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 11, 29, 7, 299, DateTimeKind.Unspecified) },
                    { 33, 1, new DateTime(2023, 3, 20, 21, 1, 52, 201, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 4, 1, 52, 201, DateTimeKind.Unspecified) },
                    { 34, 7, new DateTime(2023, 4, 27, 19, 5, 2, 861, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 22, 5, 2, 861, DateTimeKind.Unspecified) },
                    { 35, 8, new DateTime(2023, 2, 19, 2, 2, 26, 124, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 7, 2, 26, 124, DateTimeKind.Unspecified) },
                    { 36, 9, new DateTime(2023, 3, 29, 7, 11, 4, 721, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 16, 11, 4, 721, DateTimeKind.Unspecified) },
                    { 37, 5, new DateTime(2023, 4, 9, 20, 1, 37, 325, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 1, 1, 37, 325, DateTimeKind.Unspecified) },
                    { 38, 8, new DateTime(2023, 2, 10, 7, 30, 44, 857, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 17, 30, 44, 857, DateTimeKind.Unspecified) },
                    { 39, 6, new DateTime(2023, 4, 9, 4, 46, 9, 420, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 11, 46, 9, 420, DateTimeKind.Unspecified) },
                    { 40, 7, new DateTime(2023, 5, 17, 19, 4, 12, 169, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 21, 4, 12, 169, DateTimeKind.Unspecified) },
                    { 41, 9, new DateTime(2023, 4, 5, 0, 45, 35, 959, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 9, 45, 35, 959, DateTimeKind.Unspecified) },
                    { 42, 3, new DateTime(2023, 3, 31, 4, 26, 24, 175, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 8, 26, 24, 175, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 5, 26, 2, 26, 27, 7, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 7, 26, 27, 7, DateTimeKind.Unspecified) },
                    { 44, 8, new DateTime(2023, 3, 30, 3, 8, 48, 594, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 5, 8, 48, 594, DateTimeKind.Unspecified) },
                    { 45, 3, new DateTime(2023, 3, 25, 16, 13, 47, 336, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 19, 13, 47, 336, DateTimeKind.Unspecified) },
                    { 46, 6, new DateTime(2023, 4, 17, 3, 37, 48, 883, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 11, 37, 48, 883, DateTimeKind.Unspecified) },
                    { 47, 1, new DateTime(2023, 5, 7, 16, 1, 11, 119, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 23, 1, 11, 119, DateTimeKind.Unspecified) },
                    { 48, 4, new DateTime(2023, 5, 6, 4, 35, 35, 251, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 13, 35, 35, 251, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2023, 5, 24, 0, 46, 8, 217, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 1, 46, 8, 217, DateTimeKind.Unspecified) },
                    { 50, 3, new DateTime(2023, 5, 23, 3, 15, 34, 61, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 13, 15, 34, 61, DateTimeKind.Unspecified) },
                    { 51, 5, new DateTime(2023, 2, 12, 14, 35, 11, 136, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 18, 35, 11, 136, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2023, 3, 30, 23, 53, 11, 952, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 6, 53, 11, 952, DateTimeKind.Unspecified) },
                    { 53, 2, new DateTime(2023, 3, 4, 1, 28, 39, 184, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 4, 28, 39, 184, DateTimeKind.Unspecified) },
                    { 54, 3, new DateTime(2023, 4, 22, 14, 6, 19, 606, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 18, 6, 19, 606, DateTimeKind.Unspecified) },
                    { 55, 2, new DateTime(2023, 5, 10, 13, 53, 17, 816, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 22, 53, 17, 816, DateTimeKind.Unspecified) },
                    { 56, 1, new DateTime(2023, 5, 29, 12, 12, 52, 874, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 22, 12, 52, 874, DateTimeKind.Unspecified) },
                    { 57, 2, new DateTime(2023, 5, 18, 17, 25, 23, 968, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 1, 25, 23, 968, DateTimeKind.Unspecified) },
                    { 58, 5, new DateTime(2023, 3, 12, 15, 21, 35, 802, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 20, 21, 35, 802, DateTimeKind.Unspecified) },
                    { 59, 2, new DateTime(2023, 3, 12, 19, 14, 20, 772, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 22, 14, 20, 772, DateTimeKind.Unspecified) },
                    { 60, 7, new DateTime(2023, 3, 16, 20, 43, 2, 334, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 1, 43, 2, 334, DateTimeKind.Unspecified) },
                    { 61, 3, new DateTime(2023, 4, 15, 21, 34, 42, 513, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 4, 34, 42, 513, DateTimeKind.Unspecified) },
                    { 62, 5, new DateTime(2023, 3, 19, 7, 43, 42, 404, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 14, 43, 42, 404, DateTimeKind.Unspecified) },
                    { 63, 6, new DateTime(2023, 2, 19, 5, 57, 17, 147, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 13, 57, 17, 147, DateTimeKind.Unspecified) }
========
                    { 22, 8, new DateTime(2023, 3, 28, 14, 10, 14, 16, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 17, 10, 14, 16, DateTimeKind.Unspecified) },
                    { 23, 6, new DateTime(2023, 5, 27, 11, 28, 27, 90, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 19, 28, 27, 90, DateTimeKind.Unspecified) },
                    { 24, 8, new DateTime(2023, 3, 30, 1, 47, 59, 330, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 11, 47, 59, 330, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2023, 5, 19, 18, 1, 28, 634, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 2, 1, 28, 634, DateTimeKind.Unspecified) },
                    { 26, 4, new DateTime(2023, 4, 15, 23, 3, 45, 900, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 4, 3, 45, 900, DateTimeKind.Unspecified) },
                    { 27, 3, new DateTime(2023, 5, 5, 21, 38, 0, 234, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 6, 38, 0, 234, DateTimeKind.Unspecified) },
                    { 28, 5, new DateTime(2023, 3, 22, 21, 16, 20, 266, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 7, 16, 20, 266, DateTimeKind.Unspecified) },
                    { 29, 7, new DateTime(2023, 2, 24, 8, 50, 24, 672, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 10, 50, 24, 672, DateTimeKind.Unspecified) },
                    { 30, 2, new DateTime(2023, 4, 10, 4, 9, 21, 562, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 5, 9, 21, 562, DateTimeKind.Unspecified) },
                    { 31, 5, new DateTime(2023, 4, 8, 14, 31, 44, 672, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 21, 31, 44, 672, DateTimeKind.Unspecified) },
                    { 32, 3, new DateTime(2023, 3, 8, 3, 42, 32, 813, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 7, 42, 32, 813, DateTimeKind.Unspecified) },
                    { 33, 9, new DateTime(2023, 5, 31, 17, 14, 53, 878, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 23, 14, 53, 878, DateTimeKind.Unspecified) },
                    { 34, 4, new DateTime(2023, 5, 7, 8, 21, 8, 336, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 18, 21, 8, 336, DateTimeKind.Unspecified) },
                    { 35, 6, new DateTime(2023, 2, 16, 2, 42, 22, 719, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 6, 42, 22, 719, DateTimeKind.Unspecified) },
                    { 36, 9, new DateTime(2023, 2, 2, 18, 22, 51, 8, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 21, 22, 51, 8, DateTimeKind.Unspecified) },
                    { 37, 2, new DateTime(2023, 2, 11, 9, 42, 36, 194, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 15, 42, 36, 194, DateTimeKind.Unspecified) },
                    { 38, 2, new DateTime(2023, 5, 2, 2, 47, 15, 632, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 5, 47, 15, 632, DateTimeKind.Unspecified) },
                    { 39, 1, new DateTime(2023, 3, 5, 14, 1, 39, 531, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 22, 1, 39, 531, DateTimeKind.Unspecified) },
                    { 40, 3, new DateTime(2023, 4, 18, 8, 19, 22, 850, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 12, 19, 22, 850, DateTimeKind.Unspecified) },
                    { 41, 3, new DateTime(2023, 3, 10, 22, 54, 31, 866, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 7, 54, 31, 866, DateTimeKind.Unspecified) },
                    { 42, 2, new DateTime(2023, 5, 13, 18, 7, 15, 575, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 0, 7, 15, 575, DateTimeKind.Unspecified) },
                    { 43, 7, new DateTime(2023, 3, 2, 17, 50, 42, 885, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 22, 50, 42, 885, DateTimeKind.Unspecified) },
                    { 44, 1, new DateTime(2023, 2, 12, 16, 15, 29, 888, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 1, 15, 29, 888, DateTimeKind.Unspecified) },
                    { 45, 3, new DateTime(2023, 5, 18, 14, 43, 47, 816, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 17, 43, 47, 816, DateTimeKind.Unspecified) },
                    { 46, 7, new DateTime(2023, 4, 19, 8, 46, 6, 873, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 17, 46, 6, 873, DateTimeKind.Unspecified) },
                    { 47, 9, new DateTime(2023, 5, 15, 14, 3, 12, 95, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 15, 3, 12, 95, DateTimeKind.Unspecified) },
                    { 48, 6, new DateTime(2023, 4, 16, 21, 53, 3, 443, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 1, 53, 3, 443, DateTimeKind.Unspecified) },
                    { 49, 5, new DateTime(2023, 4, 22, 6, 53, 36, 471, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 16, 53, 36, 471, DateTimeKind.Unspecified) },
                    { 50, 6, new DateTime(2023, 4, 12, 7, 48, 34, 629, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 10, 48, 34, 629, DateTimeKind.Unspecified) },
                    { 51, 4, new DateTime(2023, 3, 25, 8, 30, 46, 701, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 15, 30, 46, 701, DateTimeKind.Unspecified) },
                    { 52, 9, new DateTime(2023, 3, 26, 13, 53, 10, 739, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 15, 53, 10, 739, DateTimeKind.Unspecified) },
                    { 53, 3, new DateTime(2023, 2, 27, 20, 7, 30, 232, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 0, 7, 30, 232, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 2, 23, 22, 15, 19, 809, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 0, 15, 19, 809, DateTimeKind.Unspecified) },
                    { 55, 7, new DateTime(2023, 4, 2, 22, 33, 29, 985, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 0, 33, 29, 985, DateTimeKind.Unspecified) },
                    { 56, 5, new DateTime(2023, 3, 22, 4, 34, 51, 453, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 9, 34, 51, 453, DateTimeKind.Unspecified) },
                    { 57, 9, new DateTime(2023, 3, 9, 6, 7, 14, 402, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 10, 7, 14, 402, DateTimeKind.Unspecified) },
                    { 58, 2, new DateTime(2023, 5, 6, 11, 44, 47, 985, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 15, 44, 47, 985, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2023, 2, 15, 11, 52, 22, 408, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 21, 52, 22, 408, DateTimeKind.Unspecified) },
                    { 60, 5, new DateTime(2023, 4, 16, 22, 28, 47, 834, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 5, 28, 47, 834, DateTimeKind.Unspecified) },
                    { 61, 2, new DateTime(2023, 3, 14, 19, 31, 33, 179, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 5, 31, 33, 179, DateTimeKind.Unspecified) },
                    { 62, 4, new DateTime(2023, 4, 16, 21, 12, 25, 485, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 0, 12, 25, 485, DateTimeKind.Unspecified) },
                    { 63, 7, new DateTime(2023, 5, 19, 21, 51, 3, 251, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 2, 51, 3, 251, DateTimeKind.Unspecified) }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 64, 9, new DateTime(2023, 4, 22, 7, 18, 37, 191, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 15, 18, 37, 191, DateTimeKind.Unspecified) },
                    { 65, 3, new DateTime(2023, 3, 28, 16, 17, 0, 648, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 0, 17, 0, 648, DateTimeKind.Unspecified) },
                    { 66, 7, new DateTime(2023, 2, 20, 18, 26, 14, 428, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 1, 26, 14, 428, DateTimeKind.Unspecified) },
                    { 67, 2, new DateTime(2023, 4, 24, 4, 46, 56, 935, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 9, 46, 56, 935, DateTimeKind.Unspecified) },
                    { 68, 4, new DateTime(2023, 2, 3, 23, 7, 44, 951, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 0, 7, 44, 951, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 5, 25, 15, 34, 42, 541, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 22, 34, 42, 541, DateTimeKind.Unspecified) },
                    { 70, 4, new DateTime(2023, 4, 9, 11, 54, 34, 984, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 15, 54, 34, 984, DateTimeKind.Unspecified) },
                    { 71, 7, new DateTime(2023, 5, 22, 22, 44, 4, 525, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 23, 44, 4, 525, DateTimeKind.Unspecified) },
                    { 72, 7, new DateTime(2023, 4, 27, 23, 49, 2, 242, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 8, 49, 2, 242, DateTimeKind.Unspecified) },
                    { 73, 8, new DateTime(2023, 2, 1, 1, 38, 15, 300, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 8, 38, 15, 300, DateTimeKind.Unspecified) },
                    { 74, 9, new DateTime(2023, 3, 9, 12, 59, 40, 361, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 18, 59, 40, 361, DateTimeKind.Unspecified) },
                    { 75, 9, new DateTime(2023, 5, 6, 17, 6, 53, 637, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 2, 6, 53, 637, DateTimeKind.Unspecified) },
                    { 76, 2, new DateTime(2023, 2, 20, 5, 14, 12, 764, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 9, 14, 12, 764, DateTimeKind.Unspecified) },
                    { 77, 3, new DateTime(2023, 5, 6, 10, 38, 52, 372, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 13, 38, 52, 372, DateTimeKind.Unspecified) },
                    { 78, 9, new DateTime(2023, 2, 19, 5, 36, 52, 454, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 14, 36, 52, 454, DateTimeKind.Unspecified) },
                    { 79, 6, new DateTime(2023, 2, 1, 3, 25, 45, 379, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 11, 25, 45, 379, DateTimeKind.Unspecified) },
                    { 80, 9, new DateTime(2023, 5, 8, 1, 45, 51, 352, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 2, 45, 51, 352, DateTimeKind.Unspecified) },
                    { 81, 8, new DateTime(2023, 5, 6, 7, 21, 47, 666, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 15, 21, 47, 666, DateTimeKind.Unspecified) },
                    { 82, 2, new DateTime(2023, 4, 15, 19, 47, 17, 328, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 20, 47, 17, 328, DateTimeKind.Unspecified) },
                    { 83, 4, new DateTime(2023, 2, 15, 9, 4, 4, 106, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 13, 4, 4, 106, DateTimeKind.Unspecified) },
                    { 84, 1, new DateTime(2023, 4, 12, 19, 51, 36, 844, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 20, 51, 36, 844, DateTimeKind.Unspecified) },
                    { 85, 2, new DateTime(2023, 3, 24, 5, 27, 34, 4, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 6, 27, 34, 4, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2023, 2, 6, 22, 44, 37, 826, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 6, 44, 37, 826, DateTimeKind.Unspecified) },
                    { 87, 7, new DateTime(2023, 2, 22, 2, 11, 59, 438, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 4, 11, 59, 438, DateTimeKind.Unspecified) },
                    { 88, 6, new DateTime(2023, 3, 21, 21, 59, 45, 198, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 6, 59, 45, 198, DateTimeKind.Unspecified) },
                    { 89, 8, new DateTime(2023, 2, 22, 22, 24, 55, 50, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 1, 24, 55, 50, DateTimeKind.Unspecified) },
                    { 90, 3, new DateTime(2023, 2, 27, 18, 58, 49, 835, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 19, 58, 49, 835, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 4, 5, 18, 46, 46, 415, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 2, 46, 46, 415, DateTimeKind.Unspecified) },
                    { 92, 5, new DateTime(2023, 3, 6, 10, 44, 8, 817, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 20, 44, 8, 817, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 4, 19, 20, 2, 21, 782, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 3, 2, 21, 782, DateTimeKind.Unspecified) },
                    { 94, 8, new DateTime(2023, 4, 14, 20, 3, 39, 736, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 6, 3, 39, 736, DateTimeKind.Unspecified) },
                    { 95, 7, new DateTime(2023, 4, 10, 23, 31, 46, 181, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 4, 31, 46, 181, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 4, 10, 19, 57, 24, 905, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 3, 57, 24, 905, DateTimeKind.Unspecified) },
                    { 97, 2, new DateTime(2023, 3, 19, 18, 59, 30, 146, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 19, 59, 30, 146, DateTimeKind.Unspecified) },
                    { 98, 2, new DateTime(2023, 4, 10, 12, 41, 52, 161, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 13, 41, 52, 161, DateTimeKind.Unspecified) },
                    { 99, 7, new DateTime(2023, 2, 2, 20, 40, 20, 896, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 2, 40, 20, 896, DateTimeKind.Unspecified) },
                    { 100, 3, new DateTime(2023, 3, 21, 0, 56, 13, 905, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 4, 56, 13, 905, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 5, 16, 19, 50, 18, 726, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 21, 50, 18, 726, DateTimeKind.Unspecified) }
========
                    { 64, 1, new DateTime(2023, 5, 11, 9, 39, 13, 174, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 18, 39, 13, 174, DateTimeKind.Unspecified) },
                    { 65, 5, new DateTime(2023, 2, 21, 22, 16, 42, 446, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 2, 16, 42, 446, DateTimeKind.Unspecified) },
                    { 66, 8, new DateTime(2023, 5, 10, 2, 27, 5, 578, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 9, 27, 5, 578, DateTimeKind.Unspecified) },
                    { 67, 4, new DateTime(2023, 2, 13, 9, 34, 48, 100, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 34, 48, 100, DateTimeKind.Unspecified) },
                    { 68, 5, new DateTime(2023, 4, 1, 7, 42, 8, 578, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 9, 42, 8, 578, DateTimeKind.Unspecified) },
                    { 69, 8, new DateTime(2023, 2, 16, 21, 26, 22, 669, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 6, 26, 22, 669, DateTimeKind.Unspecified) },
                    { 70, 2, new DateTime(2023, 4, 14, 5, 48, 47, 549, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 6, 48, 47, 549, DateTimeKind.Unspecified) },
                    { 71, 8, new DateTime(2023, 4, 21, 21, 51, 52, 433, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 7, 51, 52, 433, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 2, 3, 3, 31, 54, 932, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 12, 31, 54, 932, DateTimeKind.Unspecified) },
                    { 73, 9, new DateTime(2023, 2, 17, 1, 42, 46, 925, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 9, 42, 46, 925, DateTimeKind.Unspecified) },
                    { 74, 2, new DateTime(2023, 3, 23, 5, 45, 32, 100, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 15, 45, 32, 100, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 4, 6, 16, 28, 36, 439, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 23, 28, 36, 439, DateTimeKind.Unspecified) },
                    { 76, 4, new DateTime(2023, 5, 5, 12, 18, 43, 961, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 13, 18, 43, 961, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 3, 27, 21, 58, 54, 166, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 2, 58, 54, 166, DateTimeKind.Unspecified) },
                    { 78, 5, new DateTime(2023, 2, 12, 13, 3, 20, 919, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 18, 3, 20, 919, DateTimeKind.Unspecified) },
                    { 79, 2, new DateTime(2023, 3, 20, 23, 37, 24, 128, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 9, 37, 24, 128, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2023, 3, 2, 0, 16, 19, 489, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 9, 16, 19, 489, DateTimeKind.Unspecified) },
                    { 81, 3, new DateTime(2023, 4, 19, 6, 30, 52, 141, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 8, 30, 52, 141, DateTimeKind.Unspecified) },
                    { 82, 3, new DateTime(2023, 2, 26, 19, 36, 51, 231, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 5, 36, 51, 231, DateTimeKind.Unspecified) },
                    { 83, 6, new DateTime(2023, 3, 22, 10, 46, 50, 953, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 13, 46, 50, 953, DateTimeKind.Unspecified) },
                    { 84, 8, new DateTime(2023, 2, 25, 1, 4, 25, 493, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 10, 4, 25, 493, DateTimeKind.Unspecified) },
                    { 85, 8, new DateTime(2023, 3, 30, 18, 49, 23, 233, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 4, 49, 23, 233, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2023, 5, 22, 4, 47, 58, 353, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 6, 47, 58, 353, DateTimeKind.Unspecified) },
                    { 87, 7, new DateTime(2023, 4, 25, 18, 18, 54, 594, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 19, 18, 54, 594, DateTimeKind.Unspecified) },
                    { 88, 4, new DateTime(2023, 2, 5, 11, 18, 49, 983, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 20, 18, 49, 983, DateTimeKind.Unspecified) },
                    { 89, 9, new DateTime(2023, 4, 21, 7, 12, 53, 938, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 16, 12, 53, 938, DateTimeKind.Unspecified) },
                    { 90, 4, new DateTime(2023, 2, 12, 21, 42, 59, 291, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 22, 42, 59, 291, DateTimeKind.Unspecified) },
                    { 91, 9, new DateTime(2023, 2, 3, 1, 10, 5, 334, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 9, 10, 5, 334, DateTimeKind.Unspecified) },
                    { 92, 3, new DateTime(2023, 4, 14, 20, 12, 26, 70, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 1, 12, 26, 70, DateTimeKind.Unspecified) },
                    { 93, 1, new DateTime(2023, 5, 15, 22, 49, 23, 53, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 4, 49, 23, 53, DateTimeKind.Unspecified) },
                    { 94, 9, new DateTime(2023, 3, 15, 4, 12, 58, 733, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 7, 12, 58, 733, DateTimeKind.Unspecified) },
                    { 95, 2, new DateTime(2023, 5, 15, 13, 59, 17, 179, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 17, 59, 17, 179, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 4, 30, 23, 49, 23, 563, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 5, 49, 23, 563, DateTimeKind.Unspecified) },
                    { 97, 7, new DateTime(2023, 2, 9, 16, 59, 9, 577, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 22, 59, 9, 577, DateTimeKind.Unspecified) },
                    { 98, 3, new DateTime(2023, 4, 10, 11, 8, 17, 214, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 15, 8, 17, 214, DateTimeKind.Unspecified) },
                    { 99, 6, new DateTime(2023, 5, 27, 4, 44, 37, 987, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 8, 44, 37, 987, DateTimeKind.Unspecified) },
                    { 100, 2, new DateTime(2023, 4, 18, 1, 36, 22, 443, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 9, 36, 22, 443, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 2, 28, 7, 59, 18, 772, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 14, 59, 18, 772, DateTimeKind.Unspecified) }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 1, 1, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8995), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(8996), 1198m },
                    { 3, 2, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9671), 699m },
                    { 4, 2, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9689), 699m }
========
                    { 1, 1, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7762), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(7763), 1198m },
                    { 3, 9, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8374), 699m },
                    { 4, 5, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8391), 699m }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
<<<<<<<< HEAD:final_repo_test/final_repo_test/Migrations/20230518022526_m1.cs
                    { 5, 8, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9697), 699m },
                    { 6, 6, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9706), 699m },
                    { 7, 8, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9714), 699m },
                    { 8, 7, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9729), 699m },
                    { 9, 1, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9736), 699m },
                    { 10, 3, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9745), 699m },
                    { 11, 3, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9752), 699m },
                    { 12, 4, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9766), 699m },
                    { 13, 1, false, new DateTime(2023, 5, 18, 10, 25, 26, 552, DateTimeKind.Local).AddTicks(9773), 699m }
========
                    { 5, 8, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8405), 699m },
                    { 6, 4, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8422), 699m },
                    { 7, 3, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8435), 699m },
                    { 8, 8, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8449), 699m },
                    { 9, 4, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8462), 699m },
                    { 10, 2, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8481), 699m },
                    { 11, 7, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8494), 699m },
                    { 12, 7, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8506), 699m },
                    { 13, 1, false, new DateTime(2023, 5, 18, 23, 45, 59, 431, DateTimeKind.Local).AddTicks(8518), 699m }
>>>>>>>> main:final_repo_test/final_repo_test/Migrations/20230518154559_m1.cs
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
