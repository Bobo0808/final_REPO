using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenLife.Migrations
{
    public partial class _20230524bnn : Migration
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
                    { 1, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5725), "100元換150點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "100元換150點", 100 },
                    { 2, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5726), "200元換350點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "200元換350點", 200 },
                    { 3, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5727), "400元換650點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "400元換650點", 400 },
                    { 4, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5727), "500元換800點", false, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png", "500元換800點", 500 }
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
                    { 2, "高雄市前金區", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "81vglj@gmail.com", 0, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 1, "0911128004", "81vglj", 1, "2", true, false, "user" },
                    { 3, "高雄市前金區", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "5jxn8kzkez@gmail.com", 0, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 1, "0915161579", "5jxn8kzkez", 1, "3", true, false, "user" },
                    { 4, "高雄市前金區", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "b323ij0@gmail.com", 0, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 1, "0912582204", "b323ij0", 0, "4", true, false, "user" },
                    { 5, "高雄市前金區", new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0rrk4zmwfrp@gmail.com", 1, new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 1, "0913332647", "0rrk4zmwfrp", 1, "5", true, false, "user" },
                    { 6, "高雄市前金區", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2o0ny6xh@gmail.com", 0, new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 2, "0915362260", "2o0ny6xh", 1, "6", true, false, "user" },
                    { 7, "高雄市前金區", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "6sg2i9@gmail.com", 0, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 2, "0911161206", "6sg2i9", 0, "7", true, false, "user" },
                    { 8, "高雄市前金區", new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "jik68qp470b@gmail.com", 0, new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", 2, "0916708847", "jik68qp470b", 1, "8", true, false, "user" },
                    { 9, "高雄市前金區", new DateTime(2022, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "f5kcea8au6u@gmail.com", 1, new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", 1, "0917155952", "f5kcea8au6u", 0, "9", true, false, "user" }
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
                    { 1, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5737), "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png", 99, "博麗 靈夢", 750, 0 },
                    { 2, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5739), "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png", 99, "霧雨 魔理沙", 750, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "P_ID", "P_Date", "P_Describe", "P_Discontinuted", "P_Discount", "P_Image", "P_Instock", "P_Name", "P_Price", "P_ProductType" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5757), "守矢神社的風祝。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png", 99, "東風谷 早苗", 750, 0 },
                    { 4, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5758), "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png", 99, "帕秋莉·諾雷姬", 750, 0 },
                    { 5, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5759), "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png", 99, "十六夜 咲夜", 750, 0 },
                    { 6, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5760), "小精靈。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png", 99, "小精靈", 350, 3 },
                    { 7, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5760), "想被踩踩看嗎?。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png", 99, "腳", 500, 3 },
                    { 8, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5761), "鬼魂，可參加萬聖節。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png", 99, "鬼魂", 500, 3 },
                    { 9, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5762), "為了生存而長出腳的香菇。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png", 99, "香菇", 500, 3 },
                    { 10, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5763), "能快速移動的烏龜。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png", 99, "烏龜", 600, 2 },
                    { 11, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5764), "就是那位能預測冠軍的章魚哥。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png", 99, "章魚", 600, 2 },
                    { 12, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5764), "黑色的烏鴉。", false, 0, "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png", 99, "烏鴉", 600, 2 }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "A_ID", "A_Coin", "A_Email", "A_Gender", "A_Name", "A_NickName", "A_Phone", "A_RegisteredAt", "A_add", "A_level", "Birthday", "P_id", "PasswordHash", "PasswordRestToken", "PasswordSalt", "ResetTokenExpries", "UserName", "UserPWD", "VerifiedAt", "VerifycationToken" },
                values: new object[,]
                {
                    { 1, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5635), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5634), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 2, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5651), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5650), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 3, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5657), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5657), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 4, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5662), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5662), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 5, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5668), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5667), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 6, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5674), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5673), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 7, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5679), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5678), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 8, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5684), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5683), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 9, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5689), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5688), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null },
                    { 10, 999999, "Test@gmail.com", 0, "Test", "Test", "0900000000", new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5694), "Test", 99, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5694), 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, "Test", "Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Ad_ID", "AD_FinalPaymentAmount", "Ad_ActiveStatus", "Ad_Clicks", "Ad_DayCount", "Ad_Description", "Ad_EndTime", "Ad_ImageURL", "Ad_PaymentDueDate", "Ad_StartTime", "Ad_TargetURL", "Ad_TimeOfPayment", "CaseID", "OS_ID", "PartnerID" },
                values: new object[,]
                {
                    { 1, 15000, 1, 38, 14, "", new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_1.jpg", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com1", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 20 },
                    { 2, 15000, 1, 178, 12, "", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_2.jpg", new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com2", new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 8 },
                    { 3, 15000, 1, 216, 12, "", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_3.jpg", new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com3", new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 4 },
                    { 4, 15000, 1, 158, 17, "", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_4.jpg", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com4", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 5, 15000, 1, 85, 24, "", new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_5.jpg", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com5", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 6, 15000, 1, 223, 14, "", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_6.jpg", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com6", new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 5 },
                    { 7, 15000, 1, 210, 16, "", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_7.jpg", new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com7", new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 17 },
                    { 8, 15000, 1, 129, 15, "", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_8.jpg", new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com8", new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 14 },
                    { 9, 15000, 1, 40, 7, "", new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_9.jpg", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com9", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 20 },
                    { 10, 15000, 1, 111, 10, "", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_10.jpg", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com10", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 15 },
                    { 11, 15000, 1, 63, 18, "", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_11.jpg", new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com11", new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 11 },
                    { 12, 15000, 1, 55, 11, "", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_12.jpg", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com12", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 19 },
                    { 13, 15000, 1, 193, 18, "", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_13.jpg", new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com13", new DateTime(2022, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 7 },
                    { 14, 15000, 1, 57, 15, "", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_14.jpg", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com14", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 11 },
                    { 15, 15000, 1, 153, 17, "", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_15.jpg", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com15", new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 8 },
                    { 16, 15000, 1, 147, 20, "", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_16.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com16", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 6 },
                    { 17, 15000, 1, 128, 19, "", new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_17.jpg", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com17", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 18, 15000, 1, 43, 21, "", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_18.jpg", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com18", new DateTime(2022, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 20 },
                    { 19, 15000, 1, 148, 11, "", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_19.jpg", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com19", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 10 },
                    { 20, 15000, 1, 223, 18, "", new DateTime(2022, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_20.jpg", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com20", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 21, 15000, 1, 202, 11, "", new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_21.jpg", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com21", new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 16 },
                    { 22, 15000, 1, 190, 9, "", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_22.jpg", new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com22", new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 18 },
                    { 23, 15000, 1, 167, 19, "", new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_23.jpg", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com23", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 24, 15000, 1, 32, 24, "", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_24.jpg", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com24", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 15 },
                    { 25, 15000, 1, 220, 9, "", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_25.jpg", new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com25", new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 9 },
                    { 26, 15000, 1, 45, 19, "", new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_26.jpg", new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com26", new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 16 },
                    { 27, 15000, 1, 223, 21, "", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_27.jpg", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com27", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 18 },
                    { 28, 15000, 1, 85, 21, "", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_28.jpg", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com28", new DateTime(2022, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 29, 15000, 1, 66, 20, "", new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD_29.jpg", new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://exmple/.com29", new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "CardOrders",
                columns: new[] { "CO_ID", "A_ID", "CA_ID", "CO_Cancel", "CO_Date", "CO_Quantity", "CO_Sum", "CT_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5713), 1, 100, 1 },
                    { 2, 1, 2, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5714), 2, 400, 2 }
                });

            migrationBuilder.InsertData(
                table: "DebugLogs",
                columns: new[] { "D_ID", "A_ID", "D_Comment", "D_event", "D_isSolved", "D_time" },
                values: new object[,]
                {
                    { 1, 9, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4911) },
                    { 2, 4, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4970) },
                    { 3, 6, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4972) },
                    { 4, 10, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4973) },
                    { 5, 9, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4975) },
                    { 6, 6, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4977) },
                    { 7, 8, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4978) },
                    { 8, 3, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4979) },
                    { 9, 10, null, "test", true, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4980) },
                    { 10, 5, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4983) },
                    { 11, 4, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4984) },
                    { 12, 8, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4985) },
                    { 13, 5, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4986) },
                    { 14, 8, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4987) },
                    { 15, 9, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4989) },
                    { 16, 9, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4990) },
                    { 17, 4, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4990) },
                    { 18, 9, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4992) },
                    { 19, 8, null, "test", false, new DateTime(2023, 5, 24, 9, 48, 4, 730, DateTimeKind.Local).AddTicks(4993) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 2, 6, 20, 38, 3, 141, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 21, 38, 3, 141, DateTimeKind.Unspecified) },
                    { 2, 4, new DateTime(2023, 5, 20, 0, 21, 40, 241, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 7, 21, 40, 241, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2023, 2, 23, 16, 31, 39, 212, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 2, 31, 39, 212, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2023, 5, 16, 16, 0, 49, 18, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 17, 0, 49, 18, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(2023, 5, 4, 11, 41, 18, 903, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 16, 41, 18, 903, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2023, 5, 8, 15, 42, 53, 277, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 19, 42, 53, 277, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 3, 16, 13, 37, 22, 67, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 16, 37, 22, 67, DateTimeKind.Unspecified) },
                    { 8, 6, new DateTime(2023, 3, 24, 19, 0, 36, 629, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 1, 0, 36, 629, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(2023, 2, 13, 11, 47, 18, 206, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 15, 47, 18, 206, DateTimeKind.Unspecified) },
                    { 10, 6, new DateTime(2023, 4, 8, 14, 25, 39, 501, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 18, 25, 39, 501, DateTimeKind.Unspecified) },
                    { 11, 4, new DateTime(2023, 2, 5, 18, 25, 54, 104, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 3, 25, 54, 104, DateTimeKind.Unspecified) },
                    { 12, 7, new DateTime(2023, 5, 28, 15, 2, 9, 298, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 18, 2, 9, 298, DateTimeKind.Unspecified) },
                    { 13, 3, new DateTime(2023, 5, 19, 5, 21, 10, 987, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 6, 21, 10, 987, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2023, 5, 1, 2, 18, 25, 239, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 7, 18, 25, 239, DateTimeKind.Unspecified) },
                    { 15, 5, new DateTime(2023, 5, 21, 13, 22, 25, 494, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 18, 22, 25, 494, DateTimeKind.Unspecified) },
                    { 16, 6, new DateTime(2023, 2, 19, 2, 18, 42, 398, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 9, 18, 42, 398, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2023, 3, 24, 23, 45, 7, 834, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 4, 45, 7, 834, DateTimeKind.Unspecified) },
                    { 18, 8, new DateTime(2023, 4, 20, 10, 23, 55, 708, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 20, 23, 55, 708, DateTimeKind.Unspecified) },
                    { 19, 5, new DateTime(2023, 3, 18, 4, 43, 50, 687, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 6, 43, 50, 687, DateTimeKind.Unspecified) },
                    { 20, 5, new DateTime(2023, 5, 20, 6, 41, 40, 801, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 14, 41, 40, 801, DateTimeKind.Unspecified) },
                    { 21, 7, new DateTime(2023, 3, 2, 13, 42, 13, 2, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 23, 42, 13, 2, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 22, 8, new DateTime(2023, 2, 21, 17, 23, 25, 807, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 21, 23, 25, 807, DateTimeKind.Unspecified) },
                    { 23, 4, new DateTime(2023, 4, 18, 22, 18, 16, 929, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 1, 18, 16, 929, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2023, 4, 27, 23, 39, 55, 138, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 4, 39, 55, 138, DateTimeKind.Unspecified) },
                    { 25, 8, new DateTime(2023, 2, 17, 8, 9, 1, 909, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 13, 9, 1, 909, DateTimeKind.Unspecified) },
                    { 26, 7, new DateTime(2023, 4, 14, 4, 29, 53, 346, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 13, 29, 53, 346, DateTimeKind.Unspecified) },
                    { 27, 2, new DateTime(2023, 5, 4, 18, 37, 17, 936, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 20, 37, 17, 936, DateTimeKind.Unspecified) },
                    { 28, 9, new DateTime(2023, 5, 13, 19, 35, 21, 988, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 3, 35, 21, 988, DateTimeKind.Unspecified) },
                    { 29, 5, new DateTime(2023, 4, 14, 13, 0, 27, 824, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 21, 0, 27, 824, DateTimeKind.Unspecified) },
                    { 30, 9, new DateTime(2023, 4, 1, 23, 37, 54, 69, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 2, 37, 54, 69, DateTimeKind.Unspecified) },
                    { 31, 8, new DateTime(2023, 2, 12, 7, 24, 57, 860, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 17, 24, 57, 860, DateTimeKind.Unspecified) },
                    { 32, 6, new DateTime(2023, 4, 3, 2, 12, 31, 132, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 3, 12, 31, 132, DateTimeKind.Unspecified) },
                    { 33, 1, new DateTime(2023, 4, 23, 15, 57, 8, 533, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 22, 57, 8, 533, DateTimeKind.Unspecified) },
                    { 34, 7, new DateTime(2023, 2, 7, 11, 44, 39, 96, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 20, 44, 39, 96, DateTimeKind.Unspecified) },
                    { 35, 7, new DateTime(2023, 3, 10, 11, 41, 8, 484, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 20, 41, 8, 484, DateTimeKind.Unspecified) },
                    { 36, 6, new DateTime(2023, 4, 12, 12, 51, 0, 870, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 15, 51, 0, 870, DateTimeKind.Unspecified) },
                    { 37, 7, new DateTime(2023, 4, 4, 6, 46, 17, 322, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 15, 46, 17, 322, DateTimeKind.Unspecified) },
                    { 38, 8, new DateTime(2023, 4, 28, 9, 0, 32, 640, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 12, 0, 32, 640, DateTimeKind.Unspecified) },
                    { 39, 8, new DateTime(2023, 5, 30, 14, 10, 11, 312, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 18, 10, 11, 312, DateTimeKind.Unspecified) },
                    { 40, 6, new DateTime(2023, 4, 6, 5, 37, 5, 360, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 6, 37, 5, 360, DateTimeKind.Unspecified) },
                    { 41, 7, new DateTime(2023, 2, 18, 0, 10, 58, 310, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 3, 10, 58, 310, DateTimeKind.Unspecified) },
                    { 42, 2, new DateTime(2023, 3, 23, 19, 51, 3, 784, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 3, 51, 3, 784, DateTimeKind.Unspecified) },
                    { 43, 1, new DateTime(2023, 5, 15, 22, 58, 55, 913, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 23, 58, 55, 913, DateTimeKind.Unspecified) },
                    { 44, 8, new DateTime(2023, 4, 29, 19, 3, 25, 524, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 3, 3, 25, 524, DateTimeKind.Unspecified) },
                    { 45, 4, new DateTime(2023, 4, 23, 23, 17, 26, 983, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 5, 17, 26, 983, DateTimeKind.Unspecified) },
                    { 46, 1, new DateTime(2023, 3, 24, 2, 26, 28, 351, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 9, 26, 28, 351, DateTimeKind.Unspecified) },
                    { 47, 6, new DateTime(2023, 5, 3, 16, 5, 6, 894, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 19, 5, 6, 894, DateTimeKind.Unspecified) },
                    { 48, 2, new DateTime(2023, 2, 7, 6, 18, 59, 317, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 11, 18, 59, 317, DateTimeKind.Unspecified) },
                    { 49, 3, new DateTime(2023, 3, 20, 0, 56, 35, 344, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 7, 56, 35, 344, DateTimeKind.Unspecified) },
                    { 50, 9, new DateTime(2023, 4, 3, 11, 28, 3, 767, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 12, 28, 3, 767, DateTimeKind.Unspecified) },
                    { 51, 7, new DateTime(2023, 5, 20, 15, 3, 38, 218, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 18, 3, 38, 218, DateTimeKind.Unspecified) },
                    { 52, 4, new DateTime(2023, 3, 4, 18, 47, 15, 58, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 1, 47, 15, 58, DateTimeKind.Unspecified) },
                    { 53, 6, new DateTime(2023, 4, 27, 11, 20, 50, 461, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 20, 50, 461, DateTimeKind.Unspecified) },
                    { 54, 6, new DateTime(2023, 5, 20, 3, 31, 19, 961, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 6, 31, 19, 961, DateTimeKind.Unspecified) },
                    { 55, 9, new DateTime(2023, 3, 11, 23, 49, 12, 302, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 8, 49, 12, 302, DateTimeKind.Unspecified) },
                    { 56, 7, new DateTime(2023, 4, 23, 19, 24, 5, 449, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 0, 24, 5, 449, DateTimeKind.Unspecified) },
                    { 57, 1, new DateTime(2023, 2, 16, 18, 11, 29, 526, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 4, 11, 29, 526, DateTimeKind.Unspecified) },
                    { 58, 3, new DateTime(2023, 2, 25, 19, 48, 8, 980, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 20, 48, 8, 980, DateTimeKind.Unspecified) },
                    { 59, 9, new DateTime(2023, 2, 20, 16, 11, 22, 979, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 17, 11, 22, 979, DateTimeKind.Unspecified) },
                    { 60, 8, new DateTime(2023, 3, 12, 12, 42, 47, 841, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 17, 42, 47, 841, DateTimeKind.Unspecified) },
                    { 61, 6, new DateTime(2023, 2, 4, 20, 27, 44, 262, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 4, 27, 44, 262, DateTimeKind.Unspecified) },
                    { 62, 2, new DateTime(2023, 4, 22, 14, 50, 8, 44, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 21, 50, 8, 44, DateTimeKind.Unspecified) },
                    { 63, 2, new DateTime(2023, 3, 31, 4, 48, 14, 438, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 12, 48, 14, 438, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "LoginStaus",
                columns: new[] { "L_ID", "A_ID", "L_cTime", "L_dcTime" },
                values: new object[,]
                {
                    { 64, 3, new DateTime(2023, 2, 14, 1, 57, 59, 671, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 4, 57, 59, 671, DateTimeKind.Unspecified) },
                    { 65, 9, new DateTime(2023, 3, 20, 22, 24, 32, 600, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 1, 24, 32, 600, DateTimeKind.Unspecified) },
                    { 66, 1, new DateTime(2023, 5, 15, 5, 29, 31, 144, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 9, 29, 31, 144, DateTimeKind.Unspecified) },
                    { 67, 7, new DateTime(2023, 4, 6, 21, 24, 17, 984, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 3, 24, 17, 984, DateTimeKind.Unspecified) },
                    { 68, 2, new DateTime(2023, 5, 24, 17, 55, 34, 875, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 1, 55, 34, 875, DateTimeKind.Unspecified) },
                    { 69, 2, new DateTime(2023, 5, 2, 10, 35, 49, 19, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 15, 35, 49, 19, DateTimeKind.Unspecified) },
                    { 70, 2, new DateTime(2023, 3, 19, 22, 55, 54, 634, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 6, 55, 54, 634, DateTimeKind.Unspecified) },
                    { 71, 3, new DateTime(2023, 2, 1, 7, 57, 44, 990, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 8, 57, 44, 990, DateTimeKind.Unspecified) },
                    { 72, 1, new DateTime(2023, 4, 25, 21, 20, 22, 768, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 23, 20, 22, 768, DateTimeKind.Unspecified) },
                    { 73, 7, new DateTime(2023, 2, 27, 8, 51, 17, 890, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 12, 51, 17, 890, DateTimeKind.Unspecified) },
                    { 74, 8, new DateTime(2023, 3, 1, 20, 5, 45, 846, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 21, 5, 45, 846, DateTimeKind.Unspecified) },
                    { 75, 5, new DateTime(2023, 4, 27, 7, 27, 16, 802, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 13, 27, 16, 802, DateTimeKind.Unspecified) },
                    { 76, 3, new DateTime(2023, 3, 1, 5, 11, 48, 717, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 7, 11, 48, 717, DateTimeKind.Unspecified) },
                    { 77, 1, new DateTime(2023, 4, 5, 17, 26, 15, 434, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 3, 26, 15, 434, DateTimeKind.Unspecified) },
                    { 78, 1, new DateTime(2023, 4, 16, 1, 3, 32, 273, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 5, 3, 32, 273, DateTimeKind.Unspecified) },
                    { 79, 3, new DateTime(2023, 2, 17, 16, 33, 18, 786, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 20, 33, 18, 786, DateTimeKind.Unspecified) },
                    { 80, 1, new DateTime(2023, 4, 5, 5, 7, 46, 615, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 7, 7, 46, 615, DateTimeKind.Unspecified) },
                    { 81, 8, new DateTime(2023, 2, 8, 15, 52, 23, 280, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 1, 52, 23, 280, DateTimeKind.Unspecified) },
                    { 82, 4, new DateTime(2023, 3, 10, 11, 58, 10, 409, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 15, 58, 10, 409, DateTimeKind.Unspecified) },
                    { 83, 2, new DateTime(2023, 2, 4, 20, 55, 7, 915, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 0, 55, 7, 915, DateTimeKind.Unspecified) },
                    { 84, 4, new DateTime(2023, 5, 16, 17, 27, 59, 433, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 3, 27, 59, 433, DateTimeKind.Unspecified) },
                    { 85, 8, new DateTime(2023, 4, 4, 4, 23, 45, 391, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 13, 23, 45, 391, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2023, 5, 23, 23, 48, 42, 449, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 9, 48, 42, 449, DateTimeKind.Unspecified) },
                    { 87, 4, new DateTime(2023, 2, 4, 3, 43, 43, 29, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 4, 43, 43, 29, DateTimeKind.Unspecified) },
                    { 88, 3, new DateTime(2023, 3, 1, 7, 3, 37, 216, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 15, 3, 37, 216, DateTimeKind.Unspecified) },
                    { 89, 9, new DateTime(2023, 3, 23, 8, 27, 8, 292, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 12, 27, 8, 292, DateTimeKind.Unspecified) },
                    { 90, 5, new DateTime(2023, 5, 31, 18, 17, 23, 41, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 21, 17, 23, 41, DateTimeKind.Unspecified) },
                    { 91, 9, new DateTime(2023, 5, 29, 9, 9, 57, 750, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 15, 9, 57, 750, DateTimeKind.Unspecified) },
                    { 92, 3, new DateTime(2023, 4, 23, 2, 44, 31, 952, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 10, 44, 31, 952, DateTimeKind.Unspecified) },
                    { 93, 4, new DateTime(2023, 4, 19, 23, 51, 49, 362, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 5, 51, 49, 362, DateTimeKind.Unspecified) },
                    { 94, 4, new DateTime(2023, 4, 29, 15, 16, 35, 359, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 19, 16, 35, 359, DateTimeKind.Unspecified) },
                    { 95, 5, new DateTime(2023, 5, 6, 17, 37, 29, 602, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 20, 37, 29, 602, DateTimeKind.Unspecified) },
                    { 96, 8, new DateTime(2023, 4, 4, 10, 49, 1, 672, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 19, 49, 1, 672, DateTimeKind.Unspecified) },
                    { 97, 7, new DateTime(2023, 5, 4, 2, 2, 46, 408, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 6, 2, 46, 408, DateTimeKind.Unspecified) },
                    { 98, 2, new DateTime(2023, 2, 12, 3, 44, 21, 214, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 8, 44, 21, 214, DateTimeKind.Unspecified) },
                    { 99, 7, new DateTime(2023, 3, 31, 3, 23, 21, 630, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 12, 23, 21, 630, DateTimeKind.Unspecified) },
                    { 100, 7, new DateTime(2023, 4, 25, 22, 58, 29, 710, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 4, 58, 29, 710, DateTimeKind.Unspecified) },
                    { 101, 1, new DateTime(2023, 4, 22, 9, 20, 54, 173, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 13, 20, 54, 173, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5775), 750m },
                    { 2, 1, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5776), 600m },
                    { 3, 2, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5777), 500m },
                    { 4, 3, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(5778), 500m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "O_ID", "A_ID", "O_Cancle", "O_Date", "O_TotalPrice" },
                values: new object[,]
                {
                    { 5, 3, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6434), 700m },
                    { 6, 4, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6453), 700m },
                    { 7, 7, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6462), 700m },
                    { 8, 5, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6470), 700m },
                    { 9, 5, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6479), 700m },
                    { 10, 6, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6517), 700m },
                    { 11, 4, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6526), 700m },
                    { 12, 3, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6536), 700m },
                    { 13, 6, false, new DateTime(2023, 5, 24, 9, 48, 4, 731, DateTimeKind.Local).AddTicks(6544), 700m }
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
