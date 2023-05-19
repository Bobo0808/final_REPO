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
                    { 1, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7168), "100元換200點", false, "點數.png", "100元換200點", 100 },
                    { 2, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7170), "200元換350點", false, "點數.png", "200元換350點", 200 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ij2l47nwt5g@gmail.com", 1, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0918430822", "ij2l47nwt5g", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "fylln7@gmail.com", 1, new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0910268780", "fylln7", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "7rdhwiex@gmail.com", 1, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0910649180", "7rdhwiex", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "3xrqe52ni@gmail.com", 0, new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0916393364", "3xrqe52ni", 1, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "frw19aov@gmail.com", 1, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0910477501", "frw19aov", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "kfo3et75@gmail.com", 1, new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 1, "0913189802", "kfo3et75", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "7qmisnf78g@gmail.com", 1, new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 1, "0912080205", "7qmisnf78g", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "jedmhf4966y@gmail.com", 1, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0915773132", "jedmhf4966y", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7179), "Regular Fit反摺袖襯衫", false, 0, "1.jpg", 99, "反摺袖襯衫", 699, 1 },
                    { 2, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7181), "Regular Fit棉麻短袖襯衫", false, 0, "2.jpg", 99, "短袖襯衫", 499, 0 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7060), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7059), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7078), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7077), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7083), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7083), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7089), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7088), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7093), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7093), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7099), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7099), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7122), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7122), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7127), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7127), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7132), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7132), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7137), "Test", 99, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7137), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 131, 17, "", new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 10 },
                    { 2, 15000, 1, 226, 21, "", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 3, 15000, 1, 184, 12, "", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 6 },
                    { 4, 15000, 1, 185, 8, "", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 5, 15000, 1, 106, 12, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 6, 15000, 1, 96, 10, "", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 7, 15000, 1, 162, 11, "", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 8, 15000, 1, 83, 13, "", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 9, 15000, 1, 132, 11, "", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 5 },
                    { 10, 15000, 1, 91, 14, "", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 },
                    { 11, 15000, 1, 30, 23, "", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 12, 15000, 1, 57, 9, "", new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 6 },
                    { 13, 15000, 1, 66, 7, "", new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 9 },
                    { 14, 15000, 1, 194, 24, "", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 6 },
                    { 15, 15000, 1, 174, 20, "", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 18 },
                    { 16, 15000, 1, 31, 7, "", new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 17, 15000, 1, 189, 16, "", new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 18, 15000, 1, 53, 15, "", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 19, 15000, 1, 231, 22, "", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 3 },
                    { 20, 15000, 1, 53, 13, "", new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 21, 15000, 1, 75, 18, "", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 22, 15000, 1, 94, 17, "", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 23, 15000, 1, 237, 11, "", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 14 },
                    { 24, 15000, 1, 144, 17, "", new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 25, 15000, 1, 226, 17, "", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 26, 15000, 1, 104, 15, "", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 5 },
                    { 27, 15000, 1, 90, 7, "", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 28, 15000, 1, 50, 21, "", new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 12 },
                    { 29, 15000, 1, 125, 19, "", new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7158), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7161), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 8, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6632) },
                    { 2, 2, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6675) },
                    { 3, 2, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6677) },
                    { 4, 3, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6679) },
                    { 5, 1, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6680) },
                    { 6, 5, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6683) },
                    { 7, 7, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6684) },
                    { 8, 10, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6686) },
                    { 9, 10, null, "test", true, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6687) },
                    { 10, 1, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6689) },
                    { 11, 1, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6691) },
                    { 12, 7, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6693) },
                    { 13, 8, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6694) },
                    { 14, 2, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6695) },
                    { 15, 3, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6697) },
                    { 16, 6, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6698) },
                    { 17, 10, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6700) },
                    { 18, 1, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6701) },
                    { 19, 2, null, "test", false, new DateTime(2023, 5, 19, 16, 33, 42, 442, DateTimeKind.Local).AddTicks(6703) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 27, 11, 11, 26, 635, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 19, 11, 26, 635, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 3, 31, 11, 34, 45, 497, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 17, 34, 45, 497, DateTimeKind.Unspecified) },
                    { 3, 9, new DateTime(2023, 2, 22, 16, 54, 54, 445, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 2, 54, 54, 445, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 3, 6, 16, 51, 11, 937, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 18, 51, 11, 937, DateTimeKind.Unspecified) },
                    { 5, 9, new DateTime(2023, 4, 3, 13, 40, 18, 85, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 16, 40, 18, 85, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2023, 5, 17, 2, 16, 29, 710, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 12, 16, 29, 710, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(2023, 5, 19, 23, 1, 16, 483, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 6, 1, 16, 483, DateTimeKind.Unspecified) },
                    { 8, 9, new DateTime(2023, 3, 18, 19, 33, 46, 633, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 23, 33, 46, 633, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(2023, 3, 16, 11, 36, 57, 630, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 12, 36, 57, 630, DateTimeKind.Unspecified) },
                    { 10, 7, new DateTime(2023, 5, 5, 16, 58, 44, 260, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 1, 58, 44, 260, DateTimeKind.Unspecified) },
                    { 11, 5, new DateTime(2023, 4, 22, 19, 5, 4, 707, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 2, 5, 4, 707, DateTimeKind.Unspecified) },
                    { 12, 3, new DateTime(2023, 2, 10, 17, 29, 19, 173, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 1, 29, 19, 173, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2023, 4, 11, 15, 20, 31, 259, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 23, 20, 31, 259, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2023, 5, 10, 19, 31, 47, 933, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 23, 31, 47, 933, DateTimeKind.Unspecified) },
                    { 15, 9, new DateTime(2023, 4, 9, 10, 45, 5, 295, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 14, 45, 5, 295, DateTimeKind.Unspecified) },
                    { 16, 8, new DateTime(2023, 4, 13, 19, 30, 41, 997, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 20, 30, 41, 997, DateTimeKind.Unspecified) },
                    { 17, 3, new DateTime(2023, 5, 8, 4, 32, 2, 355, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 11, 32, 2, 355, DateTimeKind.Unspecified) },
                    { 18, 6, new DateTime(2023, 5, 20, 13, 48, 22, 974, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 20, 48, 22, 974, DateTimeKind.Unspecified) },
                    { 19, 6, new DateTime(2023, 5, 30, 6, 21, 24, 210, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 10, 21, 24, 210, DateTimeKind.Unspecified) },
                    { 20, 4, new DateTime(2023, 4, 12, 14, 49, 41, 712, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 17, 49, 41, 712, DateTimeKind.Unspecified) },
                    { 21, 9, new DateTime(2023, 3, 3, 5, 5, 30, 448, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 6, 5, 30, 448, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 5, new DateTime(2023, 2, 25, 0, 50, 55, 39, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 9, 50, 55, 39, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2023, 2, 15, 19, 58, 57, 689, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 1, 58, 57, 689, DateTimeKind.Unspecified) },
                    { 24, 8, new DateTime(2023, 4, 2, 22, 50, 22, 132, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 0, 50, 22, 132, DateTimeKind.Unspecified) },
                    { 25, 5, new DateTime(2023, 2, 25, 10, 48, 24, 354, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 15, 48, 24, 354, DateTimeKind.Unspecified) },
                    { 26, 6, new DateTime(2023, 3, 26, 10, 34, 18, 833, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 12, 34, 18, 833, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 3, 14, 2, 32, 2, 913, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 5, 32, 2, 913, DateTimeKind.Unspecified) },
                    { 28, 5, new DateTime(2023, 4, 9, 12, 54, 59, 765, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 15, 54, 59, 765, DateTimeKind.Unspecified) },
                    { 29, 2, new DateTime(2023, 4, 13, 2, 27, 27, 505, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 10, 27, 27, 505, DateTimeKind.Unspecified) },
                    { 30, 4, new DateTime(2023, 5, 5, 17, 6, 15, 189, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 23, 6, 15, 189, DateTimeKind.Unspecified) },
                    { 31, 4, new DateTime(2023, 3, 22, 20, 31, 36, 200, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 4, 31, 36, 200, DateTimeKind.Unspecified) },
                    { 32, 8, new DateTime(2023, 5, 12, 19, 41, 6, 11, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 4, 41, 6, 11, DateTimeKind.Unspecified) },
                    { 33, 2, new DateTime(2023, 4, 26, 23, 36, 19, 256, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 4, 36, 19, 256, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2023, 3, 20, 0, 18, 29, 436, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 1, 18, 29, 436, DateTimeKind.Unspecified) },
                    { 35, 3, new DateTime(2023, 2, 5, 19, 54, 7, 673, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 22, 54, 7, 673, DateTimeKind.Unspecified) },
                    { 36, 4, new DateTime(2023, 5, 4, 0, 43, 14, 372, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 8, 43, 14, 372, DateTimeKind.Unspecified) },
                    { 37, 2, new DateTime(2023, 4, 26, 8, 35, 23, 210, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 9, 35, 23, 210, DateTimeKind.Unspecified) },
                    { 38, 4, new DateTime(2023, 2, 19, 20, 23, 38, 101, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 4, 23, 38, 101, DateTimeKind.Unspecified) },
                    { 39, 8, new DateTime(2023, 5, 23, 17, 19, 17, 68, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 19, 19, 17, 68, DateTimeKind.Unspecified) },
                    { 40, 7, new DateTime(2023, 2, 16, 9, 39, 52, 718, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 13, 39, 52, 718, DateTimeKind.Unspecified) },
                    { 41, 5, new DateTime(2023, 2, 15, 18, 36, 45, 63, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 20, 36, 45, 63, DateTimeKind.Unspecified) },
                    { 42, 6, new DateTime(2023, 4, 17, 10, 56, 19, 492, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 15, 56, 19, 492, DateTimeKind.Unspecified) },
                    { 43, 9, new DateTime(2023, 2, 12, 13, 17, 45, 215, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 15, 17, 45, 215, DateTimeKind.Unspecified) },
                    { 44, 9, new DateTime(2023, 4, 16, 18, 9, 40, 336, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 20, 9, 40, 336, DateTimeKind.Unspecified) },
                    { 45, 5, new DateTime(2023, 5, 11, 22, 38, 46, 107, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 2, 38, 46, 107, DateTimeKind.Unspecified) },
                    { 46, 6, new DateTime(2023, 5, 3, 5, 54, 59, 385, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 13, 54, 59, 385, DateTimeKind.Unspecified) },
                    { 47, 5, new DateTime(2023, 4, 29, 18, 34, 41, 647, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 2, 34, 41, 647, DateTimeKind.Unspecified) },
                    { 48, 3, new DateTime(2023, 5, 12, 21, 7, 0, 154, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 5, 7, 0, 154, DateTimeKind.Unspecified) },
                    { 49, 6, new DateTime(2023, 2, 11, 15, 26, 50, 445, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 16, 26, 50, 445, DateTimeKind.Unspecified) },
                    { 50, 4, new DateTime(2023, 3, 26, 12, 22, 29, 949, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 22, 29, 949, DateTimeKind.Unspecified) },
                    { 51, 4, new DateTime(2023, 3, 11, 15, 18, 6, 984, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 22, 18, 6, 984, DateTimeKind.Unspecified) },
                    { 52, 2, new DateTime(2023, 4, 22, 1, 4, 38, 241, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 7, 4, 38, 241, DateTimeKind.Unspecified) },
                    { 53, 6, new DateTime(2023, 3, 6, 2, 19, 57, 622, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 5, 19, 57, 622, DateTimeKind.Unspecified) },
                    { 54, 9, new DateTime(2023, 2, 13, 21, 56, 40, 697, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 5, 56, 40, 697, DateTimeKind.Unspecified) },
                    { 55, 5, new DateTime(2023, 4, 24, 6, 38, 0, 217, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 16, 38, 0, 217, DateTimeKind.Unspecified) },
                    { 56, 6, new DateTime(2023, 5, 8, 4, 16, 9, 933, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 6, 16, 9, 933, DateTimeKind.Unspecified) },
                    { 57, 1, new DateTime(2023, 2, 5, 9, 0, 41, 853, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 12, 0, 41, 853, DateTimeKind.Unspecified) },
                    { 58, 8, new DateTime(2023, 2, 22, 0, 23, 8, 848, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 7, 23, 8, 848, DateTimeKind.Unspecified) },
                    { 59, 3, new DateTime(2023, 2, 18, 3, 53, 47, 64, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 10, 53, 47, 64, DateTimeKind.Unspecified) },
                    { 60, 6, new DateTime(2023, 5, 28, 7, 57, 21, 502, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 16, 57, 21, 502, DateTimeKind.Unspecified) },
                    { 61, 1, new DateTime(2023, 2, 15, 2, 24, 37, 745, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 7, 24, 37, 745, DateTimeKind.Unspecified) },
                    { 62, 2, new DateTime(2023, 3, 18, 2, 20, 25, 480, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 7, 20, 25, 480, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 5, 7, 8, 19, 44, 15, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 11, 19, 44, 15, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 2, new DateTime(2023, 5, 3, 9, 32, 49, 311, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 18, 32, 49, 311, DateTimeKind.Unspecified) },
                    { 65, 9, new DateTime(2023, 4, 21, 23, 24, 50, 301, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 9, 24, 50, 301, DateTimeKind.Unspecified) },
                    { 66, 9, new DateTime(2023, 5, 14, 10, 48, 47, 865, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 16, 48, 47, 865, DateTimeKind.Unspecified) },
                    { 67, 4, new DateTime(2023, 3, 22, 18, 5, 34, 381, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 20, 5, 34, 381, DateTimeKind.Unspecified) },
                    { 68, 3, new DateTime(2023, 4, 24, 17, 46, 8, 604, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 22, 46, 8, 604, DateTimeKind.Unspecified) },
                    { 69, 9, new DateTime(2023, 4, 18, 9, 2, 23, 775, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 19, 2, 23, 775, DateTimeKind.Unspecified) },
                    { 70, 7, new DateTime(2023, 5, 2, 6, 32, 36, 250, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 15, 32, 36, 250, DateTimeKind.Unspecified) },
                    { 71, 8, new DateTime(2023, 3, 19, 2, 36, 2, 634, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 4, 36, 2, 634, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 3, 5, 6, 51, 29, 301, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 10, 51, 29, 301, DateTimeKind.Unspecified) },
                    { 73, 6, new DateTime(2023, 2, 8, 7, 0, 10, 660, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 12, 0, 10, 660, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 2, 6, 4, 29, 4, 250, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 14, 29, 4, 250, DateTimeKind.Unspecified) },
                    { 75, 6, new DateTime(2023, 4, 30, 12, 44, 10, 206, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 18, 44, 10, 206, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 4, 3, 13, 58, 28, 244, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 18, 58, 28, 244, DateTimeKind.Unspecified) },
                    { 77, 5, new DateTime(2023, 5, 12, 9, 27, 2, 615, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 17, 27, 2, 615, DateTimeKind.Unspecified) },
                    { 78, 4, new DateTime(2023, 2, 25, 1, 2, 22, 551, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 5, 2, 22, 551, DateTimeKind.Unspecified) },
                    { 79, 9, new DateTime(2023, 3, 15, 2, 6, 25, 657, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 3, 6, 25, 657, DateTimeKind.Unspecified) },
                    { 80, 6, new DateTime(2023, 4, 6, 17, 55, 14, 605, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 0, 55, 14, 605, DateTimeKind.Unspecified) },
                    { 81, 2, new DateTime(2023, 4, 7, 22, 54, 15, 439, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 4, 54, 15, 439, DateTimeKind.Unspecified) },
                    { 82, 8, new DateTime(2023, 4, 15, 16, 59, 34, 75, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 0, 59, 34, 75, DateTimeKind.Unspecified) },
                    { 83, 3, new DateTime(2023, 4, 22, 22, 44, 34, 998, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 7, 44, 34, 998, DateTimeKind.Unspecified) },
                    { 84, 9, new DateTime(2023, 3, 4, 15, 27, 25, 713, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 0, 27, 25, 713, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 3, 18, 5, 38, 52, 870, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 7, 38, 52, 870, DateTimeKind.Unspecified) },
                    { 86, 6, new DateTime(2023, 4, 19, 14, 39, 3, 452, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 15, 39, 3, 452, DateTimeKind.Unspecified) },
                    { 87, 8, new DateTime(2023, 4, 23, 15, 56, 39, 388, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 1, 56, 39, 388, DateTimeKind.Unspecified) },
                    { 88, 9, new DateTime(2023, 5, 8, 1, 59, 1, 684, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 6, 59, 1, 684, DateTimeKind.Unspecified) },
                    { 89, 5, new DateTime(2023, 5, 28, 20, 3, 43, 383, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 3, 3, 43, 383, DateTimeKind.Unspecified) },
                    { 90, 7, new DateTime(2023, 5, 19, 1, 12, 50, 364, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 5, 12, 50, 364, DateTimeKind.Unspecified) },
                    { 91, 4, new DateTime(2023, 4, 15, 21, 49, 45, 910, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 22, 49, 45, 910, DateTimeKind.Unspecified) },
                    { 92, 3, new DateTime(2023, 3, 21, 13, 54, 45, 629, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 22, 54, 45, 629, DateTimeKind.Unspecified) },
                    { 93, 2, new DateTime(2023, 2, 17, 0, 15, 29, 44, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 10, 15, 29, 44, DateTimeKind.Unspecified) },
                    { 94, 5, new DateTime(2023, 3, 24, 9, 41, 13, 693, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 13, 41, 13, 693, DateTimeKind.Unspecified) },
                    { 95, 4, new DateTime(2023, 3, 30, 3, 55, 39, 667, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 13, 55, 39, 667, DateTimeKind.Unspecified) },
                    { 96, 2, new DateTime(2023, 4, 2, 19, 24, 58, 12, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 2, 24, 58, 12, DateTimeKind.Unspecified) },
                    { 97, 5, new DateTime(2023, 2, 8, 0, 51, 42, 844, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 1, 51, 42, 844, DateTimeKind.Unspecified) },
                    { 98, 7, new DateTime(2023, 4, 24, 10, 53, 21, 414, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 20, 53, 21, 414, DateTimeKind.Unspecified) },
                    { 99, 1, new DateTime(2023, 2, 5, 22, 21, 48, 530, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 3, 21, 48, 530, DateTimeKind.Unspecified) },
                    { 100, 9, new DateTime(2023, 4, 30, 18, 23, 29, 546, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 23, 23, 29, 546, DateTimeKind.Unspecified) },
                    { 101, 4, new DateTime(2023, 5, 14, 5, 17, 23, 648, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 15, 17, 23, 648, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7189), 2396m },
                    { 2, 1, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7190), 1198m },
                    { 3, 1, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7836), 699m },
                    { 4, 1, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7847), 699m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 3, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7874), 699m },
                    { 6, 4, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7890), 699m },
                    { 7, 5, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7897), 699m },
                    { 8, 4, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7906), 699m },
                    { 9, 5, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7914), 699m },
                    { 10, 6, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7929), 699m },
                    { 11, 5, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7937), 699m },
                    { 12, 4, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7945), 699m },
                    { 13, 9, false, new DateTime(2023, 5, 19, 16, 33, 42, 443, DateTimeKind.Local).AddTicks(7952), 699m }
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
