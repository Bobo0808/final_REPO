using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_repo_test.Migrations
{
    public partial class _20230523frankadddata : Migration
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
                    { 1, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4790), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4791), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4792), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4793), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "d5b8fv0br@gmail.com", 0, new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2, "0915573524", "d5b8fv0br", 0, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "evkgq8b@gmail.com", 1, new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2, "0916978278", "evkgq8b", 0, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "8heohb@gmail.com", 0, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 1, "0918550655", "8heohb", 1, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "5sgqv8r2a@gmail.com", 1, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 2, "0916016284", "5sgqv8r2a", 1, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "qb08pemtusp@gmail.com", 0, new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 1, "0918637505", "qb08pemtusp", 1, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "cdz5nlnpc7@gmail.com", 1, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0919826676", "cdz5nlnpc7", 1, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "81bfdxpox1o@gmail.com", 1, new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 1, "0916750466", "81bfdxpox1o", 0, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "5apbgf@gmail.com", 1, new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0917482468", "5apbgf", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4802), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4804), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4805), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4806), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4807), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4808), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4809), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4810), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4811), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4812), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4813), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4814), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4661), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4660), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4675), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4674), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4681), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4681), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4687), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4687), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4694), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4693), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4702), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4702), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4708), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4708), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4714), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4714), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4720), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4720), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4727), "Test", 99, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4726), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 66, 10, "", new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 2, 15000, 1, 184, 7, "", new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 12 },
                    { 3, 15000, 1, 170, 9, "", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 10 },
                    { 4, 15000, 1, 116, 12, "", new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 5, 15000, 1, 112, 14, "", new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 6 },
                    { 6, 15000, 1, 111, 19, "", new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 9 },
                    { 7, 15000, 1, 67, 21, "", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 8, 15000, 1, 64, 13, "", new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 11 },
                    { 9, 15000, 1, 133, 15, "", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 10, 15000, 1, 50, 11, "", new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 11, 15000, 1, 173, 22, "", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 20 },
                    { 12, 15000, 1, 98, 24, "", new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 4 },
                    { 13, 15000, 1, 122, 7, "", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 14, 15000, 1, 172, 10, "", new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 19 },
                    { 15, 15000, 1, 186, 14, "", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 16, 15000, 1, 133, 24, "", new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 17, 15000, 1, 196, 14, "", new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 20 },
                    { 18, 15000, 1, 217, 18, "", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 14 },
                    { 19, 15000, 1, 99, 13, "", new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2 },
                    { 20, 15000, 1, 198, 23, "", new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 21, 15000, 1, 230, 14, "", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 22, 15000, 1, 123, 14, "", new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 23, 15000, 1, 147, 16, "", new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 24, 15000, 1, 229, 11, "", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 25, 15000, 1, 103, 24, "", new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 26, 15000, 1, 218, 23, "", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 27, 15000, 1, 164, 18, "", new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 5 },
                    { 28, 15000, 1, 119, 16, "", new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 3 },
                    { 29, 15000, 1, 185, 16, "", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 18 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4755), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4778), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 6, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3600) },
                    { 2, 9, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3654) },
                    { 3, 7, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3656) },
                    { 4, 7, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3658) },
                    { 5, 2, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3659) },
                    { 6, 7, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3662) },
                    { 7, 5, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3664) },
                    { 8, 8, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3665) },
                    { 9, 6, null, "test", true, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3666) },
                    { 10, 3, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3669) },
                    { 11, 4, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3671) },
                    { 12, 4, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3672) },
                    { 13, 9, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3673) },
                    { 14, 3, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3675) },
                    { 15, 4, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3676) },
                    { 16, 8, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3677) },
                    { 17, 9, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3678) },
                    { 18, 2, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3680) },
                    { 19, 7, null, "test", false, new DateTime(2023, 5, 24, 0, 17, 28, 842, DateTimeKind.Local).AddTicks(3682) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 14, 14, 36, 32, 793, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 21, 36, 32, 793, DateTimeKind.Unspecified) },
                    { 2, 9, new DateTime(2023, 5, 7, 20, 8, 30, 587, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 6, 8, 30, 587, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2023, 5, 19, 17, 19, 22, 250, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 1, 19, 22, 250, DateTimeKind.Unspecified) },
                    { 4, 8, new DateTime(2023, 5, 11, 4, 19, 12, 839, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 11, 19, 12, 839, DateTimeKind.Unspecified) },
                    { 5, 8, new DateTime(2023, 5, 6, 1, 36, 51, 913, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 3, 36, 51, 913, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2023, 5, 17, 18, 36, 29, 604, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 2, 36, 29, 604, DateTimeKind.Unspecified) },
                    { 7, 5, new DateTime(2023, 2, 22, 2, 21, 32, 789, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 3, 21, 32, 789, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 5, 17, 23, 1, 21, 909, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 0, 1, 21, 909, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2023, 3, 7, 17, 49, 29, 230, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 20, 49, 29, 230, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2023, 4, 12, 20, 35, 34, 467, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 4, 35, 34, 467, DateTimeKind.Unspecified) },
                    { 11, 6, new DateTime(2023, 5, 16, 14, 15, 9, 826, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 15, 15, 9, 826, DateTimeKind.Unspecified) },
                    { 12, 8, new DateTime(2023, 3, 24, 4, 50, 58, 436, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 9, 50, 58, 436, DateTimeKind.Unspecified) },
                    { 13, 6, new DateTime(2023, 2, 6, 6, 52, 27, 256, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 15, 52, 27, 256, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 4, 6, 22, 31, 58, 580, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 6, 31, 58, 580, DateTimeKind.Unspecified) },
                    { 15, 6, new DateTime(2023, 2, 2, 1, 54, 16, 431, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 7, 54, 16, 431, DateTimeKind.Unspecified) },
                    { 16, 9, new DateTime(2023, 2, 21, 9, 24, 47, 134, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 19, 24, 47, 134, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2023, 4, 30, 1, 21, 41, 269, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 2, 21, 41, 269, DateTimeKind.Unspecified) },
                    { 18, 8, new DateTime(2023, 4, 25, 18, 36, 46, 203, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 0, 36, 46, 203, DateTimeKind.Unspecified) },
                    { 19, 7, new DateTime(2023, 3, 5, 21, 50, 15, 890, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 3, 50, 15, 890, DateTimeKind.Unspecified) },
                    { 20, 9, new DateTime(2023, 2, 3, 9, 48, 35, 983, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 15, 48, 35, 983, DateTimeKind.Unspecified) },
                    { 21, 5, new DateTime(2023, 4, 25, 8, 46, 43, 222, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 18, 46, 43, 222, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 7, new DateTime(2023, 5, 14, 22, 12, 31, 196, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 3, 12, 31, 196, DateTimeKind.Unspecified) },
                    { 23, 2, new DateTime(2023, 4, 22, 17, 9, 38, 154, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 3, 9, 38, 154, DateTimeKind.Unspecified) },
                    { 24, 4, new DateTime(2023, 3, 27, 5, 47, 36, 254, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 9, 47, 36, 254, DateTimeKind.Unspecified) },
                    { 25, 2, new DateTime(2023, 2, 20, 10, 41, 17, 334, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 20, 41, 17, 334, DateTimeKind.Unspecified) },
                    { 26, 2, new DateTime(2023, 2, 1, 13, 11, 4, 168, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 17, 11, 4, 168, DateTimeKind.Unspecified) },
                    { 27, 3, new DateTime(2023, 2, 10, 4, 11, 39, 778, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 5, 11, 39, 778, DateTimeKind.Unspecified) },
                    { 28, 4, new DateTime(2023, 4, 30, 19, 42, 47, 152, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 2, 42, 47, 152, DateTimeKind.Unspecified) },
                    { 29, 1, new DateTime(2023, 3, 31, 10, 23, 0, 683, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 20, 23, 0, 683, DateTimeKind.Unspecified) },
                    { 30, 5, new DateTime(2023, 3, 10, 19, 3, 38, 290, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 23, 3, 38, 290, DateTimeKind.Unspecified) },
                    { 31, 3, new DateTime(2023, 4, 26, 1, 39, 25, 229, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 8, 39, 25, 229, DateTimeKind.Unspecified) },
                    { 32, 5, new DateTime(2023, 3, 16, 5, 24, 45, 391, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 13, 24, 45, 391, DateTimeKind.Unspecified) },
                    { 33, 8, new DateTime(2023, 3, 21, 8, 29, 9, 741, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 17, 29, 9, 741, DateTimeKind.Unspecified) },
                    { 34, 2, new DateTime(2023, 3, 14, 7, 31, 15, 419, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 16, 31, 15, 419, DateTimeKind.Unspecified) },
                    { 35, 7, new DateTime(2023, 4, 23, 13, 11, 7, 349, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 21, 11, 7, 349, DateTimeKind.Unspecified) },
                    { 36, 9, new DateTime(2023, 4, 30, 12, 24, 36, 896, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 13, 24, 36, 896, DateTimeKind.Unspecified) },
                    { 37, 5, new DateTime(2023, 4, 3, 16, 18, 47, 533, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 17, 18, 47, 533, DateTimeKind.Unspecified) },
                    { 38, 6, new DateTime(2023, 4, 24, 5, 49, 17, 931, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 13, 49, 17, 931, DateTimeKind.Unspecified) },
                    { 39, 3, new DateTime(2023, 5, 7, 13, 59, 48, 422, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 15, 59, 48, 422, DateTimeKind.Unspecified) },
                    { 40, 7, new DateTime(2023, 2, 25, 20, 26, 34, 191, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 1, 26, 34, 191, DateTimeKind.Unspecified) },
                    { 41, 2, new DateTime(2023, 2, 10, 22, 1, 43, 105, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 23, 1, 43, 105, DateTimeKind.Unspecified) },
                    { 42, 9, new DateTime(2023, 2, 24, 16, 36, 50, 820, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 18, 36, 50, 820, DateTimeKind.Unspecified) },
                    { 43, 6, new DateTime(2023, 2, 20, 6, 16, 59, 604, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 9, 16, 59, 604, DateTimeKind.Unspecified) },
                    { 44, 2, new DateTime(2023, 3, 7, 5, 2, 6, 855, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 10, 2, 6, 855, DateTimeKind.Unspecified) },
                    { 45, 5, new DateTime(2023, 2, 22, 11, 26, 51, 758, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 13, 26, 51, 758, DateTimeKind.Unspecified) },
                    { 46, 3, new DateTime(2023, 2, 18, 0, 1, 32, 410, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 6, 1, 32, 410, DateTimeKind.Unspecified) },
                    { 47, 9, new DateTime(2023, 3, 26, 8, 20, 24, 483, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 20, 24, 483, DateTimeKind.Unspecified) },
                    { 48, 4, new DateTime(2023, 4, 5, 17, 49, 25, 384, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 2, 49, 25, 384, DateTimeKind.Unspecified) },
                    { 49, 3, new DateTime(2023, 3, 23, 20, 31, 48, 883, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 0, 31, 48, 883, DateTimeKind.Unspecified) },
                    { 50, 1, new DateTime(2023, 2, 10, 16, 48, 43, 562, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 0, 48, 43, 562, DateTimeKind.Unspecified) },
                    { 51, 9, new DateTime(2023, 2, 20, 8, 59, 29, 78, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 16, 59, 29, 78, DateTimeKind.Unspecified) },
                    { 52, 1, new DateTime(2023, 4, 13, 4, 38, 37, 705, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 14, 38, 37, 705, DateTimeKind.Unspecified) },
                    { 53, 8, new DateTime(2023, 5, 29, 0, 28, 4, 28, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 9, 28, 4, 28, DateTimeKind.Unspecified) },
                    { 54, 7, new DateTime(2023, 2, 27, 10, 10, 42, 691, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 14, 10, 42, 691, DateTimeKind.Unspecified) },
                    { 55, 9, new DateTime(2023, 2, 12, 5, 45, 35, 63, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 12, 45, 35, 63, DateTimeKind.Unspecified) },
                    { 56, 7, new DateTime(2023, 3, 16, 17, 58, 47, 803, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 20, 58, 47, 803, DateTimeKind.Unspecified) },
                    { 57, 6, new DateTime(2023, 4, 18, 15, 19, 7, 660, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 23, 19, 7, 660, DateTimeKind.Unspecified) },
                    { 58, 6, new DateTime(2023, 4, 13, 16, 30, 52, 312, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 2, 30, 52, 312, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2023, 4, 5, 8, 57, 33, 419, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 13, 57, 33, 419, DateTimeKind.Unspecified) },
                    { 60, 9, new DateTime(2023, 4, 6, 3, 37, 26, 507, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 5, 37, 26, 507, DateTimeKind.Unspecified) },
                    { 61, 3, new DateTime(2023, 3, 23, 7, 34, 6, 811, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 11, 34, 6, 811, DateTimeKind.Unspecified) },
                    { 62, 3, new DateTime(2023, 3, 28, 14, 24, 23, 835, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 16, 24, 23, 835, DateTimeKind.Unspecified) },
                    { 63, 3, new DateTime(2023, 3, 20, 1, 12, 15, 661, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 11, 12, 15, 661, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 6, new DateTime(2023, 4, 28, 23, 11, 37, 691, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 0, 11, 37, 691, DateTimeKind.Unspecified) },
                    { 65, 2, new DateTime(2023, 2, 28, 0, 31, 42, 173, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 8, 31, 42, 173, DateTimeKind.Unspecified) },
                    { 66, 4, new DateTime(2023, 4, 9, 18, 17, 19, 270, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 23, 17, 19, 270, DateTimeKind.Unspecified) },
                    { 67, 2, new DateTime(2023, 4, 9, 11, 37, 15, 142, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 17, 37, 15, 142, DateTimeKind.Unspecified) },
                    { 68, 6, new DateTime(2023, 2, 3, 6, 55, 48, 292, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 7, 55, 48, 292, DateTimeKind.Unspecified) },
                    { 69, 1, new DateTime(2023, 2, 27, 21, 52, 1, 466, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 4, 52, 1, 466, DateTimeKind.Unspecified) },
                    { 70, 2, new DateTime(2023, 5, 12, 14, 43, 44, 186, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 0, 43, 44, 186, DateTimeKind.Unspecified) },
                    { 71, 7, new DateTime(2023, 5, 19, 17, 53, 18, 145, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 3, 53, 18, 145, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 3, 25, 11, 29, 41, 245, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 16, 29, 41, 245, DateTimeKind.Unspecified) },
                    { 73, 5, new DateTime(2023, 4, 25, 5, 59, 31, 650, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 9, 59, 31, 650, DateTimeKind.Unspecified) },
                    { 74, 5, new DateTime(2023, 5, 16, 7, 5, 47, 894, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 16, 5, 47, 894, DateTimeKind.Unspecified) },
                    { 75, 7, new DateTime(2023, 3, 4, 14, 45, 9, 78, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 23, 45, 9, 78, DateTimeKind.Unspecified) },
                    { 76, 7, new DateTime(2023, 2, 9, 16, 20, 37, 327, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 21, 20, 37, 327, DateTimeKind.Unspecified) },
                    { 77, 9, new DateTime(2023, 4, 24, 1, 5, 25, 924, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 10, 5, 25, 924, DateTimeKind.Unspecified) },
                    { 78, 7, new DateTime(2023, 3, 7, 0, 34, 1, 860, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 7, 34, 1, 860, DateTimeKind.Unspecified) },
                    { 79, 8, new DateTime(2023, 5, 28, 15, 10, 15, 719, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 18, 10, 15, 719, DateTimeKind.Unspecified) },
                    { 80, 7, new DateTime(2023, 4, 17, 21, 0, 23, 300, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 6, 0, 23, 300, DateTimeKind.Unspecified) },
                    { 81, 6, new DateTime(2023, 3, 11, 16, 41, 48, 347, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 20, 41, 48, 347, DateTimeKind.Unspecified) },
                    { 82, 1, new DateTime(2023, 5, 20, 6, 49, 35, 955, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 15, 49, 35, 955, DateTimeKind.Unspecified) },
                    { 83, 8, new DateTime(2023, 3, 13, 12, 19, 15, 171, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 17, 19, 15, 171, DateTimeKind.Unspecified) },
                    { 84, 8, new DateTime(2023, 4, 12, 19, 42, 47, 133, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 22, 42, 47, 133, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2023, 4, 6, 1, 17, 31, 898, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 2, 17, 31, 898, DateTimeKind.Unspecified) },
                    { 86, 7, new DateTime(2023, 5, 22, 22, 56, 58, 570, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 1, 56, 58, 570, DateTimeKind.Unspecified) },
                    { 87, 1, new DateTime(2023, 4, 4, 2, 31, 50, 355, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 4, 31, 50, 355, DateTimeKind.Unspecified) },
                    { 88, 6, new DateTime(2023, 5, 4, 20, 9, 1, 294, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 1, 9, 1, 294, DateTimeKind.Unspecified) },
                    { 89, 5, new DateTime(2023, 4, 6, 21, 37, 13, 230, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 22, 37, 13, 230, DateTimeKind.Unspecified) },
                    { 90, 6, new DateTime(2023, 3, 19, 10, 13, 0, 501, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 13, 13, 0, 501, DateTimeKind.Unspecified) },
                    { 91, 9, new DateTime(2023, 2, 3, 7, 43, 12, 415, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 10, 43, 12, 415, DateTimeKind.Unspecified) },
                    { 92, 9, new DateTime(2023, 5, 20, 15, 39, 18, 531, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 17, 39, 18, 531, DateTimeKind.Unspecified) },
                    { 93, 6, new DateTime(2023, 4, 28, 21, 51, 58, 784, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 5, 51, 58, 784, DateTimeKind.Unspecified) },
                    { 94, 2, new DateTime(2023, 4, 18, 2, 20, 30, 781, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 7, 20, 30, 781, DateTimeKind.Unspecified) },
                    { 95, 3, new DateTime(2023, 3, 25, 23, 28, 40, 936, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 7, 28, 40, 936, DateTimeKind.Unspecified) },
                    { 96, 4, new DateTime(2023, 2, 19, 7, 53, 18, 838, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 8, 53, 18, 838, DateTimeKind.Unspecified) },
                    { 97, 9, new DateTime(2023, 3, 12, 2, 32, 8, 460, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 7, 32, 8, 460, DateTimeKind.Unspecified) },
                    { 98, 2, new DateTime(2023, 5, 15, 2, 52, 32, 893, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 8, 52, 32, 893, DateTimeKind.Unspecified) },
                    { 99, 4, new DateTime(2023, 2, 4, 5, 57, 32, 222, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 10, 57, 32, 222, DateTimeKind.Unspecified) },
                    { 100, 5, new DateTime(2023, 2, 18, 6, 15, 56, 452, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 15, 15, 56, 452, DateTimeKind.Unspecified) },
                    { 101, 3, new DateTime(2023, 3, 25, 16, 30, 33, 279, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 22, 30, 33, 279, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4826), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4828), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4828), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(4829), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 8, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5373), 700m },
                    { 6, 7, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5389), 700m },
                    { 7, 7, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5398), 700m },
                    { 8, 4, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5407), 700m },
                    { 9, 3, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5438), 700m },
                    { 10, 4, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5451), 700m },
                    { 11, 8, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5462), 700m },
                    { 12, 4, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5471), 700m },
                    { 13, 1, false, new DateTime(2023, 5, 24, 0, 17, 28, 843, DateTimeKind.Local).AddTicks(5480), 700m }
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
