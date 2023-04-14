using final_repo_test.Models;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<DebugLog> DebugLogs { get; set; }
        public DbSet<LoginStaus> LoginStaus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Society> Societies { get; set; }
    }
}
