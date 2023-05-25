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
                    { 1, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8904), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8906), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8907), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8907), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "j0ei21z@gmail.com", 1, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0919109480", "j0ei21z", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "n448esr5@gmail.com", 1, new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0912011122", "n448esr5", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "haycwygka@gmail.com", 1, new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 1, "0912320326", "haycwygka", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "fnda3etn@gmail.com", 0, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0917857912", "fnda3etn", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "5yyfodfw@gmail.com", 0, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0913286796", "5yyfodfw", 1, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "89rabs@gmail.com", 0, new DateTime(2022, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0919796038", "89rabs", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "l6wjylqq5f9@gmail.com", 0, new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0913708856", "l6wjylqq5f9", 0, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "8funoj3q@gmail.com", 0, new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0919545992", "8funoj3q", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8921), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8927), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8928), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8929), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8930), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8931), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8932), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8933), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8935), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8936), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8937), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8938), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8771), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8768), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8792), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8792), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8801), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8800), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8808), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8808), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8816), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8816), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8826), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8825), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8834), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8833), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8841), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8841), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8849), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8848), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8857), "Test", 99, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8856), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 77, 7, "", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 2, 15000, 1, 155, 14, "", new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 3, 15000, 1, 104, 12, "", new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 4, 15000, 1, 165, 23, "", new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 5, 15000, 1, 89, 9, "", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 },
                    { 6, 15000, 1, 70, 14, "", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 7, 15000, 1, 219, 14, "", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 8, 15000, 1, 102, 21, "", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 9, 15000, 1, 97, 8, "", new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 10, 15000, 1, 203, 13, "", new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 11, 15000, 1, 225, 18, "", new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 13 },
                    { 12, 15000, 1, 81, 10, "", new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 13, 15000, 1, 147, 7, "", new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 14, 15000, 1, 183, 21, "", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 19 },
                    { 15, 15000, 1, 218, 24, "", new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 16, 15000, 1, 49, 18, "", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 17, 15000, 1, 125, 9, "", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 18, 15000, 1, 233, 12, "", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 19, 15000, 1, 173, 20, "", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 10 },
                    { 20, 15000, 1, 121, 7, "", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 19 },
                    { 21, 15000, 1, 215, 12, "", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 22, 15000, 1, 54, 16, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 23, 15000, 1, 36, 24, "", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 17 },
                    { 24, 15000, 1, 31, 10, "", new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 25, 15000, 1, 204, 15, "", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 6 },
                    { 26, 15000, 1, 101, 16, "", new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 27, 15000, 1, 125, 9, "", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 5 },
                    { 28, 15000, 1, 45, 20, "", new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 13 },
                    { 29, 15000, 1, 67, 15, "", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8888), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8890), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 8, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8476) },
                    { 2, 7, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8539) },
                    { 3, 9, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8541) },
                    { 4, 8, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8543) },
                    { 5, 5, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8546) },
                    { 6, 9, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8549) },
                    { 7, 8, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8551) },
                    { 8, 8, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8553) },
                    { 9, 9, null, "test", true, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8555) },
                    { 10, 2, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8558) },
                    { 11, 8, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8561) },
                    { 12, 1, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8563) },
                    { 13, 8, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8570) },
                    { 14, 4, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8572) },
                    { 15, 3, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8574) },
                    { 16, 2, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8575) },
                    { 17, 4, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8577) },
                    { 18, 1, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8580) },
                    { 19, 4, null, "test", false, new DateTime(2023, 5, 25, 20, 39, 50, 250, DateTimeKind.Local).AddTicks(8582) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 5, 2, 18, 5, 20, 728, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 22, 5, 20, 728, DateTimeKind.Unspecified) },
                    { 2, 9, new DateTime(2023, 4, 4, 11, 17, 21, 935, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 16, 17, 21, 935, DateTimeKind.Unspecified) },
                    { 3, 9, new DateTime(2023, 3, 17, 8, 10, 30, 30, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 17, 10, 30, 30, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 3, 4, 4, 1, 6, 882, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 13, 1, 6, 882, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2023, 2, 6, 16, 57, 17, 913, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 21, 57, 17, 913, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2023, 5, 10, 19, 14, 45, 773, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 2, 14, 45, 773, DateTimeKind.Unspecified) },
                    { 7, 9, new DateTime(2023, 2, 20, 13, 43, 8, 471, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 22, 43, 8, 471, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2023, 4, 15, 0, 35, 29, 456, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 9, 35, 29, 456, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2023, 2, 11, 5, 25, 34, 76, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 6, 25, 34, 76, DateTimeKind.Unspecified) },
                    { 10, 5, new DateTime(2023, 5, 6, 8, 24, 49, 448, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 15, 24, 49, 448, DateTimeKind.Unspecified) },
                    { 11, 7, new DateTime(2023, 4, 11, 1, 13, 2, 474, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 10, 13, 2, 474, DateTimeKind.Unspecified) },
                    { 12, 5, new DateTime(2023, 4, 9, 19, 21, 25, 954, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 20, 21, 25, 954, DateTimeKind.Unspecified) },
                    { 13, 9, new DateTime(2023, 2, 20, 2, 28, 22, 58, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 12, 28, 22, 58, DateTimeKind.Unspecified) },
                    { 14, 3, new DateTime(2023, 5, 10, 15, 33, 4, 835, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 18, 33, 4, 835, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2023, 2, 27, 8, 45, 42, 705, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 15, 45, 42, 705, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 4, 20, 18, 24, 54, 814, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 22, 24, 54, 814, DateTimeKind.Unspecified) },
                    { 17, 8, new DateTime(2023, 2, 3, 23, 59, 18, 113, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 8, 59, 18, 113, DateTimeKind.Unspecified) },
                    { 18, 5, new DateTime(2023, 3, 4, 4, 58, 7, 169, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 7, 58, 7, 169, DateTimeKind.Unspecified) },
                    { 19, 3, new DateTime(2023, 5, 13, 23, 23, 20, 711, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 1, 23, 20, 711, DateTimeKind.Unspecified) },
                    { 20, 8, new DateTime(2023, 5, 14, 9, 50, 23, 717, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 11, 50, 23, 717, DateTimeKind.Unspecified) },
                    { 21, 2, new DateTime(2023, 3, 8, 15, 13, 54, 825, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 0, 13, 54, 825, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 7, new DateTime(2023, 4, 23, 12, 36, 53, 651, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 15, 36, 53, 651, DateTimeKind.Unspecified) },
                    { 23, 8, new DateTime(2023, 5, 23, 17, 16, 44, 137, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 3, 16, 44, 137, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2023, 2, 13, 17, 28, 6, 992, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 18, 28, 6, 992, DateTimeKind.Unspecified) },
                    { 25, 2, new DateTime(2023, 3, 22, 11, 9, 14, 509, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 18, 9, 14, 509, DateTimeKind.Unspecified) },
                    { 26, 7, new DateTime(2023, 5, 9, 12, 45, 5, 141, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 22, 45, 5, 141, DateTimeKind.Unspecified) },
                    { 27, 4, new DateTime(2023, 3, 6, 12, 29, 24, 927, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 13, 29, 24, 927, DateTimeKind.Unspecified) },
                    { 28, 6, new DateTime(2023, 5, 5, 15, 31, 35, 839, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 19, 31, 35, 839, DateTimeKind.Unspecified) },
                    { 29, 7, new DateTime(2023, 3, 25, 11, 14, 6, 96, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 12, 14, 6, 96, DateTimeKind.Unspecified) },
                    { 30, 6, new DateTime(2023, 5, 13, 8, 35, 43, 198, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 14, 35, 43, 198, DateTimeKind.Unspecified) },
                    { 31, 2, new DateTime(2023, 3, 29, 7, 33, 47, 241, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 11, 33, 47, 241, DateTimeKind.Unspecified) },
                    { 32, 6, new DateTime(2023, 5, 8, 16, 41, 7, 758, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 19, 41, 7, 758, DateTimeKind.Unspecified) },
                    { 33, 2, new DateTime(2023, 5, 6, 1, 25, 46, 343, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 6, 25, 46, 343, DateTimeKind.Unspecified) },
                    { 34, 9, new DateTime(2023, 2, 6, 9, 27, 56, 998, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 11, 27, 56, 998, DateTimeKind.Unspecified) },
                    { 35, 6, new DateTime(2023, 2, 27, 0, 13, 7, 756, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 10, 13, 7, 756, DateTimeKind.Unspecified) },
                    { 36, 1, new DateTime(2023, 2, 7, 6, 35, 59, 472, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 13, 35, 59, 472, DateTimeKind.Unspecified) },
                    { 37, 6, new DateTime(2023, 5, 3, 3, 57, 21, 349, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 4, 57, 21, 349, DateTimeKind.Unspecified) },
                    { 38, 4, new DateTime(2023, 2, 9, 7, 40, 43, 972, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 11, 40, 43, 972, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 2, 21, 1, 18, 49, 815, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 3, 18, 49, 815, DateTimeKind.Unspecified) },
                    { 40, 6, new DateTime(2023, 3, 15, 5, 55, 21, 304, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 7, 55, 21, 304, DateTimeKind.Unspecified) },
                    { 41, 6, new DateTime(2023, 3, 9, 13, 39, 36, 51, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 18, 39, 36, 51, DateTimeKind.Unspecified) },
                    { 42, 2, new DateTime(2023, 4, 12, 11, 17, 14, 636, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 12, 17, 14, 636, DateTimeKind.Unspecified) },
                    { 43, 2, new DateTime(2023, 3, 16, 6, 19, 25, 197, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 9, 19, 25, 197, DateTimeKind.Unspecified) },
                    { 44, 9, new DateTime(2023, 5, 6, 22, 59, 5, 560, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 23, 59, 5, 560, DateTimeKind.Unspecified) },
                    { 45, 2, new DateTime(2023, 5, 14, 2, 0, 41, 331, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 12, 0, 41, 331, DateTimeKind.Unspecified) },
                    { 46, 4, new DateTime(2023, 4, 2, 5, 34, 47, 348, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 8, 34, 47, 348, DateTimeKind.Unspecified) },
                    { 47, 4, new DateTime(2023, 5, 30, 20, 22, 31, 325, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 3, 22, 31, 325, DateTimeKind.Unspecified) },
                    { 48, 6, new DateTime(2023, 4, 17, 7, 56, 23, 160, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 11, 56, 23, 160, DateTimeKind.Unspecified) },
                    { 49, 4, new DateTime(2023, 5, 11, 18, 55, 10, 436, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 23, 55, 10, 436, DateTimeKind.Unspecified) },
                    { 50, 8, new DateTime(2023, 3, 11, 9, 35, 36, 852, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 10, 35, 36, 852, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2023, 2, 11, 21, 47, 34, 6, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 2, 47, 34, 6, DateTimeKind.Unspecified) },
                    { 52, 7, new DateTime(2023, 3, 25, 15, 2, 0, 396, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 21, 2, 0, 396, DateTimeKind.Unspecified) },
                    { 53, 1, new DateTime(2023, 5, 28, 18, 25, 57, 123, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 19, 25, 57, 123, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2023, 5, 5, 22, 26, 3, 300, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 2, 26, 3, 300, DateTimeKind.Unspecified) },
                    { 55, 9, new DateTime(2023, 4, 1, 18, 46, 54, 748, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 4, 46, 54, 748, DateTimeKind.Unspecified) },
                    { 56, 9, new DateTime(2023, 4, 11, 7, 58, 49, 36, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 17, 58, 49, 36, DateTimeKind.Unspecified) },
                    { 57, 6, new DateTime(2023, 3, 25, 9, 46, 41, 543, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 10, 46, 41, 543, DateTimeKind.Unspecified) },
                    { 58, 4, new DateTime(2023, 4, 1, 17, 21, 2, 659, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 18, 21, 2, 659, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 2, 4, 23, 0, 26, 7, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 5, 0, 26, 7, DateTimeKind.Unspecified) },
                    { 60, 1, new DateTime(2023, 2, 28, 7, 53, 28, 79, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 14, 53, 28, 79, DateTimeKind.Unspecified) },
                    { 61, 5, new DateTime(2023, 4, 28, 7, 13, 7, 857, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 12, 13, 7, 857, DateTimeKind.Unspecified) },
                    { 62, 5, new DateTime(2023, 5, 7, 7, 40, 36, 741, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 16, 40, 36, 741, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 2, 11, 8, 24, 16, 167, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 15, 24, 16, 167, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 1, new DateTime(2023, 5, 20, 13, 38, 15, 406, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 21, 38, 15, 406, DateTimeKind.Unspecified) },
                    { 65, 1, new DateTime(2023, 2, 25, 23, 7, 33, 992, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 6, 7, 33, 992, DateTimeKind.Unspecified) },
                    { 66, 2, new DateTime(2023, 3, 12, 8, 34, 24, 626, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 17, 34, 24, 626, DateTimeKind.Unspecified) },
                    { 67, 7, new DateTime(2023, 2, 6, 15, 9, 21, 493, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 20, 9, 21, 493, DateTimeKind.Unspecified) },
                    { 68, 6, new DateTime(2023, 3, 8, 23, 55, 34, 845, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 2, 55, 34, 845, DateTimeKind.Unspecified) },
                    { 69, 8, new DateTime(2023, 5, 4, 19, 21, 18, 660, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 1, 21, 18, 660, DateTimeKind.Unspecified) },
                    { 70, 2, new DateTime(2023, 4, 13, 5, 55, 25, 376, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 14, 55, 25, 376, DateTimeKind.Unspecified) },
                    { 71, 2, new DateTime(2023, 4, 2, 12, 29, 21, 90, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 20, 29, 21, 90, DateTimeKind.Unspecified) },
                    { 72, 6, new DateTime(2023, 3, 14, 18, 30, 59, 148, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 22, 30, 59, 148, DateTimeKind.Unspecified) },
                    { 73, 2, new DateTime(2023, 3, 27, 21, 58, 17, 824, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 22, 58, 17, 824, DateTimeKind.Unspecified) },
                    { 74, 3, new DateTime(2023, 4, 14, 19, 35, 45, 690, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 20, 35, 45, 690, DateTimeKind.Unspecified) },
                    { 75, 3, new DateTime(2023, 3, 12, 18, 43, 10, 590, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 0, 43, 10, 590, DateTimeKind.Unspecified) },
                    { 76, 6, new DateTime(2023, 3, 7, 10, 4, 16, 82, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 18, 4, 16, 82, DateTimeKind.Unspecified) },
                    { 77, 1, new DateTime(2023, 4, 17, 18, 42, 16, 327, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 0, 42, 16, 327, DateTimeKind.Unspecified) },
                    { 78, 9, new DateTime(2023, 4, 23, 15, 5, 13, 964, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 18, 5, 13, 964, DateTimeKind.Unspecified) },
                    { 79, 7, new DateTime(2023, 2, 20, 16, 17, 41, 779, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 0, 17, 41, 779, DateTimeKind.Unspecified) },
                    { 80, 7, new DateTime(2023, 4, 16, 4, 43, 58, 45, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 11, 43, 58, 45, DateTimeKind.Unspecified) },
                    { 81, 3, new DateTime(2023, 3, 23, 2, 25, 41, 580, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 10, 25, 41, 580, DateTimeKind.Unspecified) },
                    { 82, 1, new DateTime(2023, 3, 13, 0, 27, 7, 50, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 6, 27, 7, 50, DateTimeKind.Unspecified) },
                    { 83, 5, new DateTime(2023, 3, 12, 20, 59, 59, 556, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 1, 59, 59, 556, DateTimeKind.Unspecified) },
                    { 84, 5, new DateTime(2023, 2, 24, 18, 36, 25, 607, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 0, 36, 25, 607, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 5, 19, 0, 6, 59, 946, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 3, 6, 59, 946, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2023, 5, 6, 9, 7, 37, 397, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 13, 7, 37, 397, DateTimeKind.Unspecified) },
                    { 87, 5, new DateTime(2023, 4, 14, 18, 31, 53, 281, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 20, 31, 53, 281, DateTimeKind.Unspecified) },
                    { 88, 6, new DateTime(2023, 5, 26, 23, 23, 57, 601, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 2, 23, 57, 601, DateTimeKind.Unspecified) },
                    { 89, 3, new DateTime(2023, 5, 8, 9, 55, 58, 717, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 17, 55, 58, 717, DateTimeKind.Unspecified) },
                    { 90, 4, new DateTime(2023, 4, 30, 4, 22, 34, 100, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 13, 22, 34, 100, DateTimeKind.Unspecified) },
                    { 91, 1, new DateTime(2023, 4, 11, 16, 44, 36, 801, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 17, 44, 36, 801, DateTimeKind.Unspecified) },
                    { 92, 4, new DateTime(2023, 3, 13, 5, 46, 32, 421, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 6, 46, 32, 421, DateTimeKind.Unspecified) },
                    { 93, 1, new DateTime(2023, 5, 22, 11, 2, 17, 171, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 19, 2, 17, 171, DateTimeKind.Unspecified) },
                    { 94, 5, new DateTime(2023, 4, 19, 6, 52, 2, 82, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 15, 52, 2, 82, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 3, 8, 15, 34, 53, 957, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 0, 34, 53, 957, DateTimeKind.Unspecified) },
                    { 96, 1, new DateTime(2023, 2, 27, 10, 46, 57, 535, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 15, 46, 57, 535, DateTimeKind.Unspecified) },
                    { 97, 6, new DateTime(2023, 4, 21, 1, 31, 41, 844, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 5, 31, 41, 844, DateTimeKind.Unspecified) },
                    { 98, 6, new DateTime(2023, 2, 14, 8, 7, 15, 702, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 10, 7, 15, 702, DateTimeKind.Unspecified) },
                    { 99, 8, new DateTime(2023, 3, 10, 18, 30, 44, 419, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 19, 30, 44, 419, DateTimeKind.Unspecified) },
                    { 100, 8, new DateTime(2023, 5, 30, 15, 43, 51, 545, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 1, 43, 51, 545, DateTimeKind.Unspecified) },
                    { 101, 6, new DateTime(2023, 5, 24, 13, 47, 58, 572, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 15, 47, 58, 572, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8953), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8954), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8955), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(8956), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 8, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9590), 700m },
                    { 6, 9, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9609), 700m },
                    { 7, 2, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9624), 700m },
                    { 8, 4, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9637), 700m },
                    { 9, 6, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9650), 700m },
                    { 10, 8, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9670), 700m },
                    { 11, 1, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9685), 700m },
                    { 12, 3, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9697), 700m },
                    { 13, 4, false, new DateTime(2023, 5, 25, 20, 39, 50, 252, DateTimeKind.Local).AddTicks(9710), 700m }
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
