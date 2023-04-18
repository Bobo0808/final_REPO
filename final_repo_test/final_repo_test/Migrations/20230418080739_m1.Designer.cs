﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final_repo_test.Data;

#nullable disable

namespace final_repo_test.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230418080739_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("final_repo_test.Models.Account", b =>
                {
                    b.Property<int>("A_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("A_ID"), 1L, 1);

                    b.Property<int>("A_Coin")
                        .HasColumnType("int");

                    b.Property<string>("A_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("A_Gender")
                        .HasColumnType("int");

                    b.Property<string>("A_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("A_RegisteredAt")
                        .HasColumnType("Date");

                    b.Property<string>("A_add")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("A_level")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("Date");

                    b.Property<int>("P_id")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPWD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("A_ID");

                    b.HasIndex("P_id");

                    b.ToTable("Accounts", (string)null);

                    b.HasData(
                        new
                        {
                            A_ID = 1,
                            A_Coin = 999999,
                            A_Email = "Test@gmail.com",
                            A_Gender = 0,
                            A_Name = "Test",
                            A_NickName = "Test",
                            A_Phone = "0900000000",
                            A_RegisteredAt = new DateTime(2023, 4, 18, 16, 7, 39, 751, DateTimeKind.Local).AddTicks(5453),
                            A_add = "Test",
                            A_level = 99,
                            Birthday = new DateTime(2023, 4, 18, 16, 7, 39, 751, DateTimeKind.Local).AddTicks(5452),
                            P_id = 1,
                            UserName = "Test",
                            UserPWD = "Test"
                        });
                });

            modelBuilder.Entity("final_repo_test.Models.Ads", b =>
                {
                    b.Property<int>("Ad_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ad_ID"), 1L, 1);

                    b.Property<int>("AD_FinalPaymentAmount")
                        .HasColumnType("int");

                    b.Property<int>("Ad_ActiveStatus")
                        .HasColumnType("int");

                    b.Property<int>("Ad_Clicks")
                        .HasColumnType("int");

                    b.Property<int>("Ad_DayCount")
                        .HasColumnType("int");

                    b.Property<string>("Ad_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ad_EndTime")
                        .HasColumnType("Date");

                    b.Property<string>("Ad_ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ad_PaymentDueDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("Ad_StartTime")
                        .HasColumnType("Date");

                    b.Property<string>("Ad_TargetURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ad_TimeOfPayment")
                        .HasColumnType("Date");

                    b.Property<int>("CaseID")
                        .HasColumnType("int");

                    b.Property<int>("OS_ID")
                        .HasColumnType("int");

                    b.Property<int>("PartnerID")
                        .HasColumnType("int");

                    b.HasKey("Ad_ID");

                    b.HasIndex("CaseID");

                    b.HasIndex("OS_ID");

                    b.HasIndex("PartnerID");

                    b.ToTable("Ads", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Ads_OrderStatus", b =>
                {
                    b.Property<int>("OS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OS_ID"), 1L, 1);

                    b.Property<decimal>("OS_FullfillmentRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OS_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OS_PaymentMultiplier")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OS_ID");

                    b.ToTable("Ads_OrderStatus");
                });

            modelBuilder.Entity("final_repo_test.Models.Card", b =>
                {
                    b.Property<int>("CT_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CA_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("CA_Describe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CA_Discontinuted")
                        .HasColumnType("bit");

                    b.Property<int>("CA_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CA_ID"), 1L, 1);

                    b.Property<string>("CA_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CA_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CA_Price")
                        .HasColumnType("int");

                    b.HasKey("CT_ID");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("final_repo_test.Models.CardOrder", b =>
                {
                    b.Property<int>("CO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CO_ID"), 1L, 1);

                    b.Property<int>("A_ID")
                        .HasColumnType("int");

                    b.Property<int>("CA_Price")
                        .HasColumnType("int");

                    b.Property<int>("CO_Quantity")
                        .HasColumnType("int");

                    b.Property<int>("CO_Sum")
                        .HasColumnType("int");

                    b.HasKey("CO_ID");

                    b.HasIndex("A_ID");

                    b.HasIndex("CA_Price");

                    b.ToTable("CardOrder");
                });

            modelBuilder.Entity("final_repo_test.Models.CardType", b =>
                {
                    b.Property<int>("CT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_ID"), 1L, 1);

                    b.Property<string>("CT_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CT_ID");

                    b.ToTable("CardType");

                    b.HasData(
                        new
                        {
                            CT_ID = 1,
                            CT_Name = "綠界"
                        },
                        new
                        {
                            CT_ID = 2,
                            CT_Name = "LinePay"
                        });
                });

            modelBuilder.Entity("final_repo_test.Models.CaseTable", b =>
                {
                    b.Property<int>("Case_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Case_ID"), 1L, 1);

                    b.Property<string>("Case_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Case_PricePerDay")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Case_ID");

                    b.ToTable("CaseTables", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.DebugLog", b =>
                {
                    b.Property<int>("D_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("D_ID"), 1L, 1);

                    b.Property<int>("A_ID")
                        .HasColumnType("int");

                    b.Property<string>("D_event")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("D_isSolved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("D_time")
                        .HasColumnType("datetime2");

                    b.HasKey("D_ID");

                    b.HasIndex("A_ID");

                    b.ToTable("DebugLogs", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Employee", b =>
                {
                    b.Property<int>("E_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("E_ID"), 1L, 1);

                    b.Property<string>("E_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("E_Birthday")
                        .HasColumnType("Date");

                    b.Property<string>("E_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("E_Gender")
                        .HasColumnType("int");

                    b.Property<DateTime>("E_HireDate")
                        .HasColumnType("Date");

                    b.Property<string>("E_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("E_Permission")
                        .HasColumnType("int");

                    b.Property<string>("E_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E_Pwd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("E_Title")
                        .HasColumnType("int");

                    b.Property<string>("E_UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("E_Work")
                        .HasColumnType("bit");

                    b.HasKey("E_ID");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.LoginStaus", b =>
                {
                    b.Property<int>("L_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("L_ID"), 1L, 1);

                    b.Property<int>("A_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("L_cTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("L_dcTime")
                        .HasColumnType("datetime2");

                    b.HasKey("L_ID");

                    b.HasIndex("A_ID");

                    b.ToTable("LoginStaus", (string)null);

                    b.HasData(
                        new
                        {
                            L_ID = 1,
                            A_ID = 1,
                            L_cTime = new DateTime(2023, 4, 18, 16, 7, 39, 750, DateTimeKind.Local).AddTicks(6475),
                            L_dcTime = new DateTime(2023, 4, 18, 17, 7, 39, 750, DateTimeKind.Local).AddTicks(6484)
                        },
                        new
                        {
                            L_ID = 2,
                            A_ID = 1,
                            L_cTime = new DateTime(2023, 4, 17, 14, 7, 39, 750, DateTimeKind.Local).AddTicks(6490),
                            L_dcTime = new DateTime(2023, 4, 17, 15, 7, 39, 750, DateTimeKind.Local).AddTicks(6490)
                        },
                        new
                        {
                            L_ID = 3,
                            A_ID = 1,
                            L_cTime = new DateTime(2023, 4, 16, 13, 7, 39, 750, DateTimeKind.Local).AddTicks(6491),
                            L_dcTime = new DateTime(2023, 4, 16, 14, 7, 39, 750, DateTimeKind.Local).AddTicks(6492)
                        },
                        new
                        {
                            L_ID = 4,
                            A_ID = 1,
                            L_cTime = new DateTime(2023, 4, 15, 12, 7, 39, 750, DateTimeKind.Local).AddTicks(6493),
                            L_dcTime = new DateTime(2023, 4, 15, 13, 7, 39, 750, DateTimeKind.Local).AddTicks(6514)
                        },
                        new
                        {
                            L_ID = 5,
                            A_ID = 1,
                            L_cTime = new DateTime(2023, 4, 14, 11, 7, 39, 750, DateTimeKind.Local).AddTicks(6515),
                            L_dcTime = new DateTime(2023, 4, 14, 12, 7, 39, 750, DateTimeKind.Local).AddTicks(6516)
                        },
                        new
                        {
                            L_ID = 6,
                            A_ID = 1,
                            L_cTime = new DateTime(2023, 4, 14, 10, 7, 39, 750, DateTimeKind.Local).AddTicks(6516),
                            L_dcTime = new DateTime(2023, 4, 14, 11, 7, 39, 750, DateTimeKind.Local).AddTicks(6517)
                        },
                        new
                        {
                            L_ID = 7,
                            A_ID = 1,
                            L_cTime = new DateTime(2023, 4, 14, 9, 7, 39, 750, DateTimeKind.Local).AddTicks(6518),
                            L_dcTime = new DateTime(2023, 4, 14, 10, 7, 39, 750, DateTimeKind.Local).AddTicks(6518)
                        });
                });

            modelBuilder.Entity("final_repo_test.Models.Map", b =>
                {
                    b.Property<int>("M_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("M_ID"), 1L, 1);

                    b.Property<string>("M_Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("M_MapType")
                        .HasColumnType("int");

                    b.Property<string>("M_Src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("M_maxX")
                        .HasColumnType("int");

                    b.Property<int>("M_maxY")
                        .HasColumnType("int");

                    b.Property<int>("M_minX")
                        .HasColumnType("int");

                    b.Property<int>("M_minY")
                        .HasColumnType("int");

                    b.HasKey("M_ID");

                    b.ToTable("Maps", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Map_ADArea", b =>
                {
                    b.Property<int>("Area_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Area_ID"), 1L, 1);

                    b.Property<int>("Area_EndX")
                        .HasColumnType("int");

                    b.Property<int>("Area_EndY")
                        .HasColumnType("int");

                    b.Property<int>("Area_StartX")
                        .HasColumnType("int");

                    b.Property<int>("Area_StartY")
                        .HasColumnType("int");

                    b.Property<int>("CaseID")
                        .HasColumnType("int");

                    b.Property<int>("M_ID")
                        .HasColumnType("int");

                    b.HasKey("Area_ID");

                    b.HasIndex("CaseID");

                    b.HasIndex("M_ID");

                    b.ToTable("Map_ADAreas", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Map_BlockSpace", b =>
                {
                    b.Property<int>("Mb_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mb_ID"), 1L, 1);

                    b.Property<int>("M_ID")
                        .HasColumnType("int");

                    b.Property<int>("Mb_EndX")
                        .HasColumnType("int");

                    b.Property<int>("Mb_EndY")
                        .HasColumnType("int");

                    b.Property<int>("Mb_starX")
                        .HasColumnType("int");

                    b.Property<int>("Mb_starY")
                        .HasColumnType("int");

                    b.HasKey("Mb_ID");

                    b.HasIndex("M_ID");

                    b.ToTable("BlockSpaces", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Order", b =>
                {
                    b.Property<int>("O_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("O_ID"), 1L, 1);

                    b.Property<int>("A_ID")
                        .HasColumnType("int");

                    b.Property<bool>("O_Cancle")
                        .HasColumnType("bit");

                    b.Property<DateTime>("O_Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("O_TotalPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("O_ID");

                    b.HasIndex("A_ID");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.OrderDetail", b =>
                {
                    b.Property<int>("Od_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Od_ID"), 1L, 1);

                    b.Property<int>("O_ID")
                        .HasColumnType("int");

                    b.Property<int>("Od_Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Od_Sum")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("Od_UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("P_ID")
                        .HasColumnType("int");

                    b.HasKey("Od_ID");

                    b.HasIndex("O_ID");

                    b.HasIndex("P_ID");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Partner", b =>
                {
                    b.Property<int>("P_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("P_ID"), 1L, 1);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("P_ID");

                    b.ToTable("Partners", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Product", b =>
                {
                    b.Property<int>("P_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("P_ID"), 1L, 1);

                    b.Property<DateTime>("P_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("P_Describe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("P_Discontinuted")
                        .HasColumnType("bit");

                    b.Property<int>("P_Discount")
                        .HasColumnType("int");

                    b.Property<string>("P_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("P_Instock")
                        .HasColumnType("int");

                    b.Property<string>("P_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("P_Price")
                        .HasColumnType("int");

                    b.Property<int>("P_ProductType")
                        .HasColumnType("int");

                    b.HasKey("P_ID");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            P_ID = 1,
                            P_Date = new DateTime(2023, 4, 18, 16, 7, 39, 751, DateTimeKind.Local).AddTicks(5435),
                            P_Describe = "Regular Fit反摺袖襯衫",
                            P_Discontinuted = false,
                            P_Discount = 0,
                            P_Image = "1.jpg",
                            P_Instock = 99,
                            P_Name = "反摺袖襯衫",
                            P_Price = 699,
                            P_ProductType = 1
                        },
                        new
                        {
                            P_ID = 2,
                            P_Date = new DateTime(2023, 4, 18, 16, 7, 39, 751, DateTimeKind.Local).AddTicks(5439),
                            P_Describe = "Regular Fit棉麻短袖襯衫",
                            P_Discontinuted = false,
                            P_Discount = 0,
                            P_Image = "2.jpg",
                            P_Instock = 99,
                            P_Name = "短袖襯衫",
                            P_Price = 499,
                            P_ProductType = 0
                        });
                });

            modelBuilder.Entity("final_repo_test.Models.Report", b =>
                {
                    b.Property<int>("R_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("R_ID"), 1L, 1);

                    b.Property<int>("A_ID")
                        .HasColumnType("int");

                    b.Property<string>("R_Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R_Reply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("R_ReportStatus")
                        .HasColumnType("int");

                    b.Property<int>("R_ReportType")
                        .HasColumnType("int");

                    b.Property<DateTime>("R_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReportedA_ID")
                        .HasColumnType("int");

                    b.HasKey("R_ID");

                    b.HasIndex("A_ID");

                    b.HasIndex("ReportedA_ID");

                    b.ToTable("Reports", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Society", b =>
                {
                    b.Property<int>("S_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("S_ID"), 1L, 1);

                    b.Property<int>("A_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("S_Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TargetA_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("S_ID");

                    b.HasIndex("A_ID");

                    b.HasIndex("TargetA_ID");

                    b.ToTable("Societies", (string)null);
                });

            modelBuilder.Entity("final_repo_test.Models.Account", b =>
                {
                    b.HasOne("final_repo_test.Models.Product", "Product")
                        .WithMany("Accounts")
                        .HasForeignKey("P_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("final_repo_test.Models.Ads", b =>
                {
                    b.HasOne("final_repo_test.Models.CaseTable", "CaseTable")
                        .WithMany("Ads")
                        .HasForeignKey("CaseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("final_repo_test.Models.Ads_OrderStatus", "Ads_OrderStatus")
                        .WithMany("Ads")
                        .HasForeignKey("OS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("final_repo_test.Models.Partner", "Partner")
                        .WithMany("Ads")
                        .HasForeignKey("PartnerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ads_OrderStatus");

                    b.Navigation("CaseTable");

                    b.Navigation("Partner");
                });

            modelBuilder.Entity("final_repo_test.Models.Card", b =>
                {
                    b.HasOne("final_repo_test.Models.CardType", "CardType")
                        .WithMany("Cards")
                        .HasForeignKey("CT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardType");
                });

            modelBuilder.Entity("final_repo_test.Models.CardOrder", b =>
                {
                    b.HasOne("final_repo_test.Models.Account", "Account")
                        .WithMany("CardOrders")
                        .HasForeignKey("A_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("final_repo_test.Models.Card", "Card")
                        .WithMany("CardOrders")
                        .HasForeignKey("CA_Price")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("final_repo_test.Models.DebugLog", b =>
                {
                    b.HasOne("final_repo_test.Models.Account", "Account")
                        .WithMany("DebugLogs")
                        .HasForeignKey("A_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("final_repo_test.Models.LoginStaus", b =>
                {
                    b.HasOne("final_repo_test.Models.Account", "Account")
                        .WithMany("LoginStaus")
                        .HasForeignKey("A_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("final_repo_test.Models.Map_ADArea", b =>
                {
                    b.HasOne("final_repo_test.Models.CaseTable", "CaseTable")
                        .WithMany("Map_ADAreas")
                        .HasForeignKey("CaseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("final_repo_test.Models.Map", "Map")
                        .WithMany("Map_ADAreas")
                        .HasForeignKey("M_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaseTable");

                    b.Navigation("Map");
                });

            modelBuilder.Entity("final_repo_test.Models.Map_BlockSpace", b =>
                {
                    b.HasOne("final_repo_test.Models.Map", "Map")
                        .WithMany("Map_BlockSpaces")
                        .HasForeignKey("M_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Map");
                });

            modelBuilder.Entity("final_repo_test.Models.Order", b =>
                {
                    b.HasOne("final_repo_test.Models.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("A_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("final_repo_test.Models.OrderDetail", b =>
                {
                    b.HasOne("final_repo_test.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("O_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("final_repo_test.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("P_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("final_repo_test.Models.Report", b =>
                {
                    b.HasOne("final_repo_test.Models.Account", "Account")
                        .WithMany("Reports")
                        .HasForeignKey("A_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("final_repo_test.Models.Account", "ReportedAccount")
                        .WithMany("ReportedReports")
                        .HasForeignKey("ReportedA_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("ReportedAccount");
                });

            modelBuilder.Entity("final_repo_test.Models.Society", b =>
                {
                    b.HasOne("final_repo_test.Models.Account", "Account")
                        .WithMany("Societies")
                        .HasForeignKey("A_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("final_repo_test.Models.Account", "TargetAccount")
                        .WithMany("TargetSocieties")
                        .HasForeignKey("TargetA_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("TargetAccount");
                });

            modelBuilder.Entity("final_repo_test.Models.Account", b =>
                {
                    b.Navigation("CardOrders");

                    b.Navigation("DebugLogs");

                    b.Navigation("LoginStaus");

                    b.Navigation("Orders");

                    b.Navigation("ReportedReports");

                    b.Navigation("Reports");

                    b.Navigation("Societies");

                    b.Navigation("TargetSocieties");
                });

            modelBuilder.Entity("final_repo_test.Models.Ads_OrderStatus", b =>
                {
                    b.Navigation("Ads");
                });

            modelBuilder.Entity("final_repo_test.Models.Card", b =>
                {
                    b.Navigation("CardOrders");
                });

            modelBuilder.Entity("final_repo_test.Models.CardType", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("final_repo_test.Models.CaseTable", b =>
                {
                    b.Navigation("Ads");

                    b.Navigation("Map_ADAreas");
                });

            modelBuilder.Entity("final_repo_test.Models.Map", b =>
                {
                    b.Navigation("Map_ADAreas");

                    b.Navigation("Map_BlockSpaces");
                });

            modelBuilder.Entity("final_repo_test.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("final_repo_test.Models.Partner", b =>
                {
                    b.Navigation("Ads");
                });

            modelBuilder.Entity("final_repo_test.Models.Product", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
