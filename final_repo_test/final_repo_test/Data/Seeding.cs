using final_repo_test.Data.Enum;
using final_repo_test.Models;

namespace final_repo_test.Data
{
    public class Seeding
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();
                if (!context.Accounts.Any())
                {
                    context.Accounts.AddRange(new List<Account>
                    {
                        new Account()
                        {
                            A_ID = 1,
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
                        }
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
