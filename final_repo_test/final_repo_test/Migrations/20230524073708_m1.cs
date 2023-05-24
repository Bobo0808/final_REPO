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
                    { 1, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4385), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4386), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4387), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4388), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "yd35k51k@gmail.com", 0, new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0918838149", "yd35k51k", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "gam7cl4@gmail.com", 1, new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0910896771", "gam7cl4", 0, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "i6i2xf4@gmail.com", 1, new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2, "0911296644", "i6i2xf4", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "20qjrvk@gmail.com", 1, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 2, "0915901281", "20qjrvk", 0, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "nujkp5@gmail.com", 1, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0918786949", "nujkp5", 0, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "4wb5q5ycf@gmail.com", 1, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 1, "0910325100", "4wb5q5ycf", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "hly2jlx3v@gmail.com", 0, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0914077062", "hly2jlx3v", 0, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "iy4wsjnu@gmail.com", 1, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 2, "0918200921", "iy4wsjnu", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4413), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4414), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4415), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4416), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4417), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4418), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4419), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4420), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4420), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4421), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4422), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4423), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4306), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4305), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4319), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4318), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4325), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4324), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4330), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4329), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4335), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4334), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4341), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4340), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4346), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4345), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4350), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4350), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4355), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4355), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4361), "Test", 99, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4360), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 218, 8, "", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 2, 15000, 1, 117, 14, "", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 3, 15000, 1, 107, 14, "", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 4, 15000, 1, 191, 11, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 5, 15000, 1, 163, 19, "", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 6, 15000, 1, 126, 21, "", new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 7, 15000, 1, 94, 19, "", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 15 },
                    { 8, 15000, 1, 160, 17, "", new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 9, 15000, 1, 115, 12, "", new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15 },
                    { 10, 15000, 1, 202, 13, "", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 11, 15000, 1, 120, 12, "", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 12, 15000, 1, 106, 7, "", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 13, 15000, 1, 81, 15, "", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 14, 15000, 1, 222, 24, "", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 17 },
                    { 15, 15000, 1, 44, 11, "", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 16, 15000, 1, 45, 14, "", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 17, 15000, 1, 180, 11, "", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 18, 15000, 1, 232, 12, "", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 19, 15000, 1, 222, 24, "", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 20, 15000, 1, 170, 13, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 21, 15000, 1, 88, 9, "", new DateTime(2022, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 4 },
                    { 22, 15000, 1, 136, 13, "", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 23, 15000, 1, 161, 24, "", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 24, 15000, 1, 139, 17, "", new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 11 },
                    { 25, 15000, 1, 229, 7, "", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 26, 15000, 1, 169, 22, "", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 27, 15000, 1, 179, 13, "", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 28, 15000, 1, 152, 9, "", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 29, 15000, 1, 92, 22, "", new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4376), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4377), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 9, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4182) },
                    { 2, 5, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4232) },
                    { 3, 1, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4234) },
                    { 4, 4, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4236) },
                    { 5, 1, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4237) },
                    { 6, 10, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4239) },
                    { 7, 8, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4240) },
                    { 8, 9, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4242) },
                    { 9, 4, null, "test", true, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4243) },
                    { 10, 6, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4245) },
                    { 11, 9, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4247) },
                    { 12, 5, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4248) },
                    { 13, 2, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4249) },
                    { 14, 7, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4250) },
                    { 15, 4, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4251) },
                    { 16, 10, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4252) },
                    { 17, 7, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4253) },
                    { 18, 4, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4255) },
                    { 19, 8, null, "test", false, new DateTime(2023, 5, 24, 15, 37, 8, 340, DateTimeKind.Local).AddTicks(4256) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 3, 6, 10, 12, 17, 294, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 12, 12, 17, 294, DateTimeKind.Unspecified) },
                    { 2, 6, new DateTime(2023, 5, 6, 18, 41, 23, 188, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 20, 41, 23, 188, DateTimeKind.Unspecified) },
                    { 3, 6, new DateTime(2023, 2, 16, 2, 3, 23, 205, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 8, 3, 23, 205, DateTimeKind.Unspecified) },
                    { 4, 5, new DateTime(2023, 4, 29, 2, 45, 40, 422, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 4, 45, 40, 422, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2023, 5, 25, 8, 0, 2, 895, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 11, 0, 2, 895, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2023, 2, 16, 11, 51, 31, 31, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 14, 51, 31, 31, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(2023, 4, 13, 18, 13, 36, 768, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 1, 13, 36, 768, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 4, 1, 11, 19, 11, 222, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 17, 19, 11, 222, DateTimeKind.Unspecified) },
                    { 9, 6, new DateTime(2023, 5, 1, 12, 12, 25, 174, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 17, 12, 25, 174, DateTimeKind.Unspecified) },
                    { 10, 3, new DateTime(2023, 2, 20, 10, 4, 0, 405, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 20, 4, 0, 405, DateTimeKind.Unspecified) },
                    { 11, 7, new DateTime(2023, 3, 24, 4, 34, 21, 339, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 5, 34, 21, 339, DateTimeKind.Unspecified) },
                    { 12, 7, new DateTime(2023, 2, 25, 8, 15, 47, 960, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 17, 15, 47, 960, DateTimeKind.Unspecified) },
                    { 13, 8, new DateTime(2023, 4, 10, 23, 35, 38, 206, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 4, 35, 38, 206, DateTimeKind.Unspecified) },
                    { 14, 5, new DateTime(2023, 5, 15, 0, 5, 4, 217, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 8, 5, 4, 217, DateTimeKind.Unspecified) },
                    { 15, 9, new DateTime(2023, 2, 8, 15, 11, 29, 338, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 20, 11, 29, 338, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2023, 4, 27, 21, 28, 22, 121, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 4, 28, 22, 121, DateTimeKind.Unspecified) },
                    { 17, 4, new DateTime(2023, 5, 24, 2, 57, 47, 863, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 12, 57, 47, 863, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2023, 2, 2, 18, 8, 47, 74, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 0, 8, 47, 74, DateTimeKind.Unspecified) },
                    { 19, 6, new DateTime(2023, 4, 14, 20, 38, 37, 191, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 22, 38, 37, 191, DateTimeKind.Unspecified) },
                    { 20, 6, new DateTime(2023, 2, 9, 1, 52, 56, 469, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 8, 52, 56, 469, DateTimeKind.Unspecified) },
                    { 21, 7, new DateTime(2023, 4, 7, 11, 47, 50, 539, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 19, 47, 50, 539, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 5, new DateTime(2023, 5, 16, 2, 50, 18, 860, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 8, 50, 18, 860, DateTimeKind.Unspecified) },
                    { 23, 3, new DateTime(2023, 5, 5, 3, 55, 18, 607, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 6, 55, 18, 607, DateTimeKind.Unspecified) },
                    { 24, 2, new DateTime(2023, 4, 10, 2, 18, 33, 108, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 7, 18, 33, 108, DateTimeKind.Unspecified) },
                    { 25, 8, new DateTime(2023, 2, 23, 14, 17, 55, 858, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 23, 17, 55, 858, DateTimeKind.Unspecified) },
                    { 26, 3, new DateTime(2023, 4, 8, 23, 13, 21, 409, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 7, 13, 21, 409, DateTimeKind.Unspecified) },
                    { 27, 8, new DateTime(2023, 5, 24, 21, 53, 31, 580, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 23, 53, 31, 580, DateTimeKind.Unspecified) },
                    { 28, 5, new DateTime(2023, 3, 14, 22, 59, 43, 829, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 3, 59, 43, 829, DateTimeKind.Unspecified) },
                    { 29, 9, new DateTime(2023, 4, 16, 5, 16, 8, 411, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 13, 16, 8, 411, DateTimeKind.Unspecified) },
                    { 30, 6, new DateTime(2023, 4, 10, 22, 41, 59, 811, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 2, 41, 59, 811, DateTimeKind.Unspecified) },
                    { 31, 4, new DateTime(2023, 3, 7, 6, 1, 24, 766, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 11, 1, 24, 766, DateTimeKind.Unspecified) },
                    { 32, 7, new DateTime(2023, 5, 17, 12, 9, 40, 956, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 20, 9, 40, 956, DateTimeKind.Unspecified) },
                    { 33, 5, new DateTime(2023, 3, 17, 14, 29, 58, 774, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 17, 29, 58, 774, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2023, 3, 20, 10, 6, 25, 406, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 12, 6, 25, 406, DateTimeKind.Unspecified) },
                    { 35, 9, new DateTime(2023, 3, 16, 2, 26, 51, 686, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 4, 26, 51, 686, DateTimeKind.Unspecified) },
                    { 36, 6, new DateTime(2023, 4, 16, 15, 59, 59, 225, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 18, 59, 59, 225, DateTimeKind.Unspecified) },
                    { 37, 9, new DateTime(2023, 2, 26, 5, 30, 28, 211, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 15, 30, 28, 211, DateTimeKind.Unspecified) },
                    { 38, 7, new DateTime(2023, 5, 21, 2, 6, 2, 527, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 5, 6, 2, 527, DateTimeKind.Unspecified) },
                    { 39, 5, new DateTime(2023, 2, 25, 15, 55, 31, 832, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 16, 55, 31, 832, DateTimeKind.Unspecified) },
                    { 40, 6, new DateTime(2023, 2, 14, 15, 13, 32, 192, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 1, 13, 32, 192, DateTimeKind.Unspecified) },
                    { 41, 8, new DateTime(2023, 5, 29, 0, 53, 30, 945, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 10, 53, 30, 945, DateTimeKind.Unspecified) },
                    { 42, 9, new DateTime(2023, 2, 11, 11, 7, 14, 739, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 16, 7, 14, 739, DateTimeKind.Unspecified) },
                    { 43, 5, new DateTime(2023, 2, 6, 9, 24, 58, 426, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 17, 24, 58, 426, DateTimeKind.Unspecified) },
                    { 44, 3, new DateTime(2023, 2, 22, 3, 54, 29, 45, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 12, 54, 29, 45, DateTimeKind.Unspecified) },
                    { 45, 4, new DateTime(2023, 2, 8, 8, 43, 3, 547, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 13, 43, 3, 547, DateTimeKind.Unspecified) },
                    { 46, 8, new DateTime(2023, 2, 2, 6, 53, 15, 101, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 12, 53, 15, 101, DateTimeKind.Unspecified) },
                    { 47, 5, new DateTime(2023, 5, 17, 22, 36, 21, 755, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 5, 36, 21, 755, DateTimeKind.Unspecified) },
                    { 48, 4, new DateTime(2023, 3, 7, 21, 25, 50, 427, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 5, 25, 50, 427, DateTimeKind.Unspecified) },
                    { 49, 7, new DateTime(2023, 5, 13, 2, 50, 3, 560, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 6, 50, 3, 560, DateTimeKind.Unspecified) },
                    { 50, 3, new DateTime(2023, 2, 9, 12, 1, 3, 973, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 17, 1, 3, 973, DateTimeKind.Unspecified) },
                    { 51, 4, new DateTime(2023, 3, 19, 21, 37, 12, 405, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 22, 37, 12, 405, DateTimeKind.Unspecified) },
                    { 52, 9, new DateTime(2023, 4, 24, 5, 49, 29, 508, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 14, 49, 29, 508, DateTimeKind.Unspecified) },
                    { 53, 1, new DateTime(2023, 4, 1, 11, 23, 50, 48, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 15, 23, 50, 48, DateTimeKind.Unspecified) },
                    { 54, 2, new DateTime(2023, 4, 10, 4, 55, 11, 392, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 5, 55, 11, 392, DateTimeKind.Unspecified) },
                    { 55, 4, new DateTime(2023, 3, 12, 4, 42, 30, 44, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 5, 42, 30, 44, DateTimeKind.Unspecified) },
                    { 56, 8, new DateTime(2023, 3, 11, 19, 59, 6, 182, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 1, 59, 6, 182, DateTimeKind.Unspecified) },
                    { 57, 1, new DateTime(2023, 5, 31, 18, 50, 34, 850, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 1, 50, 34, 850, DateTimeKind.Unspecified) },
                    { 58, 4, new DateTime(2023, 2, 23, 14, 49, 39, 473, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 21, 49, 39, 473, DateTimeKind.Unspecified) },
                    { 59, 5, new DateTime(2023, 5, 31, 12, 27, 0, 819, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 18, 27, 0, 819, DateTimeKind.Unspecified) },
                    { 60, 9, new DateTime(2023, 4, 22, 4, 59, 4, 654, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 9, 59, 4, 654, DateTimeKind.Unspecified) },
                    { 61, 4, new DateTime(2023, 3, 15, 18, 20, 40, 873, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 22, 20, 40, 873, DateTimeKind.Unspecified) },
                    { 62, 6, new DateTime(2023, 5, 22, 16, 20, 38, 489, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 2, 20, 38, 489, DateTimeKind.Unspecified) },
                    { 63, 8, new DateTime(2023, 5, 10, 23, 56, 19, 26, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 5, 56, 19, 26, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 5, new DateTime(2023, 3, 1, 17, 55, 51, 262, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 3, 55, 51, 262, DateTimeKind.Unspecified) },
                    { 65, 6, new DateTime(2023, 4, 18, 7, 38, 5, 652, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 13, 38, 5, 652, DateTimeKind.Unspecified) },
                    { 66, 1, new DateTime(2023, 3, 7, 1, 43, 19, 158, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 2, 43, 19, 158, DateTimeKind.Unspecified) },
                    { 67, 9, new DateTime(2023, 2, 13, 3, 45, 30, 168, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 12, 45, 30, 168, DateTimeKind.Unspecified) },
                    { 68, 3, new DateTime(2023, 3, 1, 19, 24, 53, 653, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 5, 24, 53, 653, DateTimeKind.Unspecified) },
                    { 69, 2, new DateTime(2023, 3, 9, 5, 19, 19, 755, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 10, 19, 19, 755, DateTimeKind.Unspecified) },
                    { 70, 2, new DateTime(2023, 5, 24, 16, 34, 50, 805, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 21, 34, 50, 805, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 2, 28, 1, 8, 41, 218, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 3, 8, 41, 218, DateTimeKind.Unspecified) },
                    { 72, 8, new DateTime(2023, 2, 27, 7, 25, 23, 401, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 16, 25, 23, 401, DateTimeKind.Unspecified) },
                    { 73, 8, new DateTime(2023, 5, 22, 2, 22, 35, 14, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 4, 22, 35, 14, DateTimeKind.Unspecified) },
                    { 74, 2, new DateTime(2023, 4, 27, 4, 1, 14, 469, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 7, 1, 14, 469, DateTimeKind.Unspecified) },
                    { 75, 2, new DateTime(2023, 3, 4, 14, 0, 0, 182, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 16, 0, 0, 182, DateTimeKind.Unspecified) },
                    { 76, 1, new DateTime(2023, 5, 14, 8, 18, 45, 18, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 12, 18, 45, 18, DateTimeKind.Unspecified) },
                    { 77, 1, new DateTime(2023, 3, 21, 9, 4, 15, 574, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 17, 4, 15, 574, DateTimeKind.Unspecified) },
                    { 78, 5, new DateTime(2023, 3, 1, 16, 51, 18, 97, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 22, 51, 18, 97, DateTimeKind.Unspecified) },
                    { 79, 5, new DateTime(2023, 2, 25, 16, 55, 10, 484, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 2, 55, 10, 484, DateTimeKind.Unspecified) },
                    { 80, 7, new DateTime(2023, 4, 10, 3, 9, 59, 931, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 10, 9, 59, 931, DateTimeKind.Unspecified) },
                    { 81, 9, new DateTime(2023, 4, 6, 20, 0, 53, 302, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 5, 0, 53, 302, DateTimeKind.Unspecified) },
                    { 82, 3, new DateTime(2023, 5, 4, 2, 16, 50, 182, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 11, 16, 50, 182, DateTimeKind.Unspecified) },
                    { 83, 8, new DateTime(2023, 2, 15, 11, 53, 36, 356, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 15, 53, 36, 356, DateTimeKind.Unspecified) },
                    { 84, 5, new DateTime(2023, 2, 7, 0, 46, 5, 629, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 10, 46, 5, 629, DateTimeKind.Unspecified) },
                    { 85, 4, new DateTime(2023, 5, 6, 23, 23, 0, 349, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 5, 23, 0, 349, DateTimeKind.Unspecified) },
                    { 86, 5, new DateTime(2023, 4, 15, 11, 57, 50, 147, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 19, 57, 50, 147, DateTimeKind.Unspecified) },
                    { 87, 9, new DateTime(2023, 2, 19, 13, 30, 7, 536, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 22, 30, 7, 536, DateTimeKind.Unspecified) },
                    { 88, 8, new DateTime(2023, 2, 3, 0, 29, 49, 944, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 5, 29, 49, 944, DateTimeKind.Unspecified) },
                    { 89, 6, new DateTime(2023, 3, 20, 12, 7, 30, 14, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 16, 7, 30, 14, DateTimeKind.Unspecified) },
                    { 90, 5, new DateTime(2023, 5, 6, 9, 53, 16, 353, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 12, 53, 16, 353, DateTimeKind.Unspecified) },
                    { 91, 7, new DateTime(2023, 5, 11, 1, 26, 28, 196, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 5, 26, 28, 196, DateTimeKind.Unspecified) },
                    { 92, 5, new DateTime(2023, 5, 3, 15, 31, 9, 352, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 16, 31, 9, 352, DateTimeKind.Unspecified) },
                    { 93, 6, new DateTime(2023, 4, 2, 3, 33, 56, 809, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 13, 33, 56, 809, DateTimeKind.Unspecified) },
                    { 94, 7, new DateTime(2023, 2, 5, 19, 40, 2, 532, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 5, 40, 2, 532, DateTimeKind.Unspecified) },
                    { 95, 5, new DateTime(2023, 4, 1, 3, 18, 22, 150, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 12, 18, 22, 150, DateTimeKind.Unspecified) },
                    { 96, 3, new DateTime(2023, 2, 12, 0, 2, 24, 236, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 8, 2, 24, 236, DateTimeKind.Unspecified) },
                    { 97, 6, new DateTime(2023, 2, 8, 9, 14, 47, 497, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 15, 14, 47, 497, DateTimeKind.Unspecified) },
                    { 98, 2, new DateTime(2023, 4, 3, 1, 7, 49, 174, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 10, 7, 49, 174, DateTimeKind.Unspecified) },
                    { 99, 6, new DateTime(2023, 5, 12, 15, 0, 2, 134, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 20, 0, 2, 134, DateTimeKind.Unspecified) },
                    { 100, 3, new DateTime(2023, 4, 6, 17, 35, 26, 256, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 0, 35, 26, 256, DateTimeKind.Unspecified) },
                    { 101, 9, new DateTime(2023, 5, 13, 5, 38, 44, 839, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 14, 38, 44, 839, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4434), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4435), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4436), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(4437), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 7, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5070), 700m },
                    { 6, 4, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5089), 700m },
                    { 7, 5, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5099), 700m },
                    { 8, 3, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5108), 700m },
                    { 9, 8, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5116), 700m },
                    { 10, 6, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5151), 700m },
                    { 11, 9, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5160), 700m },
                    { 12, 7, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5168), 700m },
                    { 13, 6, false, new DateTime(2023, 5, 24, 15, 37, 8, 341, DateTimeKind.Local).AddTicks(5176), 700m }
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
