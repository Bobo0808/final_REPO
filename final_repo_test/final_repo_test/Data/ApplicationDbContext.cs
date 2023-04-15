﻿using final_repo_test.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace final_repo_test.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>( b =>
            {
                b.Property(x=>x.A_ID)
                    .ValueGeneratedOnAdd();


                b.Property(x=>x.A_Coin);

                b.Property(x=>x.A_Email)
                    .IsRequired();

                b.Property(x=>x.A_Gender);

                b.Property(x=>x.A_Name)
                    .IsRequired();

                b.Property(x=>x.A_NickName)
                    .IsRequired();

                b.Property(x=>x.A_Phone)
                    .IsRequired();

                b.Property(x=>x.A_RegisteredAt).IsRequired();

                b.Property(x=>x.A_add)
                    .IsRequired();

                b.Property(x=>x.A_level);

                b.Property(x=>x.Birthday);

                b.Property(x=>x.UserName)
                    .IsRequired();

                b.Property(x=>x.UserPWD)
                    .IsRequired();

                b.HasKey(x=>x.A_ID);
                b.HasMany(x => x.Reports).WithOne(x => x.Account).HasForeignKey(x=>x.A_ID).HasPrincipalKey(x=>x.A_ID);
                b.HasMany(x => x.ReportedReports).WithOne(x => x.ReportedAccount).HasForeignKey(x=>x.ReportedA_ID).HasPrincipalKey(x=>x.A_ID);
                b.HasMany(x => x.DebugLogs).WithOne(x => x.Account).HasForeignKey(x=>x.A_ID).HasPrincipalKey(x=>x.A_ID);
                b.HasMany(x => x.LoginStaus).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.Orders).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.Societies).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.TargetSocieties).WithOne(x => x.TargetAccount).HasForeignKey(x => x.TargetA_ID).HasPrincipalKey(x => x.A_ID);
                b.ToTable("Accounts");

            });

            modelBuilder.Entity<Ads>( b =>
            {
                b.Property(x=>x.Ad_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.Ad_Clicks);

                b.Property(x=>x.Ad_DayCount);

                b.Property(x=>x.Ad_Description);

                b.Property(x=>x.Ad_EndTime);

                b.Property(x=>x.Ad_ImageURL);

                b.Property(x=>x.Ad_StartTime);

                b.Property(x=>x.Ad_TargetURL);

                b.Property(x=>x.CaseID);

                b.Property(x=>x.PartnerID);

                b.HasKey(x=>x.Ad_ID);
                b.HasOne(x => x.CaseTable).WithMany(x => x.Ads).HasForeignKey(x => x.CaseID).HasPrincipalKey(x=>x.Case_ID).OnDelete(DeleteBehavior.Restrict);
                b.HasOne(x => x.Partner).WithMany(x => x.Ads).HasForeignKey(x => x.PartnerID).HasPrincipalKey(x=>x.P_ID).OnDelete(DeleteBehavior.Restrict);

                b.ToTable("Ads");
            });

            modelBuilder.Entity<CaseTable>(b =>
            {
                b.Property(x=>x.Case_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.Case_Name)
                    .IsRequired();

                b.Property(x=>x.Case_PricePerDay).HasColumnType("decimal(18,4)"); ;

                b.HasKey(x=>x.Case_ID);
                b.HasMany(x=>x.Ads).WithOne(x=>x.CaseTable).HasForeignKey(x=>x.CaseID).HasPrincipalKey(x=>x.Case_ID);
                b.HasMany(x => x.Map_ADAreas).WithOne(x => x.CaseTable).HasForeignKey(x => x.CaseID).HasPrincipalKey(x => x.Case_ID);

                b.ToTable("CaseTables");
            });

            modelBuilder.Entity<DebugLog>(b =>
            {
                b.Property(x=>x.D_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.A_ID);

                b.Property(x=>x.D_event)
                    .IsRequired();

                b.Property(x=>x.D_isSolved);

                b.Property(x=>x.D_time);

                b.HasKey(x=>x.D_ID);
                b.HasOne(x => x.Account).WithMany(x => x.DebugLogs).HasForeignKey(x => x.A_ID).HasPrincipalKey(x=>x.A_ID).OnDelete(DeleteBehavior.Restrict);
                b.ToTable("DebugLogs");
            });

            modelBuilder.Entity<Employee>(b =>
            {
                b.Property(x=>x.E_ID)
                    .ValueGeneratedOnAdd();


                b.Property(x=>x.E_Address)
                    .IsRequired();

                b.Property(x=>x.E_Birthday);

                b.Property(x=>x.E_Email)
                    .IsRequired();

                b.Property(x=>x.E_Gender);

                b.Property(x=>x.E_HireDate);

                b.Property(x=>x.E_Name)
                    .IsRequired();

                b.Property(x=>x.E_Permission);

                b.Property(x=>x.E_Phone)
                    .IsRequired();

                b.Property(x=>x.E_Pwd)
                    .IsRequired();

                b.Property(x=>x.E_Title);

                b.Property(x=>x.E_UserName)
                    .IsRequired();

                b.Property(x=>x.E_Work);

                b.HasKey(x=>x.E_ID);

                b.ToTable("Employees");
            });

            modelBuilder.Entity<LoginStaus>(b =>
            {
                b.Property(x=>x.L_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.A_ID);

                b.Property(x=>x.L_cTime);

                b.Property(x=>x.L_dcTime);

                b.HasKey(x => x.L_ID) ;
                b.HasOne(x => x.Account).WithMany(x => x.LoginStaus).HasForeignKey(x => x.A_ID).HasPrincipalKey(x=>x.A_ID).OnDelete(DeleteBehavior.Restrict);

                b.ToTable("LoginStaus");
            });

            modelBuilder.Entity<Map>(b =>
            {
                b.Property(x=>x.M_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.M_Desc)
                    .IsRequired();

                b.Property(x=>x.M_MapType);

                b.Property(x=>x.M_Src)
                    .IsRequired();

                b.Property(x=>x.M_maxX);

                b.Property(x=>x.M_maxY);

                b.Property(x=>x.M_minX);

                b.Property(x=>x.M_minY);

                b.HasKey(x=>x.M_ID);
                b.HasMany(x => x.Map_BlockSpaces).WithOne(x => x.Map).HasForeignKey(x=>x.M_ID).HasPrincipalKey(x=>x.M_ID);
                b.HasMany(x => x.Map_ADAreas).WithOne(x => x.Map).HasForeignKey(x => x.M_ID).HasPrincipalKey(x => x.M_ID);
                b.ToTable("Maps");
            });

            modelBuilder.Entity<Map_ADArea>(b =>
            {
                b.Property(x=>x.Area_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.Area_EndX);

                b.Property(x=>x.Area_EndY);

                b.Property(x=>x.Area_StartX);

                b.Property(x=>x.Area_StartY);

                b.Property(x=>x.CaseID);

                b.Property(x=>x.M_ID);

                b.HasKey(x=>x.Area_ID);
                b.HasOne(x => x.Map).WithMany(x => x.Map_ADAreas).HasForeignKey(x => x.M_ID).HasPrincipalKey(x=>x.M_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.CaseTable).WithMany(x => x.Map_ADAreas).HasForeignKey(x => x.CaseID).HasPrincipalKey(x=>x.Case_ID).OnDelete(DeleteBehavior.Restrict);

                b.ToTable("Map_ADAreas");
            });

            modelBuilder.Entity<Map_BlockSpace>(b =>
            {
                b.Property(x=>x.Mb_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.M_ID);

                b.Property(x=>x.Mb_EndX);

                b.Property(x=>x.Mb_EndY);

                b.Property(x=>x.Mb_starX);

                b.Property(x=>x.Mb_starY);

                b.HasKey(x=>x.Mb_ID);

                b.HasOne(x => x.Map).WithMany(x => x.Map_BlockSpaces).HasForeignKey(x => x.M_ID).HasPrincipalKey(x=>x.M_ID).OnDelete(DeleteBehavior.Cascade);
                b.ToTable("BlockSpaces");
            });

            modelBuilder.Entity<Order>(b =>
            {
                b.Property(x=>x.O_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.A_ID);

                b.Property(x=>x.O_Cancle);

                b.Property(x=>x.O_Date);

                b.Property(x=>x.O_TotalPrice).HasColumnType("decimal(18,4)"); ;

                b.HasKey(x=>x.O_ID);
                b.HasOne(x => x.Account).WithMany(x => x.Orders).HasForeignKey(x => x.A_ID).HasPrincipalKey(x=>x.A_ID).OnDelete(DeleteBehavior.Restrict);
                b.HasMany(x => x.OrderDetails).WithOne(x => x.Order).HasForeignKey(x=>x.O_ID).HasPrincipalKey(x=>x.O_ID);
                b.ToTable("Orders");
            });

            modelBuilder.Entity<OrderDetail>(b =>
            {
                b.Property(x=>x.Od_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.O_ID);

                b.Property(x=>x.Od_Quantity);

                b.Property(x=>x.Od_Sum).HasColumnType("decimal(18,4)"); ;

                b.Property(x=>x.Od_UnitPrice).HasColumnType("decimal(18,4)"); ;

                b.Property(x=>x.P_ID);

                b.HasKey(x=>x.Od_ID);
                b.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.O_ID).HasPrincipalKey(x=>x.O_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.P_ID).HasPrincipalKey(x=>x.P_ID).OnDelete(DeleteBehavior.Restrict);

                b.ToTable("OrderDetails");
            });

            modelBuilder.Entity<Partner>(b =>
            {
                b.Property(x=>x.P_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.Contact)
                    .IsRequired();

                b.Property(x=>x.Email)
                    .IsRequired();

                b.Property(x=>x.P_Name)
                    .IsRequired();

                b.Property(x=>x.Phone)
                    .IsRequired();

                b.HasKey(x=>x.P_ID);
                b.HasMany(x => x.Ads).WithOne(x => x.Partner).HasForeignKey(x=>x.PartnerID).HasPrincipalKey(x=>x.P_ID);
                b.ToTable("Partners");
            });

            modelBuilder.Entity<Product>(b =>
            {
                b.Property(x=>x.P_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.P_Date);

                b.Property(x=>x.P_Describe)
                    .IsRequired();

                b.Property(x=>x.P_Discontinuted);

                b.Property(x=>x.P_Discount)
                    .IsRequired();

                b.Property(x=>x.P_Image)
                    .IsRequired();

                b.Property(x=>x.P_Instock);

                b.Property(x=>x.P_Name)
                    .IsRequired();

                b.Property(x=>x.P_Price);

                b.Property(x=>x.P_ProductType);

                b.HasKey(x=>x.P_ID);
                b.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x=>x.P_ID).HasPrincipalKey(x=>x.P_ID);

                b.ToTable("Products");
            });
            
            modelBuilder.Entity<Report>(b =>
            {
                b.Property(x=>x.R_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.A_ID);

                b.Property(x=>x.R_Reason)
                    .IsRequired();

                b.Property(x=>x.R_Reply)
                    .IsRequired();

                b.Property(x=>x.R_ReportStatus);

                b.Property(x=>x.R_ReportType);

                b.Property(x=>x.R_Time);

                b.Property(x=>x.ReportedA_ID);
                b.HasKey(x=>x.R_ID);
                b.HasOne(x => x.Account).WithMany(x => x.Reports).HasForeignKey(x => x.A_ID).HasPrincipalKey(x=>x.A_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.ReportedAccount).WithMany(x => x.ReportedReports).HasForeignKey(x => x.ReportedA_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Restrict);
                b.ToTable("Reports");
            });

            modelBuilder.Entity<Society>(b =>
            {
                b.Property(x=>x.S_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x=>x.A_ID);

                b.Property(x=>x.CreateAt);

                b.Property(x=>x.S_Notes)
                    .IsRequired();

                b.Property(x=>x.TargetA_ID);

                b.Property(x=>x.UpdateAt);

                b.HasKey(x=>x.S_ID);
                b.HasOne(x => x.Account).WithMany(x => x.Societies).HasForeignKey(x=>x.A_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.TargetAccount).WithMany(x => x.TargetSocieties).HasForeignKey(x => x.TargetA_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Restrict);
                b.ToTable("Societies");
            });
        }

        public DbSet<Account> Accounts { get; set; } = default!;
        public DbSet<Ads> Ads { get; set; } = default!;
        public DbSet<CaseTable> CaseTables { get; set; } = default!;
        public DbSet<DebugLog> DebugLogs { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<LoginStaus> LoginStaus { get; set; } = default!;
        public DbSet<Map> Maps { get; set; } = default!;
        public DbSet<Map_ADArea> Map_ADAreas { get; set; } = default!;
        public DbSet<Map_BlockSpace> BlockSpaces { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = default!;
        public DbSet<Partner> Partners { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Report> Reports { get; set; } = default!;
        public DbSet<Society> Societies { get; set; } = default!;
    }
}