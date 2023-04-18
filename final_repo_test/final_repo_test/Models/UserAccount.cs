using final_repo_test.Data.Enum;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class UserAccount
    {
        [Key]
        public int A_ID { get; set; } = default!;
        public string A_Name { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string UserPWD { get; set; } = default!;
        public Gender A_Gender { get; set; } = default!;
        [Column(TypeName = "Date")]
        public DateTime Birthday { get; set; } = default!;
        [ForeignKey("Product")]
        public int P_id { get; set; } = default!;
        public Product Product { get; set; } = default!;
        public int A_level { get; set; } = default!;
        public string A_Email { get; set; } = default!;
        public string A_Phone { get; set; } = default!;
        public string A_add { get; set; } = default!;
        [Column(TypeName = "Date")]
        public DateTime A_RegisteredAt { get; set; } = default!;
        public string A_NickName { get; set; } = default!;
        public int A_Coin { get; set; } = default!;

        public ICollection<CardOrder>? CardOrders { get; set; }
        public ICollection<Order>? Orders { get; set; }
        //[InverseProperty(nameof(Report.Account))]
        public ICollection<Report>? Reports { get; set; }
        //[InverseProperty(nameof(Report.ReportedAccount))]
        public ICollection<Report>? ReportedReports { get; set; }
        //[InverseProperty(nameof(Society.Account))]
        public ICollection<Society>? Societies { get; set; }
        //[InverseProperty(nameof(Society.TargetAccount))]
        public ICollection<Society>? TargetSocieties { get; set; }
        public ICollection<DebugLog>? DebugLogs { get; set; }
        public ICollection<LoginStaus>? LoginStaus { get; set; }

    }
}
