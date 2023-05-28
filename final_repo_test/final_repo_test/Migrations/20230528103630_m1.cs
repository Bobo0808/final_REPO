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
                    { 1, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5825), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5827), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5828), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5829), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "jcq9akbh9@gmail.com", 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0911227931", "jcq9akbh9", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "5271740m@gmail.com", 0, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0912267655", "5271740m", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "nj7rfg@gmail.com", 0, new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0916379691", "nj7rfg", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "z5508do8mg@gmail.com", 1, new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0915446385", "z5508do8mg", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "hq7hpmbaaj@gmail.com", 1, new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0911735136", "hq7hpmbaaj", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "92fbwq19akb@gmail.com", 1, new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0912689654", "92fbwq19akb", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ord787@gmail.com", 0, new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 1, "0916517614", "1ord787", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "3e95b2xe3@gmail.com", 1, new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0919587417", "3e95b2xe3", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5842), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5844), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5845), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5846), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5848), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5849), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5850), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5851), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5852), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5853), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5855), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5856), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5673), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5671), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5690), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5689), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5698), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5697), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5706), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5705), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5713), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5713), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5723), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5722), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5730), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5730), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5738), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5737), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5745), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5744), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5790), "Test", 99, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5789), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 32, 23, "", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 5 },
                    { 2, 15000, 1, 137, 18, "", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 3, 15000, 1, 203, 17, "", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 4, 15000, 1, 184, 24, "", new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 13 },
                    { 5, 15000, 1, 88, 11, "", new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 19 },
                    { 6, 15000, 1, 36, 12, "", new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 12 },
                    { 7, 15000, 1, 151, 24, "", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 8, 15000, 1, 37, 13, "", new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 9, 15000, 1, 163, 22, "", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 10, 15000, 1, 65, 22, "", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 11, 15000, 1, 147, 9, "", new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 12, 15000, 1, 58, 16, "", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 13, 15000, 1, 141, 11, "", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 14, 15000, 1, 134, 21, "", new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 15, 15000, 1, 70, 13, "", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 16, 15000, 1, 129, 19, "", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 17, 15000, 1, 179, 19, "", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 18, 15000, 1, 232, 23, "", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 19, 15000, 1, 169, 23, "", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 20, 15000, 1, 50, 16, "", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 21, 15000, 1, 39, 9, "", new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 22, 15000, 1, 34, 24, "", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 23, 15000, 1, 131, 14, "", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 24, 15000, 1, 171, 9, "", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 25, 15000, 1, 118, 15, "", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 26, 15000, 1, 120, 22, "", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 27, 15000, 1, 180, 11, "", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 28, 15000, 1, 172, 15, "", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 29, 15000, 1, 118, 13, "", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5813), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5815), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 8, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 231, DateTimeKind.Local).AddTicks(9951) },
                    { 2, 1, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(9) },
                    { 3, 5, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(12) },
                    { 4, 5, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(14) },
                    { 5, 1, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(15) },
                    { 6, 2, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(19) },
                    { 7, 3, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(20) },
                    { 8, 2, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(22) },
                    { 9, 2, null, "test", true, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(24) },
                    { 10, 10, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(27) },
                    { 11, 3, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(29) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(31) },
                    { 13, 5, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(33) },
                    { 14, 2, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(35) },
                    { 15, 6, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(37) },
                    { 16, 9, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(38) },
                    { 17, 5, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(40) },
                    { 18, 5, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(42) },
                    { 19, 6, null, "test", false, new DateTime(2023, 5, 28, 18, 36, 30, 232, DateTimeKind.Local).AddTicks(44) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 5, 16, 18, 11, 41, 486, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 1, 11, 41, 486, DateTimeKind.Unspecified) },
                    { 2, 8, new DateTime(2023, 4, 5, 1, 34, 39, 561, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 3, 34, 39, 561, DateTimeKind.Unspecified) },
                    { 3, 8, new DateTime(2023, 5, 29, 15, 34, 29, 914, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 20, 34, 29, 914, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2023, 4, 14, 23, 9, 23, 989, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 0, 9, 23, 989, DateTimeKind.Unspecified) },
                    { 5, 7, new DateTime(2023, 5, 17, 11, 14, 39, 462, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 16, 14, 39, 462, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2023, 4, 9, 5, 49, 5, 556, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 12, 49, 5, 556, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2023, 5, 6, 0, 52, 22, 231, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 1, 52, 22, 231, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2023, 5, 19, 18, 3, 26, 557, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 3, 3, 26, 557, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2023, 3, 23, 6, 10, 53, 56, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 9, 10, 53, 56, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 2, 26, 8, 26, 4, 709, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 11, 26, 4, 709, DateTimeKind.Unspecified) },
                    { 11, 3, new DateTime(2023, 4, 3, 3, 15, 7, 586, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 12, 15, 7, 586, DateTimeKind.Unspecified) },
                    { 12, 9, new DateTime(2023, 2, 14, 20, 41, 0, 240, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 3, 41, 0, 240, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2023, 4, 20, 7, 58, 45, 93, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 8, 58, 45, 93, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 5, 13, 12, 3, 59, 165, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 14, 3, 59, 165, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2023, 3, 4, 14, 40, 55, 49, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 15, 40, 55, 49, DateTimeKind.Unspecified) },
                    { 16, 7, new DateTime(2023, 3, 14, 21, 7, 30, 389, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 2, 7, 30, 389, DateTimeKind.Unspecified) },
                    { 17, 4, new DateTime(2023, 4, 23, 7, 4, 12, 115, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 11, 4, 12, 115, DateTimeKind.Unspecified) },
                    { 18, 5, new DateTime(2023, 3, 31, 11, 40, 2, 886, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 16, 40, 2, 886, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 3, 31, 17, 14, 45, 705, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 1, 14, 45, 705, DateTimeKind.Unspecified) },
                    { 20, 5, new DateTime(2023, 2, 21, 21, 6, 18, 588, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 22, 6, 18, 588, DateTimeKind.Unspecified) },
                    { 21, 6, new DateTime(2023, 3, 12, 22, 28, 15, 537, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 7, 28, 15, 537, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 8, new DateTime(2023, 3, 21, 9, 1, 39, 23, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 13, 1, 39, 23, DateTimeKind.Unspecified) },
                    { 23, 5, new DateTime(2023, 5, 12, 23, 36, 46, 476, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 1, 36, 46, 476, DateTimeKind.Unspecified) },
                    { 24, 5, new DateTime(2023, 4, 7, 16, 54, 7, 996, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 2, 54, 7, 996, DateTimeKind.Unspecified) },
                    { 25, 6, new DateTime(2023, 4, 27, 17, 11, 37, 877, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 3, 11, 37, 877, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2023, 2, 7, 1, 52, 17, 921, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 8, 52, 17, 921, DateTimeKind.Unspecified) },
                    { 27, 8, new DateTime(2023, 3, 28, 14, 26, 56, 75, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 15, 26, 56, 75, DateTimeKind.Unspecified) },
                    { 28, 9, new DateTime(2023, 3, 13, 12, 23, 30, 686, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 14, 23, 30, 686, DateTimeKind.Unspecified) },
                    { 29, 4, new DateTime(2023, 4, 21, 17, 6, 57, 793, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 21, 6, 57, 793, DateTimeKind.Unspecified) },
                    { 30, 3, new DateTime(2023, 4, 20, 22, 45, 44, 464, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 0, 45, 44, 464, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2023, 3, 6, 22, 39, 18, 548, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 1, 39, 18, 548, DateTimeKind.Unspecified) },
                    { 32, 4, new DateTime(2023, 4, 24, 17, 23, 57, 99, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 22, 23, 57, 99, DateTimeKind.Unspecified) },
                    { 33, 2, new DateTime(2023, 5, 9, 21, 48, 2, 580, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 0, 48, 2, 580, DateTimeKind.Unspecified) },
                    { 34, 6, new DateTime(2023, 4, 19, 16, 3, 4, 379, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 21, 3, 4, 379, DateTimeKind.Unspecified) },
                    { 35, 2, new DateTime(2023, 4, 2, 8, 10, 53, 697, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 17, 10, 53, 697, DateTimeKind.Unspecified) },
                    { 36, 5, new DateTime(2023, 2, 6, 16, 50, 20, 267, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 20, 50, 20, 267, DateTimeKind.Unspecified) },
                    { 37, 2, new DateTime(2023, 2, 20, 3, 22, 31, 25, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 9, 22, 31, 25, DateTimeKind.Unspecified) },
                    { 38, 1, new DateTime(2023, 5, 16, 16, 19, 47, 517, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 1, 19, 47, 517, DateTimeKind.Unspecified) },
                    { 39, 1, new DateTime(2023, 4, 24, 9, 13, 35, 191, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 18, 13, 35, 191, DateTimeKind.Unspecified) },
                    { 40, 5, new DateTime(2023, 4, 27, 6, 24, 34, 716, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 11, 24, 34, 716, DateTimeKind.Unspecified) },
                    { 41, 1, new DateTime(2023, 5, 6, 12, 20, 3, 375, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 15, 20, 3, 375, DateTimeKind.Unspecified) },
                    { 42, 8, new DateTime(2023, 5, 29, 9, 10, 44, 445, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 18, 10, 44, 445, DateTimeKind.Unspecified) },
                    { 43, 9, new DateTime(2023, 3, 30, 1, 56, 21, 650, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 5, 56, 21, 650, DateTimeKind.Unspecified) },
                    { 44, 7, new DateTime(2023, 3, 16, 22, 59, 48, 398, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 1, 59, 48, 398, DateTimeKind.Unspecified) },
                    { 45, 8, new DateTime(2023, 5, 8, 17, 0, 10, 299, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 19, 0, 10, 299, DateTimeKind.Unspecified) },
                    { 46, 2, new DateTime(2023, 4, 17, 3, 49, 33, 681, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 4, 49, 33, 681, DateTimeKind.Unspecified) },
                    { 47, 7, new DateTime(2023, 4, 28, 19, 51, 24, 675, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 2, 51, 24, 675, DateTimeKind.Unspecified) },
                    { 48, 7, new DateTime(2023, 3, 28, 2, 0, 25, 497, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 12, 0, 25, 497, DateTimeKind.Unspecified) },
                    { 49, 7, new DateTime(2023, 5, 15, 19, 46, 7, 213, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 22, 46, 7, 213, DateTimeKind.Unspecified) },
                    { 50, 9, new DateTime(2023, 3, 17, 22, 14, 51, 774, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 23, 14, 51, 774, DateTimeKind.Unspecified) },
                    { 51, 5, new DateTime(2023, 5, 2, 20, 2, 15, 505, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 0, 2, 15, 505, DateTimeKind.Unspecified) },
                    { 52, 1, new DateTime(2023, 5, 21, 3, 38, 6, 640, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 6, 38, 6, 640, DateTimeKind.Unspecified) },
                    { 53, 8, new DateTime(2023, 4, 27, 18, 35, 11, 152, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 21, 35, 11, 152, DateTimeKind.Unspecified) },
                    { 54, 2, new DateTime(2023, 5, 7, 0, 19, 2, 321, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 8, 19, 2, 321, DateTimeKind.Unspecified) },
                    { 55, 9, new DateTime(2023, 5, 26, 4, 17, 16, 739, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 12, 17, 16, 739, DateTimeKind.Unspecified) },
                    { 56, 2, new DateTime(2023, 4, 26, 10, 18, 11, 609, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 14, 18, 11, 609, DateTimeKind.Unspecified) },
                    { 57, 4, new DateTime(2023, 4, 10, 20, 41, 11, 8, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 3, 41, 11, 8, DateTimeKind.Unspecified) },
                    { 58, 7, new DateTime(2023, 3, 18, 15, 48, 28, 312, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 18, 48, 28, 312, DateTimeKind.Unspecified) },
                    { 59, 6, new DateTime(2023, 3, 11, 14, 2, 39, 389, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 16, 2, 39, 389, DateTimeKind.Unspecified) },
                    { 60, 2, new DateTime(2023, 4, 16, 0, 23, 6, 721, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 7, 23, 6, 721, DateTimeKind.Unspecified) },
                    { 61, 6, new DateTime(2023, 5, 4, 15, 11, 54, 588, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 22, 11, 54, 588, DateTimeKind.Unspecified) },
                    { 62, 2, new DateTime(2023, 5, 28, 8, 7, 32, 945, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 17, 7, 32, 945, DateTimeKind.Unspecified) },
                    { 63, 6, new DateTime(2023, 4, 15, 16, 28, 7, 68, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 0, 28, 7, 68, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 8, new DateTime(2023, 2, 25, 10, 54, 41, 855, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 18, 54, 41, 855, DateTimeKind.Unspecified) },
                    { 65, 2, new DateTime(2023, 5, 6, 10, 1, 29, 988, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 17, 1, 29, 988, DateTimeKind.Unspecified) },
                    { 66, 7, new DateTime(2023, 2, 16, 23, 3, 12, 273, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 5, 3, 12, 273, DateTimeKind.Unspecified) },
                    { 67, 4, new DateTime(2023, 5, 16, 23, 34, 36, 197, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 3, 34, 36, 197, DateTimeKind.Unspecified) },
                    { 68, 8, new DateTime(2023, 5, 2, 4, 30, 16, 750, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 9, 30, 16, 750, DateTimeKind.Unspecified) },
                    { 69, 8, new DateTime(2023, 4, 17, 0, 41, 19, 493, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 6, 41, 19, 493, DateTimeKind.Unspecified) },
                    { 70, 7, new DateTime(2023, 2, 3, 15, 10, 9, 174, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 16, 10, 9, 174, DateTimeKind.Unspecified) },
                    { 71, 2, new DateTime(2023, 2, 6, 13, 15, 35, 88, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 17, 15, 35, 88, DateTimeKind.Unspecified) },
                    { 72, 6, new DateTime(2023, 2, 16, 6, 14, 15, 793, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 9, 14, 15, 793, DateTimeKind.Unspecified) },
                    { 73, 1, new DateTime(2023, 2, 3, 4, 29, 43, 54, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 7, 29, 43, 54, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 2, 17, 21, 1, 46, 220, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 4, 1, 46, 220, DateTimeKind.Unspecified) },
                    { 75, 9, new DateTime(2023, 2, 8, 23, 55, 29, 945, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 8, 55, 29, 945, DateTimeKind.Unspecified) },
                    { 76, 2, new DateTime(2023, 5, 29, 20, 52, 34, 914, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 3, 52, 34, 914, DateTimeKind.Unspecified) },
                    { 77, 8, new DateTime(2023, 2, 19, 11, 30, 12, 339, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 12, 30, 12, 339, DateTimeKind.Unspecified) },
                    { 78, 6, new DateTime(2023, 4, 1, 18, 3, 45, 619, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 23, 3, 45, 619, DateTimeKind.Unspecified) },
                    { 79, 1, new DateTime(2023, 5, 6, 14, 14, 35, 928, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 16, 14, 35, 928, DateTimeKind.Unspecified) },
                    { 80, 3, new DateTime(2023, 3, 9, 0, 57, 48, 166, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 4, 57, 48, 166, DateTimeKind.Unspecified) },
                    { 81, 2, new DateTime(2023, 4, 18, 1, 37, 7, 439, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 3, 37, 7, 439, DateTimeKind.Unspecified) },
                    { 82, 9, new DateTime(2023, 2, 23, 4, 13, 16, 78, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 7, 13, 16, 78, DateTimeKind.Unspecified) },
                    { 83, 1, new DateTime(2023, 3, 27, 1, 32, 27, 30, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 5, 32, 27, 30, DateTimeKind.Unspecified) },
                    { 84, 6, new DateTime(2023, 5, 24, 4, 35, 47, 371, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 13, 35, 47, 371, DateTimeKind.Unspecified) },
                    { 85, 2, new DateTime(2023, 5, 12, 1, 9, 4, 401, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 10, 9, 4, 401, DateTimeKind.Unspecified) },
                    { 86, 7, new DateTime(2023, 2, 7, 23, 56, 1, 600, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 8, 56, 1, 600, DateTimeKind.Unspecified) },
                    { 87, 6, new DateTime(2023, 5, 6, 3, 1, 36, 790, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 8, 1, 36, 790, DateTimeKind.Unspecified) },
                    { 88, 2, new DateTime(2023, 4, 20, 0, 48, 34, 413, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 10, 48, 34, 413, DateTimeKind.Unspecified) },
                    { 89, 7, new DateTime(2023, 3, 7, 18, 40, 25, 655, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 3, 40, 25, 655, DateTimeKind.Unspecified) },
                    { 90, 8, new DateTime(2023, 5, 25, 17, 35, 50, 897, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 1, 35, 50, 897, DateTimeKind.Unspecified) },
                    { 91, 9, new DateTime(2023, 5, 29, 18, 16, 31, 653, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 0, 16, 31, 653, DateTimeKind.Unspecified) },
                    { 92, 7, new DateTime(2023, 3, 12, 15, 34, 46, 33, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 19, 34, 46, 33, DateTimeKind.Unspecified) },
                    { 93, 7, new DateTime(2023, 5, 8, 18, 28, 20, 756, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 3, 28, 20, 756, DateTimeKind.Unspecified) },
                    { 94, 7, new DateTime(2023, 4, 1, 19, 7, 58, 835, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 23, 7, 58, 835, DateTimeKind.Unspecified) },
                    { 95, 5, new DateTime(2023, 2, 3, 16, 7, 42, 906, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 20, 7, 42, 906, DateTimeKind.Unspecified) },
                    { 96, 2, new DateTime(2023, 3, 8, 0, 41, 49, 457, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 1, 41, 49, 457, DateTimeKind.Unspecified) },
                    { 97, 1, new DateTime(2023, 5, 10, 13, 0, 35, 683, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 16, 0, 35, 683, DateTimeKind.Unspecified) },
                    { 98, 9, new DateTime(2023, 3, 7, 9, 49, 50, 381, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 16, 49, 50, 381, DateTimeKind.Unspecified) },
                    { 99, 3, new DateTime(2023, 2, 19, 12, 50, 58, 15, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 15, 50, 58, 15, DateTimeKind.Unspecified) },
                    { 100, 3, new DateTime(2023, 4, 1, 4, 20, 55, 909, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 12, 20, 55, 909, DateTimeKind.Unspecified) },
                    { 101, 4, new DateTime(2023, 4, 2, 11, 59, 5, 460, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 13, 59, 5, 460, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5869), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5870), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5871), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(5872), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 4, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6595), 700m },
                    { 6, 2, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6614), 700m },
                    { 7, 2, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6665), 700m },
                    { 8, 7, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6679), 700m },
                    { 9, 9, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6691), 700m },
                    { 10, 1, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6706), 700m },
                    { 11, 2, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6721), 700m },
                    { 12, 1, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6734), 700m },
                    { 13, 7, false, new DateTime(2023, 5, 28, 18, 36, 30, 233, DateTimeKind.Local).AddTicks(6745), 700m }
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
