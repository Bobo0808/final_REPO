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
                    { 1, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3542), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3544), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "okqabl8kay@gmail.com", 1, new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0919016736", "okqabl8kay", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "g75zaxd5@gmail.com", 0, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0915214612", "g75zaxd5", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "946m8k97m@gmail.com", 1, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 1, "0912565094", "946m8k97m", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "vmao7bh@gmail.com", 0, new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0918498488", "vmao7bh", 1, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "4zsqvkwt@gmail.com", 0, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 2, "0912224861", "4zsqvkwt", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "wv6572de@gmail.com", 1, new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0910882257", "wv6572de", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "yeny2jg@gmail.com", 1, new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0912516678", "yeny2jg", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0upfadc4ft@gmail.com", 0, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 2, "0913655120", "0upfadc4ft", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3561), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3564), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "UserName", "UserPWD" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3376), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3367), 1, "Test", "Test" },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3403), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3402), 1, "Test", "Test" },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3414), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3413), 1, "Test", "Test" },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3423), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3422), 1, "Test", "Test" },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3432), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3431), 1, "Test", "Test" },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3444), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3443), 1, "Test", "Test" },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3453), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3452), 1, "Test", "Test" },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3462), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3461), 1, "Test", "Test" },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3471), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3470), 1, "Test", "Test" },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3480), "Test", 99, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3480), 1, "Test", "Test" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 149, 20, "", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5 },
                    { 2, 15000, 1, 197, 17, "", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 3, 15000, 1, 152, 19, "", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 4, 15000, 1, 150, 12, "", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 5, 15000, 1, 226, 10, "", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 6, 15000, 1, 222, 16, "", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 7, 15000, 1, 65, 13, "", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 8, 15000, 1, 109, 14, "", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 9, 15000, 1, 46, 19, "", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 17 },
                    { 10, 15000, 1, 30, 13, "", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 11, 15000, 1, 216, 12, "", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 12, 15000, 1, 72, 14, "", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 13, 15000, 1, 58, 9, "", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 19 },
                    { 14, 15000, 1, 106, 22, "", new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 15, 15000, 1, 61, 8, "", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 16, 15000, 1, 122, 9, "", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 17, 15000, 1, 186, 18, "", new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 7 },
                    { 18, 15000, 1, 225, 23, "", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 19, 15000, 1, 50, 17, "", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 20, 15000, 1, 157, 16, "", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 21, 15000, 1, 106, 11, "", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 22, 15000, 1, 79, 8, "", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 23, 15000, 1, 216, 10, "", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 24, 15000, 1, 182, 9, "", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 25, 15000, 1, 192, 19, "", new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 26, 15000, 1, 215, 24, "", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 27, 15000, 1, 239, 12, "", new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 },
                    { 28, 15000, 1, 123, 15, "", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 29, 15000, 1, 69, 13, "", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3518), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3520), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 9, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2211) },
                    { 2, 2, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2295) },
                    { 3, 9, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2298) },
                    { 4, 5, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2300) },
                    { 5, 9, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2303) },
                    { 6, 5, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2307) },
                    { 7, 2, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2310) },
                    { 8, 6, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2312) },
                    { 9, 3, null, "test", true, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2314) },
                    { 10, 7, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2318) },
                    { 11, 3, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2322) },
                    { 12, 4, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2324) },
                    { 13, 3, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2326) },
                    { 14, 10, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2328) },
                    { 15, 3, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2331) },
                    { 16, 4, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2333) },
                    { 17, 6, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2335) },
                    { 18, 3, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2339) },
                    { 19, 4, null, "test", false, new DateTime(2023, 5, 15, 19, 54, 14, 518, DateTimeKind.Local).AddTicks(2341) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 5, 26, 2, 9, 43, 956, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 9, 9, 43, 956, DateTimeKind.Unspecified) },
                    { 2, 9, new DateTime(2023, 3, 7, 5, 6, 30, 818, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 7, 6, 30, 818, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2023, 3, 24, 1, 2, 58, 329, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 9, 2, 58, 329, DateTimeKind.Unspecified) },
                    { 4, 9, new DateTime(2023, 5, 1, 12, 10, 26, 304, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 21, 10, 26, 304, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(2023, 4, 2, 2, 18, 23, 200, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 5, 18, 23, 200, DateTimeKind.Unspecified) },
                    { 6, 9, new DateTime(2023, 4, 5, 10, 41, 55, 870, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 15, 41, 55, 870, DateTimeKind.Unspecified) },
                    { 7, 5, new DateTime(2023, 4, 29, 20, 45, 45, 27, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 3, 45, 45, 27, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 3, 9, 18, 54, 6, 642, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 23, 54, 6, 642, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2023, 4, 6, 8, 50, 44, 720, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 16, 50, 44, 720, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(2023, 2, 8, 2, 40, 14, 990, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 7, 40, 14, 990, DateTimeKind.Unspecified) },
                    { 11, 5, new DateTime(2023, 3, 24, 6, 3, 51, 758, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 16, 3, 51, 758, DateTimeKind.Unspecified) },
                    { 12, 7, new DateTime(2023, 2, 21, 1, 47, 3, 521, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 5, 47, 3, 521, DateTimeKind.Unspecified) },
                    { 13, 5, new DateTime(2023, 3, 22, 5, 7, 24, 29, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 9, 7, 24, 29, DateTimeKind.Unspecified) },
                    { 14, 7, new DateTime(2023, 4, 21, 0, 46, 23, 628, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 3, 46, 23, 628, DateTimeKind.Unspecified) },
                    { 15, 7, new DateTime(2023, 5, 16, 8, 36, 18, 788, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 10, 36, 18, 788, DateTimeKind.Unspecified) },
                    { 16, 7, new DateTime(2023, 3, 9, 5, 34, 56, 850, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 7, 34, 56, 850, DateTimeKind.Unspecified) },
                    { 17, 4, new DateTime(2023, 4, 7, 8, 15, 34, 466, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 18, 15, 34, 466, DateTimeKind.Unspecified) },
                    { 18, 9, new DateTime(2023, 5, 14, 8, 25, 3, 795, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 17, 25, 3, 795, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2023, 5, 25, 8, 25, 23, 256, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 18, 25, 23, 256, DateTimeKind.Unspecified) },
                    { 20, 8, new DateTime(2023, 2, 28, 17, 10, 2, 271, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 18, 10, 2, 271, DateTimeKind.Unspecified) },
                    { 21, 5, new DateTime(2023, 3, 19, 21, 52, 12, 337, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 5, 52, 12, 337, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 9, new DateTime(2023, 4, 2, 4, 25, 41, 89, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 13, 25, 41, 89, DateTimeKind.Unspecified) },
                    { 23, 4, new DateTime(2023, 3, 9, 20, 6, 12, 582, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 23, 6, 12, 582, DateTimeKind.Unspecified) },
                    { 24, 7, new DateTime(2023, 4, 24, 9, 5, 35, 25, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 16, 5, 35, 25, DateTimeKind.Unspecified) },
                    { 25, 5, new DateTime(2023, 5, 2, 13, 1, 54, 613, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 18, 1, 54, 613, DateTimeKind.Unspecified) },
                    { 26, 9, new DateTime(2023, 5, 23, 7, 38, 13, 231, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 12, 38, 13, 231, DateTimeKind.Unspecified) },
                    { 27, 4, new DateTime(2023, 2, 5, 9, 19, 31, 955, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 19, 19, 31, 955, DateTimeKind.Unspecified) },
                    { 28, 8, new DateTime(2023, 3, 17, 11, 10, 39, 57, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 21, 10, 39, 57, DateTimeKind.Unspecified) },
                    { 29, 6, new DateTime(2023, 4, 12, 8, 13, 33, 788, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 13, 13, 33, 788, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2023, 4, 27, 13, 9, 8, 190, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 19, 9, 8, 190, DateTimeKind.Unspecified) },
                    { 31, 6, new DateTime(2023, 5, 21, 12, 37, 40, 910, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 15, 37, 40, 910, DateTimeKind.Unspecified) },
                    { 32, 5, new DateTime(2023, 3, 23, 1, 15, 48, 254, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 4, 15, 48, 254, DateTimeKind.Unspecified) },
                    { 33, 4, new DateTime(2023, 3, 30, 14, 36, 40, 82, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 21, 36, 40, 82, DateTimeKind.Unspecified) },
                    { 34, 6, new DateTime(2023, 3, 5, 9, 16, 55, 87, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 19, 16, 55, 87, DateTimeKind.Unspecified) },
                    { 35, 9, new DateTime(2023, 3, 4, 17, 27, 36, 323, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 19, 27, 36, 323, DateTimeKind.Unspecified) },
                    { 36, 2, new DateTime(2023, 3, 13, 1, 18, 42, 939, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 10, 18, 42, 939, DateTimeKind.Unspecified) },
                    { 37, 8, new DateTime(2023, 5, 9, 23, 25, 12, 976, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 2, 25, 12, 976, DateTimeKind.Unspecified) },
                    { 38, 9, new DateTime(2023, 3, 7, 19, 58, 40, 837, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 21, 58, 40, 837, DateTimeKind.Unspecified) },
                    { 39, 4, new DateTime(2023, 3, 29, 8, 16, 42, 504, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 18, 16, 42, 504, DateTimeKind.Unspecified) },
                    { 40, 5, new DateTime(2023, 2, 4, 10, 27, 5, 52, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 18, 27, 5, 52, DateTimeKind.Unspecified) },
                    { 41, 3, new DateTime(2023, 3, 26, 21, 44, 39, 400, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 2, 44, 39, 400, DateTimeKind.Unspecified) },
                    { 42, 8, new DateTime(2023, 5, 16, 17, 14, 21, 507, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 2, 14, 21, 507, DateTimeKind.Unspecified) },
                    { 43, 7, new DateTime(2023, 3, 20, 13, 28, 3, 273, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 21, 28, 3, 273, DateTimeKind.Unspecified) },
                    { 44, 2, new DateTime(2023, 4, 1, 2, 45, 29, 966, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 9, 45, 29, 966, DateTimeKind.Unspecified) },
                    { 45, 5, new DateTime(2023, 2, 16, 6, 57, 2, 287, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 11, 57, 2, 287, DateTimeKind.Unspecified) },
                    { 46, 2, new DateTime(2023, 4, 24, 17, 55, 35, 208, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 20, 55, 35, 208, DateTimeKind.Unspecified) },
                    { 47, 3, new DateTime(2023, 2, 24, 18, 38, 3, 870, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 0, 38, 3, 870, DateTimeKind.Unspecified) },
                    { 48, 2, new DateTime(2023, 5, 5, 0, 46, 6, 734, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 7, 46, 6, 734, DateTimeKind.Unspecified) },
                    { 49, 8, new DateTime(2023, 4, 10, 13, 16, 57, 604, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 15, 16, 57, 604, DateTimeKind.Unspecified) },
                    { 50, 8, new DateTime(2023, 3, 23, 10, 53, 38, 284, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 20, 53, 38, 284, DateTimeKind.Unspecified) },
                    { 51, 9, new DateTime(2023, 4, 16, 11, 24, 38, 457, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 18, 24, 38, 457, DateTimeKind.Unspecified) },
                    { 52, 8, new DateTime(2023, 3, 24, 16, 0, 47, 897, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 21, 0, 47, 897, DateTimeKind.Unspecified) },
                    { 53, 8, new DateTime(2023, 4, 27, 21, 9, 47, 896, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 7, 9, 47, 896, DateTimeKind.Unspecified) },
                    { 54, 9, new DateTime(2023, 5, 31, 12, 43, 53, 144, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 18, 43, 53, 144, DateTimeKind.Unspecified) },
                    { 55, 3, new DateTime(2023, 5, 8, 15, 7, 21, 313, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 20, 7, 21, 313, DateTimeKind.Unspecified) },
                    { 56, 4, new DateTime(2023, 3, 11, 22, 32, 1, 176, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 2, 32, 1, 176, DateTimeKind.Unspecified) },
                    { 57, 6, new DateTime(2023, 5, 14, 17, 36, 32, 686, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 3, 36, 32, 686, DateTimeKind.Unspecified) },
                    { 58, 7, new DateTime(2023, 5, 22, 20, 31, 3, 264, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 21, 31, 3, 264, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 2, 11, 12, 34, 51, 352, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 18, 34, 51, 352, DateTimeKind.Unspecified) },
                    { 60, 1, new DateTime(2023, 5, 13, 23, 20, 20, 530, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 0, 20, 20, 530, DateTimeKind.Unspecified) },
                    { 61, 6, new DateTime(2023, 3, 8, 17, 58, 31, 408, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 23, 58, 31, 408, DateTimeKind.Unspecified) },
                    { 62, 9, new DateTime(2023, 4, 24, 6, 39, 49, 1, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 8, 39, 49, 1, DateTimeKind.Unspecified) },
                    { 63, 1, new DateTime(2023, 4, 10, 13, 22, 5, 986, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 20, 22, 5, 986, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 2, new DateTime(2023, 4, 14, 8, 20, 28, 994, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 11, 20, 28, 994, DateTimeKind.Unspecified) },
                    { 65, 6, new DateTime(2023, 4, 9, 20, 6, 54, 353, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 6, 6, 54, 353, DateTimeKind.Unspecified) },
                    { 66, 5, new DateTime(2023, 3, 9, 14, 58, 22, 214, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 19, 58, 22, 214, DateTimeKind.Unspecified) },
                    { 67, 8, new DateTime(2023, 4, 3, 3, 43, 55, 855, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 13, 43, 55, 855, DateTimeKind.Unspecified) },
                    { 68, 3, new DateTime(2023, 3, 6, 7, 16, 28, 541, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 12, 16, 28, 541, DateTimeKind.Unspecified) },
                    { 69, 3, new DateTime(2023, 2, 13, 9, 13, 46, 113, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 16, 13, 46, 113, DateTimeKind.Unspecified) },
                    { 70, 3, new DateTime(2023, 5, 23, 1, 7, 46, 975, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 8, 7, 46, 975, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 4, 24, 8, 0, 14, 930, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 10, 0, 14, 930, DateTimeKind.Unspecified) },
                    { 72, 4, new DateTime(2023, 3, 3, 18, 3, 44, 911, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 23, 3, 44, 911, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 3, 9, 6, 2, 29, 228, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 16, 2, 29, 228, DateTimeKind.Unspecified) },
                    { 74, 4, new DateTime(2023, 5, 10, 9, 21, 2, 810, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 15, 21, 2, 810, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 4, 3, 4, 27, 55, 604, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 13, 27, 55, 604, DateTimeKind.Unspecified) },
                    { 76, 9, new DateTime(2023, 4, 28, 23, 9, 46, 330, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 8, 9, 46, 330, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 5, 19, 6, 7, 33, 345, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 10, 7, 33, 345, DateTimeKind.Unspecified) },
                    { 78, 2, new DateTime(2023, 3, 3, 1, 58, 42, 152, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 10, 58, 42, 152, DateTimeKind.Unspecified) },
                    { 79, 6, new DateTime(2023, 5, 28, 8, 40, 42, 674, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 17, 40, 42, 674, DateTimeKind.Unspecified) },
                    { 80, 4, new DateTime(2023, 3, 26, 12, 4, 24, 169, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 17, 4, 24, 169, DateTimeKind.Unspecified) },
                    { 81, 7, new DateTime(2023, 3, 13, 12, 51, 48, 620, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 22, 51, 48, 620, DateTimeKind.Unspecified) },
                    { 82, 9, new DateTime(2023, 4, 19, 4, 48, 56, 927, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 6, 48, 56, 927, DateTimeKind.Unspecified) },
                    { 83, 4, new DateTime(2023, 2, 7, 21, 36, 29, 686, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 1, 36, 29, 686, DateTimeKind.Unspecified) },
                    { 84, 2, new DateTime(2023, 3, 10, 15, 52, 33, 302, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 0, 52, 33, 302, DateTimeKind.Unspecified) },
                    { 85, 9, new DateTime(2023, 5, 30, 2, 43, 57, 777, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 3, 43, 57, 777, DateTimeKind.Unspecified) },
                    { 86, 2, new DateTime(2023, 5, 16, 21, 36, 6, 302, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 1, 36, 6, 302, DateTimeKind.Unspecified) },
                    { 87, 2, new DateTime(2023, 2, 23, 21, 51, 30, 446, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 1, 51, 30, 446, DateTimeKind.Unspecified) },
                    { 88, 5, new DateTime(2023, 2, 19, 1, 53, 39, 128, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 3, 53, 39, 128, DateTimeKind.Unspecified) },
                    { 89, 4, new DateTime(2023, 5, 11, 6, 6, 41, 416, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 12, 6, 41, 416, DateTimeKind.Unspecified) },
                    { 90, 2, new DateTime(2023, 4, 23, 4, 20, 40, 197, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 5, 20, 40, 197, DateTimeKind.Unspecified) },
                    { 91, 2, new DateTime(2023, 4, 29, 10, 39, 35, 568, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 19, 39, 35, 568, DateTimeKind.Unspecified) },
                    { 92, 2, new DateTime(2023, 2, 26, 19, 44, 7, 950, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 23, 44, 7, 950, DateTimeKind.Unspecified) },
                    { 93, 6, new DateTime(2023, 5, 1, 2, 28, 24, 981, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 8, 28, 24, 981, DateTimeKind.Unspecified) },
                    { 94, 1, new DateTime(2023, 3, 24, 23, 51, 45, 629, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 9, 51, 45, 629, DateTimeKind.Unspecified) },
                    { 95, 1, new DateTime(2023, 4, 7, 17, 42, 57, 860, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 20, 42, 57, 860, DateTimeKind.Unspecified) },
                    { 96, 2, new DateTime(2023, 2, 25, 14, 14, 11, 344, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 17, 14, 11, 344, DateTimeKind.Unspecified) },
                    { 97, 9, new DateTime(2023, 5, 3, 13, 28, 4, 83, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 21, 28, 4, 83, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2023, 3, 11, 3, 11, 38, 216, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 8, 11, 38, 216, DateTimeKind.Unspecified) },
                    { 99, 4, new DateTime(2023, 3, 6, 1, 15, 28, 162, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 7, 15, 28, 162, DateTimeKind.Unspecified) },
                    { 100, 6, new DateTime(2023, 2, 6, 13, 38, 42, 521, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 16, 38, 42, 521, DateTimeKind.Unspecified) },
                    { 101, 8, new DateTime(2023, 4, 7, 3, 38, 47, 241, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 9, 38, 47, 241, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3581), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(3583), 1198m },
                    { 3, 7, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4639), 699m },
                    { 4, 4, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4706), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 8, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4740), 699m },
                    { 6, 8, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4874), 699m },
                    { 7, 6, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4894), 699m },
                    { 8, 7, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4917), 699m },
                    { 9, 3, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4936), 699m },
                    { 10, 4, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4956), 699m },
                    { 11, 6, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4974), 699m },
                    { 12, 2, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(4994), 699m },
                    { 13, 4, false, new DateTime(2023, 5, 15, 19, 54, 14, 520, DateTimeKind.Local).AddTicks(5065), 699m }
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
