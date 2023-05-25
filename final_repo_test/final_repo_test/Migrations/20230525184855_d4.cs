using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class d4 : Migration
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
                    { 1, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6739), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6740), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6741), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6741), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "w8mxscygq@gmail.com", 0, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0919776439", "w8mxscygq", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "60jb48vvs@gmail.com", 1, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0912288138", "60jb48vvs", 0, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "tz05kvpfhhy@gmail.com", 0, new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 1, "0915927675", "tz05kvpfhhy", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "exuc1ju95z@gmail.com", 1, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 2, "0918906777", "exuc1ju95z", 1, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "obzm621z@gmail.com", 1, new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0911934270", "obzm621z", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "olb0tko@gmail.com", 0, new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0910505095", "olb0tko", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "yx1n0037z@gmail.com", 1, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 1, "0915215746", "yx1n0037z", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "1gpmm51jsiz@gmail.com", 0, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 2, "0918956463", "1gpmm51jsiz", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6754), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6756), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6757), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6758), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6759), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6759), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6760), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6761), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6762), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6763), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6764), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6764), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6643), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6642), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6651), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6651), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6656), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6656), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6661), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6660), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6665), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6664), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6670), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6669), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6675), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6674), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6679), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6678), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6683), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6682), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6710), "Test", 99, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6709), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 155, 11, "", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 2, 15000, 1, 37, 24, "", new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 3, 15000, 1, 173, 9, "", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 4, 15000, 1, 113, 23, "", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 5, 15000, 1, 208, 16, "", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 6, 15000, 1, 226, 16, "", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 7, 15000, 1, 52, 15, "", new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 8, 15000, 1, 33, 18, "", new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 9, 15000, 1, 100, 20, "", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 },
                    { 10, 15000, 1, 176, 8, "", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 11, 15000, 1, 57, 18, "", new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 12, 15000, 1, 154, 7, "", new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 13, 15000, 1, 167, 15, "", new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 15 },
                    { 14, 15000, 1, 176, 9, "", new DateTime(2022, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 15, 15000, 1, 215, 8, "", new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 16, 15000, 1, 164, 13, "", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 17, 15000, 1, 33, 23, "", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 5 },
                    { 18, 15000, 1, 217, 17, "", new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 19, 15000, 1, 133, 15, "", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 20, 15000, 1, 65, 24, "", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 21, 15000, 1, 228, 14, "", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 22, 15000, 1, 105, 13, "", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 14 },
                    { 23, 15000, 1, 42, 16, "", new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 24, 15000, 1, 130, 8, "", new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 25, 15000, 1, 141, 24, "", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 26, 15000, 1, 142, 14, "", new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 27, 15000, 1, 227, 19, "", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 28, 15000, 1, 178, 23, "", new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 17 },
                    { 29, 15000, 1, 181, 16, "", new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6729), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6731), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 5, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(814) },
                    { 2, 1, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(852) },
                    { 3, 9, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(854) },
                    { 4, 3, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(856) },
                    { 5, 1, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(857) },
                    { 6, 1, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(859) },
                    { 7, 1, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(861) },
                    { 8, 3, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(861) },
                    { 9, 6, null, "test", true, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(863) },
                    { 10, 10, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(865) },
                    { 11, 4, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(867) },
                    { 12, 8, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(868) },
                    { 13, 7, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(869) },
                    { 14, 9, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(870) },
                    { 15, 8, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(871) },
                    { 16, 6, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(872) },
                    { 17, 2, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(873) },
                    { 18, 8, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(874) },
                    { 19, 8, null, "test", false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(875) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 5, 28, 9, 1, 46, 487, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 19, 1, 46, 487, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 5, 27, 14, 7, 10, 850, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 0, 7, 10, 850, DateTimeKind.Unspecified) },
                    { 3, 4, new DateTime(2023, 4, 28, 19, 6, 16, 849, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 23, 6, 16, 849, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2023, 4, 8, 4, 14, 38, 238, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 11, 14, 38, 238, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2023, 2, 6, 19, 52, 42, 649, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 4, 52, 42, 649, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2023, 5, 29, 6, 1, 14, 127, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 1, 14, 127, DateTimeKind.Unspecified) },
                    { 7, 8, new DateTime(2023, 4, 21, 14, 32, 38, 436, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 23, 32, 38, 436, DateTimeKind.Unspecified) },
                    { 8, 9, new DateTime(2023, 2, 16, 5, 21, 54, 530, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 15, 21, 54, 530, DateTimeKind.Unspecified) },
                    { 9, 8, new DateTime(2023, 4, 23, 5, 9, 54, 395, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 10, 9, 54, 395, DateTimeKind.Unspecified) },
                    { 10, 7, new DateTime(2023, 3, 23, 0, 3, 10, 770, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 6, 3, 10, 770, DateTimeKind.Unspecified) },
                    { 11, 9, new DateTime(2023, 3, 19, 13, 21, 3, 904, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 14, 21, 3, 904, DateTimeKind.Unspecified) },
                    { 12, 4, new DateTime(2023, 5, 19, 0, 44, 6, 338, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 5, 44, 6, 338, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2023, 3, 15, 18, 13, 42, 231, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 22, 13, 42, 231, DateTimeKind.Unspecified) },
                    { 14, 6, new DateTime(2023, 4, 2, 9, 27, 36, 340, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 16, 27, 36, 340, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2023, 2, 9, 16, 18, 12, 831, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 17, 18, 12, 831, DateTimeKind.Unspecified) },
                    { 16, 6, new DateTime(2023, 3, 21, 14, 39, 41, 756, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 19, 39, 41, 756, DateTimeKind.Unspecified) },
                    { 17, 8, new DateTime(2023, 2, 3, 21, 18, 19, 678, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 0, 18, 19, 678, DateTimeKind.Unspecified) },
                    { 18, 1, new DateTime(2023, 5, 11, 23, 40, 10, 492, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 1, 40, 10, 492, DateTimeKind.Unspecified) },
                    { 19, 4, new DateTime(2023, 3, 31, 6, 55, 8, 661, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 13, 55, 8, 661, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 3, 1, 8, 37, 47, 163, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 12, 37, 47, 163, DateTimeKind.Unspecified) },
                    { 21, 8, new DateTime(2023, 3, 29, 23, 0, 29, 931, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 1, 0, 29, 931, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 6, new DateTime(2023, 5, 23, 11, 7, 38, 567, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 14, 7, 38, 567, DateTimeKind.Unspecified) },
                    { 23, 9, new DateTime(2023, 5, 9, 22, 13, 52, 685, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 2, 13, 52, 685, DateTimeKind.Unspecified) },
                    { 24, 9, new DateTime(2023, 4, 9, 12, 49, 26, 816, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 18, 49, 26, 816, DateTimeKind.Unspecified) },
                    { 25, 9, new DateTime(2023, 2, 12, 11, 19, 6, 992, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 18, 19, 6, 992, DateTimeKind.Unspecified) },
                    { 26, 7, new DateTime(2023, 2, 10, 9, 47, 59, 560, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 13, 47, 59, 560, DateTimeKind.Unspecified) },
                    { 27, 7, new DateTime(2023, 4, 7, 0, 16, 3, 145, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 2, 16, 3, 145, DateTimeKind.Unspecified) },
                    { 28, 4, new DateTime(2023, 2, 28, 6, 40, 9, 53, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 11, 40, 9, 53, DateTimeKind.Unspecified) },
                    { 29, 7, new DateTime(2023, 2, 15, 3, 56, 15, 251, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 11, 56, 15, 251, DateTimeKind.Unspecified) },
                    { 30, 7, new DateTime(2023, 5, 27, 7, 58, 8, 68, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 11, 58, 8, 68, DateTimeKind.Unspecified) },
                    { 31, 2, new DateTime(2023, 2, 25, 8, 19, 38, 950, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 16, 19, 38, 950, DateTimeKind.Unspecified) },
                    { 32, 7, new DateTime(2023, 4, 17, 4, 19, 27, 518, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 11, 19, 27, 518, DateTimeKind.Unspecified) },
                    { 33, 2, new DateTime(2023, 5, 20, 22, 46, 31, 324, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 7, 46, 31, 324, DateTimeKind.Unspecified) },
                    { 34, 7, new DateTime(2023, 4, 6, 19, 11, 56, 774, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 21, 11, 56, 774, DateTimeKind.Unspecified) },
                    { 35, 6, new DateTime(2023, 3, 21, 21, 12, 48, 485, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 22, 12, 48, 485, DateTimeKind.Unspecified) },
                    { 36, 2, new DateTime(2023, 5, 17, 9, 46, 15, 469, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 17, 46, 15, 469, DateTimeKind.Unspecified) },
                    { 37, 6, new DateTime(2023, 3, 13, 8, 1, 11, 817, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 14, 1, 11, 817, DateTimeKind.Unspecified) },
                    { 38, 9, new DateTime(2023, 5, 15, 14, 24, 38, 292, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 17, 24, 38, 292, DateTimeKind.Unspecified) },
                    { 39, 2, new DateTime(2023, 5, 23, 19, 28, 11, 432, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 23, 28, 11, 432, DateTimeKind.Unspecified) },
                    { 40, 1, new DateTime(2023, 5, 25, 22, 21, 59, 164, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 1, 21, 59, 164, DateTimeKind.Unspecified) },
                    { 41, 9, new DateTime(2023, 2, 13, 11, 3, 33, 244, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 19, 3, 33, 244, DateTimeKind.Unspecified) },
                    { 42, 5, new DateTime(2023, 4, 13, 21, 6, 51, 6, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 0, 6, 51, 6, DateTimeKind.Unspecified) },
                    { 43, 5, new DateTime(2023, 5, 30, 5, 55, 52, 872, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 13, 55, 52, 872, DateTimeKind.Unspecified) },
                    { 44, 5, new DateTime(2023, 4, 15, 11, 26, 22, 373, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 18, 26, 22, 373, DateTimeKind.Unspecified) },
                    { 45, 8, new DateTime(2023, 4, 28, 4, 34, 34, 433, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 10, 34, 34, 433, DateTimeKind.Unspecified) },
                    { 46, 2, new DateTime(2023, 3, 26, 22, 56, 53, 745, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 0, 56, 53, 745, DateTimeKind.Unspecified) },
                    { 47, 5, new DateTime(2023, 4, 10, 14, 36, 32, 847, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 17, 36, 32, 847, DateTimeKind.Unspecified) },
                    { 48, 3, new DateTime(2023, 2, 4, 0, 30, 33, 187, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 10, 30, 33, 187, DateTimeKind.Unspecified) },
                    { 49, 9, new DateTime(2023, 5, 11, 9, 47, 6, 287, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 10, 47, 6, 287, DateTimeKind.Unspecified) },
                    { 50, 1, new DateTime(2023, 5, 23, 14, 44, 19, 270, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 15, 44, 19, 270, DateTimeKind.Unspecified) },
                    { 51, 2, new DateTime(2023, 2, 26, 8, 19, 7, 322, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 15, 19, 7, 322, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2023, 5, 29, 6, 44, 42, 952, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 9, 44, 42, 952, DateTimeKind.Unspecified) },
                    { 53, 9, new DateTime(2023, 5, 23, 5, 17, 38, 449, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 12, 17, 38, 449, DateTimeKind.Unspecified) },
                    { 54, 8, new DateTime(2023, 4, 13, 19, 45, 27, 531, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 20, 45, 27, 531, DateTimeKind.Unspecified) },
                    { 55, 8, new DateTime(2023, 5, 18, 5, 3, 37, 443, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 6, 3, 37, 443, DateTimeKind.Unspecified) },
                    { 56, 5, new DateTime(2023, 4, 4, 23, 38, 19, 79, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 0, 38, 19, 79, DateTimeKind.Unspecified) },
                    { 57, 8, new DateTime(2023, 2, 26, 6, 54, 23, 514, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 12, 54, 23, 514, DateTimeKind.Unspecified) },
                    { 58, 9, new DateTime(2023, 4, 4, 10, 43, 54, 688, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 15, 43, 54, 688, DateTimeKind.Unspecified) },
                    { 59, 3, new DateTime(2023, 4, 27, 2, 45, 28, 566, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 5, 45, 28, 566, DateTimeKind.Unspecified) },
                    { 60, 3, new DateTime(2023, 4, 1, 2, 43, 15, 360, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 9, 43, 15, 360, DateTimeKind.Unspecified) },
                    { 61, 2, new DateTime(2023, 5, 2, 3, 42, 16, 123, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 5, 42, 16, 123, DateTimeKind.Unspecified) },
                    { 62, 4, new DateTime(2023, 4, 29, 5, 18, 42, 858, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 15, 18, 42, 858, DateTimeKind.Unspecified) },
                    { 63, 1, new DateTime(2023, 2, 11, 10, 42, 38, 108, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 13, 42, 38, 108, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 6, new DateTime(2023, 2, 27, 20, 5, 29, 206, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 22, 5, 29, 206, DateTimeKind.Unspecified) },
                    { 65, 6, new DateTime(2023, 4, 26, 15, 58, 35, 312, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 21, 58, 35, 312, DateTimeKind.Unspecified) },
                    { 66, 2, new DateTime(2023, 3, 8, 7, 13, 20, 318, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 8, 13, 20, 318, DateTimeKind.Unspecified) },
                    { 67, 6, new DateTime(2023, 4, 2, 9, 3, 40, 21, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 19, 3, 40, 21, DateTimeKind.Unspecified) },
                    { 68, 4, new DateTime(2023, 2, 18, 10, 0, 44, 540, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 19, 0, 44, 540, DateTimeKind.Unspecified) },
                    { 69, 7, new DateTime(2023, 4, 7, 18, 6, 5, 101, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 2, 6, 5, 101, DateTimeKind.Unspecified) },
                    { 70, 8, new DateTime(2023, 2, 27, 14, 32, 56, 456, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 23, 32, 56, 456, DateTimeKind.Unspecified) },
                    { 71, 1, new DateTime(2023, 2, 14, 4, 36, 20, 600, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 10, 36, 20, 600, DateTimeKind.Unspecified) },
                    { 72, 3, new DateTime(2023, 5, 8, 11, 46, 47, 480, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 17, 46, 47, 480, DateTimeKind.Unspecified) },
                    { 73, 1, new DateTime(2023, 4, 18, 23, 17, 17, 914, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 4, 17, 17, 914, DateTimeKind.Unspecified) },
                    { 74, 4, new DateTime(2023, 4, 17, 16, 59, 7, 888, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 21, 59, 7, 888, DateTimeKind.Unspecified) },
                    { 75, 2, new DateTime(2023, 5, 30, 21, 11, 0, 574, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 6, 11, 0, 574, DateTimeKind.Unspecified) },
                    { 76, 6, new DateTime(2023, 4, 13, 4, 7, 19, 346, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 8, 7, 19, 346, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 2, 21, 4, 15, 36, 856, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 9, 15, 36, 856, DateTimeKind.Unspecified) },
                    { 78, 1, new DateTime(2023, 2, 26, 3, 35, 20, 361, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 7, 35, 20, 361, DateTimeKind.Unspecified) },
                    { 79, 4, new DateTime(2023, 5, 11, 13, 23, 6, 402, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 18, 23, 6, 402, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2023, 5, 15, 5, 20, 21, 765, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 8, 20, 21, 765, DateTimeKind.Unspecified) },
                    { 81, 6, new DateTime(2023, 2, 19, 8, 1, 36, 525, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 18, 1, 36, 525, DateTimeKind.Unspecified) },
                    { 82, 7, new DateTime(2023, 3, 30, 1, 48, 1, 8, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 9, 48, 1, 8, DateTimeKind.Unspecified) },
                    { 83, 8, new DateTime(2023, 4, 23, 14, 47, 50, 144, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 22, 47, 50, 144, DateTimeKind.Unspecified) },
                    { 84, 6, new DateTime(2023, 4, 27, 12, 22, 58, 80, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 22, 22, 58, 80, DateTimeKind.Unspecified) },
                    { 85, 4, new DateTime(2023, 3, 28, 17, 2, 47, 164, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 18, 2, 47, 164, DateTimeKind.Unspecified) },
                    { 86, 7, new DateTime(2023, 2, 2, 10, 13, 37, 640, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 20, 13, 37, 640, DateTimeKind.Unspecified) },
                    { 87, 5, new DateTime(2023, 2, 12, 19, 12, 14, 899, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 4, 12, 14, 899, DateTimeKind.Unspecified) },
                    { 88, 4, new DateTime(2023, 3, 31, 23, 58, 9, 106, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 4, 58, 9, 106, DateTimeKind.Unspecified) },
                    { 89, 6, new DateTime(2023, 3, 21, 23, 26, 22, 805, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 7, 26, 22, 805, DateTimeKind.Unspecified) },
                    { 90, 6, new DateTime(2023, 4, 16, 6, 53, 36, 59, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 12, 53, 36, 59, DateTimeKind.Unspecified) },
                    { 91, 1, new DateTime(2023, 5, 2, 15, 49, 32, 920, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 1, 49, 32, 920, DateTimeKind.Unspecified) },
                    { 92, 8, new DateTime(2023, 4, 2, 21, 20, 51, 168, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 20, 51, 168, DateTimeKind.Unspecified) },
                    { 93, 3, new DateTime(2023, 4, 20, 0, 0, 34, 489, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 10, 0, 34, 489, DateTimeKind.Unspecified) },
                    { 94, 6, new DateTime(2023, 5, 18, 9, 55, 23, 573, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 15, 55, 23, 573, DateTimeKind.Unspecified) },
                    { 95, 7, new DateTime(2023, 2, 13, 2, 3, 20, 413, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 4, 3, 20, 413, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 5, 7, 15, 5, 4, 133, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 16, 5, 4, 133, DateTimeKind.Unspecified) },
                    { 97, 6, new DateTime(2023, 4, 26, 11, 9, 36, 595, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 15, 9, 36, 595, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2023, 4, 19, 15, 18, 45, 358, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 22, 18, 45, 358, DateTimeKind.Unspecified) },
                    { 99, 7, new DateTime(2023, 2, 13, 7, 36, 14, 475, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 36, 14, 475, DateTimeKind.Unspecified) },
                    { 100, 6, new DateTime(2023, 4, 21, 11, 15, 7, 328, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 12, 15, 7, 328, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 5, 31, 20, 31, 29, 31, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 22, 31, 29, 31, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6774), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6775), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6776), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(6776), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 8, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7181), 700m },
                    { 6, 7, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7191), 700m },
                    { 7, 2, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7223), 700m },
                    { 8, 2, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7230), 700m },
                    { 9, 8, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7237), 700m },
                    { 10, 8, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7245), 700m },
                    { 11, 9, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7253), 700m },
                    { 12, 8, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7259), 700m },
                    { 13, 5, false, new DateTime(2023, 5, 26, 2, 48, 55, 291, DateTimeKind.Local).AddTicks(7266), 700m }
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
