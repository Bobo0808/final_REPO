using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Enum;

namespace ClassLibrary
{
    public class ChickenDbContext : DbContext
    {
        public ChickenDbContext(DbContextOptions<ChickenDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ChickenLife;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //optionsBuilder.UseSqlServer(@"Server=tcp:chdb0.database.windows.net,1433;Initial Catalog=ChickenLife;Persist Security Info=False;User ID=bobowang;Password=Wang0963915586;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserAccount>(b =>
            {
                b.Property(x => x.A_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.A_Coin);

                b.Property(x => x.A_Email)
                    .IsRequired();

                b.Property(x => x.A_Gender);

                b.Property(x => x.A_Name)
                    .IsRequired();

                b.Property(x => x.A_NickName)
                    .IsRequired();

                b.Property(x => x.A_Phone)
                    .IsRequired();

                b.Property(x => x.A_RegisteredAt).IsRequired();

                b.Property(x => x.A_add)
                    .IsRequired();

                b.Property(x => x.A_level);

                b.Property(x => x.Birthday);

                b.Property(x => x.UserName)
                    .IsRequired();

                b.Property(x => x.UserPWD)
                    .IsRequired();

                b.HasKey(x => x.A_ID);
                b.HasOne(x => x.Product).WithMany(x => x.Accounts).HasForeignKey(x => x.P_id);
                b.HasMany(x => x.Reports).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.ReportedReports).WithOne(x => x.ReportedAccount).HasForeignKey(x => x.ReportedA_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.DebugLogs).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.LoginStaus).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.Orders).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.Societies).WithOne(x => x.Account).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID);
                b.HasMany(x => x.TargetSocieties).WithOne(x => x.TargetAccount).HasForeignKey(x => x.TargetA_ID).HasPrincipalKey(x => x.A_ID);
                b.ToTable("Accounts");
            });

            modelBuilder.Entity<Ads>(b =>
            {
                b.Property(x => x.Ad_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.Ad_Clicks);

                b.Property(x => x.Ad_DayCount);

                b.Property(x => x.Ad_Description);

                b.Property(x => x.Ad_EndTime);

                b.Property(x => x.Ad_ImageURL);

                b.Property(x => x.Ad_StartTime);

                b.Property(x => x.Ad_TargetURL);

                b.Property(x => x.CaseID);

                b.Property(x => x.PartnerID);

                b.Property(x => x.Ad_PaymentDueDate);
                b.Property(x => x.Ad_TimeOfPayment);
                b.Property(x => x.Ad_ActiveStatus);
                b.Property(x => x.OS_ID);
                b.Property(x => x.AD_FinalPaymentAmount);

                b.HasKey(x => x.Ad_ID);
                b.HasOne(x => x.Ads_OrderStatus).WithMany(x => x.Ads).HasForeignKey(x => x.OS_ID);
                b.HasOne(x => x.CaseTable).WithMany(x => x.Ads).HasForeignKey(x => x.CaseID).HasPrincipalKey(x => x.Case_ID).OnDelete(DeleteBehavior.Restrict);
                b.HasOne(x => x.Partner).WithMany(x => x.Ads).HasForeignKey(x => x.PartnerID).HasPrincipalKey(x => x.P_ID).OnDelete(DeleteBehavior.Restrict);

                //var rnd = new Random(Guid.NewGuid().GetHashCode());
                //for (int i = 0; i < 30; i++)
                //{
                //    var year = rnd.Next(2023, 2024);
                //    var month = rnd.Next(1, 5);
                //    var days = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                //    DateTime temp = new DateTime(year, month, days, rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60), rnd.Next(0, 1000));
                //    b.HasData(new Ads()
                //    {
                //        Ad_ID=i++,
                //        Ad_Clicks = rnd.Next(1000,3000),
                //        Ad_StartTime = temp,
                //        Ad_EndTime = temp.AddYears(1),
                //        Ad_DayCount = temp.AddYears(1).Subtract(temp).Days,
                //        Ad_TargetURL = "test",
                //        Ad_ImageURL = "test",
                //        Ad_Description = "test",
                //        Ad_TimeOfPayment = temp.AddMonths(-3),
                //        Ad_PaymentDueDate = temp.AddMonths(-1),
                //        CaseID =
                //    });
                //}

                b.ToTable("Ads");
            });
            modelBuilder.Entity<Ads_OrderStatus>(b =>
            {
                b.Property(x => x.OS_ID).ValueGeneratedOnAdd();
                b.Property(x => x.OS_Name);

                b.Property(x => x.OS_FullfillmentRate).HasColumnType("decimal(5,2)");
                b.Property(x => x.OS_PaymentMultiplier).HasColumnType("decimal(5,2)");
                b.HasKey(x => x.OS_ID);
            });

            modelBuilder.Entity<CardType>(b =>
            {
                b.Property(x => x.CT_ID).ValueGeneratedOnAdd();
                b.Property(x => x.CT_Name);

                b.HasKey(x => x.CT_ID);
            });

            modelBuilder.Entity<Card>(b =>
            {
                b.Property(x => x.CA_ID).ValueGeneratedOnAdd();
                b.Property(x => x.CA_Name);
                b.Property(x => x.CA_Price);
                b.Property(x => x.CA_Image);
                b.Property(x => x.CA_Describe);
                b.Property(x => x.CA_Date);
                b.Property(x => x.CA_Discontinuted);

                b.HasKey(x => x.CA_ID);
            });

            modelBuilder.Entity<CardOrder>(b =>
            {
                b.Property(x => x.CO_ID).ValueGeneratedOnAdd();
                b.Property(x => x.A_ID);
                b.Property(x => x.CA_ID);
                b.Property(x => x.CT_ID);
                b.Property(x => x.CO_Sum);
                b.Property(x => x.CO_Date);
                b.Property(x => x.CO_Cancel);
                b.Property(x => x.CO_Quantity);

                b.HasKey(x => x.CO_ID);
                b.HasOne(x => x.CardType).WithMany(x => x.CardOrders).HasForeignKey(x => x.CT_ID);
                b.HasOne(x => x.Account).WithMany(x => x.CardOrders).HasForeignKey(x => x.A_ID);
                b.HasOne(x => x.Card).WithMany(x => x.CardOrders).HasForeignKey(x => x.CA_ID);
            });

            modelBuilder.Entity<CaseTable>(b =>
            {
                b.Property(x => x.Case_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.Case_Name)
                    .IsRequired();

                b.Property(x => x.Case_PricePerDay).HasColumnType("decimal(18,4)"); ;

                b.HasKey(x => x.Case_ID);
                b.HasMany(x => x.Ads).WithOne(x => x.CaseTable).HasForeignKey(x => x.CaseID).HasPrincipalKey(x => x.Case_ID);
                b.HasMany(x => x.Map_ADAreas).WithOne(x => x.CaseTable).HasForeignKey(x => x.CaseID).HasPrincipalKey(x => x.Case_ID);

                b.ToTable("CaseTables");
            });

            modelBuilder.Entity<DebugLog>(b =>
            {
                b.Property(x => x.D_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.A_ID);

                b.Property(x => x.D_event)
                    .IsRequired();

                b.Property(x => x.D_isSolved);

                b.Property(x => x.D_time);

                b.Property(x => x.D_Comment);

                b.HasKey(x => x.D_ID);
                b.HasOne(x => x.Account).WithMany(x => x.DebugLogs).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Restrict);
                Random rnd = new Random();
                for (int i = 1; i < 20; i++)
                {
                    if (i < 10)
                    {
                        b.HasData(new DebugLog
                        {
                            D_ID = i,
                            A_ID = rnd.Next(1, 11),
                            D_event = "test",
                            D_time = DateTime.Now,
                            D_isSolved = true,
                        });
                    }
                    else
                    {
                        b.HasData(new DebugLog
                        {
                            D_ID = i,
                            A_ID = rnd.Next(1, 11),
                            D_event = "test",
                            D_time = DateTime.Now,
                            D_isSolved = false,
                        });
                    }
                }
                b.ToTable("DebugLogs");
            });

            modelBuilder.Entity<Employee>(b =>
            {
                b.Property(x => x.E_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.E_Address)
                    .IsRequired();

                b.Property(x => x.E_Birthday);

                b.Property(x => x.E_Email)
                    .IsRequired();

                b.Property(x => x.E_Gender);

                b.Property(x => x.E_HireDate);

                b.Property(x => x.E_Name)
                    .IsRequired();

                b.Property(x => x.E_Permission);

                b.Property(x => x.E_Phone)
                    .IsRequired();

                b.Property(x => x.E_Pwd)
                    .IsRequired();

                b.Property(x => x.E_Title);

                b.Property(x => x.E_UserName)
                    .IsRequired();

                b.Property(x => x.E_Work);

                b.HasKey(x => x.E_ID);

                b.ToTable("Employees");
            });
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                E_ID = 1,
                E_Name = "bobo",
                E_Gender = 0,
                E_UserName = "bobo",
                E_Pwd = "1234",
                E_Email = "user@gmail.com",
                E_Title = 0,
                E_Phone = "0963915584",
                E_Birthday = new DateTime(1999, 08, 08),
                E_HireDate = new DateTime(2023, 05, 15),
                E_Address = "高雄市前金區",
                E_Permission = 0,
                E_Work = true,
            });
            for (int i = 2; i < 10; i++)//從這裡開始
            {
                Random SRnd = new Random();
                Random ERnd = new Random();

                DateTime StartDate = new DateTime(2002, 1, 1);
                DateTime endDate = new DateTime(2022, 1, 1);
                int StartDaysToAdd = SRnd.Next(365);
                int EndDaysToAdd = ERnd.Next(7, 25);
                DateTime StartTime = StartDate.AddDays(StartDaysToAdd);
                DateTime EndTime = endDate.AddDays(EndDaysToAdd);

                Random random = new Random();
                Random r_Work = new Random();
                //string[] Work = { "在職", "離職" };
                //string random_Work = Work[r_Work.Next(0, 2)];

                //int randomGender1 = random.Next(0, 2);
                //int random_Title1 = random.Next(0, 3);

                string characters = "abcdefghijklmnopqrstuvwxyz0123456789";
                int length = random.Next(6, 12); // Random length between 6 and 11
                string email = "";
                string pwd = "";
                string username = "";
                for (int jj = 0; jj < length; jj++)
                {
                    int index = random.Next(0, characters.Length);
                    email += characters[index];
                }
                email += "@gmail.com";

                for (int kk = 0; kk < length; kk++)
                {
                    int index = random.Next(0, characters.Length);
                    pwd += characters[index];
                }

                for (int ii = 0; ii < length; ii++)
                {
                    int index = random.Next(0, characters.Length);
                    username += characters[index];
                }

                modelBuilder.Entity<Employee>().HasData(new Employee()
                {
                    E_ID = i,
                    E_Name = username,
                    E_Gender = (Employee.Gender)random.Next(0, 2),
                    E_UserName = username,
                    E_Pwd = pwd,
                    E_Email = email,
                    E_Title = (Employee.Title)random.Next(0, 2),
                    E_Phone = $"09{SRnd.Next(10000000, 20000000)}",
                    E_Birthday = StartTime,
                    E_HireDate = EndTime,
                    E_Address = "高雄市前金區",
                    E_Permission = SRnd.Next(1, 3),
                    E_Work = true,
                });
            };//從這裡結束

            modelBuilder.Entity<LoginStaus>(b =>
            {
                b.Property(x => x.L_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.A_ID);

                b.Property(x => x.L_cTime);

                b.Property(x => x.L_dcTime);

                b.HasKey(x => x.L_ID);
                b.HasOne(x => x.Account).WithMany(x => x.LoginStaus).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Restrict);

                var rnd = new Random(Guid.NewGuid().GetHashCode());
                for (int j = 0; j <= 100; j++)
                {
                    var year = rnd.Next(2023, 2024);
                    var month = rnd.Next(2, 6);
                    var days = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                    DateTime temp = new DateTime(year, month, days, rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60), rnd.Next(0, 1000));
                    b.HasData(new LoginStaus()
                    {
                        L_ID = j + 1,
                        A_ID = rnd.Next(1, 10),
                        L_cTime = temp,
                        L_dcTime = temp.AddHours(rnd.Next(1, 11))
                    });
                }

                b.ToTable("LoginStaus");
            });

            modelBuilder.Entity<Map>(b =>
            {
                b.Property(x => x.M_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.M_Desc)
                    .IsRequired();

                b.Property(x => x.M_MapType);

                b.Property(x => x.M_Src)
                    .IsRequired();

                b.Property(x => x.M_maxX);

                b.Property(x => x.M_maxY);

                b.Property(x => x.M_minX);

                b.Property(x => x.M_minY);

                b.HasKey(x => x.M_ID);
                b.HasMany(x => x.Map_BlockSpaces).WithOne(x => x.Map).HasForeignKey(x => x.M_ID).HasPrincipalKey(x => x.M_ID);
                b.HasMany(x => x.Map_ADAreas).WithOne(x => x.Map).HasForeignKey(x => x.M_ID).HasPrincipalKey(x => x.M_ID);
                b.ToTable("Maps");
            });

            modelBuilder.Entity<Map_ADArea>(b =>
            {
                b.Property(x => x.Area_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.Area_EndX);

                b.Property(x => x.Area_EndY);

                b.Property(x => x.Area_StartX);

                b.Property(x => x.Area_StartY);

                b.Property(x => x.CaseID);

                b.Property(x => x.M_ID);

                b.HasKey(x => x.Area_ID);
                b.HasOne(x => x.Map).WithMany(x => x.Map_ADAreas).HasForeignKey(x => x.M_ID).HasPrincipalKey(x => x.M_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.CaseTable).WithMany(x => x.Map_ADAreas).HasForeignKey(x => x.CaseID).HasPrincipalKey(x => x.Case_ID).OnDelete(DeleteBehavior.Restrict);

                b.ToTable("Map_ADAreas");
            });

            modelBuilder.Entity<Map_BlockSpace>(b =>
            {
                b.Property(x => x.Mb_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.M_ID);

                b.Property(x => x.Mb_EndX);

                b.Property(x => x.Mb_EndY);

                b.Property(x => x.Mb_starX);

                b.Property(x => x.Mb_starY);

                b.HasKey(x => x.Mb_ID);

                b.HasOne(x => x.Map).WithMany(x => x.Map_BlockSpaces).HasForeignKey(x => x.M_ID).HasPrincipalKey(x => x.M_ID).OnDelete(DeleteBehavior.Cascade);
                b.ToTable("BlockSpaces");
            });

            modelBuilder.Entity<Order>(b =>
            {
                b.Property(x => x.O_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.A_ID);

                b.Property(x => x.O_Cancle);

                b.Property(x => x.O_Date);

                b.Property(x => x.O_TotalPrice).HasColumnType("decimal(18,4)"); ;

                b.HasKey(x => x.O_ID);
                b.HasOne(x => x.Account).WithMany(x => x.Orders).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Restrict);
                b.HasMany(x => x.OrderDetails).WithOne(x => x.Order).HasForeignKey(x => x.O_ID).HasPrincipalKey(x => x.O_ID);
                b.ToTable("Orders");
            });

            modelBuilder.Entity<OrderDetail>(b =>
            {
                b.Property(x => x.Od_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.O_ID);

                b.Property(x => x.Od_Quantity);

                b.Property(x => x.Od_Sum).HasColumnType("decimal(18,4)"); ;

                b.Property(x => x.Od_UnitPrice).HasColumnType("decimal(18,4)"); ;

                b.Property(x => x.P_ID);

                b.HasKey(x => x.Od_ID);
                b.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.O_ID).HasPrincipalKey(x => x.O_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.P_ID).HasPrincipalKey(x => x.P_ID).OnDelete(DeleteBehavior.Restrict);

                b.ToTable("OrderDetails");
            });

            modelBuilder.Entity<Partner>(b =>
            {
                b.Property(x => x.P_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.Contact)
                    .IsRequired();

                b.Property(x => x.Email)
                    .IsRequired();

                b.Property(x => x.P_Name)
                    .IsRequired();

                b.Property(x => x.Phone)
                    .IsRequired();
                b.Property(x => x.P_Note);
                b.HasKey(x => x.P_ID);
                b.HasMany(x => x.Ads).WithOne(x => x.Partner).HasForeignKey(x => x.PartnerID).HasPrincipalKey(x => x.P_ID);
                b.ToTable("Partners");
            });

            modelBuilder.Entity<Product>(b =>
            {
                b.Property(x => x.P_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.P_Date);

                b.Property(x => x.P_Describe)
                    .IsRequired();

                b.Property(x => x.P_Discontinuted);

                b.Property(x => x.P_Discount)
                    .IsRequired();

                b.Property(x => x.P_Image)
                    .IsRequired();

                b.Property(x => x.P_Instock);

                b.Property(x => x.P_Name)
                    .IsRequired();

                b.Property(x => x.P_Price);

                b.Property(x => x.P_ProductType);

                b.HasKey(x => x.P_ID);

                b.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.P_ID).HasPrincipalKey(x => x.P_ID);

                b.ToTable("Products");
            });

            modelBuilder.Entity<Report>(b =>
            {
                b.Property(x => x.R_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.A_ID);

                b.Property(x => x.R_Reason)
                    .IsRequired();

                b.Property(x => x.R_Reply)
                    .IsRequired();

                b.Property(x => x.R_ReportStatus);

                b.Property(x => x.R_ReportType);

                b.Property(x => x.R_Time);

                b.Property(x => x.ReportedA_ID);
                b.HasKey(x => x.R_ID);
                b.HasOne(x => x.Account).WithMany(x => x.Reports).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.ReportedAccount).WithMany(x => x.ReportedReports).HasForeignKey(x => x.ReportedA_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Restrict);
                b.ToTable("Reports");
            });

            modelBuilder.Entity<Society>(b =>
            {
                b.Property(x => x.S_ID)
                    .ValueGeneratedOnAdd();

                b.Property(x => x.A_ID);

                b.Property(x => x.CreateAt);

                b.Property(x => x.S_Notes)
                    .IsRequired();

                b.Property(x => x.TargetA_ID);

                b.Property(x => x.UpdateAt);

                b.HasKey(x => x.S_ID);
                b.HasOne(x => x.Account).WithMany(x => x.Societies).HasForeignKey(x => x.A_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.TargetAccount).WithMany(x => x.TargetSocieties).HasForeignKey(x => x.TargetA_ID).HasPrincipalKey(x => x.A_ID).OnDelete(DeleteBehavior.Restrict);
                b.ToTable("Societies");
            });

            for (int i = 0; i < 10; i++)
            {
                modelBuilder.Entity<UserAccount>().HasData(new UserAccount()
                {
                    A_ID = i + 1,
                    A_Name = "Test",
                    UserName = "Test",
                    UserPWD = "Test",
                    A_Gender = Gender.男,
                    Birthday = DateTime.Now,
                    A_level = 99,
                    A_Email = "Test@gmail.com",
                    A_Phone = "0900000000",
                    A_add = "Test",
                    A_RegisteredAt = DateTime.Now,
                    A_NickName = "Test",
                    A_Coin = 999999,
                    P_id = 1,
                });
            }

            modelBuilder.Entity<CardType>().HasData(
                                    new CardType()
                                    {
                                        CT_ID = 1,
                                        CT_Name = "綠界"
                                    },
                                    new CardType()
                                    {
                                        CT_ID = 2,
                                        CT_Name = "LinePay",
                                    },
                                    new CardType()
                                    {
                                        CT_ID = 3,
                                        CT_Name = "藍新",
                                    });
            modelBuilder.Entity<CardOrder>().HasData(
                        new CardOrder()
                        {
                            CO_ID = 1,
                            A_ID = 1,
                            CT_ID = 3,
                            CA_ID = 1,
                            CO_Sum = 100,
                            CO_Date = DateTime.Now,
                            CO_Cancel = false,
                            CO_Quantity = 1,
                        },
                        new CardOrder()
                        {
                            CO_ID = 2,
                            A_ID = 1,
                            CT_ID = 3,
                            CA_ID = 2,
                            CO_Sum = 400,
                            CO_Date = DateTime.Now,
                            CO_Cancel = false,
                            CO_Quantity = 1,
                        });

            modelBuilder.Entity<Card>().HasData(
                               new Card()
                               {
                                   CA_ID = 1,
                                   CA_Name = "100元換150點",
                                   CA_Price = 100,
                                   CA_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png",
                                   CA_Describe = "100元換150點",
                                   CA_Date = DateTime.Now,
                                   CA_Discontinuted = false,
                               },
                               new Card()
                               {
                                   CA_ID = 2,
                                   CA_Name = "200元換350點",
                                   CA_Price = 200,
                                   CA_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png",
                                   CA_Describe = "200元換350點",
                                   CA_Date = DateTime.Now,
                                   CA_Discontinuted = false,
                               },
                               new Card()
                               {
                                   CA_ID = 3,
                                   CA_Name = "400元換650點",
                                   CA_Price = 400,
                                   CA_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png",
                                   CA_Describe = "400元換650點",
                                   CA_Date = DateTime.Now,
                                   CA_Discontinuted = false,
                               },
                               new Card()
                               {
                                   CA_ID = 4,
                                   CA_Name = "500元換800點",
                                   CA_Price = 500,
                                   CA_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684856122/%E9%BB%9E%E6%95%B8_lihgyo.png",
                                   CA_Describe = "500元換800點",
                                   CA_Date = DateTime.Now,
                                   CA_Discontinuted = false,
                               });

            modelBuilder.Entity<Product>().HasData(
                   new Product()
                   {
                       P_ID = 1,
                       P_Name = "博麗 靈夢",
                       P_ProductType = ProductType.東方,
                       P_Price = 750,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835451/woq8pk012slwtluy8p3k.png",
                       P_Describe = "博麗神社的巫女。生來就具有強大的靈力，也是博麗神社以來靈力最強大的巫女。最喜歡坐在神社的緣側前悠閒地喝茶，罕有地天生幸運，使她解決了不少異變。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 2,
                       P_Name = "霧雨 魔理沙",
                       P_ProductType = ProductType.東方,
                       P_Price = 750,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835474/hmtyowptu1agbamv1vfh.png",
                       P_Describe = "居住於魔法森林的人類魔法使，常騎著掃把，喜歡蒐集東西，努力追趕不用修行也很強的靈夢。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 3,
                       P_Name = "東風谷 早苗",
                       P_ProductType = ProductType.東方,
                       P_Price = 750,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684835488/smyheqfg2ctqbuvleeks.png",
                       P_Describe = "守矢神社的風祝。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 4,
                       P_Name = "帕秋莉·諾雷姬",
                       P_ProductType = ProductType.東方,
                       P_Price = 750,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853351/006_00_mzeucd.png",
                       P_Describe = "已有100歲，一直都生活在紅魔館的圖書館。有哮喘的毛病。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 5,
                       P_Name = "十六夜 咲夜",
                       P_ProductType = ProductType.東方,
                       P_Price = 750,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853395/005_00_bzakdg.png",
                       P_Describe = "紅魔館的女僕長，擅長打掃。能夠無視時間的不可逆性停止時間。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 6,
                       P_Name = "小精靈",
                       P_ProductType = ProductType.其他,
                       P_Price = 350,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/113_00_jqkj0f.png",
                       P_Describe = "小精靈。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 7,
                       P_Name = "腳",
                       P_ProductType = ProductType.其他,
                       P_Price = 500,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/114_00_ajrq7u.png",
                       P_Describe = "想被踩踩看嗎?。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 8,
                       P_Name = "鬼魂",
                       P_ProductType = ProductType.其他,
                       P_Price = 500,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/122_00_xy08rk.png",
                       P_Describe = "鬼魂，可參加萬聖節。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 9,
                       P_Name = "香菇",
                       P_ProductType = ProductType.其他,
                       P_Price = 500,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684853683/126_00_boxrvt.png",
                       P_Describe = "為了生存而長出腳的香菇。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 10,
                       P_Name = "烏龜",
                       P_ProductType = ProductType.動物,
                       P_Price = 600,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/082_00_qbrhui.png",
                       P_Describe = "能快速移動的烏龜。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 11,
                       P_Name = "章魚",
                       P_ProductType = ProductType.動物,
                       P_Price = 600,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/125_00_av01za.png",
                       P_Describe = "就是那位能預測冠軍的章魚哥。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   },
                   new Product()
                   {
                       P_ID = 12,
                       P_Name = "烏鴉",
                       P_ProductType = ProductType.動物,
                       P_Price = 600,
                       P_Image = "https://res.cloudinary.com/dolqf5dmn/image/upload/v1684855469/119_00_blsy4d.png",
                       P_Describe = "黑色的烏鴉。",
                       P_Instock = 99,
                       P_Date = DateTime.Now,
                       P_Discount = 0,
                       P_Discontinuted = false,
                   });
            modelBuilder.Entity<Order>().HasData(
                   new Order()
                   {
                       O_ID = 1,
                       A_ID = 1,
                       O_Date = DateTime.Now,
                       O_TotalPrice = 750,
                       O_Cancle = false,
                   },
                   new Order()
                   {
                       O_ID = 2,
                       A_ID = 1,
                       O_Date = DateTime.Now,
                       O_TotalPrice = 600,
                       O_Cancle = false,
                   },
                   new Order()
                   {
                       O_ID = 3,
                       A_ID = 2,
                       O_Date = DateTime.Now,
                       O_TotalPrice = 500,
                       O_Cancle = false,
                   },
                   new Order()
                   {
                       O_ID = 4,
                       A_ID = 3,
                       O_Date = DateTime.Now,
                       O_TotalPrice = 500,
                       O_Cancle = false,
                   });
            modelBuilder.Entity<OrderDetail>().HasData(
                               new OrderDetail()
                               {
                                   Od_ID = 1,
                                   O_ID = 1,
                                   P_ID = 1,
                                   Od_UnitPrice = 750,
                                   Od_Sum = 750,
                                   Od_Quantity = 1,
                               },
                               new OrderDetail()
                               {
                                   Od_ID = 2,
                                   O_ID = 2,
                                   P_ID = 10,
                                   Od_UnitPrice = 600,
                                   Od_Sum = 600,
                                   Od_Quantity = 1,
                               },
                               new OrderDetail()
                               {
                                   Od_ID = 3,
                                   O_ID = 3,
                                   P_ID = 9,
                                   Od_UnitPrice = 500,
                                   Od_Sum = 500,
                                   Od_Quantity = 1,
                               },
                               new OrderDetail()
                               {
                                   Od_ID = 4,
                                   O_ID = 4,
                                   P_ID = 7,
                                   Od_UnitPrice = 500,
                                   Od_Sum = 500,
                                   Od_Quantity = 1,
                               });
            modelBuilder.Entity<CaseTable>().HasData(
                new CaseTable()
                {
                    Case_ID = 1,
                    Case_Name = "豪華蛋黃熱區",
                    Case_PricePerDay = 250,
                },
                new CaseTable()
                {
                    Case_ID = 2,
                    Case_Name = "中等曝光區",
                    Case_PricePerDay = 200,
                },
                new CaseTable()
                {
                    Case_ID = 3,
                    Case_Name = "經濟實惠區",
                    Case_PricePerDay = 150,
                },
                new CaseTable()
                {
                    Case_ID = 4,
                    Case_Name = "限時特惠專區",
                    Case_PricePerDay = 100,
                });

            modelBuilder.Entity<Partner>().HasData(
                new Partner()
                {
                    P_ID = 1,
                    P_Name = "Apple",
                    Contact = "林小明",
                    Email = "apple@gmail.com",
                    Phone = "0912345678",
                    P_Note = "好合作",
                },
                new Partner()
                {
                    P_ID = 2,
                    P_Name = "Google",
                    Contact = "陳大名",
                    Email = "google@gmail.com",
                    Phone = "0923456789",
                    P_Note = "溝通良好",
                },
                new Partner()
                {
                    P_ID = 3,
                    P_Name = "Amazon",
                    Contact = "王小美",
                    Email = "amazon@gmail.com",
                    Phone = "0934567890",
                    P_Note = "產品品質不錯",
                },
                new Partner()
                {
                    P_ID = 4,
                    P_Name = "Microsoft",
                    Contact = "李志明",
                    Email = "microsoft@gmail.com",
                    Phone = "0912345678",
                    P_Note = "合作愉快",
                },
                new Partner()
                {
                    P_ID = 5,
                    P_Name = "Facebook",
                    Contact = "蔡佳玲",
                    Email = "facebook@gmail.com",
                    Phone = "0923456789",
                    P_Note = "回覆速度快",
                },
                new Partner()
                {
                    P_ID = 6,
                    P_Name = "Netflix",
                    Contact = "林小華",
                    Email = "netflix@gmail.com",
                    Phone = "0934567890",
                    P_Note = "服務很好",
                },
                new Partner()
                {
                    P_ID = 7,
                    P_Name = "Tesla",
                    Contact = "陳小明",
                    Email = "tesla@gmail.com",
                    Phone = "0912345678",
                    P_Note = "值得信賴",
                },
                new Partner()
                {
                    P_ID = 8,
                    P_Name = "Twitter",
                    Contact = "蔡小玲",
                    Email = "twitter@gmail.com",
                    Phone = "0923456789",
                    P_Note = "溝通良好",
                },
                new Partner()
                {
                    P_ID = 9,
                    P_Name = "Uber",
                    Contact = "李小明",
                    Email = "uber@gmail.com",
                    Phone = "0934567890",
                    P_Note = "好合作",
                },
                new Partner()
                {
                    P_ID = 10,
                    P_Name = "Airbnb",
                    Contact = "林小美",
                    Email = "airbnb@gmail.com",
                    Phone = "0912345678",
                    P_Note = "服務很好",
                },
                new Partner()
                {
                    P_ID = 11,
                    P_Name = "LinkedIn",
                    Contact = "陳大名",
                    Email = "linkedin@gmail.com",
                    Phone = "0923456789",
                    P_Note = "回覆速度快",
                },
                new Partner()
                {
                    P_ID = 12,
                    P_Name = "Dropbox",
                    Contact = "王小華",
                    Email = "dropbox@gmail.com",
                    Phone = "0934567890",
                    P_Note = "值得信賴",
                },
                new Partner()
                {
                    P_ID = 13,
                    P_Name = "Twitter",
                    Contact = "蔡小玲",
                    Email = "twitter@gmail.com",
                    Phone = "0923456789",
                    P_Note = "溝通良好",
                },
                new Partner()
                {
                    P_ID = 14,
                    P_Name = "Salesforce",
                    Contact = "陳小明",
                    Email = "salesforce@gmail.com",
                    Phone = "0912345678",
                    P_Note = "產品品質不錯",
                },
                new Partner()
                {
                    P_ID = 15,
                    P_Name = "Adobe",
                    Contact = "蔡佳玲",
                    Email = "adobe@gmail.com",
                    Phone = "0923456789",
                    P_Note = "回覆速度快",
                },
                new Partner()
                {
                    P_ID = 16,
                    P_Name = "PayPal",
                    Contact = "林小華",
                    Email = "paypal@gmail.com",
                    Phone = "0934567890",
                    P_Note = "合作愉快",
                },
                new Partner()
                {
                    P_ID = 17,
                    P_Name = "Oracle",
                    Contact = "陳小明",
                    Email = "oracle@gmail.com",
                    Phone = "0912345678",
                    P_Note = "回覆速度快",
                },
                new Partner()
                {
                    P_ID = 18,
                    P_Name = "IBM",
                    Contact = "蔡小玲",
                    Email = "ibm@gmail.com",
                    Phone = "0923456789",
                    P_Note = "好合作",
                },
                new Partner()
                {
                    P_ID = 19,
                    P_Name = "Intel",
                    Contact = "李小明",
                    Email = "intel@gmail.com",
                    Phone = "0934567890",
                    P_Note = "值得信賴",
                },
                new Partner()
                {
                    P_ID = 20,
                    P_Name = "HP",
                    Contact = "林小美",
                    Email = "hp@gmail.com",
                    Phone = "0912345678",
                    P_Note = "溝通良好",
                }
                );

            modelBuilder.Entity<Ads_OrderStatus>().HasData(
                new Ads_OrderStatus()
                {
                    OS_ID = 1,
                    OS_Name = "完全履約",
                    OS_FullfillmentRate = 1,
                    OS_PaymentMultiplier = 1,
                }

                );


            for (int i = 1; i < 30; i++)
            {
                Random PRnd = new Random();
                Random CRnd = new Random();
                Random SRnd = new Random();
                Random ERnd = new Random();
                Random ClickRnd = new Random();

                DateTime StartDate = new DateTime(2022, 1, 1);
                int StartDaysToAdd = SRnd.Next(365);
                int EndDaysToAdd = ERnd.Next(7, 25);

                DateTime StartTime = StartDate.AddDays(StartDaysToAdd);
                DateTime EndTime = StartTime.AddDays(EndDaysToAdd);
                int DayCount = (int)(EndTime - StartTime).TotalDays;

                modelBuilder.Entity<Ads>().HasData(
                new Ads()
                {
                    Ad_ID = i,
                    PartnerID = PRnd.Next(1, 21),
                    CaseID = CRnd.Next(1, 5),
                    Ad_StartTime = StartTime,
                    Ad_EndTime = EndTime,
                    Ad_DayCount = DayCount,
                    Ad_ImageURL = $"AD_{i}.jpg",
                    Ad_TargetURL = $"http://exmple/.com{i}",
                    Ad_Clicks = ClickRnd.Next(30, 240),
                    Ad_Description = "",
                    Ad_PaymentDueDate = StartTime.AddDays(-2),
                    Ad_TimeOfPayment = StartTime.AddDays(-2),
                    Ad_ActiveStatus = 1,
                    OS_ID = 1,
                    AD_FinalPaymentAmount = 15000,
                });
            };

            int j = 5;
            for (int i = 5; i < 14; i++)
            {
                Random rnd = new Random();
                modelBuilder.Entity<Order>().HasData(
                    new Order()
                    {
                        O_ID = i,
                        A_ID = rnd.Next(1, 10),
                        O_Date = DateTime.Now,
                        O_TotalPrice = 700,
                        O_Cancle = false,
                    });
                modelBuilder.Entity<OrderDetail>().HasData(
                           new OrderDetail()
                           {
                               Od_ID = j,
                               O_ID = i,
                               P_ID = rnd.Next(1, 10),
                               Od_UnitPrice = 699,
                               Od_Sum = 699,
                               Od_Quantity = 1,
                           });
                j++;
            }
        }

        public DbSet<UserAccount> Accounts { get; set; } = default!;
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
        public DbSet<Card> Cards { get; set; } = default!;
        public DbSet<CardOrder> CardOrders { get; set; } = default!;
        public DbSet<CardType> CardTypes { get; set; } = default!;
        public DbSet<Ads_OrderStatus> Ads_OrderStatuses { get; set; } = default!;
    }
}