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
                    { 1, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7994), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7995), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7996), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7997), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2002, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "spcmsofzmgz@gmail.com", 0, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "n0a27pos4rv", 1, "0914157686", "9x3pcgft8oz", 1, "n0a27pos4rv", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2002, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "tcgg3b@gmail.com", 0, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8xlbvk", 2, "0917590203", "3ufrqm", 1, "8xlbvk", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2002, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "h6qfgkzan@gmail.com", 1, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "6osovk37e", 2, "0911149087", "6b8ci8m55", 0, "6osovk37e", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2002, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "qkd4qq@gmail.com", 1, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0o5qpf", 1, "0916301102", "ez2p11", 0, "0o5qpf", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2002, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "6fi4ku@gmail.com", 0, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ahwin", 1, "0919853845", "ykmq2u", 1, "8ahwin", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2002, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "lja3kr@gmail.com", 0, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "9qy3m3", 1, "0916174609", "8vlyng", 0, "9qy3m3", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2002, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hryr0n4@gmail.com", 1, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "nro0p8p", 2, "0913936067", "hoihhxh", 0, "nro0p8p", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2002, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "uvijc8@gmail.com", 1, new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "rmeqoz", 1, "0911406452", "sgdsqy", 0, "rmeqoz", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8011), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8013), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8014), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8015), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8016), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8017), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8017), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8018), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8019), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8020), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8021), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8022), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7884), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7884), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7898), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7897), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7904), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7904), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7910), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7910), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7916), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7915), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7922), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7921), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7927), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7926), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7953), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7952), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7958), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7958), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7964), "Test", 99, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7964), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 171, 21, "", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2 },
                    { 2, 15000, 1, 78, 14, "", new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 3, 15000, 1, 182, 12, "", new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 4 },
                    { 4, 15000, 1, 46, 12, "", new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5 },
                    { 5, 15000, 1, 44, 7, "", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 6, 15000, 1, 76, 11, "", new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 7, 15000, 1, 133, 16, "", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 8, 15000, 1, 133, 9, "", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 9, 15000, 1, 186, 8, "", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 10, 15000, 1, 195, 15, "", new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 11, 15000, 1, 222, 24, "", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 12, 15000, 1, 137, 22, "", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 13, 15000, 1, 189, 16, "", new DateTime(2022, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 14, 15000, 1, 102, 15, "", new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 15, 15000, 1, 75, 16, "", new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 12 },
                    { 16, 15000, 1, 210, 11, "", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 17, 15000, 1, 218, 8, "", new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 18, 15000, 1, 135, 12, "", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 19, 15000, 1, 129, 7, "", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 20, 15000, 1, 132, 20, "", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 21, 15000, 1, 45, 18, "", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 22, 15000, 1, 79, 15, "", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 7 },
                    { 23, 15000, 1, 202, 12, "", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 24, 15000, 1, 50, 12, "", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 25, 15000, 1, 234, 21, "", new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 26, 15000, 1, 201, 16, "", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 27, 15000, 1, 222, 12, "", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 28, 15000, 1, 148, 10, "", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 29, 15000, 1, 66, 14, "", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7984), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(7985), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 5, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7127) },
                    { 2, 2, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7190) },
                    { 3, 2, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7192) },
                    { 4, 2, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7193) },
                    { 5, 8, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7194) },
                    { 6, 2, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7196) },
                    { 7, 10, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7198) },
                    { 8, 6, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7199) },
                    { 9, 8, null, "test", true, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7200) },
                    { 10, 4, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7202) },
                    { 11, 4, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7204) },
                    { 12, 5, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7205) },
                    { 13, 9, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7206) },
                    { 14, 3, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7207) },
                    { 15, 9, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7209) },
                    { 16, 5, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7210) },
                    { 17, 2, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7211) },
                    { 18, 10, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7213) },
                    { 19, 1, null, "test", false, new DateTime(2023, 5, 29, 9, 11, 10, 739, DateTimeKind.Local).AddTicks(7214) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 2, 28, 4, 6, 20, 716, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 7, 6, 20, 716, DateTimeKind.Unspecified) },
                    { 2, 7, new DateTime(2023, 3, 18, 18, 11, 6, 518, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 0, 11, 6, 518, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2023, 5, 9, 7, 28, 27, 562, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 17, 28, 27, 562, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(2023, 5, 14, 21, 2, 20, 1, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 23, 2, 20, 1, DateTimeKind.Unspecified) },
                    { 5, 8, new DateTime(2023, 3, 15, 0, 21, 52, 345, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 3, 21, 52, 345, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2023, 5, 8, 17, 38, 10, 932, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 22, 38, 10, 932, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(2023, 3, 20, 12, 37, 42, 439, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 17, 37, 42, 439, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 3, 9, 5, 46, 55, 998, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 10, 46, 55, 998, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(2023, 3, 14, 9, 58, 35, 195, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 14, 58, 35, 195, DateTimeKind.Unspecified) },
                    { 10, 8, new DateTime(2023, 4, 10, 6, 57, 1, 889, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 15, 57, 1, 889, DateTimeKind.Unspecified) },
                    { 11, 5, new DateTime(2023, 3, 23, 18, 36, 59, 449, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 0, 36, 59, 449, DateTimeKind.Unspecified) },
                    { 12, 8, new DateTime(2023, 5, 4, 7, 45, 2, 758, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 13, 45, 2, 758, DateTimeKind.Unspecified) },
                    { 13, 7, new DateTime(2023, 5, 14, 1, 20, 8, 207, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 9, 20, 8, 207, DateTimeKind.Unspecified) },
                    { 14, 5, new DateTime(2023, 4, 13, 6, 20, 57, 65, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 9, 20, 57, 65, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2023, 3, 27, 10, 56, 29, 93, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 17, 56, 29, 93, DateTimeKind.Unspecified) },
                    { 16, 8, new DateTime(2023, 3, 26, 6, 30, 7, 480, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 7, 30, 7, 480, DateTimeKind.Unspecified) },
                    { 17, 4, new DateTime(2023, 3, 1, 14, 33, 49, 190, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 0, 33, 49, 190, DateTimeKind.Unspecified) },
                    { 18, 1, new DateTime(2023, 4, 16, 4, 14, 13, 788, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 10, 14, 13, 788, DateTimeKind.Unspecified) },
                    { 19, 8, new DateTime(2023, 4, 26, 22, 57, 7, 535, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 3, 57, 7, 535, DateTimeKind.Unspecified) },
                    { 20, 6, new DateTime(2023, 5, 3, 6, 46, 28, 928, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 8, 46, 28, 928, DateTimeKind.Unspecified) },
                    { 21, 9, new DateTime(2023, 2, 22, 1, 14, 36, 584, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 6, 14, 36, 584, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 8, new DateTime(2023, 2, 3, 14, 29, 25, 600, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 17, 29, 25, 600, DateTimeKind.Unspecified) },
                    { 23, 3, new DateTime(2023, 4, 15, 21, 3, 43, 401, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 3, 3, 43, 401, DateTimeKind.Unspecified) },
                    { 24, 6, new DateTime(2023, 5, 30, 1, 14, 37, 121, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 11, 14, 37, 121, DateTimeKind.Unspecified) },
                    { 25, 5, new DateTime(2023, 4, 10, 5, 21, 57, 636, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 12, 21, 57, 636, DateTimeKind.Unspecified) },
                    { 26, 7, new DateTime(2023, 3, 11, 15, 41, 58, 183, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 17, 41, 58, 183, DateTimeKind.Unspecified) },
                    { 27, 7, new DateTime(2023, 3, 2, 0, 38, 0, 85, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 2, 38, 0, 85, DateTimeKind.Unspecified) },
                    { 28, 8, new DateTime(2023, 2, 27, 11, 29, 55, 443, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 13, 29, 55, 443, DateTimeKind.Unspecified) },
                    { 29, 1, new DateTime(2023, 5, 5, 12, 15, 35, 89, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 21, 15, 35, 89, DateTimeKind.Unspecified) },
                    { 30, 5, new DateTime(2023, 2, 4, 23, 52, 30, 492, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 2, 52, 30, 492, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2023, 4, 30, 7, 8, 35, 776, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 12, 8, 35, 776, DateTimeKind.Unspecified) },
                    { 32, 3, new DateTime(2023, 5, 27, 9, 12, 50, 784, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 17, 12, 50, 784, DateTimeKind.Unspecified) },
                    { 33, 9, new DateTime(2023, 2, 3, 10, 56, 33, 129, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 16, 56, 33, 129, DateTimeKind.Unspecified) },
                    { 34, 5, new DateTime(2023, 4, 5, 10, 59, 0, 695, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 12, 59, 0, 695, DateTimeKind.Unspecified) },
                    { 35, 4, new DateTime(2023, 4, 25, 13, 43, 10, 164, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 16, 43, 10, 164, DateTimeKind.Unspecified) },
                    { 36, 5, new DateTime(2023, 5, 31, 6, 11, 38, 712, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 10, 11, 38, 712, DateTimeKind.Unspecified) },
                    { 37, 7, new DateTime(2023, 4, 24, 10, 11, 15, 15, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 16, 11, 15, 15, DateTimeKind.Unspecified) },
                    { 38, 6, new DateTime(2023, 2, 24, 20, 42, 42, 723, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 2, 42, 42, 723, DateTimeKind.Unspecified) },
                    { 39, 1, new DateTime(2023, 3, 13, 21, 16, 32, 316, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 23, 16, 32, 316, DateTimeKind.Unspecified) },
                    { 40, 5, new DateTime(2023, 5, 13, 12, 44, 28, 641, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 22, 44, 28, 641, DateTimeKind.Unspecified) },
                    { 41, 8, new DateTime(2023, 5, 14, 13, 32, 0, 672, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 15, 32, 0, 672, DateTimeKind.Unspecified) },
                    { 42, 7, new DateTime(2023, 2, 2, 6, 33, 36, 49, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 7, 33, 36, 49, DateTimeKind.Unspecified) },
                    { 43, 4, new DateTime(2023, 3, 8, 5, 6, 5, 133, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 15, 6, 5, 133, DateTimeKind.Unspecified) },
                    { 44, 4, new DateTime(2023, 5, 15, 8, 12, 10, 720, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 16, 12, 10, 720, DateTimeKind.Unspecified) },
                    { 45, 9, new DateTime(2023, 3, 28, 9, 13, 23, 345, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 19, 13, 23, 345, DateTimeKind.Unspecified) },
                    { 46, 7, new DateTime(2023, 3, 7, 18, 27, 0, 377, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 21, 27, 0, 377, DateTimeKind.Unspecified) },
                    { 47, 6, new DateTime(2023, 2, 20, 8, 25, 7, 51, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 9, 25, 7, 51, DateTimeKind.Unspecified) },
                    { 48, 9, new DateTime(2023, 2, 27, 21, 32, 11, 812, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 0, 32, 11, 812, DateTimeKind.Unspecified) },
                    { 49, 1, new DateTime(2023, 4, 1, 19, 53, 11, 158, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 20, 53, 11, 158, DateTimeKind.Unspecified) },
                    { 50, 9, new DateTime(2023, 3, 11, 11, 59, 32, 883, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 14, 59, 32, 883, DateTimeKind.Unspecified) },
                    { 51, 6, new DateTime(2023, 5, 1, 17, 19, 39, 306, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 2, 19, 39, 306, DateTimeKind.Unspecified) },
                    { 52, 2, new DateTime(2023, 2, 22, 0, 58, 32, 721, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 1, 58, 32, 721, DateTimeKind.Unspecified) },
                    { 53, 3, new DateTime(2023, 5, 7, 11, 12, 19, 40, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 14, 12, 19, 40, DateTimeKind.Unspecified) },
                    { 54, 7, new DateTime(2023, 3, 2, 10, 0, 35, 908, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 12, 0, 35, 908, DateTimeKind.Unspecified) },
                    { 55, 2, new DateTime(2023, 3, 8, 8, 31, 15, 309, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 18, 31, 15, 309, DateTimeKind.Unspecified) },
                    { 56, 6, new DateTime(2023, 4, 11, 18, 44, 50, 454, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 19, 44, 50, 454, DateTimeKind.Unspecified) },
                    { 57, 5, new DateTime(2023, 4, 18, 16, 42, 2, 409, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 20, 42, 2, 409, DateTimeKind.Unspecified) },
                    { 58, 4, new DateTime(2023, 4, 4, 4, 6, 16, 425, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 11, 6, 16, 425, DateTimeKind.Unspecified) },
                    { 59, 7, new DateTime(2023, 5, 13, 22, 11, 0, 393, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 4, 11, 0, 393, DateTimeKind.Unspecified) },
                    { 60, 8, new DateTime(2023, 5, 16, 5, 58, 23, 547, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 6, 58, 23, 547, DateTimeKind.Unspecified) },
                    { 61, 5, new DateTime(2023, 4, 23, 5, 56, 58, 886, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 12, 56, 58, 886, DateTimeKind.Unspecified) },
                    { 62, 6, new DateTime(2023, 2, 18, 1, 21, 17, 150, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 9, 21, 17, 150, DateTimeKind.Unspecified) },
                    { 63, 5, new DateTime(2023, 2, 12, 13, 17, 58, 472, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 19, 17, 58, 472, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 8, new DateTime(2023, 4, 18, 17, 38, 15, 184, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 2, 38, 15, 184, DateTimeKind.Unspecified) },
                    { 65, 6, new DateTime(2023, 4, 29, 10, 3, 42, 361, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 17, 3, 42, 361, DateTimeKind.Unspecified) },
                    { 66, 9, new DateTime(2023, 5, 20, 5, 3, 20, 687, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 13, 3, 20, 687, DateTimeKind.Unspecified) },
                    { 67, 1, new DateTime(2023, 5, 10, 18, 44, 27, 414, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 3, 44, 27, 414, DateTimeKind.Unspecified) },
                    { 68, 3, new DateTime(2023, 2, 13, 8, 52, 28, 453, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 9, 52, 28, 453, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 2, 2, 17, 12, 42, 348, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 0, 12, 42, 348, DateTimeKind.Unspecified) },
                    { 70, 5, new DateTime(2023, 4, 17, 5, 2, 44, 538, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 14, 2, 44, 538, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 2, 25, 12, 0, 2, 861, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 18, 0, 2, 861, DateTimeKind.Unspecified) },
                    { 72, 9, new DateTime(2023, 4, 30, 3, 45, 49, 325, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 10, 45, 49, 325, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 5, 25, 14, 26, 12, 825, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 18, 26, 12, 825, DateTimeKind.Unspecified) },
                    { 74, 9, new DateTime(2023, 5, 1, 17, 49, 21, 587, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 19, 49, 21, 587, DateTimeKind.Unspecified) },
                    { 75, 2, new DateTime(2023, 3, 7, 0, 51, 54, 187, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 10, 51, 54, 187, DateTimeKind.Unspecified) },
                    { 76, 8, new DateTime(2023, 5, 28, 17, 54, 6, 57, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 23, 54, 6, 57, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 5, 22, 15, 40, 32, 653, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 20, 40, 32, 653, DateTimeKind.Unspecified) },
                    { 78, 2, new DateTime(2023, 3, 24, 15, 33, 50, 728, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 22, 33, 50, 728, DateTimeKind.Unspecified) },
                    { 79, 2, new DateTime(2023, 4, 3, 20, 25, 15, 250, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 3, 25, 15, 250, DateTimeKind.Unspecified) },
                    { 80, 5, new DateTime(2023, 4, 29, 21, 39, 57, 784, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 7, 39, 57, 784, DateTimeKind.Unspecified) },
                    { 81, 7, new DateTime(2023, 4, 18, 16, 22, 16, 470, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 0, 22, 16, 470, DateTimeKind.Unspecified) },
                    { 82, 6, new DateTime(2023, 2, 7, 0, 0, 44, 427, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 3, 0, 44, 427, DateTimeKind.Unspecified) },
                    { 83, 2, new DateTime(2023, 2, 15, 10, 23, 30, 869, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 11, 23, 30, 869, DateTimeKind.Unspecified) },
                    { 84, 3, new DateTime(2023, 4, 24, 19, 50, 4, 850, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 2, 50, 4, 850, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 5, 9, 19, 23, 43, 514, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 21, 23, 43, 514, DateTimeKind.Unspecified) },
                    { 86, 3, new DateTime(2023, 3, 17, 4, 29, 4, 729, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 7, 29, 4, 729, DateTimeKind.Unspecified) },
                    { 87, 9, new DateTime(2023, 5, 4, 1, 48, 13, 248, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 3, 48, 13, 248, DateTimeKind.Unspecified) },
                    { 88, 3, new DateTime(2023, 3, 6, 4, 11, 41, 86, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 13, 11, 41, 86, DateTimeKind.Unspecified) },
                    { 89, 5, new DateTime(2023, 4, 26, 18, 55, 21, 351, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 1, 55, 21, 351, DateTimeKind.Unspecified) },
                    { 90, 4, new DateTime(2023, 3, 3, 17, 4, 31, 836, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 21, 4, 31, 836, DateTimeKind.Unspecified) },
                    { 91, 5, new DateTime(2023, 2, 28, 1, 34, 26, 595, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 8, 34, 26, 595, DateTimeKind.Unspecified) },
                    { 92, 8, new DateTime(2023, 2, 8, 20, 6, 10, 257, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 3, 6, 10, 257, DateTimeKind.Unspecified) },
                    { 93, 7, new DateTime(2023, 4, 2, 18, 43, 21, 532, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 1, 43, 21, 532, DateTimeKind.Unspecified) },
                    { 94, 5, new DateTime(2023, 3, 11, 15, 20, 49, 352, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 18, 20, 49, 352, DateTimeKind.Unspecified) },
                    { 95, 4, new DateTime(2023, 5, 3, 9, 11, 22, 709, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 12, 11, 22, 709, DateTimeKind.Unspecified) },
                    { 96, 4, new DateTime(2023, 4, 7, 22, 27, 17, 874, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 5, 27, 17, 874, DateTimeKind.Unspecified) },
                    { 97, 6, new DateTime(2023, 5, 10, 14, 31, 48, 783, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 17, 31, 48, 783, DateTimeKind.Unspecified) },
                    { 98, 4, new DateTime(2023, 3, 29, 11, 29, 33, 877, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 21, 29, 33, 877, DateTimeKind.Unspecified) },
                    { 99, 2, new DateTime(2023, 5, 16, 16, 3, 20, 152, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 18, 3, 20, 152, DateTimeKind.Unspecified) },
                    { 100, 1, new DateTime(2023, 2, 23, 1, 46, 54, 162, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 9, 46, 54, 162, DateTimeKind.Unspecified) },
                    { 101, 4, new DateTime(2023, 2, 10, 6, 37, 37, 71, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 7, 37, 37, 71, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8032), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8033), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8034), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8035), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 8, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8752), 700m },
                    { 6, 6, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8772), 700m },
                    { 7, 8, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8781), 700m },
                    { 8, 5, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8789), 700m },
                    { 9, 8, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8798), 700m },
                    { 10, 4, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8814), 700m },
                    { 11, 8, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8823), 700m },
                    { 12, 6, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8831), 700m },
                    { 13, 3, false, new DateTime(2023, 5, 29, 9, 11, 10, 740, DateTimeKind.Local).AddTicks(8839), 700m }
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
