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
                    { 1, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1705), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1707), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1708), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1709), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "hz1ytnxlf@gmail.com", 0, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0917394407", "hz1ytnxlf", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "uzhpxhluru@gmail.com", 1, new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0918146216", "uzhpxhluru", 0, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "348huecoe@gmail.com", 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0914923371", "348huecoe", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "2qiatzqv50b@gmail.com", 1, new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0915305159", "2qiatzqv50b", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mv9uebfv@gmail.com", 1, new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 2, "0911650015", "mv9uebfv", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "efeydv7@gmail.com", 1, new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 1, "0910118645", "efeydv7", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hatgrksj@gmail.com", 1, new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0912238330", "hatgrksj", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "mqe4o27@gmail.com", 1, new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0913888284", "mqe4o27", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1721), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1723), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1724), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1725), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1726), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1728), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1729), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1730), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1731), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1732), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1733), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1734), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1549), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1547), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1567), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1567), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1575), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1575), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1583), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1582), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1590), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1590), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1599), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1598), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1606), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1606), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1613), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1612), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1656), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1656), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1666), "Test", 99, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1666), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 219, 7, "", new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 5 },
                    { 2, 15000, 1, 64, 17, "", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 3, 15000, 1, 230, 11, "", new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 4, 15000, 1, 77, 7, "", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 5, 15000, 1, 130, 19, "", new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 6, 15000, 1, 150, 7, "", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 9 },
                    { 7, 15000, 1, 43, 23, "", new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 8, 15000, 1, 223, 7, "", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 9, 15000, 1, 83, 14, "", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 7 },
                    { 10, 15000, 1, 33, 18, "", new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 5 },
                    { 11, 15000, 1, 206, 13, "", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 12, 15000, 1, 231, 22, "", new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 13, 15000, 1, 84, 24, "", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 16 },
                    { 14, 15000, 1, 207, 9, "", new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 15, 15000, 1, 116, 14, "", new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 16, 15000, 1, 221, 8, "", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 17, 15000, 1, 75, 23, "", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 18, 15000, 1, 208, 19, "", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 19, 15000, 1, 87, 10, "", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 13 },
                    { 20, 15000, 1, 113, 19, "", new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 21, 15000, 1, 171, 17, "", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 },
                    { 22, 15000, 1, 196, 7, "", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 23, 15000, 1, 177, 9, "", new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 },
                    { 24, 15000, 1, 206, 17, "", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 13 },
                    { 25, 15000, 1, 31, 7, "", new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 },
                    { 26, 15000, 1, 112, 7, "", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 27, 15000, 1, 177, 16, "", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 28, 15000, 1, 133, 10, "", new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3 },
                    { 29, 15000, 1, 169, 14, "", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1691), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1693), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 5, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4052) },
                    { 2, 7, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4110) },
                    { 3, 10, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4113) },
                    { 4, 4, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4115) },
                    { 5, 5, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4117) },
                    { 6, 10, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4121) },
                    { 7, 3, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4123) },
                    { 8, 1, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4124) },
                    { 9, 1, null, "test", true, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4126) },
                    { 10, 6, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4129) },
                    { 11, 3, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4131) },
                    { 12, 2, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4133) },
                    { 13, 5, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4135) },
                    { 14, 1, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4137) },
                    { 15, 9, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4138) },
                    { 16, 6, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4140) },
                    { 17, 1, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4141) },
                    { 18, 4, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4144) },
                    { 19, 2, null, "test", false, new DateTime(2023, 5, 28, 18, 52, 44, 254, DateTimeKind.Local).AddTicks(4146) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 4, 22, 12, 44, 34, 247, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 18, 44, 34, 247, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(2023, 2, 10, 22, 24, 5, 240, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 1, 24, 5, 240, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(2023, 3, 11, 21, 10, 36, 569, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 22, 10, 36, 569, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2023, 4, 9, 8, 6, 1, 994, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 17, 6, 1, 994, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2023, 4, 19, 18, 23, 45, 382, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 19, 23, 45, 382, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2023, 2, 9, 2, 44, 17, 446, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 7, 44, 17, 446, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(2023, 5, 14, 2, 58, 6, 528, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 12, 58, 6, 528, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(2023, 2, 28, 7, 56, 16, 208, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 16, 56, 16, 208, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(2023, 4, 30, 13, 30, 48, 529, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 20, 30, 48, 529, DateTimeKind.Unspecified) },
                    { 10, 9, new DateTime(2023, 4, 28, 0, 54, 28, 545, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 2, 54, 28, 545, DateTimeKind.Unspecified) },
                    { 11, 2, new DateTime(2023, 5, 20, 12, 15, 58, 810, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 16, 15, 58, 810, DateTimeKind.Unspecified) },
                    { 12, 8, new DateTime(2023, 4, 3, 0, 52, 23, 398, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 52, 23, 398, DateTimeKind.Unspecified) },
                    { 13, 8, new DateTime(2023, 3, 14, 14, 34, 25, 496, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 21, 34, 25, 496, DateTimeKind.Unspecified) },
                    { 14, 7, new DateTime(2023, 2, 5, 12, 45, 59, 70, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 18, 45, 59, 70, DateTimeKind.Unspecified) },
                    { 15, 4, new DateTime(2023, 2, 8, 0, 45, 19, 494, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 9, 45, 19, 494, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2023, 4, 27, 12, 36, 5, 377, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 17, 36, 5, 377, DateTimeKind.Unspecified) },
                    { 17, 8, new DateTime(2023, 5, 7, 4, 0, 28, 324, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 14, 0, 28, 324, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2023, 4, 29, 2, 57, 7, 827, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 10, 57, 7, 827, DateTimeKind.Unspecified) },
                    { 19, 9, new DateTime(2023, 3, 23, 2, 7, 8, 584, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 3, 7, 8, 584, DateTimeKind.Unspecified) },
                    { 20, 3, new DateTime(2023, 3, 19, 1, 7, 41, 505, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 11, 7, 41, 505, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2023, 2, 3, 19, 41, 58, 363, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 4, 41, 58, 363, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 5, new DateTime(2023, 3, 24, 17, 42, 28, 380, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 0, 42, 28, 380, DateTimeKind.Unspecified) },
                    { 23, 5, new DateTime(2023, 4, 22, 1, 37, 2, 408, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 4, 37, 2, 408, DateTimeKind.Unspecified) },
                    { 24, 5, new DateTime(2023, 2, 13, 6, 35, 38, 204, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 7, 35, 38, 204, DateTimeKind.Unspecified) },
                    { 25, 7, new DateTime(2023, 2, 22, 17, 44, 48, 282, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 23, 44, 48, 282, DateTimeKind.Unspecified) },
                    { 26, 7, new DateTime(2023, 2, 23, 2, 40, 34, 79, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 9, 40, 34, 79, DateTimeKind.Unspecified) },
                    { 27, 9, new DateTime(2023, 3, 15, 1, 23, 9, 690, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 4, 23, 9, 690, DateTimeKind.Unspecified) },
                    { 28, 7, new DateTime(2023, 4, 25, 2, 32, 13, 425, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 8, 32, 13, 425, DateTimeKind.Unspecified) },
                    { 29, 1, new DateTime(2023, 2, 26, 21, 47, 55, 511, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 2, 47, 55, 511, DateTimeKind.Unspecified) },
                    { 30, 9, new DateTime(2023, 3, 14, 21, 10, 51, 989, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 0, 10, 51, 989, DateTimeKind.Unspecified) },
                    { 31, 9, new DateTime(2023, 4, 20, 14, 2, 45, 586, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 15, 2, 45, 586, DateTimeKind.Unspecified) },
                    { 32, 3, new DateTime(2023, 2, 15, 13, 41, 54, 74, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 21, 41, 54, 74, DateTimeKind.Unspecified) },
                    { 33, 2, new DateTime(2023, 3, 15, 12, 32, 17, 672, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 20, 32, 17, 672, DateTimeKind.Unspecified) },
                    { 34, 8, new DateTime(2023, 4, 14, 23, 6, 33, 23, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 2, 6, 33, 23, DateTimeKind.Unspecified) },
                    { 35, 8, new DateTime(2023, 2, 28, 3, 18, 54, 849, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 12, 18, 54, 849, DateTimeKind.Unspecified) },
                    { 36, 3, new DateTime(2023, 5, 19, 12, 48, 56, 131, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 19, 48, 56, 131, DateTimeKind.Unspecified) },
                    { 37, 8, new DateTime(2023, 2, 1, 8, 56, 50, 36, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 12, 56, 50, 36, DateTimeKind.Unspecified) },
                    { 38, 2, new DateTime(2023, 4, 3, 23, 32, 51, 695, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 9, 32, 51, 695, DateTimeKind.Unspecified) },
                    { 39, 7, new DateTime(2023, 4, 1, 13, 41, 43, 392, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 16, 41, 43, 392, DateTimeKind.Unspecified) },
                    { 40, 3, new DateTime(2023, 3, 23, 12, 50, 52, 897, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 20, 50, 52, 897, DateTimeKind.Unspecified) },
                    { 41, 3, new DateTime(2023, 3, 10, 3, 7, 30, 531, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 4, 7, 30, 531, DateTimeKind.Unspecified) },
                    { 42, 4, new DateTime(2023, 2, 11, 17, 49, 35, 948, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 0, 49, 35, 948, DateTimeKind.Unspecified) },
                    { 43, 9, new DateTime(2023, 2, 11, 7, 58, 13, 557, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 13, 58, 13, 557, DateTimeKind.Unspecified) },
                    { 44, 5, new DateTime(2023, 2, 25, 5, 3, 15, 109, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 13, 3, 15, 109, DateTimeKind.Unspecified) },
                    { 45, 6, new DateTime(2023, 4, 15, 12, 2, 27, 648, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 19, 2, 27, 648, DateTimeKind.Unspecified) },
                    { 46, 3, new DateTime(2023, 3, 14, 2, 33, 28, 233, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 4, 33, 28, 233, DateTimeKind.Unspecified) },
                    { 47, 8, new DateTime(2023, 5, 17, 1, 34, 13, 972, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 3, 34, 13, 972, DateTimeKind.Unspecified) },
                    { 48, 3, new DateTime(2023, 4, 29, 2, 36, 19, 868, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 10, 36, 19, 868, DateTimeKind.Unspecified) },
                    { 49, 6, new DateTime(2023, 2, 4, 22, 38, 23, 538, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 3, 38, 23, 538, DateTimeKind.Unspecified) },
                    { 50, 7, new DateTime(2023, 4, 17, 9, 58, 48, 124, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 16, 58, 48, 124, DateTimeKind.Unspecified) },
                    { 51, 4, new DateTime(2023, 4, 2, 6, 31, 10, 348, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 16, 31, 10, 348, DateTimeKind.Unspecified) },
                    { 52, 1, new DateTime(2023, 5, 26, 2, 15, 18, 706, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 4, 15, 18, 706, DateTimeKind.Unspecified) },
                    { 53, 8, new DateTime(2023, 3, 8, 3, 31, 55, 744, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 7, 31, 55, 744, DateTimeKind.Unspecified) },
                    { 54, 7, new DateTime(2023, 5, 20, 3, 59, 52, 694, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 10, 59, 52, 694, DateTimeKind.Unspecified) },
                    { 55, 8, new DateTime(2023, 5, 19, 23, 34, 12, 399, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 8, 34, 12, 399, DateTimeKind.Unspecified) },
                    { 56, 2, new DateTime(2023, 5, 9, 6, 42, 54, 691, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 9, 42, 54, 691, DateTimeKind.Unspecified) },
                    { 57, 8, new DateTime(2023, 2, 3, 2, 30, 39, 843, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 9, 30, 39, 843, DateTimeKind.Unspecified) },
                    { 58, 9, new DateTime(2023, 4, 25, 22, 25, 34, 677, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 0, 25, 34, 677, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2023, 2, 25, 0, 44, 44, 102, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 9, 44, 44, 102, DateTimeKind.Unspecified) },
                    { 60, 3, new DateTime(2023, 3, 3, 17, 26, 51, 575, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 0, 26, 51, 575, DateTimeKind.Unspecified) },
                    { 61, 1, new DateTime(2023, 4, 12, 22, 7, 46, 561, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 0, 7, 46, 561, DateTimeKind.Unspecified) },
                    { 62, 2, new DateTime(2023, 4, 18, 17, 35, 42, 740, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 18, 35, 42, 740, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 3, 10, 8, 1, 26, 788, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 14, 1, 26, 788, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 2, new DateTime(2023, 4, 5, 22, 22, 6, 952, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 3, 22, 6, 952, DateTimeKind.Unspecified) },
                    { 65, 1, new DateTime(2023, 4, 28, 2, 28, 42, 559, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 6, 28, 42, 559, DateTimeKind.Unspecified) },
                    { 66, 2, new DateTime(2023, 3, 22, 9, 58, 15, 768, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 19, 58, 15, 768, DateTimeKind.Unspecified) },
                    { 67, 1, new DateTime(2023, 2, 16, 22, 9, 18, 255, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 2, 9, 18, 255, DateTimeKind.Unspecified) },
                    { 68, 9, new DateTime(2023, 2, 10, 11, 45, 25, 292, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 18, 45, 25, 292, DateTimeKind.Unspecified) },
                    { 69, 5, new DateTime(2023, 3, 28, 14, 48, 55, 69, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 19, 48, 55, 69, DateTimeKind.Unspecified) },
                    { 70, 6, new DateTime(2023, 2, 20, 21, 11, 13, 147, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 7, 11, 13, 147, DateTimeKind.Unspecified) },
                    { 71, 5, new DateTime(2023, 5, 13, 14, 50, 27, 328, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 15, 50, 27, 328, DateTimeKind.Unspecified) },
                    { 72, 6, new DateTime(2023, 5, 18, 6, 6, 0, 635, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 15, 6, 0, 635, DateTimeKind.Unspecified) },
                    { 73, 4, new DateTime(2023, 4, 11, 15, 53, 40, 833, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 0, 53, 40, 833, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 2, 25, 3, 18, 7, 446, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 5, 18, 7, 446, DateTimeKind.Unspecified) },
                    { 75, 1, new DateTime(2023, 4, 15, 10, 16, 15, 901, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 17, 16, 15, 901, DateTimeKind.Unspecified) },
                    { 76, 1, new DateTime(2023, 4, 2, 16, 16, 35, 402, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 16, 35, 402, DateTimeKind.Unspecified) },
                    { 77, 6, new DateTime(2023, 2, 27, 17, 46, 24, 601, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 22, 46, 24, 601, DateTimeKind.Unspecified) },
                    { 78, 4, new DateTime(2023, 5, 17, 10, 49, 38, 870, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 11, 49, 38, 870, DateTimeKind.Unspecified) },
                    { 79, 9, new DateTime(2023, 4, 14, 2, 44, 49, 29, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 11, 44, 49, 29, DateTimeKind.Unspecified) },
                    { 80, 8, new DateTime(2023, 2, 24, 6, 43, 15, 207, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 9, 43, 15, 207, DateTimeKind.Unspecified) },
                    { 81, 7, new DateTime(2023, 3, 26, 2, 48, 38, 819, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 4, 48, 38, 819, DateTimeKind.Unspecified) },
                    { 82, 1, new DateTime(2023, 3, 23, 9, 47, 51, 589, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 13, 47, 51, 589, DateTimeKind.Unspecified) },
                    { 83, 8, new DateTime(2023, 4, 14, 2, 42, 50, 516, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 8, 42, 50, 516, DateTimeKind.Unspecified) },
                    { 84, 7, new DateTime(2023, 5, 5, 6, 14, 59, 392, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 16, 14, 59, 392, DateTimeKind.Unspecified) },
                    { 85, 9, new DateTime(2023, 2, 24, 19, 17, 59, 659, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 0, 17, 59, 659, DateTimeKind.Unspecified) },
                    { 86, 7, new DateTime(2023, 3, 8, 23, 41, 38, 858, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 3, 41, 38, 858, DateTimeKind.Unspecified) },
                    { 87, 3, new DateTime(2023, 2, 23, 23, 34, 1, 42, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 8, 34, 1, 42, DateTimeKind.Unspecified) },
                    { 88, 4, new DateTime(2023, 5, 7, 17, 0, 7, 938, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 2, 0, 7, 938, DateTimeKind.Unspecified) },
                    { 89, 4, new DateTime(2023, 4, 7, 11, 26, 47, 377, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 15, 26, 47, 377, DateTimeKind.Unspecified) },
                    { 90, 6, new DateTime(2023, 4, 6, 12, 25, 29, 679, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 18, 25, 29, 679, DateTimeKind.Unspecified) },
                    { 91, 6, new DateTime(2023, 2, 19, 20, 45, 3, 120, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 21, 45, 3, 120, DateTimeKind.Unspecified) },
                    { 92, 3, new DateTime(2023, 3, 12, 2, 2, 17, 788, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 3, 2, 17, 788, DateTimeKind.Unspecified) },
                    { 93, 7, new DateTime(2023, 3, 21, 0, 35, 12, 619, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 7, 35, 12, 619, DateTimeKind.Unspecified) },
                    { 94, 8, new DateTime(2023, 4, 13, 17, 3, 25, 558, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 19, 3, 25, 558, DateTimeKind.Unspecified) },
                    { 95, 2, new DateTime(2023, 4, 27, 3, 20, 48, 715, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 20, 48, 715, DateTimeKind.Unspecified) },
                    { 96, 6, new DateTime(2023, 3, 18, 21, 43, 5, 412, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 0, 43, 5, 412, DateTimeKind.Unspecified) },
                    { 97, 4, new DateTime(2023, 2, 18, 10, 12, 5, 450, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 12, 12, 5, 450, DateTimeKind.Unspecified) },
                    { 98, 6, new DateTime(2023, 4, 11, 23, 32, 13, 124, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 6, 32, 13, 124, DateTimeKind.Unspecified) },
                    { 99, 6, new DateTime(2023, 5, 31, 20, 17, 27, 269, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 1, 17, 27, 269, DateTimeKind.Unspecified) },
                    { 100, 6, new DateTime(2023, 5, 25, 7, 18, 28, 157, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 14, 18, 28, 157, DateTimeKind.Unspecified) },
                    { 101, 1, new DateTime(2023, 5, 16, 19, 42, 54, 670, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 2, 42, 54, 670, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1748), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1749), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1750), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(1751), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 5, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2448), 700m },
                    { 6, 1, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2498), 700m },
                    { 7, 6, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2513), 700m },
                    { 8, 5, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2525), 700m },
                    { 9, 2, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2537), 700m },
                    { 10, 4, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2551), 700m },
                    { 11, 1, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2564), 700m },
                    { 12, 3, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2576), 700m },
                    { 13, 5, false, new DateTime(2023, 5, 28, 18, 52, 44, 256, DateTimeKind.Local).AddTicks(2587), 700m }
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
