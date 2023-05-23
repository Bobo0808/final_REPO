using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class _20230523bnn : Migration
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
                    { 1, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5359), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5360), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "iuu0ui@gmail.com", 0, new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0912671222", "iuu0ui", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "uusx4m@gmail.com", 0, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0915408008", "uusx4m", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "1hgh1emg@gmail.com", 1, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0915625813", "1hgh1emg", 0, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "j9q8fuv66bz@gmail.com", 0, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 2, "0919403178", "j9q8fuv66bz", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "obsbvt@gmail.com", 1, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 2, "0911722577", "obsbvt", 1, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "59yp5mfn@gmail.com", 0, new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0919010568", "59yp5mfn", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hqna8jof7j0@gmail.com", 0, new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 1, "0911370892", "hqna8jof7j0", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "nvj8kf@gmail.com", 0, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 2, "0915237944", "nvj8kf", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5374), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 0 },
                    { 2, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5375), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5202), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5199), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5217), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5216), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5227), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5226), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5236), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5236), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5246), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5246), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5258), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5257), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5267), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5267), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5277), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5277), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5287), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5286), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5322), "Test", 99, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5321), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 189, 8, "", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 13 },
                    { 2, 15000, 1, 33, 11, "", new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 3, 15000, 1, 70, 13, "", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 12 },
                    { 4, 15000, 1, 191, 8, "", new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 5, 15000, 1, 120, 14, "", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 6, 15000, 1, 78, 23, "", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 7, 15000, 1, 102, 13, "", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 8, 15000, 1, 210, 18, "", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 4 },
                    { 9, 15000, 1, 220, 22, "", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 10, 15000, 1, 215, 22, "", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 11, 15000, 1, 170, 13, "", new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 12, 15000, 1, 105, 17, "", new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 13, 15000, 1, 113, 24, "", new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 12 },
                    { 14, 15000, 1, 58, 16, "", new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 15, 15000, 1, 51, 14, "", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 16, 15000, 1, 99, 14, "", new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 },
                    { 17, 15000, 1, 106, 14, "", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 18, 15000, 1, 49, 24, "", new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 19, 15000, 1, 34, 20, "", new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 20, 15000, 1, 238, 14, "", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 21, 15000, 1, 217, 9, "", new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 22, 15000, 1, 79, 14, "", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 23, 15000, 1, 198, 13, "", new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 24, 15000, 1, 89, 20, "", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 25, 15000, 1, 197, 15, "", new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 26, 15000, 1, 70, 24, "", new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 27, 15000, 1, 124, 20, "", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 28, 15000, 1, 188, 14, "", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 29, 15000, 1, 42, 24, "", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5345), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5346), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 4, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2451) },
                    { 2, 1, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2502) },
                    { 3, 9, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2505) },
                    { 4, 5, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2507) },
                    { 5, 4, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2509) },
                    { 6, 8, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2513) },
                    { 7, 1, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2515) },
                    { 8, 6, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2517) },
                    { 9, 3, null, "test", true, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2519) },
                    { 10, 9, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2522) },
                    { 11, 8, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2524) },
                    { 12, 6, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2526) },
                    { 13, 3, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2527) },
                    { 14, 1, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2529) },
                    { 15, 9, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2531) },
                    { 16, 10, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2533) },
                    { 17, 4, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2535) },
                    { 18, 6, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2538) },
                    { 19, 8, null, "test", false, new DateTime(2023, 5, 23, 23, 31, 33, 41, DateTimeKind.Local).AddTicks(2540) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 5, 20, 18, 59, 2, 815, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 0, 59, 2, 815, DateTimeKind.Unspecified) },
                    { 2, 7, new DateTime(2023, 2, 19, 17, 35, 38, 614, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 21, 35, 38, 614, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(2023, 3, 9, 12, 47, 18, 501, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 17, 47, 18, 501, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2023, 5, 27, 16, 51, 27, 248, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 23, 51, 27, 248, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2023, 2, 23, 10, 57, 51, 556, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 18, 57, 51, 556, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2023, 4, 17, 7, 41, 17, 116, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 8, 41, 17, 116, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2023, 5, 4, 7, 16, 22, 570, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 13, 16, 22, 570, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 3, 10, 5, 29, 54, 26, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 11, 29, 54, 26, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(2023, 5, 14, 9, 57, 25, 511, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 19, 57, 25, 511, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2023, 3, 9, 13, 33, 10, 378, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 21, 33, 10, 378, DateTimeKind.Unspecified) },
                    { 11, 8, new DateTime(2023, 4, 27, 9, 51, 53, 294, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 10, 51, 53, 294, DateTimeKind.Unspecified) },
                    { 12, 5, new DateTime(2023, 5, 5, 15, 17, 6, 763, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 0, 17, 6, 763, DateTimeKind.Unspecified) },
                    { 13, 6, new DateTime(2023, 4, 29, 16, 48, 44, 409, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 23, 48, 44, 409, DateTimeKind.Unspecified) },
                    { 14, 5, new DateTime(2023, 2, 22, 3, 49, 19, 141, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 12, 49, 19, 141, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 2, 1, 13, 6, 4, 399, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 21, 6, 4, 399, DateTimeKind.Unspecified) },
                    { 16, 7, new DateTime(2023, 3, 5, 3, 47, 3, 376, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 8, 47, 3, 376, DateTimeKind.Unspecified) },
                    { 17, 1, new DateTime(2023, 5, 29, 3, 0, 12, 248, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 11, 0, 12, 248, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2023, 3, 29, 20, 29, 44, 244, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 0, 29, 44, 244, DateTimeKind.Unspecified) },
                    { 19, 6, new DateTime(2023, 2, 16, 20, 18, 46, 954, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 0, 18, 46, 954, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 2, 10, 17, 45, 5, 820, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 1, 45, 5, 820, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2023, 3, 6, 19, 18, 6, 330, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 2, 18, 6, 330, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 6, new DateTime(2023, 5, 25, 9, 55, 40, 727, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 16, 55, 40, 727, DateTimeKind.Unspecified) },
                    { 23, 7, new DateTime(2023, 5, 15, 2, 11, 23, 872, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 11, 11, 23, 872, DateTimeKind.Unspecified) },
                    { 24, 3, new DateTime(2023, 4, 19, 20, 1, 10, 988, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 3, 1, 10, 988, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2023, 5, 24, 11, 32, 9, 115, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 18, 32, 9, 115, DateTimeKind.Unspecified) },
                    { 26, 8, new DateTime(2023, 2, 6, 15, 59, 8, 414, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 19, 59, 8, 414, DateTimeKind.Unspecified) },
                    { 27, 9, new DateTime(2023, 5, 10, 19, 56, 32, 229, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 2, 56, 32, 229, DateTimeKind.Unspecified) },
                    { 28, 6, new DateTime(2023, 2, 27, 15, 24, 38, 56, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 22, 24, 38, 56, DateTimeKind.Unspecified) },
                    { 29, 3, new DateTime(2023, 3, 13, 7, 0, 5, 762, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 14, 0, 5, 762, DateTimeKind.Unspecified) },
                    { 30, 7, new DateTime(2023, 5, 17, 11, 25, 7, 781, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 16, 25, 7, 781, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2023, 3, 1, 5, 13, 37, 559, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 6, 13, 37, 559, DateTimeKind.Unspecified) },
                    { 32, 5, new DateTime(2023, 5, 21, 13, 35, 23, 487, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 18, 35, 23, 487, DateTimeKind.Unspecified) },
                    { 33, 6, new DateTime(2023, 5, 27, 4, 1, 36, 878, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 6, 1, 36, 878, DateTimeKind.Unspecified) },
                    { 34, 7, new DateTime(2023, 4, 18, 19, 51, 42, 208, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 22, 51, 42, 208, DateTimeKind.Unspecified) },
                    { 35, 1, new DateTime(2023, 4, 8, 18, 45, 57, 18, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 23, 45, 57, 18, DateTimeKind.Unspecified) },
                    { 36, 8, new DateTime(2023, 2, 6, 3, 58, 54, 719, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 11, 58, 54, 719, DateTimeKind.Unspecified) },
                    { 37, 5, new DateTime(2023, 2, 9, 9, 20, 40, 496, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 14, 20, 40, 496, DateTimeKind.Unspecified) },
                    { 38, 8, new DateTime(2023, 5, 2, 23, 21, 51, 135, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 8, 21, 51, 135, DateTimeKind.Unspecified) },
                    { 39, 8, new DateTime(2023, 2, 6, 21, 10, 57, 198, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 2, 10, 57, 198, DateTimeKind.Unspecified) },
                    { 40, 6, new DateTime(2023, 5, 20, 16, 5, 3, 946, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 23, 5, 3, 946, DateTimeKind.Unspecified) },
                    { 41, 5, new DateTime(2023, 3, 12, 13, 16, 15, 499, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 16, 16, 15, 499, DateTimeKind.Unspecified) },
                    { 42, 5, new DateTime(2023, 2, 21, 7, 1, 8, 100, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 13, 1, 8, 100, DateTimeKind.Unspecified) },
                    { 43, 5, new DateTime(2023, 4, 29, 8, 11, 27, 207, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 15, 11, 27, 207, DateTimeKind.Unspecified) },
                    { 44, 2, new DateTime(2023, 5, 24, 0, 1, 44, 263, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 6, 1, 44, 263, DateTimeKind.Unspecified) },
                    { 45, 8, new DateTime(2023, 4, 29, 22, 23, 38, 751, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 7, 23, 38, 751, DateTimeKind.Unspecified) },
                    { 46, 4, new DateTime(2023, 4, 27, 11, 34, 32, 482, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 21, 34, 32, 482, DateTimeKind.Unspecified) },
                    { 47, 7, new DateTime(2023, 4, 2, 21, 22, 43, 651, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 5, 22, 43, 651, DateTimeKind.Unspecified) },
                    { 48, 6, new DateTime(2023, 3, 31, 23, 3, 50, 555, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 9, 3, 50, 555, DateTimeKind.Unspecified) },
                    { 49, 5, new DateTime(2023, 4, 10, 7, 35, 21, 601, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 16, 35, 21, 601, DateTimeKind.Unspecified) },
                    { 50, 6, new DateTime(2023, 3, 8, 5, 31, 38, 838, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 11, 31, 38, 838, DateTimeKind.Unspecified) },
                    { 51, 3, new DateTime(2023, 4, 7, 5, 17, 43, 923, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 10, 17, 43, 923, DateTimeKind.Unspecified) },
                    { 52, 8, new DateTime(2023, 4, 18, 1, 55, 56, 587, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 9, 55, 56, 587, DateTimeKind.Unspecified) },
                    { 53, 9, new DateTime(2023, 3, 1, 17, 17, 52, 832, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 21, 17, 52, 832, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 2, 24, 8, 9, 26, 259, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 9, 9, 26, 259, DateTimeKind.Unspecified) },
                    { 55, 7, new DateTime(2023, 3, 11, 14, 22, 16, 866, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 22, 22, 16, 866, DateTimeKind.Unspecified) },
                    { 56, 3, new DateTime(2023, 4, 13, 7, 38, 39, 865, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 10, 38, 39, 865, DateTimeKind.Unspecified) },
                    { 57, 4, new DateTime(2023, 5, 9, 8, 23, 21, 385, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 10, 23, 21, 385, DateTimeKind.Unspecified) },
                    { 58, 8, new DateTime(2023, 3, 18, 3, 47, 53, 856, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 8, 47, 53, 856, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 5, 30, 17, 50, 33, 105, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 20, 50, 33, 105, DateTimeKind.Unspecified) },
                    { 60, 7, new DateTime(2023, 2, 16, 4, 29, 54, 168, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 7, 29, 54, 168, DateTimeKind.Unspecified) },
                    { 61, 2, new DateTime(2023, 3, 1, 23, 13, 56, 163, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 2, 13, 56, 163, DateTimeKind.Unspecified) },
                    { 62, 4, new DateTime(2023, 2, 25, 12, 26, 47, 200, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 15, 26, 47, 200, DateTimeKind.Unspecified) },
                    { 63, 5, new DateTime(2023, 5, 30, 17, 14, 51, 98, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 20, 14, 51, 98, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 1, new DateTime(2023, 3, 1, 15, 59, 5, 655, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 20, 59, 5, 655, DateTimeKind.Unspecified) },
                    { 65, 8, new DateTime(2023, 3, 24, 0, 33, 37, 304, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 4, 33, 37, 304, DateTimeKind.Unspecified) },
                    { 66, 8, new DateTime(2023, 3, 24, 18, 58, 4, 638, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 3, 58, 4, 638, DateTimeKind.Unspecified) },
                    { 67, 6, new DateTime(2023, 2, 5, 3, 52, 45, 706, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 11, 52, 45, 706, DateTimeKind.Unspecified) },
                    { 68, 7, new DateTime(2023, 4, 6, 18, 51, 23, 338, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 4, 51, 23, 338, DateTimeKind.Unspecified) },
                    { 69, 7, new DateTime(2023, 3, 9, 7, 24, 20, 487, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 8, 24, 20, 487, DateTimeKind.Unspecified) },
                    { 70, 4, new DateTime(2023, 5, 16, 22, 0, 7, 247, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 8, 0, 7, 247, DateTimeKind.Unspecified) },
                    { 71, 1, new DateTime(2023, 3, 19, 0, 18, 57, 877, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 4, 18, 57, 877, DateTimeKind.Unspecified) },
                    { 72, 2, new DateTime(2023, 4, 17, 8, 26, 13, 133, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 14, 26, 13, 133, DateTimeKind.Unspecified) },
                    { 73, 2, new DateTime(2023, 5, 22, 19, 39, 8, 703, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 4, 39, 8, 703, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2023, 3, 18, 1, 32, 29, 463, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 6, 32, 29, 463, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 3, 31, 7, 27, 20, 32, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 9, 27, 20, 32, DateTimeKind.Unspecified) },
                    { 76, 7, new DateTime(2023, 2, 10, 6, 47, 52, 556, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 11, 47, 52, 556, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 3, 20, 11, 18, 5, 105, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 19, 18, 5, 105, DateTimeKind.Unspecified) },
                    { 78, 8, new DateTime(2023, 2, 2, 1, 53, 23, 760, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 8, 53, 23, 760, DateTimeKind.Unspecified) },
                    { 79, 2, new DateTime(2023, 3, 16, 8, 46, 22, 13, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 9, 46, 22, 13, DateTimeKind.Unspecified) },
                    { 80, 3, new DateTime(2023, 5, 17, 16, 29, 52, 65, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 22, 29, 52, 65, DateTimeKind.Unspecified) },
                    { 81, 3, new DateTime(2023, 5, 6, 21, 13, 49, 615, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 23, 13, 49, 615, DateTimeKind.Unspecified) },
                    { 82, 9, new DateTime(2023, 3, 8, 22, 30, 59, 240, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 3, 30, 59, 240, DateTimeKind.Unspecified) },
                    { 83, 6, new DateTime(2023, 5, 22, 5, 26, 6, 6, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 12, 26, 6, 6, DateTimeKind.Unspecified) },
                    { 84, 9, new DateTime(2023, 2, 19, 4, 0, 39, 829, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 14, 0, 39, 829, DateTimeKind.Unspecified) },
                    { 85, 9, new DateTime(2023, 4, 2, 16, 44, 30, 259, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 0, 44, 30, 259, DateTimeKind.Unspecified) },
                    { 86, 2, new DateTime(2023, 4, 15, 12, 26, 31, 451, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 16, 26, 31, 451, DateTimeKind.Unspecified) },
                    { 87, 4, new DateTime(2023, 4, 13, 2, 53, 37, 205, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 5, 53, 37, 205, DateTimeKind.Unspecified) },
                    { 88, 8, new DateTime(2023, 5, 14, 13, 6, 34, 70, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 16, 6, 34, 70, DateTimeKind.Unspecified) },
                    { 89, 2, new DateTime(2023, 2, 5, 4, 59, 31, 336, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 5, 59, 31, 336, DateTimeKind.Unspecified) },
                    { 90, 9, new DateTime(2023, 4, 19, 3, 43, 51, 324, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 7, 43, 51, 324, DateTimeKind.Unspecified) },
                    { 91, 8, new DateTime(2023, 3, 25, 9, 27, 19, 300, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 10, 27, 19, 300, DateTimeKind.Unspecified) },
                    { 92, 1, new DateTime(2023, 3, 15, 21, 27, 38, 237, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 7, 27, 38, 237, DateTimeKind.Unspecified) },
                    { 93, 1, new DateTime(2023, 4, 18, 21, 45, 43, 597, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 5, 45, 43, 597, DateTimeKind.Unspecified) },
                    { 94, 6, new DateTime(2023, 3, 6, 13, 15, 8, 232, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 18, 15, 8, 232, DateTimeKind.Unspecified) },
                    { 95, 1, new DateTime(2023, 5, 25, 19, 54, 10, 491, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 5, 54, 10, 491, DateTimeKind.Unspecified) },
                    { 96, 2, new DateTime(2023, 2, 6, 23, 55, 39, 951, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 3, 55, 39, 951, DateTimeKind.Unspecified) },
                    { 97, 7, new DateTime(2023, 4, 19, 2, 48, 24, 579, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 8, 48, 24, 579, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2023, 5, 1, 7, 40, 53, 214, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 9, 40, 53, 214, DateTimeKind.Unspecified) },
                    { 99, 1, new DateTime(2023, 3, 24, 9, 25, 44, 818, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 18, 25, 44, 818, DateTimeKind.Unspecified) },
                    { 100, 5, new DateTime(2023, 4, 12, 12, 37, 7, 824, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 22, 37, 7, 824, DateTimeKind.Unspecified) },
                    { 101, 6, new DateTime(2023, 3, 5, 9, 14, 10, 660, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 12, 14, 10, 660, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5387), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(5389), 1198m },
                    { 3, 1, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6069), 699m },
                    { 4, 6, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6089), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 7, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6108), 699m },
                    { 6, 4, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6126), 699m },
                    { 7, 3, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6142), 699m },
                    { 8, 3, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6197), 699m },
                    { 9, 3, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6215), 699m },
                    { 10, 7, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6233), 699m },
                    { 11, 6, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6249), 699m },
                    { 12, 5, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6266), 699m },
                    { 13, 2, false, new DateTime(2023, 5, 23, 23, 31, 33, 42, DateTimeKind.Local).AddTicks(6284), 699m }
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
